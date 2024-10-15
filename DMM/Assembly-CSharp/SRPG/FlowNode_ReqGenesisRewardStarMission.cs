// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqGenesisRewardStarMission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001698")]
  [FlowNode.Pin(102, "OutOfPeriod", FlowNode.PinTypes.Output, 102)]
  [FlowNode.NodeType("Genesis/Req/RewardStarMission", 32741)]
  [FlowNode.Pin(1, "Request", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Success", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_ReqGenesisRewardStarMission : FlowNode_Network
  {
    [Token(Token = "0x400521C")]
    protected const int PIN_IN_REQUEST = 1;
    [Token(Token = "0x400521D")]
    protected const int PIN_OUT_SUCCESS = 101;
    [Token(Token = "0x400521E")]
    protected const int PIN_OUT_OUT_OF_PERIOD = 102;

    [Token(Token = "0x6005CA6")]
    [Address(RVA = "0x130A9A0", Offset = "0x13097A0", VA = "0x1130A9A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005CA7")]
    [Address(RVA = "0x3089D0", Offset = "0x3077D0", VA = "0x103089D0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005CA8")]
    [Address(RVA = "0x130AB90", Offset = "0x1309990", VA = "0x1130AB90", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005CA9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqGenesisRewardStarMission()
    {
    }
  }
}
