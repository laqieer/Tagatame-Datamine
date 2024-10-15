// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceBossInfo
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
  [Token(Token = "0x2001F3E")]
  [FlowNode.Pin(2, "QuestDetail Open", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "挑戦click", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(101, "Initialized", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "挑戦", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "アーカイブ用開催期間外", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("UI/Advance/AdvanceBossInfo")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  public class AdvanceBossInfo : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x4008379")]
    public const int PIN_IN_INIT = 1;
    [Token(Token = "0x400837A")]
    public const int PIN_IN_QUEST_DETAIL_OPEN = 2;
    [Token(Token = "0x400837B")]
    public const int PIN_IN_CALLENGE = 3;
    [Token(Token = "0x400837C")]
    public const int PIN_OUT_INIT = 101;
    [Token(Token = "0x400837D")]
    public const int PIN_OUT_CALLENGE = 102;
    [Token(Token = "0x400837E")]
    public const int PIN_OUT_ARCHIVE_OUT_PERIOD = 103;
    [Token(Token = "0x400837F")]
    [FieldOffset(Offset = "0x0")]
    private static AdvanceBossInfo mInstance;
    [Token(Token = "0x4008380")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mBGParent;
    [Token(Token = "0x4008381")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject[] mTitle;
    [Token(Token = "0x4008382")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mChapterTitle;
    [Token(Token = "0x4008383")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Space(5f)]
    private GameObject mRewardBox;
    [Token(Token = "0x4008384")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mRwardItemName;
    [Token(Token = "0x4008385")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mRwardItemNum;
    [Token(Token = "0x4008386")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform mRewardIconParent;
    [Token(Token = "0x4008387")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private AdvanceRewardIcon mRewardIcon;
    [Token(Token = "0x4008388")]
    [FieldOffset(Offset = "0x2C")]
    [Space(5f)]
    [SerializeField]
    private GameObject mTicketIcon;
    [Token(Token = "0x4008389")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mUseTicketNum;
    [Token(Token = "0x400838A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mHaveTicketNum;
    [Token(Token = "0x400838B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mChallengeButton;
    [Token(Token = "0x400838C")]
    [FieldOffset(Offset = "0x3C")]
    [Space(5f)]
    [SerializeField]
    private GameObject mGoCommonBoss;
    [Token(Token = "0x400838D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mGoLapBoss;
    [Token(Token = "0x400838E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mLapBossChapterTitle;
    [Token(Token = "0x400838F")]
    [FieldOffset(Offset = "0x48")]
    [Space(5f)]
    [SerializeField]
    private GameObject mGoLapBossReward;
    [Token(Token = "0x4008390")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mGoParentLapBossReward;
    [Token(Token = "0x4008391")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private AdvanceLapBossReward mTemplateLapBossReward;
    [Token(Token = "0x4008392")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    [Space(5f)]
    private GameObject mPrefabQuestDetail;
    [Token(Token = "0x4008394")]
    [FieldOffset(Offset = "0x5C")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x4008395")]
    [FieldOffset(Offset = "0x4")]
    public static AdvanceBossInfo.LapBossBattleInfo LapBossBattleData;

    [Token(Token = "0x17001251")]
    public static AdvanceBossInfo Instance
    {
      [Token(Token = "0x6007FF6"), Address(RVA = "0x408190", Offset = "0x406F90", VA = "0x10408190")] get
      {
        return (AdvanceBossInfo) null;
      }
    }

    [Token(Token = "0x17001252")]
    public int BossHP
    {
      [Token(Token = "0x6007FF7"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
      [Token(Token = "0x6007FF8"), Address(RVA = "0x374A60", Offset = "0x373860", VA = "0x10374A60")] private set
      {
      }
    }

    [Token(Token = "0x6007FF9")]
    [Address(RVA = "0x406870", Offset = "0x405670", VA = "0x10406870")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007FFA")]
    [Address(RVA = "0x407300", Offset = "0x406100", VA = "0x10407300")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6007FFB")]
    [Address(RVA = "0x406670", Offset = "0x405470", VA = "0x10406670", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6007FFC")]
    [Address(RVA = "0x407810", Offset = "0x406610", VA = "0x10407810")]
    public void SetBossInfo(int hp, int round)
    {
    }

    [Token(Token = "0x6007FFD")]
    [Address(RVA = "0x406B60", Offset = "0x405960", VA = "0x10406B60")]
    private bool Init() => new bool();

    [Token(Token = "0x6007FFE")]
    [Address(RVA = "0x4071D0", Offset = "0x405FD0", VA = "0x104071D0")]
    private bool IstArchiveOpen() => new bool();

    [Token(Token = "0x6007FFF")]
    [Address(RVA = "0x408120", Offset = "0x406F20", VA = "0x10408120")]
    private IEnumerator UpdateTicketNum() => (IEnumerator) null;

    [Token(Token = "0x6008000")]
    [Address(RVA = "0x4068B0", Offset = "0x4056B0", VA = "0x104068B0")]
    private void Downloaded(GameObject prefab)
    {
    }

    [Token(Token = "0x6008001")]
    [Address(RVA = "0x406A30", Offset = "0x405830", VA = "0x10406A30", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x6008002")]
    [Address(RVA = "0x407340", Offset = "0x406140", VA = "0x10407340")]
    private void OpenQuestDetail()
    {
    }

    [Token(Token = "0x6008003")]
    [Address(RVA = "0x4079A0", Offset = "0x4067A0", VA = "0x104079A0")]
    private void SetupReward(AdvanceEventParam aeParam, AdvanceEventModeInfoParam aemiParam)
    {
    }

    [Token(Token = "0x6008004")]
    [Address(RVA = "0x407680", Offset = "0x406480", VA = "0x10407680")]
    private bool SetBossBattleInfo(int round) => new bool();

    [Token(Token = "0x6008005")]
    [Address(RVA = "0x407100", Offset = "0x405F00", VA = "0x10407100")]
    public static bool IsLapBossQuest(QuestParam quest) => new bool();

    [Token(Token = "0x6008006")]
    [Address(RVA = "0x4074E0", Offset = "0x4062E0", VA = "0x104074E0")]
    public static bool SetBossBattleInfo(QuestParam quest, int round) => new bool();

    [Token(Token = "0x6008007")]
    [Address(RVA = "0x406960", Offset = "0x405760", VA = "0x10406960")]
    public static bool GetBossChallengeItemInfo(
      ref ItemParam ch_item_param,
      ref int ch_item_need_num)
    {
      return new bool();
    }

    [Token(Token = "0x6008008")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceBossInfo()
    {
    }

    [Token(Token = "0x2001F3F")]
    public class AdvanceBossData
    {
      [Token(Token = "0x4008396")]
      [FieldOffset(Offset = "0x8")]
      public UnitParam unit;
      [Token(Token = "0x4008397")]
      [FieldOffset(Offset = "0xC")]
      public int maxHP;
      [Token(Token = "0x4008398")]
      [FieldOffset(Offset = "0x10")]
      public int currentHP;

      [Token(Token = "0x6008009")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public AdvanceBossData()
      {
      }
    }

    [Token(Token = "0x2001F40")]
    public class LapBossBattleInfo
    {
      [Token(Token = "0x4008399")]
      [FieldOffset(Offset = "0x8")]
      public AdvanceLapBossParam LapBossParam;
      [Token(Token = "0x400839A")]
      [FieldOffset(Offset = "0xC")]
      public int Round;

      [Token(Token = "0x600800A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LapBossBattleInfo()
      {
      }
    }
  }
}
