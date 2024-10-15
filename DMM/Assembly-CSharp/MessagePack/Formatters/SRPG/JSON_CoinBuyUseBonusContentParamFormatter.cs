// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CoinBuyUseBonusContentParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000655")]
  public sealed class JSON_CoinBuyUseBonusContentParamFormatter : 
    IMessagePackFormatter<JSON_CoinBuyUseBonusContentParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001142")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001143")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C4D")]
    [Address(RVA = "0xBD00B0", Offset = "0xBCEEB0", VA = "0x10BD00B0")]
    public JSON_CoinBuyUseBonusContentParamFormatter()
    {
    }

    [Token(Token = "0x6001C4E")]
    [Address(RVA = "0xBCFED0", Offset = "0xBCECD0", VA = "0x10BCFED0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CoinBuyUseBonusContentParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C4F")]
    [Address(RVA = "0xBCFB20", Offset = "0xBCE920", VA = "0x10BCFB20", Slot = "5")]
    public JSON_CoinBuyUseBonusContentParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CoinBuyUseBonusContentParam) null;
    }
  }
}
