// Decompiled with JetBrains decompiler
// Type: SRPG.QuestListV2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200289A")]
  [FlowNode.Pin(104, "上の階層に戻る", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(113, "戦闘力クエストがロック中", FlowNode.PinTypes.Output, 113)]
  [FlowNode.Pin(112, "エクストラに切り替わった", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(111, "ハードに切り替わった", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(110, "ノーマルに切り替わった", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(102, "鍵クエストを開ける", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "シナリオクエストが選択された", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(103, "鍵クエストを閉じる", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(11, "チャプター情報更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "前回選択したクエストを表示", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(2, "エクストラクエストを表示", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "エリートクエストを表示", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "通常クエストを表示", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/リスト/クエスト一覧")]
  [FlowNode.Pin(12, "機能購入後更新", FlowNode.PinTypes.Input, 12)]
  public class QuestListV2 : SRPG_ListBase, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400C24C")]
    private const int PIN_IN_SHOW_NORMAL = 0;
    [Token(Token = "0x400C24D")]
    private const int PIN_IN_SHOW_ELITE = 1;
    [Token(Token = "0x400C24E")]
    private const int PIN_IN_SHOW_EXTRA = 2;
    [Token(Token = "0x400C24F")]
    private const int PIN_IN_SHOW_LASTTIME = 10;
    [Token(Token = "0x400C250")]
    private const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x400C251")]
    private const int PIN_IN_REFRESH_EXPANSION_PURCHASE = 12;
    [Token(Token = "0x400C252")]
    private const int PIN_OUT_SELECT_SCENARIOQUEST = 101;
    [Token(Token = "0x400C253")]
    private const int PIN_OUT_OPEN_KEYQUEST = 102;
    [Token(Token = "0x400C254")]
    private const int PIN_OUT_CLOSE_KEYQUEST = 103;
    [Token(Token = "0x400C255")]
    private const int PIN_OUT_UP_TO_LAYER = 104;
    [Token(Token = "0x400C256")]
    private const int PIN_OUT_DIFF_CHANGE_NORMAL = 110;
    [Token(Token = "0x400C257")]
    private const int PIN_OUT_DIFF_CHANGE_HARD = 111;
    [Token(Token = "0x400C258")]
    private const int PIN_OUT_DIFF_CHANGE_EXTRA = 112;
    [Token(Token = "0x400C259")]
    private const int PIN_OUT_COMBATPOWERQUEST_LOCK = 113;
    [Token(Token = "0x400C25A")]
    private const int SCROOLWAIT = 10;
    [Token(Token = "0x400C25B")]
    [FieldOffset(Offset = "0x20")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C25C")]
    [FieldOffset(Offset = "0x24")]
    public GameObject SpecialQuestItem;
    [Token(Token = "0x400C25D")]
    [FieldOffset(Offset = "0x28")]
    public GameObject ExtraQuestItem;
    [Token(Token = "0x400C25E")]
    [FieldOffset(Offset = "0x2C")]
    [Description("シナリオクエスト用のアイテムとして使用するゲームオブジェクト")]
    public GameObject ScenarioQuestItem;
    [Token(Token = "0x400C25F")]
    [FieldOffset(Offset = "0x30")]
    [Description("シナリオクエスト用のアイテムとして使用するゲームオブジェクト")]
    public GameObject EliteQuestItem;
    [Token(Token = "0x400C260")]
    [FieldOffset(Offset = "0x34")]
    [Description("挑戦回数を使い果たしたエリートクエストのアイテムとして使用するゲームオブジェクト")]
    public GameObject EliteQuestDisAbleItem;
    [Token(Token = "0x400C261")]
    [FieldOffset(Offset = "0x38")]
    [Description("シナリオのエクストラクエスト用のアイテムとして使用するゲームオブジェクト")]
    public GameObject StoryExtraQuestItem;
    [Token(Token = "0x400C262")]
    [FieldOffset(Offset = "0x3C")]
    [Description("挑戦回数を使い果たしたシナリオのエクストラクエスト用のアイテムとして使用するゲームオブジェクト")]
    public GameObject StoryExtraQuestDisableItem;
    [Token(Token = "0x400C263")]
    [FieldOffset(Offset = "0x40")]
    [Description("挑戦回数ありのイベントリストアイテムとして使用するゲームオブジェクト")]
    public GameObject EventTemplateLimit;
    [Token(Token = "0x400C264")]
    [FieldOffset(Offset = "0x44")]
    [Description("詳細画面として使用するゲームオブジェクト")]
    public GameObject DetailTemplate;
    [Token(Token = "0x400C265")]
    [FieldOffset(Offset = "0x48")]
    [Description("難易度選択ボタン (Normal)")]
    public GameObject BtnNormal;
    [Token(Token = "0x400C266")]
    [FieldOffset(Offset = "0x4C")]
    [Description("難易度選択ボタン (Elite)")]
    public GameObject BtnElite;
    [Token(Token = "0x400C267")]
    [FieldOffset(Offset = "0x50")]
    [Description("難易度選択ボタン (Extra)")]
    public GameObject BtnExtra;
    [Token(Token = "0x400C268")]
    [FieldOffset(Offset = "0x54")]
    [Description("ハードクエストのブックマーク表示用ボタン")]
    public GameObject BtnEliteBookmark;
    [Token(Token = "0x400C269")]
    [FieldOffset(Offset = "0x58")]
    [Description("ユニットランキング表示ボタン")]
    public GameObject BtnUnitRanking;
    [Token(Token = "0x400C26A")]
    [FieldOffset(Offset = "0x5C")]
    [Description("戦闘力クエスト用リストオブジェクト")]
    public GameObject CombatPowerQuestItem;
    [Token(Token = "0x400C26B")]
    [FieldOffset(Offset = "0x60")]
    [Description("戦闘力クエスト用挑戦回数表示リストオブジェクト")]
    public GameObject CombatPowerQuestLimitItem;
    [Token(Token = "0x400C26C")]
    [FieldOffset(Offset = "0x64")]
    [Description("ハードクエスト用挑戦回数なしオブジェクト")]
    public GameObject NoLimitEliteQuestItem;
    [Token(Token = "0x400C26D")]
    [FieldOffset(Offset = "0x68")]
    [Description("エクストラクエスト用挑戦回数なしオブジェクト")]
    public GameObject NoLimitExtraQuestItem;
    [Token(Token = "0x400C26E")]
    [FieldOffset(Offset = "0x6C")]
    public Dictionary<string, GameObject> mListItemTemplates;
    [Token(Token = "0x400C26F")]
    [FieldOffset(Offset = "0x0")]
    private static Dictionary<int, float> mScrollPosCache;
    [Token(Token = "0x400C270")]
    [FieldOffset(Offset = "0x70")]
    private GameObject mDetailInfo;
    [Token(Token = "0x400C271")]
    [FieldOffset(Offset = "0x74")]
    public bool Descending;
    [Token(Token = "0x400C272")]
    [FieldOffset(Offset = "0x75")]
    public bool RefreshOnStart;
    [Token(Token = "0x400C273")]
    [FieldOffset(Offset = "0x76")]
    public bool ShowAllQuests;
    [Token(Token = "0x400C274")]
    [FieldOffset(Offset = "0x78")]
    public ScrollRect ScrollRect;
    [Token(Token = "0x400C275")]
    [FieldOffset(Offset = "0x7C")]
    public GameObject AreaInfo;
    [Token(Token = "0x400C276")]
    [FieldOffset(Offset = "0x80")]
    [FourCC]
    public int ListID;
    [Token(Token = "0x400C277")]
    [FieldOffset(Offset = "0x84")]
    public GameObject ChapterTimer;
    [Token(Token = "0x400C278")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject StoryExRestCount;
    [Token(Token = "0x400C279")]
    [FieldOffset(Offset = "0x8C")]
    public GameObject BackButton;
    [Token(Token = "0x400C27A")]
    [FieldOffset(Offset = "0x90")]
    [Space]
    [SerializeField]
    private GameObject ChapterCount;
    [Token(Token = "0x400C27B")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private Text ChapterCountText;
    [Token(Token = "0x400C27C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text ChapterCountLimit;
    [Token(Token = "0x400C27D")]
    [FieldOffset(Offset = "0x9C")]
    private ChapterParam mCurrentChapter;
    [Token(Token = "0x400C27E")]
    [FieldOffset(Offset = "0xA0")]
    private List<QuestParam> mQuests;
    [Token(Token = "0x400C27F")]
    [FieldOffset(Offset = "0xA4")]
    private QuestDifficulties mDifficultyFilter;
    [Token(Token = "0x400C280")]
    [FieldOffset(Offset = "0xA8")]
    private int mSetScrollPos;
    [Token(Token = "0x400C281")]
    [FieldOffset(Offset = "0xAC")]
    private float mNewScrollPos;
    [Token(Token = "0x400C282")]
    [FieldOffset(Offset = "0xB0")]
    private bool mIsQuestsRefreshed;
    [Token(Token = "0x400C283")]
    [FieldOffset(Offset = "0xB4")]
    private GameObject mExtraSystemMsg;
    [Token(Token = "0x400C284")]
    [FieldOffset(Offset = "0xB8")]
    private PointQuestHighScoreSource mHighScoreSource;
    [Token(Token = "0x400C285")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    private GameObject ChallengeCountPeriodObj;
    [Token(Token = "0x400C286")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text ChallengeCountPeriodText;
    [Token(Token = "0x400C287")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    private GameObject DropUpPeriodObj;
    [Token(Token = "0x400C288")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text DropUpPeriodText;
    [Token(Token = "0x400C289")]
    [FieldOffset(Offset = "0xCC")]
    [Header("スクロール位置を再計算する")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x400C28A")]
    [FieldOffset(Offset = "0xD0")]
    private bool IsScrollOffsetContentHeight;
    [Token(Token = "0x400C28B")]
    [FieldOffset(Offset = "0xD4")]
    private float mAnchoredPositionY;

    [Token(Token = "0x600B786")]
    [Address(RVA = "0x7E4310", Offset = "0x7E3110", VA = "0x107E4310", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B787")]
    [Address(RVA = "0x7E9D30", Offset = "0x7E8B30", VA = "0x107E9D30", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600B788")]
    [Address(RVA = "0x7E53C0", Offset = "0x7E41C0", VA = "0x107E53C0")]
    private GameObject LoadQuestListItem(QuestParam param) => (GameObject) null;

    [Token(Token = "0x600B789")]
    [Address(RVA = "0x7E7960", Offset = "0x7E6760", VA = "0x107E7960", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600B78A")]
    [Address(RVA = "0x7E5000", Offset = "0x7E3E00", VA = "0x107E5000")]
    public bool ExistsQuest(QuestDifficulties difficulty) => new bool();

    [Token(Token = "0x600B78B")]
    [Address(RVA = "0x7E9660", Offset = "0x7E8460", VA = "0x107E9660")]
    private bool Refresh(QuestDifficulties difficulty) => new bool();

    [Token(Token = "0x600B78C")]
    [Address(RVA = "0x7E4510", Offset = "0x7E3310", VA = "0x107E4510")]
    private IEnumerator CalcScrollPosByAutoRepeat(QuestDifficulties difficulty)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600B78D")]
    [Address(RVA = "0x7E5140", Offset = "0x7E3F40", VA = "0x107E5140")]
    private bool HasEliteQuest(QuestParam q) => new bool();

    [Token(Token = "0x600B78E")]
    [Address(RVA = "0x7E8F60", Offset = "0x7E7D60", VA = "0x107E8F60")]
    private bool RefreshQuests() => new bool();

    [Token(Token = "0x600B78F")]
    [Address(RVA = "0x7E92F0", Offset = "0x7E80F0", VA = "0x107E92F0")]
    private bool RefreshRankingQuests() => new bool();

    [Token(Token = "0x600B790")]
    [Address(RVA = "0x7E8570", Offset = "0x7E7370", VA = "0x107E8570")]
    private void RefreshItems()
    {
    }

    [Token(Token = "0x600B791")]
    [Address(RVA = "0x7E8460", Offset = "0x7E7260", VA = "0x107E8460")]
    private void RefreshChapterTimer()
    {
    }

    [Token(Token = "0x600B792")]
    [Address(RVA = "0x7E8340", Offset = "0x7E7140", VA = "0x107E8340")]
    private void RefreshButtons(QuestDifficulties difficulty)
    {
    }

    [Token(Token = "0x600B793")]
    [Address(RVA = "0x7E4580", Offset = "0x7E3380", VA = "0x107E4580")]
    private void ChangeChapterCountState(ChapterParam chapterParam)
    {
    }

    [Token(Token = "0x600B794")]
    [Address(RVA = "0x7E46E0", Offset = "0x7E34E0", VA = "0x107E46E0")]
    private void CheckChapterState()
    {
    }

    [Token(Token = "0x600B795")]
    [Address(RVA = "0x7E7C00", Offset = "0x7E6A00", VA = "0x107E7C00")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600B796")]
    [Address(RVA = "0x6FCE90", Offset = "0x6FBC90", VA = "0x106FCE90")]
    private void OnCloseKeyQuest(GameObject go)
    {
    }

    [Token(Token = "0x600B797")]
    [Address(RVA = "0x7E78C0", Offset = "0x7E66C0", VA = "0x107E78C0")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B798")]
    [Address(RVA = "0x7E7AB0", Offset = "0x7E68B0", VA = "0x107E7AB0")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B799")]
    [Address(RVA = "0x7E8270", Offset = "0x7E7070", VA = "0x107E8270")]
    private QuestDifficulties PlayingDifficultiy() => new QuestDifficulties();

    [Token(Token = "0x600B79A")]
    [Address(RVA = "0x7E5260", Offset = "0x7E4060", VA = "0x107E5260", Slot = "8")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600B79B")]
    [Address(RVA = "0x7E50B0", Offset = "0x7E3EB0", VA = "0x107E50B0", Slot = "10")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600B79C")]
    [Address(RVA = "0x7E4950", Offset = "0x7E3750", VA = "0x107E4950")]
    private void DispExpansionPurchasePeriod()
    {
    }

    [Token(Token = "0x600B79D")]
    [Address(RVA = "0x7EA3F0", Offset = "0x7E91F0", VA = "0x107EA3F0")]
    public QuestListV2()
    {
    }

    [Token(Token = "0x600B79E")]
    [Address(RVA = "0x7EA370", Offset = "0x7E9170", VA = "0x107EA370")]
    static QuestListV2()
    {
    }
  }
}
