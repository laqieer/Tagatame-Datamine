// Decompiled with JetBrains decompiler
// Type: FlowNode_TriggerLocalEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x200022A")]
[FlowNode.Pin(1, "Triggered", FlowNode.PinTypes.Output, 2)]
[FlowNode.Pin(100, "Trigger", FlowNode.PinTypes.Input, 0)]
[FlowNode.NodeType("Event/TriggerLocalEvent", 32741)]
[AddComponentMenu("")]
public class FlowNode_TriggerLocalEvent : FlowNode
{
  [Token(Token = "0x400095E")]
  [FieldOffset(Offset = "0x18")]
  [StringIsLocalEventID]
  public string EventName;

  [Token(Token = "0x6000B9F")]
  [Address(RVA = "0x1080BC0", Offset = "0x107F9C0", VA = "0x11080BC0", Slot = "6")]
  public override string[] GetInfoLines() => (string[]) null;

  [Token(Token = "0x6000BA0")]
  [Address(RVA = "0x1080C80", Offset = "0x107FA80", VA = "0x11080C80", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000BA1")]
  [Address(RVA = "0x1080D90", Offset = "0x107FB90", VA = "0x11080D90")]
  public static void TriggerLocalEvent(Component caller, string EventName)
  {
  }

  [Token(Token = "0x6000BA2")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_TriggerLocalEvent()
  {
  }
}
