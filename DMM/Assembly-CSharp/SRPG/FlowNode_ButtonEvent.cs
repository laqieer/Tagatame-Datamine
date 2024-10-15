// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ButtonEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200136C")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Event/ButtonEvent", 15695845)]
  [FlowNode.Pin(1, "Triggered", FlowNode.PinTypes.Output, 0)]
  public class FlowNode_ButtonEvent : FlowNode
  {
    [Token(Token = "0x40047AC")]
    [FieldOffset(Offset = "0x0")]
    public static object currentValue;
    [Token(Token = "0x40047AD")]
    [FieldOffset(Offset = "0x18")]
    [StringIsButtonEventID]
    public string EventName;
    [Token(Token = "0x40047AE")]
    [FieldOffset(Offset = "0x1C")]
    [BitMask]
    public CriticalSections CSMask;
    [Token(Token = "0x40047AF")]
    [FieldOffset(Offset = "0x20")]
    public bool DoLock;
    [Token(Token = "0x40047B0")]
    [FieldOffset(Offset = "0x24")]
    public string LockKey;
    [Token(Token = "0x40047B1")]
    [FieldOffset(Offset = "0x28")]
    private ButtonEvent.Listener m_Listener;

    [Token(Token = "0x6005176")]
    [Address(RVA = "0x1266FE0", Offset = "0x1265DE0", VA = "0x11266FE0", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x6005177")]
    [Address(RVA = "0x1266F20", Offset = "0x1265D20", VA = "0x11266F20", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6005178")]
    [Address(RVA = "0x12672E0", Offset = "0x12660E0", VA = "0x112672E0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005179")]
    [Address(RVA = "0x1267130", Offset = "0x1265F30", VA = "0x11267130")]
    private void OnButtonEvent(bool isForce, object obj)
    {
    }

    [Token(Token = "0x600517A")]
    [Address(RVA = "0x1267340", Offset = "0x1266140", VA = "0x11267340")]
    public FlowNode_ButtonEvent()
    {
    }
  }
}
