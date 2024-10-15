// Decompiled with JetBrains decompiler
// Type: FlowNode_IsAnimStateInfoName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E4")]
[FlowNode.Pin(11, "Output(No)", FlowNode.PinTypes.Output, 3)]
[AddComponentMenu("")]
[FlowNode.Pin(1, "Input", FlowNode.PinTypes.Input, 1)]
[FlowNode.NodeType("Animator/IsName", 32741)]
[FlowNode.Pin(10, "Output(Yes)", FlowNode.PinTypes.Output, 2)]
public class FlowNode_IsAnimStateInfoName : FlowNode
{
  [Token(Token = "0x400087C")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  public string[] StateName;
  [Token(Token = "0x400087D")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  [FlowNode.ShowInInfo]
  public GameObject Target;

  [Token(Token = "0x6000AE3")]
  [Address(RVA = "0xF4E290", Offset = "0xF4D090", VA = "0x10F4E290", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AE4")]
  [Address(RVA = "0xF4E410", Offset = "0xF4D210", VA = "0x10F4E410")]
  public FlowNode_IsAnimStateInfoName()
  {
  }
}
