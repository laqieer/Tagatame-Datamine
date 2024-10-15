// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LeagueMatchSchedule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001749")]
  [FlowNode.Pin(11, "攻撃可能期間", FlowNode.PinTypes.Output, 11)]
  [FlowNode.NodeType("LeagueMatch/Schedule", 32741)]
  [FlowNode.Pin(10, "season終了", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(22, "入場条件を満たしていない", FlowNode.PinTypes.Output, 22)]
  [FlowNode.Pin(21, "マッチング期間外", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(2, "マッチングチェック", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(20, "マッチング中", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(13, "準備期間", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(12, "ランキング集計期間", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(1, "input", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_LeagueMatchSchedule : FlowNode
  {
    [Token(Token = "0x40053C0")]
    private const int PIN_IN_INPUT = 1;
    [Token(Token = "0x40053C1")]
    private const int PIN_IN_CHECK_MATCHING = 2;
    [Token(Token = "0x40053C2")]
    private const int PIN_OUT_SEASON_CLOSE = 10;
    [Token(Token = "0x40053C3")]
    private const int PIN_OUT_ATTACK_OPEN = 11;
    [Token(Token = "0x40053C4")]
    private const int PIN_OUT_RANKING = 12;
    [Token(Token = "0x40053C5")]
    private const int PIN_OUT_PREPARATION = 13;
    [Token(Token = "0x40053C6")]
    private const int PIN_OUT_MATCHING = 20;
    [Token(Token = "0x40053C7")]
    private const int PIN_OUT_NO_MATCHING = 21;
    [Token(Token = "0x40053C8")]
    private const int PIN_OUT_NO_ENTRY = 22;
    [Token(Token = "0x40053C9")]
    [FieldOffset(Offset = "0x18")]
    private int entryUnitCount;
    [Token(Token = "0x40053CA")]
    [FieldOffset(Offset = "0x1C")]
    private bool isMatching;

    [Token(Token = "0x6005EA6")]
    [Address(RVA = "0x1331170", Offset = "0x132FF70", VA = "0x11331170", Slot = "5")]
    public override void OnActivate(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x6005EA7")]
    [Address(RVA = "0x13312F0", Offset = "0x13300F0", VA = "0x113312F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005EA8")]
    [Address(RVA = "0x127F7E0", Offset = "0x127E5E0", VA = "0x1127F7E0")]
    public FlowNode_LeagueMatchSchedule()
    {
    }
  }
}
