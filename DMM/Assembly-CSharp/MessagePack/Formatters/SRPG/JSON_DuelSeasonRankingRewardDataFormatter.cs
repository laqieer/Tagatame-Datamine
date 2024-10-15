// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelSeasonRankingRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200090A")]
  public sealed class JSON_DuelSeasonRankingRewardDataFormatter : 
    IMessagePackFormatter<JSON_DuelSeasonRankingRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600246C")]
    [Address(RVA = "0xDE2410", Offset = "0xDE1210", VA = "0x10DE2410")]
    public JSON_DuelSeasonRankingRewardDataFormatter()
    {
    }

    [Token(Token = "0x600246D")]
    [Address(RVA = "0xDE2240", Offset = "0xDE1040", VA = "0x10DE2240", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelSeasonRankingRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600246E")]
    [Address(RVA = "0xDE1E90", Offset = "0xDE0C90", VA = "0x10DE1E90", Slot = "5")]
    public JSON_DuelSeasonRankingRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelSeasonRankingRewardData) null;
    }
  }
}
