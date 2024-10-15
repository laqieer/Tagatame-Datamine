// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidRankingWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D72")]
  [FlowNode.Pin(102, "入力制限解除", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("UI/WorldRaid/WorldRaidRankingWindow")]
  [FlowNode.Pin(10, "ランキング情報初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "ランキング情報取得", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(13, "表示情報更新", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(11, "ダメージランキング表示", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "入力制限", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "ランキング報酬表示", FlowNode.PinTypes.Input, 12)]
  public class WorldRaidRankingWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E28A")]
    private const int PIN_INPUT_INIT_RANKING = 10;
    [Token(Token = "0x400E28B")]
    private const int PIN_INPUT_DAMAGE_RANKING = 11;
    [Token(Token = "0x400E28C")]
    private const int PIN_INPUT_RANKING_REWARD = 12;
    [Token(Token = "0x400E28D")]
    private const int PIN_INPUT_UPDATE_VIEW = 13;
    [Token(Token = "0x400E28E")]
    private const int PIN_OUTPUT_REQUEST_RANKING = 100;
    [Token(Token = "0x400E28F")]
    private const int PIN_OUTPUT_INPUT_LIMITATION = 101;
    [Token(Token = "0x400E290")]
    private const int PIN_OUTPUT_INPUT_RELEASE = 102;
    [Token(Token = "0x400E291")]
    private const string SVB_NAME_MASK_OBJ = "BossMask";
    [Token(Token = "0x400E292")]
    private const string SVB_NAME_SELECT_OBJ = "BossSelect";
    [Token(Token = "0x400E293")]
    private const string SVB_NAME_BOSS_SELECT_IMG = "BossSelectImg";
    [Token(Token = "0x400E294")]
    private const string SVB_NAME_BOSS_MASK_IMG = "BossMaskImg";
    [Token(Token = "0x400E295")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRankingTop;
    [Token(Token = "0x400E296")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRewardTop;
    [Token(Token = "0x400E297")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mWorldRaidRoot;
    [Token(Token = "0x400E298")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRewardRoot;
    [Token(Token = "0x400E299")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mBossDataTemplate;
    [Token(Token = "0x400E29A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private WorldRaidRankingContentNode mRankingDataTemplate;
    [Token(Token = "0x400E29B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private WorldRaidRewardContent mRewardDataTemplate;
    [Token(Token = "0x400E29C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private WorldRaidRankingContentNode mPlayerRankingData;
    [Token(Token = "0x400E29D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SRPG_ScrollRect mRewardScrollRect;
    [Token(Token = "0x400E29E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollablePulldown mLapPullDown;
    [Token(Token = "0x400E29F")]
    [FieldOffset(Offset = "0x0")]
    private static WorldRaidRankingWindow mInstance;
    [Token(Token = "0x400E2A0")]
    [FieldOffset(Offset = "0x34")]
    private List<WorldRaidRankingData> mWorldRaidRankings;
    [Token(Token = "0x400E2A1")]
    [FieldOffset(Offset = "0x38")]
    private WorldRaidRankingData mMyWorldRaidRanking;
    [Token(Token = "0x400E2A2")]
    [FieldOffset(Offset = "0x3C")]
    private int mTotalPage;
    [Token(Token = "0x400E2A3")]
    [FieldOffset(Offset = "0x40")]
    private WorldRaidBossParam mCurrentWorldRaidBossParam;
    [Token(Token = "0x400E2A4")]
    [FieldOffset(Offset = "0x44")]
    private int mSelectTab;
    [Token(Token = "0x400E2A5")]
    [FieldOffset(Offset = "0x48")]
    private string mViewWorldRaidBossId;
    [Token(Token = "0x400E2A6")]
    [FieldOffset(Offset = "0x4C")]
    private int mNowPage;
    [Token(Token = "0x400E2A7")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsRequestRankingAdd;
    [Token(Token = "0x400E2A8")]
    [FieldOffset(Offset = "0x54")]
    private List<WorldRaidRewardContent> mWorldRaidRewardContents;
    [Token(Token = "0x400E2A9")]
    [FieldOffset(Offset = "0x58")]
    private List<GameObject> mWorldRaidBossContents;
    [Token(Token = "0x400E2AA")]
    private const int InitLap = 1;
    [Token(Token = "0x400E2AB")]
    [FieldOffset(Offset = "0x5C")]
    private int mNowLap;
    [Token(Token = "0x400E2AC")]
    [FieldOffset(Offset = "0x60")]
    private int mCurrentLap;
    [Token(Token = "0x400E2AD")]
    [FieldOffset(Offset = "0x64")]
    private int mMaxLap;
    [Token(Token = "0x400E2AE")]
    private const int InitLastLap = -1;
    [Token(Token = "0x400E2AF")]
    [FieldOffset(Offset = "0x68")]
    private int mLastRankingLap;
    [Token(Token = "0x400E2B0")]
    [FieldOffset(Offset = "0x6C")]
    private int mLastRewardLap;
    [Token(Token = "0x400E2B1")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x400E2B2")]
    [FieldOffset(Offset = "0x74")]
    private List<WorldRaidRankingParam> mWorldRaidRankingParam;
    [Token(Token = "0x400E2B3")]
    [FieldOffset(Offset = "0x78")]
    private Vector2 mAnchorPosition;

    [Token(Token = "0x17001BBE")]
    public static WorldRaidRankingWindow Instance
    {
      [Token(Token = "0x600D3E2"), Address(RVA = "0x9EC380", Offset = "0x9EB180", VA = "0x109EC380")] get
      {
        return (WorldRaidRankingWindow) null;
      }
    }

    [Token(Token = "0x600D3E3")]
    [Address(RVA = "0x9E9CB0", Offset = "0x9E8AB0", VA = "0x109E9CB0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D3E4")]
    [Address(RVA = "0x9EB370", Offset = "0x9EA170", VA = "0x109EB370")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D3E5")]
    [Address(RVA = "0x9EC0D0", Offset = "0x9EAED0", VA = "0x109EC0D0")]
    private void Update()
    {
    }

    [Token(Token = "0x600D3E6")]
    [Address(RVA = "0x9E9BD0", Offset = "0x9E89D0", VA = "0x109E9BD0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D3E7")]
    [Address(RVA = "0x9EABA0", Offset = "0x9E99A0", VA = "0x109EABA0")]
    private void Init()
    {
    }

    [Token(Token = "0x600D3E8")]
    [Address(RVA = "0x9E9D50", Offset = "0x9E8B50", VA = "0x109E9D50")]
    private void BossSelect(WorldRaidBossParam select_boss, bool is_force = false)
    {
    }

    [Token(Token = "0x600D3E9")]
    [Address(RVA = "0x9EB2D0", Offset = "0x9EA0D0", VA = "0x109EB2D0")]
    private void LapSelect(int Lap, bool is_force = false)
    {
    }

    [Token(Token = "0x600D3EA")]
    [Address(RVA = "0x9EBF20", Offset = "0x9EAD20", VA = "0x109EBF20")]
    private void UpdateViewList(int _select_tab)
    {
    }

    [Token(Token = "0x600D3EB")]
    [Address(RVA = "0x9EA580", Offset = "0x9E9380", VA = "0x109EA580")]
    private void CreateRankingInfo()
    {
    }

    [Token(Token = "0x600D3EC")]
    [Address(RVA = "0x9EA120", Offset = "0x9E8F20", VA = "0x109EA120")]
    private void CreateDamageRanking()
    {
    }

    [Token(Token = "0x600D3ED")]
    [Address(RVA = "0x9EAB60", Offset = "0x9E9960", VA = "0x109EAB60")]
    public string GetTargetBossInfo() => (string) null;

    [Token(Token = "0x600D3EE")]
    [Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")]
    public int GetNowRankingPage() => new int();

    [Token(Token = "0x600D3EF")]
    [Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")]
    public int GetNowRankingLap() => new int();

    [Token(Token = "0x600D3F0")]
    [Address(RVA = "0x9EB7D0", Offset = "0x9EA5D0", VA = "0x109EB7D0")]
    public void SetRankingData(ReqWorldRaidRanking.Response worldraid_rankings)
    {
    }

    [Token(Token = "0x600D3F1")]
    [Address(RVA = "0x9EB900", Offset = "0x9EA700", VA = "0x109EB900")]
    public void SetRewardPullDownButton(int lap)
    {
    }

    [Token(Token = "0x600D3F2")]
    [Address(RVA = "0x9EB450", Offset = "0x9EA250", VA = "0x109EB450")]
    public void SetPullDownButton(int maxLap)
    {
    }

    [Token(Token = "0x600D3F3")]
    [Address(RVA = "0x9EAAF0", Offset = "0x9E98F0", VA = "0x109EAAF0")]
    public int GetPullDownLap() => new int();

    [Token(Token = "0x600D3F4")]
    [Address(RVA = "0x9EB750", Offset = "0x9EA550", VA = "0x109EB750")]
    public void SetPullDownLap(int value)
    {
    }

    [Token(Token = "0x600D3F5")]
    [Address(RVA = "0x9EB3B0", Offset = "0x9EA1B0", VA = "0x109EB3B0")]
    public void OnPullDownButton(int value)
    {
    }

    [Token(Token = "0x600D3F6")]
    [Address(RVA = "0x9EC1B0", Offset = "0x9EAFB0", VA = "0x109EC1B0")]
    public WorldRaidRankingWindow()
    {
    }
  }
}
