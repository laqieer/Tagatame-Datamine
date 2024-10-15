// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CoinBuyUseBonusRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000658")]
  public sealed class JSON_CoinBuyUseBonusRewardParamFormatter : 
    IMessagePackFormatter<JSON_CoinBuyUseBonusRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001148")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001149")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C56")]
    [Address(RVA = "0xBDFB30", Offset = "0xBDE930", VA = "0x10BDFB30")]
    public JSON_CoinBuyUseBonusRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001C57")]
    [Address(RVA = "0xBDF950", Offset = "0xBDE750", VA = "0x10BDF950", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CoinBuyUseBonusRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C58")]
    [Address(RVA = "0xBDF610", Offset = "0xBDE410", VA = "0x10BDF610", Slot = "5")]
    public JSON_CoinBuyUseBonusRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CoinBuyUseBonusRewardParam) null;
    }
  }
}
