// Decompiled with JetBrains decompiler
// Type: FlowNode_ActionCall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001C3")]
[AddComponentMenu("")]
[FlowNode.NodeType("UI/ActionCall", 32741)]
[FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
public class FlowNode_ActionCall : FlowNode
{
  [Token(Token = "0x400081B")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.ShowInInfo]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  public GameObject Target;
  [Token(Token = "0x400081C")]
  [FieldOffset(Offset = "0x1C")]
  public ActionCall.EventType EventType;
  [Token(Token = "0x400081D")]
  [FieldOffset(Offset = "0x20")]
  public SerializeValueList Value;

  [Token(Token = "0x6000A66")]
  [Address(RVA = "0xF47550", Offset = "0xF46350", VA = "0x10F47550", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A67")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_ActionCall()
  {
  }
}
