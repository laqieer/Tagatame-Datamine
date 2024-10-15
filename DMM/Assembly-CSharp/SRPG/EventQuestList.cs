// Decompiled with JetBrains decompiler
// Type: SRPG.EventQuestList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002374")]
  [FlowNode.Pin(10, "機能購入時の更新", FlowNode.PinTypes.Input, 9)]
  [FlowNode.Pin(7, "更新", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(6, "塔チャプター切り替え", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(5, "GPSチャプター切り替え", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(4, "鍵チャプター切り替え", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(3, "通常チャプター切り替え", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(2, "リスト階層を戻る", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1, "リスト要素を選択", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(0, "再読み込み", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(8, "ランキングクエストへチャプター切り替え", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(9, "UIの更新", FlowNode.PinTypes.Input, 8)]
  [AddComponentMenu("UI/EventQuestList")]
  [FlowNode.Pin(400, "スコアチャレンジクエストが選択された", FlowNode.PinTypes.Output, 400)]
  [FlowNode.Pin(300, "戦闘力クエストエリア条件未達成", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(201, "マルチ塔が選択された", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(200, "塔が選択された", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(101, "クエストのアンロック", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "クエストが選択された", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(50, "再読み込み完了", FlowNode.PinTypes.Output, 50)]
  [FlowNode.Pin(11, "戦闘力クエスト切り替え", FlowNode.PinTypes.Input, 10)]
  public class EventQuestList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009F5F")]
    private const int PIN_IN_RELOAD = 0;
    [Token(Token = "0x4009F60")]
    private const int PIN_IN_SELECT_LIST_ITEM = 1;
    [Token(Token = "0x4009F61")]
    private const int PIN_IN_UPTO_LIST_LAYER = 2;
    [Token(Token = "0x4009F62")]
    private const int PIN_IN_TO_NORMAL_CHAPTER = 3;
    [Token(Token = "0x4009F63")]
    private const int PIN_IN_TO_KEY_CHAPTER = 4;
    [Token(Token = "0x4009F64")]
    private const int PIN_IN_TO_GPS_CHAPTER = 5;
    [Token(Token = "0x4009F65")]
    private const int PIN_IN_TO_TOWER_CHAPTER = 6;
    [Token(Token = "0x4009F66")]
    private const int PIN_IN_REFRESH = 7;
    [Token(Token = "0x4009F67")]
    private const int PIN_IN_TO_RANKING = 8;
    [Token(Token = "0x4009F68")]
    private const int PIN_IN_UI_REFRESH = 9;
    [Token(Token = "0x4009F69")]
    private const int PIN_IN_BUY_FUNC_REFRESH = 10;
    [Token(Token = "0x4009F6A")]
    private const int PIN_IN_TO_COMBAT_POWER = 11;
    [Token(Token = "0x4009F6B")]
    private const int PIN_OUT_FIN_RELOAD = 50;
    [Token(Token = "0x4009F6C")]
    private const int PIN_OUT_SELECT_QUEST = 100;
    [Token(Token = "0x4009F6D")]
    private const int PIN_OUT_UNLOCK_QUEST = 101;
    [Token(Token = "0x4009F6E")]
    private const int PIN_OUT_SELECT_TOWER = 200;
    [Token(Token = "0x4009F6F")]
    private const int PIN_OUT_SELECT_MULTI_TOWER = 201;
    [Token(Token = "0x4009F70")]
    private const int PIN_OUT_LOCK_COMBAT_POWER = 300;
    [Token(Token = "0x4009F71")]
    private const int PIN_OUT_SELECT_SCORE_CHALLENGE = 400;
    [Token(Token = "0x4009F72")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemTemplate;
    [Token(Token = "0x4009F73")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemContainer;
    [Token(Token = "0x4009F74")]
    [FieldOffset(Offset = "0x14")]
    public bool Descending;
    [Token(Token = "0x4009F75")]
    [FieldOffset(Offset = "0x15")]
    public bool RefreshOnStart;
    [Token(Token = "0x4009F76")]
    [FieldOffset(Offset = "0x18")]
    public RectTransform SwitchParent;
    [Token(Token = "0x4009F77")]
    [FieldOffset(Offset = "0x1C")]
    public Button EventQuestButton;
    [Token(Token = "0x4009F78")]
    [FieldOffset(Offset = "0x20")]
    public Button KeyQuestButton;
    [Token(Token = "0x4009F79")]
    [FieldOffset(Offset = "0x24")]
    public Button TowerQuestButton;
    [Token(Token = "0x4009F7A")]
    [FieldOffset(Offset = "0x28")]
    public GameObject KeyQuestOpenEffect;
    [Token(Token = "0x4009F7B")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject QuestTypeTextFrame;
    [Token(Token = "0x4009F7C")]
    [FieldOffset(Offset = "0x30")]
    public Text QuestTypeText;
    [Token(Token = "0x4009F7D")]
    [FieldOffset(Offset = "0x34")]
    public GameObject TabTriple;
    [Token(Token = "0x4009F7E")]
    [FieldOffset(Offset = "0x38")]
    public GameObject TabDouble;
    [Token(Token = "0x4009F7F")]
    [FieldOffset(Offset = "0x3C")]
    public Toggle[] TripleTabPages;
    [Token(Token = "0x4009F80")]
    [FieldOffset(Offset = "0x40")]
    public Toggle[] DoubleTabPages;
    [Token(Token = "0x4009F81")]
    [FieldOffset(Offset = "0x44")]
    public GameObject BackButton;
    [Token(Token = "0x4009F82")]
    [FieldOffset(Offset = "0x48")]
    public GameObject Caution;
    [Token(Token = "0x4009F83")]
    [FieldOffset(Offset = "0x4C")]
    public Text CautionText;
    [Token(Token = "0x4009F84")]
    [FieldOffset(Offset = "0x50")]
    public Vector2 DefaultScrollPosition;
    [Token(Token = "0x4009F85")]
    [FieldOffset(Offset = "0x58")]
    public GameObject[] DisabledInBeginnerQuest;
    [Token(Token = "0x4009F86")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject ChapterCount;
    [Token(Token = "0x4009F87")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text ChapterCountText;
    [Token(Token = "0x4009F88")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text ChapterCountLimit;
    [Token(Token = "0x4009F89")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Header("スクロール位置を再計算する")]
    private SRPG_ScrollRect ChapterScrollRect;
    [Token(Token = "0x4009F8A")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private CalcPositionScrollRect PosCalculator;
    [Token(Token = "0x4009F8B")]
    [FieldOffset(Offset = "0x70")]
    private bool mIsParentToChild;
    [Token(Token = "0x4009F8C")]
    [FieldOffset(Offset = "0x74")]
    private float BITING_PREVENT_VELOCITY;
    [Token(Token = "0x4009F8D")]
    [FieldOffset(Offset = "0x78")]
    private List<ListItemEvents> mItems;
    [Token(Token = "0x4009F8E")]
    [FieldOffset(Offset = "0x7C")]
    private int mTabIndex;
    [Token(Token = "0x4009F8F")]
    [FieldOffset(Offset = "0x80")]
    private GameObject mCurrentTab;
    [Token(Token = "0x4009F90")]
    [FieldOffset(Offset = "0x84")]
    private Toggle[] mCurrentTabPages;
    [Token(Token = "0x4009F91")]
    [FieldOffset(Offset = "0x88")]
    private EventQuestList.EventQuestTypes mEventType;
    [Token(Token = "0x4009F92")]
    [FieldOffset(Offset = "0x8C")]
    private bool mForceChangeTab;

    [Token(Token = "0x600991E")]
    [Address(RVA = "0x5D1140", Offset = "0x5CFF40", VA = "0x105D1140")]
    private void Awake()
    {
    }

    [Token(Token = "0x600991F")]
    [Address(RVA = "0x5D27D0", Offset = "0x5D15D0", VA = "0x105D27D0")]
    private EventQuestList.EventQuestTypes GetQuestTypeFromSelectedChapter(string chapterName)
    {
      return new EventQuestList.EventQuestTypes();
    }

    [Token(Token = "0x6009920")]
    [Address(RVA = "0x5D2520", Offset = "0x5D1320", VA = "0x105D2520")]
    private SubQuestTypes GetHighestPrioritySubType() => new SubQuestTypes();

    [Token(Token = "0x6009921")]
    [Address(RVA = "0x5D5D50", Offset = "0x5D4B50", VA = "0x105D5D50")]
    private void ResetScroll(Vector2 _pos)
    {
    }

    [Token(Token = "0x6009922")]
    [Address(RVA = "0x5D0AB0", Offset = "0x5CF8B0", VA = "0x105D0AB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009923")]
    [Address(RVA = "0x5D5DF0", Offset = "0x5D4BF0", VA = "0x105D5DF0")]
    private void RestoreHierarchyRoot()
    {
    }

    [Token(Token = "0x6009924")]
    [Address(RVA = "0x5D5E60", Offset = "0x5D4C60", VA = "0x105D5E60")]
    private void RestoreHierarchy()
    {
    }

    [Token(Token = "0x6009925")]
    [Address(RVA = "0x5D2EB0", Offset = "0x5D1CB0", VA = "0x105D2EB0")]
    private bool IsSectionHidden(string iname) => new bool();

    [Token(Token = "0x6009926")]
    [Address(RVA = "0x5D19C0", Offset = "0x5D07C0", VA = "0x105D19C0")]
    public static bool ChapterContainsPlayableQuest(
      ChapterParam chapter,
      ChapterParam[] allChapters,
      QuestParam[] availableQuests,
      long currentTime,
      bool _is_point_quest = false)
    {
      return new bool();
    }

    [Token(Token = "0x6009927")]
    [Address(RVA = "0x5D2C40", Offset = "0x5D1A40", VA = "0x105D2C40")]
    private bool IsChapterChildOf(ChapterParam child, ChapterParam parent) => new bool();

    [Token(Token = "0x6009928")]
    [Address(RVA = "0x5D1C40", Offset = "0x5D0A40", VA = "0x105D1C40")]
    private List<ChapterParam> GetAvailableChapters(
      EventQuestList.EventQuestTypes type,
      ChapterParam[] allChapters,
      QuestParam[] questsAvailable,
      string selectedSection,
      string selectedChapter,
      long currentTime,
      out ChapterParam currentChapter)
    {
      return (List<ChapterParam>) null;
    }

    [Token(Token = "0x6009929")]
    [Address(RVA = "0x5D6110", Offset = "0x5D4F10", VA = "0x105D6110")]
    private bool SelectAvailableChapter() => new bool();

    [Token(Token = "0x600992A")]
    [Address(RVA = "0x5D4530", Offset = "0x5D3330", VA = "0x105D4530")]
    private void Refresh(
      EventQuestList.EventQuestTypes type,
      bool _is_reset_flag = true,
      bool _is_out_pin = true)
    {
    }

    [Token(Token = "0x600992B")]
    [Address(RVA = "0x5D6330", Offset = "0x5D5130", VA = "0x105D6330")]
    private void SetScrollPos(EventQuestList.EventQuestTypes type)
    {
    }

    [Token(Token = "0x600992C")]
    [Address(RVA = "0x5D28F0", Offset = "0x5D16F0", VA = "0x105D28F0")]
    private IEnumerator InitScroll(Vector2 vector) => (IEnumerator) null;

    [Token(Token = "0x600992D")]
    [Address(RVA = "0x5D1860", Offset = "0x5D0660", VA = "0x105D1860")]
    private void ChangeChapterCountState(ChapterParam chapterParam)
    {
    }

    [Token(Token = "0x600992E")]
    [Address(RVA = "0x5D65E0", Offset = "0x5D53E0", VA = "0x105D65E0")]
    private void SetToggleIsOn()
    {
    }

    [Token(Token = "0x600992F")]
    [Address(RVA = "0x5D1BF0", Offset = "0x5D09F0", VA = "0x105D1BF0")]
    private void EnableTab()
    {
    }

    [Token(Token = "0x6009930")]
    [Address(RVA = "0x5D1BA0", Offset = "0x5D09A0", VA = "0x105D1BA0")]
    private void DisableTab()
    {
    }

    [Token(Token = "0x6009931")]
    [Address(RVA = "0x5D2970", Offset = "0x5D1770", VA = "0x105D2970")]
    private void InitializeTab(SubQuestTypes subtype)
    {
    }

    [Token(Token = "0x6009932")]
    [Address(RVA = "0x5D5C90", Offset = "0x5D4A90", VA = "0x105D5C90")]
    private void RemoveTabs()
    {
    }

    [Token(Token = "0x6009933")]
    [Address(RVA = "0x5D3A60", Offset = "0x5D2860", VA = "0x105D3A60")]
    private void OnToggleValueChanged(int index)
    {
    }

    [Token(Token = "0x6009934")]
    [Address(RVA = "0x5D42E0", Offset = "0x5D30E0", VA = "0x105D42E0")]
    private void RefreshSwitchButton(EventQuestList.EventQuestTypes type)
    {
    }

    [Token(Token = "0x6009935")]
    [Address(RVA = "0x5D1040", Offset = "0x5CFE40", VA = "0x105D1040")]
    private void AllRefreshQuestButtonState(
      bool is_quest,
      bool is_key,
      bool is_key_exist,
      bool is_tower)
    {
    }

    [Token(Token = "0x6009936")]
    [Address(RVA = "0x5D3F50", Offset = "0x5D2D50", VA = "0x105D3F50")]
    private void RefreshBeginnerObjects(EventQuestList.EventQuestTypes type)
    {
    }

    [Token(Token = "0x6009937")]
    [Address(RVA = "0x5D3FE0", Offset = "0x5D2DE0", VA = "0x105D3FE0")]
    private bool RefreshQuestButtonState(Button _btn, bool _active, bool _interactable)
    {
      return new bool();
    }

    [Token(Token = "0x6009938")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0")]
    private bool IsOpenRankingQuest() => new bool();

    [Token(Token = "0x6009939")]
    [Address(RVA = "0x5D40F0", Offset = "0x5D2EF0", VA = "0x105D40F0")]
    private void RefreshQuestTypeText(EventQuestList.EventQuestTypes type)
    {
    }

    [Token(Token = "0x600993A")]
    [Address(RVA = "0x5D1B10", Offset = "0x5D0910", VA = "0x105D1B10")]
    private bool CheckChapterChallengeable(ChapterParam chapter) => new bool();

    [Token(Token = "0x600993B")]
    [Address(RVA = "0x5D36D0", Offset = "0x5D24D0", VA = "0x105D36D0")]
    private void OnNodeSelect(GameObject go)
    {
    }

    [Token(Token = "0x600993C")]
    [Address(RVA = "0x5D3000", Offset = "0x5D1E00", VA = "0x105D3000")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600993D")]
    [Address(RVA = "0x5D3C50", Offset = "0x5D2A50", VA = "0x105D3C50")]
    private void OnTowerSelect(GameObject go)
    {
    }

    [Token(Token = "0x600993E")]
    [Address(RVA = "0x5D3530", Offset = "0x5D2330", VA = "0x105D3530")]
    private void OnMultiTowerSelect(GameObject go)
    {
    }

    [Token(Token = "0x600993F")]
    [Address(RVA = "0x5D2380", Offset = "0x5D1180", VA = "0x105D2380")]
    private int GetEventListIndex(string iname, EventQuestList.EventQuestTypes type) => new int();

    [Token(Token = "0x6009940")]
    public void StableSort<T>(List<T> list, Comparison<T> comparison)
    {
    }

    [Token(Token = "0x6009941")]
    [Address(RVA = "0x5D2C70", Offset = "0x5D1A70", VA = "0x105D2C70")]
    public bool IsOpendTower() => new bool();

    [Token(Token = "0x6009942")]
    [Address(RVA = "0x5D66B0", Offset = "0x5D54B0", VA = "0x105D66B0")]
    private int SortKeyQuest(ChapterParam param) => new int();

    [Token(Token = "0x6009943")]
    [Address(RVA = "0x5D6820", Offset = "0x5D5620", VA = "0x105D6820")]
    public EventQuestList()
    {
    }

    [Token(Token = "0x2002375")]
    public enum EventQuestTypes
    {
      [Token(Token = "0x4009F94")] Normal,
      [Token(Token = "0x4009F95")] Key,
      [Token(Token = "0x4009F96")] Gps,
      [Token(Token = "0x4009F97")] Tower,
      [Token(Token = "0x4009F98")] Ranking,
      [Token(Token = "0x4009F99")] Beginner,
      [Token(Token = "0x4009F9A")] NormalAndGps,
      [Token(Token = "0x4009F9B")] Archive,
      [Token(Token = "0x4009F9C")] CombatPower,
    }

    [Token(Token = "0x2002376")]
    private enum KeyQuestSortNum
    {
      [Token(Token = "0x4009F9E")] OPEN,
      [Token(Token = "0x4009F9F")] RELEASE_POSSIBLE,
      [Token(Token = "0x4009FA0")] RELEASE_IMPOSSIBLE,
      [Token(Token = "0x4009FA1")] LOCK,
      [Token(Token = "0x4009FA2")] NONE,
    }
  }
}
