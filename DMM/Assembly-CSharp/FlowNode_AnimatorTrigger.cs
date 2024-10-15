// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001CD")]
[FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[AddComponentMenu("")]
[FlowNode.NodeType("Animator/Trigger", 32741)]
public class FlowNode_AnimatorTrigger : FlowNode
{
  [Token(Token = "0x4000839")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public string TriggerName;
  [Token(Token = "0x400083A")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;
  [Token(Token = "0x400083B")]
  [FieldOffset(Offset = "0x20")]
  public bool UpdateAnimator;

  [Token(Token = "0x6000A7E")]
  [Address(RVA = "0xF488A0", Offset = "0xF476A0", VA = "0x10F488A0", Slot = "10")]
  public override string GetCaption() => (string) null;

  [Token(Token = "0x6000A7F")]
  [Address(RVA = "0xF488F0", Offset = "0xF476F0", VA = "0x10F488F0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A80")]
  [Address(RVA = "0xF489E0", Offset = "0xF477E0", VA = "0x10F489E0")]
  public FlowNode_AnimatorTrigger()
  {
  }
}
