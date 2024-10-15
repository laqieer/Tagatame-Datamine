// Decompiled with JetBrains decompiler
// Type: SRPG.PartyWindow2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027CE")]
  [FlowNode.Pin(20, "アイテム選択開始", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(200, "フレンドがサポートに設定された", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(210, "フレンド以外がサポートが設定された", FlowNode.PinTypes.Output, 210)]
  [FlowNode.Pin(220, "サポートが解除された", FlowNode.PinTypes.Output, 220)]
  [FlowNode.Pin(250, "リネームボタンが押された", FlowNode.PinTypes.Output, 250)]
  [FlowNode.Pin(300, "パーティ情報の更新（開始）", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(319, "ストーリーEX挑戦回数リセット", FlowNode.PinTypes.Output, 319)]
  [FlowNode.Pin(160, "真理念装表示更新完了", FlowNode.PinTypes.Output, 160)]
  [FlowNode.Pin(320, "ストーリーEXトータル挑戦回数リセット", FlowNode.PinTypes.Output, 320)]
  [FlowNode.Pin(330, "表示更新(挑戦回数リセット)", FlowNode.PinTypes.Input, 330)]
  [FlowNode.Pin(340, "ポイントクエストデータ取得通信開始", FlowNode.PinTypes.Output, 340)]
  [FlowNode.Pin(341, "ポイントクエストデータ取得通信完了", FlowNode.PinTypes.Input, 341)]
  [FlowNode.Pin(342, "バトル設定を閉じた", FlowNode.PinTypes.Input, 342)]
  [FlowNode.Pin(343, "刻印自動分解設定変更", FlowNode.PinTypes.Input, 343)]
  [FlowNode.Pin(344, "刻印自動分解設定保存API開始", FlowNode.PinTypes.Output, 344)]
  [FlowNode.Pin(310, "パーティ情報の更新（終了）", FlowNode.PinTypes.Output, 310)]
  [FlowNode.Pin(21, "アイテム選択完了", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(150, "真理念装表示更新", FlowNode.PinTypes.Input, 150)]
  [FlowNode.Pin(130, "強制的に更新", FlowNode.PinTypes.Input, 130)]
  [FlowNode.Pin(11, "ユニット選択完了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(10, "ユニット選択開始", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(4, "開く", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "戻る", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(40, "チーム名変更完了", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(41, "おまかせ編成完了", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(140, "強制的に更新(チームのリロードなし)", FlowNode.PinTypes.Input, 140)]
  [FlowNode.Pin(1, "進む", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(50, "クエスト更新", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(6, "画面アンロック", FlowNode.PinTypes.Output, 6)]
  [FlowNode.Pin(7, "AP回復アイテム", FlowNode.PinTypes.Output, 7)]
  [FlowNode.Pin(8, "マルチタワー用進む", FlowNode.PinTypes.Output, 8)]
  [FlowNode.Pin(100, "ユニット選択", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(101, "サポートユニット選択", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(110, "ユニット解除", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(119, "ユニットリストウィンド開いた", FlowNode.PinTypes.Input, 119)]
  [FlowNode.Pin(120, "ユニットリストウィンド閉じ始めた", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(5, "画面ロック", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(111, "サポートユニット解除", FlowNode.PinTypes.Input, 111)]
  public class PartyWindow2 : MonoBehaviour, IFlowInterface, ISortableList
  {
    [Token(Token = "0x400BC90")]
    public const int PIN_OUTPUT_BACK = 3;
    [Token(Token = "0x400BC91")]
    public const int PIN_OUTPUT_OPEN = 4;
    [Token(Token = "0x400BC92")]
    public const int PIN_OUTPUT_UNIT_SELSTART = 10;
    [Token(Token = "0x400BC93")]
    public const int PIN_OUTPUT_UNIT_SELEND = 11;
    [Token(Token = "0x400BC94")]
    public const int PIN_OUTPUT_ITEM_SELSTART = 20;
    [Token(Token = "0x400BC95")]
    public const int PIN_OUTPUT_ITEM_SELEND = 21;
    [Token(Token = "0x400BC96")]
    public const int PIN_INPUT_TEAM_NAME = 40;
    [Token(Token = "0x400BC97")]
    public const int PIN_INPUT_RECOMMEND_TEAM = 41;
    [Token(Token = "0x400BC98")]
    public const int PIN_INPUT_QUEST_REFRESH = 50;
    [Token(Token = "0x400BC99")]
    public const int PIN_OUTPUT_GO = 1;
    [Token(Token = "0x400BC9A")]
    public const int PIN_OUTPUT_LOCK = 5;
    [Token(Token = "0x400BC9B")]
    public const int PIN_OUTPUT_UNLOCK = 6;
    [Token(Token = "0x400BC9C")]
    public const int PIN_OUTPUT_AP_HEAL = 7;
    [Token(Token = "0x400BC9D")]
    public const int PIN_OUTPUT_MULTI_GO = 8;
    [Token(Token = "0x400BC9E")]
    public const int PIN_INPUT_UNIT_SELECT = 100;
    [Token(Token = "0x400BC9F")]
    public const int PIN_INPUT_SUPPORT_SELECT = 101;
    [Token(Token = "0x400BCA0")]
    public const int PIN_INPUT_UNIT_RELEASE = 110;
    [Token(Token = "0x400BCA1")]
    public const int PIN_INPUT_SUPPORT_RELEASE = 111;
    [Token(Token = "0x400BCA2")]
    public const int PIN_INPUT_UNITLIST_OPEN = 119;
    [Token(Token = "0x400BCA3")]
    public const int PIN_INPUT_UNITLIST_CLOSE = 120;
    [Token(Token = "0x400BCA4")]
    public const int PIN_INPUT_FORCE_REFRESH = 130;
    [Token(Token = "0x400BCA5")]
    public const int PIN_INPUT_FORCE_REFRESH_NOTEAM = 140;
    [Token(Token = "0x400BCA6")]
    public const int PIN_INPUT_CONCEPTCARD_REFRESH = 150;
    [Token(Token = "0x400BCA7")]
    public const int PIN_OUTPUT_CONCEPTCARD_REFRESH = 160;
    [Token(Token = "0x400BCA8")]
    public const int PIN_OUTPUT_SUPPORT_FRIEND = 200;
    [Token(Token = "0x400BCA9")]
    public const int PIN_OUTPUT_SUPPORT_OTHER = 210;
    [Token(Token = "0x400BCAA")]
    public const int PIN_OUTPUT_SUPPORT_RELEASE = 220;
    [Token(Token = "0x400BCAB")]
    public const int PIN_OUTPUT_RENAME = 250;
    [Token(Token = "0x400BCAC")]
    public const int PIN_INPUT_PARTY_REFRESH_START = 300;
    [Token(Token = "0x400BCAD")]
    public const int PIN_OUTPUT_PARTY_REFRESH_END = 310;
    [Token(Token = "0x400BCAE")]
    public const int PIN_OUTPUT_STORYEX_RESET = 319;
    [Token(Token = "0x400BCAF")]
    public const int PIN_OUTPUT_STORYEX_TOTAL_RESET = 320;
    [Token(Token = "0x400BCB0")]
    public const int PIN_INPUT_CHALLENGE_RESET = 330;
    [Token(Token = "0x400BCB1")]
    public const int PIN_OUTPUT_START_REQ_POINT_QUEST = 340;
    [Token(Token = "0x400BCB2")]
    public const int PIN_INPUT_END_REQ_POINT_QUEST = 341;
    [Token(Token = "0x400BCB3")]
    public const int PIN_INPUT_BATTLE_SETTING_CLOSE = 342;
    [Token(Token = "0x400BCB4")]
    public const int PIN_INPUT_RUNE_DISASSEMBLE_CHANGE = 343;
    [Token(Token = "0x400BCB5")]
    public const int PIN_OUTPUT_START_REQ_RUNE_DISASSEMBLE = 344;
    [Token(Token = "0x400BCB6")]
    public const int PIN_INPUT_VERSUS_EDIT_PLACE_START = 10010;
    [Token(Token = "0x400BCB7")]
    public const int PIN_OUTPUT_VERSUS_EDIT_PLACE_END = 10100;
    [Token(Token = "0x400BCB8")]
    public const int PIN_OUTPUT_VERSUS_EDIT_PLACE_FAILED = 10200;
    [Token(Token = "0x400BCB9")]
    [FieldOffset(Offset = "0xC")]
    public int MaxRaidNum;
    [Token(Token = "0x400BCBA")]
    [FieldOffset(Offset = "0x10")]
    public int DefaultRaidNum;
    [Token(Token = "0x400BCBB")]
    [FieldOffset(Offset = "0x14")]
    public PartyWindow2.EditPartyTypes PartyType;
    [Token(Token = "0x400BCBC")]
    [FieldOffset(Offset = "0x0")]
    private static PartyWindow2 mInstance;
    [Token(Token = "0x400BCBD")]
    [FieldOffset(Offset = "0x18")]
    [Space(10f)]
    [SerializeField]
    private GenericSlot UnitSlotTemplate;
    [Token(Token = "0x400BCBE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GenericSlot NpcSlotTemplate;
    [Token(Token = "0x400BCBF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform MainMemberHolder;
    [Token(Token = "0x400BCC0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform SubMemberHolder;
    [Token(Token = "0x400BCC1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GenericSlot CardSlotTemplate;
    [Token(Token = "0x400BCC2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Transform MainMemberCardHolder;
    [Token(Token = "0x400BCC3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform SubMemberCardHolder;
    [Token(Token = "0x400BCC4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    protected GenericSlot[] UnitSlots;
    [Token(Token = "0x400BCC5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected GenericSlot[] CardSlots;
    [Token(Token = "0x400BCC6")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GenericSlot FriendSlot;
    [Token(Token = "0x400BCC7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GenericSlot FriendCardSlot;
    [Token(Token = "0x400BCC8")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private string SlotChangeTrigger;
    [Token(Token = "0x400BCC9")]
    [FieldOffset(Offset = "0x48")]
    [Space(10f)]
    [SerializeField]
    private GameObject AddMainUnitOverlay;
    [Token(Token = "0x400BCCA")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject AddSubUnitOverlay;
    [Token(Token = "0x400BCCB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject AddItemOverlay;
    [Token(Token = "0x400BCCC")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject AddPopupItemOverlay;
    [Token(Token = "0x400BCCD")]
    [FieldOffset(Offset = "0x58")]
    [Space(10f)]
    [SerializeField]
    private GenericSlot[] ItemSlots;
    [Token(Token = "0x400BCCE")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private SRPG_Button ItemButton;
    [Token(Token = "0x400BCCF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GenericSlot[] PopupItemSlots;
    [Token(Token = "0x400BCD0")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    [Space(10f)]
    private FixedScrollablePulldown TeamPulldown;
    [Token(Token = "0x400BCD1")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    protected Toggle[] TeamTabs;
    [Token(Token = "0x400BCD2")]
    [FieldOffset(Offset = "0x6C")]
    [Space(10f)]
    [SerializeField]
    [FormerlySerializedAs("TotalAtk")]
    private Text TotalCombatPower;
    [Token(Token = "0x400BCD3")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GenericSlot LeaderSkill;
    [Token(Token = "0x400BCD4")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private ImageArray LeaderSkillBGImageArray;
    [Token(Token = "0x400BCD5")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GenericSlot SupportSkill;
    [Token(Token = "0x400BCD6")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private GameObject ConceptCardBonus;
    [Token(Token = "0x400BCD7")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text ConceptCardBonusRate;
    [Token(Token = "0x400BCD8")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    protected SRPG_Button ChangeLeaderSkillButton;
    [Token(Token = "0x400BCD9")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject QuestInfo;
    [Token(Token = "0x400BCDA")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private SRPG_Button QuestInfoButton;
    [Token(Token = "0x400BCDB")]
    [FieldOffset(Offset = "0x90")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string QuestDetail;
    [Token(Token = "0x400BCDC")]
    [FieldOffset(Offset = "0x94")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string QuestDetailMulti;
    [Token(Token = "0x400BCDD")]
    [FieldOffset(Offset = "0x98")]
    public bool ShowQuestInfo;
    [Token(Token = "0x400BCDE")]
    [FieldOffset(Offset = "0x99")]
    public bool UseQuestInfo;
    [Token(Token = "0x400BCDF")]
    [FieldOffset(Offset = "0x9A")]
    public bool ShowRaidInfo;
    [Token(Token = "0x400BCE0")]
    [FieldOffset(Offset = "0x9C")]
    private SRPG_Button CurrentForwardButton;
    [Token(Token = "0x400BCE1")]
    [FieldOffset(Offset = "0xA0")]
    public SRPG_Button ForwardButton;
    [Token(Token = "0x400BCE2")]
    [FieldOffset(Offset = "0xA4")]
    public bool ShowForwardButton;
    [Token(Token = "0x400BCE3")]
    [FieldOffset(Offset = "0xA8")]
    public SRPG_Button ChallangeCountResetButton;
    [Token(Token = "0x400BCE4")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    private Text ChallangeCountResetButtonText;
    [Token(Token = "0x400BCE5")]
    [FieldOffset(Offset = "0xB0")]
    public SRPG_Button LimitForwardButton;
    [Token(Token = "0x400BCE6")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string CHALLENGE_COUNT_RESET_CONFIRM;
    [Token(Token = "0x400BCE7")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string CHALLENGE_COUNT_RESET_COMPLETE;
    [Token(Token = "0x400BCE8")]
    [FieldOffset(Offset = "0xBC")]
    [Space(10f)]
    public SRPG_Button BackButton;
    [Token(Token = "0x400BCE9")]
    [FieldOffset(Offset = "0xC0")]
    public bool ShowBackButton;
    [Token(Token = "0x400BCEA")]
    [FieldOffset(Offset = "0xC1")]
    public bool EnableTeamAssign;
    [Token(Token = "0x400BCEB")]
    [FieldOffset(Offset = "0xC4")]
    public GameObject NoItemText;
    [Token(Token = "0x400BCEC")]
    [FieldOffset(Offset = "0xC8")]
    public GameObject Prefab_SankaFuka;
    [Token(Token = "0x400BCED")]
    [FieldOffset(Offset = "0xCC")]
    public float SankaFukaOpacity;
    [Token(Token = "0x400BCEE")]
    [FieldOffset(Offset = "0xD0")]
    public SRPG_Button RecommendTeamButton;
    [Token(Token = "0x400BCEF")]
    [FieldOffset(Offset = "0xD4")]
    public SRPG_Button BreakupButton;
    [Token(Token = "0x400BCF0")]
    [FieldOffset(Offset = "0xD8")]
    public SRPG_Button RenameButton;
    [Token(Token = "0x400BCF1")]
    [FieldOffset(Offset = "0xDC")]
    public SRPG_Button PrevButton;
    [Token(Token = "0x400BCF2")]
    [FieldOffset(Offset = "0xE0")]
    public SRPG_Button NextButton;
    [Token(Token = "0x400BCF3")]
    [FieldOffset(Offset = "0xE4")]
    public SRPG_Button RecentTeamButton;
    [Token(Token = "0x400BCF4")]
    [FieldOffset(Offset = "0xE8")]
    public Text TextFixParty;
    [Token(Token = "0x400BCF5")]
    [FieldOffset(Offset = "0xEC")]
    [Space(10f)]
    public RectTransform[] ChosenUnitBadges;
    [Token(Token = "0x400BCF6")]
    [FieldOffset(Offset = "0xF0")]
    public RectTransform[] ChosenItemBadges;
    [Token(Token = "0x400BCF7")]
    [FieldOffset(Offset = "0xF4")]
    public RectTransform ChosenSupportBadge;
    [Token(Token = "0x400BCF8")]
    [FieldOffset(Offset = "0xF8")]
    [Space(10f)]
    public RectTransform MainRect;
    [Token(Token = "0x400BCF9")]
    [FieldOffset(Offset = "0xFC")]
    public VirtualList UnitList;
    [Token(Token = "0x400BCFA")]
    [FieldOffset(Offset = "0x100")]
    public RectTransform UnitListHilit;
    [Token(Token = "0x400BCFB")]
    [FieldOffset(Offset = "0x104")]
    public string UnitListHilitParent;
    [Token(Token = "0x400BCFC")]
    [FieldOffset(Offset = "0x108")]
    public GameObject NoMatchingUnit;
    [Token(Token = "0x400BCFD")]
    [FieldOffset(Offset = "0x10C")]
    public bool AlwaysShowRemoveUnit;
    [Token(Token = "0x400BCFE")]
    [FieldOffset(Offset = "0x110")]
    public Text SortModeCaption;
    [Token(Token = "0x400BCFF")]
    [FieldOffset(Offset = "0x114")]
    public GameObject AscendingIcon;
    [Token(Token = "0x400BD00")]
    [FieldOffset(Offset = "0x118")]
    public GameObject DescendingIcon;
    [Token(Token = "0x400BD01")]
    [FieldOffset(Offset = "0x11C")]
    [Space(10f)]
    public VirtualList ItemList;
    [Token(Token = "0x400BD02")]
    [FieldOffset(Offset = "0x120")]
    public ListItemEvents ItemListItem;
    [Token(Token = "0x400BD03")]
    [FieldOffset(Offset = "0x124")]
    public SRPG_Button ItemRemoveItem;
    [Token(Token = "0x400BD04")]
    [FieldOffset(Offset = "0x128")]
    public RectTransform ItemListHilit;
    [Token(Token = "0x400BD05")]
    [FieldOffset(Offset = "0x12C")]
    public string ItemListHilitParent;
    [Token(Token = "0x400BD06")]
    [FieldOffset(Offset = "0x130")]
    public SRPG_Button CloseItemList;
    [Token(Token = "0x400BD07")]
    [FieldOffset(Offset = "0x134")]
    public RectTransform ItemListPopupHilit;
    [Token(Token = "0x400BD08")]
    [FieldOffset(Offset = "0x138")]
    public string ItemListPopupHilitParent;
    [Token(Token = "0x400BD09")]
    [FieldOffset(Offset = "0x13C")]
    public SRPG_ToggleButton ItemFilter_All;
    [Token(Token = "0x400BD0A")]
    [FieldOffset(Offset = "0x140")]
    public SRPG_ToggleButton ItemFilter_Offense;
    [Token(Token = "0x400BD0B")]
    [FieldOffset(Offset = "0x144")]
    public SRPG_ToggleButton ItemFilter_Support;
    [Token(Token = "0x400BD0C")]
    [FieldOffset(Offset = "0x148")]
    public bool AlwaysShowRemoveItem;
    [Token(Token = "0x400BD0D")]
    [FieldOffset(Offset = "0x14C")]
    [SerializeField]
    [Space(10f)]
    private GameObject RaidInfo;
    [Token(Token = "0x400BD0E")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private Text RaidTicketNum;
    [Token(Token = "0x400BD0F")]
    [FieldOffset(Offset = "0x154")]
    [SerializeField]
    private SRPG_Button Raid;
    [Token(Token = "0x400BD10")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private SRPG_Button RaidN;
    [Token(Token = "0x400BD11")]
    [FieldOffset(Offset = "0x15C")]
    [SerializeField]
    private Text RaidNCount;
    [Token(Token = "0x400BD12")]
    [FieldOffset(Offset = "0x160")]
    [StringIsResourcePath(typeof (RaidResultWindow))]
    [SerializeField]
    private string RaidResultPrefab;
    [Token(Token = "0x400BD13")]
    [FieldOffset(Offset = "0x164")]
    [SerializeField]
    private SRPG_Button RaidTicketPlus;
    [Token(Token = "0x400BD14")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private SRPG_Button RaidTicketMinus;
    [Token(Token = "0x400BD15")]
    [FieldOffset(Offset = "0x16C")]
    [SerializeField]
    private Text RaidAPCurrent;
    [Token(Token = "0x400BD16")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private Text RaidAPAfter;
    [Token(Token = "0x400BD17")]
    [FieldOffset(Offset = "0x174")]
    [SerializeField]
    private Color RaidAPColorEnable;
    [Token(Token = "0x400BD18")]
    [FieldOffset(Offset = "0x184")]
    [SerializeField]
    private Color RaidAPColorDisable;
    [Token(Token = "0x400BD19")]
    [FieldOffset(Offset = "0x194")]
    public GameObject RaidSettingsTemplate;
    [Token(Token = "0x400BD1A")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private GameObject RaidIconAp;
    [Token(Token = "0x400BD1B")]
    [FieldOffset(Offset = "0x19C")]
    [SerializeField]
    private GameObject RaidIconItem;
    [Token(Token = "0x400BD1C")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    [StringIsResourcePath(typeof (PointQuestResultWindow))]
    private string PointQuestSkipResultWindow;
    [Token(Token = "0x400BD1D")]
    [FieldOffset(Offset = "0x1A4")]
    [Space(10f)]
    public Toggle ToggleDirectineCut;
    [Token(Token = "0x400BD1E")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    [Space(10f)]
    private QuestCampaignCreate QuestCampaigns;
    [Token(Token = "0x400BD1F")]
    [FieldOffset(Offset = "0x1AC")]
    [Space(10f)]
    public GameObject QuestUnitCond;
    [Token(Token = "0x400BD20")]
    [FieldOffset(Offset = "0x1B0")]
    public PlayerPartyTypes[] SaveJobs;
    [Token(Token = "0x400BD21")]
    [FieldOffset(Offset = "0x1B4")]
    [Space(10f)]
    public bool EnableHeroSolo;
    [Token(Token = "0x400BD22")]
    [FieldOffset(Offset = "0x1B8")]
    [Space(10f)]
    public SRPG_Button BattleSettingButton;
    [Token(Token = "0x400BD23")]
    [FieldOffset(Offset = "0x1BC")]
    public SRPG_Button HelpButton;
    [Token(Token = "0x400BD24")]
    [FieldOffset(Offset = "0x1C0")]
    public GameObject Filter;
    [Token(Token = "0x400BD25")]
    [FieldOffset(Offset = "0x1C4")]
    [Space(10f)]
    public string UNIT_LIST_PATH;
    [Token(Token = "0x400BD26")]
    [FieldOffset(Offset = "0x1C8")]
    [Space(10f)]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string UNITLIST_WINDOW_PATH;
    [Token(Token = "0x400BD27")]
    [FieldOffset(Offset = "0x1CC")]
    protected UnitListWindow mUnitListWindow;
    [Token(Token = "0x400BD28")]
    [FieldOffset(Offset = "0x1D0")]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string CARDLIST_WINDOW_PATH;
    [Token(Token = "0x400BD29")]
    [FieldOffset(Offset = "0x1D4")]
    protected List<UnitData> mOwnUnits;
    [Token(Token = "0x400BD2A")]
    [FieldOffset(Offset = "0x1D8")]
    private List<ItemData> mOwnItems;
    [Token(Token = "0x400BD2B")]
    [FieldOffset(Offset = "0x1DC")]
    protected QuestParam mCurrentQuest;
    [Token(Token = "0x400BD2C")]
    [FieldOffset(Offset = "0x1E0")]
    protected List<UnitData> mGuestUnit;
    [Token(Token = "0x400BD2D")]
    [FieldOffset(Offset = "0x1E4")]
    protected List<PartySlotData> mSlotData;
    [Token(Token = "0x400BD2E")]
    [FieldOffset(Offset = "0x1E8")]
    private PartySlotData mSupportSlotData;
    [Token(Token = "0x400BD2F")]
    [FieldOffset(Offset = "0x1EC")]
    protected int mCurrentTeamIndex;
    [Token(Token = "0x400BD30")]
    [FieldOffset(Offset = "0x1F0")]
    protected int mSelectedRenameTeamIndex;
    [Token(Token = "0x400BD31")]
    [FieldOffset(Offset = "0x1F4")]
    protected int mMaxTeamCount;
    [Token(Token = "0x400BD32")]
    [FieldOffset(Offset = "0x1F8")]
    protected PartyWindow2.EditPartyTypes mCurrentPartyType;
    [Token(Token = "0x400BD33")]
    [FieldOffset(Offset = "0x1FC")]
    private List<SupportData> mSupports;
    [Token(Token = "0x400BD34")]
    [FieldOffset(Offset = "0x200")]
    protected SupportData mCurrentSupport;
    [Token(Token = "0x400BD35")]
    [FieldOffset(Offset = "0x204")]
    private SupportData mSelectedSupport;
    [Token(Token = "0x400BD36")]
    [FieldOffset(Offset = "0x208")]
    protected ItemData[] mCurrentItems;
    [Token(Token = "0x400BD37")]
    [FieldOffset(Offset = "0x20C")]
    private List<RectTransform> mUnitPoolA;
    [Token(Token = "0x400BD38")]
    [FieldOffset(Offset = "0x210")]
    private List<RectTransform> mUnitPoolB;
    [Token(Token = "0x400BD39")]
    [FieldOffset(Offset = "0x214")]
    private List<RectTransform> mItemPoolA;
    [Token(Token = "0x400BD3A")]
    [FieldOffset(Offset = "0x218")]
    private List<RectTransform> mItemPoolB;
    [Token(Token = "0x400BD3B")]
    [FieldOffset(Offset = "0x21C")]
    private List<RectTransform> mSupportPoolA;
    [Token(Token = "0x400BD3C")]
    [FieldOffset(Offset = "0x220")]
    private List<RectTransform> mSupportPoolB;
    [Token(Token = "0x400BD3D")]
    [FieldOffset(Offset = "0x224")]
    protected int mSelectedSlotIndex;
    [Token(Token = "0x400BD3E")]
    [FieldOffset(Offset = "0x228")]
    protected List<PartyEditData> mTeams;
    [Token(Token = "0x400BD3F")]
    [FieldOffset(Offset = "0x22C")]
    protected int mLockedPartySlots;
    [Token(Token = "0x400BD40")]
    [FieldOffset(Offset = "0x230")]
    protected bool mSupportLocked;
    [Token(Token = "0x400BD41")]
    [FieldOffset(Offset = "0x231")]
    private bool mItemsLocked;
    [Token(Token = "0x400BD42")]
    [FieldOffset(Offset = "0x232")]
    protected bool mIsSaving;
    [Token(Token = "0x400BD43")]
    [FieldOffset(Offset = "0x234")]
    private PartyWindow2.Callback mOnPartySaveSuccess;
    [Token(Token = "0x400BD44")]
    [FieldOffset(Offset = "0x238")]
    private PartyWindow2.Callback mOnPartySaveFail;
    [Token(Token = "0x400BD45")]
    [FieldOffset(Offset = "0x23C")]
    private RaidResultWindow mRaidResultWindow;
    [Token(Token = "0x400BD46")]
    [FieldOffset(Offset = "0x240")]
    private PointQuestResultWindow mPointQuestResultWindow;
    [Token(Token = "0x400BD47")]
    [FieldOffset(Offset = "0x244")]
    private RaidResult mRaidResult;
    [Token(Token = "0x400BD48")]
    [FieldOffset(Offset = "0x248")]
    private LoadRequest mReqRaidResultWindow;
    [Token(Token = "0x400BD49")]
    [FieldOffset(Offset = "0x24C")]
    private LoadRequest mReqQuestDetail;
    [Token(Token = "0x400BD4A")]
    [FieldOffset(Offset = "0x250")]
    private LoadRequest mReqPointQuestResultWindow;
    [Token(Token = "0x400BD4B")]
    [FieldOffset(Offset = "0x254")]
    private string[] mUnitFilter;
    [Token(Token = "0x400BD4C")]
    [FieldOffset(Offset = "0x258")]
    private bool mReverse;
    [Token(Token = "0x400BD4D")]
    [FieldOffset(Offset = "0x25C")]
    private SRPG_ToggleButton[] mItemFilterToggles;
    [Token(Token = "0x400BD4E")]
    [FieldOffset(Offset = "0x260")]
    private PartyWindow2.ItemFilterTypes mItemFilter;
    [Token(Token = "0x400BD4F")]
    [FieldOffset(Offset = "0x264")]
    protected GameObject[] mSankaFukaIcons;
    [Token(Token = "0x400BD50")]
    [FieldOffset(Offset = "0x268")]
    private RaidSettingsWindow mRaidSettings;
    [Token(Token = "0x400BD51")]
    [FieldOffset(Offset = "0x26C")]
    private int mMultiRaidNum;
    [Token(Token = "0x400BD52")]
    [FieldOffset(Offset = "0x270")]
    private int mNumRaids;
    [Token(Token = "0x400BD53")]
    [FieldOffset(Offset = "0x274")]
    private ItemParam GenAdvBossChItemParam;
    [Token(Token = "0x400BD54")]
    [FieldOffset(Offset = "0x278")]
    private int GenAdvBossChItemNeedNum;
    [Token(Token = "0x400BD55")]
    [FieldOffset(Offset = "0x27C")]
    private bool mInitialized;
    [Token(Token = "0x400BD56")]
    [FieldOffset(Offset = "0x27D")]
    private bool mIsHeloOnly;
    [Token(Token = "0x400BD57")]
    [FieldOffset(Offset = "0x27E")]
    protected bool mIsLockCurrentParty;
    [Token(Token = "0x400BD58")]
    [FieldOffset(Offset = "0x280")]
    [Space(10f)]
    public SRPG_Button ButtonMapEffectQuest;
    [Token(Token = "0x400BD59")]
    [FieldOffset(Offset = "0x284")]
    [StringIsResourcePath(typeof (GameObject))]
    public string PrefabMapEffectQuest;
    [Token(Token = "0x400BD5A")]
    [FieldOffset(Offset = "0x288")]
    private LoadRequest mReqMapEffectQuest;
    [Token(Token = "0x400BD5B")]
    [FieldOffset(Offset = "0x28C")]
    public string SceneNameHome;
    [Token(Token = "0x400BD5C")]
    [FieldOffset(Offset = "0x290")]
    private GameObject mMultiErrorMsg;
    [Token(Token = "0x400BD5D")]
    [FieldOffset(Offset = "0x294")]
    private bool mIsShowDownloadPopup;
    [Token(Token = "0x400BD5E")]
    [FieldOffset(Offset = "0x298")]
    private GameObject mConceptCardSelector;
    [Token(Token = "0x400BD5F")]
    [FieldOffset(Offset = "0x29C")]
    [SerializeField]
    [Space(10f)]
    private SRPG_Button AutoRepeatQuestBtn;
    [Token(Token = "0x400BD60")]
    [FieldOffset(Offset = "0x2A0")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestBtnMask;
    [Token(Token = "0x400BD61")]
    [FieldOffset(Offset = "0x2A4")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestBestTimeBtn;
    [Token(Token = "0x400BD62")]
    [FieldOffset(Offset = "0x2A8")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestBestTimeBtnMask;
    [Token(Token = "0x400BD63")]
    [FieldOffset(Offset = "0x2AC")]
    [SerializeField]
    private Text AutoRepeatQuestBestTimeText;
    [Token(Token = "0x400BD64")]
    [FieldOffset(Offset = "0x2B0")]
    [SerializeField]
    private GameObject mGuildRaidForcedDeck;
    [Token(Token = "0x400BD65")]
    [FieldOffset(Offset = "0x2B4")]
    [SerializeField]
    private GameObject StoryExChallengeCount;
    [Token(Token = "0x400BD66")]
    [FieldOffset(Offset = "0x2B8")]
    [SerializeField]
    private GameObject PointQuestMissionConfirmBtn;
    [Token(Token = "0x400BD67")]
    [FieldOffset(Offset = "0x2BC")]
    private bool mIsEndReqPointQuest;
    [Token(Token = "0x400BD68")]
    [FieldOffset(Offset = "0x2C0")]
    [SerializeField]
    private SRPG_Button WorldRaidBpForwardButton;
    [Token(Token = "0x400BD69")]
    [FieldOffset(Offset = "0x2C4")]
    [Space(10f)]
    [SerializeField]
    private GameObject RuneDisassembly;
    [Token(Token = "0x400BD6A")]
    [FieldOffset(Offset = "0x2C8")]
    private bool mIsAutoDisassembleAPI;
    [Token(Token = "0x400BD6B")]
    [FieldOffset(Offset = "0x2CC")]
    private Transform mTrHomeHeader;
    [Token(Token = "0x400BD6C")]
    [FieldOffset(Offset = "0x2D0")]
    private bool mUnitSlotSelected;
    [Token(Token = "0x400BD6D")]
    [FieldOffset(Offset = "0x4")]
    private static bool ForceUpdateBattleParty;

    [Token(Token = "0x1700189E")]
    public PartyWindow2.EditPartyTypes CurrentPartyType
    {
      [Token(Token = "0x600B2E4"), Address(RVA = "0x78D510", Offset = "0x78C310", VA = "0x1078D510")] get
      {
        return new PartyWindow2.EditPartyTypes();
      }
    }

    [Token(Token = "0x1700189F")]
    public static PartyWindow2 Instance
    {
      [Token(Token = "0x600B2E5"), Address(RVA = "0x78D5D0", Offset = "0x78C3D0", VA = "0x1078D5D0")] get
      {
        return (PartyWindow2) null;
      }
    }

    [Token(Token = "0x170018A0")]
    public SupportData CurrentSupport
    {
      [Token(Token = "0x600B2E6"), Address(RVA = "0x4782D0", Offset = "0x4770D0", VA = "0x104782D0")] get
      {
        return (SupportData) null;
      }
    }

    [Token(Token = "0x170018A1")]
    public RaidSettingsWindow RaidSettings
    {
      [Token(Token = "0x600B2E7"), Address(RVA = "0x78D9E0", Offset = "0x78C7E0", VA = "0x1078D9E0")] get
      {
        return (RaidSettingsWindow) null;
      }
    }

    [Token(Token = "0x170018A2")]
    public int MultiRaidNum
    {
      [Token(Token = "0x600B2E8"), Address(RVA = "0x349440", Offset = "0x348240", VA = "0x10349440")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170018A3")]
    public List<PartyEditData> Teams
    {
      [Token(Token = "0x600B2E9"), Address(RVA = "0x349610", Offset = "0x348410", VA = "0x10349610")] get
      {
        return (List<PartyEditData>) null;
      }
    }

    [Token(Token = "0x170018A4")]
    private bool IsShowDownloadPopup
    {
      [Token(Token = "0x600B2EA"), Address(RVA = "0x78D890", Offset = "0x78C690", VA = "0x1078D890")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B2EB")]
    [Address(RVA = "0x7867D0", Offset = "0x7855D0", VA = "0x107867D0")]
    protected void SetCurrentParty(PartyEditData party_data)
    {
    }

    [Token(Token = "0x600B2EC")]
    [Address(RVA = "0x786770", Offset = "0x785570", VA = "0x10786770")]
    protected void SetCurrentParty(int index)
    {
    }

    [Token(Token = "0x170018A5")]
    protected PartyEditData CurrentParty
    {
      [Token(Token = "0x600B2ED"), Address(RVA = "0x78D520", Offset = "0x78C320", VA = "0x1078D520")] get
      {
        return (PartyEditData) null;
      }
    }

    [Token(Token = "0x600B2EE")]
    [Address(RVA = "0x770610", Offset = "0x76F410", VA = "0x10770610")]
    public static string EditPartyType2String(PartyWindow2.EditPartyTypes edit_party_type)
    {
      return (string) null;
    }

    [Token(Token = "0x600B2EF")]
    [Address(RVA = "0x773450", Offset = "0x772250", VA = "0x10773450")]
    protected bool IsEventTypeQuest() => new bool();

    [Token(Token = "0x600B2F0")]
    [Address(RVA = "0x778D00", Offset = "0x777B00", VA = "0x10778D00")]
    private void OpenQuestDetail()
    {
    }

    [Token(Token = "0x170018A6")]
    private Transform TrHomeHeader
    {
      [Token(Token = "0x600B2F1"), Address(RVA = "0x78DA10", Offset = "0x78C810", VA = "0x1078DA10")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x600B2F2")]
    [Address(RVA = "0x7789C0", Offset = "0x7777C0", VA = "0x107789C0")]
    private void OpenMapEffectQuest()
    {
    }

    [Token(Token = "0x600B2F3")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    protected virtual void Init()
    {
    }

    [Token(Token = "0x600B2F4")]
    [Address(RVA = "0x76CDB0", Offset = "0x76BBB0", VA = "0x1076CDB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B2F5")]
    [Address(RVA = "0x788B70", Offset = "0x787970", VA = "0x10788B70")]
    private IEnumerator Start() => (IEnumerator) null;

    [Token(Token = "0x600B2F6")]
    [Address(RVA = "0x775BC0", Offset = "0x7749C0", VA = "0x10775BC0", Slot = "7")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x600B2F7")]
    [Address(RVA = "0x775B80", Offset = "0x774980", VA = "0x10775B80")]
    private void OnCloseItemListClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B2F8")]
    [Address(RVA = "0x76C8D0", Offset = "0x76B6D0", VA = "0x1076C8D0")]
    private void AttachAndEnable(Transform go, Transform parent, string subPath)
    {
    }

    [Token(Token = "0x600B2F9")]
    [Address(RVA = "0x775190", Offset = "0x773F90", VA = "0x10775190")]
    private void MoveToOrigin(GameObject go)
    {
    }

    [Token(Token = "0x600B2FA")]
    [Address(RVA = "0x76D1C0", Offset = "0x76BFC0", VA = "0x1076D1C0")]
    protected void ChangeEnabledArrowButtons(int index, int max)
    {
    }

    [Token(Token = "0x600B2FB")]
    [Address(RVA = "0x76D290", Offset = "0x76C090", VA = "0x1076D290", Slot = "8")]
    protected virtual void ChangeEnabledTeamTabs(int index)
    {
    }

    [Token(Token = "0x600B2FC")]
    [Address(RVA = "0x7773E0", Offset = "0x7761E0", VA = "0x107773E0", Slot = "9")]
    protected virtual void OnNextTeamChange()
    {
    }

    [Token(Token = "0x600B2FD")]
    [Address(RVA = "0x777930", Offset = "0x776730", VA = "0x10777930", Slot = "10")]
    protected virtual void OnPrevTeamChange()
    {
    }

    [Token(Token = "0x600B2FE")]
    [Address(RVA = "0x787D50", Offset = "0x786B50", VA = "0x10787D50")]
    protected void SetPullDownPrevSelection(int index)
    {
    }

    [Token(Token = "0x600B2FF")]
    [Address(RVA = "0x7787B0", Offset = "0x7775B0", VA = "0x107787B0")]
    protected bool OnTeamChangeImpl(int index) => new bool();

    [Token(Token = "0x600B300")]
    [Address(RVA = "0x788D70", Offset = "0x787B70", VA = "0x10788D70", Slot = "11")]
    protected virtual bool TeamChangeImpl(PartyEditData party) => new bool();

    [Token(Token = "0x600B301")]
    [Address(RVA = "0x778820", Offset = "0x777620", VA = "0x10778820")]
    private void OnTeamChange(int index)
    {
    }

    [Token(Token = "0x600B302")]
    [Address(RVA = "0x776470", Offset = "0x775270", VA = "0x10776470")]
    private RectTransform OnGetItemListItem(int id, int old, RectTransform current)
    {
      return (RectTransform) null;
    }

    [Token(Token = "0x600B303")]
    [Address(RVA = "0x76E3C0", Offset = "0x76D1C0", VA = "0x1076E3C0")]
    private ListItemEvents CreateItemListItem() => (ListItemEvents) null;

    [Token(Token = "0x600B304")]
    [Address(RVA = "0x77DA50", Offset = "0x77C850", VA = "0x1077DA50")]
    private void RefreshItemList()
    {
    }

    [Token(Token = "0x600B305")]
    [Address(RVA = "0x777090", Offset = "0x775E90", VA = "0x10777090")]
    private void OnItemSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600B306")]
    [Address(RVA = "0x7778D0", Offset = "0x7766D0", VA = "0x107778D0")]
    private void OnPopupItemSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600B307")]
    [Address(RVA = "0x776E80", Offset = "0x775C80", VA = "0x10776E80")]
    private void OnItemRemoveSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B308")]
    [Address(RVA = "0x7770F0", Offset = "0x775EF0", VA = "0x107770F0")]
    private void OnItemSlotOpenClick(SRPG_Button go)
    {
    }

    [Token(Token = "0x600B309")]
    [Address(RVA = "0x776EF0", Offset = "0x775CF0", VA = "0x10776EF0")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B30A")]
    [Address(RVA = "0x777480", Offset = "0x776280", VA = "0x10777480")]
    private void OnPartyMemberChange()
    {
    }

    [Token(Token = "0x600B30B")]
    [Address(RVA = "0x777120", Offset = "0x775F20", VA = "0x10777120", Slot = "12")]
    protected virtual void OnItemSlotsChange()
    {
    }

    [Token(Token = "0x600B30C")]
    [Address(RVA = "0x78BC70", Offset = "0x78AA70", VA = "0x1078BC70", Slot = "13")]
    protected virtual void UpdateLeaderSkills()
    {
    }

    [Token(Token = "0x600B30D")]
    [Address(RVA = "0x778480", Offset = "0x777280", VA = "0x10778480")]
    private void OnSlotChange(GameObject go)
    {
    }

    [Token(Token = "0x600B30E")]
    [Address(RVA = "0x781CE0", Offset = "0x780AE0", VA = "0x10781CE0")]
    private void RefreshUnitSlots()
    {
    }

    [Token(Token = "0x600B30F")]
    [Address(RVA = "0x788160", Offset = "0x786F60", VA = "0x10788160")]
    private void SetSupport(SupportData support)
    {
    }

    [Token(Token = "0x600B310")]
    [Address(RVA = "0x786A30", Offset = "0x785830", VA = "0x10786A30", Slot = "14")]
    protected virtual void SetItemSlot(int slotIndex, ItemData item)
    {
    }

    [Token(Token = "0x600B311")]
    [Address(RVA = "0x7872A0", Offset = "0x7860A0", VA = "0x107872A0", Slot = "15")]
    protected virtual void SetPartyUnit(
      int slotIndex,
      UnitData unit,
      bool isSlotChange = true,
      bool edit_party_only = false,
      bool isSwap = false)
    {
    }

    [Token(Token = "0x600B312")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "16")]
    protected virtual void BeforeSetPartyUnit()
    {
    }

    [Token(Token = "0x600B313")]
    [Address(RVA = "0x786F50", Offset = "0x785D50", VA = "0x10786F50")]
    private void SetPartyUnitForce(int slotIndex, UnitData unit, bool isSlotChange = true)
    {
    }

    [Token(Token = "0x600B314")]
    [Address(RVA = "0x776BF0", Offset = "0x7759F0", VA = "0x10776BF0")]
    private bool OnHomeMenuChange() => new bool();

    [Token(Token = "0x600B315")]
    [Address(RVA = "0x77A770", Offset = "0x779570", VA = "0x1077A770")]
    private IEnumerator PopulateItemList() => (IEnumerator) null;

    [Token(Token = "0x600B316")]
    [Address(RVA = "0x77B640", Offset = "0x77A440", VA = "0x1077B640", Slot = "17")]
    protected virtual void RecalcTotalCombatPower()
    {
    }

    [Token(Token = "0x600B317")]
    [Address(RVA = "0x7738A0", Offset = "0x7726A0", VA = "0x107738A0")]
    private bool IsMultiTowerPartySlot(int index) => new bool();

    [Token(Token = "0x600B318")]
    [Address(RVA = "0x778900", Offset = "0x777700", VA = "0x10778900", Slot = "18")]
    protected virtual void OnUnitSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600B319")]
    [Address(RVA = "0x775AD0", Offset = "0x7748D0", VA = "0x10775AD0", Slot = "19")]
    protected virtual void OnCardSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600B31A")]
    [Address(RVA = "0x7785A0", Offset = "0x7773A0", VA = "0x107785A0")]
    private void OnSupportUnitSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600B31B")]
    [Address(RVA = "0x781E30", Offset = "0x780C30", VA = "0x10781E30")]
    private UnitData[] RefreshUnits(UnitData[] units) => (UnitData[]) null;

    [Token(Token = "0x170018A7")]
    private bool IsPartyDirty
    {
      [Token(Token = "0x600B31C"), Address(RVA = "0x78D740", Offset = "0x78C540", VA = "0x1078D740")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B31D")]
    [Address(RVA = "0x777C40", Offset = "0x776A40", VA = "0x10777C40")]
    private void OnRaidClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B31E")]
    [Address(RVA = "0x777A00", Offset = "0x776800", VA = "0x10777A00")]
    private void OnRaidAPPlus(SRPG_Button button, bool is_refresh_btn_interactable)
    {
    }

    [Token(Token = "0x600B31F")]
    [Address(RVA = "0x7779D0", Offset = "0x7767D0", VA = "0x107779D0")]
    private void OnRaidAPMinus(SRPG_Button button, bool is_refresh_btn_interactable)
    {
    }

    [Token(Token = "0x600B320")]
    [Address(RVA = "0x777A30", Offset = "0x776830", VA = "0x10777A30")]
    private void OnRaidAccept(GameObject go)
    {
    }

    [Token(Token = "0x600B321")]
    [Address(RVA = "0x788890", Offset = "0x787690", VA = "0x10788890")]
    private void StartRaid()
    {
    }

    [Token(Token = "0x600B322")]
    [Address(RVA = "0x77B710", Offset = "0x77A510", VA = "0x1077B710")]
    private void RecvRaidResult(WWWResult www)
    {
    }

    [Token(Token = "0x600B323")]
    [Address(RVA = "0x7885D0", Offset = "0x7873D0", VA = "0x107885D0")]
    private IEnumerator ShowRaidResultAsync() => (IEnumerator) null;

    [Token(Token = "0x600B324")]
    [Address(RVA = "0x788550", Offset = "0x787350", VA = "0x10788550")]
    private IEnumerator ShowPointQuestSkipResultAsync(
      Json_PointQuestResult _result_data,
      int _skip_num)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600B325")]
    [Address(RVA = "0x778050", Offset = "0x776E50", VA = "0x10778050")]
    private void OnResetChallenge(WWWResult www, Action<bool> callback)
    {
    }

    [Token(Token = "0x600B326")]
    [Address(RVA = "0x7828B0", Offset = "0x7816B0", VA = "0x107828B0")]
    private void Refresh_ResetChallengeCount()
    {
    }

    [Token(Token = "0x600B327")]
    [Address(RVA = "0x7733A0", Offset = "0x7721A0", VA = "0x107733A0")]
    private void HardQuestDropPiecesUpdate()
    {
    }

    [Token(Token = "0x600B328")]
    [Address(RVA = "0x77B480", Offset = "0x77A280", VA = "0x1077B480", Slot = "20")]
    public virtual void PrepareStartQuest()
    {
    }

    [Token(Token = "0x600B329")]
    [Address(RVA = "0x7846E0", Offset = "0x7834E0", VA = "0x107846E0")]
    private void ResetChallengeCountIfNeeded(Action<bool> callback)
    {
    }

    [Token(Token = "0x600B32A")]
    [Address(RVA = "0x76D550", Offset = "0x76C350", VA = "0x1076D550")]
    private bool CheckStoryExChallengeCount() => new bool();

    [Token(Token = "0x600B32B")]
    [Address(RVA = "0x771D60", Offset = "0x770B60", VA = "0x10771D60")]
    private void GoToForward(bool didReset)
    {
    }

    [Token(Token = "0x600B32C")]
    [Address(RVA = "0x776290", Offset = "0x775090", VA = "0x10776290", Slot = "21")]
    protected virtual void OnForwardOrBackButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B32D")]
    [Address(RVA = "0x76D300", Offset = "0x76C100", VA = "0x1076D300", Slot = "22")]
    protected virtual bool CheckMember(int numMainUnits) => new bool();

    [Token(Token = "0x600B32E")]
    [Address(RVA = "0x77A7D0", Offset = "0x7795D0", VA = "0x1077A7D0", Slot = "23")]
    protected virtual void PostForwardPressed()
    {
    }

    [Token(Token = "0x600B32F")]
    [Address(RVA = "0x785310", Offset = "0x784110", VA = "0x10785310")]
    protected void SaveAndActivatePin(int pinID, int ErrPinID = -1)
    {
    }

    [Token(Token = "0x600B330")]
    [Address(RVA = "0x785900", Offset = "0x784700", VA = "0x10785900")]
    protected void SaveParty(PartyWindow2.Callback cbSuccess, PartyWindow2.Callback cbError)
    {
    }

    [Token(Token = "0x600B331")]
    [Address(RVA = "0x7854A0", Offset = "0x7842A0", VA = "0x107854A0")]
    private void SaveInventory(bool force_save = false)
    {
    }

    [Token(Token = "0x170018A8")]
    private bool InventoryDirty
    {
      [Token(Token = "0x600B332"), Address(RVA = "0x78D600", Offset = "0x78C400", VA = "0x1078D600")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B333")]
    [Address(RVA = "0x773C70", Offset = "0x772A70", VA = "0x10773C70")]
    private void JumpToBefore(GameObject dialog)
    {
    }

    [Token(Token = "0x600B334")]
    [Address(RVA = "0x78CFC0", Offset = "0x78BDC0", VA = "0x1078CFC0")]
    private IEnumerator WaitForSave() => (IEnumerator) null;

    [Token(Token = "0x600B335")]
    [Address(RVA = "0x785630", Offset = "0x784430", VA = "0x10785630")]
    private void SavePartyCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600B336")]
    [Address(RVA = "0x77FBE0", Offset = "0x77E9E0", VA = "0x1077FBE0")]
    protected void RefreshQuest()
    {
    }

    [Token(Token = "0x600B337")]
    [Address(RVA = "0x77E8D0", Offset = "0x77D6D0", VA = "0x1077E8D0")]
    protected void RefreshNoneQuestInfo(bool keepTeam)
    {
    }

    [Token(Token = "0x600B338")]
    [Address(RVA = "0x77D1A0", Offset = "0x77BFA0", VA = "0x1077D1A0")]
    public void RefreshArenaDefUnits()
    {
    }

    [Token(Token = "0x600B339")]
    [Address(RVA = "0x782A30", Offset = "0x781830", VA = "0x10782A30")]
    public void Refresh(bool keepTeam = false)
    {
    }

    [Token(Token = "0x600B33A")]
    [Address(RVA = "0x76E5A0", Offset = "0x76D3A0", VA = "0x1076E5A0")]
    private void CreateSlots()
    {
    }

    [Token(Token = "0x600B33B")]
    [Address(RVA = "0x76E480", Offset = "0x76D280", VA = "0x1076E480")]
    private GenericSlot CreateSlotObject(
      PartySlotData slotData,
      GenericSlot template,
      Transform parent)
    {
      return (GenericSlot) null;
    }

    [Token(Token = "0x600B33C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "24")]
    protected virtual void CreateSlots_Arena(
      ref List<PartySlotData> main_slots,
      ref PartySlotData support,
      ref List<PartySlotData> sub_slots)
    {
    }

    [Token(Token = "0x600B33D")]
    [Address(RVA = "0x780ED0", Offset = "0x77FCD0", VA = "0x10780ED0")]
    private void RefreshSankaStates()
    {
    }

    [Token(Token = "0x600B33E")]
    [Address(RVA = "0x788FE0", Offset = "0x787DE0", VA = "0x10788FE0")]
    private void ToggleRaidInfo()
    {
    }

    [Token(Token = "0x600B33F")]
    [Address(RVA = "0x780B60", Offset = "0x77F960", VA = "0x10780B60")]
    private void RefreshRaidTicketNum()
    {
    }

    [Token(Token = "0x600B340")]
    [Address(RVA = "0x774790", Offset = "0x773590", VA = "0x10774790")]
    private void LockSlots()
    {
    }

    [Token(Token = "0x600B341")]
    [Address(RVA = "0x773CB0", Offset = "0x772AB0", VA = "0x10773CB0", Slot = "25")]
    protected virtual void LoadInventory()
    {
    }

    [Token(Token = "0x600B342")]
    [Address(RVA = "0x77D0B0", Offset = "0x77BEB0", VA = "0x1077D0B0")]
    private void RefreshAllItemSlots()
    {
    }

    [Token(Token = "0x600B343")]
    [Address(RVA = "0x784380", Offset = "0x783180", VA = "0x10784380")]
    private bool RemoveExpiredItem_Inventory() => new bool();

    [Token(Token = "0x600B344")]
    [Address(RVA = "0x773CF0", Offset = "0x772AF0", VA = "0x10773CF0", Slot = "26")]
    public virtual void LoadRecommendedTeamSetting()
    {
    }

    [Token(Token = "0x600B345")]
    [Address(RVA = "0x785DF0", Offset = "0x784BF0", VA = "0x10785DF0")]
    private void SaveRecommendedTeamSetting(GlobalVars.RecommendTeamSetting setting)
    {
    }

    [Token(Token = "0x600B346")]
    [Address(RVA = "0x785E60", Offset = "0x784C60", VA = "0x10785E60", Slot = "27")]
    protected virtual void SaveTeamPresets()
    {
    }

    [Token(Token = "0x600B347")]
    [Address(RVA = "0x7884F0", Offset = "0x7872F0", VA = "0x107884F0", Slot = "28")]
    protected virtual void SetUnitOverWriteTeams(PartyWindow2.EditPartyTypes edit_party_type)
    {
    }

    [Token(Token = "0x600B348")]
    [Address(RVA = "0x773E80", Offset = "0x772C80", VA = "0x10773E80", Slot = "29")]
    protected virtual void LoadTeam(PartyWindow2.EditPartyTypes edit_party_type)
    {
    }

    [Token(Token = "0x600B349")]
    [Address(RVA = "0x77A740", Offset = "0x779540", VA = "0x1077A740", Slot = "30")]
    protected virtual void OverrideLoadTeam()
    {
    }

    [Token(Token = "0x600B34A")]
    [Address(RVA = "0x76C3E0", Offset = "0x76B1E0", VA = "0x1076C3E0")]
    private void AssignUnits(PartyEditData partyEditData)
    {
    }

    [Token(Token = "0x600B34B")]
    [Address(RVA = "0x773480", Offset = "0x772280", VA = "0x10773480")]
    private bool IsFixedParty(bool isSetParty = false) => new bool();

    [Token(Token = "0x600B34C")]
    [Address(RVA = "0x76DE10", Offset = "0x76CC10", VA = "0x1076DE10")]
    protected bool ContainsNotFree() => new bool();

    [Token(Token = "0x600B34D")]
    [Address(RVA = "0x76E000", Offset = "0x76CE00", VA = "0x1076E000")]
    private bool ContainsNpcOrForcedOrForcedHero() => new bool();

    [Token(Token = "0x600B34E")]
    [Address(RVA = "0x76E1E0", Offset = "0x76CFE0", VA = "0x1076E1E0")]
    private bool ContainsNpcOrForced() => new bool();

    [Token(Token = "0x600B34F")]
    [Address(RVA = "0x76E0F0", Offset = "0x76CEF0", VA = "0x1076E0F0")]
    private bool ContainsNpcOrForcedOrLocked() => new bool();

    [Token(Token = "0x600B350")]
    [Address(RVA = "0x76DF00", Offset = "0x76CD00", VA = "0x1076DF00")]
    private bool ContainsNpcOrForcedHero() => new bool();

    [Token(Token = "0x600B351")]
    [Address(RVA = "0x76E2D0", Offset = "0x76D0D0", VA = "0x1076E2D0")]
    private bool ContainsNpc() => new bool();

    [Token(Token = "0x600B352")]
    [Address(RVA = "0x76DD20", Offset = "0x76CB20", VA = "0x1076DD20")]
    private bool ContainsForcedHero() => new bool();

    [Token(Token = "0x600B353")]
    [Address(RVA = "0x773C40", Offset = "0x772A40", VA = "0x10773C40")]
    private bool IsSettableSlot(PartySlotData slotData) => new bool();

    [Token(Token = "0x600B354")]
    [Address(RVA = "0x773580", Offset = "0x772380", VA = "0x10773580")]
    private bool IsHeroSoloParty() => new bool();

    [Token(Token = "0x600B355")]
    [Address(RVA = "0x78C8E0", Offset = "0x78B6E0", VA = "0x1078C8E0")]
    private void ValidateTeam(PartyEditData partyEditData)
    {
    }

    [Token(Token = "0x600B356")]
    [Address(RVA = "0x78C840", Offset = "0x78B640", VA = "0x1078C840")]
    private void ValidateSupport(int maxTeamCount)
    {
    }

    [Token(Token = "0x600B357")]
    [Address(RVA = "0x771CE0", Offset = "0x770AE0", VA = "0x10771CE0")]
    private PartyCondType GetPartyCondType() => new PartyCondType();

    [Token(Token = "0x600B358")]
    [Address(RVA = "0x771D30", Offset = "0x770B30", VA = "0x10771D30")]
    private QuestCondParam GetPartyCondition() => (QuestCondParam) null;

    [Token(Token = "0x600B359")]
    [Address(RVA = "0x784F70", Offset = "0x783D70", VA = "0x10784F70")]
    protected void ResetTeamPulldown(
      List<PartyEditData> teams,
      int maxTeams,
      QuestParam currentQuest,
      FixedScrollablePulldown pullDown = null)
    {
    }

    [Token(Token = "0x600B35A")]
    [Address(RVA = "0x77D800", Offset = "0x77C600", VA = "0x1077D800")]
    private void RefreshGuildRaid()
    {
    }

    [Token(Token = "0x600B35B")]
    [Address(RVA = "0x780100", Offset = "0x77EF00", VA = "0x10780100")]
    private void RefreshRaidButtons(bool is_refresh_btn_interactable = true)
    {
    }

    [Token(Token = "0x600B35C")]
    [Address(RVA = "0x77FF00", Offset = "0x77ED00", VA = "0x1077FF00")]
    private void RefreshRaidAP(int count)
    {
    }

    [Token(Token = "0x600B35D")]
    [Address(RVA = "0x7712A0", Offset = "0x7700A0", VA = "0x107712A0")]
    private UnitData[] GetDefaultTeam() => (UnitData[]) null;

    [Token(Token = "0x170018A9")]
    private bool TeamsAvailable
    {
      [Token(Token = "0x600B35E"), Address(RVA = "0x78D9F0", Offset = "0x78C7F0", VA = "0x1078D9F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170018AA")]
    protected virtual int AvailableMainMemberSlots
    {
      [Token(Token = "0x600B35F"), Address(RVA = "0x78D4E0", Offset = "0x78C2E0", VA = "0x1078D4E0", Slot = "31")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B360")]
    [Address(RVA = "0x76BE10", Offset = "0x76AC10", VA = "0x1076BE10", Slot = "32")]
    public virtual void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B361")]
    [Address(RVA = "0x778540", Offset = "0x777340", VA = "0x10778540")]
    private void OnStaminaChange()
    {
    }

    [Token(Token = "0x600B362")]
    [Address(RVA = "0x781280", Offset = "0x780080", VA = "0x10781280")]
    private void RefreshUnitList()
    {
    }

    [Token(Token = "0x600B363")]
    [Address(RVA = "0x784180", Offset = "0x782F80", VA = "0x10784180", Slot = "33")]
    protected virtual void RegistPartyMember(
      List<UnitData> allUnits,
      bool heroesAvailable,
      bool selectedSlotIsEmpty,
      int numMainMembers)
    {
    }

    [Token(Token = "0x600B364")]
    [Address(RVA = "0x776CF0", Offset = "0x775AF0", VA = "0x10776CF0")]
    private void OnItemFilterChange(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B365")]
    [Address(RVA = "0x788F50", Offset = "0x787D50", VA = "0x10788F50")]
    private static void ToggleBlockRaycasts(Component component, bool block)
    {
    }

    [Token(Token = "0x600B366")]
    [Address(RVA = "0x775170", Offset = "0x773F70", VA = "0x10775170")]
    protected void LockWindow(bool y)
    {
    }

    [Token(Token = "0x600B367")]
    [Address(RVA = "0x784590", Offset = "0x783390", VA = "0x10784590", Slot = "34")]
    public virtual void Reopen(bool farceRefresh = false)
    {
    }

    [Token(Token = "0x600B368")]
    [Address(RVA = "0x788630", Offset = "0x787430", VA = "0x10788630")]
    private void ShowRaidSettings()
    {
    }

    [Token(Token = "0x600B369")]
    [Address(RVA = "0x77AC00", Offset = "0x779A00", VA = "0x1077AC00")]
    private bool PrepareRaid(int num, bool validateOnly, bool skipConfirm = false) => new bool();

    [Token(Token = "0x600B36A")]
    [Address(RVA = "0x770AE0", Offset = "0x76F8E0", VA = "0x10770AE0")]
    private bool GenAdvBossNoTicketConfirm(bool is_ticket_no_check = false) => new bool();

    [Token(Token = "0x600B36B")]
    [Address(RVA = "0x77B610", Offset = "0x77A410", VA = "0x1077B610")]
    public void RaidSettingsAccepted(RaidSettingsWindow window)
    {
    }

    [Token(Token = "0x600B36C")]
    [Address(RVA = "0x787DC0", Offset = "0x786BC0", VA = "0x10787DC0", Slot = "5")]
    public void SetSortMethod(SortMenuData sortMenuData)
    {
    }

    [Token(Token = "0x600B36D")]
    [Address(RVA = "0x776180", Offset = "0x774F80", VA = "0x10776180")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600B36E")]
    [Address(RVA = "0x776070", Offset = "0x774E70", VA = "0x10776070")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600B36F")]
    [Address(RVA = "0x7788E0", Offset = "0x7776E0", VA = "0x107788E0")]
    private void OnUnitJobChange(long unitUniqueID)
    {
    }

    [Token(Token = "0x600B370")]
    private T GetComponents<T>(GameObject root, string targetName, bool includeInactive) where T : Component
    {
      return (T) null;
    }

    [Token(Token = "0x600B371")]
    [Address(RVA = "0x784F00", Offset = "0x783D00", VA = "0x10784F00")]
    public void ResetTeamName()
    {
    }

    [Token(Token = "0x600B372")]
    [Address(RVA = "0x76CF00", Offset = "0x76BD00", VA = "0x1076CF00")]
    public void BreakupTeam()
    {
    }

    [Token(Token = "0x600B373")]
    [Address(RVA = "0x76CDF0", Offset = "0x76BBF0", VA = "0x1076CDF0")]
    private void BreakupTeamImpl(bool isSlotChange = true)
    {
    }

    [Token(Token = "0x600B374")]
    [Address(RVA = "0x77B5F0", Offset = "0x77A3F0", VA = "0x1077B5F0")]
    public void PrevTeam()
    {
    }

    [Token(Token = "0x600B375")]
    [Address(RVA = "0x2868E0", Offset = "0x2856E0", VA = "0x102868E0")]
    public void NextTeam()
    {
    }

    [Token(Token = "0x600B376")]
    [Address(RVA = "0x778830", Offset = "0x777630", VA = "0x10778830")]
    public void OnTeamTabChange()
    {
    }

    [Token(Token = "0x600B377")]
    [Address(RVA = "0x773310", Offset = "0x772110", VA = "0x10773310")]
    public void GoToUnitList()
    {
    }

    [Token(Token = "0x600B378")]
    [Address(RVA = "0x786020", Offset = "0x784E20", VA = "0x10786020")]
    private List<List<UnitData>> SeparateUnitByElement(
      List<UnitData> allUnits,
      IEnumerable<string> kyouseiUnits,
      EElement targetElement,
      bool isHeroAvailable)
    {
      return (List<List<UnitData>>) null;
    }

    [Token(Token = "0x600B379")]
    [Address(RVA = "0x778F10", Offset = "0x777D10", VA = "0x10778F10")]
    protected void OrganizeRecommendedParty(
      GlobalVars.RecommendType targetType,
      EElement targetElement)
    {
    }

    [Token(Token = "0x600B37A")]
    [Address(RVA = "0x76DCE0", Offset = "0x76CAE0", VA = "0x1076DCE0")]
    public static int CompareTo_Total(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B37B")]
    [Address(RVA = "0x76DAC0", Offset = "0x76C8C0", VA = "0x1076DAC0")]
    private static int CompareTo_Attack(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B37C")]
    [Address(RVA = "0x76DBC0", Offset = "0x76C9C0", VA = "0x1076DBC0")]
    private static int CompareTo_Magic(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B37D")]
    [Address(RVA = "0x76DB20", Offset = "0x76C920", VA = "0x1076DB20")]
    private static int CompareTo_Defense(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B37E")]
    [Address(RVA = "0x76DC20", Offset = "0x76CA20", VA = "0x1076DC20")]
    private static int CompareTo_Mind(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B37F")]
    [Address(RVA = "0x76DC80", Offset = "0x76CA80", VA = "0x1076DC80")]
    private static int CompareTo_Speed(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B380")]
    [Address(RVA = "0x76DB80", Offset = "0x76C980", VA = "0x1076DB80")]
    private static int CompareTo_HP(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B381")]
    [Address(RVA = "0x76DA50", Offset = "0x76C850", VA = "0x1076DA50")]
    private static int CompareTo_AttackType(UnitData unit1, UnitData unit2, AttackDetailTypes type)
    {
      return new int();
    }

    [Token(Token = "0x600B382")]
    [Address(RVA = "0x76D970", Offset = "0x76C770", VA = "0x1076D970")]
    private static int CompareTo_AttackTypeSlash(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B383")]
    [Address(RVA = "0x76D9E0", Offset = "0x76C7E0", VA = "0x1076D9E0")]
    private static int CompareTo_AttackTypeStab(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B384")]
    [Address(RVA = "0x76D7B0", Offset = "0x76C5B0", VA = "0x1076D7B0")]
    private static int CompareTo_AttackTypeBlow(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B385")]
    [Address(RVA = "0x76D900", Offset = "0x76C700", VA = "0x1076D900")]
    private static int CompareTo_AttackTypeShot(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B386")]
    [Address(RVA = "0x76D820", Offset = "0x76C620", VA = "0x1076D820")]
    private static int CompareTo_AttackTypeMagic(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B387")]
    [Address(RVA = "0x76D890", Offset = "0x76C690", VA = "0x1076D890")]
    private static int CompareTo_AttackTypeNone(UnitData unit1, UnitData unit2) => new int();

    [Token(Token = "0x600B388")]
    [Address(RVA = "0x771410", Offset = "0x770210", VA = "0x10771410")]
    protected Dictionary<long, long> GetEquipConceptCardToParty(out bool isDirtyCCardEquipStatus)
    {
      return (Dictionary<long, long>) null;
    }

    [Token(Token = "0x600B389")]
    [Address(RVA = "0x76CCD0", Offset = "0x76BAD0", VA = "0x1076CCD0")]
    private bool AutoEquipConceptCardToParty() => new bool();

    [Token(Token = "0x600B38A")]
    [Address(RVA = "0x76C980", Offset = "0x76B780", VA = "0x1076C980")]
    private void AutoEquipConceptCardToPartyCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600B38B")]
    [Address(RVA = "0x771100", Offset = "0x76FF00", VA = "0x10771100")]
    protected List<UnitData> GetBattleEntryUnits() => (List<UnitData>) null;

    [Token(Token = "0x600B38C")]
    [Address(RVA = "0x771000", Offset = "0x76FE00", VA = "0x10771000")]
    protected List<ItemData> GetBattleEntryItems() => (List<ItemData>) null;

    [Token(Token = "0x600B38D")]
    [Address(RVA = "0x775260", Offset = "0x774060", VA = "0x10775260")]
    public void OnAutoBattleSetting(
      string name,
      ActionCall.EventType eventType,
      SerializeValueList list)
    {
    }

    [Token(Token = "0x600B38E")]
    [Address(RVA = "0x789560", Offset = "0x788360", VA = "0x10789560")]
    private void UnitList_Activated(int pinID)
    {
    }

    [Token(Token = "0x600B38F")]
    [Address(RVA = "0x789900", Offset = "0x788700", VA = "0x10789900", Slot = "35")]
    protected virtual void UnitList_Create()
    {
    }

    [Token(Token = "0x600B390")]
    [Address(RVA = "0x78AD70", Offset = "0x789B70", VA = "0x1078AD70")]
    private void UnitList_Remove()
    {
    }

    [Token(Token = "0x600B391")]
    [Address(RVA = "0x78AE60", Offset = "0x789C60", VA = "0x1078AE60", Slot = "36")]
    protected virtual void UnitList_Show(bool isAsync = false)
    {
    }

    [Token(Token = "0x600B392")]
    [Address(RVA = "0x788830", Offset = "0x787630", VA = "0x10788830")]
    private IEnumerator ShowUnitListCoroutine() => (IEnumerator) null;

    [Token(Token = "0x600B393")]
    [Address(RVA = "0x78A5D0", Offset = "0x7893D0", VA = "0x1078A5D0")]
    private void UnitList_OnSelect(bool IsSkip = false)
    {
    }

    [Token(Token = "0x600B394")]
    [Address(RVA = "0x78A480", Offset = "0x789280", VA = "0x1078A480", Slot = "37")]
    protected virtual void UnitList_OnSelect_RefreshOverWrite(UnitData selected_unit)
    {
    }

    [Token(Token = "0x600B395")]
    [Address(RVA = "0x78A080", Offset = "0x788E80", VA = "0x1078A080")]
    private void UnitList_OnRemove()
    {
    }

    [Token(Token = "0x600B396")]
    [Address(RVA = "0x789D20", Offset = "0x788B20", VA = "0x10789D20")]
    private void UnitList_OnClosing(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B397")]
    [Address(RVA = "0x788BD0", Offset = "0x7879D0", VA = "0x10788BD0")]
    private void SupportList_Show()
    {
    }

    [Token(Token = "0x600B398")]
    [Address(RVA = "0x78A190", Offset = "0x788F90", VA = "0x1078A190")]
    private void UnitList_OnSelectSupport()
    {
    }

    [Token(Token = "0x600B399")]
    [Address(RVA = "0x789B00", Offset = "0x788900", VA = "0x10789B00")]
    private void UnitList_OnAcceptSupport(GameObject go)
    {
    }

    [Token(Token = "0x600B39A")]
    [Address(RVA = "0x76CF30", Offset = "0x76BD30", VA = "0x1076CF30")]
    private int CalculateTotalSupportCost(SupportData support) => new int();

    [Token(Token = "0x600B39B")]
    [Address(RVA = "0x789E60", Offset = "0x788C60", VA = "0x10789E60")]
    private void UnitList_OnRemoveSupport()
    {
    }

    [Token(Token = "0x600B39C")]
    [Address(RVA = "0x76D000", Offset = "0x76BE00", VA = "0x1076D000")]
    private void CardList_Show()
    {
    }

    [Token(Token = "0x600B39D")]
    [Address(RVA = "0x770670", Offset = "0x76F470", VA = "0x10770670")]
    private void ForceRefreshCardData()
    {
    }

    [Token(Token = "0x600B39E")]
    [Address(RVA = "0x786A10", Offset = "0x785810", VA = "0x10786A10")]
    public void SetIsShowDownloadPopup(bool isShowDownloadPopup)
    {
    }

    [Token(Token = "0x600B39F")]
    [Address(RVA = "0x78B770", Offset = "0x78A570", VA = "0x1078B770")]
    private void UpdateCurrentForwardButton()
    {
    }

    [Token(Token = "0x600B3A0")]
    [Address(RVA = "0x782960", Offset = "0x781760", VA = "0x10782960")]
    private void Refresh_StoryExChallengeCount()
    {
    }

    [Token(Token = "0x170018AB")]
    public static bool IsAutoRepeatQuestCheck
    {
      [Token(Token = "0x600B3A1"), Address(RVA = "0x78D6D0", Offset = "0x78C4D0", VA = "0x1078D6D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B3A2")]
    [Address(RVA = "0x77D4F0", Offset = "0x77C2F0", VA = "0x1077D4F0")]
    private void RefreshAutoRepeatQuestButton()
    {
    }

    [Token(Token = "0x600B3A3")]
    [Address(RVA = "0x7757D0", Offset = "0x7745D0", VA = "0x107757D0")]
    private void OnAutoRepeatQuestMask(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B3A4")]
    [Address(RVA = "0x770970", Offset = "0x76F770", VA = "0x10770970")]
    private void ForceSavePartyData()
    {
    }

    [Token(Token = "0x600B3A5")]
    [Address(RVA = "0x786850", Offset = "0x785650", VA = "0x10786850")]
    public void SetForcedConceptCardUnit(UnitData[] units)
    {
    }

    [Token(Token = "0x600B3A6")]
    [Address(RVA = "0x780C70", Offset = "0x77FA70", VA = "0x10780C70")]
    private void RefreshSameUnitStates()
    {
    }

    [Token(Token = "0x600B3A7")]
    [Address(RVA = "0x7738D0", Offset = "0x7726D0", VA = "0x107738D0")]
    private bool IsSameUnitInParty(UnitData[] list) => new bool();

    [Token(Token = "0x600B3A8")]
    [Address(RVA = "0x771910", Offset = "0x770710", VA = "0x10771910")]
    private string[] GetForceUnits() => (string[]) null;

    [Token(Token = "0x600B3A9")]
    [Address(RVA = "0x771B20", Offset = "0x770920", VA = "0x10771B20")]
    private List<UnitData> GetMultiActiveUnitList() => (List<UnitData>) null;

    [Token(Token = "0x170018AC")]
    private bool IsUnitPartyOnlyMode
    {
      [Token(Token = "0x600B3AA"), Address(RVA = "0x78D910", Offset = "0x78C710", VA = "0x1078D910")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B3AB")]
    [Address(RVA = "0x78B230", Offset = "0x78A030", VA = "0x1078B230")]
    private bool UnitPartyOnlyOne_Select(UnitData selectedUnit) => new bool();

    [Token(Token = "0x600B3AC")]
    [Address(RVA = "0x7894D0", Offset = "0x7882D0", VA = "0x107894D0")]
    private void UnitListClosed(SRPG_Button button, UnitData unit)
    {
    }

    [Token(Token = "0x600B3AD")]
    [Address(RVA = "0x78DB70", Offset = "0x78C970", VA = "0x1078DB70")]
    public bool isPermitAutoRepeatQuestType(QuestTypes type) => new bool();

    [Token(Token = "0x600B3AE")]
    [Address(RVA = "0x76D740", Offset = "0x76C540", VA = "0x1076D740")]
    internal void ClosePulldown()
    {
    }

    [Token(Token = "0x600B3AF")]
    [Address(RVA = "0x78D020", Offset = "0x78BE20", VA = "0x1078D020")]
    public PartyWindow2()
    {
    }

    [Token(Token = "0x20027CF")]
    public enum EditPartyTypes
    {
      [Token(Token = "0x400BD6F")] Auto = 0,
      [Token(Token = "0x400BD70")] Normal = 1,
      [Token(Token = "0x400BD71")] Event = 2,
      [Token(Token = "0x400BD72")] MP = 3,
      [Token(Token = "0x400BD73")] Arena = 4,
      [Token(Token = "0x400BD74")] ArenaDef = 5,
      [Token(Token = "0x400BD75")] Character = 6,
      [Token(Token = "0x400BD76")] Tower = 7,
      [Token(Token = "0x400BD77")] Versus = 8,
      [Token(Token = "0x400BD78")] MultiTower = 9,
      [Token(Token = "0x400BD79")] Ordeal = 10, // 0x0000000A
      [Token(Token = "0x400BD7A")] RankMatch = 11, // 0x0000000B
      [Token(Token = "0x400BD7B")] Raid = 12, // 0x0000000C
      [Token(Token = "0x400BD7C")] GuildRaid = 13, // 0x0000000D
      [Token(Token = "0x400BD7D")] StoryExtra = 14, // 0x0000000E
      [Token(Token = "0x400BD7E")] GvG = 16, // 0x00000010
      [Token(Token = "0x400BD7F")] WorldRaid = 17, // 0x00000011
      [Token(Token = "0x400BD80")] BulkSkip = 18, // 0x00000012
      [Token(Token = "0x400BD81")] LeagueMatchAtk = 19, // 0x00000013
      [Token(Token = "0x400BD82")] LeagueMatchDef = 20, // 0x00000014
      [Token(Token = "0x400BD83")] LeagueMatchSham = 21, // 0x00000015
      [Token(Token = "0x400BD84")] LeagueMatchShamAtk = 22, // 0x00000016
      [Token(Token = "0x400BD85")] LeagueMatchAtkSet = 23, // 0x00000017
      [Token(Token = "0x400BD86")] Max = 24, // 0x00000018
    }

    [Token(Token = "0x20027D0")]
    public enum PartySlotType
    {
      [Token(Token = "0x400BD88")] Main0,
      [Token(Token = "0x400BD89")] Main1,
      [Token(Token = "0x400BD8A")] Sub0,
    }

    [Token(Token = "0x20027D1")]
    protected delegate void Callback();

    [Token(Token = "0x20027D2")]
    private enum ItemFilterTypes
    {
      [Token(Token = "0x400BD8C")] All,
      [Token(Token = "0x400BD8D")] Offense,
      [Token(Token = "0x400BD8E")] Support,
    }

    [Token(Token = "0x20027D3")]
    public class JSON_ReqBtlComRaidResponse
    {
      [Token(Token = "0x400BD8F")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400BD90")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400BD91")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400BD92")]
      [FieldOffset(Offset = "0x14")]
      public Json_BtlRewardConceptCard[] cards;
      [Token(Token = "0x400BD93")]
      [FieldOffset(Offset = "0x18")]
      public BattleCore.Json_BtlInfo[] btlinfos;
      [Token(Token = "0x400BD94")]
      [FieldOffset(Offset = "0x1C")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400BD95")]
      [FieldOffset(Offset = "0x20")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400BD96")]
      [FieldOffset(Offset = "0x24")]
      public int guildraid_bp_charge;
      [Token(Token = "0x400BD97")]
      [FieldOffset(Offset = "0x28")]
      public string[] bgms;
      [Token(Token = "0x400BD98")]
      [FieldOffset(Offset = "0x2C")]
      public int rune_storage_used;
      [Token(Token = "0x400BD99")]
      [FieldOffset(Offset = "0x30")]
      public JSON_StoryExChallengeCount story_ex_challenge;
      [Token(Token = "0x400BD9A")]
      [FieldOffset(Offset = "0x34")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400BD9B")]
      [FieldOffset(Offset = "0x38")]
      public JSON_TrophyProgress[] guild_trophies;
      [Token(Token = "0x400BD9C")]
      [FieldOffset(Offset = "0x3C")]
      public Json_HotDealInfo[] hot_deals;
      [Token(Token = "0x400BD9D")]
      [FieldOffset(Offset = "0x40")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400BD9E")]
      [FieldOffset(Offset = "0x44")]
      public PartyWindow2.JSON_ReqBtlComRaidResponse.BossReward[] boss_rewards;
      [Token(Token = "0x400BD9F")]
      [FieldOffset(Offset = "0x48")]
      public Json_PointQuestResult point_quest;
      [Token(Token = "0x400BDA0")]
      [FieldOffset(Offset = "0x4C")]
      public Json_Disassemble[] disassemble_rewards;

      [Token(Token = "0x600B3C8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ReqBtlComRaidResponse()
      {
      }

      [Token(Token = "0x20027D4")]
      public class BossReward
      {
        [Token(Token = "0x400BDA1")]
        [FieldOffset(Offset = "0x8")]
        public PartyWindow2.JSON_ReqBtlComRaidResponse.BossReward.Reward[] rewards;

        [Token(Token = "0x600B3C9")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public BossReward()
        {
        }

        [Token(Token = "0x20027D5")]
        public class Reward
        {
          [Token(Token = "0x400BDA2")]
          [FieldOffset(Offset = "0x8")]
          public int itype;
          [Token(Token = "0x400BDA3")]
          [FieldOffset(Offset = "0xC")]
          public string iname;
          [Token(Token = "0x400BDA4")]
          [FieldOffset(Offset = "0x10")]
          public int num;

          [Token(Token = "0x600B3CA")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public Reward()
          {
          }
        }
      }
    }

    [Token(Token = "0x20027D6")]
    public class JSON_ReqBtlComResetResponse
    {
      [Token(Token = "0x400BDA5")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400BDA6")]
      [FieldOffset(Offset = "0xC")]
      public JSON_QuestProgress[] quests;
      [Token(Token = "0x400BDA7")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;

      [Token(Token = "0x600B3CB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_ReqBtlComResetResponse()
      {
      }
    }

    [Token(Token = "0x20027D7")]
    [MessagePackObject(true)]
    public class MP_Response_SetConceptCardList : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400BDA8")]
      [FieldOffset(Offset = "0x28")]
      public ReqSetConceptCardList.Response body;

      [Token(Token = "0x600B3CC")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public MP_Response_SetConceptCardList()
      {
      }
    }

    [Token(Token = "0x20027D8")]
    private class HoldObserver : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
    {
      [Token(Token = "0x400BDA9")]
      [FieldOffset(Offset = "0xC")]
      private float[] HoldSpan;
      [Token(Token = "0x400BDAA")]
      [FieldOffset(Offset = "0x10")]
      private float HoldDuration;
      [Token(Token = "0x400BDAB")]
      [FieldOffset(Offset = "0x14")]
      private bool Holding;
      [Token(Token = "0x400BDAC")]
      [FieldOffset(Offset = "0x18")]
      private int ActionCount;
      [Token(Token = "0x400BDAD")]
      [FieldOffset(Offset = "0x1C")]
      private Vector2 mDragStartPos;
      [Token(Token = "0x400BDAE")]
      [FieldOffset(Offset = "0x24")]
      public PartyWindow2.HoldObserver.DelegateOnHoldEvent OnHoldStart;
      [Token(Token = "0x400BDAF")]
      [FieldOffset(Offset = "0x28")]
      public PartyWindow2.HoldObserver.DelegateOnHoldEvent OnHoldEnd;
      [Token(Token = "0x400BDB0")]
      [FieldOffset(Offset = "0x2C")]
      public PartyWindow2.HoldObserver.DelegateOnHoldEvent OnHoldUpdate;

      [Token(Token = "0x600B3CD")]
      [Address(RVA = "0x489C00", Offset = "0x488A00", VA = "0x10489C00", Slot = "4")]
      public void OnPointerDown(PointerEventData eventData)
      {
      }

      [Token(Token = "0x600B3CE")]
      [Address(RVA = "0x489C50", Offset = "0x488A50", VA = "0x10489C50")]
      public void OnPointerUp()
      {
      }

      [Token(Token = "0x600B3CF")]
      [Address(RVA = "0x489C90", Offset = "0x488A90", VA = "0x10489C90")]
      public void StatusReset()
      {
      }

      [Token(Token = "0x600B3D0")]
      [Address(RVA = "0x489CC0", Offset = "0x488AC0", VA = "0x10489CC0")]
      public void Update()
      {
      }

      [Token(Token = "0x600B3D1")]
      [Address(RVA = "0x489BA0", Offset = "0x4889A0", VA = "0x10489BA0")]
      public void OnDestroy()
      {
      }

      [Token(Token = "0x600B3D2")]
      [Address(RVA = "0x7A5A50", Offset = "0x7A4850", VA = "0x107A5A50")]
      public HoldObserver()
      {
      }

      [Token(Token = "0x20027D9")]
      public delegate void DelegateOnHoldEvent();
    }
  }
}
