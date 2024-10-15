// Decompiled with JetBrains decompiler
// Type: SRPG.QuestArchiveListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200286C")]
  [AddComponentMenu("UI/QuestArchiveListWindow")]
  [FlowNode.Pin(140, "ミッションを開く", FlowNode.PinTypes.Output, 140)]
  [FlowNode.Pin(130, "イベント詳細を開く", FlowNode.PinTypes.Output, 130)]
  [FlowNode.Pin(112, "ボスバトル画面へ", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(111, "ボスバトル一覧画面へ", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(110, "既に開放中のクエストの出撃へ", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "クエストを開放するか？", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(120, "開放時間の過ぎたクエストが選択された", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(12, "イベント詳細ボタンがクリックされた", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(14, "クエストリストからアーカイブウィンドウに戻る", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(0, "Initialize", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(13, "ミッションボタンがクリックされた", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(3, "Refresh(noResetPos)", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(10, "開放ボタンが押下された", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "挑戦ボタンが押下された", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(2, "TabChange", FlowNode.PinTypes.Input, 2)]
  public class QuestArchiveListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C132")]
    public const int INPUT_PIN_INITIALIZE = 0;
    [Token(Token = "0x400C133")]
    public const int INPUT_PIN_REFRESH = 1;
    [Token(Token = "0x400C134")]
    public const int INPUT_PIN_TAB_CHANGE = 2;
    [Token(Token = "0x400C135")]
    public const int INPUT_PIN_NORESET_REFRESH = 3;
    [Token(Token = "0x400C136")]
    public const int INPUT_PIN_QUEST_OPEN_BTN = 10;
    [Token(Token = "0x400C137")]
    public const int INPUT_PIN_QUEST_CHALLENGE_BTN = 11;
    [Token(Token = "0x400C138")]
    public const int INPUT_PIN_QUEST_DETAILS_BTN = 12;
    [Token(Token = "0x400C139")]
    public const int INPUT_PIN_QUEST_MISSION_BTN = 13;
    [Token(Token = "0x400C13A")]
    public const int INPUT_PIN_RETURN_ARCHIVE_LIST = 14;
    [Token(Token = "0x400C13B")]
    public const int OUTPUT_PIN_QUEST_OPEN_CONFIRM = 100;
    [Token(Token = "0x400C13C")]
    public const int OUTPUT_PIN_QUEST_OPENED_GO_CHALLENGE = 110;
    [Token(Token = "0x400C13D")]
    public const int OUTPUT_PIN_QUEST_BOSSBATTLE = 111;
    [Token(Token = "0x400C13E")]
    public const int OUTPUT_PIN_QUEST_BOSSBATTLE_MAP = 112;
    [Token(Token = "0x400C13F")]
    public const int OUTPUT_PIN_QUEST_CLOSED_ALREADY = 120;
    [Token(Token = "0x400C140")]
    public const int OUTPUT_PIN_QUEST_OPEN_EVENT_DETAILS = 130;
    [Token(Token = "0x400C141")]
    public const int OUTPUT_PIN_MISSION = 140;
    [Token(Token = "0x400C142")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject QuestArchiveTemplate;
    [Token(Token = "0x400C143")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle[] TabList;
    [Token(Token = "0x400C144")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit ArchiveContentExhibit;
    [Token(Token = "0x400C145")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour serializeValue;
    [Token(Token = "0x400C146")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ExhibitList KeyItemExhibitList;
    [Token(Token = "0x400C147")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentController ContentControllerObj;
    [Token(Token = "0x400C148")]
    [FieldOffset(Offset = "0x24")]
    private List<QuestArchiveModel> _archiveModelList;
    [Token(Token = "0x400C149")]
    [FieldOffset(Offset = "0x28")]
    private string mSelectedChapterName;
    [Token(Token = "0x400C14A")]
    [FieldOffset(Offset = "0x2C")]
    [Space(5f)]
    [Header("スクロール位置を再計算する")]
    [SerializeField]
    private SRPG_ScrollRect ScrollRectController;
    [Token(Token = "0x400C14B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x400C14C")]
    [FieldOffset(Offset = "0x34")]
    private List<GameObject> mQuestList;
    [Token(Token = "0x400C14D")]
    [FieldOffset(Offset = "0x38")]
    private QuestArchiveListWindow.ETabType mCurrentTab;

    [Token(Token = "0x600B6AC")]
    [Address(RVA = "0x7D1220", Offset = "0x7D0020", VA = "0x107D1220", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B6AD")]
    [Address(RVA = "0x7D1720", Offset = "0x7D0520", VA = "0x107D1720")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B6AE")]
    [Address(RVA = "0x7D1780", Offset = "0x7D0580", VA = "0x107D1780")]
    private void ChangeTab(QuestArchiveListWindow.ETabType tabtype)
    {
    }

    [Token(Token = "0x600B6AF")]
    [Address(RVA = "0x7D2010", Offset = "0x7D0E10", VA = "0x107D2010")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600B6B0")]
    [Address(RVA = "0x7D2610", Offset = "0x7D1410", VA = "0x107D2610")]
    private void RefreshList()
    {
    }

    [Token(Token = "0x600B6B1")]
    [Address(RVA = "0x7D2500", Offset = "0x7D1300", VA = "0x107D2500")]
    private void NoPosRefreshList()
    {
    }

    [Token(Token = "0x600B6B2")]
    [Address(RVA = "0x7D1C80", Offset = "0x7D0A80", VA = "0x107D1C80")]
    private void ClickQuestOpen()
    {
    }

    [Token(Token = "0x600B6B3")]
    [Address(RVA = "0x7D1B20", Offset = "0x7D0920", VA = "0x107D1B20")]
    private void ClickQuestDetail()
    {
    }

    [Token(Token = "0x600B6B4")]
    [Address(RVA = "0x7D17A0", Offset = "0x7D05A0", VA = "0x107D17A0")]
    private void ClickQuestChallenge()
    {
    }

    [Token(Token = "0x600B6B5")]
    [Address(RVA = "0x66DB90", Offset = "0x66C990", VA = "0x1066DB90")]
    private void ClickMission()
    {
    }

    [Token(Token = "0x600B6B6")]
    [Address(RVA = "0x7D2A70", Offset = "0x7D1870", VA = "0x107D2A70")]
    private void ResetArchiveListScrollPos(string iname)
    {
    }

    [Token(Token = "0x600B6B7")]
    [Address(RVA = "0x7D2CF0", Offset = "0x7D1AF0", VA = "0x107D2CF0")]
    private void SetTabOn()
    {
    }

    [Token(Token = "0x600B6B8")]
    [Address(RVA = "0x7D1EA0", Offset = "0x7D0CA0", VA = "0x107D1EA0")]
    private List<ChapterParam> GetChapterList() => (List<ChapterParam>) null;

    [Token(Token = "0x600B6B9")]
    [Address(RVA = "0x7D2C90", Offset = "0x7D1A90", VA = "0x107D2C90")]
    private void SetCurrentTab(ArchiveParam archiveParam)
    {
    }

    [Token(Token = "0x600B6BA")]
    [Address(RVA = "0x7D2D60", Offset = "0x7D1B60", VA = "0x107D2D60")]
    public QuestArchiveListWindow()
    {
    }

    [Token(Token = "0x200286D")]
    public enum ETabType
    {
      [Token(Token = "0x400C14F")] Encounter,
      [Token(Token = "0x400C150")] Season,
      [Token(Token = "0x400C151")] Artifact,
      [Token(Token = "0x400C152")] BossBattle,
    }
  }
}
