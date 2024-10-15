// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorSetNormalizedTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001CA")]
[AddComponentMenu("")]
[FlowNode.NodeType("Animator/Set Normalized Time", 32741)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
public class FlowNode_AnimatorSetNormalizedTime : FlowNode
{
  [Token(Token = "0x4000830")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public float NormalizedTime;
  [Token(Token = "0x4000831")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;
  [Token(Token = "0x4000832")]
  [FieldOffset(Offset = "0x20")]
  public bool UpdateAnimator;

  [Token(Token = "0x6000A78")]
  [Address(RVA = "0xF48480", Offset = "0xF47280", VA = "0x10F48480", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A79")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_AnimatorSetNormalizedTime()
  {
  }
}
