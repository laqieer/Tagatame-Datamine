// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002CB0")]
  [FlowNode.Pin(331, "鍛錬場ユニットウインドウ", FlowNode.PinTypes.Input, 331)]
  [FlowNode.Pin(600, "フィルタウィンド開く", FlowNode.PinTypes.Input, 600)]
  [FlowNode.Pin(300, "傭兵雇用ウィンド開く", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(120, "汎用欠片変換ウィンド開く", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(110, "ユニット欠片ウィンド開く", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(610, "フィルタウィンド閉じる", FlowNode.PinTypes.Input, 610)]
  [FlowNode.Pin(330, "対戦クエストパーティ編集", FlowNode.PinTypes.Input, 330)]
  [FlowNode.Pin(620, "フィルタウィンド確定", FlowNode.PinTypes.Input, 620)]
  [FlowNode.Pin(640, "フィルタウィンドトグル全て選択", FlowNode.PinTypes.Input, 640)]
  [FlowNode.Pin(650, "フィルタウィンドトグル全てクリア", FlowNode.PinTypes.Input, 650)]
  [FlowNode.Pin(660, "フィルタウィンドタブ切り替え", FlowNode.PinTypes.Input, 660)]
  [FlowNode.Pin(690, "フィルタウィンド確定した", FlowNode.PinTypes.Output, 690)]
  [FlowNode.Pin(691, "フィルタウィンドキャンセルした", FlowNode.PinTypes.Output, 691)]
  [FlowNode.Pin(1000, "ウィンドロック", FlowNode.PinTypes.Input, 1000)]
  [FlowNode.Pin(700, "レンタルユニット選択", FlowNode.PinTypes.Input, 700)]
  [FlowNode.Pin(1010, "ウィンドロック解除", FlowNode.PinTypes.Input, 1010)]
  [FlowNode.Pin(1100, "名称検索設定", FlowNode.PinTypes.Input, 1100)]
  [AddComponentMenu("")]
  [FlowNode.Pin(105, "ショップ装備強化ユニットウィンド開く", FlowNode.PinTypes.Input, 105)]
  [FlowNode.Pin(104, "サポート傭兵設定ユニットウィンド開く", FlowNode.PinTypes.Input, 104)]
  [FlowNode.Pin(100, "所持ユニットウィンド開く", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(103, "装備強化ユニットウィンド開く", FlowNode.PinTypes.Input, 103)]
  [FlowNode.Pin(102, "タワー編成ユニットウィンド開く", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(101, "編成ユニットウィンド開く", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(591, "ソートウィンドキャンセルした", FlowNode.PinTypes.Output, 591)]
  [FlowNode.Pin(590, "ソートウィンド確定した", FlowNode.PinTypes.Output, 590)]
  [FlowNode.NodeType("UI/UnitListWindow", 32741)]
  [FlowNode.Pin(520, "ソートウィンド確定", FlowNode.PinTypes.Input, 520)]
  [FlowNode.Pin(332, "真理刻印専用化ユニットウインドウ", FlowNode.PinTypes.Input, 332)]
  [FlowNode.Pin(190, "ウィンド開く", FlowNode.PinTypes.Output, 398)]
  [FlowNode.Pin(191, "ウィンド開いた", FlowNode.PinTypes.Output, 399)]
  [FlowNode.Pin(400, "リストタブ切り替え", FlowNode.PinTypes.Input, 400)]
  [FlowNode.Pin(410, "リスト更新", FlowNode.PinTypes.Input, 410)]
  [FlowNode.Pin(430, "リスト再生成", FlowNode.PinTypes.Input, 411)]
  [FlowNode.Pin(420, "アイテム選択", FlowNode.PinTypes.Input, 419)]
  [FlowNode.Pin(419, "アイテムホールド", FlowNode.PinTypes.Input, 420)]
  [FlowNode.Pin(421, "ユニット選択", FlowNode.PinTypes.Output, 422)]
  [FlowNode.Pin(530, "ソートウィンドトグル切り替え", FlowNode.PinTypes.Input, 530)]
  [FlowNode.Pin(320, "派遣クエストパーティ編集", FlowNode.PinTypes.Input, 320)]
  [FlowNode.Pin(423, "欠片選択", FlowNode.PinTypes.Output, 423)]
  [FlowNode.Pin(426, "傭兵雇用選択", FlowNode.PinTypes.Output, 426)]
  [FlowNode.Pin(427, "傭兵雇用解除", FlowNode.PinTypes.Output, 427)]
  [FlowNode.Pin(429, "アイテムホールド", FlowNode.PinTypes.Output, 429)]
  [FlowNode.Pin(422, "ユニット解除", FlowNode.PinTypes.Output, 423)]
  [FlowNode.Pin(481, "サポートリスト強制取得", FlowNode.PinTypes.Output, 481)]
  [FlowNode.Pin(510, "ソートウィンド閉じる", FlowNode.PinTypes.Input, 510)]
  [FlowNode.Pin(500, "ソートウィンド開く", FlowNode.PinTypes.Input, 500)]
  [FlowNode.Pin(480, "サポートリスト取得", FlowNode.PinTypes.Output, 480)]
  [FlowNode.Pin(310, "ホームユニットウィンド開く", FlowNode.PinTypes.Input, 310)]
  [FlowNode.Pin(492, "ウィンド閉じた", FlowNode.PinTypes.Output, 492)]
  [FlowNode.Pin(491, "ウィンド閉じる", FlowNode.PinTypes.Output, 491)]
  [FlowNode.Pin(440, "サポートリスト更新", FlowNode.PinTypes.Input, 440)]
  [FlowNode.Pin(490, "ウィンド閉じる", FlowNode.PinTypes.Input, 490)]
  public class UnitListWindow : FlowNodePersistent
  {
    [Token(Token = "0x400DD89")]
    public const int INPUT_UNITWINDOW_OPEN = 100;
    [Token(Token = "0x400DD8A")]
    public const int INPUT_UNITWINDOW_EDIT_OPEN = 101;
    [Token(Token = "0x400DD8B")]
    public const int INPUT_UNITWINDOW_TWEDIT_OPEN = 102;
    [Token(Token = "0x400DD8C")]
    public const int INPUT_UNITWINDOW_EQUIP_OPEN = 103;
    [Token(Token = "0x400DD8D")]
    public const int INPUT_UNITWINDOW_SUPPORT_OPEN = 104;
    [Token(Token = "0x400DD8E")]
    public const int INPUT_UNITWINDOW_SHOPEQUIP_OPEN = 105;
    [Token(Token = "0x400DD8F")]
    public const int INPUT_PIECEWINDOW_OPEN = 110;
    [Token(Token = "0x400DD90")]
    public const int INPUT_PIECEEXCHANGE_OPEN = 120;
    [Token(Token = "0x400DD91")]
    public const int INPUT_SUPPORTWINDOW_OPEN = 300;
    [Token(Token = "0x400DD92")]
    public const int INPUT_HOMEUNITWINDOW_OPEN = 310;
    [Token(Token = "0x400DD93")]
    public const int INPUT_ADVENTURE_OPEN = 320;
    [Token(Token = "0x400DD94")]
    public const int INPUT_VERSUS_OPEN = 330;
    [Token(Token = "0x400DD95")]
    public const int INPUT_GUILD_TRAINING_OPEN = 331;
    [Token(Token = "0x400DD96")]
    public const int INPUT_RUNE_DEDICATED_OPEN = 332;
    [Token(Token = "0x400DD97")]
    public const int OUTPUT_WINDOW_OPEN = 190;
    [Token(Token = "0x400DD98")]
    public const int OUTPUT_WINDOW_OPENED = 191;
    [Token(Token = "0x400DD99")]
    public const int INPUT_LIST_TABCHANGE = 400;
    [Token(Token = "0x400DD9A")]
    public const int INPUT_LIST_REFRESH = 410;
    [Token(Token = "0x400DD9B")]
    public const int INPUT_LIST_HOLD = 419;
    [Token(Token = "0x400DD9C")]
    public const int INPUT_LIST_SELECT = 420;
    [Token(Token = "0x400DD9D")]
    public const int INPUT_LIST_REMAKE = 430;
    [Token(Token = "0x400DD9E")]
    public const int INPUT_SUPPORTLIST_REFRESH = 440;
    [Token(Token = "0x400DD9F")]
    public const int OUTPUT_SELECT_UNIT = 421;
    [Token(Token = "0x400DDA0")]
    public const int OUTPUT_REMOVE_UNIT = 422;
    [Token(Token = "0x400DDA1")]
    public const int OUTPUT_SELECT_PIECE = 423;
    [Token(Token = "0x400DDA2")]
    public const int OUTPUT_SELECT_SUPPORT = 426;
    [Token(Token = "0x400DDA3")]
    public const int OUTPUT_REMOVE_SUPPORT = 427;
    [Token(Token = "0x400DDA4")]
    public const int OUTPUT_HOLD_ITEM = 429;
    [Token(Token = "0x400DDA5")]
    public const int OUTPUT_WEBAPI_SUPPORT_UPDATE = 480;
    [Token(Token = "0x400DDA6")]
    public const int OUTPUT_WEBAPI_SUPPORT_UPDATEFORCE = 481;
    [Token(Token = "0x400DDA7")]
    public const int INPUT_WINDOW_CLOSE = 490;
    [Token(Token = "0x400DDA8")]
    public const int OUTPUT_WINDOW_CLOSE = 491;
    [Token(Token = "0x400DDA9")]
    public const int OUTPUT_WINDOW_CLOSED = 492;
    [Token(Token = "0x400DDAA")]
    public const int INPUT_SORTWINDOW_OPEN = 500;
    [Token(Token = "0x400DDAB")]
    public const int INPUT_SORTWINDOW_CLOSE = 510;
    [Token(Token = "0x400DDAC")]
    public const int INPUT_SORTWINDOW_OK = 520;
    [Token(Token = "0x400DDAD")]
    public const int INPUT_SORTWINDOW_TGLCHANGE = 530;
    [Token(Token = "0x400DDAE")]
    public const int OUTPUT_SORTWINDOW_CONFIRMED = 590;
    [Token(Token = "0x400DDAF")]
    public const int OUTPUT_SORTWINDOW_CANCELED = 591;
    [Token(Token = "0x400DDB0")]
    public const int OUTPUT_SORTWINDOW_CLOSED = 599;
    [Token(Token = "0x400DDB1")]
    public const int INPUT_FILTERWINDOW_OPEN = 600;
    [Token(Token = "0x400DDB2")]
    public const int INPUT_FILTERWINDOW_CLOSE = 610;
    [Token(Token = "0x400DDB3")]
    public const int INPUT_FILTERWWINDOW_OK = 620;
    [Token(Token = "0x400DDB4")]
    public const int INPUT_FILTERWWINDOW_ALL = 640;
    [Token(Token = "0x400DDB5")]
    public const int INPUT_FILTERWWINDOW_CLEAR = 650;
    [Token(Token = "0x400DDB6")]
    public const int INPUT_FILTERWWINDOW_TABCHANGE = 660;
    [Token(Token = "0x400DDB7")]
    public const int OUTPUT_FILTERWINDOW_CONFIRMED = 690;
    [Token(Token = "0x400DDB8")]
    public const int OUTPUT_FILTERWINDOW_CANCELED = 691;
    [Token(Token = "0x400DDB9")]
    public const int OUTPUT_FILTERWINDOW_CLOSED = 699;
    [Token(Token = "0x400DDBA")]
    public const int INPUT_DECIDE_RENTAL_UNIT = 700;
    [Token(Token = "0x400DDBB")]
    public const int INPUT_LOCK = 1000;
    [Token(Token = "0x400DDBC")]
    public const int INPUT_UNLOCK = 1010;
    [Token(Token = "0x400DDBD")]
    public const int INPUT_SET_SEARCH_NAME = 1100;
    [Token(Token = "0x400DDBE")]
    public const string DATA_REGISTER = "data_register";
    [Token(Token = "0x400DDBF")]
    public const string DATA_EDIT = "data_edit";
    [Token(Token = "0x400DDC0")]
    public const string DATA_UNIT = "data_unit";
    [Token(Token = "0x400DDC1")]
    public const string DATA_UNITS = "data_units";
    [Token(Token = "0x400DDC2")]
    public const string DATA_PARTY = "data_party";
    [Token(Token = "0x400DDC3")]
    public const string DATA_PARTY_INDEX = "data_party_index";
    [Token(Token = "0x400DDC4")]
    public const string DATA_QUEST = "data_quest";
    [Token(Token = "0x400DDC5")]
    public const string DATA_ELEMENT = "data_element";
    [Token(Token = "0x400DDC6")]
    public const string DATA_SELECTSLOT = "data_slot";
    [Token(Token = "0x400DDC7")]
    public const string DATA_HEROONLY = "data_heroOnly";
    [Token(Token = "0x400DDC8")]
    public const string DATA_SUPPORT = "data_support";
    [Token(Token = "0x400DDC9")]
    public const string DATA_SUPPORT_RESPONSE = "data_supportres";
    [Token(Token = "0x400DDCA")]
    public const string DATA_ADVENTURE_MENU = "data_adventure_menu";
    [Token(Token = "0x400DDCB")]
    public const string DATA_GUILD_TRAINING = "data_guild_training";
    [Token(Token = "0x400DDCC")]
    public const string DATA_CAMPAIGN_TEXT = "data_campaign_text";
    [Token(Token = "0x400DDCD")]
    private const string NAME_SEARCH_WINDOW_UI_PATH = "UI/NameSearchBox/namesearch_window_unit";
    [Token(Token = "0x400DDCE")]
    [FieldOffset(Offset = "0x18")]
    public UnitListRootWindow.SerializeParam m_RootWindowParam;
    [Token(Token = "0x400DDCF")]
    [FieldOffset(Offset = "0x1C")]
    public UnitListSortWindow.SerializeParam m_SortWindowParam;
    [Token(Token = "0x400DDD0")]
    [FieldOffset(Offset = "0x20")]
    public UnitListFilterWindow.SerializeParam m_FilterWindowParam;
    [Token(Token = "0x400DDD1")]
    [FieldOffset(Offset = "0x24")]
    public UnitListTotalCombatPower.SerializeParam m_TotalCombatPowerParam;
    [Token(Token = "0x400DDD2")]
    [FieldOffset(Offset = "0x28")]
    public Transform m_NameBoxParent;
    [Token(Token = "0x400DDD3")]
    [FieldOffset(Offset = "0x2C")]
    private FlowWindowController m_WindowController;
    [Token(Token = "0x400DDD4")]
    [FieldOffset(Offset = "0x30")]
    private UnitListRootWindow m_RootWindow;
    [Token(Token = "0x400DDD5")]
    [FieldOffset(Offset = "0x34")]
    private UnitListSortWindow m_SortWindow;
    [Token(Token = "0x400DDD6")]
    [FieldOffset(Offset = "0x38")]
    private UnitListFilterWindow m_FilterWindow;
    [Token(Token = "0x400DDD7")]
    [FieldOffset(Offset = "0x3C")]
    private UnitListTotalCombatPower m_TotalCombatPowerWindow;
    [Token(Token = "0x400DDD8")]
    [FieldOffset(Offset = "0x40")]
    private NameSearchBox m_NameSearchBox;
    [Token(Token = "0x400DDD9")]
    [FieldOffset(Offset = "0x44")]
    private string m_NameSearchText;

    [Token(Token = "0x17001B41")]
    public UnitListRootWindow rootWindow
    {
      [Token(Token = "0x600CF76"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (UnitListRootWindow) null;
      }
    }

    [Token(Token = "0x17001B42")]
    public UnitListSortWindow sortWindow
    {
      [Token(Token = "0x600CF77"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (UnitListSortWindow) null;
      }
    }

    [Token(Token = "0x17001B43")]
    public UnitListFilterWindow filterWindow
    {
      [Token(Token = "0x600CF78"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (UnitListFilterWindow) null;
      }
    }

    [Token(Token = "0x17001B44")]
    public UnitListTotalCombatPower totalCombatPowerWindow
    {
      [Token(Token = "0x600CF79"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (UnitListTotalCombatPower) null;
      }
    }

    [Token(Token = "0x17001B45")]
    public NameSearchBox nameSearchBox
    {
      [Token(Token = "0x600CF7A"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (NameSearchBox) null;
      }
    }

    [Token(Token = "0x17001B46")]
    public string nameSearchText
    {
      [Token(Token = "0x600CF7B"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600CF7C")]
    [Address(RVA = "0x9AD9C0", Offset = "0x9AC7C0", VA = "0x109AD9C0", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600CF7D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600CF7E")]
    [Address(RVA = "0x9AE020", Offset = "0x9ACE20", VA = "0x109AE020", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600CF7F")]
    [Address(RVA = "0x9ADD20", Offset = "0x9ACB20", VA = "0x109ADD20")]
    private void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x600CF80")]
    [Address(RVA = "0x9AE0E0", Offset = "0x9ACEE0", VA = "0x109AE0E0")]
    private void Update()
    {
    }

    [Token(Token = "0x600CF81")]
    [Address(RVA = "0x9ADD00", Offset = "0x9ACB00", VA = "0x109ADD00")]
    public void ClearData()
    {
    }

    [Token(Token = "0x600CF82")]
    [Address(RVA = "0x9AD9A0", Offset = "0x9AC7A0", VA = "0x109AD9A0")]
    public void AddData(string key, object value)
    {
    }

    [Token(Token = "0x600CF83")]
    [Address(RVA = "0x9ADE40", Offset = "0x9ACC40", VA = "0x109ADE40")]
    public object GetData(string key) => (object) null;

    [Token(Token = "0x600CF84")]
    public T GetData<T>(string key) => (T) null;

    [Token(Token = "0x600CF85")]
    public T GetData<T>(string key, T defaultValue) => (T) null;

    [Token(Token = "0x600CF86")]
    [Address(RVA = "0x833230", Offset = "0x832030", VA = "0x10833230")]
    public void Enabled(bool value)
    {
    }

    [Token(Token = "0x600CF87")]
    [Address(RVA = "0x9ADE60", Offset = "0x9ACC60", VA = "0x109ADE60")]
    public bool IsEnabled() => new bool();

    [Token(Token = "0x600CF88")]
    [Address(RVA = "0x9ADE80", Offset = "0x9ACC80", VA = "0x109ADE80")]
    public bool IsState(string stateName) => new bool();

    [Token(Token = "0x600CF89")]
    [Address(RVA = "0x9ADF30", Offset = "0x9ACD30", VA = "0x109ADF30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600CF8A")]
    [Address(RVA = "0x9AE060", Offset = "0x9ACE60", VA = "0x109AE060")]
    public void SetNameSearchText(string _text)
    {
    }

    [Token(Token = "0x600CF8B")]
    [Address(RVA = "0x9AE110", Offset = "0x9ACF10", VA = "0x109AE110")]
    public UnitListWindow()
    {
    }

    [Token(Token = "0x2002CB1")]
    public enum EditType
    {
      [Token(Token = "0x400DDDB")] DEFAULT,
      [Token(Token = "0x400DDDC")] PARTY,
      [Token(Token = "0x400DDDD")] PARTY_TOWER,
      [Token(Token = "0x400DDDE")] EQUIP,
      [Token(Token = "0x400DDDF")] SUPPORT,
      [Token(Token = "0x400DDE0")] SHOP_EQUIP,
      [Token(Token = "0x400DDE1")] PIECE_EXCHANGE,
      [Token(Token = "0x400DDE2")] HOME_PREVIEW,
      [Token(Token = "0x400DDE3")] ADVENTURE,
      [Token(Token = "0x400DDE4")] PARTY_VERSUS,
      [Token(Token = "0x400DDE5")] GUILD_TRAINING,
      [Token(Token = "0x400DDE6")] RUNE_DEDICATED,
      [Token(Token = "0x400DDE7")] LEAGUE_MATCH,
      [Token(Token = "0x400DDE8")] LEAGUE_MATCH_ATK_SET,
    }

    [Token(Token = "0x2002CB2")]
    public class Data
    {
      [Token(Token = "0x400DDE9")]
      [FieldOffset(Offset = "0x8")]
      public string body;
      [Token(Token = "0x400DDEA")]
      [FieldOffset(Offset = "0xC")]
      public UnitParam param;
      [Token(Token = "0x400DDEB")]
      [FieldOffset(Offset = "0x10")]
      public UnitData unit;
      [Token(Token = "0x400DDEC")]
      [FieldOffset(Offset = "0x14")]
      public SupportData support;
      [Token(Token = "0x400DDED")]
      [FieldOffset(Offset = "0x18")]
      public bool interactable;
      [Token(Token = "0x400DDEE")]
      [FieldOffset(Offset = "0x19")]
      public bool partySelect;
      [Token(Token = "0x400DDEF")]
      [FieldOffset(Offset = "0x1C")]
      public int partyMainSlot;
      [Token(Token = "0x400DDF0")]
      [FieldOffset(Offset = "0x20")]
      public int partySubSlot;
      [Token(Token = "0x400DDF1")]
      [FieldOffset(Offset = "0x24")]
      public int partyIndex;
      [Token(Token = "0x400DDF2")]
      [FieldOffset(Offset = "0x28")]
      public bool sameUnit;
      [Token(Token = "0x400DDF3")]
      [FieldOffset(Offset = "0x2C")]
      public int gvgUsedUnit;
      [Token(Token = "0x400DDF4")]
      [FieldOffset(Offset = "0x30")]
      public bool gvgUsedUnitSelect;
      [Token(Token = "0x400DDF5")]
      [FieldOffset(Offset = "0x34")]
      public int gvgPresetNum;
      [Token(Token = "0x400DDF6")]
      [FieldOffset(Offset = "0x38")]
      public bool used_adventure;
      [Token(Token = "0x400DDF7")]
      [FieldOffset(Offset = "0x3C")]
      public int guild_training_drop;
      [Token(Token = "0x400DDF8")]
      [FieldOffset(Offset = "0x40")]
      public int guild_training_time;
      [Token(Token = "0x400DDF9")]
      [FieldOffset(Offset = "0x44")]
      public bool guild_training_period;
      [Token(Token = "0x400DDFA")]
      [FieldOffset(Offset = "0x45")]
      public bool guild_training_limited;
      [Token(Token = "0x400DDFB")]
      [FieldOffset(Offset = "0x46")]
      public bool isUsedUnit;
      [Token(Token = "0x400DDFC")]
      [FieldOffset(Offset = "0x47")]
      public bool isNext;
      [Token(Token = "0x400DDFD")]
      [FieldOffset(Offset = "0x48")]
      public bool isNext2;
      [Token(Token = "0x400DDFE")]
      [FieldOffset(Offset = "0x49")]
      public bool isBeforeUsed;
      [Token(Token = "0x400DDFF")]
      [FieldOffset(Offset = "0x4A")]
      public bool isImageEnabled;
      [Token(Token = "0x400DE00")]
      [FieldOffset(Offset = "0x4B")]
      public bool unlockable;
      [Token(Token = "0x400DE01")]
      [FieldOffset(Offset = "0x4C")]
      public int pieceAmount;
      [Token(Token = "0x400DE02")]
      [FieldOffset(Offset = "0x50")]
      public UnitListRootWindow.Tab tabMask;
      [Token(Token = "0x400DE03")]
      [FieldOffset(Offset = "0x58")]
      public long sortPriority;
      [Token(Token = "0x400DE04")]
      [FieldOffset(Offset = "0x60")]
      public int subSortPriority;

      [Token(Token = "0x600CF8C")]
      [Address(RVA = "0x9A0760", Offset = "0x99F560", VA = "0x109A0760")]
      public Data()
      {
      }

      [Token(Token = "0x600CF8D")]
      [Address(RVA = "0x9A0730", Offset = "0x99F530", VA = "0x109A0730")]
      public Data(string _body)
      {
      }

      [Token(Token = "0x600CF8E")]
      [Address(RVA = "0x9A0810", Offset = "0x99F610", VA = "0x109A0810")]
      public Data(UnitParam _param)
      {
      }

      [Token(Token = "0x600CF8F")]
      [Address(RVA = "0x9A0920", Offset = "0x99F720", VA = "0x109A0920")]
      public Data(UnitData _unit)
      {
      }

      [Token(Token = "0x600CF90")]
      [Address(RVA = "0x9A06F0", Offset = "0x99F4F0", VA = "0x109A06F0")]
      public Data(SupportData _support)
      {
      }

      [Token(Token = "0x600CF91")]
      [Address(RVA = "0x9A0690", Offset = "0x99F490", VA = "0x109A0690")]
      public void Refresh()
      {
      }

      [Token(Token = "0x600CF92")]
      [Address(RVA = "0x9A0650", Offset = "0x99F450", VA = "0x109A0650")]
      public void RefreshTabMask()
      {
      }

      [Token(Token = "0x600CF93")]
      [Address(RVA = "0x9A0620", Offset = "0x99F420", VA = "0x109A0620")]
      public void RefreshSortPriority(
        UnitListSortWindow.SelectType sortType,
        UnitListSortWindow.SelectType alignment)
      {
      }

      [Token(Token = "0x600CF94")]
      [Address(RVA = "0x9A05B0", Offset = "0x99F3B0", VA = "0x109A05B0")]
      public void RefreshPartySlotPriority()
      {
      }

      [Token(Token = "0x600CF95")]
      [Address(RVA = "0x9A0590", Offset = "0x99F390", VA = "0x109A0590")]
      public long GetUniq() => new long();

      [Token(Token = "0x600CF96")]
      [Address(RVA = "0x9A04C0", Offset = "0x99F2C0", VA = "0x109A04C0")]
      public string GetFilterKeyword() => (string) null;
    }
  }
}
