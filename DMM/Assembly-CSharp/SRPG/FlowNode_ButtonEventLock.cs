// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ButtonEventLock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200136D")]
  [FlowNode.Pin(2, "UnLock", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Lock", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(4, "AllReset", FlowNode.PinTypes.Input, 3)]
  [FlowNode.NodeType("Event/ButtonEventLock", 13156327)]
  [AddComponentMenu("")]
  [FlowNode.Pin(3, "Reset", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(10, "Out", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_ButtonEventLock : FlowNode
  {
    [Token(Token = "0x40047B2")]
    [FieldOffset(Offset = "0x18")]
    public string LockKey;

    [Token(Token = "0x600517B")]
    [Address(RVA = "0x1266E10", Offset = "0x1265C10", VA = "0x11266E10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600517C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ButtonEventLock()
    {
    }
  }
}
