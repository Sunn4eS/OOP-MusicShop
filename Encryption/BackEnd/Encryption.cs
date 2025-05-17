using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using MusicStore.Encrypt;
using MusicStore.Instruments;

namespace Encryption.BackEnd
{
    public class Encryption : IPluginCipher
    {
        public static byte[] plainText;
        public static byte[] cipherText;
        public static byte[] generatedKey;
        //private static byte[] key = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1, 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1];
        
        
        
        public void Encrypt(InstrumentsData instruments, FileStream fileStream, byte[] key)
        {
            byte[] bytes = JsonSerializer.SerializeToUtf8Bytes(instruments.InstrumentsList);
            

            plainText = new byte[bytes.Length * 8];
            generatedKey = new byte[bytes.Length * 8];
            
            
            for (int i = 0; i < bytes.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    plainText[i * 8 + j] = (byte)((bytes[i] >> j) & 0x1);
                }
            } 
           generatedKey = Key.Generate(key, plainText.Length);
            cipherText = new byte[plainText.Length];
            for (int i = 0; i < cipherText.Length; i++)
            {
                cipherText[i] = (byte)(generatedKey[i] ^ plainText[i]);
            }
            fileStream.Write(cipherText, 0, cipherText.Length);
        }
    }
}
