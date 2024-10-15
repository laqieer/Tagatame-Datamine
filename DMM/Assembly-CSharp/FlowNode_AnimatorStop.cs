// Decompiled with JetBrains decompiler
// Type: FlowNode_AnimatorStop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001CC")]
[FlowNode.Pin(10, "Out", FlowNode.PinTypes.Output, 10)]
[FlowNode.NodeType("Animator/Stop", 32741)]
[AddComponentMenu("")]
[FlowNode.Pin(0, "Stop", FlowNode.PinTypes.Input, 0)]
public class FlowNode_AnimatorStop : FlowNode
{
  [Token(Token = "0x4000836")]
  private const int PIN_IN_STOP = 0;
  [Token(Token = "0x4000837")]
  private const int PIN_OUT_OUT = 10;
  [Token(Token = "0x4000838")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;

  [Token(Token = "0x6000A7C")]
  [Address(RVA = "0xF487D0", Offset = "0xF475D0", VA = "0x10F487D0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A7D")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_AnimatorStop()
  {
  }
}
