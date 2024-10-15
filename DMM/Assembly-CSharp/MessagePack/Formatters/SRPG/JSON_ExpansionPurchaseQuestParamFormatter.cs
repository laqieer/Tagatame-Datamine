// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ExpansionPurchaseQuestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200069F")]
  public sealed class JSON_ExpansionPurchaseQuestParamFormatter : 
    IMessagePackFormatter<JSON_ExpansionPurchaseQuestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D2B")]
    [Address(RVA = "0xBF9280", Offset = "0xBF8080", VA = "0x10BF9280")]
    public JSON_ExpansionPurchaseQuestParamFormatter()
    {
    }

    [Token(Token = "0x6001D2C")]
    [Address(RVA = "0xBF90A0", Offset = "0xBF7EA0", VA = "0x10BF90A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ExpansionPurchaseQuestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D2D")]
    [Address(RVA = "0xBF8D60", Offset = "0xBF7B60", VA = "0x10BF8D60", Slot = "5")]
    public JSON_ExpansionPurchaseQuestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ExpansionPurchaseQuestParam) null;
    }
  }
}
