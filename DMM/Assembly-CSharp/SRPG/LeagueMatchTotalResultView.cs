// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchTotalResultView
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
  [Token(Token = "0x20026BE")]
  [AddComponentMenu("UI/LeagueMatch/LeagueMatchTotalResultView")]
  [FlowNode.Pin(1000, "デイリー報酬表示", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(101, "ランク変動ない場合の演出開始", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "ランク変動演出開始", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(5, "デイリー報酬表示check", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(4, "ランク変動演出終了", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(2, "総獲得ポイントのカウントアップ演出開始", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "ランク変動演出開始", FlowNode.PinTypes.Input, 3)]
  public class LeagueMatchTotalResultView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B5AE")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B5AF")]
    private const int PIN_IN_TOTALSCORE_ANIMA = 2;
    [Token(Token = "0x400B5B0")]
    private const int PIN_IN_RANK_ANIMA = 3;
    [Token(Token = "0x400B5B1")]
    private const int PIN_IN_RANK_ANIMA_END = 4;
    [Token(Token = "0x400B5B2")]
    private const int PIN_IN_DAILY_REWARD_CHECK = 5;
    [Token(Token = "0x400B5B3")]
    private const int PIN_OUT_RANK_EFF = 100;
    [Token(Token = "0x400B5B4")]
    private const int PIN_OUT_NOT_RANK_EFF = 101;
    [Token(Token = "0x400B5B5")]
    private const int PIN_OUT_DAILY_REWARD = 1000;
    [Token(Token = "0x400B5B6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList _exhibitList;
    [Token(Token = "0x400B5B7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList _rankExhibitList;
    [Token(Token = "0x400B5B8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ExhibitList _countUpExhibitList;
    [Token(Token = "0x400B5B9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExhibitList _countDownExhibitList;
    [Token(Token = "0x400B5BA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B5BB")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchTotalResultModel _resultModel;
    [Token(Token = "0x400B5BC")]
    [FieldOffset(Offset = "0x24")]
    private CountAnimationModel _countUpModel;
    [Token(Token = "0x400B5BD")]
    [FieldOffset(Offset = "0x28")]
    private CountAnimationModel _countDownModel;

    [Token(Token = "0x600AD50")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AD51")]
    [Address(RVA = "0x712940", Offset = "0x711740", VA = "0x10712940", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD52")]
    [Address(RVA = "0x712C90", Offset = "0x711A90", VA = "0x10712C90")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AD53")]
    [Address(RVA = "0x7130A0", Offset = "0x711EA0", VA = "0x107130A0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD54")]
    [Address(RVA = "0x713170", Offset = "0x711F70", VA = "0x10713170")]
    private void TotalScoreAnima()
    {
    }

    [Token(Token = "0x600AD55")]
    [Address(RVA = "0x712FD0", Offset = "0x711DD0", VA = "0x10712FD0")]
    private void RankAnima()
    {
    }

    [Token(Token = "0x600AD56")]
    [Address(RVA = "0x712F30", Offset = "0x711D30", VA = "0x10712F30")]
    private void RankAnimaEnd()
    {
    }

    [Token(Token = "0x600AD57")]
    [Address(RVA = "0x712C50", Offset = "0x711A50", VA = "0x10712C50")]
    private void DailyRewardCheck()
    {
    }

    [Token(Token = "0x600AD58")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchTotalResultView()
    {
    }
  }
}
