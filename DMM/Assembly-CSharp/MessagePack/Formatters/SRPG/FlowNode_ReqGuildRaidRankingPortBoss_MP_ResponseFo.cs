// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidRankingPortBoss_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B8")]
  public sealed class FlowNode_ReqGuildRaidRankingPortBoss_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidRankingPortBoss.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001600")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001601")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002376")]
    [Address(RVA = "0xDAF880", Offset = "0xDAE680", VA = "0x10DAF880")]
    public FlowNode_ReqGuildRaidRankingPortBoss_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002377")]
    [Address(RVA = "0xDAF590", Offset = "0xDAE390", VA = "0x10DAF590", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidRankingPortBoss.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002378")]
    [Address(RVA = "0xDAF160", Offset = "0xDADF60", VA = "0x10DAF160", Slot = "5")]
    public FlowNode_ReqGuildRaidRankingPortBoss.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidRankingPortBoss.MP_Response) null;
    }
  }
}
