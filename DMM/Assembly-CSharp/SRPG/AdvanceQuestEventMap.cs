// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceQuestEventMap
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
  [Token(Token = "0x2001F58")]
  [FlowNode.Pin(41, "難易度変更", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Advance/AdvanceQuestEventMap")]
  [FlowNode.Pin(201, "選択中チャプターをリセット", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(143, "キークエスト終了", FlowNode.PinTypes.Output, 143)]
  [FlowNode.Pin(144, "アーカイブ用開催期間外", FlowNode.PinTypes.Output, 144)]
  [FlowNode.Pin(11, "Refresh", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(141, "クエスト選択された", FlowNode.PinTypes.Output, 141)]
  [FlowNode.Pin(132, "StarRewardAllReceive", FlowNode.PinTypes.Output, 132)]
  [FlowNode.Pin(131, "OpenStarReward", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(51, "ミッション一括受取", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(142, "クエスト開催期間外", FlowNode.PinTypes.Output, 142)]
  public class AdvanceQuestEventMap : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400840A")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x400840B")]
    public const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x400840C")]
    public const int PIN_IN_CHANGE_DIFFICULTY = 41;
    [Token(Token = "0x400840D")]
    public const int PIN_IN_STARMISSION_ALL_RECEIVE = 51;
    [Token(Token = "0x400840E")]
    public const int PIN_OUT_INIT = 101;
    [Token(Token = "0x400840F")]
    public const int PIN_OUT_OPEN_STAR_REWARD = 131;
    [Token(Token = "0x4008410")]
    public const int PIN_OUT_STAR_REWARD_ALL_RECEIVE = 132;
    [Token(Token = "0x4008411")]
    public const int PIN_OUT_SELECT_QUEST = 141;
    [Token(Token = "0x4008412")]
    public const int PIN_OUT_QUEST_OUT_OF_PERIOD = 142;
    [Token(Token = "0x4008413")]
    public const int PIN_OUT_KEY_QUEST_OUT_OF_PERIOD = 143;
    [Token(Token = "0x4008414")]
    public const int PIN_OUT_ARCHIVE_OUT_PERIOD = 144;
    [Token(Token = "0x4008415")]
    public const int PIN_OUT_RESET_SELECTED_CHAPTER = 201;
    [Token(Token = "0x4008416")]
    public const string ADVANCE_STAR_REWARD_SVB_KEY = "ADVANCE_STAR_REWARD";
    [Token(Token = "0x4008417")]
    public const string ADVANCE_STAR_POINT_SVB_KEY = "ADVANCE_STAR_POINT";
    [Token(Token = "0x4008418")]
    public const string ADVANCE_QUEST_PARAM_KEY = "ADVANCE_QUEST_PARAM";
    [Token(Token = "0x4008419")]
    public const string ADVANCE_ALL_STAR_REWARD_SVB_KEY = "ADVANCE_ALL_STAR_REWARD";
    [Token(Token = "0x400841A")]
    [FieldOffset(Offset = "0xC")]
    private Dictionary<QuestDifficulties, List<QuestParam>> mQuestList;
    [Token(Token = "0x400841B")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<QuestDifficulties, List<AdvanceQuestMapSymbol>> mQuestSymbols;
    [Token(Token = "0x400841C")]
    [FieldOffset(Offset = "0x14")]
    private Dictionary<QuestDifficulties, List<QuestParam>> mQuestAvailable;
    [Token(Token = "0x400841D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AnimationCurve mScrollCurve;
    [Token(Token = "0x400841E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform mBGParent;
    [Token(Token = "0x400841F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mPreviewParent;
    [Token(Token = "0x4008420")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private AdvanceQuestMapSymbol mRefQuestSymbol;
    [Token(Token = "0x4008421")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GameObject> mRefQuestCursor;
    [Token(Token = "0x4008422")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private AdvanceQuestEventMapStarIcon StarRewardIconTemplate;
    [Token(Token = "0x4008423")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button mStartRewardAllReceiveBtn;
    [Token(Token = "0x4008424")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Slider StarPointGauge;
    [Token(Token = "0x4008425")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text StarPointCurrent;
    [Token(Token = "0x4008426")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text StarPointMax;
    [Token(Token = "0x4008427")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text ChapterTitle;
    [Token(Token = "0x4008428")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text ChapterDifficulty;
    [Token(Token = "0x4008429")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ImageArray TitleBack;
    [Token(Token = "0x400842A")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private List<ImageArray> ButtonDifficulty;
    [Token(Token = "0x400842B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<string> LocalizeDifficultyKey;
    [Token(Token = "0x400842C")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private SRPG_ScrollRect mRefScrollRect;
    [Token(Token = "0x400842D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private float mScrollTime;
    [Token(Token = "0x400842E")]
    [FieldOffset(Offset = "0x5C")]
    private List<AdvanceQuestEventMapStarIcon> StarRewardIconList;
    [Token(Token = "0x400842F")]
    [FieldOffset(Offset = "0x60")]
    private int mChapterStarCurrent;
    [Token(Token = "0x4008430")]
    [FieldOffset(Offset = "0x64")]
    private AdvanceQuestMapIcon mCurrentSelectIcon;
    [Token(Token = "0x4008431")]
    [FieldOffset(Offset = "0x68")]
    private AdvanceEventManager mEventManager;
    [Token(Token = "0x4008432")]
    [FieldOffset(Offset = "0x6C")]
    private AdvanceEventParam mEventParam;
    [Token(Token = "0x4008433")]
    [FieldOffset(Offset = "0x70")]
    private QuestDifficulties[] mDifficultyList;

    [Token(Token = "0x1700126D")]
    private AdvanceEventManager EventManager
    {
      [Token(Token = "0x600808E"), Address(RVA = "0x410BC0", Offset = "0x40F9C0", VA = "0x10410BC0")] get
      {
        return (AdvanceEventManager) null;
      }
    }

    [Token(Token = "0x1700126E")]
    private AdvanceEventParam EventParam
    {
      [Token(Token = "0x600808F"), Address(RVA = "0x410C50", Offset = "0x40FA50", VA = "0x10410C50")] get
      {
        return (AdvanceEventParam) null;
      }
    }

    [Token(Token = "0x1700126F")]
    private QuestDifficulties[] DifficultyList
    {
      [Token(Token = "0x6008090"), Address(RVA = "0x410AD0", Offset = "0x40F8D0", VA = "0x10410AD0")] get
      {
        return (QuestDifficulties[]) null;
      }
    }

    [Token(Token = "0x6008091")]
    [Address(RVA = "0x40D840", Offset = "0x40C640", VA = "0x1040D840")]
    private List<QuestParam> GetDifficultyQuestList(QuestDifficulties difficulty)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x6008092")]
    [Address(RVA = "0x40D970", Offset = "0x40C770", VA = "0x1040D970")]
    private bool Init() => new bool();

    [Token(Token = "0x6008093")]
    [Address(RVA = "0x40D500", Offset = "0x40C300", VA = "0x1040D500")]
    private List<QuestDifficulties> GetAvailableDifficultyList() => (List<QuestDifficulties>) null;

    [Token(Token = "0x6008094")]
    [Address(RVA = "0x40EE70", Offset = "0x40DC70", VA = "0x1040EE70")]
    private bool Refresh() => new bool();

    [Token(Token = "0x6008095")]
    [Address(RVA = "0x40EAF0", Offset = "0x40D8F0", VA = "0x1040EAF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008096")]
    [Address(RVA = "0x40CE60", Offset = "0x40BC60", VA = "0x1040CE60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008097")]
    [Address(RVA = "0x4102A0", Offset = "0x40F0A0", VA = "0x104102A0")]
    private void ResetParameters()
    {
    }

    [Token(Token = "0x6008098")]
    [Address(RVA = "0x4105B0", Offset = "0x40F3B0", VA = "0x104105B0")]
    private bool SetNextDifficulty() => new bool();

    [Token(Token = "0x6008099")]
    [Address(RVA = "0x40EB70", Offset = "0x40D970", VA = "0x1040EB70")]
    private void RefreshDifficultyButton()
    {
    }

    [Token(Token = "0x600809A")]
    [Address(RVA = "0x40D4E0", Offset = "0x40C2E0", VA = "0x1040D4E0")]
    private void FinishLoad()
    {
    }

    [Token(Token = "0x600809B")]
    [Address(RVA = "0x40D1F0", Offset = "0x40BFF0", VA = "0x1040D1F0")]
    private void DownLoadedBG(GameObject bg_prefab)
    {
    }

    [Token(Token = "0x600809C")]
    [Address(RVA = "0x40D420", Offset = "0x40C220", VA = "0x1040D420")]
    private void DownLoadedPreview(GameObject preview_prefab)
    {
    }

    [Token(Token = "0x600809D")]
    [Address(RVA = "0x410710", Offset = "0x40F510", VA = "0x10410710")]
    private void SetSelectedQuest(AdvanceQuestMapIcon icon, QuestDifficulties difficulty)
    {
    }

    [Token(Token = "0x600809E")]
    [Address(RVA = "0x40E9D0", Offset = "0x40D7D0", VA = "0x1040E9D0")]
    private void OnClickSymbolIcon(AdvanceQuestMapIcon icon, QuestParam param)
    {
    }

    [Token(Token = "0x600809F")]
    [Address(RVA = "0x40DD90", Offset = "0x40CB90", VA = "0x1040DD90")]
    private bool IsEventOpen() => new bool();

    [Token(Token = "0x60080A0")]
    [Address(RVA = "0x40DFC0", Offset = "0x40CDC0", VA = "0x1040DFC0")]
    private void OnClickLockedIcon(AdvanceQuestMapIcon icon)
    {
    }

    [Token(Token = "0x60080A1")]
    [Address(RVA = "0x4103E0", Offset = "0x40F1E0", VA = "0x104103E0")]
    private void ScrollTo(AdvanceQuestMapIcon icon)
    {
    }

    [Token(Token = "0x60080A2")]
    [Address(RVA = "0x410520", Offset = "0x40F320", VA = "0x10410520")]
    private IEnumerator ScrollTo(
      Transform target_transform,
      SRPG_ScrollRect scroll_rect,
      AnimationCurve curve,
      float scroll_time)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60080A3")]
    [Address(RVA = "0x40E800", Offset = "0x40D600", VA = "0x1040E800")]
    public void OnClickStarRewardIcon(GameObject icon)
    {
    }

    [Token(Token = "0x60080A4")]
    [Address(RVA = "0x40E1D0", Offset = "0x40CFD0", VA = "0x1040E1D0")]
    private void OnClickStarRewardAllReceive()
    {
    }

    [Token(Token = "0x60080A5")]
    [Address(RVA = "0x40DBA0", Offset = "0x40C9A0", VA = "0x1040DBA0")]
    private bool IsAvailableDifficulty(QuestDifficulties difficulty) => new bool();

    [Token(Token = "0x60080A6")]
    [Address(RVA = "0x40D600", Offset = "0x40C400", VA = "0x1040D600")]
    private int GetAvailableDifficultyNum() => new int();

    [Token(Token = "0x60080A7")]
    [Address(RVA = "0x40D680", Offset = "0x40C480", VA = "0x1040D680")]
    private List<QuestParam> GetAvailableQuest(QuestDifficulties difficulty)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x60080A8")]
    [Address(RVA = "0x4100F0", Offset = "0x40EEF0", VA = "0x104100F0")]
    private void ResetBossChapterParam()
    {
    }

    [Token(Token = "0x60080A9")]
    [Address(RVA = "0x4109A0", Offset = "0x40F7A0", VA = "0x104109A0")]
    public AdvanceQuestEventMap()
    {
    }
  }
}
