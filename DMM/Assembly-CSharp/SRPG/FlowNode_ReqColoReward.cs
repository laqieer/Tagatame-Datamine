// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqColoReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014CB")]
  [AddComponentMenu("")]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Network/btl_colo_reward", 32741)]
  public class FlowNode_ReqColoReward : FlowNode_Network
  {
    [Token(Token = "0x4004C4A")]
    private const int PIN_IN_REQUEST = 0;
    [Token(Token = "0x4004C4B")]
    private const int PIN_OUT_SUCCESS = 10;
    [Token(Token = "0x4004C4C")]
    private const int PIN_OUT_DONOTHING = 100;

    [Token(Token = "0x60056A0")]
    [Address(RVA = "0x12C13B0", Offset = "0x12C01B0", VA = "0x112C13B0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056A1")]
    [Address(RVA = "0x12C1450", Offset = "0x12C0250", VA = "0x112C1450", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056A2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqColoReward()
    {
    }
  }
}
