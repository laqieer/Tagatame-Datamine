// Decompiled with JetBrains decompiler
// Type: FlowNode_EventCall
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001D3")]
[AddComponentMenu("")]
[FlowNode.Pin(1, "Output", FlowNode.PinTypes.Output, 1)]
[FlowNode.Pin(10, "Input", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Event/Call", 32741)]
public class FlowNode_EventCall : FlowNode
{
  [Token(Token = "0x4000848")]
  [FieldOffset(Offset = "0x18")]
  [FlowNode.DropTarget(typeof (GameObject), true)]
  [FlowNode.ShowInInfo]
  public GameObject Target;
  [Token(Token = "0x4000849")]
  [FieldOffset(Offset = "0x1C")]
  [FlowNode.ShowInInfo]
  public string Key;
  [Token(Token = "0x400084A")]
  [FieldOffset(Offset = "0x20")]
  public string Value;

  [Token(Token = "0x6000A90")]
  [Address(RVA = "0xF49670", Offset = "0xF48470", VA = "0x10F49670", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000A91")]
  [Address(RVA = "0xF49740", Offset = "0xF48540", VA = "0x10F49740")]
  public FlowNode_EventCall()
  {
  }
}
