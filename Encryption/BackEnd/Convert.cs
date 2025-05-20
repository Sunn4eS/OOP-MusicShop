using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using MusicStore.Instruments;

namespace Encryption.BackEnd
{
    internal static class Convert
    {
        

    /*public static byte[] SerializeDataContract<T>(T obj)
    {
        DataContractSerializer serializer = new DataContractSerializer(typeof(T));
        using MemoryStream ms = new MemoryStream();
        {
            serializer.WriteObject(ms, obj);
            return ms.ToArray();
        }
    }*/
    
    public static byte[] Serialize(InstrumentsData data, List<Type> knownTypes)
    {
        var serializer = new DataContractSerializer(typeof(InstrumentsData), knownTypes);
        using var ms = new MemoryStream();
        serializer.WriteObject(ms, data);
        return ms.ToArray();
    }

    
    /*public static T DeserializeDataContract<T>(byte[] data)
    {
        DataContractSerializer serializer = new DataContractSerializer(typeof(T));
        using MemoryStream ms = new MemoryStream(data);
        {
            return (T)serializer.ReadObject(ms);
        }
    }*/
    public static InstrumentsData Deserialize(byte[] bytes, List<Type> knownTypes)
    {
        var serializer = new DataContractSerializer(typeof(InstrumentsData), knownTypes);
        using var ms = new MemoryStream(bytes);
        return (InstrumentsData)serializer.ReadObject(ms)!;
    }

        public static byte[] ConvertToBytes(byte[] binaryData)
        {
            int byteLength = binaryData.Length / 8;
            byte[] bytes = new byte[byteLength];
            for (int i = 0; i < byteLength; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (binaryData[i * 8 + j] == 1)
                    {
                        bytes[i] |= (byte)(1 << j);
                    }
                }
            }
            return bytes;
        }
    }
}
