// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBookmarkWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002877")]
  [FlowNode.Pin(101, "フィルタウインドウの表示", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(121, "クエスト一括：必要アイテム不足画面へ移動", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(122, "クエスト一括：ＡＰ回復アイテム選択画面へ移動", FlowNode.PinTypes.Output, 122)]
  [FlowNode.Pin(131, "クエスト一括：パーティー選択画面へ移動", FlowNode.PinTypes.Output, 131)]
  [AddComponentMenu("UI/QuestBookmarkWindow")]
  [FlowNode.Pin(11, "PartyEditor2から戻ってきた", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(22, "フィルタウインドウが閉じられた", FlowNode.PinTypes.Input, 22)]
  [FlowNode.Pin(21, "フィルタウインドウが開かれた", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(111, "クエスト選択", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "一括の最大値に変更があった場合", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(200, "初期化完了", FlowNode.PinTypes.Output, 200)]
  public class QuestBookmarkWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C164")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C165")]
    private const int PIN_INPUT_RETURN = 11;
    [Token(Token = "0x400C166")]
    private const int PIN_INPUT_OPEN_FILTER = 21;
    [Token(Token = "0x400C167")]
    private const int PIN_INPUT_CLOSE_FILTER = 22;
    [Token(Token = "0x400C168")]
    private const int PIN_OUTPUT_INIT = 100;
    [Token(Token = "0x400C169")]
    private const int PIN_OUTPUT_FILTER_WINDOW = 101;
    [Token(Token = "0x400C16A")]
    private const int PIN_OUTPUT_QUEST = 111;
    [Token(Token = "0x400C16B")]
    private const int PIN_OUTPUT_BULK_SKIP_ADVICE = 121;
    [Token(Token = "0x400C16C")]
    private const int PIN_OUTPUT_BULK_SKIP_AP = 122;
    [Token(Token = "0x400C16D")]
    private const int PIN_OUTPUT_BULK_SKIP_PARTY = 131;
    [Token(Token = "0x400C16E")]
    private const int PIN_OUTPUT_INITIALIZED = 200;
    [Token(Token = "0x400C16F")]
    private const string PrefsFilterKey = "PREFS_KEY_BOOKMARK_FILTER_UNIT";
    [Token(Token = "0x400C170")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject DisplayTop;
    [Token(Token = "0x400C171")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400C172")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ItemContainer;
    [Token(Token = "0x400C173")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject QuestSelectorTemplate;
    [Token(Token = "0x400C174")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject BookmarkNotFoundText;
    [Token(Token = "0x400C175")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x400C176")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle mDisplayToggle;
    [Token(Token = "0x400C177")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400C178")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject BundleWindow;
    [Token(Token = "0x400C179")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SRPG_Button ButtonBundleStart;
    [Token(Token = "0x400C17A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text TextCheckQuestNum;
    [Token(Token = "0x400C17B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text TextCheckQuestMax;
    [Token(Token = "0x400C17C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Color CheckQuestOverColor;
    [Token(Token = "0x400C17D")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Color CheckQuestLessColor;
    [Token(Token = "0x400C17E")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Text TextBulkCount;
    [Token(Token = "0x400C17F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text TextSkipAPCount;
    [Token(Token = "0x400C180")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text TextBulkSkipCount;
    [Token(Token = "0x400C181")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ImageArray mFilterButton;
    [Token(Token = "0x400C182")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private List<QuestBookmarkWindow.EditMode> QuestModes;
    [Token(Token = "0x400C183")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private int BulkSkipNum;
    [Token(Token = "0x400C184")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private GameObject ChallengeCountPeriodObj;
    [Token(Token = "0x400C185")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text ChallengeCountPeriodText;
    [Token(Token = "0x400C186")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private GameObject DropUpPeriodObj;
    [Token(Token = "0x400C187")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text DropUpPeriodText;
    [Token(Token = "0x400C188")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private ScrollablePulldown BulkSkipNumPulldown;
    [Token(Token = "0x400C189")]
    [FieldOffset(Offset = "0x88")]
    private readonly string BOOKMARK_TITLE;
    [Token(Token = "0x400C18A")]
    [FieldOffset(Offset = "0x8C")]
    private readonly string BOOKMARK_BUNDLE_NUM;
    [Token(Token = "0x400C18B")]
    [FieldOffset(Offset = "0x90")]
    private readonly string BOOKMARK_OVER_MAXIMUN;
    [Token(Token = "0x400C18C")]
    [FieldOffset(Offset = "0x0")]
    private static QuestBookmarkWindow mInstance;
    [Token(Token = "0x400C18D")]
    [FieldOffset(Offset = "0x94")]
    private GameObject mItemContentObject;
    [Token(Token = "0x400C18E")]
    [FieldOffset(Offset = "0x98")]
    private List<BookmarkUnitContentParam> BookmarkUnitParams;
    [Token(Token = "0x400C18F")]
    [FieldOffset(Offset = "0x9C")]
    private int mCheckQuestMax;
    [Token(Token = "0x400C190")]
    [FieldOffset(Offset = "0xA0")]
    private List<string> SaveCheckQuestList;
    [Token(Token = "0x400C191")]
    [FieldOffset(Offset = "0xA4")]
    private List<string> LoadCheckQuestList;
    [Token(Token = "0x400C192")]
    [FieldOffset(Offset = "0xA8")]
    private List<UnitParam> AllUnits;
    [Token(Token = "0x400C193")]
    [FieldOffset(Offset = "0xAC")]
    private List<QuestBookmarkWindow.ItemAndQuest> ItemAndQuestList;
    [Token(Token = "0x400C194")]
    [FieldOffset(Offset = "0xB0")]
    private List<QuestBookmarkWindow.BookmarkBulkQuestParam> mTargets;
    [Token(Token = "0x400C195")]
    [FieldOffset(Offset = "0xB4")]
    private QuestBookmarkWindow.BookmarkBulkResult mTargetsResult;
    [Token(Token = "0x400C196")]
    [FieldOffset(Offset = "0xB8")]
    private List<QuestBookmarkWindow.BookmarkBulkQuestParam> mSqueezeTargets;
    [Token(Token = "0x400C197")]
    [FieldOffset(Offset = "0xBC")]
    private QuestBookmarkWindow.BookmarkBulkResult mSqueezeTargetsResult;
    [Token(Token = "0x400C198")]
    [FieldOffset(Offset = "0xC0")]
    private List<QuestBookmarkWindow.BookmarkBulkParam> mDripItems;
    [Token(Token = "0x400C199")]
    [FieldOffset(Offset = "0xC4")]
    private List<QuestBookmarkWindow.BookmarkBulkParam> mTicketList;
    [Token(Token = "0x400C19A")]
    [FieldOffset(Offset = "0xC8")]
    private List<QuestBookmarkWindow.BookmarkBulkParam> mSqueezeTicketList;
    [Token(Token = "0x400C19B")]
    [FieldOffset(Offset = "0xCC")]
    private int mSkipTotalCount;
    [Token(Token = "0x400C19C")]
    [FieldOffset(Offset = "0xD0")]
    private int mSqueezeSkipTotalCount;
    [Token(Token = "0x400C19D")]
    [FieldOffset(Offset = "0xD4")]
    private int mSkipAPCount;
    [Token(Token = "0x400C19E")]
    [FieldOffset(Offset = "0xD8")]
    private int mSqueezeSkipAPCount;
    [Token(Token = "0x400C19F")]
    [FieldOffset(Offset = "0xDC")]
    private int mBulkSkipNum;
    [Token(Token = "0x400C1A0")]
    [FieldOffset(Offset = "0xE0")]
    private bool mSelectQuestFlag;
    [Token(Token = "0x400C1A1")]
    [FieldOffset(Offset = "0xE1")]
    private bool mSelectDisplayFlag;
    [Token(Token = "0x400C1A2")]
    [FieldOffset(Offset = "0xE2")]
    private bool isFilter;
    [Token(Token = "0x400C1A3")]
    [FieldOffset(Offset = "0xE3")]
    [NonSerialized]
    public bool isApMaxCheck;
    [Token(Token = "0x400C1A4")]
    [FieldOffset(Offset = "0xE4")]
    [NonSerialized]
    public bool isHaveSkipTicketCheck;

    [Token(Token = "0x17001906")]
    public static QuestBookmarkWindow Instance
    {
      [Token(Token = "0x600B6D6"), Address(RVA = "0x7DA2C0", Offset = "0x7D90C0", VA = "0x107DA2C0")] get
      {
        return (QuestBookmarkWindow) null;
      }
    }

    [Token(Token = "0x17001907")]
    public GameObject ItemContentObject
    {
      [Token(Token = "0x600B6D7"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001908")]
    public QuestBookmarkWindow.BookmarkBulkResult Result
    {
      [Token(Token = "0x600B6D8"), Address(RVA = "0x7DA2F0", Offset = "0x7D90F0", VA = "0x107DA2F0")] get
      {
        return (QuestBookmarkWindow.BookmarkBulkResult) null;
      }
    }

    [Token(Token = "0x600B6D9")]
    [Address(RVA = "0x7D5F60", Offset = "0x7D4D60", VA = "0x107D5F60")]
    public List<QuestBookmarkWindow.BookmarkBulkParam> GetTicketList()
    {
      return (List<QuestBookmarkWindow.BookmarkBulkParam>) null;
    }

    [Token(Token = "0x600B6DA")]
    [Address(RVA = "0x7D5BA0", Offset = "0x7D49A0", VA = "0x107D5BA0")]
    public int GetBulkSkipNum() => new int();

    [Token(Token = "0x600B6DB")]
    [Address(RVA = "0x7D5DC0", Offset = "0x7D4BC0", VA = "0x107D5DC0")]
    public int GetSkipAPCount() => new int();

    [Token(Token = "0x600B6DC")]
    [Address(RVA = "0x7D95A0", Offset = "0x7D83A0", VA = "0x107D95A0")]
    public void SetServerDataFavorite(int maxcount, string[] data)
    {
    }

    [Token(Token = "0x600B6DD")]
    [Address(RVA = "0x7D5BF0", Offset = "0x7D49F0", VA = "0x107D5BF0")]
    public string[] GetCheckQuestList() => (string[]) null;

    [Token(Token = "0x600B6DE")]
    [Address(RVA = "0x7D5E10", Offset = "0x7D4C10", VA = "0x107D5E10")]
    public JSON_BookmarkBulkData[] GetTargetQuestList() => (JSON_BookmarkBulkData[]) null;

    [Token(Token = "0x600B6DF")]
    [Address(RVA = "0x7D5C40", Offset = "0x7D4A40", VA = "0x107D5C40")]
    public JSON_BookmarkBulkData[] GetDripItemtList() => (JSON_BookmarkBulkData[]) null;

    [Token(Token = "0x600B6E0")]
    [Address(RVA = "0x7D9580", Offset = "0x7D8380", VA = "0x107D9580")]
    public void SetDripItems(
      List<QuestBookmarkWindow.BookmarkBulkParam> drip_items)
    {
    }

    [Token(Token = "0x600B6E1")]
    [Address(RVA = "0x7D4230", Offset = "0x7D3030", VA = "0x107D4230", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B6E2")]
    [Address(RVA = "0x7D4340", Offset = "0x7D3140", VA = "0x107D4340")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B6E3")]
    [Address(RVA = "0x7D8650", Offset = "0x7D7450", VA = "0x107D8650")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B6E4")]
    [Address(RVA = "0x7D94F0", Offset = "0x7D82F0", VA = "0x107D94F0")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x600B6E5")]
    [Address(RVA = "0x7D5FB0", Offset = "0x7D4DB0", VA = "0x107D5FB0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600B6E6")]
    [Address(RVA = "0x7D85D0", Offset = "0x7D73D0", VA = "0x107D85D0")]
    private void OnButtonBundleWindowClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B6E7")]
    [Address(RVA = "0x7D8460", Offset = "0x7D7260", VA = "0x107D8460")]
    public void OnButtonBundleSetupClick(int num)
    {
    }

    [Token(Token = "0x600B6E8")]
    [Address(RVA = "0x7D84D0", Offset = "0x7D72D0", VA = "0x107D84D0")]
    private void OnButtonBundleStartClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B6E9")]
    [Address(RVA = "0x7D7440", Offset = "0x7D6240", VA = "0x107D7440")]
    private bool IsAvailableQuest(QuestParam questParam, long currentTime) => new bool();

    [Token(Token = "0x600B6EA")]
    [Address(RVA = "0x7D91A0", Offset = "0x7D7FA0", VA = "0x107D91A0")]
    private void RefreshQuest()
    {
    }

    [Token(Token = "0x600B6EB")]
    [Address(RVA = "0x7D94C0", Offset = "0x7D82C0", VA = "0x107D94C0")]
    private void RefreshSection()
    {
    }

    [Token(Token = "0x600B6EC")]
    [Address(RVA = "0x7D8CD0", Offset = "0x7D7AD0", VA = "0x107D8CD0")]
    private void RefreshBundleInitialize()
    {
    }

    [Token(Token = "0x600B6ED")]
    [Address(RVA = "0x7D8E30", Offset = "0x7D7C30", VA = "0x107D8E30")]
    private void RefreshBundleSkip()
    {
    }

    [Token(Token = "0x600B6EE")]
    [Address(RVA = "0x7D94C0", Offset = "0x7D82C0", VA = "0x107D94C0")]
    private void RefreshSort()
    {
    }

    [Token(Token = "0x600B6EF")]
    [Address(RVA = "0x7D9120", Offset = "0x7D7F20", VA = "0x107D9120")]
    private void RefreshFilterButton()
    {
    }

    [Token(Token = "0x600B6F0")]
    [Address(RVA = "0x7D4B40", Offset = "0x7D3940", VA = "0x107D4B40")]
    private void CreateUnitPanels()
    {
    }

    [Token(Token = "0x600B6F1")]
    [Address(RVA = "0x7D5A30", Offset = "0x7D4830", VA = "0x107D5A30")]
    private List<UnitParam> FilterOnUnitList(
      FilterUtility.FilterPrefs filter,
      List<EElement> elementFilter)
    {
      return (List<UnitParam>) null;
    }

    [Token(Token = "0x600B6F2")]
    [Address(RVA = "0x7D87A0", Offset = "0x7D75A0", VA = "0x107D87A0")]
    public void OnDisplayToggle(bool value)
    {
    }

    [Token(Token = "0x600B6F3")]
    [Address(RVA = "0x7D8A60", Offset = "0x7D7860", VA = "0x107D8A60")]
    public void OnUnitSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B6F4")]
    [Address(RVA = "0x7D87E0", Offset = "0x7D75E0", VA = "0x107D87E0")]
    public void OnUnitSelectTab(BookmarkUnit btn, bool check)
    {
    }

    [Token(Token = "0x600B6F5")]
    [Address(RVA = "0x7D4690", Offset = "0x7D3490", VA = "0x107D4690")]
    private void BookmarkListup()
    {
    }

    [Token(Token = "0x600B6F6")]
    [Address(RVA = "0x7D4850", Offset = "0x7D3650", VA = "0x107D4850")]
    public void CheckSkipAllQuest()
    {
    }

    [Token(Token = "0x600B6F7")]
    [Address(RVA = "0x7D78D0", Offset = "0x7D66D0", VA = "0x107D78D0")]
    public void ListupSkipAllQuest()
    {
    }

    [Token(Token = "0x600B6F8")]
    [Address(RVA = "0x7D9680", Offset = "0x7D8480", VA = "0x107D9680")]
    public void SqueezeQuestList(int limitAp)
    {
    }

    [Token(Token = "0x600B6F9")]
    [Address(RVA = "0x7D81E0", Offset = "0x7D6FE0", VA = "0x107D81E0")]
    private FilterUtility.FilterPrefs LoadFilterPrefs() => (FilterUtility.FilterPrefs) null;

    [Token(Token = "0x600B6FA")]
    [Address(RVA = "0x7D80A0", Offset = "0x7D6EA0", VA = "0x107D80A0")]
    private List<EElement> LoadElementFilterPrefs() => (List<EElement>) null;

    [Token(Token = "0x600B6FB")]
    [Address(RVA = "0x7D7140", Offset = "0x7D5F40", VA = "0x107D7140")]
    private bool IsApItemUseMax(int mStamina) => new bool();

    [Token(Token = "0x600B6FC")]
    [Address(RVA = "0x7D7600", Offset = "0x7D6400", VA = "0x107D7600")]
    private bool IsHaveTicket() => new bool();

    [Token(Token = "0x600B6FD")]
    [Address(RVA = "0x7D77F0", Offset = "0x7D65F0", VA = "0x107D77F0")]
    public bool IsSaveFavorite() => new bool();

    [Token(Token = "0x600B6FE")]
    [Address(RVA = "0x7D7890", Offset = "0x7D6690", VA = "0x107D7890")]
    public bool IsSaveListPossession() => new bool();

    [Token(Token = "0x600B6FF")]
    [Address(RVA = "0x7D74A0", Offset = "0x7D62A0", VA = "0x107D74A0")]
    public bool IsCanQuest(int nowStamina) => new bool();

    [Token(Token = "0x600B700")]
    [Address(RVA = "0x7D9C20", Offset = "0x7D8A20", VA = "0x107D9C20")]
    private void UnitCheckSetAll(bool check)
    {
    }

    [Token(Token = "0x600B701")]
    [Address(RVA = "0x7D9BE0", Offset = "0x7D89E0", VA = "0x107D9BE0")]
    public void UnitCheckAll()
    {
    }

    [Token(Token = "0x600B702")]
    [Address(RVA = "0x7D9C00", Offset = "0x7D8A00", VA = "0x107D9C00")]
    public void UnitCheckClear()
    {
    }

    [Token(Token = "0x600B703")]
    [Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x107D54E0")]
    private void DispExpansionPurchasePeriod(List<QuestParam> _quest_list)
    {
    }

    [Token(Token = "0x600B704")]
    [Address(RVA = "0x7D4870", Offset = "0x7D3670", VA = "0x107D4870")]
    private void CreateBulkSkipNumPulldown(List<QuestParam> _quest_list)
    {
    }

    [Token(Token = "0x600B705")]
    [Address(RVA = "0x7D4820", Offset = "0x7D3620", VA = "0x107D4820")]
    private void ChangeBulkSkipNum(int index)
    {
    }

    [Token(Token = "0x600B706")]
    [Address(RVA = "0x7D9E90", Offset = "0x7D8C90", VA = "0x107D9E90")]
    public QuestBookmarkWindow()
    {
    }

    [Token(Token = "0x2002878")]
    private enum FilterButtonState
    {
      [Token(Token = "0x400C1A6")] FILTER_BUTTON_NONE,
      [Token(Token = "0x400C1A7")] FILTER_BUTTON_ACTIVE,
    }

    [Token(Token = "0x2002879")]
    public class ItemAndQuest
    {
      [Token(Token = "0x400C1A8")]
      [FieldOffset(Offset = "0x8")]
      public string itemName;
      [Token(Token = "0x400C1A9")]
      [FieldOffset(Offset = "0xC")]
      public QuestParam quest;
      [Token(Token = "0x400C1AA")]
      [FieldOffset(Offset = "0x10")]
      public bool isCheck;

      [Token(Token = "0x600B707")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ItemAndQuest()
      {
      }
    }

    [Token(Token = "0x200287A")]
    public class BulkSkipQuest
    {
      [Token(Token = "0x400C1AB")]
      [FieldOffset(Offset = "0x8")]
      public QuestParam quest;
      [Token(Token = "0x400C1AC")]
      [FieldOffset(Offset = "0xC")]
      public int skip;

      [Token(Token = "0x600B708")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BulkSkipQuest()
      {
      }
    }

    [Token(Token = "0x200287B")]
    public enum EditMode
    {
      [Token(Token = "0x400C1AE")] AUTO,
      [Token(Token = "0x400C1AF")] STORY_HARD_EXTRA,
      [Token(Token = "0x400C1B0")] BABEL,
      [Token(Token = "0x400C1B1")] SEISEKI,
      [Token(Token = "0x400C1B2")] GENESIS,
    }

    [Token(Token = "0x200287C")]
    public class BookmarkBulkResult
    {
      [Token(Token = "0x400C1B3")]
      [FieldOffset(Offset = "0x8")]
      public int PlayerExp;
      [Token(Token = "0x400C1B4")]
      [FieldOffset(Offset = "0xC")]
      public int UnitExp;

      [Token(Token = "0x600B709")]
      [Address(RVA = "0x7CBF10", Offset = "0x7CAD10", VA = "0x107CBF10")]
      public void Reset()
      {
      }

      [Token(Token = "0x600B70A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BookmarkBulkResult()
      {
      }
    }

    [Token(Token = "0x200287D")]
    public class BookmarkBulkQuestParam
    {
      [Token(Token = "0x400C1B5")]
      [FieldOffset(Offset = "0x8")]
      public string Iname;
      [Token(Token = "0x400C1B6")]
      [FieldOffset(Offset = "0xC")]
      public int Count;
      [Token(Token = "0x400C1B7")]
      [FieldOffset(Offset = "0x10")]
      public int UseAp;
      [Token(Token = "0x400C1B8")]
      [FieldOffset(Offset = "0x14")]
      public string useTicket;
      [Token(Token = "0x400C1B9")]
      [FieldOffset(Offset = "0x18")]
      public int PlayerExp;
      [Token(Token = "0x400C1BA")]
      [FieldOffset(Offset = "0x1C")]
      public int UnitExp;

      [Token(Token = "0x600B70B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BookmarkBulkQuestParam()
      {
      }
    }

    [Token(Token = "0x200287E")]
    public class BookmarkBulkParam
    {
      [Token(Token = "0x400C1BB")]
      [FieldOffset(Offset = "0x8")]
      public string Iname;
      [Token(Token = "0x400C1BC")]
      [FieldOffset(Offset = "0xC")]
      public int Count;

      [Token(Token = "0x600B70C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BookmarkBulkParam()
      {
      }
    }
  }
}
