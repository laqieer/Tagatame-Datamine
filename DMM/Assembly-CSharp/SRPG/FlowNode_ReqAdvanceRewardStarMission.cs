// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAdvanceRewardStarMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012D4")]
  [FlowNode.NodeType("Advance/Req/RewardStarMission", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "NotOpen", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  public class FlowNode_ReqAdvanceRewardStarMission : FlowNode_Network
  {
    [Token(Token = "0x4004629")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400462A")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400462B")]
    protected const int PIN_OUT_NOT_OPEN = 102;

    [Token(Token = "0x6004FC3")]
    [Address(RVA = "0x124A310", Offset = "0x1249110", VA = "0x1124A310", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FC4")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6004FC5")]
    [Address(RVA = "0x124A500", Offset = "0x1249300", VA = "0x1124A500", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6004FC6")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAdvanceRewardStarMission()
    {
    }
  }
}
