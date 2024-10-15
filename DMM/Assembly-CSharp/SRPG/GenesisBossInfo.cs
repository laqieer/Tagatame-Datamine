// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisBossInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024DC")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Genesis/GenesisBossInfo")]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(2, "QuestDetail Open", FlowNode.PinTypes.Input, 2)]
  public class GenesisBossInfo : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400A848")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x400A849")]
    public const int PIN_IN_QUEST_DETAIL_OPEN = 2;
    [Token(Token = "0x400A84A")]
    public const int PIN_OUT_INIT = 101;
    [Token(Token = "0x400A84B")]
    [FieldOffset(Offset = "0x0")]
    private static GenesisBossInfo mInstance;
    [Token(Token = "0x400A84C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mBGParent;
    [Token(Token = "0x400A84D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject[] mTitle;
    [Token(Token = "0x400A84E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mChapterTitle;
    [Token(Token = "0x400A84F")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private GameObject mRewardBox;
    [Token(Token = "0x400A850")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mRwardItemName;
    [Token(Token = "0x400A851")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mRwardItemNum;
    [Token(Token = "0x400A852")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform mRewardIconParent;
    [Token(Token = "0x400A853")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GenesisRewardIcon mRewardIcon;
    [Token(Token = "0x400A854")]
    [FieldOffset(Offset = "0x2C")]
    [Space(5f)]
    [SerializeField]
    private GameObject mTicketIcon;
    [Token(Token = "0x400A855")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mUseTicketNum;
    [Token(Token = "0x400A856")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mHaveTicketNum;
    [Token(Token = "0x400A857")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mChallengeButton;
    [Token(Token = "0x400A858")]
    [FieldOffset(Offset = "0x3C")]
    [Space(5f)]
    [SerializeField]
    private GameObject mGoCommonBoss;
    [Token(Token = "0x400A859")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mGoLapBoss;
    [Token(Token = "0x400A85A")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mLapBossChapterTitle;
    [Token(Token = "0x400A85B")]
    [FieldOffset(Offset = "0x48")]
    [Space(5f)]
    [SerializeField]
    private GameObject mGoLapBossReward;
    [Token(Token = "0x400A85C")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mGoParentLapBossReward;
    [Token(Token = "0x400A85D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GenesisLapBossReward mTemplateLapBossReward;
    [Token(Token = "0x400A85E")]
    [FieldOffset(Offset = "0x54")]
    [Space(5f)]
    [SerializeField]
    private GameObject mPrefabQuestDetail;
    [Token(Token = "0x400A860")]
    [FieldOffset(Offset = "0x5C")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x400A861")]
    [FieldOffset(Offset = "0x4")]
    public static GenesisBossInfo.LapBossBattleInfo LapBossBattleData;

    [Token(Token = "0x17001698")]
    public static GenesisBossInfo Instance
    {
      [Token(Token = "0x600A1B7"), Address(RVA = "0x63A780", Offset = "0x639580", VA = "0x1063A780")] get
      {
        return (GenesisBossInfo) null;
      }
    }

    [Token(Token = "0x17001699")]
    public int BossHP
    {
      [Token(Token = "0x600A1B8"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
      [Token(Token = "0x600A1B9"), Address(RVA = "0x374A60", Offset = "0x373860", VA = "0x10374A60")] private set
      {
      }
    }

    [Token(Token = "0x600A1BA")]
    [Address(RVA = "0x638FC0", Offset = "0x637DC0", VA = "0x10638FC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A1BB")]
    [Address(RVA = "0x639910", Offset = "0x638710", VA = "0x10639910")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A1BC")]
    [Address(RVA = "0x638F60", Offset = "0x637D60", VA = "0x10638F60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A1BD")]
    [Address(RVA = "0x639E20", Offset = "0x638C20", VA = "0x10639E20")]
    public void SetBossInfo(int hp, int round)
    {
    }

    [Token(Token = "0x600A1BE")]
    [Address(RVA = "0x6392A0", Offset = "0x6380A0", VA = "0x106392A0")]
    private bool Init() => new bool();

    [Token(Token = "0x600A1BF")]
    [Address(RVA = "0x63A710", Offset = "0x639510", VA = "0x1063A710")]
    private IEnumerator UpdateTicketNum() => (IEnumerator) null;

    [Token(Token = "0x600A1C0")]
    [Address(RVA = "0x639000", Offset = "0x637E00", VA = "0x10639000")]
    private void Downloaded(GameObject prefab)
    {
    }

    [Token(Token = "0x600A1C1")]
    [Address(RVA = "0x639180", Offset = "0x637F80", VA = "0x10639180", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600A1C2")]
    [Address(RVA = "0x639950", Offset = "0x638750", VA = "0x10639950")]
    private void OpenQuestDetail()
    {
    }

    [Token(Token = "0x600A1C3")]
    [Address(RVA = "0x639FB0", Offset = "0x638DB0", VA = "0x10639FB0")]
    private void SetupReward(GenesisChapterParam gcParam, GenesisChapterModeInfoParam gcmiParam)
    {
    }

    [Token(Token = "0x600A1C4")]
    [Address(RVA = "0x639AF0", Offset = "0x6388F0", VA = "0x10639AF0")]
    private bool SetBossBattleInfo(int round) => new bool();

    [Token(Token = "0x600A1C5")]
    [Address(RVA = "0x639840", Offset = "0x638640", VA = "0x10639840")]
    public static bool IsLapBossQuest(QuestParam quest) => new bool();

    [Token(Token = "0x600A1C6")]
    [Address(RVA = "0x639C80", Offset = "0x638A80", VA = "0x10639C80")]
    public static bool SetBossBattleInfo(QuestParam quest, int round) => new bool();

    [Token(Token = "0x600A1C7")]
    [Address(RVA = "0x6390B0", Offset = "0x637EB0", VA = "0x106390B0")]
    public static bool GetBossChallengeItemInfo(
      ref ItemParam ch_item_param,
      ref int ch_item_need_num)
    {
      return new bool();
    }

    [Token(Token = "0x600A1C8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisBossInfo()
    {
    }

    [Token(Token = "0x20024DD")]
    public class GenesisBossData
    {
      [Token(Token = "0x400A862")]
      [FieldOffset(Offset = "0x8")]
      public UnitParam unit;
      [Token(Token = "0x400A863")]
      [FieldOffset(Offset = "0xC")]
      public int maxHP;
      [Token(Token = "0x400A864")]
      [FieldOffset(Offset = "0x10")]
      public int currentHP;

      [Token(Token = "0x600A1C9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public GenesisBossData()
      {
      }
    }

    [Token(Token = "0x20024DE")]
    public class LapBossBattleInfo
    {
      [Token(Token = "0x400A865")]
      [FieldOffset(Offset = "0x8")]
      public GenesisLapBossParam LapBossParam;
      [Token(Token = "0x400A866")]
      [FieldOffset(Offset = "0xC")]
      public int Round;

      [Token(Token = "0x600A1CA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LapBossBattleInfo()
      {
      }
    }
  }
}
