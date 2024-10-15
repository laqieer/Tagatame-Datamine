// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_IsAllowedAuto
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017D4")]
  [FlowNode.NodeType("MultiPlay/IsAllowedAuto", 32741)]
  [FlowNode.Pin(1, "Test", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Allowed", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Denied", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(100, "Failure", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_MP_IsAllowedAuto : FlowNode
  {
    [Token(Token = "0x40055B6")]
    private const int PIN_IN_TEST = 1;
    [Token(Token = "0x40055B7")]
    private const int PIN_OUT_ALLOWED = 10;
    [Token(Token = "0x40055B8")]
    private const int PIN_OUT_DENIED = 11;
    [Token(Token = "0x40055B9")]
    private const int PIN_OUT_FAILURE = 100;

    [Token(Token = "0x600607B")]
    [Address(RVA = "0x134B880", Offset = "0x134A680", VA = "0x1134B880", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600607C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_IsAllowedAuto()
    {
    }
  }
}
