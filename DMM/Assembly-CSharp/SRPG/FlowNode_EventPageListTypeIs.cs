// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EventPageListTypeIs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013D6")]
  [FlowNode.NodeType("System/EventPageList/EventPageListTypeIs")]
  [FlowNode.Pin(0, "判定", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "==", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "!=", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_EventPageListTypeIs : FlowNode
  {
    [Token(Token = "0x4004973")]
    private const int INPUT_JUDGE = 0;
    [Token(Token = "0x4004974")]
    private const int OUTPUT_EQUAL = 100;
    [Token(Token = "0x4004975")]
    private const int OUTPUT_NOT_EQUAL = 101;
    [Token(Token = "0x4004976")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [FlowNode.ShowInInfo(true)]
    private GlobalVars.EventQuestListType m_TargetEventQuestListType;

    [Token(Token = "0x6005305")]
    [Address(RVA = "0x127BC90", Offset = "0x127AA90", VA = "0x1127BC90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005306")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_EventPageListTypeIs()
    {
    }
  }
}
