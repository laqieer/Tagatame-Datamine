// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorSetBool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C8")]
[FlowNode.Pin(3, "Turned Off", FlowNode.PinTypes.Output, 12)]
[AddComponentMenu("")]
[FlowNode.Pin(12, "Toggle", FlowNode.PinTypes.Input, 2)]
[FlowNode.Pin(11, "Off", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(10, "On", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Animator/SetBool", 32741)]
[FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 10)]
[FlowNode.Pin(2, "Turned On", FlowNode.PinTypes.Output, 11)]
public class FlowNode_AnimatorSetBool : FlowNode
{
  [Token(Token = "0x4000829")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public string PropertyName;
  [Token(Token = "0x400082A")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;
  [Token(Token = "0x400082B")]
  [FieldOffset(Offset = "0x20")]
  [FlowNode.ShowInInfo]
  public bool IskeepAnimator;

  [Token(Token = "0x6000A73")]
  [Address(RVA = "0xF480B0", Offset = "0xF46EB0", VA = "0x10F480B0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A74")]
  [Address(RVA = "0xF48220", Offset = "0xF47020", VA = "0x10F48220")]
  public FlowNode_AnimatorSetBool()
  {
  }
}
