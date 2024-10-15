// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorPlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C5")]
[FlowNode.NodeType("Animator/Play", 32741)]
[FlowNode.Pin(0, "Play", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(10, "Out", FlowNode.PinTypes.Output, 10)]
[AddComponentMenu("")]
public class FlowNode_AnimatorPlay : FlowNode
{
  [Token(Token = "0x4000821")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public string StateName;
  [Token(Token = "0x4000822")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;

  [Token(Token = "0x6000A6A")]
  [Address(RVA = "0xF47930", Offset = "0xF46730", VA = "0x10F47930", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A6B")]
  [Address(RVA = "0xF47A10", Offset = "0xF46810", VA = "0x10F47A10")]
  public FlowNode_AnimatorPlay()
  {
  }
}
