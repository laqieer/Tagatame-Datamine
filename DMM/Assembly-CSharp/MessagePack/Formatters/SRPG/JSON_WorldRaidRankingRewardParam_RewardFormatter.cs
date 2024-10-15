// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidRankingRewardParam_RewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009E3")]
  public sealed class JSON_WorldRaidRankingRewardParam_RewardFormatter : 
    IMessagePackFormatter<JSON_WorldRaidRankingRewardParam.Reward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001856")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001857")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026F7")]
    [Address(RVA = "0xE86EB0", Offset = "0xE85CB0", VA = "0x10E86EB0")]
    public JSON_WorldRaidRankingRewardParam_RewardFormatter()
    {
    }

    [Token(Token = "0x60026F8")]
    [Address(RVA = "0xE86D50", Offset = "0xE85B50", VA = "0x10E86D50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidRankingRewardParam.Reward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026F9")]
    [Address(RVA = "0xE86A00", Offset = "0xE85800", VA = "0x10E86A00", Slot = "5")]
    public JSON_WorldRaidRankingRewardParam.Reward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidRankingRewardParam.Reward) null;
    }
  }
}
