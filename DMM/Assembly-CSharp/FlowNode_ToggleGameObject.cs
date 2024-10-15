// Decompiled with JetBrains decompiler
// Type: FlowNode_ToggleGameObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000225")]
[FlowNode.NodeType("Toggle/GameObject", 32741)]
[FlowNode.Pin(10, "Enable", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(11, "Disable", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 2)]
[AddComponentMenu("")]
public class FlowNode_ToggleGameObject : FlowNode
{
  [Token(Token = "0x400095A")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  [FlowNode.ShowInInfo]
  public GameObject Target;

  [Token(Token = "0x6000B95")]
  [Address(RVA = "0x1080940", Offset = "0x107F740", VA = "0x11080940", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B96")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_ToggleGameObject()
  {
  }
}
