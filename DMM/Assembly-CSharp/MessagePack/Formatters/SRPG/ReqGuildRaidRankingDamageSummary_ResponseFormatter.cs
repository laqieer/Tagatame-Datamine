// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGuildRaidRankingDamageSummary_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A6D")]
  public sealed class ReqGuildRaidRankingDamageSummary_ResponseFormatter : 
    IMessagePackFormatter<ReqGuildRaidRankingDamageSummary.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400196A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400196B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002895")]
    [Address(RVA = "0xED3D40", Offset = "0xED2B40", VA = "0x10ED3D40")]
    public ReqGuildRaidRankingDamageSummary_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002896")]
    [Address(RVA = "0xED3B90", Offset = "0xED2990", VA = "0x10ED3B90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGuildRaidRankingDamageSummary.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002897")]
    [Address(RVA = "0xED3880", Offset = "0xED2680", VA = "0x10ED3880", Slot = "5")]
    public ReqGuildRaidRankingDamageSummary.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGuildRaidRankingDamageSummary.Response) null;
    }
  }
}
