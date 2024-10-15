// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidRankingPort_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200093F")]
  public sealed class FlowNode_ReqGuildRaidRankingPort_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidRankingPort.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400170E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400170F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600250B")]
    [Address(RVA = "0xE0DA50", Offset = "0xE0C850", VA = "0x10E0DA50")]
    public FlowNode_ReqGuildRaidRankingPort_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600250C")]
    [Address(RVA = "0xE0D760", Offset = "0xE0C560", VA = "0x10E0D760", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidRankingPort.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600250D")]
    [Address(RVA = "0xE0D330", Offset = "0xE0C130", VA = "0x10E0D330", Slot = "5")]
    public FlowNode_ReqGuildRaidRankingPort.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidRankingPort.MP_Response) null;
    }
  }
}
