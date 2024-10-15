// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorPoll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C6")]
[AddComponentMenu("")]
[FlowNode.Pin(2, "NoAnim", FlowNode.PinTypes.Output, 3)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 2)]
[FlowNode.Pin(11, "Cancel", FlowNode.PinTypes.Input, 1)]
[FlowNode.NodeType("Animator/Poll", 32741)]
[FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 0)]
public class FlowNode_AnimatorPoll : FlowNode
{
  [Token(Token = "0x4000823")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public string StateName;
  [Token(Token = "0x4000824")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;
  [Token(Token = "0x4000825")]
  [FieldOffset(Offset = "0x20")]
  private Animator mAnimator;

  [Token(Token = "0x6000A6C")]
  [Address(RVA = "0xF47D90", Offset = "0xF46B90", VA = "0x10F47D90", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A6D")]
  [Address(RVA = "0xF47E70", Offset = "0xF46C70", VA = "0x10F47E70")]
  private void Update()
  {
  }

  [Token(Token = "0x6000A6E")]
  [Address(RVA = "0xF48020", Offset = "0xF46E20", VA = "0x10F48020")]
  public FlowNode_AnimatorPoll()
  {
  }
}
