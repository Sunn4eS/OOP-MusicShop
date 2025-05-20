using MusicStore.Instruments;

namespace MusicStore.Encrypt;

public interface IPluginCipher
{
    public void Encrypt(InstrumentsData instruments, FileStream fileStream, byte[] key);
    public InstrumentsData Decrypt(byte[] key, OpenFileDialog openFileDialog);

}