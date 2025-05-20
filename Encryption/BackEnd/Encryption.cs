using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using MusicStore.Encrypt;
using MusicStore.Instruments;
using MusicStore.Types;
using MusicStore;
using Type = MusicStore.Types.Type;

namespace Encryption.BackEnd
{
    public class Encryption : IPluginCipher
    {
        public static byte[] plainText;
        public static byte[] cipherText;
        public static byte[] generatedKey;
        
        
        
        public void Encrypt(InstrumentsData instruments, FileStream fileStream, byte[] key)
        {
           //byte[] bytes = Convert.SerializeDataContract(instruments);
            byte[] bytes = Convert.Serialize(instruments, Type.GetKnownInstrumentTypes());

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

       public InstrumentsData Decrypt(byte[] key, OpenFileDialog openEncDialog)
{
    InstrumentsData newList = null; // Initialize to null for error handling.
    if (openEncDialog.ShowDialog() == DialogResult.OK)
    {
        try // Add a try-catch block for error handling
        {
            cipherText = File.ReadAllBytes(openEncDialog.FileName);
            
            generatedKey = Key.Generate(key, cipherText.Length);
            plainText = new byte[cipherText.Length];
            for (int i = 0; i < plainText.Length; i++)
            {
                plainText[i] = (byte)(generatedKey[i] ^ cipherText[i]);
            }

            byte[] arr = Convert.ConvertToBytes(plainText);
             
            //newList = Convert.DeserializeDataContract<InstrumentsData>(arr);
            newList = Convert.Deserialize(arr, Type.GetKnownInstrumentTypes()); 
            if (newList == null)
            {
                 Console.WriteLine("Deserialization failed: The JSON string may be invalid.");
                 return null; // Or throw an exception, depending on your error handling strategy
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred during decryption or deserialization: {ex.Message}");
            return null; // Returning null might be appropriate, depending on your application's logic.
        }
    }
    return newList;
}

    }
}
