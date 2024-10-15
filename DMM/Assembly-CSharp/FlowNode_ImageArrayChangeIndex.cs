// Decompiled with JetBrains decompiler
// Type: FlowNode_ImageArrayChangeIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E1")]
[FlowNode.Pin(10, "Out", FlowNode.PinTypes.Output, 10)]
[FlowNode.NodeType("UI/ImageArrayChangeIndex", 32741)]
[AddComponentMenu("")]
[FlowNode.Pin(0, "Set", FlowNode.PinTypes.Input, 0)]
public class FlowNode_ImageArrayChangeIndex : FlowNode
{
  [Token(Token = "0x4000878")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public int Index;
  [Token(Token = "0x4000879")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  [FlowNode.ShowInInfo]
  public GameObject Target;

  [Token(Token = "0x6000ADB")]
  [Address(RVA = "0xF4E100", Offset = "0xF4CF00", VA = "0x10F4E100", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000ADC")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_ImageArrayChangeIndex()
  {
  }
}
