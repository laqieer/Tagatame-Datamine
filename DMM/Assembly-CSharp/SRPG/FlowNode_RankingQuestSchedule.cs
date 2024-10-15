// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_RankingQuestSchedule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200146F")]
  [FlowNode.NodeType("System/Quest/RankingQuestSchedule")]
  [FlowNode.Pin(100, "開催期間中のランキングクエストはあるか？", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "開催期間中のランキングクエスト（有）", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "開催期間中のランキングクエスト（無）", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  public class FlowNode_RankingQuestSchedule : FlowNode
  {
    [Token(Token = "0x4004B92")]
    public const int INPUT_EXIST_OPEN_RANKING_SCHEDULE = 100;
    [Token(Token = "0x4004B93")]
    public const int OUTPUT_EXIST_OPEN_RANKING_SCHEDULE_TRUE = 101;
    [Token(Token = "0x4004B94")]
    public const int OUTPUT_EXIST_OPEN_RANKING_SCHEDULE_FALSE = 102;

    [Token(Token = "0x600556A")]
    [Address(RVA = "0x129BE20", Offset = "0x129AC20", VA = "0x1129BE20", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600556B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_RankingQuestSchedule()
    {
    }
  }
}
