// Decompiled with JetBrains decompiler
// Type: FlowNode_SetAnchoredPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000219")]
[FlowNode.Pin(1, "Out", FlowNode.PinTypes.Output, 1)]
[FlowNode.Pin(0, "In", FlowNode.PinTypes.Input, 0)]
[AddComponentMenu("")]
[FlowNode.NodeType("UI/SetAnchoredPosition", 32741)]
public class FlowNode_SetAnchoredPosition : FlowNode
{
  [Token(Token = "0x4000933")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.DropTarget(typeof (RectTransform), true)]
  [FlowNode.ShowInInfo]
  public RectTransform Target;
  [Token(Token = "0x4000934")]
  [FieldOffset(Offset = "0x1C")]
  public Vector2 TargetPosition;

  [Token(Token = "0x6000B7A")]
  [Address(RVA = "0x107EE90", Offset = "0x107DC90", VA = "0x1107EE90", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B7B")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_SetAnchoredPosition()
  {
  }
}
