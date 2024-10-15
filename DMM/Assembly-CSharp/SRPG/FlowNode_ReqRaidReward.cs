// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqRaidReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200157F")]
  [AddComponentMenu("")]
  [FlowNode.Pin(20, "Guild", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(10, "Player", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Guild Set", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "Req", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Multi/ReqRaidReward", 32741)]
  [FlowNode.Pin(30, "Cancel", FlowNode.PinTypes.Output, 30)]
  public class FlowNode_ReqRaidReward : FlowNode_Network
  {
    [Token(Token = "0x4004E4A")]
    private const int PIN_IN_REQ = 0;
    [Token(Token = "0x4004E4B")]
    private const int PIN_IN_NEXT = 1;
    [Token(Token = "0x4004E4C")]
    private const int PIN_OUT_PLAYER = 10;
    [Token(Token = "0x4004E4D")]
    private const int PIN_OUT_GUILD = 20;
    [Token(Token = "0x4004E4E")]
    private const int PIN_OUT_CANCEL = 30;
    [Token(Token = "0x4004E4F")]
    [FieldOffset(Offset = "0x20")]
    private bool isChecked;

    [Token(Token = "0x60058B7")]
    [Address(RVA = "0x12D9240", Offset = "0x12D8040", VA = "0x112D9240", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60058B8")]
    [Address(RVA = "0x12D95A0", Offset = "0x12D83A0", VA = "0x112D95A0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60058B9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqRaidReward()
    {
    }

    [Token(Token = "0x2001580")]
    private enum RaidRewardRankingStatus
    {
      [Token(Token = "0x4004E51")] RankingOutSide,
      [Token(Token = "0x4004E52")] GetReward,
      [Token(Token = "0x4004E53")] RewardNoneReceive,
      [Token(Token = "0x4004E54")] RewardTimeOut,
      [Token(Token = "0x4004E55")] RewardReceiveed,
    }
  }
}
