// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B07")]
  public sealed class FlowNode_ReqGuildRaidReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A9E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A9F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A63")]
    [Address(RVA = "0xF33CC0", Offset = "0xF32AC0", VA = "0x10F33CC0")]
    public FlowNode_ReqGuildRaidReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A64")]
    [Address(RVA = "0xF339D0", Offset = "0xF327D0", VA = "0x10F339D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A65")]
    [Address(RVA = "0xF335A0", Offset = "0xF323A0", VA = "0x10F335A0", Slot = "5")]
    public FlowNode_ReqGuildRaidReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidReward.MP_Response) null;
    }
  }
}
