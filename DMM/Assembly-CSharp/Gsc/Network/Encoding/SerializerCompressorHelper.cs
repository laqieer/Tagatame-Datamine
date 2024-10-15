// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Encoding.SerializerCompressorHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.IO;

#nullable disable
namespace Gsc.Network.Encoding
{
  [Token(Token = "0x20035AD")]
  public static class SerializerCompressorHelper
  {
    [Token(Token = "0x600EE4B")]
    public static byte[] Encode<T>(
      T objectToEncode,
      bool serializeWithMessagePack = false,
      CompressMode compressMode = CompressMode.Lz4,
      bool useFromJson = false)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x600EE4C")]
    public static T Decode<T>(
      byte[] dataToDecode,
      bool deserializeWithMessagePack = false,
      CompressMode decompressMode = CompressMode.Lz4,
      bool useToJson = false,
      bool printExceptions = true)
    {
      return (T) null;
    }

    [Token(Token = "0x600EE4D")]
    private static void LZ4Serialize<T>(Stream outputStream, T objectToSerialize)
    {
    }

    [Token(Token = "0x600EE4E")]
    [Address(RVA = "0xB116C0", Offset = "0xB104C0", VA = "0x10B116C0")]
    private static void LZ4SerializeFromJson(Stream outputStream, string jsonToSerialize)
    {
    }

    [Token(Token = "0x600EE4F")]
    private static void Serialize<T>(Stream outputStream, T objectToSerialize)
    {
    }

    [Token(Token = "0x600EE50")]
    [Address(RVA = "0xB11700", Offset = "0xB10500", VA = "0x10B11700")]
    private static void SerializeFromJson(Stream outputStream, string jsonToSerialize)
    {
    }

    [Token(Token = "0x600EE51")]
    private static T LZ4Deserialize<T>(Stream inputStream) => (T) null;

    [Token(Token = "0x600EE52")]
    [Address(RVA = "0xB11560", Offset = "0xB10360", VA = "0x10B11560")]
    private static string LZ4DeserializeToJson(Stream inputStream) => (string) null;

    [Token(Token = "0x600EE53")]
    private static T Deserialize<T>(Stream inputStream) => (T) null;

    [Token(Token = "0x600EE54")]
    [Address(RVA = "0xB11400", Offset = "0xB10200", VA = "0x10B11400")]
    private static string DeserializeToJson(Stream inputStream) => (string) null;
  }
}
