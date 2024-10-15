// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001CB")]
[AddComponentMenu("")]
[FlowNode.Pin(10, "Output", FlowNode.PinTypes.Output, 1)]
[FlowNode.NodeType("Animator/Skip", 32741)]
[FlowNode.Pin(1, "Input", FlowNode.PinTypes.Input, 0)]
public class FlowNode_AnimatorSkip : FlowNode
{
  [Token(Token = "0x4000833")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public string StateName;
  [Token(Token = "0x4000834")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;
  [Token(Token = "0x4000835")]
  [FieldOffset(Offset = "0x20")]
  private int m_PrevStateHash;

  [Token(Token = "0x6000A7A")]
  [Address(RVA = "0xF485C0", Offset = "0xF473C0", VA = "0x10F485C0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A7B")]
  [Address(RVA = "0xF48740", Offset = "0xF47540", VA = "0x10F48740")]
  public FlowNode_AnimatorSkip()
  {
  }
}
