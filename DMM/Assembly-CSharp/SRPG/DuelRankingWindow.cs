// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200232A")]
  [FlowNode.Pin(102, "ランキングユーザーの詳細を開く", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "入力制限", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("UI/Duel/DuelRankingWindow")]
  [FlowNode.Pin(101, "ランキング情報取得", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(104, "入力制限解放", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(3, "ウィークリーランキング表示", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "デイリーランキング", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "ランキング表示更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(4, "前回のランキング表示", FlowNode.PinTypes.Input, 4)]
  public class DuelRankingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009D1E")]
    private const int PIN_INPUT_RANKING_UPDATE = 1;
    [Token(Token = "0x4009D1F")]
    private const int PIN_INPUT_SELECT_TAB_1 = 2;
    [Token(Token = "0x4009D20")]
    private const int PIN_INPUT_SELECT_TAB_2 = 3;
    [Token(Token = "0x4009D21")]
    private const int PIN_INPUT_SELECT_TAB_3 = 4;
    [Token(Token = "0x4009D22")]
    private const int PIN_OUTPUT_REQUEST_RANKING = 101;
    [Token(Token = "0x4009D23")]
    private const int PIN_OUTPUT_RANKING_USER_DETAIL = 102;
    [Token(Token = "0x4009D24")]
    private const int PIN_OUTPUT_INPUT_LIMITATION = 103;
    [Token(Token = "0x4009D25")]
    private const int PIN_OUTPUT_INPUT_RELEASE = 104;
    [Token(Token = "0x4009D26")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private DuelRankingContentNode mRankingTemplete;
    [Token(Token = "0x4009D27")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private DuelRankingContentNode mRankingPlayer;
    [Token(Token = "0x4009D28")]
    [FieldOffset(Offset = "0x0")]
    private static DuelRankingWindow mInstance;
    [Token(Token = "0x4009D29")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x4009D2A")]
    [FieldOffset(Offset = "0x18")]
    private List<DuelRankingParam> mDuelRankingParam;
    [Token(Token = "0x4009D2B")]
    [FieldOffset(Offset = "0x1C")]
    private Vector2 mAnchorPosition;
    [Token(Token = "0x4009D2C")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsInitialized;
    [Token(Token = "0x4009D2D")]
    [FieldOffset(Offset = "0x28")]
    private DuelRankingWindow.ETabType mSelectTab;
    [Token(Token = "0x4009D2E")]
    [FieldOffset(Offset = "0x2C")]
    private bool mIsRankingUpdate;
    [Token(Token = "0x4009D2F")]
    [FieldOffset(Offset = "0x2D")]
    private bool mIsScrollPosRest;
    [Token(Token = "0x4009D30")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<DuelRankingWindow.ETabType, int> mTotlaPage;
    [Token(Token = "0x4009D31")]
    [FieldOffset(Offset = "0x34")]
    private Dictionary<DuelRankingWindow.ETabType, int> mNowPage;
    [Token(Token = "0x4009D32")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<DuelRankingWindow.ETabType, List<DuelPlayerData>> mRankingDatas;
    [Token(Token = "0x4009D33")]
    [FieldOffset(Offset = "0x3C")]
    private Dictionary<DuelRankingWindow.ETabType, DuelPlayerData> mMyRankingData;

    [Token(Token = "0x17001531")]
    public static DuelRankingWindow Instance
    {
      [Token(Token = "0x600974F"), Address(RVA = "0x59E140", Offset = "0x59CF40", VA = "0x1059E140")] get
      {
        return (DuelRankingWindow) null;
      }
    }

    [Token(Token = "0x6009750")]
    [Address(RVA = "0x59D090", Offset = "0x59BE90", VA = "0x1059D090")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009751")]
    [Address(RVA = "0x59D960", Offset = "0x59C760", VA = "0x1059D960")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009752")]
    [Address(RVA = "0x59DD00", Offset = "0x59CB00", VA = "0x1059DD00")]
    private void Update()
    {
    }

    [Token(Token = "0x6009753")]
    [Address(RVA = "0x59D020", Offset = "0x59BE20", VA = "0x1059D020", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009754")]
    [Address(RVA = "0x59DC40", Offset = "0x59CA40", VA = "0x1059DC40")]
    private void SetViewRanking(DuelRankingWindow.ETabType select_tab)
    {
    }

    [Token(Token = "0x6009755")]
    [Address(RVA = "0x59D110", Offset = "0x59BF10", VA = "0x1059D110")]
    private void CreateRanking()
    {
    }

    [Token(Token = "0x6009756")]
    [Address(RVA = "0x59D8F0", Offset = "0x59C6F0", VA = "0x1059D8F0")]
    public void OnClickOpenDetail(DuelPlayerData enemy)
    {
    }

    [Token(Token = "0x6009757")]
    [Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")]
    public int GetNowSelectTab() => new int();

    [Token(Token = "0x6009758")]
    [Address(RVA = "0x59D890", Offset = "0x59C690", VA = "0x1059D890")]
    public int GetNowRankingPage() => new int();

    [Token(Token = "0x6009759")]
    [Address(RVA = "0x59D8E0", Offset = "0x59C6E0", VA = "0x1059D8E0")]
    public bool IsSelectTabPreview() => new bool();

    [Token(Token = "0x600975A")]
    [Address(RVA = "0x59D9A0", Offset = "0x59C7A0", VA = "0x1059D9A0")]
    public void SetRankingData(ReqDuelRanking.Response req_datas)
    {
    }

    [Token(Token = "0x600975B")]
    [Address(RVA = "0x59DE40", Offset = "0x59CC40", VA = "0x1059DE40")]
    public DuelRankingWindow()
    {
    }

    [Token(Token = "0x200232B")]
    private enum ETabType
    {
      [Token(Token = "0x4009D35")] TOTAL_RANKING,
      [Token(Token = "0x4009D36")] PRE_RANKING,
      [Token(Token = "0x4009D37")] DAILY_RANKING,
    }
  }
}
