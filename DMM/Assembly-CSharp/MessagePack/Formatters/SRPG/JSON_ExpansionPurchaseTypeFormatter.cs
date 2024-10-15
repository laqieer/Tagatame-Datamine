// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ExpansionPurchaseTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200069C")]
  public sealed class JSON_ExpansionPurchaseTypeFormatter : 
    IMessagePackFormatter<JSON_ExpansionPurchaseType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D22")]
    [Address(RVA = "0xBF9920", Offset = "0xBF8720", VA = "0x10BF9920")]
    public JSON_ExpansionPurchaseTypeFormatter()
    {
    }

    [Token(Token = "0x6001D23")]
    [Address(RVA = "0xBF9780", Offset = "0xBF8580", VA = "0x10BF9780", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ExpansionPurchaseType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D24")]
    [Address(RVA = "0xBF9400", Offset = "0xBF8200", VA = "0x10BF9400", Slot = "5")]
    public JSON_ExpansionPurchaseType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ExpansionPurchaseType) null;
    }
  }
}
