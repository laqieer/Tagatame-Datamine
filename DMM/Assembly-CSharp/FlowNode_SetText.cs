// Decompiled with JetBrains decompiler
// Type: FlowNode_SetText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200021A")]
[FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("UI/SetText", 32741)]
[FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 0)]
[AddComponentMenu("")]
public class FlowNode_SetText : FlowNode
{
  [Token(Token = "0x4000935")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (UnityEngine.UI.Text), true)]
  public UnityEngine.UI.Text Target;
  [Token(Token = "0x4000936")]
  [FieldOffset(Offset = "0x1C")]
  public string Text;

  [Token(Token = "0x6000B7C")]
  [Address(RVA = "0x107F020", Offset = "0x107DE20", VA = "0x1107F020", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B7D")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_SetText()
  {
  }
}
