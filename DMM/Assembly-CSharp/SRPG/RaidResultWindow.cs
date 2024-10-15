// Decompiled with JetBrains decompiler
// Type: SRPG.RaidResultWindow
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
  [Token(Token = "0x20028FA")]
  [FlowNode.Pin(2, "プレイヤー経験値の獲得演出開始", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(2104, "新イベントに戻る", FlowNode.PinTypes.Output, 2104)]
  [FlowNode.Pin(2101, "イベントクエストに戻る", FlowNode.PinTypes.Output, 2101)]
  [FlowNode.Pin(2100, "ストーリークエストに戻る", FlowNode.PinTypes.Output, 2100)]
  [AddComponentMenu("UI/RaidResultWindow")]
  [FlowNode.Pin(2105, "竜神編に戻る", FlowNode.PinTypes.Output, 2105)]
  [FlowNode.Pin(2106, "ポイントイベントに戻る", FlowNode.PinTypes.Output, 2106)]
  [FlowNode.Pin(3100, "自動周回表示用の設定を戻す", FlowNode.PinTypes.Input, 3100)]
  [FlowNode.Pin(1, "ドロップアイテムの獲得演出開始", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2000, "クエストリストに戻る", FlowNode.PinTypes.Input, 2000)]
  [FlowNode.Pin(3000, "自動周回表示用の設定初期化", FlowNode.PinTypes.Input, 3000)]
  [FlowNode.Pin(300, "ファントム経験値の獲得演出終了", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(2200, "不明なのでホームへ", FlowNode.PinTypes.Output, 2200)]
  [FlowNode.Pin(200, "プレイヤー経験値の獲得演出終了", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(100, "ドロップアイテムの獲得演出終了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(20, "経験値演出スキップ", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(11, "アイテムスキップHoldOff", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "アイテムスキップHoldOn", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(3, "ファントム経験値の獲得演出開始", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2103, "創世編に戻る", FlowNode.PinTypes.Output, 2103)]
  [FlowNode.Pin(1000, "終了", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(2102, "カルマに戻る", FlowNode.PinTypes.Output, 2102)]
  public class RaidResultWindow : SRPG_ListBase, IFlowInterface
  {
    [Token(Token = "0x400C51D")]
    public const int PIN_INPUT_RETURN_QUEST = 2000;
    [Token(Token = "0x400C51E")]
    public const int PIN_GOTO_QUEST = 2100;
    [Token(Token = "0x400C51F")]
    public const int PIN_GOTO_EVENT = 2101;
    [Token(Token = "0x400C520")]
    public const int PIN_GOTO_QUEST_ORDEAL = 2102;
    [Token(Token = "0x400C521")]
    public const int PIN_GOTO_GENESIS = 2103;
    [Token(Token = "0x400C522")]
    public const int PIN_GOTO_ADVANCE = 2104;
    [Token(Token = "0x400C523")]
    public const int PIN_GOTO_DRAGONGOD = 2105;
    [Token(Token = "0x400C524")]
    public const int PIN_GOTO_POINTEVENT = 2106;
    [Token(Token = "0x400C525")]
    public const int PIN_GOTO_UNKNOWN = 2200;
    [Token(Token = "0x400C526")]
    public const int PIN_INPUT_AUTO_REPEAT_INIT = 3000;
    [Token(Token = "0x400C527")]
    public const int PIN_INPUT_AUTO_REPEAT_REVERT = 3100;
    [Token(Token = "0x400C528")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ScrollRect ResultLayout;
    [Token(Token = "0x400C529")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform ResultParent;
    [Token(Token = "0x400C52A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject ResultTemplate;
    [Token(Token = "0x400C52B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button BtnUp;
    [Token(Token = "0x400C52C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button BtnDown;
    [Token(Token = "0x400C52D")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Button BtnOutSide;
    [Token(Token = "0x400C52E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text TextOutSide;
    [Token(Token = "0x400C52F")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button BtnGainExpOutSide;
    [Token(Token = "0x400C530")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button OkButton;
    [Token(Token = "0x400C531")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Button ReturnToQuestListButton;
    [Token(Token = "0x400C532")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button ReturnToQuestListButtonMask;
    [Token(Token = "0x400C533")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Button ReturnToHomeButton;
    [Token(Token = "0x400C534")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button CloseButton;
    [Token(Token = "0x400C535")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    [Description("クエストの自動周回開始ボタン")]
    private SRPG_Button AutoRepeatQuestStartBtn;
    [Token(Token = "0x400C536")]
    [FieldOffset(Offset = "0x58")]
    [Description("クエストの自動周回開始ボタンマスク")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestStartBtnMask;
    [Token(Token = "0x400C537")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestBestTimeBtn;
    [Token(Token = "0x400C538")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private SRPG_Button AutoRepeatQuestBestTimeBtnMask;
    [Token(Token = "0x400C539")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text AutoRepeatQuestBestTimeText;
    [Token(Token = "0x400C53A")]
    [FieldOffset(Offset = "0x68")]
    [Description("入手アイテムのリストになる親ゲームオブジェクト")]
    public GameObject TreasureList;
    [Token(Token = "0x400C53B")]
    [FieldOffset(Offset = "0x6C")]
    [Description("入手アイテムのリストになる親ゲームオブジェクト Contentnode版")]
    public ContentController CcTreasureList;
    [Token(Token = "0x400C53C")]
    [FieldOffset(Offset = "0x70")]
    [Description("入手アイテムのゲームオブジェクト")]
    public GameObject TreasureListItem;
    [Token(Token = "0x400C53D")]
    [FieldOffset(Offset = "0x74")]
    [Description("入手真理念装のゲームオブジェクト")]
    public GameObject TreasureListConceptCard;
    [Token(Token = "0x400C53E")]
    [FieldOffset(Offset = "0x78")]
    [Description("入新規取得アイテムのバッジ")]
    public GameObject NewItemBadge;
    [Token(Token = "0x400C53F")]
    [FieldOffset(Offset = "0x7C")]
    public GameObject DropItemWindow;
    [Token(Token = "0x400C540")]
    [FieldOffset(Offset = "0x80")]
    public GameObject GainExpWindow;
    [Token(Token = "0x400C541")]
    [FieldOffset(Offset = "0x84")]
    public GameObject PlayerResult;
    [Token(Token = "0x400C542")]
    [FieldOffset(Offset = "0x88")]
    public Slider PlayerGauge;
    [Token(Token = "0x400C543")]
    [FieldOffset(Offset = "0x8C")]
    public Text TxtPlayerLvVal;
    [Token(Token = "0x400C544")]
    [FieldOffset(Offset = "0x90")]
    public Text TxtPlayerExpVal;
    [Token(Token = "0x400C545")]
    [FieldOffset(Offset = "0x94")]
    public Text TxtGainGoldVal;
    [Token(Token = "0x400C546")]
    [FieldOffset(Offset = "0x98")]
    [Description("レベルアップ時に使用するトリガー。ゲームオブジェクトにアタッチされたAnimatorへ送られます。")]
    public string LevelUpTrigger;
    [Token(Token = "0x400C547")]
    [FieldOffset(Offset = "0x9C")]
    [Description("一秒あたりの経験値の増加量")]
    public float ExpGainRate;
    [Token(Token = "0x400C548")]
    [FieldOffset(Offset = "0xA0")]
    [Description("経験値増加アニメーションの最長時間。経験値がExpGainRateの速度で増加する時、これで設定した時間を超える時に加算速度を上げる。")]
    public float ExpGainTimeMax;
    [Token(Token = "0x400C549")]
    [FieldOffset(Offset = "0xA4")]
    public float ResultScrollInterval;
    [Token(Token = "0x400C54A")]
    [FieldOffset(Offset = "0xA8")]
    [Description("経験値増加アニメーションスキップの倍速設定")]
    public float ExpSkipSpeedMul;
    [Token(Token = "0x400C54B")]
    [FieldOffset(Offset = "0xAC")]
    public GameObject UnitList;
    [Token(Token = "0x400C54C")]
    [FieldOffset(Offset = "0xB0")]
    public GameObject UnitListItem;
    [Token(Token = "0x400C54D")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    private GameObject UnitExpGaugeObject;
    [Token(Token = "0x400C54E")]
    [FieldOffset(Offset = "0xB8")]
    public Button SkipButton;
    [Token(Token = "0x400C54F")]
    [FieldOffset(Offset = "0xBC")]
    public Button ExpSkipButton;
    [Token(Token = "0x400C550")]
    [FieldOffset(Offset = "0xC0")]
    [Range(0.1f, 10f)]
    public float SkipTimeScale;
    [Token(Token = "0x400C551")]
    [FieldOffset(Offset = "0xC4")]
    private RaidResult mRaidResult;
    [Token(Token = "0x400C552")]
    [FieldOffset(Offset = "0xC8")]
    private List<GameObject> mResults;
    [Token(Token = "0x400C553")]
    [FieldOffset(Offset = "0xCC")]
    private List<GameObject> mUnitListItems;
    [Token(Token = "0x400C554")]
    [FieldOffset(Offset = "0xD0")]
    private RaidResultElement mCurrentElement;
    [Token(Token = "0x400C555")]
    [FieldOffset(Offset = "0xD4")]
    private bool mItemSkipElement;
    [Token(Token = "0x400C556")]
    [FieldOffset(Offset = "0xD5")]
    private bool mExpSkipElement;
    [Token(Token = "0x400C557")]
    [FieldOffset(Offset = "0xD6")]
    private bool mIsSkipDropItemResult;
    [Token(Token = "0x400C558")]
    [FieldOffset(Offset = "0xD8")]
    public int[] AcquiredUnitExp;
    [Token(Token = "0x400C559")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    private SerializeValueBehaviour mSerializeValueBehaviour;
    [Token(Token = "0x400C55A")]
    [FieldOffset(Offset = "0xE0")]
    private List<QuestResultTreasureParam> mCcTreasureList;
    [Token(Token = "0x400C55B")]
    [FieldOffset(Offset = "0xE4")]
    private string mKeepPreSelectedQuestID;
    [Token(Token = "0x400C55C")]
    [FieldOffset(Offset = "0xE8")]
    private RaidResultWindow.ResultButtonType mResultButtonType;

    [Token(Token = "0x600B974")]
    [Address(RVA = "0x809260", Offset = "0x808060", VA = "0x10809260")]
    private void QuestReturnButtonClick()
    {
    }

    [Token(Token = "0x600B975")]
    [Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0", Slot = "4")]
    protected override ScrollRect GetScrollRect() => (ScrollRect) null;

    [Token(Token = "0x600B976")]
    [Address(RVA = "0x808130", Offset = "0x806F30", VA = "0x10808130", Slot = "5")]
    protected override RectTransform GetRectTransform() => (RectTransform) null;

    [Token(Token = "0x600B977")]
    [Address(RVA = "0x809590", Offset = "0x808390", VA = "0x10809590", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600B978")]
    [Address(RVA = "0x809540", Offset = "0x808340", VA = "0x10809540")]
    public void SetupResutButtonType(RaidResultWindow.ResultButtonType resultButtonType)
    {
    }

    [Token(Token = "0x600B979")]
    [Address(RVA = "0x809350", Offset = "0x808150", VA = "0x10809350")]
    private void RefreshAutoRepeatQuestButton(QuestParam currentQuest, bool is_intaractable)
    {
    }

    [Token(Token = "0x600B97A")]
    [Address(RVA = "0x8091C0", Offset = "0x807FC0", VA = "0x108091C0")]
    private void OnAutoRepeatQuestMask(SRPG_Button button)
    {
    }

    [Token(Token = "0x600B97B")]
    [Address(RVA = "0x8074A0", Offset = "0x8062A0", VA = "0x108074A0")]
    private void AutoRepeatQuestRetrySetting()
    {
    }

    [Token(Token = "0x600B97C")]
    [Address(RVA = "0x807A90", Offset = "0x806890", VA = "0x10807A90")]
    private void AutoRepeatQuestRvertSetting()
    {
    }

    [Token(Token = "0x600B97D")]
    [Address(RVA = "0x807550", Offset = "0x806350", VA = "0x10807550")]
    private void AutoRepeatQuestReturnQuestList()
    {
    }

    [Token(Token = "0x600B97E")]
    [Address(RVA = "0x808490", Offset = "0x807290", VA = "0x10808490")]
    private bool IsAutoRepeatRetryAvailable(
      QuestParam quest,
      bool is_period = true,
      bool is_count = true,
      bool is_draw_popup = false)
    {
      return new bool();
    }

    [Token(Token = "0x600B97F")]
    [Address(RVA = "0x808790", Offset = "0x807590", VA = "0x10808790")]
    private QuestResult.DropItemData[] MergeDropItems(RaidResult raidResult)
    {
      return (QuestResult.DropItemData[]) null;
    }

    [Token(Token = "0x600B980")]
    [Address(RVA = "0x807B00", Offset = "0x806900", VA = "0x10807B00")]
    private void CreateDropItemObjects(QuestResult.DropItemData[] items)
    {
    }

    [Token(Token = "0x600B981")]
    [Address(RVA = "0x807E50", Offset = "0x806C50", VA = "0x10807E50")]
    private void CreateTreasureObject(QuestResult.DropItemData[] items)
    {
    }

    [Token(Token = "0x600B982")]
    [Address(RVA = "0x807090", Offset = "0x805E90", VA = "0x10807090")]
    private void ApplyQuestCampaignParams(string[] campaignIds)
    {
    }

    [Token(Token = "0x600B983")]
    [Address(RVA = "0x809560", Offset = "0x808360", VA = "0x10809560")]
    public void SkipDropItemResult()
    {
    }

    [Token(Token = "0x600B984")]
    [Address(RVA = "0x806C80", Offset = "0x805A80", VA = "0x10806C80", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B985")]
    [Address(RVA = "0x8091F0", Offset = "0x807FF0", VA = "0x108091F0")]
    private IEnumerator QuestResultAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B986")]
    [Address(RVA = "0x808050", Offset = "0x806E50", VA = "0x10808050")]
    private IEnumerator GainPlayerExpAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B987")]
    [Address(RVA = "0x8080C0", Offset = "0x806EC0", VA = "0x108080C0")]
    private IEnumerator GainUnitExpAnimation() => (IEnumerator) null;

    [Token(Token = "0x600B988")]
    [Address(RVA = "0x808170", Offset = "0x806F70", VA = "0x10808170")]
    private void InitPlayerLevel()
    {
    }

    [Token(Token = "0x600B989")]
    [Address(RVA = "0x80A560", Offset = "0x809360", VA = "0x1080A560")]
    public RaidResultWindow()
    {
    }

    [Token(Token = "0x20028FB")]
    public enum ResultButtonType
    {
      [Token(Token = "0x400C55E")] OkOnly,
      [Token(Token = "0x400C55F")] CloseAndQuestlist,
      [Token(Token = "0x400C560")] HomeAndQuestlist,
    }
  }
}
