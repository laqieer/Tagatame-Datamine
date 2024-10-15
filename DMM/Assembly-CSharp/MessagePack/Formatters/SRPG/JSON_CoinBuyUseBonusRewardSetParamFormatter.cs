// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CoinBuyUseBonusRewardSetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000656")]
  public sealed class JSON_CoinBuyUseBonusRewardSetParamFormatter : 
    IMessagePackFormatter<JSON_CoinBuyUseBonusRewardSetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001144")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001145")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C50")]
    [Address(RVA = "0xBE01D0", Offset = "0xBDEFD0", VA = "0x10BE01D0")]
    public JSON_CoinBuyUseBonusRewardSetParamFormatter()
    {
    }

    [Token(Token = "0x6001C51")]
    [Address(RVA = "0xBDFFF0", Offset = "0xBDEDF0", VA = "0x10BDFFF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CoinBuyUseBonusRewardSetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C52")]
    [Address(RVA = "0xBDFCB0", Offset = "0xBDEAB0", VA = "0x10BDFCB0", Slot = "5")]
    public JSON_CoinBuyUseBonusRewardSetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CoinBuyUseBonusRewardSetParam) null;
    }
  }
}
