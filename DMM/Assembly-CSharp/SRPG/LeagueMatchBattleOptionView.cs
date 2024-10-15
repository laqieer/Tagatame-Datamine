// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchBattleOptionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026B5")]
  [FlowNode.Pin(101, "通知設定Request", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(201, "閉じる実行", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(3, "攻撃防衛通知", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(12, "閉じる", FlowNode.PinTypes.Input, 12)]
  public class LeagueMatchBattleOptionView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B576")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400B577")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x400B578")]
    private const int PIN_INPUT_ATTACK_NOTICE = 3;
    [Token(Token = "0x400B579")]
    private const int PIN_INPUT_CLOSE = 12;
    [Token(Token = "0x400B57A")]
    private const int PIN_OUTPUT_SETTING_REQ = 101;
    [Token(Token = "0x400B57B")]
    private const int PIN_OUTPUT_CLOSE = 201;
    [Token(Token = "0x400B57C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400B57D")]
    [FieldOffset(Offset = "0x10")]
    private bool IsAttackNoticeEnable;
    [Token(Token = "0x400B57E")]
    [FieldOffset(Offset = "0x14")]
    private LeagueMatchBattleOptionModel mLeagueMatchBattleOptionModel;

    [Token(Token = "0x600AD1F")]
    [Address(RVA = "0x70A970", Offset = "0x709770", VA = "0x1070A970", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD20")]
    [Address(RVA = "0x70AC60", Offset = "0x709A60", VA = "0x1070AC60")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AD21")]
    [Address(RVA = "0x70AD60", Offset = "0x709B60", VA = "0x1070AD60")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD22")]
    [Address(RVA = "0x70ADE0", Offset = "0x709BE0", VA = "0x1070ADE0")]
    private void SelectAttackNoticeSetting()
    {
    }

    [Token(Token = "0x600AD23")]
    [Address(RVA = "0x70AB90", Offset = "0x709990", VA = "0x1070AB90")]
    public void Close()
    {
    }

    [Token(Token = "0x600AD24")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchBattleOptionView()
    {
    }
  }
}
