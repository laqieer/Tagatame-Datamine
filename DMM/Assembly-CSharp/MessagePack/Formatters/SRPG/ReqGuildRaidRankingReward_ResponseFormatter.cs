// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidRankingReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B06")]
  public sealed class ReqGuildRaidRankingReward_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidRankingReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A9C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A9D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A60")]
    [Address(RVA = "0xF27980", Offset = "0xF26780", VA = "0x10F27980")]
    public ReqGuildRaidRankingReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A61")]
    [Address(RVA = "0xF277A0", Offset = "0xF265A0", VA = "0x10F277A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidRankingReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A62")]
    [Address(RVA = "0xF27450", Offset = "0xF26250", VA = "0x10F27450", Slot = "5")]
    public ReqGuildRaidRankingReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidRankingReward.Response) null;
    }
  }
}
