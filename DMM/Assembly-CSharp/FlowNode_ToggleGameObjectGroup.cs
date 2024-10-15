// Decompiled with JetBrains decompiler
// Type: FlowNode_ToggleGameObjectGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000226")]
[FlowNode.Pin(2, "Enabled", FlowNode.PinTypes.Output, 3)]
[AddComponentMenu("")]
[FlowNode.Pin(3, "Disabled", FlowNode.PinTypes.Output, 4)]
[FlowNode.Pin(11, "Disable", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 2)]
[FlowNode.Pin(10, "Enable", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Toggle/GameObjectGroup", 32741)]
public class FlowNode_ToggleGameObjectGroup : FlowNode
{
  [Token(Token = "0x400095B")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  [FlowNode.ShowInInfo]
  public GameObject[] Target;

  [Token(Token = "0x6000B97")]
  [Address(RVA = "0x10807A0", Offset = "0x107F5A0", VA = "0x110807A0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B98")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_ToggleGameObjectGroup()
  {
  }
}
