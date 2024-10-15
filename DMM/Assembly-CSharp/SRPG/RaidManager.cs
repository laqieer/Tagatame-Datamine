// Decompiled with JetBrains decompiler
// Type: SRPG.RaidManager
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
  [Token(Token = "0x20028E1")]
  [FlowNode.Pin(11, "Start Challenge", FlowNode.PinTypes.Input, 11)]
  [AddComponentMenu("UI/Raid/RaidManager")]
  [FlowNode.Pin(12, "Selected Raid", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(302, "Raid Stage Info", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(311, "Selected", FlowNode.PinTypes.Output, 311)]
  [FlowNode.Pin(303, "Area Clear Reward", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(13, "Selected List", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(14, "Selected Rescue", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(201, "Finish Initialize", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(301, "Select Raid", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(901, "Error", FlowNode.PinTypes.Output, 901)]
  public class RaidManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C45D")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C45E")]
    public const int PIN_INPUT_CHALLENGE = 11;
    [Token(Token = "0x400C45F")]
    public const int PIN_INPUT_SELECTED = 12;
    [Token(Token = "0x400C460")]
    public const int PIN_INPUT_SELECTED_LIST = 13;
    [Token(Token = "0x400C461")]
    public const int PIN_INPUT_SELECTED_RESCUE = 14;
    [Token(Token = "0x400C462")]
    public const int PIN_OUTPUT_FINISH_INIT = 201;
    [Token(Token = "0x400C463")]
    public const int PIN_OUTPUT_SELECT_RAID = 301;
    [Token(Token = "0x400C464")]
    public const int PIN_OUTPUT_TO_DETAIL = 302;
    [Token(Token = "0x400C465")]
    public const int PIN_OUTPUT_AREA_CLEAR_REWARD = 303;
    [Token(Token = "0x400C466")]
    public const int PIN_OUTPUT_SELECTED = 311;
    [Token(Token = "0x400C467")]
    public const int PIN_OUTPUT_ERROR = 901;
    [Token(Token = "0x400C468")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mAreaTransform;
    [Token(Token = "0x400C469")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RaidArea mRaidAreaPrefab;
    [Token(Token = "0x400C46A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mPeriodParent;
    [Token(Token = "0x400C46B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mPeriodTitle;
    [Token(Token = "0x400C46C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mPeriodText;
    [Token(Token = "0x400C46D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mPeriodPeriodTimeParent;
    [Token(Token = "0x400C46E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mPeriodTimeTitle;
    [Token(Token = "0x400C46F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mPeriodTimeText;
    [Token(Token = "0x400C470")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mPeriodReceiveParent;
    [Token(Token = "0x400C471")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mPeriodReceiveText;
    [Token(Token = "0x400C472")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mRoundText;
    [Token(Token = "0x400C473")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mRescueListButton;
    [Token(Token = "0x400C474")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mRescueDetailButton;
    [Token(Token = "0x400C475")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mBPParent;
    [Token(Token = "0x400C476")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private List<GameObject> mBPList;
    [Token(Token = "0x400C477")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mBPCoolDownGO;
    [Token(Token = "0x400C478")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mBPCoolDownText;
    [Token(Token = "0x400C479")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mChallengeBadge;
    [Token(Token = "0x400C47A")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mRescueBadge;
    [Token(Token = "0x400C47B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject mCompleteBadge;
    [Token(Token = "0x400C47C")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject mChallengeButton;
    [Token(Token = "0x400C47D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject mNextAreaButton;
    [Token(Token = "0x400C47E")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject mResetButton;
    [Token(Token = "0x400C47F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject mCheckButton;
    [Token(Token = "0x400C480")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject mRescueButton;
    [Token(Token = "0x400C481")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject mScheduleCloseButton;
    [Token(Token = "0x400C482")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private GameObject mTimeScheduleButton;
    [Token(Token = "0x400C483")]
    [FieldOffset(Offset = "0x0")]
    private static RaidManager mInstance;
    [Token(Token = "0x400C486")]
    [FieldOffset(Offset = "0x7C")]
    private int mRaidPeriodId;
    [Token(Token = "0x400C487")]
    [FieldOffset(Offset = "0x80")]
    private int mCurrentRound;
    [Token(Token = "0x400C488")]
    [FieldOffset(Offset = "0x84")]
    private int mCurrentRaidAreaId;
    [Token(Token = "0x400C489")]
    [FieldOffset(Offset = "0x88")]
    private bool mIsAreaReward;
    [Token(Token = "0x400C48A")]
    [FieldOffset(Offset = "0x89")]
    private bool mIsRaidCompleteReward;
    [Token(Token = "0x400C48B")]
    [FieldOffset(Offset = "0x8C")]
    private RaidBP mRaidBP;
    [Token(Token = "0x400C48C")]
    [FieldOffset(Offset = "0x90")]
    private RaidArea mCurrentRaidArea;
    [Token(Token = "0x400C48D")]
    [FieldOffset(Offset = "0x94")]
    private RaidBossData mCurrentRaidBossData;
    [Token(Token = "0x400C48E")]
    [FieldOffset(Offset = "0x98")]
    private RaidBossData mRescueRaidBossData;
    [Token(Token = "0x400C48F")]
    [FieldOffset(Offset = "0x9C")]
    private List<RaidBossInfo> mBeatedRaidBossList;
    [Token(Token = "0x400C490")]
    [FieldOffset(Offset = "0xA0")]
    private List<RaidRescueMember> mRaidRescueMemberList;
    [Token(Token = "0x400C491")]
    [FieldOffset(Offset = "0xA4")]
    private int mSelectedRaidRescueIndex;
    [Token(Token = "0x400C492")]
    [FieldOffset(Offset = "0xA8")]
    private RaidManager.RaidOwnerType mSelectedRaidOwnerType;
    [Token(Token = "0x400C493")]
    [FieldOffset(Offset = "0xAC")]
    private List<RaidRewardData> mRaidRewards;
    [Token(Token = "0x400C494")]
    [FieldOffset(Offset = "0xB0")]
    private List<RuneData> mRuneRewardDatas;
    [Token(Token = "0x400C495")]
    [FieldOffset(Offset = "0xB4")]
    private Json_Disassemble[] mRuneDisassembleList;
    [Token(Token = "0x400C496")]
    [FieldOffset(Offset = "0xB8")]
    private RaidBossInfo mSelectedClearedRaidBossInfo;
    [Token(Token = "0x400C497")]
    [FieldOffset(Offset = "0xBC")]
    private RaidBossData mSelectedClearedRaidBossData;
    [Token(Token = "0x400C498")]
    [FieldOffset(Offset = "0xC0")]
    private int mAreaClearAnnounceSkipCount;
    [Token(Token = "0x400C499")]
    [FieldOffset(Offset = "0xC8")]
    private DateTime mPeriodEndAt;
    [Token(Token = "0x400C49A")]
    [FieldOffset(Offset = "0xD0")]
    private int mRescueListRefreshWaitSeconds;
    [Token(Token = "0x400C49B")]
    [FieldOffset(Offset = "0xD8")]
    private DateTime mRescueListRefreshWaitStarted;
    [Token(Token = "0x400C49E")]
    private const int MULTITIMESET = 2;
    [Token(Token = "0x400C49F")]
    private const int TIME_SCHEDULEBASE = 0;
    [Token(Token = "0x400C4A0")]
    public const int DAY_HOUR = 24;
    [Token(Token = "0x400C4A1")]
    private const int SCHEDULE_DEFAULT = 0;

    [Token(Token = "0x17001940")]
    public static RaidManager Instance
    {
      [Token(Token = "0x600B8D6"), Address(RVA = "0x800E00", Offset = "0x7FFC00", VA = "0x10800E00")] get
      {
        return (RaidManager) null;
      }
    }

    [Token(Token = "0x17001941")]
    public int RaidPeriodId
    {
      [Token(Token = "0x600B8D7"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001942")]
    public int CurrentRound
    {
      [Token(Token = "0x600B8D8"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001943")]
    public int CurrentRaidAreaId
    {
      [Token(Token = "0x600B8D9"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001944")]
    public RaidBossData CurrentRaidBossData
    {
      [Token(Token = "0x600B8DA"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (RaidBossData) null;
      }
    }

    [Token(Token = "0x17001945")]
    public RaidBossData RescueRaidBossData
    {
      [Token(Token = "0x600B8DB"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (RaidBossData) null;
      }
    }

    [Token(Token = "0x17001946")]
    public List<RaidBossInfo> BeatedRaidBossList
    {
      [Token(Token = "0x600B8DC"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return (List<RaidBossInfo>) null;
      }
    }

    [Token(Token = "0x17001947")]
    public RaidManager.RaidOwnerType SelectedRaidOwnerType
    {
      [Token(Token = "0x600B8DD"), Address(RVA = "0x4601C0", Offset = "0x45EFC0", VA = "0x104601C0")] get
      {
        return new RaidManager.RaidOwnerType();
      }
    }

    [Token(Token = "0x17001948")]
    public List<RaidRescueMember> RaidRescueMemberList
    {
      [Token(Token = "0x600B8DE"), Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")] get
      {
        return (List<RaidRescueMember>) null;
      }
    }

    [Token(Token = "0x17001949")]
    public RaidRescueMember SelectedRaidRescueMember
    {
      [Token(Token = "0x600B8DF"), Address(RVA = "0x800FA0", Offset = "0x7FFDA0", VA = "0x10800FA0")] get
      {
        return (RaidRescueMember) null;
      }
    }

    [Token(Token = "0x1700194A")]
    public int RaidBp
    {
      [Token(Token = "0x600B8E0"), Address(RVA = "0x800E30", Offset = "0x7FFC30", VA = "0x10800E30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700194B")]
    public RaidBossInfo SelectedClearedRaidBossInfo
    {
      [Token(Token = "0x600B8E1"), Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")] get
      {
        return (RaidBossInfo) null;
      }
    }

    [Token(Token = "0x1700194C")]
    public RaidBossData SelectedClearedRaidBossData
    {
      [Token(Token = "0x600B8E2"), Address(RVA = "0x36AA10", Offset = "0x369810", VA = "0x1036AA10")] get
      {
        return (RaidBossData) null;
      }
    }

    [Token(Token = "0x1700194D")]
    public bool RescueListIsRefreshable
    {
      [Token(Token = "0x600B8E3"), Address(RVA = "0x800E50", Offset = "0x7FFC50", VA = "0x10800E50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700194E")]
    public bool RescueReqOptionGuild
    {
      [Token(Token = "0x600B8E4"), Address(RVA = "0x2B5E80", Offset = "0x2B4C80", VA = "0x102B5E80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B8E5"), Address(RVA = "0x2B60E0", Offset = "0x2B4EE0", VA = "0x102B60E0")] set
      {
      }
    }

    [Token(Token = "0x1700194F")]
    public bool RescueReqOptionFriend
    {
      [Token(Token = "0x600B8E6"), Address(RVA = "0x2C9960", Offset = "0x2C8760", VA = "0x102C9960")] get
      {
        return new bool();
      }
      [Token(Token = "0x600B8E7"), Address(RVA = "0x2C99A0", Offset = "0x2C87A0", VA = "0x102C99A0")] set
      {
      }
    }

    [Token(Token = "0x17001950")]
    public Json_Disassemble[] RuneDisassembleList
    {
      [Token(Token = "0x600B8E8"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return (Json_Disassemble[]) null;
      }
    }

    [Token(Token = "0x17001951")]
    public static RaidManager.RaidOwnerType SelectedLastRaidOwnerType
    {
      [Token(Token = "0x600B8E9"), Address(RVA = "0x800F40", Offset = "0x7FFD40", VA = "0x10800F40")] get
      {
        return new RaidManager.RaidOwnerType();
      }
      [Token(Token = "0x600B8EA"), Address(RVA = "0x801010", Offset = "0x7FFE10", VA = "0x10801010")] set
      {
      }
    }

    [Token(Token = "0x17001952")]
    public static RaidRescueMemberType SelectedLastRaidRescueMemberType
    {
      [Token(Token = "0x600B8EB"), Address(RVA = "0x800F70", Offset = "0x7FFD70", VA = "0x10800F70")] get
      {
        return new RaidRescueMemberType();
      }
      [Token(Token = "0x600B8EC"), Address(RVA = "0x801040", Offset = "0x7FFE40", VA = "0x10801040")] set
      {
      }
    }

    [Token(Token = "0x600B8ED")]
    [Address(RVA = "0x7FC450", Offset = "0x7FB250", VA = "0x107FC450")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B8EE")]
    [Address(RVA = "0x7FE430", Offset = "0x7FD230", VA = "0x107FE430")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B8EF")]
    [Address(RVA = "0x800AF0", Offset = "0x7FF8F0", VA = "0x10800AF0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B8F0")]
    [Address(RVA = "0x7FC3A0", Offset = "0x7FB1A0", VA = "0x107FC3A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B8F1")]
    [Address(RVA = "0x7FD7C0", Offset = "0x7FC5C0", VA = "0x107FD7C0")]
    private void Init()
    {
    }

    [Token(Token = "0x600B8F2")]
    [Address(RVA = "0x800CD0", Offset = "0x7FFAD0", VA = "0x10800CD0")]
    private IEnumerator WaitLoadArea() => (IEnumerator) null;

    [Token(Token = "0x600B8F3")]
    [Address(RVA = "0x8000E0", Offset = "0x7FEEE0", VA = "0x108000E0")]
    public void StartChallenge()
    {
    }

    [Token(Token = "0x600B8F4")]
    [Address(RVA = "0x7FE470", Offset = "0x7FD270", VA = "0x107FE470")]
    public void SelectedBoss()
    {
    }

    [Token(Token = "0x600B8F5")]
    [Address(RVA = "0x800190", Offset = "0x7FEF90", VA = "0x10800190")]
    private void SwitchRaidArea(int area_index)
    {
    }

    [Token(Token = "0x600B8F6")]
    [Address(RVA = "0x6855C0", Offset = "0x6843C0", VA = "0x106855C0")]
    public void SetRescueIndex(int index)
    {
    }

    [Token(Token = "0x600B8F7")]
    [Address(RVA = "0x7FD350", Offset = "0x7FC150", VA = "0x107FD350")]
    public RaidRewardData GetRaidRewards() => (RaidRewardData) null;

    [Token(Token = "0x600B8F8")]
    [Address(RVA = "0x7FD780", Offset = "0x7FC580", VA = "0x107FD780")]
    public bool HasRaidRewards() => new bool();

    [Token(Token = "0x600B8F9")]
    [Address(RVA = "0x7FC540", Offset = "0x7FB340", VA = "0x107FC540")]
    public RuneData CheckAutoRunedisassemble(GiftData gift) => (RuneData) null;

    [Token(Token = "0x600B8FA")]
    [Address(RVA = "0x7FC6C0", Offset = "0x7FB4C0", VA = "0x107FC6C0")]
    public void ClearRuneDisassembleList()
    {
    }

    [Token(Token = "0x600B8FB")]
    [Address(RVA = "0x7FC890", Offset = "0x7FB690", VA = "0x107FC890")]
    public void GeActiveRaidPeriodTimeString(out string title, out string timeCount)
    {
    }

    [Token(Token = "0x600B8FC")]
    [Address(RVA = "0x7FD480", Offset = "0x7FC280", VA = "0x107FD480")]
    public RaidBossData GetSelectedRaidBoss() => (RaidBossData) null;

    [Token(Token = "0x600B8FD")]
    [Address(RVA = "0x7FC440", Offset = "0x7FB240", VA = "0x107FC440")]
    public void AddAnnounceSkipCount()
    {
    }

    [Token(Token = "0x600B8FE")]
    [Address(RVA = "0x7FD3E0", Offset = "0x7FC1E0", VA = "0x107FD3E0")]
    public List<RaidSOSMember> GetSOSMembers() => (List<RaidSOSMember>) null;

    [Token(Token = "0x600B8FF")]
    [Address(RVA = "0x8000A0", Offset = "0x7FEEA0", VA = "0x108000A0")]
    public void ShowDetail(RaidBossInfo info)
    {
    }

    [Token(Token = "0x600B900")]
    [Address(RVA = "0x8002C0", Offset = "0x7FF0C0", VA = "0x108002C0")]
    public void UpdateBP()
    {
    }

    [Token(Token = "0x600B901")]
    [Address(RVA = "0x8007F0", Offset = "0x7FF5F0", VA = "0x108007F0")]
    public void UpdateReceivePeriod()
    {
    }

    [Token(Token = "0x600B902")]
    [Address(RVA = "0x8006A0", Offset = "0x7FF4A0", VA = "0x108006A0")]
    public void UpdatePeriodScheduleTime()
    {
    }

    [Token(Token = "0x600B903")]
    [Address(RVA = "0x8009C0", Offset = "0x7FF7C0", VA = "0x108009C0")]
    private void UpdateScheduleCloseButton()
    {
    }

    [Token(Token = "0x600B904")]
    [Address(RVA = "0x7FCF40", Offset = "0x7FBD40", VA = "0x107FCF40")]
    private List<DateTime> GetBeginScheduleTime() => (List<DateTime>) null;

    [Token(Token = "0x600B905")]
    [Address(RVA = "0x7FC6F0", Offset = "0x7FB4F0", VA = "0x107FC6F0")]
    private void CreateScheduleMessaageBox()
    {
    }

    [Token(Token = "0x600B906")]
    [Address(RVA = "0x7FE490", Offset = "0x7FD290", VA = "0x107FE490")]
    private string SetTimeScheduleList(DateTime beginTime, DateTime endTime, int addDay = 0)
    {
      return (string) null;
    }

    [Token(Token = "0x600B907")]
    [Address(RVA = "0x7FF8F0", Offset = "0x7FE6F0", VA = "0x107FF8F0")]
    public void Setup(ReqRaid.Response response)
    {
    }

    [Token(Token = "0x600B908")]
    [Address(RVA = "0x800010", Offset = "0x7FEE10", VA = "0x10800010")]
    public void Setup(ReqRaidSelect.Response response)
    {
    }

    [Token(Token = "0x600B909")]
    [Address(RVA = "0x7FFCD0", Offset = "0x7FEAD0", VA = "0x107FFCD0")]
    public void Setup(ReqRaidInfo.Response response)
    {
    }

    [Token(Token = "0x600B90A")]
    [Address(RVA = "0x7FEF70", Offset = "0x7FDD70", VA = "0x107FEF70")]
    public void Setup(ReqRaidRescue.Response response)
    {
    }

    [Token(Token = "0x600B90B")]
    [Address(RVA = "0x7FFDD0", Offset = "0x7FEBD0", VA = "0x107FFDD0")]
    public void Setup(ReqRaidRewardAreaClear.Response response)
    {
    }

    [Token(Token = "0x600B90C")]
    [Address(RVA = "0x7FF340", Offset = "0x7FE140", VA = "0x107FF340")]
    public void Setup(ReqRaidRewardBeat.Response response)
    {
    }

    [Token(Token = "0x600B90D")]
    [Address(RVA = "0x7FF0E0", Offset = "0x7FDEE0", VA = "0x107FF0E0")]
    public void Setup(ReqRaidRewardRescueComplete.Response response)
    {
    }

    [Token(Token = "0x600B90E")]
    [Address(RVA = "0x7FFC20", Offset = "0x7FEA20", VA = "0x107FFC20")]
    public void Setup(ReqRaidResetBp.Response response)
    {
    }

    [Token(Token = "0x600B90F")]
    [Address(RVA = "0x7FD4D0", Offset = "0x7FC2D0", VA = "0x107FD4D0")]
    public static TimeSpan GetTimeSpan(string time) => new TimeSpan();

    [Token(Token = "0x600B910")]
    [Address(RVA = "0x800D40", Offset = "0x7FFB40", VA = "0x10800D40")]
    public RaidManager()
    {
    }

    [Token(Token = "0x20028E2")]
    public enum RaidOwnerType
    {
      [Token(Token = "0x400C4A3")] Self,
      [Token(Token = "0x400C4A4")] Rescue,
      [Token(Token = "0x400C4A5")] Rescue_Temp,
      [Token(Token = "0x400C4A6")] Self_Cleared,
    }

    [Token(Token = "0x20028E3")]
    public enum RaidScheduleType
    {
      [Token(Token = "0x400C4A8")] Open,
      [Token(Token = "0x400C4A9")] Close,
      [Token(Token = "0x400C4AA")] OpenSchedule,
      [Token(Token = "0x400C4AB")] CloseSchedule,
    }
  }
}
