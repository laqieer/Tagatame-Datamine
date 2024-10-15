// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EventPageListType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013D5")]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "設定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/EventPageList/EventPageListType")]
  public class FlowNode_EventPageListType : FlowNode
  {
    [Token(Token = "0x4004972")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GlobalVars.EventQuestListType m_TargetEventQuestListType;

    [Token(Token = "0x6005303")]
    [Address(RVA = "0x127BD10", Offset = "0x127AB10", VA = "0x1127BD10", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005304")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_EventPageListType()
    {
    }
  }
}
