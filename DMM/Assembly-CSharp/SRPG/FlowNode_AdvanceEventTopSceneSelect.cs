// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdvanceEventTopSceneSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012C8")]
  [FlowNode.Pin(111, "KeyClosed", FlowNode.PinTypes.Output, 111)]
  [FlowNode.NodeType("Advance/EventTopSceneSelect", 32741)]
  [FlowNode.Pin(1, "Select", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Top", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(21, "Stage", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(22, "Boss", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(101, "OutOfPeriod", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_AdvanceEventTopSceneSelect : FlowNode
  {
    [Token(Token = "0x4004601")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4004602")]
    private const int PIN_OUT_TOP = 11;
    [Token(Token = "0x4004603")]
    private const int PIN_OUT_STAGE = 21;
    [Token(Token = "0x4004604")]
    private const int PIN_OUT_BOSS = 22;
    [Token(Token = "0x4004605")]
    private const int PIN_OUT_QUEST_OUT_OF_PERIOD = 101;
    [Token(Token = "0x4004606")]
    private const int PIN_OUT_QUEST_KEY_CLOSED = 111;

    [Token(Token = "0x6004F99")]
    [Address(RVA = "0x1248B90", Offset = "0x1247990", VA = "0x11248B90", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004F9A")]
    [Address(RVA = "0x1248E10", Offset = "0x1247C10", VA = "0x11248E10")]
    private void ToQuest(QuestParam quest, bool is_restore)
    {
    }

    [Token(Token = "0x6004F9B")]
    [Address(RVA = "0x1248FA0", Offset = "0x1247DA0", VA = "0x11248FA0")]
    private void ToTop()
    {
    }

    [Token(Token = "0x6004F9C")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_AdvanceEventTopSceneSelect()
    {
    }
  }
}
