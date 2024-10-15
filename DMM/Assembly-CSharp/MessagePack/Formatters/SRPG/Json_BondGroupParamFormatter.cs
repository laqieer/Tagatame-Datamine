// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondGroupParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B1")]
  public sealed class Json_BondGroupParamFormatter : 
    IMessagePackFormatter<Json_BondGroupParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D61")]
    [Address(RVA = "0xC0CAC0", Offset = "0xC0B8C0", VA = "0x10C0CAC0")]
    public Json_BondGroupParamFormatter()
    {
    }

    [Token(Token = "0x6001D62")]
    [Address(RVA = "0xC0C740", Offset = "0xC0B540", VA = "0x10C0C740", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondGroupParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D63")]
    [Address(RVA = "0xC0C220", Offset = "0xC0B020", VA = "0x10C0C220", Slot = "5")]
    public Json_BondGroupParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondGroupParam) null;
    }
  }
}
