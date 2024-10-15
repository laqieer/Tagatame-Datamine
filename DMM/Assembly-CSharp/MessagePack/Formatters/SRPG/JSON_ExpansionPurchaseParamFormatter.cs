// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ExpansionPurchaseParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200069D")]
  public sealed class JSON_ExpansionPurchaseParamFormatter : 
    IMessagePackFormatter<JSON_ExpansionPurchaseParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D25")]
    [Address(RVA = "0xBF83C0", Offset = "0xBF71C0", VA = "0x10BF83C0")]
    public JSON_ExpansionPurchaseParamFormatter()
    {
    }

    [Token(Token = "0x6001D26")]
    [Address(RVA = "0xBF8050", Offset = "0xBF6E50", VA = "0x10BF8050", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ExpansionPurchaseParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D27")]
    [Address(RVA = "0xBF7BB0", Offset = "0xBF69B0", VA = "0x10BF7BB0", Slot = "5")]
    public JSON_ExpansionPurchaseParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ExpansionPurchaseParam) null;
    }
  }
}
