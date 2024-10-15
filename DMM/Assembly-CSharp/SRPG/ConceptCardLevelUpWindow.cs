// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardLevelUpWindow
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
  [Token(Token = "0x200221C")]
  [AddComponentMenu("UI/ConceptCardLevelUpWindow")]
  [FlowNode.Pin(31, "一括強化、限界突破の素材の選択完了", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(11, "強化素材画面のタブを押した", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "錬金素材画面のタブを押した", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(21, "限界突破画面のタブを押した", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(3, "選択クリアボタンを押した", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "MAXボタンを押した", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(5, "限界突破画面のタブを押した", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(2, "錬金素材画面のタブを押した", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "強化素材画面のタブを押した", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "一括強化ボタンを押した", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "一括強化のための選択素材の設定完了", FlowNode.PinTypes.Output, 10)]
  public class ConceptCardLevelUpWindow : ConceptCardDetailBase, IFlowInterface
  {
    [Token(Token = "0x40096C4")]
    public const int PIN_INPUT_PUSH_ENHANCE_BUTTON = 0;
    [Token(Token = "0x40096C5")]
    public const int PIN_INPUT_PUSH_ENHANCE_TOGGLE_BUTTON = 1;
    [Token(Token = "0x40096C6")]
    public const int PIN_INPUT_PUSH_TRUST_TOGGLE_BUTTON = 2;
    [Token(Token = "0x40096C7")]
    public const int PIN_INPUT_PUSH_CLEAR_BUTTON = 3;
    [Token(Token = "0x40096C8")]
    public const int PIN_INPUT_PUSH_MAX_BUTTON = 4;
    [Token(Token = "0x40096C9")]
    public const int PIN_INPUT_PUSH_LIMIT_TOGGLE_BUTTON = 5;
    [Token(Token = "0x40096CA")]
    public const int PIN_OUTPUT_PUSH_ENHANCE_BUTTON = 10;
    [Token(Token = "0x40096CB")]
    public const int PIN_OUTPUT_PUSH_ENHANCE_TAB = 11;
    [Token(Token = "0x40096CC")]
    public const int PIN_OUTPUT_PUSH_TRUST_TAB = 12;
    [Token(Token = "0x40096CD")]
    public const int PIN_OUTPUT_PUSH_LIMIT_TAB = 21;
    [Token(Token = "0x40096CE")]
    public const int PIN_OUTPUT_PUSH_LIMITUP_BUTTON = 31;
    [Token(Token = "0x40096CF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ScrollRect CardScrollRect;
    [Token(Token = "0x40096D0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject SelectedCardIcon;
    [Token(Token = "0x40096D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform TrustEnhanceListParent;
    [Token(Token = "0x40096D2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RectTransform LimitUpListParent;
    [Token(Token = "0x40096D3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject TrustEnhanceListItemTemplate;
    [Token(Token = "0x40096D4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject LimitUpItemTemplate;
    [Token(Token = "0x40096D5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text CurrentLevel;
    [Token(Token = "0x40096D6")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text FinishedLevel;
    [Token(Token = "0x40096D7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text MaxLevel;
    [Token(Token = "0x40096D8")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text NextExp;
    [Token(Token = "0x40096D9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Slider CardLvSlider;
    [Token(Token = "0x40096DA")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text GetAllExp;
    [Token(Token = "0x40096DB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button DecideBtn;
    [Token(Token = "0x40096DC")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Button MaxBtn;
    [Token(Token = "0x40096DD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SliderAnimator AddLevelGauge;
    [Token(Token = "0x40096DE")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject MainLevelup;
    [Token(Token = "0x40096DF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject MainTrust;
    [Token(Token = "0x40096E0")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject MainLimit;
    [Token(Token = "0x40096E1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Toggle TabEnhanceToggle;
    [Token(Token = "0x40096E2")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Toggle TabTrustToggle;
    [Token(Token = "0x40096E3")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Toggle TabLimitToggle;
    [Token(Token = "0x40096E4")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private RawImage TrustMasterRewardIcon;
    [Token(Token = "0x40096E5")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Image TrustMasterRewardFrame;
    [Token(Token = "0x40096E6")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject TrustMasterRewardItemIconObject;
    [Token(Token = "0x40096E7")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private ConceptCardIcon TrustMasterRewardCardIcon;
    [Token(Token = "0x40096E8")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Text TrustValueTxt;
    [Token(Token = "0x40096E9")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text TrustPredictValueTxt;
    [Token(Token = "0x40096EA")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private GameObject ItemNoneText;
    [Token(Token = "0x40096EB")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject mAwakeCountAfterIconsParent;
    [Token(Token = "0x40096EC")]
    [FieldOffset(Offset = "0x84")]
    private Dictionary<string, int> mSelectExpMaterials;
    [Token(Token = "0x40096ED")]
    [FieldOffset(Offset = "0x88")]
    private List<ConceptCardMaterialData> mCacheMaxCardExpMaterialList;
    [Token(Token = "0x40096EE")]
    [FieldOffset(Offset = "0x8C")]
    private List<ConceptCardLevelUpListItem> mCCExpListItem;
    [Token(Token = "0x40096EF")]
    [FieldOffset(Offset = "0x90")]
    private Dictionary<string, int> mSelectTrustMaterials;
    [Token(Token = "0x40096F0")]
    [FieldOffset(Offset = "0x94")]
    private List<ConceptCardMaterialData> mCacheMaxCardTrustMaterialList;
    [Token(Token = "0x40096F1")]
    [FieldOffset(Offset = "0x98")]
    private List<ConceptCardLevelUpListItem> mCCTrustListItem;
    [Token(Token = "0x40096F2")]
    [FieldOffset(Offset = "0x9C")]
    private List<ConceptCardLimitUpListItem> mCCLimitUpListItem;
    [Token(Token = "0x40096F3")]
    [FieldOffset(Offset = "0xA0")]
    private int mLv;
    [Token(Token = "0x40096F4")]
    [FieldOffset(Offset = "0xA4")]
    private int mExp;
    [Token(Token = "0x40096F5")]
    [FieldOffset(Offset = "0xA8")]
    private int mTrust;
    [Token(Token = "0x40096F6")]
    [FieldOffset(Offset = "0xAC")]
    private int mAwakeCap;
    [Token(Token = "0x40096F7")]
    [FieldOffset(Offset = "0xB0")]
    private int mCurrentAwakeCount;
    [Token(Token = "0x40096F8")]
    [FieldOffset(Offset = "0xB4")]
    private ConceptCardLevelUpWindow.TabState mTabState;
    [Token(Token = "0x40096F9")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private ContentController Controller;
    [Token(Token = "0x40096FA")]
    [FieldOffset(Offset = "0xBC")]
    private List<ConceptCardLevelupListItemParam> mLevelupItemList;
    [Token(Token = "0x40096FB")]
    [FieldOffset(Offset = "0xC0")]
    private List<ConceptCardLevelupListItemParam> mExpListItem;
    [Token(Token = "0x40096FC")]
    [FieldOffset(Offset = "0xC4")]
    private List<ConceptCardLevelupListItemParam> mTrustListItem;
    [Token(Token = "0x40096FD")]
    [FieldOffset(Offset = "0xC8")]
    private List<ConceptCardLimitupListItemParam> mLimitupListItem;
    [Token(Token = "0x40096FE")]
    [FieldOffset(Offset = "0xCC")]
    private ContentSource mCurrentContentSource;
    [Token(Token = "0x40096FF")]
    [FieldOffset(Offset = "0xD0")]
    private ContentSource mExpContentSource;
    [Token(Token = "0x4009700")]
    [FieldOffset(Offset = "0xD4")]
    private ContentSource mTrustContentSource;
    [Token(Token = "0x4009701")]
    [FieldOffset(Offset = "0xD8")]
    private ContentSource mLimitupContentSource;

    [Token(Token = "0x1700146D")]
    private List<ConceptCardMaterialData> ConceptCardExpMaterials
    {
      [Token(Token = "0x60090CE"), Address(RVA = "0x546F00", Offset = "0x545D00", VA = "0x10546F00")] get
      {
        return (List<ConceptCardMaterialData>) null;
      }
    }

    [Token(Token = "0x1700146E")]
    private List<ConceptCardMaterialData> ConceptCardTrustMaterials
    {
      [Token(Token = "0x60090CF"), Address(RVA = "0x546F50", Offset = "0x545D50", VA = "0x10546F50")] get
      {
        return (List<ConceptCardMaterialData>) null;
      }
    }

    [Token(Token = "0x60090D0")]
    [Address(RVA = "0x546830", Offset = "0x545630", VA = "0x10546830")]
    private void Start()
    {
    }

    [Token(Token = "0x60090D1")]
    [Address(RVA = "0x5415D0", Offset = "0x5403D0", VA = "0x105415D0")]
    private void InitSelectedCardData()
    {
    }

    [Token(Token = "0x60090D2")]
    [Address(RVA = "0x542110", Offset = "0x540F10", VA = "0x10542110")]
    private void InitializeContentList()
    {
    }

    [Token(Token = "0x60090D3")]
    [Address(RVA = "0x543050", Offset = "0x541E50", VA = "0x10543050")]
    private void RefreshContentlist()
    {
    }

    [Token(Token = "0x60090D4")]
    [Address(RVA = "0x5464E0", Offset = "0x5452E0", VA = "0x105464E0")]
    private void SetupExpList()
    {
    }

    [Token(Token = "0x60090D5")]
    [Address(RVA = "0x5466E0", Offset = "0x5454E0", VA = "0x105466E0")]
    private void SetupTrustList()
    {
    }

    [Token(Token = "0x60090D6")]
    [Address(RVA = "0x546630", Offset = "0x545430", VA = "0x10546630")]
    private void SetupLimitupList()
    {
    }

    [Token(Token = "0x60090D7")]
    [Address(RVA = "0x540E90", Offset = "0x53FC90", VA = "0x10540E90")]
    private List<string> GetUseCheckList() => (List<string>) null;

    [Token(Token = "0x60090D8")]
    [Address(RVA = "0x544F30", Offset = "0x543D30", VA = "0x10544F30")]
    private ContentSource SetContentList(
      IReadOnlyList<ConceptCardMaterialData> material_list,
      IReadOnlyList<string> use_check_list)
    {
      return (ContentSource) null;
    }

    [Token(Token = "0x60090D9")]
    [Address(RVA = "0x544AC0", Offset = "0x5438C0", VA = "0x10544AC0")]
    private ContentSource SetContentList(
      IReadOnlyList<ConceptLimitUpItemParam> limitup_list)
    {
      return (ContentSource) null;
    }

    [Token(Token = "0x60090DA")]
    [Address(RVA = "0x540F60", Offset = "0x53FD60", VA = "0x10540F60")]
    private void InitListItem()
    {
    }

    [Token(Token = "0x60090DB")]
    [Address(RVA = "0x541990", Offset = "0x540790", VA = "0x10541990")]
    private void InitSetTab()
    {
    }

    [Token(Token = "0x60090DC")]
    [Address(RVA = "0x541A80", Offset = "0x540880", VA = "0x10541A80")]
    private void InitTrust()
    {
    }

    [Token(Token = "0x60090DD")]
    [Address(RVA = "0x541C50", Offset = "0x540A50", VA = "0x10541C50")]
    private void InitWindowButton()
    {
    }

    [Token(Token = "0x60090DE")]
    [Address(RVA = "0x53FA20", Offset = "0x53E820", VA = "0x1053FA20", Slot = "8")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60090DF")]
    [Address(RVA = "0x5429A0", Offset = "0x5417A0", VA = "0x105429A0")]
    private void OnClear()
    {
    }

    [Token(Token = "0x60090E0")]
    [Address(RVA = "0x542BF0", Offset = "0x5419F0", VA = "0x10542BF0")]
    private void OnMax()
    {
    }

    [Token(Token = "0x60090E1")]
    [Address(RVA = "0x5424B0", Offset = "0x5412B0", VA = "0x105424B0")]
    private int OnCheck(string iname, int num) => new int();

    [Token(Token = "0x60090E2")]
    [Address(RVA = "0x5422E0", Offset = "0x5410E0", VA = "0x105422E0")]
    private int OnCheckLimitUp(string iname, int num) => new int();

    [Token(Token = "0x60090E3")]
    [Address(RVA = "0x544240", Offset = "0x543040", VA = "0x10544240")]
    private void RefreshParamSelectItems(string iname, int value)
    {
    }

    [Token(Token = "0x60090E4")]
    [Address(RVA = "0x543190", Offset = "0x541F90", VA = "0x10543190")]
    private void RefreshFinishedExpStatus()
    {
    }

    [Token(Token = "0x60090E5")]
    [Address(RVA = "0x53FCE0", Offset = "0x53EAE0", VA = "0x1053FCE0")]
    private void CalcCanCardLevelUpMax()
    {
    }

    [Token(Token = "0x60090E6")]
    [Address(RVA = "0x543BC0", Offset = "0x5429C0", VA = "0x10543BC0")]
    private void RefreshFinishedTrustStatus()
    {
    }

    [Token(Token = "0x60090E7")]
    [Address(RVA = "0x540CB0", Offset = "0x53FAB0", VA = "0x10540CB0")]
    private int GetNextTrustExp(int trust) => new int();

    [Token(Token = "0x60090E8")]
    [Address(RVA = "0x5404C0", Offset = "0x53F2C0", VA = "0x105404C0")]
    private void CalcCanCardTrustUpMax()
    {
    }

    [Token(Token = "0x60090E9")]
    [Address(RVA = "0x544360", Offset = "0x543160", VA = "0x10544360")]
    private void RefreshUseMaxItems(string iname, bool is_on)
    {
    }

    [Token(Token = "0x60090EA")]
    [Address(RVA = "0x544860", Offset = "0x543660", VA = "0x10544860")]
    private void SavePage()
    {
    }

    [Token(Token = "0x60090EB")]
    [Address(RVA = "0x5448D0", Offset = "0x5436D0", VA = "0x105448D0")]
    private void SaveSelectUseMax()
    {
    }

    [Token(Token = "0x60090EC")]
    [Address(RVA = "0x542210", Offset = "0x541010", VA = "0x10542210")]
    private static ConceptCardLevelUpWindow.TabState LoadTabState()
    {
      return new ConceptCardLevelUpWindow.TabState();
    }

    [Token(Token = "0x60090ED")]
    [Address(RVA = "0x5453E0", Offset = "0x5441E0", VA = "0x105453E0")]
    private void SetSelectMaterials()
    {
    }

    [Token(Token = "0x60090EE")]
    [Address(RVA = "0x545C20", Offset = "0x544A20", VA = "0x10545C20")]
    private void SetTabEnhance()
    {
    }

    [Token(Token = "0x60090EF")]
    [Address(RVA = "0x5462C0", Offset = "0x5450C0", VA = "0x105462C0")]
    private void SetTabTrust()
    {
    }

    [Token(Token = "0x60090F0")]
    [Address(RVA = "0x545E40", Offset = "0x544C40", VA = "0x10545E40")]
    private void SetTabLimitUp()
    {
    }

    [Token(Token = "0x60090F1")]
    [Address(RVA = "0x543FF0", Offset = "0x542DF0", VA = "0x10543FF0")]
    private void RefreshLimitUp()
    {
    }

    [Token(Token = "0x60090F2")]
    [Address(RVA = "0x53FBB0", Offset = "0x53E9B0", VA = "0x1053FBB0")]
    public void AddLimitUpEnable(bool enable)
    {
    }

    [Token(Token = "0x60090F3")]
    [Address(RVA = "0x542CC0", Offset = "0x541AC0", VA = "0x10542CC0")]
    private void RefreshAwakeIcons(int add_awake_count)
    {
    }

    [Token(Token = "0x60090F4")]
    [Address(RVA = "0x546C20", Offset = "0x545A20", VA = "0x10546C20")]
    public ConceptCardLevelUpWindow()
    {
    }

    [Token(Token = "0x200221D")]
    private enum TabState
    {
      [Token(Token = "0x4009703")] Enhance,
      [Token(Token = "0x4009704")] Trust,
      [Token(Token = "0x4009705")] LimitUp,
    }
  }
}
