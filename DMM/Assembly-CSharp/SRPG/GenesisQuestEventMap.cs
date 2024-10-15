// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisQuestEventMap
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
  [Token(Token = "0x20024F1")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Refresh", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(51, "ミッション一括受取", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(132, "StarRewardAllReceive", FlowNode.PinTypes.Output, 132)]
  [FlowNode.Pin(141, "クエスト選択された", FlowNode.PinTypes.Output, 141)]
  [FlowNode.Pin(201, "選択中チャプターをリセット", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("UI/Genesis/GenesisQuestEventMap")]
  [FlowNode.Pin(41, "難易度変更", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(131, "OpenStarReward", FlowNode.PinTypes.Output, 131)]
  public class GenesisQuestEventMap : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A8B1")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x400A8B2")]
    public const int PIN_IN_REFRESH = 11;
    [Token(Token = "0x400A8B3")]
    public const int PIN_IN_CHANGE_DIFFICULTY = 41;
    [Token(Token = "0x400A8B4")]
    public const int PIN_IN_STARMISSION_ALL_RECEIVE = 51;
    [Token(Token = "0x400A8B5")]
    public const int PIN_OUT_INIT = 101;
    [Token(Token = "0x400A8B6")]
    public const int PIN_OUT_OPEN_STAR_REWARD = 131;
    [Token(Token = "0x400A8B7")]
    public const int PIN_OUT_STAR_REWARD_ALL_RECEIVE = 132;
    [Token(Token = "0x400A8B8")]
    public const int PIN_OUT_SELECT_QUEST = 141;
    [Token(Token = "0x400A8B9")]
    public const int PIN_OUT_RESET_SELECTED_CHAPTER = 201;
    [Token(Token = "0x400A8BA")]
    public const string GENESIS_STAR_REWARD_SVB_KEY = "GENESIS_STAR_REWARD";
    [Token(Token = "0x400A8BB")]
    public const string GENESIS_STAR_POINT_SVB_KEY = "GENESIS_STAR_POINT";
    [Token(Token = "0x400A8BC")]
    public const string GENESIS_QUEST_PARAM_KEY = "GENESIS_QUEST_PARAM";
    [Token(Token = "0x400A8BD")]
    [FieldOffset(Offset = "0xC")]
    private Dictionary<QuestDifficulties, List<QuestParam>> mQuestList;
    [Token(Token = "0x400A8BE")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<QuestDifficulties, List<GenesisQuestMapSymbol>> mQuestSymbols;
    [Token(Token = "0x400A8BF")]
    [FieldOffset(Offset = "0x14")]
    private Dictionary<QuestDifficulties, List<QuestParam>> mQuestAvailable;
    [Token(Token = "0x400A8C0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private AnimationCurve mRefCurve;
    [Token(Token = "0x400A8C1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform mBGParent;
    [Token(Token = "0x400A8C2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mPreviewParent;
    [Token(Token = "0x400A8C3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GenesisQuestMapSymbol mRefQuestSymbol;
    [Token(Token = "0x400A8C4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GameObject> mRefQuestCursor;
    [Token(Token = "0x400A8C5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GenesisQuestEventMapStarIcon StarRewardIconTemplate;
    [Token(Token = "0x400A8C6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button mStartRewardAllReceiveBtn;
    [Token(Token = "0x400A8C7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Slider StarPointGauge;
    [Token(Token = "0x400A8C8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text StarPointCurrent;
    [Token(Token = "0x400A8C9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text StarPointMax;
    [Token(Token = "0x400A8CA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text ChapterTitle;
    [Token(Token = "0x400A8CB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text ChapterDifficulty;
    [Token(Token = "0x400A8CC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ImageArray TitleBack;
    [Token(Token = "0x400A8CD")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private List<ImageArray> ButtonDifficulty;
    [Token(Token = "0x400A8CE")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<string> LocalizeDifficultyKey;
    [Token(Token = "0x400A8CF")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private SRPG_ScrollRect mRefScrollRect;
    [Token(Token = "0x400A8D0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private float mScrollTime;
    [Token(Token = "0x400A8D1")]
    [FieldOffset(Offset = "0x5C")]
    private List<GenesisQuestEventMapStarIcon> StarRewardIconList;
    [Token(Token = "0x400A8D2")]
    [FieldOffset(Offset = "0x60")]
    private int mChapterStarCurrent;
    [Token(Token = "0x400A8D3")]
    [FieldOffset(Offset = "0x64")]
    private GenesisQuestMapIcon mCurrentSelectIcon;
    [Token(Token = "0x400A8D4")]
    [FieldOffset(Offset = "0x68")]
    private GenesisChapterManager mChapterManager;
    [Token(Token = "0x400A8D5")]
    [FieldOffset(Offset = "0x6C")]
    private GenesisChapterParam mChapterParam;
    [Token(Token = "0x400A8D6")]
    [FieldOffset(Offset = "0x70")]
    private QuestDifficulties[] mDifficultyList;

    [Token(Token = "0x170016B2")]
    private GenesisChapterManager ChapterManager
    {
      [Token(Token = "0x600A232"), Address(RVA = "0x647C90", Offset = "0x646A90", VA = "0x10647C90")] get
      {
        return (GenesisChapterManager) null;
      }
    }

    [Token(Token = "0x170016B3")]
    private GenesisChapterParam ChapterParam
    {
      [Token(Token = "0x600A233"), Address(RVA = "0x647D20", Offset = "0x646B20", VA = "0x10647D20")] get
      {
        return (GenesisChapterParam) null;
      }
    }

    [Token(Token = "0x170016B4")]
    private QuestDifficulties[] DifficultyList
    {
      [Token(Token = "0x600A234"), Address(RVA = "0x647DE0", Offset = "0x646BE0", VA = "0x10647DE0")] get
      {
        return (QuestDifficulties[]) null;
      }
    }

    [Token(Token = "0x600A235")]
    [Address(RVA = "0x645090", Offset = "0x643E90", VA = "0x10645090")]
    private List<QuestParam> GetDifficultyQuestList(QuestDifficulties difficulty)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x600A236")]
    [Address(RVA = "0x6451C0", Offset = "0x643FC0", VA = "0x106451C0")]
    private bool Init() => new bool();

    [Token(Token = "0x600A237")]
    [Address(RVA = "0x644D40", Offset = "0x643B40", VA = "0x10644D40")]
    private List<QuestDifficulties> GetAvailableDifficultyList() => (List<QuestDifficulties>) null;

    [Token(Token = "0x600A238")]
    [Address(RVA = "0x646300", Offset = "0x645100", VA = "0x10646300")]
    private bool Refresh() => new bool();

    [Token(Token = "0x600A239")]
    [Address(RVA = "0x645F90", Offset = "0x644D90", VA = "0x10645F90")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A23A")]
    [Address(RVA = "0x644710", Offset = "0x643510", VA = "0x10644710", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A23B")]
    [Address(RVA = "0x6477C0", Offset = "0x6465C0", VA = "0x106477C0")]
    private bool SetNextDifficulty() => new bool();

    [Token(Token = "0x600A23C")]
    [Address(RVA = "0x646010", Offset = "0x644E10", VA = "0x10646010")]
    private void RefreshDifficultyButton()
    {
    }

    [Token(Token = "0x600A23D")]
    [Address(RVA = "0x644D20", Offset = "0x643B20", VA = "0x10644D20")]
    private void FinishLoad()
    {
    }

    [Token(Token = "0x600A23E")]
    [Address(RVA = "0x644A90", Offset = "0x643890", VA = "0x10644A90")]
    private void DownLoadedBG(GameObject bg_prefab)
    {
    }

    [Token(Token = "0x600A23F")]
    [Address(RVA = "0x644C60", Offset = "0x643A60", VA = "0x10644C60")]
    private void DownLoadedPreview(GameObject preview_prefab)
    {
    }

    [Token(Token = "0x600A240")]
    [Address(RVA = "0x647920", Offset = "0x646720", VA = "0x10647920")]
    private void SetSelectedQuest(GenesisQuestMapIcon icon, QuestDifficulties difficulty)
    {
    }

    [Token(Token = "0x600A241")]
    [Address(RVA = "0x645E80", Offset = "0x644C80", VA = "0x10645E80")]
    private void OnClickSymbolIcon(GenesisQuestMapIcon icon, QuestParam param)
    {
    }

    [Token(Token = "0x600A242")]
    [Address(RVA = "0x645510", Offset = "0x644310", VA = "0x10645510")]
    private void OnClickLockedIcon(GenesisQuestMapIcon icon)
    {
    }

    [Token(Token = "0x600A243")]
    [Address(RVA = "0x6475E0", Offset = "0x6463E0", VA = "0x106475E0")]
    private void ScrollTo(GenesisQuestMapIcon icon)
    {
    }

    [Token(Token = "0x600A244")]
    [Address(RVA = "0x647730", Offset = "0x646530", VA = "0x10647730")]
    private IEnumerator ScrollTo(
      Transform target_transform,
      SRPG_ScrollRect scroll_rect,
      AnimationCurve curve,
      float scroll_time)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600A245")]
    [Address(RVA = "0x645CF0", Offset = "0x644AF0", VA = "0x10645CF0")]
    private void OnClickStarRewardIcon(GameObject icon)
    {
    }

    [Token(Token = "0x600A246")]
    [Address(RVA = "0x645710", Offset = "0x644510", VA = "0x10645710")]
    private void OnClickStarRewardAllReceive()
    {
    }

    [Token(Token = "0x600A247")]
    [Address(RVA = "0x645320", Offset = "0x644120", VA = "0x10645320")]
    private bool IsAvailableDifficulty(QuestDifficulties difficulty) => new bool();

    [Token(Token = "0x600A248")]
    [Address(RVA = "0x644E40", Offset = "0x643C40", VA = "0x10644E40")]
    private int GetAvailableDifficultyNum() => new int();

    [Token(Token = "0x600A249")]
    [Address(RVA = "0x644ED0", Offset = "0x643CD0", VA = "0x10644ED0")]
    private List<QuestParam> GetAvailableQuest(QuestDifficulties difficulty)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x600A24A")]
    [Address(RVA = "0x647B60", Offset = "0x646960", VA = "0x10647B60")]
    public GenesisQuestEventMap()
    {
    }
  }
}
