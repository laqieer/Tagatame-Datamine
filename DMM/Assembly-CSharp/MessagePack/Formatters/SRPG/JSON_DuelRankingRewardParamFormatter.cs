// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelRankingRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000808")]
  public sealed class JSON_DuelRankingRewardParamFormatter : 
    IMessagePackFormatter<JSON_DuelRankingRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002166")]
    [Address(RVA = "0xD41CF0", Offset = "0xD40AF0", VA = "0x10D41CF0")]
    public JSON_DuelRankingRewardParamFormatter()
    {
    }

    [Token(Token = "0x6002167")]
    [Address(RVA = "0xD41B10", Offset = "0xD40910", VA = "0x10D41B10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelRankingRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002168")]
    [Address(RVA = "0xD417D0", Offset = "0xD405D0", VA = "0x10D417D0", Slot = "5")]
    public JSON_DuelRankingRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelRankingRewardParam) null;
    }
  }
}
