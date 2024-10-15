// Decompiled with JetBrains decompiler
// Type: FlowNode_ToggleCanvasGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000223")]
[FlowNode.Pin(1, "Turn On Block Raycasts", FlowNode.PinTypes.Input, 1)]
[FlowNode.Pin(6, "Turn Off interactive", FlowNode.PinTypes.Input, 6)]
[AddComponentMenu("")]
[FlowNode.Pin(5, "Turn On interactive", FlowNode.PinTypes.Input, 5)]
[FlowNode.NodeType("Toggle/CanvasGroup", 32741)]
[FlowNode.Pin(2, "Turn Off Block Raycasts", FlowNode.PinTypes.Input, 2)]
[FlowNode.Pin(0, "Out", FlowNode.PinTypes.Output, 999)]
[FlowNode.Pin(4, "Hide", FlowNode.PinTypes.Input, 4)]
[FlowNode.Pin(3, "Show", FlowNode.PinTypes.Input, 3)]
public class FlowNode_ToggleCanvasGroup : FlowNode
{
  [Token(Token = "0x4000956")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (CanvasGroup), true)]
  public CanvasGroup Target;

  [Token(Token = "0x6000B91")]
  [Address(RVA = "0x1080360", Offset = "0x107F160", VA = "0x11080360", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B92")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_ToggleCanvasGroup()
  {
  }
}
