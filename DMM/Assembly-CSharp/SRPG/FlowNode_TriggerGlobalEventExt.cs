// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_TriggerGlobalEventExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001657")]
  [FlowNode.NodeType("Event/TriggerGlobalEventExt", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "Back", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_TriggerGlobalEventExt : FlowNode_TriggerGlobalEvent
  {
    [Token(Token = "0x400511F")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsGlobalEventID]
    public string CurrEventName;
    [Token(Token = "0x4005120")]
    [FieldOffset(Offset = "0x20")]
    public bool SceneChange;

    [Token(Token = "0x6005BBD")]
    [Address(RVA = "0x1310D40", Offset = "0x130FB40", VA = "0x11310D40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005BBE")]
    [Address(RVA = "0x1310E90", Offset = "0x130FC90", VA = "0x11310E90")]
    private void SceneInvoke(string event_name)
    {
    }

    [Token(Token = "0x6005BBF")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_TriggerGlobalEventExt()
    {
    }
  }
}
