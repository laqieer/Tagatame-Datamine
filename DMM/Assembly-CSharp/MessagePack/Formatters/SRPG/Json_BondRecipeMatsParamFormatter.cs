// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_BondRecipeMatsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006B8")]
  public sealed class Json_BondRecipeMatsParamFormatter : 
    IMessagePackFormatter<Json_BondRecipeMatsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001208")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001209")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D76")]
    [Address(RVA = "0xC21750", Offset = "0xC20550", VA = "0x10C21750")]
    public Json_BondRecipeMatsParamFormatter()
    {
    }

    [Token(Token = "0x6001D77")]
    [Address(RVA = "0xC21620", Offset = "0xC20420", VA = "0x10C21620", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_BondRecipeMatsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D78")]
    [Address(RVA = "0xC21310", Offset = "0xC20110", VA = "0x10C21310", Slot = "5")]
    public Json_BondRecipeMatsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_BondRecipeMatsParam) null;
    }
  }
}
