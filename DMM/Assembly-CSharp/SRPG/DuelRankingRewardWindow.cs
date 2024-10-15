// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingRewardWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002329")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "スクロール位置リセット", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(101, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/Duel/DuelRankingRewardWindow")]
  public class DuelRankingRewardWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009D11")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009D12")]
    private const int PIN_INPUT_RESET_SCROLL_POS = 10;
    [Token(Token = "0x4009D13")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 101;
    [Token(Token = "0x4009D14")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private DuelRankingRewardContent mRewardTemplate;
    [Token(Token = "0x4009D15")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mDailyRewardRoot;
    [Token(Token = "0x4009D16")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mSeasonRewardRoot;
    [Token(Token = "0x4009D17")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect mDailyScrollRect;
    [Token(Token = "0x4009D18")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ScrollRect mSeasonScrollRect;
    [Token(Token = "0x4009D19")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentSizeFitter mDailyContentSizeFitter;
    [Token(Token = "0x4009D1A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ContentSizeFitter mSeasonContentSizeFitter;
    [Token(Token = "0x4009D1B")]
    [FieldOffset(Offset = "0x28")]
    [Space(10f)]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string REWARD_ICON_PREFAB_PATH;
    [Token(Token = "0x4009D1C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Transform mMISC;
    [Token(Token = "0x4009D1D")]
    [FieldOffset(Offset = "0x30")]
    private DuelRewardIconTemplate mIconTemplate;

    [Token(Token = "0x6009747")]
    [Address(RVA = "0x59C550", Offset = "0x59B350", VA = "0x1059C550", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009748")]
    [Address(RVA = "0x59CA20", Offset = "0x59B820", VA = "0x1059CA20")]
    private void Init()
    {
    }

    [Token(Token = "0x6009749")]
    [Address(RVA = "0x59CDB0", Offset = "0x59BBB0", VA = "0x1059CDB0")]
    private void RefreshContentSizeFitter()
    {
    }

    [Token(Token = "0x600974A")]
    [Address(RVA = "0x59C6B0", Offset = "0x59B4B0", VA = "0x1059C6B0")]
    private DuelRewardIconTemplate CreateRewardIconTemplate() => (DuelRewardIconTemplate) null;

    [Token(Token = "0x600974B")]
    [Address(RVA = "0x59C7D0", Offset = "0x59B5D0", VA = "0x1059C7D0")]
    private void CreateReward(DuelRankingRewardParam reward, Transform list_root)
    {
    }

    [Token(Token = "0x600974C")]
    [Address(RVA = "0x59CED0", Offset = "0x59BCD0", VA = "0x1059CED0")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x600974D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelRankingRewardWindow()
    {
    }
  }
}
