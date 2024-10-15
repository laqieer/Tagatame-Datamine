// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRankMatchReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001584")]
  [AddComponentMenu("")]
  [FlowNode.Pin(5000, "NoMatchVersion", FlowNode.PinTypes.Output, 5000)]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Req", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Multi/ReqRankMatchReward", 32741)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(6000, "MultiMaintenance", FlowNode.PinTypes.Output, 6000)]
  public class FlowNode_ReqRankMatchReward : FlowNode_Network
  {
    [Token(Token = "0x4004E5C")]
    [FieldOffset(Offset = "0x20")]
    private bool isChecked;
    [Token(Token = "0x4004E5D")]
    [FieldOffset(Offset = "0x24")]
    private FlowNode_ReqRankMatchReward.ReqType mReqType;
    [Token(Token = "0x4004E5E")]
    [FieldOffset(Offset = "0x28")]
    private int mToDay;

    [Token(Token = "0x60058BF")]
    [Address(RVA = "0x12D9960", Offset = "0x12D8760", VA = "0x112D9960", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058C0")]
    [Address(RVA = "0x12D9D70", Offset = "0x12D8B70", VA = "0x112D9D70", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058C1")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRankMatchReward()
    {
    }

    [Token(Token = "0x2001585")]
    private enum ReqType
    {
      [Token(Token = "0x4004E60")] Status,
      [Token(Token = "0x4004E61")] Reward,
    }
  }
}
