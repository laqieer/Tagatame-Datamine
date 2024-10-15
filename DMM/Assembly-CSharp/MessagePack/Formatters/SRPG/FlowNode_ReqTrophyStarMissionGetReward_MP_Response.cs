// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqTrophyStarMissionGetReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A4B")]
  public sealed class FlowNode_ReqTrophyStarMissionGetReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqTrophyStarMissionGetReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001926")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001927")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600282F")]
    [Address(RVA = "0xEAD340", Offset = "0xEAC140", VA = "0x10EAD340")]
    public FlowNode_ReqTrophyStarMissionGetReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002830")]
    [Address(RVA = "0xEAD050", Offset = "0xEABE50", VA = "0x10EAD050", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqTrophyStarMissionGetReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002831")]
    [Address(RVA = "0xEACC20", Offset = "0xEABA20", VA = "0x10EACC20", Slot = "5")]
    public FlowNode_ReqTrophyStarMissionGetReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqTrophyStarMissionGetReward.MP_Response) null;
    }
  }
}
