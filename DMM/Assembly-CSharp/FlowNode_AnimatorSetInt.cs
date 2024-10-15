// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorSetInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C9")]
[FlowNode.NodeType("Animator/Set Int", 32741)]
[FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[AddComponentMenu("")]
public class FlowNode_AnimatorSetInt : FlowNode
{
  [Token(Token = "0x400082C")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public string ParameterName;
  [Token(Token = "0x400082D")]
  [FieldOffset(Offset = "0x1C")]
  public int Value;
  [Token(Token = "0x400082E")]
  [FieldOffset(Offset = "0x20")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;
  [Token(Token = "0x400082F")]
  [FieldOffset(Offset = "0x24")]
  public bool UpdateAnimator;

  [Token(Token = "0x6000A75")]
  [Address(RVA = "0xF482B0", Offset = "0xF470B0", VA = "0x10F482B0", Slot = "10")]
  public override string GetCaption() => (string) null;

  [Token(Token = "0x6000A76")]
  [Address(RVA = "0xF48300", Offset = "0xF47100", VA = "0x10F48300", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A77")]
  [Address(RVA = "0xF483F0", Offset = "0xF471F0", VA = "0x10F483F0")]
  public FlowNode_AnimatorSetInt()
  {
  }
}
