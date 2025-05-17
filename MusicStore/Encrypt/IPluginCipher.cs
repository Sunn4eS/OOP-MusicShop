using MusicStore.Instruments;

namespace MusicStore.Encrypt;

public interface IPluginCipher
{
    public void Encrypt(InstrumentsData instruments, FileStream fileStream, byte[] key);
    //  public void Decrypt(InstrumentsData instruments, FileStream fileStream, byte[] key) { }

}