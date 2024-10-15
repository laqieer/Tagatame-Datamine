// Decompiled with JetBrains decompiler
// Type: FlowNode_LocalEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001E8")]
[FlowNode.Pin(1, "Triggered", FlowNode.PinTypes.Output, 0)]
[FlowNode.NodeType("Event/LocalEvent", 58751)]
[AddComponentMenu("")]
public class FlowNode_LocalEvent : FlowNode
{
  [Token(Token = "0x400088A")]
  [FieldOffset(Offset = "0x18")]
  [StringIsLocalEventID]
  [FlowNode.ShowInInfo]
  public string EventName;

  [Token(Token = "0x6000AEB")]
  [Address(RVA = "0xF49830", Offset = "0xF48630", VA = "0x10F49830", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000AEC")]
  [Address(RVA = "0xF474B0", Offset = "0xF462B0", VA = "0x10F474B0")]
  public FlowNode_LocalEvent()
  {
  }
}
