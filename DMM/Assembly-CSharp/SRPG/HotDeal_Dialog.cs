// Decompiled with JetBrains decompiler
// Type: SRPG.HotDeal_Dialog
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
  [Token(Token = "0x200263E")]
  [FlowNode.Pin(0, "RightAnimStart", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(1, "LeftAnimStart", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(10, "RefreshDialog", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/HotDeal/HotDeal_Dialog")]
  public class HotDeal_Dialog : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B294")]
    private const int PIN_OUTPUT_START_RIGHT_ANIM = 0;
    [Token(Token = "0x400B295")]
    private const int PIN_OUTPUT_START_LEFT_ANIM = 1;
    [Token(Token = "0x400B296")]
    private const int PIN_INPUT_REFRESH_DIALOG = 10;
    [Token(Token = "0x400B297")]
    [FieldOffset(Offset = "0xC")]
    [Header("名前")]
    [SerializeField]
    private Text m_TextName;
    [Token(Token = "0x400B298")]
    [FieldOffset(Offset = "0x10")]
    [Header("価格")]
    [SerializeField]
    private Text m_Price;
    [Token(Token = "0x400B299")]
    [FieldOffset(Offset = "0x14")]
    [Header("販売時間")]
    [SerializeField]
    private HotDeal_Timer m_timer;
    [Token(Token = "0x400B29A")]
    [FieldOffset(Offset = "0x18")]
    [Header("購入ボタン")]
    [SerializeField]
    private Button m_BuyButton;
    [Token(Token = "0x400B29B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Header("右ボタン")]
    private Button m_RightButton;
    [Token(Token = "0x400B29C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("左ボタン")]
    private Button m_LeftButton;
    [Token(Token = "0x400B29D")]
    [FieldOffset(Offset = "0x24")]
    [Header("右未確認商品")]
    [SerializeField]
    private GameObject m_RightBadge;
    [Token(Token = "0x400B29E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("左未確認商品")]
    private GameObject m_LeftBadge;
    [Token(Token = "0x400B29F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Header("ヘルプボタン")]
    private Button m_HelpButton;
    [Token(Token = "0x400B2A0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("Loadするprefabのpathと、その親")]
    private string ResourcePath;
    [Token(Token = "0x400B2A1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject m_LoadPrefabParent;
    [Token(Token = "0x400B2A2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("報酬アイテム表示切り替え個数(+幻晶石アイコンが追加されているので表示個数は+1されます)")]
    private int m_SwitchItemDisplayNum;
    [Token(Token = "0x400B2A3")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    [Header("報酬アイテム表示個数より小さい場合に使用")]
    private GameObject m_SwitchItemDisplayLow;
    [Token(Token = "0x400B2A4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RewardListItem m_SwitchItemDisplayLowReward;
    [Token(Token = "0x400B2A5")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [Header("報酬アイテム表示個数より大きい場合に使用")]
    private GameObject m_SwitchItemDisplayHigh;
    [Token(Token = "0x400B2A6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RewardListItem m_SwitchItemDisplayHighReward;
    [Token(Token = "0x400B2A7")]
    [FieldOffset(Offset = "0x4C")]
    [Header("発生期間中再表示しない")]
    [SerializeField]
    private Toggle m_CheckToggle;
    [Token(Token = "0x400B2A8")]
    private const int SWITCH_ITEM_DESPLAY_DEFAULT = 7;
    [Token(Token = "0x400B2A9")]
    [FieldOffset(Offset = "0x50")]
    private HotDealInfo m_info;
    [Token(Token = "0x400B2AA")]
    [FieldOffset(Offset = "0x54")]
    private GameObject m_load_object;
    [Token(Token = "0x400B2AB")]
    [FieldOffset(Offset = "0x58")]
    private List<RewardListItem> m_RewardList;
    [Token(Token = "0x400B2AC")]
    [FieldOffset(Offset = "0x5C")]
    private int m_RewardItemIconNum;

    [Token(Token = "0x600AAA3")]
    [Address(RVA = "0x6E1B40", Offset = "0x6E0940", VA = "0x106E1B40")]
    private void Start()
    {
    }

    [Token(Token = "0x600AAA4")]
    [Address(RVA = "0x6E1D90", Offset = "0x6E0B90", VA = "0x106E1D90")]
    private void Update()
    {
    }

    [Token(Token = "0x600AAA5")]
    [Address(RVA = "0x6E0760", Offset = "0x6DF560", VA = "0x106E0760", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AAA6")]
    [Address(RVA = "0x6E11B0", Offset = "0x6DFFB0", VA = "0x106E11B0")]
    private void SelectedItem()
    {
    }

    [Token(Token = "0x600AAA7")]
    [Address(RVA = "0x6E0F80", Offset = "0x6DFD80", VA = "0x106E0F80")]
    private void OnClickRight()
    {
    }

    [Token(Token = "0x600AAA8")]
    [Address(RVA = "0x6E0EF0", Offset = "0x6DFCF0", VA = "0x106E0EF0")]
    private void OnClickLeft()
    {
    }

    [Token(Token = "0x600AAA9")]
    [Address(RVA = "0x6E10D0", Offset = "0x6DFED0", VA = "0x106E10D0")]
    private void OpenURL()
    {
    }

    [Token(Token = "0x600AAAA")]
    [Address(RVA = "0x6E1A60", Offset = "0x6E0860", VA = "0x106E1A60")]
    private void SetupBuyButtonListener()
    {
    }

    [Token(Token = "0x600AAAB")]
    [Address(RVA = "0x6E1110", Offset = "0x6DFF10", VA = "0x106E1110")]
    private void RemoveBuyButtonListener()
    {
    }

    [Token(Token = "0x600AAAC")]
    [Address(RVA = "0x6E1440", Offset = "0x6E0240", VA = "0x106E1440")]
    public void SetUp(HotDealInfo _info, bool is_newly, bool is_first_view)
    {
    }

    [Token(Token = "0x600AAAD")]
    [Address(RVA = "0x6E0840", Offset = "0x6DF640", VA = "0x106E0840")]
    private void CrateCustomPrefab(bool is_newly, bool is_first_view)
    {
    }

    [Token(Token = "0x600AAAE")]
    [Address(RVA = "0x6E1320", Offset = "0x6E0120", VA = "0x106E1320")]
    private void SetUpCustomDialog(
      GameObject obj,
      string message,
      bool is_newly,
      bool is_first_view)
    {
    }

    [Token(Token = "0x600AAAF")]
    [Address(RVA = "0x6E0D60", Offset = "0x6DFB60", VA = "0x106E0D60")]
    private GameObject LoadPrefab(string name) => (GameObject) null;

    [Token(Token = "0x600AAB0")]
    [Address(RVA = "0x6E07C0", Offset = "0x6DF5C0", VA = "0x106E07C0")]
    private void CalcRewarItemIconNum()
    {
    }

    [Token(Token = "0x600AAB1")]
    [Address(RVA = "0x6E0D40", Offset = "0x6DFB40", VA = "0x106E0D40")]
    private bool IsRewardIconScroll() => new bool();

    [Token(Token = "0x600AAB2")]
    [Address(RVA = "0x6E0990", Offset = "0x6DF790", VA = "0x106E0990")]
    private void CreateHotDealItemIconList()
    {
    }

    [Token(Token = "0x600AAB3")]
    [Address(RVA = "0x6E0B70", Offset = "0x6DF970", VA = "0x106E0B70")]
    private void DrawLeftRightArrow()
    {
    }

    [Token(Token = "0x600AAB4")]
    [Address(RVA = "0x6E0AF0", Offset = "0x6DF8F0", VA = "0x106E0AF0")]
    private void DrawItemIcons()
    {
    }

    [Token(Token = "0x600AAB5")]
    [Address(RVA = "0x6E1010", Offset = "0x6DFE10", VA = "0x106E1010")]
    private void OnValueChange(bool value)
    {
    }

    [Token(Token = "0x600AAB6")]
    [Address(RVA = "0x6E1E90", Offset = "0x6E0C90", VA = "0x106E1E90")]
    public HotDeal_Dialog()
    {
    }
  }
}
