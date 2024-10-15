// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GlobalEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013FB")]
  [FlowNode.Pin(1, "Triggered", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Event/GlobalEvent", 58751)]
  public class FlowNode_GlobalEvent : FlowNodePersistent
  {
    [Token(Token = "0x40049F5")]
    [FieldOffset(Offset = "0x18")]
    [StringIsGlobalEventID]
    public string EventName;
    [Token(Token = "0x40049F6")]
    [FieldOffset(Offset = "0x1C")]
    private string mRegisteredEventName;

    [Token(Token = "0x6005398")]
    [Address(RVA = "0x1281FE0", Offset = "0x1280DE0", VA = "0x11281FE0", Slot = "6")]
    public override string[] GetInfoLines() => (string[]) null;

    [Token(Token = "0x6005399")]
    [Address(RVA = "0x1281F20", Offset = "0x1280D20", VA = "0x11281F20", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600539A")]
    [Address(RVA = "0x12820A0", Offset = "0x1280EA0", VA = "0x112820A0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600539B")]
    [Address(RVA = "0xF49830", Offset = "0xF48630", VA = "0x10F49830")]
    private void OnGlobalEvent(object obj)
    {
    }

    [Token(Token = "0x600539C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GlobalEvent()
    {
    }
  }
}
