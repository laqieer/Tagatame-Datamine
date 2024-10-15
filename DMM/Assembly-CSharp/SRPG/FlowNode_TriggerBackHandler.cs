// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TriggerBackHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001654")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Event/TriggerBackHandler", 16087213)]
  [FlowNode.Pin(1, "Trigger", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Triggered", FlowNode.PinTypes.Output, 2)]
  public class FlowNode_TriggerBackHandler : FlowNode
  {
    [Token(Token = "0x400511A")]
    [FieldOffset(Offset = "0x18")]
    public bool Force;

    [Token(Token = "0x6005BB6")]
    [Address(RVA = "0x1310BB0", Offset = "0x130F9B0", VA = "0x11310BB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BB7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_TriggerBackHandler()
    {
    }
  }
}
