// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CoinBuyUseBonusParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000654")]
  public sealed class JSON_CoinBuyUseBonusParamFormatter : 
    IMessagePackFormatter<JSON_CoinBuyUseBonusParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001140")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001141")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C4A")]
    [Address(RVA = "0xBD09C0", Offset = "0xBCF7C0", VA = "0x10BD09C0")]
    public JSON_CoinBuyUseBonusParamFormatter()
    {
    }

    [Token(Token = "0x6001C4B")]
    [Address(RVA = "0xBD0750", Offset = "0xBCF550", VA = "0x10BD0750", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CoinBuyUseBonusParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C4C")]
    [Address(RVA = "0xBD0310", Offset = "0xBCF110", VA = "0x10BD0310", Slot = "5")]
    public JSON_CoinBuyUseBonusParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CoinBuyUseBonusParam) null;
    }
  }
}
