// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_RuneDedicatedDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005B5")]
  public sealed class Json_RuneDedicatedDataFormatter : 
    IMessagePackFormatter<Json_RuneDedicatedData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001002")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001003")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A6D")]
    [Address(RVA = "0x79FC80", Offset = "0x79EA80", VA = "0x1079FC80")]
    public Json_RuneDedicatedDataFormatter()
    {
    }

    [Token(Token = "0x6001A6E")]
    [Address(RVA = "0x79FBC0", Offset = "0x79E9C0", VA = "0x1079FBC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_RuneDedicatedData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A6F")]
    [Address(RVA = "0x79F900", Offset = "0x79E700", VA = "0x1079F900", Slot = "5")]
    public Json_RuneDedicatedData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_RuneDedicatedData) null;
    }
  }
}
