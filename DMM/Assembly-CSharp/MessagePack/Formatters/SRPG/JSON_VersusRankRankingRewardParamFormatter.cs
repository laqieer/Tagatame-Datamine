// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusRankRankingRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000976")]
  public sealed class JSON_VersusRankRankingRewardParamFormatter : 
    IMessagePackFormatter<JSON_VersusRankRankingRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400177C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400177D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025B0")]
    [Address(RVA = "0xE2ED60", Offset = "0xE2DB60", VA = "0x10E2ED60")]
    public JSON_VersusRankRankingRewardParamFormatter()
    {
    }

    [Token(Token = "0x60025B1")]
    [Address(RVA = "0xE2EBC0", Offset = "0xE2D9C0", VA = "0x10E2EBC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusRankRankingRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025B2")]
    [Address(RVA = "0xE2E840", Offset = "0xE2D640", VA = "0x10E2E840", Slot = "5")]
    public JSON_VersusRankRankingRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusRankRankingRewardParam) null;
    }
  }
}
