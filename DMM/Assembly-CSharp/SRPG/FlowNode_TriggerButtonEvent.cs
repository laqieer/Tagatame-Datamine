// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TriggerButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001655")]
  [FlowNode.Pin(1, "Triggered", FlowNode.PinTypes.Output, 2)]
  [FlowNode.NodeType("Event/TriggerButtonEvent", 16087213)]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Trigger", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_TriggerButtonEvent : FlowNode
  {
    [Token(Token = "0x400511B")]
    [FieldOffset(Offset = "0x18")]
    public bool Force;
    [Token(Token = "0x400511C")]
    [FieldOffset(Offset = "0x1C")]
    public string EventName;
    [Token(Token = "0x400511D")]
    [FieldOffset(Offset = "0x20")]
    public SerializeValue Value;

    [Token(Token = "0x6005BB8")]
    [Address(RVA = "0x1310C10", Offset = "0x130FA10", VA = "0x11310C10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BB9")]
    [Address(RVA = "0x1310CB0", Offset = "0x130FAB0", VA = "0x11310CB0")]
    public FlowNode_TriggerButtonEvent()
    {
    }
  }
}
