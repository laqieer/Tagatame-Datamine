// Decompiled with JetBrains decompiler
// Type: SRPG.OrdealQuestList
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
  [Token(Token = "0x20027C4")]
  [FlowNode.Pin(1000, "クエスト開始", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(0, "チーム情報更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "クエスト開始要求", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "チャプターリストに戻る", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/OrdealQuestList")]
  [FlowNode.Pin(1100, "チーム編成開始", FlowNode.PinTypes.Output, 1100)]
  [FlowNode.Pin(1200, "クエスト選択", FlowNode.PinTypes.Output, 1200)]
  public class OrdealQuestList : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400BC52")]
    private const int PIN_IN_TEAM_REFRESH = 0;
    [Token(Token = "0x400BC53")]
    private const int PIN_IN_GOTO_QUEST = 1;
    [Token(Token = "0x400BC54")]
    private const int PIN_IN_BACK_CHAPTER = 2;
    [Token(Token = "0x400BC55")]
    private const int PIN_OUT_START_QUEST = 1000;
    [Token(Token = "0x400BC56")]
    private const int PIN_OUT_START_TEAM_EDIT = 1100;
    [Token(Token = "0x400BC57")]
    private const int PIN_OUT_SELSECT_QUEST = 1200;
    [Token(Token = "0x400BC58")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemContainer;
    [Token(Token = "0x400BC59")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text QuestTypeText;
    [Token(Token = "0x400BC5A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ChapterScrollRect;
    [Token(Token = "0x400BC5B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject DetailTemplate;
    [Token(Token = "0x400BC5C")]
    [FieldOffset(Offset = "0x1C")]
    [Space(10f)]
    [SerializeField]
    private GameObject ItemQuestContainer;
    [Token(Token = "0x400BC5D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ItemQuestTemplate;
    [Token(Token = "0x400BC5E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text QuestListText;
    [Token(Token = "0x400BC5F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject QuestScrollRect;
    [Token(Token = "0x400BC60")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject DetailQuestTemplate;
    [Token(Token = "0x400BC61")]
    [FieldOffset(Offset = "0x30")]
    [Space(10f)]
    [SerializeField]
    private GameObject TeamPanelContainer;
    [Token(Token = "0x400BC62")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private OrdealTeamPanel TeamPanelTemplate;
    [Token(Token = "0x400BC63")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button StartButton;
    [Token(Token = "0x400BC64")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private ListItemEvents MissionButton;
    [Token(Token = "0x400BC65")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Image BossImage;
    [Token(Token = "0x400BC66")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text BossText;
    [Token(Token = "0x400BC67")]
    [FieldOffset(Offset = "0x48")]
    [Header("スクロール位置を再計算する")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x400BC68")]
    [FieldOffset(Offset = "0x4C")]
    private float BITING_PREVENT_VELOCITY;
    [Token(Token = "0x400BC69")]
    [FieldOffset(Offset = "0x50")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x400BC6A")]
    [FieldOffset(Offset = "0x54")]
    private List<ListItemEvents> mListItems;
    [Token(Token = "0x400BC6B")]
    [FieldOffset(Offset = "0x58")]
    private GameObject mDetailInfo;
    [Token(Token = "0x400BC6C")]
    [FieldOffset(Offset = "0x5C")]
    private ChapterParam mCurrentChapter;
    [Token(Token = "0x400BC6D")]
    [FieldOffset(Offset = "0x60")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x400BC6E")]
    [FieldOffset(Offset = "0x64")]
    private List<GameObject> mTeamPanels;

    [Token(Token = "0x600B2A8")]
    [Address(RVA = "0x7AB620", Offset = "0x7AA420", VA = "0x107AB620")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B2A9")]
    [Address(RVA = "0x7ADB90", Offset = "0x7AC990", VA = "0x107ADB90")]
    private void ResetScroll()
    {
    }

    [Token(Token = "0x600B2AA")]
    [Address(RVA = "0x7AB520", Offset = "0x7AA320", VA = "0x107AB520", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B2AB")]
    [Address(RVA = "0x7AB820", Offset = "0x7AA620", VA = "0x107AB820")]
    private bool ChapterContainsPlayableQuest(
      ChapterParam chapter,
      ChapterParam[] allChapters,
      QuestParam[] availableQuests,
      long currentTime)
    {
      return new bool();
    }

    [Token(Token = "0x600B2AC")]
    [Address(RVA = "0x7ABA00", Offset = "0x7AA800", VA = "0x107ABA00")]
    private List<ChapterParam> GetAvailableChapters(
      ChapterParam[] allChapters,
      QuestParam[] questsAvailable,
      long currentTime,
      out ChapterParam currentChapter)
    {
      return (List<ChapterParam>) null;
    }

    [Token(Token = "0x600B2AD")]
    [Address(RVA = "0x7AD3C0", Offset = "0x7AC1C0", VA = "0x107AD3C0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B2AE")]
    [Address(RVA = "0x7AD310", Offset = "0x7AC110", VA = "0x107AD310")]
    private void RefreshQuestTypeText()
    {
    }

    [Token(Token = "0x600B2AF")]
    [Address(RVA = "0x7ADFA0", Offset = "0x7ACDA0", VA = "0x107ADFA0")]
    private void StartQuest()
    {
    }

    [Token(Token = "0x600B2B0")]
    [Address(RVA = "0x7ADE90", Offset = "0x7ACC90", VA = "0x107ADE90")]
    private void StartQuestConfirmDownload()
    {
    }

    [Token(Token = "0x600B2B1")]
    [Address(RVA = "0x7AB9E0", Offset = "0x7AA7E0", VA = "0x107AB9E0")]
    private void DownloadApproved()
    {
    }

    [Token(Token = "0x600B2B2")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void DownloadNotApproved()
    {
    }

    [Token(Token = "0x600B2B3")]
    [Address(RVA = "0x7ADAB0", Offset = "0x7AC8B0", VA = "0x107ADAB0")]
    private void ResetMissionButton()
    {
    }

    [Token(Token = "0x600B2B4")]
    [Address(RVA = "0x7ABEA0", Offset = "0x7AACA0", VA = "0x107ABEA0")]
    private void LoadBossData(QuestParam quest)
    {
    }

    [Token(Token = "0x600B2B5")]
    [Address(RVA = "0x7AC200", Offset = "0x7AB000", VA = "0x107AC200")]
    private void LoadTeam()
    {
    }

    [Token(Token = "0x600B2B6")]
    [Address(RVA = "0x7AC6B0", Offset = "0x7AB4B0", VA = "0x107AC6B0")]
    private void OnClickTeamPanel(int index)
    {
    }

    [Token(Token = "0x600B2B7")]
    [Address(RVA = "0x7AB950", Offset = "0x7AA750", VA = "0x107AB950")]
    private void CheckPlayableTeams(
      QuestParam quest,
      List<PartyEditData> teams,
      List<SupportData> supports = null)
    {
    }

    [Token(Token = "0x600B2B8")]
    [Address(RVA = "0x7ABFF0", Offset = "0x7AADF0", VA = "0x107ABFF0")]
    private List<PartyEditData> LoadTeamFromPlayerPrefs() => (List<PartyEditData>) null;

    [Token(Token = "0x600B2B9")]
    [Address(RVA = "0x7AE090", Offset = "0x7ACE90", VA = "0x107AE090")]
    private void ValidateTeam(QuestParam quest, List<PartyEditData> teams, int maxTeamCount)
    {
    }

    [Token(Token = "0x600B2BA")]
    [Address(RVA = "0x7AC900", Offset = "0x7AB700", VA = "0x107AC900")]
    private void OnQuestListSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B2BB")]
    [Address(RVA = "0x7AD030", Offset = "0x7ABE30", VA = "0x107AD030")]
    private void OndetailSelect(GameObject go)
    {
    }

    [Token(Token = "0x600B2BC")]
    [Address(RVA = "0x7AC710", Offset = "0x7AB510", VA = "0x107AC710")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B2BD")]
    [Address(RVA = "0x7AC7B0", Offset = "0x7AB5B0", VA = "0x107AC7B0")]
    private void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600B2BE")]
    [Address(RVA = "0x7ABD90", Offset = "0x7AAB90", VA = "0x107ABD90", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600B2BF")]
    [Address(RVA = "0x7ABBC0", Offset = "0x7AA9C0", VA = "0x107ABBC0")]
    private List<UnitData> GetBattleEntryUnits() => (List<UnitData>) null;

    [Token(Token = "0x600B2C0")]
    [Address(RVA = "0x7ADC30", Offset = "0x7ACA30", VA = "0x107ADC30")]
    private void SetScrollPos()
    {
    }

    [Token(Token = "0x600B2C1")]
    [Address(RVA = "0x7ABE20", Offset = "0x7AAC20", VA = "0x107ABE20")]
    private IEnumerator InitScroll(Vector2 vector) => (IEnumerator) null;

    [Token(Token = "0x600B2C2")]
    [Address(RVA = "0x7AE1F0", Offset = "0x7ACFF0", VA = "0x107AE1F0")]
    public OrdealQuestList()
    {
    }
  }
}
