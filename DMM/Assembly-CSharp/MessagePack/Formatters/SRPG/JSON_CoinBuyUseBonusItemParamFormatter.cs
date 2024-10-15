// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CoinBuyUseBonusItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000657")]
  public sealed class JSON_CoinBuyUseBonusItemParamFormatter : 
    IMessagePackFormatter<JSON_CoinBuyUseBonusItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001146")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001147")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C53")]
    [Address(RVA = "0xBDF420", Offset = "0xBDE220", VA = "0x10BDF420")]
    public JSON_CoinBuyUseBonusItemParamFormatter()
    {
    }

    [Token(Token = "0x6001C54")]
    [Address(RVA = "0xBDF2C0", Offset = "0xBDE0C0", VA = "0x10BDF2C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CoinBuyUseBonusItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C55")]
    [Address(RVA = "0xBDEF70", Offset = "0xBDDD70", VA = "0x10BDEF70", Slot = "5")]
    public JSON_CoinBuyUseBonusItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CoinBuyUseBonusItemParam) null;
    }
  }
}
