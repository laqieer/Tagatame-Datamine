// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002844")]
  [FlowNode.Pin(121, "報酬の受け取り：個人", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(122, "報酬の受け取り：ポート", FlowNode.PinTypes.Output, 122)]
  [FlowNode.Pin(131, "詳細情報：個人", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(132, "詳細情報：ポート", FlowNode.PinTypes.Output, 132)]
  [FlowNode.Pin(191, "画面クリックを許可", FlowNode.PinTypes.Output, 191)]
  [FlowNode.Pin(99, "初期化", FlowNode.PinTypes.Input, 99)]
  [FlowNode.Pin(201, "リフレッシュの完了", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(11, "画面更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "ポート情報：取得", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(192, "画面クリックを不許可", FlowNode.PinTypes.Output, 192)]
  public class PointQuestReward : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C018")]
    private const int PIN_INPUT_REFRESH = 11;
    [Token(Token = "0x400C019")]
    private const int PIN_INPUT_INIT = 99;
    [Token(Token = "0x400C01A")]
    private const int PIN_OUTPUT_GET_PORT_INFO = 101;
    [Token(Token = "0x400C01B")]
    private const int PIN_OUTPUT_REWARD_PERSON = 121;
    [Token(Token = "0x400C01C")]
    private const int PIN_OUTPUT_REWARD_PORT = 122;
    [Token(Token = "0x400C01D")]
    private const int PIN_OUTPUT_PERSON_DETAIL = 131;
    [Token(Token = "0x400C01E")]
    private const int PIN_OUTPUT_PORT_DETAIL = 132;
    [Token(Token = "0x400C01F")]
    private const int PIN_OUTPUT_BLOCK_RAYCAST_ON = 191;
    [Token(Token = "0x400C020")]
    private const int PIN_OUTPUT_BLOCK_RAYCAST_OFF = 192;
    [Token(Token = "0x400C021")]
    private const int PIN_OUTPUT_REFRESH = 201;
    [Token(Token = "0x400C022")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼受け取りのコンテンツ関連")]
    [SerializeField]
    private GameObject mTempObjectParent;
    [Token(Token = "0x400C023")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PointQuestRewardParam mTempObject;
    [Token(Token = "0x400C024")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_ScrollRect mScrollRect;
    [Token(Token = "0x400C025")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mIndependentCover;
    [Token(Token = "0x400C026")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [HeaderBar("▼タブボタン関連")]
    private ToggleGroup mPageTabGroup;
    [Token(Token = "0x400C027")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle mPageTabButtonPerson;
    [Token(Token = "0x400C028")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle mPageTabButtonPort;
    [Token(Token = "0x400C029")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("▼一括受け取りボタン")]
    [SerializeField]
    private SRPG_Button mAllRewardButton;
    [Token(Token = "0x400C02A")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [HeaderBar("▼個人の情報設定用")]
    private PointQuestRewardMineInfo mMinePointInfo;
    [Token(Token = "0x400C02B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SRPG_Button mUserDetailButton;
    [Token(Token = "0x400C02C")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private PointQuestRewardPortInfo mPortPointInfo;
    [Token(Token = "0x400C02D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SRPG_Button mPortDetailButton;
    [Token(Token = "0x400C02E")]
    [FieldOffset(Offset = "0x3C")]
    [HeaderBar("▼初期ページ設定")]
    [SerializeField]
    private PointQuestReward.RewardPage mStartRewardPage;
    [Token(Token = "0x400C02F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [HeaderBar("▼詳細取得用のパラメータ")]
    private SerializeValueBehaviour mInfoParams;
    [Token(Token = "0x400C030")]
    [FieldOffset(Offset = "0x44")]
    private PointQuestReward.RewardPage CurrentRewardPage;
    [Token(Token = "0x400C031")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<PointQuestReward.RewardPage, string> RewardKeyList;
    [Token(Token = "0x400C032")]
    [FieldOffset(Offset = "0x4C")]
    private List<PointQuestRewardParam> RewardList;
    [Token(Token = "0x400C033")]
    [FieldOffset(Offset = "0x50")]
    private List<string> SelectRewardList;
    [Token(Token = "0x400C034")]
    [FieldOffset(Offset = "0x54")]
    public List<PointQuestRewardStatus> RewardStatusList;
    [Token(Token = "0x400C035")]
    [FieldOffset(Offset = "0x58")]
    private int guildMinePoint;
    [Token(Token = "0x400C036")]
    [FieldOffset(Offset = "0x5C")]
    private RewardData mReward;
    [Token(Token = "0x400C037")]
    [FieldOffset(Offset = "0x60")]
    private bool mIsGuildContribution;
    [Token(Token = "0x400C038")]
    private const float ScrollTopPosition = 1f;
    [Token(Token = "0x400C039")]
    [FieldOffset(Offset = "0x0")]
    private static PointQuestReward mInstance;

    [Token(Token = "0x170018E5")]
    public RewardData Reward
    {
      [Token(Token = "0x600B5B7"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (RewardData) null;
      }
    }

    [Token(Token = "0x170018E6")]
    public bool IsGuildContribution
    {
      [Token(Token = "0x600B5B8"), Address(RVA = "0x3A6670", Offset = "0x3A5470", VA = "0x103A6670")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170018E7")]
    public static PointQuestReward Instance
    {
      [Token(Token = "0x600B5B9"), Address(RVA = "0x7C4DD0", Offset = "0x7C3BD0", VA = "0x107C4DD0")] get
      {
        return (PointQuestReward) null;
      }
    }

    [Token(Token = "0x600B5BA")]
    [Address(RVA = "0x7C1F90", Offset = "0x7C0D90", VA = "0x107C1F90")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B5BB")]
    [Address(RVA = "0x7C32F0", Offset = "0x7C20F0", VA = "0x107C32F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B5BC")]
    [Address(RVA = "0x7C1F20", Offset = "0x7C0D20", VA = "0x107C1F20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B5BD")]
    [Address(RVA = "0x7C2920", Offset = "0x7C1720", VA = "0x107C2920")]
    private void Init()
    {
    }

    [Token(Token = "0x600B5BE")]
    [Address(RVA = "0x7C37B0", Offset = "0x7C25B0", VA = "0x107C37B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B5BF")]
    [Address(RVA = "0x7C2020", Offset = "0x7C0E20", VA = "0x107C2020")]
    private void CreateReward(List<PointQuestTotalRewardData> rewardList)
    {
    }

    [Token(Token = "0x600B5C0")]
    [Address(RVA = "0x7C41B0", Offset = "0x7C2FB0", VA = "0x107C41B0")]
    private void SetRewardData()
    {
    }

    [Token(Token = "0x600B5C1")]
    [Address(RVA = "0x7C4000", Offset = "0x7C2E00", VA = "0x107C4000")]
    private void SetCurrentPage(PointQuestReward.RewardPage nextRewardPage)
    {
    }

    [Token(Token = "0x600B5C2")]
    [Address(RVA = "0x7C2E70", Offset = "0x7C1C70", VA = "0x107C2E70")]
    public bool IsAllRewardButtonIntaractable() => new bool();

    [Token(Token = "0x600B5C3")]
    [Address(RVA = "0x7C23C0", Offset = "0x7C11C0", VA = "0x107C23C0")]
    private void GetCurrentPage()
    {
    }

    [Token(Token = "0x600B5C4")]
    [Address(RVA = "0x7C3630", Offset = "0x7C2430", VA = "0x107C3630")]
    private void OnTabToggle(bool check)
    {
    }

    [Token(Token = "0x600B5C5")]
    [Address(RVA = "0x7C3450", Offset = "0x7C2250", VA = "0x107C3450")]
    public void OnPressUnitDetailButton(Button btn)
    {
    }

    [Token(Token = "0x600B5C6")]
    [Address(RVA = "0x7C3330", Offset = "0x7C2130", VA = "0x107C3330")]
    public void OnPressPortDetailButton(Button btn)
    {
    }

    [Token(Token = "0x600B5C7")]
    [Address(RVA = "0x7C3510", Offset = "0x7C2310", VA = "0x107C3510")]
    public void OnRewardButton(SRPG_Button btn, PointQuestRewardParam btnParam)
    {
    }

    [Token(Token = "0x600B5C8")]
    [Address(RVA = "0x7C3200", Offset = "0x7C2000", VA = "0x107C3200")]
    private void OnAllRewardButton(SRPG_Button btn)
    {
    }

    [Token(Token = "0x600B5C9")]
    [Address(RVA = "0x7C4A20", Offset = "0x7C3820", VA = "0x107C4A20")]
    private void SetSelectRewardList(PointQuestRewardParam content = null)
    {
    }

    [Token(Token = "0x600B5CA")]
    [Address(RVA = "0x7C28E0", Offset = "0x7C16E0", VA = "0x107C28E0")]
    public string[] GetSelectRewardArray() => (string[]) null;

    [Token(Token = "0x600B5CB")]
    [Address(RVA = "0x7C26A0", Offset = "0x7C14A0", VA = "0x107C26A0")]
    public void GetGuildRewardStatus(JSON_PointQuestRewardStatusData[] response)
    {
    }

    [Token(Token = "0x600B5CC")]
    [Address(RVA = "0x7C24F0", Offset = "0x7C12F0", VA = "0x107C24F0")]
    public void GetGuildInfo(JSON_PointQuestGuildInfoData response)
    {
    }

    [Token(Token = "0x600B5CD")]
    [Address(RVA = "0x7C25D0", Offset = "0x7C13D0", VA = "0x107C25D0")]
    public void GetGuildMineTotalPoint(int guild_TotalPoint)
    {
    }

    [Token(Token = "0x600B5CE")]
    [Address(RVA = "0x7C30E0", Offset = "0x7C1EE0", VA = "0x107C30E0")]
    public bool IsPersonTab() => new bool();

    [Token(Token = "0x600B5CF")]
    [Address(RVA = "0x7C2FD0", Offset = "0x7C1DD0", VA = "0x107C2FD0")]
    public bool IsGuildTab() => new bool();

    [Token(Token = "0x600B5D0")]
    [Address(RVA = "0x7C4C90", Offset = "0x7C3A90", VA = "0x107C4C90")]
    public PointQuestReward()
    {
    }

    [Token(Token = "0x2002845")]
    private enum RewardPage
    {
      [Token(Token = "0x400C03B")] PERSON,
      [Token(Token = "0x400C03C")] PORT,
      [Token(Token = "0x400C03D")] NONE,
    }
  }
}
