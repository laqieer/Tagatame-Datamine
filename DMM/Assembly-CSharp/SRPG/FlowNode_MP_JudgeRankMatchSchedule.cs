// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_JudgeRankMatchSchedule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017CE")]
  [FlowNode.NodeType("MultiPlay/RankMatch/JudgeSchedule", 32741)]
  [FlowNode.Pin(1, "Test", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Aggregating", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Rewarding", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  public class FlowNode_MP_JudgeRankMatchSchedule : FlowNode
  {
    [Token(Token = "0x4005598")]
    private const int PIN_IN_TEST = 1;
    [Token(Token = "0x4005599")]
    private const int PIN_OUT_OPEN = 10;
    [Token(Token = "0x400559A")]
    private const int PIN_OUT_AGGREGATING = 11;
    [Token(Token = "0x400559B")]
    private const int PIN_OUT_REWARDING = 12;

    [Token(Token = "0x6006067")]
    [Address(RVA = "0x134D4E0", Offset = "0x134C2E0", VA = "0x1134D4E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006068")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_JudgeRankMatchSchedule()
    {
    }
  }
}
