// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqBtlCom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014A2")]
  [FlowNode.Pin(3, "GenesisOutOfPeriod", FlowNode.PinTypes.Output, 12)]
  [FlowNode.NodeType("System/ReqBtlCom/ReqBtlCom", 32741)]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "Reset to Title", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(4, "AdvanceNotOpen", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(5, "PointQuestNotOpen", FlowNode.PinTypes.Output, 14)]
  [AddComponentMenu("")]
  public class FlowNode_ReqBtlCom : FlowNode_Network
  {
    [Token(Token = "0x4004BF5")]
    private const int PIN_OUT_GENESIS_OUT_OF_PERIOD = 3;
    [Token(Token = "0x4004BF6")]
    private const int PIN_OUT_ADVANCE_NOT_OPEN = 4;
    [Token(Token = "0x4004BF7")]
    private const int PIN_OUT_DRAGONGOD_NOT_OPEN = 5;
    [Token(Token = "0x4004BF8")]
    [FieldOffset(Offset = "0x20")]
    public bool FastRefresh;
    [Token(Token = "0x4004BF9")]
    [FieldOffset(Offset = "0x21")]
    public bool GetTowerProgress;
    [Token(Token = "0x4004BFA")]
    [FieldOffset(Offset = "0x22")]
    [SerializeField]
    private bool GetGenesisProgress;
    [Token(Token = "0x4004BFB")]
    [FieldOffset(Offset = "0x23")]
    [SerializeField]
    private bool GetAdvanceProgress;
    [Token(Token = "0x4004BFC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool GetPointQuestProgress;

    [Token(Token = "0x600560F")]
    [Address(RVA = "0x12BD100", Offset = "0x12BBF00", VA = "0x112BD100", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005610")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005611")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005612")]
    [Address(RVA = "0x12BD270", Offset = "0x12BC070", VA = "0x112BD270", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005613")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqBtlCom()
    {
    }

    [Token(Token = "0x20014A3")]
    public class JSON_ReqBtlComResponse
    {
      [Token(Token = "0x4004BFD")]
      [FieldOffset(Offset = "0x8")]
      public JSON_QuestProgress[] quests;
      [Token(Token = "0x4004BFE")]
      [FieldOffset(Offset = "0xC")]
      public JSON_ReqTowerResuponse.Json_TowerProg[] towers;
      [Token(Token = "0x4004BFF")]
      [FieldOffset(Offset = "0x10")]
      public ReqBtlCom.GenesisStar[] genesis_stars;
      [Token(Token = "0x4004C00")]
      [FieldOffset(Offset = "0x14")]
      public ReqBtlCom.AdvanceStar[] advance_stars;
      [Token(Token = "0x4004C01")]
      [FieldOffset(Offset = "0x18")]
      public JSON_ChapterCount[] areas;
      [Token(Token = "0x4004C02")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_StoryExChallengeCount story_ex_challenge;
      [Token(Token = "0x4004C03")]
      [FieldOffset(Offset = "0x20")]
      public JSON_QuestCombatPowers combat_powers;
      [Token(Token = "0x4004C04")]
      [FieldOffset(Offset = "0x24")]
      public JSON_ExtraQuestClearElementProgress[] elem_ex_quests;

      [Token(Token = "0x6005614")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ReqBtlComResponse()
      {
      }
    }
  }
}
