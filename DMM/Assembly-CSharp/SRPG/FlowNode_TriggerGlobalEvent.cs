// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TriggerGlobalEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001656")]
  [FlowNode.Pin(1, "Triggered", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(100, "Trigger", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Event/TriggerGlobalEvent", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_TriggerGlobalEvent : FlowNode
  {
    [Token(Token = "0x400511E")]
    [FieldOffset(Offset = "0x18")]
    [StringIsGlobalEventID]
    public string EventName;

    [Token(Token = "0x6005BBA")]
    [Address(RVA = "0x13111B0", Offset = "0x130FFB0", VA = "0x113111B0", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x6005BBB")]
    [Address(RVA = "0x1311270", Offset = "0x1310070", VA = "0x11311270", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BBC")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_TriggerGlobalEvent()
    {
    }
  }
}
