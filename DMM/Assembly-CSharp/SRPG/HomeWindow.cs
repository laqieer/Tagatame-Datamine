// Decompiled with JetBrains decompiler
// Type: SRPG.HomeWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002623")]
  [FlowNode.Pin(133, "To Scene[33]", FlowNode.PinTypes.Input, 133)]
  [FlowNode.Pin(132, "To Scene[32]", FlowNode.PinTypes.Input, 132)]
  [FlowNode.Pin(130, "To Scene[30]", FlowNode.PinTypes.Input, 130)]
  [FlowNode.Pin(116, "To Scene[16]", FlowNode.PinTypes.Input, 116)]
  [FlowNode.Pin(134, "To Scene[34]", FlowNode.PinTypes.Input, 134)]
  [FlowNode.Pin(105, "To Scene[5]", FlowNode.PinTypes.Input, 105)]
  [FlowNode.Pin(106, "To Scene[6]", FlowNode.PinTypes.Input, 106)]
  [FlowNode.Pin(135, "To Scene[35]", FlowNode.PinTypes.Input, 135)]
  [FlowNode.Pin(136, "To Scene[36]", FlowNode.PinTypes.Input, 136)]
  [FlowNode.Pin(137, "To Scene[37]", FlowNode.PinTypes.Input, 137)]
  [FlowNode.Pin(115, "To Scene[15]", FlowNode.PinTypes.Input, 115)]
  [FlowNode.Pin(131, "To Scene[31]", FlowNode.PinTypes.Input, 131)]
  [FlowNode.Pin(107, "To Scene[7]", FlowNode.PinTypes.Input, 107)]
  [FlowNode.Pin(108, "To Scene[8]", FlowNode.PinTypes.Input, 108)]
  [FlowNode.Pin(109, "To Scene[9]", FlowNode.PinTypes.Input, 109)]
  [FlowNode.Pin(119, "To Scene[19]", FlowNode.PinTypes.Input, 119)]
  [FlowNode.Pin(120, "To Scene[20]", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(117, "To Scene[17]", FlowNode.PinTypes.Input, 117)]
  [FlowNode.Pin(121, "To Scene[21]", FlowNode.PinTypes.Input, 121)]
  [FlowNode.Pin(122, "To Scene[22]", FlowNode.PinTypes.Input, 122)]
  [FlowNode.Pin(123, "To Scene[23]", FlowNode.PinTypes.Input, 123)]
  [FlowNode.Pin(10001, "HotDealFinished", FlowNode.PinTypes.Input, 10001)]
  [FlowNode.Pin(129, "To Scene[29]", FlowNode.PinTypes.Input, 129)]
  [FlowNode.Pin(111, "To Scene[11]", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(124, "To Scene[24]", FlowNode.PinTypes.Input, 124)]
  [FlowNode.Pin(125, "To Scene[25]", FlowNode.PinTypes.Input, 125)]
  [FlowNode.Pin(126, "To Scene[26]", FlowNode.PinTypes.Input, 126)]
  [FlowNode.Pin(127, "To Scene[27]", FlowNode.PinTypes.Input, 127)]
  [FlowNode.Pin(113, "To Scene[13]", FlowNode.PinTypes.Input, 113)]
  [FlowNode.Pin(114, "To Scene[14]", FlowNode.PinTypes.Input, 114)]
  [FlowNode.Pin(118, "To Scene[18]", FlowNode.PinTypes.Input, 118)]
  [FlowNode.Pin(128, "To Scene[28]", FlowNode.PinTypes.Input, 128)]
  [FlowNode.Pin(112, "To Scene[12]", FlowNode.PinTypes.Input, 112)]
  [FlowNode.Pin(110, "To Scene[10]", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(3002, "Go to Gacha Redraw", FlowNode.PinTypes.Output, 3002)]
  [FlowNode.Pin(139, "To Scene[39]", FlowNode.PinTypes.Input, 139)]
  [FlowNode.Pin(153, "To Scene[53]", FlowNode.PinTypes.Input, 153)]
  [FlowNode.Pin(1000, "Req Rank Match Reward", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(138, "To Scene[38]", FlowNode.PinTypes.Input, 138)]
  [FlowNode.Pin(1001, "Rank Match Rewarded", FlowNode.PinTypes.Input, 1001)]
  [FlowNode.Pin(2000, "Beginner Notify", FlowNode.PinTypes.Output, 2000)]
  [FlowNode.Pin(2001, "Beginner Notified", FlowNode.PinTypes.Input, 2001)]
  [FlowNode.Pin(3000, "Gacha Redraw Notify", FlowNode.PinTypes.Output, 3000)]
  [FlowNode.Pin(3001, "Gacha Redraw Notified", FlowNode.PinTypes.Input, 3001)]
  [FlowNode.Pin(15, "Home Enter", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(12, "FadeOut End", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "FadeOut Start", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(17, "Home Popup Completed", FlowNode.PinTypes.Output, 17)]
  [FlowNode.Pin(4000, "Req Raid Reward", FlowNode.PinTypes.Output, 4000)]
  [FlowNode.Pin(5000, "Req Unit Rental Check", FlowNode.PinTypes.Output, 5000)]
  [FlowNode.Pin(5001, "Unit Rental Checked", FlowNode.PinTypes.Input, 5001)]
  [FlowNode.Pin(6000, "Req GuildRaid Reward", FlowNode.PinTypes.Output, 6000)]
  [FlowNode.Pin(6001, "GuildRaid Rewarded", FlowNode.PinTypes.Input, 6001)]
  [FlowNode.Pin(10, "FadeIn Start", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(7000, "Req GuildTrophy", FlowNode.PinTypes.Output, 7000)]
  [FlowNode.Pin(7001, "GuildTrophy", FlowNode.PinTypes.Input, 7001)]
  [FlowNode.Pin(8000, "Req WorldRaid Reward", FlowNode.PinTypes.Output, 8000)]
  [FlowNode.Pin(9000, "Req CombatPowerQuestOpen", FlowNode.PinTypes.Output, 9000)]
  [FlowNode.Pin(9001, "CombatPowerQuestOpen", FlowNode.PinTypes.Input, 9001)]
  [FlowNode.Pin(10000, "Req HotDealStart", FlowNode.PinTypes.Output, 10000)]
  [FlowNode.Pin(4001, "Raid Rewarded", FlowNode.PinTypes.Input, 4001)]
  [FlowNode.Pin(30, "Restore", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(16, "Home Leave", FlowNode.PinTypes.Output, 16)]
  [FlowNode.Pin(40, "Reload", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(104, "To Scene[4]", FlowNode.PinTypes.Input, 104)]
  [FlowNode.Pin(103, "To Scene[3]", FlowNode.PinTypes.Input, 103)]
  [FlowNode.Pin(140, "To Scene[40]", FlowNode.PinTypes.Input, 140)]
  [FlowNode.Pin(141, "To Scene[41]", FlowNode.PinTypes.Input, 141)]
  [FlowNode.Pin(142, "To Scene[42]", FlowNode.PinTypes.Input, 142)]
  [FlowNode.Pin(143, "To Scene[43]", FlowNode.PinTypes.Input, 143)]
  [FlowNode.Pin(144, "To Scene[44]", FlowNode.PinTypes.Input, 144)]
  [FlowNode.Pin(145, "To Scene[45]", FlowNode.PinTypes.Input, 145)]
  [AddComponentMenu("UI/HomeWindow")]
  [FlowNode.Pin(146, "To Scene[46]", FlowNode.PinTypes.Input, 146)]
  [FlowNode.Pin(147, "To Scene[47]", FlowNode.PinTypes.Input, 147)]
  [FlowNode.Pin(148, "To Scene[48]", FlowNode.PinTypes.Input, 148)]
  [FlowNode.Pin(149, "To Scene[49]", FlowNode.PinTypes.Input, 149)]
  [FlowNode.Pin(100000, "Scene Change", FlowNode.PinTypes.Input, 100000)]
  [FlowNode.Pin(151, "To Scene[51]", FlowNode.PinTypes.Input, 151)]
  [FlowNode.Pin(99, "To Home", FlowNode.PinTypes.Input, 99)]
  [FlowNode.Pin(152, "To Scene[52]", FlowNode.PinTypes.Input, 152)]
  [FlowNode.Pin(102, "To Scene[2]", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(101, "To Scene[1]", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(150, "To Scene[50]", FlowNode.PinTypes.Input, 150)]
  [FlowNode.Pin(100, "To Scene[0]", FlowNode.PinTypes.Input, 100)]
  public class HomeWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B200")]
    [FieldOffset(Offset = "0x0")]
    public static HomeWindow mInstance;
    [Token(Token = "0x400B201")]
    public const int PINID_FADEIN_START = 10;
    [Token(Token = "0x400B202")]
    public const int PINID_FADEOUT_START = 11;
    [Token(Token = "0x400B203")]
    public const int PINID_FADEOUT_END = 12;
    [Token(Token = "0x400B204")]
    public const int PINID_HOME_ENTER = 15;
    [Token(Token = "0x400B205")]
    public const int PINID_HOME_LEAVE = 16;
    [Token(Token = "0x400B206")]
    public const int PINID_HOME_POPUP_COMPLETED = 17;
    [Token(Token = "0x400B207")]
    public const int PINID_SCENE_RESTORE = 30;
    [Token(Token = "0x400B208")]
    public const int PINID_RELOAD = 40;
    [Token(Token = "0x400B209")]
    public const int PINOUT_REQ_RANKMATCH_REWARD = 1000;
    [Token(Token = "0x400B20A")]
    public const int PININ_RANKMATCH_REWARDED = 1001;
    [Token(Token = "0x400B20B")]
    public const int PINOUT_BEGINNER_NOTIFY = 2000;
    [Token(Token = "0x400B20C")]
    public const int PININ_BEGINNER_NOTIFIED = 2001;
    [Token(Token = "0x400B20D")]
    public const int PINOUT_GACHAREDRAW_NOTIFY = 3000;
    [Token(Token = "0x400B20E")]
    public const int PININ_GACHAREDRAW_NOTIFIED = 3001;
    [Token(Token = "0x400B20F")]
    public const int PINOUT_GOTO_GACHAREDRAW = 3002;
    [Token(Token = "0x400B210")]
    public const int PINOUT_REQ_RAID_REWARD = 4000;
    [Token(Token = "0x400B211")]
    public const int PININ_RAID_REWARDED = 4001;
    [Token(Token = "0x400B212")]
    public const int PINOUT_RENTAL_UNIT_CHECK = 5000;
    [Token(Token = "0x400B213")]
    public const int PININ_RENTAL_UNIT_CHECKED = 5001;
    [Token(Token = "0x400B214")]
    public const int PINOUT_REQ_GUILDRAID_REWARD = 6000;
    [Token(Token = "0x400B215")]
    public const int PININ_GUILDRAID_REWARDED = 6001;
    [Token(Token = "0x400B216")]
    public const int PINOUT_REQ_GUILD_TROPHY = 7000;
    [Token(Token = "0x400B217")]
    public const int PININ_GUILD_TROPHY = 7001;
    [Token(Token = "0x400B218")]
    public const int PINOUT_REQ_WORLDRAID_REWARD = 8000;
    [Token(Token = "0x400B219")]
    public const int PINOUT_REQ_COMBATPOWER_QUEST_OPEN = 9000;
    [Token(Token = "0x400B21A")]
    public const int PININ_COMBATPOWER_QUEST_OPEN = 9001;
    [Token(Token = "0x400B21B")]
    public const int PINOUT_HOTDEAL_START = 10000;
    [Token(Token = "0x400B21C")]
    public const int PINOUT_HOTDEAL_FINISHED = 10001;
    [Token(Token = "0x400B21D")]
    public const int PININ_SCENE_CHANGE = 100000;
    [Token(Token = "0x400B21E")]
    public const string KEY_SCENE_CHANGE = "KEY_SCENE_CHANGE";
    [Token(Token = "0x400B21F")]
    [FieldOffset(Offset = "0xC")]
    private StateMachine<HomeWindow> mStateMachine;
    [Token(Token = "0x400B220")]
    [FieldOffset(Offset = "0x4")]
    private static RestorePoints mRestorePoint;
    [Token(Token = "0x400B221")]
    [FieldOffset(Offset = "0x8")]
    private static SerializeValueList mRestoreSceneValueList;
    [Token(Token = "0x400B222")]
    [FieldOffset(Offset = "0x10")]
    public string[] SceneNames;
    [Token(Token = "0x400B223")]
    [FieldOffset(Offset = "0x14")]
    public string[] IgnoreSameSceneCheck;
    [Token(Token = "0x400B224")]
    [FieldOffset(Offset = "0x18")]
    public string UnloadTrigger;
    [Token(Token = "0x400B225")]
    [FieldOffset(Offset = "0x1C")]
    public string DayChangeTrigger;
    [Token(Token = "0x400B226")]
    [FieldOffset(Offset = "0x20")]
    [StringIsResourcePath(typeof (GameObject))]
    public string NewsWindowPath;
    [Token(Token = "0x400B227")]
    [FieldOffset(Offset = "0x24")]
    [StringIsResourcePath(typeof (GameObject))]
    public string LoginBonusPath;
    [Token(Token = "0x400B228")]
    [FieldOffset(Offset = "0x28")]
    [StringIsResourcePath(typeof (GameObject))]
    public string LoginInfoPath;
    [Token(Token = "0x400B229")]
    [FieldOffset(Offset = "0x2C")]
    public bool DebugLoginBonus;
    [Token(Token = "0x400B22A")]
    [FieldOffset(Offset = "0x2D")]
    private bool mDesirdSceneSet;
    [Token(Token = "0x400B22B")]
    [FieldOffset(Offset = "0x2E")]
    private bool mCheckSceneChangeStatus;
    [Token(Token = "0x400B22C")]
    [FieldOffset(Offset = "0x2F")]
    private bool mFadingOut;
    [Token(Token = "0x400B22D")]
    [FieldOffset(Offset = "0x30")]
    private string mDesiredSceneName;
    [Token(Token = "0x400B22E")]
    [FieldOffset(Offset = "0x34")]
    private string mLastSceneName;
    [Token(Token = "0x400B22F")]
    [FieldOffset(Offset = "0x38")]
    private bool mDesiredSceneIsHome;
    [Token(Token = "0x400B230")]
    [FieldOffset(Offset = "0x39")]
    private bool mIgnorePopups;
    [Token(Token = "0x400B231")]
    [FieldOffset(Offset = "0x3C")]
    private float mSyncTrophyInterval;
    [Token(Token = "0x400B232")]
    [FieldOffset(Offset = "0x40")]
    private bool mRelogin;
    [Token(Token = "0x400B233")]
    [FieldOffset(Offset = "0x41")]
    private bool mReloginSuccess;
    [Token(Token = "0x400B234")]
    [FieldOffset(Offset = "0x42")]
    private bool mRankmatchRewarded;
    [Token(Token = "0x400B235")]
    [FieldOffset(Offset = "0x43")]
    private bool mRaidRewarded;
    [Token(Token = "0x400B236")]
    [FieldOffset(Offset = "0x44")]
    private bool mGuildRaidRewarded;
    [Token(Token = "0x400B237")]
    [FieldOffset(Offset = "0x45")]
    private bool mBeginnerNotified;
    [Token(Token = "0x400B238")]
    [FieldOffset(Offset = "0x46")]
    private bool mGachaRedrawNotified;
    [Token(Token = "0x400B239")]
    [FieldOffset(Offset = "0x47")]
    private bool mGuildTrophy;
    [Token(Token = "0x400B23A")]
    [FieldOffset(Offset = "0x48")]
    private bool mIsEndCombatPowerQuestOpen;
    [Token(Token = "0x400B23B")]
    [FieldOffset(Offset = "0x49")]
    private bool mIsEndHotDealOpen;
    [Token(Token = "0x400B23C")]
    [FieldOffset(Offset = "0x4A")]
    private bool mIsReqRentalUnitCheck;
    [Token(Token = "0x400B23D")]
    [FieldOffset(Offset = "0x4B")]
    private bool mRentalUnitChecked;
    [Token(Token = "0x400B23E")]
    [FieldOffset(Offset = "0x4C")]
    private SerializeValueList mSceneChangeValueList;
    [Token(Token = "0x400B23F")]
    [FieldOffset(Offset = "0x50")]
    private UnityWeakReference<GameObject> mCurrentSceneParentObject;
    [Token(Token = "0x400B240")]
    [FieldOffset(Offset = "0x54")]
    private bool mIsReqWorldRaidRewardCheck;
    [Token(Token = "0x400B241")]
    [FieldOffset(Offset = "0x58")]
    public HomeWindow.RestoreScene[] RestoreScenes;
    [Token(Token = "0x400B242")]
    [FieldOffset(Offset = "0xC")]
    public static int EnterHomeCount;
    [Token(Token = "0x400B243")]
    [FieldOffset(Offset = "0x5C")]
    private bool mNewsShown;
    [Token(Token = "0x400B245")]
    [FieldOffset(Offset = "0x64")]
    private eAdventureStatus mAdventureStatus;

    [Token(Token = "0x170017E9")]
    public static HomeWindow Current
    {
      [Token(Token = "0x600AA14"), Address(RVA = "0x6D6990", Offset = "0x6D5790", VA = "0x106D6990")] get
      {
        return (HomeWindow) null;
      }
    }

    [Token(Token = "0x600AA15")]
    [Address(RVA = "0x6D6140", Offset = "0x6D4F40", VA = "0x106D6140")]
    public static void SetRestorePoint(RestorePoints restorePoint)
    {
    }

    [Token(Token = "0x600AA16")]
    [Address(RVA = "0x6D5060", Offset = "0x6D3E60", VA = "0x106D5060")]
    public static RestorePoints GetRestorePoint() => new RestorePoints();

    [Token(Token = "0x600AA17")]
    [Address(RVA = "0x6D6170", Offset = "0x6D4F70", VA = "0x106D6170")]
    public static void SetRestoreValueList(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600AA18")]
    [Address(RVA = "0x6D5090", Offset = "0x6D3E90", VA = "0x106D5090")]
    public static string GetRestoreSceneName() => (string) null;

    [Token(Token = "0x600AA19")]
    [Address(RVA = "0x61C720", Offset = "0x61B520", VA = "0x1061C720")]
    public void SetReqWorldRaidRewardCheck(bool _value)
    {
    }

    [Token(Token = "0x170017EA")]
    public bool IsReadyInTown
    {
      [Token(Token = "0x600AA1A"), Address(RVA = "0x6D69C0", Offset = "0x6D57C0", VA = "0x106D69C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170017EB")]
    public bool IsSceneChanging
    {
      [Token(Token = "0x600AA1B"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170017EC")]
    public bool DesiredSceneIsHome
    {
      [Token(Token = "0x600AA1C"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170017ED")]
    public HomeWindow.WorldRaidLastBossStatus mWorldRaidLastBossStatus
    {
      [Token(Token = "0x600AA1D"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new HomeWindow.WorldRaidLastBossStatus();
      }
      [Token(Token = "0x600AA1E"), Address(RVA = "0x374A70", Offset = "0x373870", VA = "0x10374A70")] private set
      {
      }
    }

    [Token(Token = "0x600AA1F")]
    [Address(RVA = "0x374A70", Offset = "0x373870", VA = "0x10374A70")]
    public void SetWorldRaidLastBossStatus(HomeWindow.WorldRaidLastBossStatus status)
    {
    }

    [Token(Token = "0x170017EE")]
    public eAdventureStatus AdventureStatus
    {
      [Token(Token = "0x600AA20"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return new eAdventureStatus();
      }
    }

    [Token(Token = "0x600AA21")]
    [Address(RVA = "0x352460", Offset = "0x351260", VA = "0x10352460")]
    public void SetAdventureStatus(eAdventureStatus status)
    {
    }

    [Token(Token = "0x600AA22")]
    [Address(RVA = "0x6D47D0", Offset = "0x6D35D0", VA = "0x106D47D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AA23")]
    [Address(RVA = "0x6D5C40", Offset = "0x6D4A40", VA = "0x106D5C40")]
    private void SceneChangeFromValueList()
    {
    }

    [Token(Token = "0x600AA24")]
    [Address(RVA = "0x6D50F0", Offset = "0x6D3EF0", VA = "0x106D50F0")]
    private bool IsNotHomeBGM() => new bool();

    [Token(Token = "0x600AA25")]
    [Address(RVA = "0x6D62B0", Offset = "0x6D50B0", VA = "0x106D62B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AA26")]
    [Address(RVA = "0x6D5A10", Offset = "0x6D4810", VA = "0x106D5A10")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AA27")]
    [Address(RVA = "0x6D56B0", Offset = "0x6D44B0", VA = "0x106D56B0")]
    private void OnApplicationPause(bool pausing)
    {
    }

    [Token(Token = "0x600AA28")]
    [Address(RVA = "0x6D5690", Offset = "0x6D4490", VA = "0x106D5690")]
    private void OnApplicationFocus(bool focus)
    {
    }

    [Token(Token = "0x600AA29")]
    [Address(RVA = "0x6D5A90", Offset = "0x6D4890", VA = "0x106D5A90")]
    private void OnUpdateTrophyImmediate(WWWResult www)
    {
    }

    [Token(Token = "0x600AA2A")]
    [Address(RVA = "0x6D6230", Offset = "0x6D5030", VA = "0x106D6230")]
    public void SetVisible(bool visible)
    {
    }

    [Token(Token = "0x600AA2B")]
    [Address(RVA = "0x6D6830", Offset = "0x6D5630", VA = "0x106D6830")]
    private void Update()
    {
    }

    [Token(Token = "0x600AA2C")]
    [Address(RVA = "0x6D4FB0", Offset = "0x6D3DB0", VA = "0x106D4FB0")]
    public void FgGIDLoginCheck()
    {
    }

    [Token(Token = "0x600AA2D")]
    [Address(RVA = "0x6D6510", Offset = "0x6D5310", VA = "0x106D6510")]
    public void UnlockContents()
    {
    }

    [Token(Token = "0x600AA2E")]
    [Address(RVA = "0x6D63C0", Offset = "0x6D51C0", VA = "0x106D63C0")]
    private void UnlockContents_ExistClearQuest(UnlockParam unlock)
    {
    }

    [Token(Token = "0x600AA2F")]
    [Address(RVA = "0x6D5620", Offset = "0x6D4420", VA = "0x106D5620")]
    private void NotifySupportResult()
    {
    }

    [Token(Token = "0x600AA30")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void CheckTrophies()
    {
    }

    [Token(Token = "0x600AA31")]
    [Address(RVA = "0x6D5330", Offset = "0x6D4130", VA = "0x106D5330")]
    private void NotifyNewFriendRequests()
    {
    }

    [Token(Token = "0x600AA32")]
    [Address(RVA = "0x6D5B70", Offset = "0x6D4970", VA = "0x106D5B70")]
    public void PushSceneChangeValue([NotNull] SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600AA33")]
    [Address(RVA = "0x6D5AD0", Offset = "0x6D48D0", VA = "0x106D5AD0")]
    public SerializeValueList PopSceneChangeValue() => (SerializeValueList) null;

    [Token(Token = "0x600AA34")]
    [Address(RVA = "0x6D4ED0", Offset = "0x6D3CD0", VA = "0x106D4ED0")]
    public void ChangeNewsState()
    {
    }

    [Token(Token = "0x600AA35")]
    [Address(RVA = "0x6D6090", Offset = "0x6D4E90", VA = "0x106D6090")]
    public void SendEventBeforeChangeScene()
    {
    }

    [Token(Token = "0x600AA36")]
    [Address(RVA = "0x6D5160", Offset = "0x6D3F60", VA = "0x106D5160")]
    private void MiscBeforeDefaultState()
    {
    }

    [Token(Token = "0x600AA37")]
    [Address(RVA = "0x6D5F40", Offset = "0x6D4D40", VA = "0x106D5F40")]
    private void SceneChangeSendLog(string before, string after)
    {
    }

    [Token(Token = "0x600AA38")]
    [Address(RVA = "0x6D6870", Offset = "0x6D5670", VA = "0x106D6870")]
    public HomeWindow()
    {
    }

    [Token(Token = "0x2002624")]
    [Serializable]
    public struct RestoreScene
    {
      [Token(Token = "0x400B246")]
      [FieldOffset(Offset = "0x0")]
      public RestorePoints Type;
      [Token(Token = "0x400B247")]
      [FieldOffset(Offset = "0x4")]
      public int Index;
    }

    [Token(Token = "0x2002625")]
    public enum WorldRaidLastBossStatus
    {
      [Token(Token = "0x400B249")] None,
      [Token(Token = "0x400B24A")] Alive,
      [Token(Token = "0x400B24B")] Dead,
    }

    [Token(Token = "0x2002626")]
    private class State_Default : State<HomeWindow>
    {
      [Token(Token = "0x600AA3A")]
      [Address(RVA = "0x6D7C90", Offset = "0x6D6A90", VA = "0x106D7C90", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA3B")]
      [Address(RVA = "0x6D7CE0", Offset = "0x6D6AE0", VA = "0x106D7CE0", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA3C")]
      [Address(RVA = "0x6D7EF0", Offset = "0x6D6CF0", VA = "0x106D7EF0")]
      public State_Default()
      {
      }
    }

    [Token(Token = "0x2002627")]
    private class State_UnitRentalCheck : State<HomeWindow>
    {
      [Token(Token = "0x600AA3D")]
      [Address(RVA = "0x6D8F20", Offset = "0x6D7D20", VA = "0x106D8F20", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA3E")]
      [Address(RVA = "0x6D8F50", Offset = "0x6D7D50", VA = "0x106D8F50", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA3F")]
      [Address(RVA = "0x6D8FA0", Offset = "0x6D7DA0", VA = "0x106D8FA0")]
      public State_UnitRentalCheck()
      {
      }
    }

    [Token(Token = "0x2002628")]
    private class State_ChangeScene : State<HomeWindow>
    {
      [Token(Token = "0x400B24C")]
      [FieldOffset(Offset = "0xC")]
      private GameObject mNewScene;
      [Token(Token = "0x400B24D")]
      [FieldOffset(Offset = "0x10")]
      private bool waitCriticalSection;
      [Token(Token = "0x400B24E")]
      [FieldOffset(Offset = "0x14")]
      private HomeWindow.State_ChangeScene.eChangeSceneState mChangeSceneState;
      [Token(Token = "0x400B24F")]
      [FieldOffset(Offset = "0x18")]
      private SceneRequest req;
      [Token(Token = "0x400B250")]
      [FieldOffset(Offset = "0x1C")]
      private AsyncOperation UnloadUnusedAssetTask;

      [Token(Token = "0x600AA40")]
      [Address(RVA = "0x6D6A10", Offset = "0x6D5810", VA = "0x106D6A10", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA41")]
      [Address(RVA = "0x6D6AD0", Offset = "0x6D58D0", VA = "0x106D6AD0")]
      private void OnSceneAwake(GameObject scene)
      {
      }

      [Token(Token = "0x600AA42")]
      [Address(RVA = "0x6D6B90", Offset = "0x6D5990", VA = "0x106D6B90", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA43")]
      [Address(RVA = "0x6D7990", Offset = "0x6D6790", VA = "0x106D7990")]
      public State_ChangeScene()
      {
      }

      [Token(Token = "0x2002629")]
      private enum eChangeSceneState
      {
        [Token(Token = "0x400B252")] StartFadeout,
        [Token(Token = "0x400B253")] WaitCriticalSection,
        [Token(Token = "0x400B254")] WaitAnyDownload,
        [Token(Token = "0x400B255")] WaitFadeout,
        [Token(Token = "0x400B256")] StartUnloadUnusedAsset_PreLoad,
        [Token(Token = "0x400B257")] WaitUnloadUnusedAsset_PreLoad,
        [Token(Token = "0x400B258")] StartDownloadNextScene,
        [Token(Token = "0x400B259")] WaitDownloadNextScene,
        [Token(Token = "0x400B25A")] StartLoadNextScene,
        [Token(Token = "0x400B25B")] WaitLoadNextScene,
        [Token(Token = "0x400B25C")] DestroyCurrentScene,
        [Token(Token = "0x400B25D")] StartActivateNextScene,
        [Token(Token = "0x400B25E")] WaitActivateNextScene,
        [Token(Token = "0x400B25F")] StartUnloadUnusedAsset_PostLoad,
        [Token(Token = "0x400B260")] WaitUnloadUnusedAsset_PostLoad,
        [Token(Token = "0x400B261")] FadeInStart,
        [Token(Token = "0x400B262")] FadeInWait,
        [Token(Token = "0x400B263")] TransitionNextState,
      }
    }

    [Token(Token = "0x200262A")]
    private class State_UpdateTrophy : State<HomeWindow>
    {
      [Token(Token = "0x400B264")]
      [FieldOffset(Offset = "0xC")]
      private List<TrophyState> mDirtyList;

      [Token(Token = "0x600AA44")]
      [Address(RVA = "0x6D9380", Offset = "0x6D8180", VA = "0x106D9380", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA45")]
      [Address(RVA = "0x6D95D0", Offset = "0x6D83D0", VA = "0x106D95D0")]
      private void ResponseCallback(WWWResult www)
      {
      }

      [Token(Token = "0x600AA46")]
      [Address(RVA = "0x6D9A00", Offset = "0x6D8800", VA = "0x106D9A00")]
      public State_UpdateTrophy()
      {
      }
    }

    [Token(Token = "0x200262B")]
    private class State_UpdateChallengeMission : State<HomeWindow>
    {
      [Token(Token = "0x400B265")]
      [FieldOffset(Offset = "0xC")]
      private List<TrophyState> mDirtyList;

      [Token(Token = "0x600AA47")]
      [Address(RVA = "0x6D8FE0", Offset = "0x6D7DE0", VA = "0x106D8FE0", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA48")]
      [Address(RVA = "0x6D9230", Offset = "0x6D8030", VA = "0x106D9230")]
      private void ResponseCallback(WWWResult www)
      {
      }

      [Token(Token = "0x600AA49")]
      [Address(RVA = "0x6D9340", Offset = "0x6D8140", VA = "0x106D9340")]
      public State_UpdateChallengeMission()
      {
      }
    }

    [Token(Token = "0x200262C")]
    private class State_GuildTrophy : State<HomeWindow>
    {
      [Token(Token = "0x400B266")]
      [FieldOffset(Offset = "0xC")]
      private LoadRequest mReq;
      [Token(Token = "0x400B267")]
      [FieldOffset(Offset = "0x10")]
      private GameObject mInstance;

      [Token(Token = "0x600AA4A")]
      [Address(RVA = "0x6D8120", Offset = "0x6D6F20", VA = "0x106D8120", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA4B")]
      [Address(RVA = "0x6D81A0", Offset = "0x6D6FA0", VA = "0x106D81A0", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA4C")]
      [Address(RVA = "0x6D84A0", Offset = "0x6D72A0", VA = "0x106D84A0")]
      public State_GuildTrophy()
      {
      }
    }

    [Token(Token = "0x200262D")]
    private class State_CombatPowerQuestTryUnlock : State<HomeWindow>
    {
      [Token(Token = "0x600AA4D")]
      [Address(RVA = "0x6D79D0", Offset = "0x6D67D0", VA = "0x106D79D0", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA4E")]
      [Address(RVA = "0x6D79F0", Offset = "0x6D67F0", VA = "0x106D79F0", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA4F")]
      [Address(RVA = "0x6D7C50", Offset = "0x6D6A50", VA = "0x106D7C50")]
      public State_CombatPowerQuestTryUnlock()
      {
      }
    }

    [Token(Token = "0x200262E")]
    private class State_News : State<HomeWindow>
    {
      [Token(Token = "0x400B268")]
      [FieldOffset(Offset = "0xC")]
      private LoadRequest mReq;
      [Token(Token = "0x400B269")]
      [FieldOffset(Offset = "0x10")]
      private GameObject mInstance;

      [Token(Token = "0x600AA50")]
      [Address(RVA = "0x6D84E0", Offset = "0x6D72E0", VA = "0x106D84E0", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA51")]
      [Address(RVA = "0x6D85B0", Offset = "0x6D73B0", VA = "0x106D85B0", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA52")]
      [Address(RVA = "0x6D89C0", Offset = "0x6D77C0", VA = "0x106D89C0")]
      public State_News()
      {
      }
    }

    [Token(Token = "0x200262F")]
    private class State_RankMatchReward : State<HomeWindow>
    {
      [Token(Token = "0x600AA53")]
      [Address(RVA = "0x6D8C60", Offset = "0x6D7A60", VA = "0x106D8C60", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA54")]
      [Address(RVA = "0x6D8CE0", Offset = "0x6D7AE0", VA = "0x106D8CE0", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA55")]
      [Address(RVA = "0x6D8EE0", Offset = "0x6D7CE0", VA = "0x106D8EE0")]
      public State_RankMatchReward()
      {
      }
    }

    [Token(Token = "0x2002630")]
    private class State_RaidReward : State<HomeWindow>
    {
      [Token(Token = "0x600AA56")]
      [Address(RVA = "0x6D8A00", Offset = "0x6D7800", VA = "0x106D8A00", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA57")]
      [Address(RVA = "0x6D8A80", Offset = "0x6D7880", VA = "0x106D8A80", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA58")]
      [Address(RVA = "0x6D8C20", Offset = "0x6D7A20", VA = "0x106D8C20")]
      public State_RaidReward()
      {
      }
    }

    [Token(Token = "0x2002631")]
    private class State_GuildRaidReward : State<HomeWindow>
    {
      [Token(Token = "0x600AA59")]
      [Address(RVA = "0x6D7F30", Offset = "0x6D6D30", VA = "0x106D7F30", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA5A")]
      [Address(RVA = "0x6D7FB0", Offset = "0x6D6DB0", VA = "0x106D7FB0", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA5B")]
      [Address(RVA = "0x6D80E0", Offset = "0x6D6EE0", VA = "0x106D80E0")]
      public State_GuildRaidReward()
      {
      }
    }

    [Token(Token = "0x2002632")]
    private class State_LoginBonus : State<HomeWindow>
    {
      [Token(Token = "0x400B26A")]
      [FieldOffset(Offset = "0xC")]
      private LoadRequest mReq;
      [Token(Token = "0x400B26B")]
      [FieldOffset(Offset = "0x10")]
      private GameObject mInstance;
      [Token(Token = "0x400B26C")]
      [FieldOffset(Offset = "0x14")]
      private string mLoginBonusType;

      [Token(Token = "0x600AA5C")]
      [Address(RVA = "0x6F2100", Offset = "0x6F0F00", VA = "0x106F2100", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA5D")]
      [Address(RVA = "0x6F2620", Offset = "0x6F1420", VA = "0x106F2620", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA5E")]
      [Address(RVA = "0x6F21C0", Offset = "0x6F0FC0", VA = "0x106F21C0")]
      private bool LoginBonusGameObjectLoad() => new bool();

      [Token(Token = "0x600AA5F")]
      [Address(RVA = "0x6F2480", Offset = "0x6F1280", VA = "0x106F2480")]
      private void NextLoginBonusBegin()
      {
      }

      [Token(Token = "0x600AA60")]
      [Address(RVA = "0x6F2A90", Offset = "0x6F1890", VA = "0x106F2A90")]
      public State_LoginBonus()
      {
      }
    }

    [Token(Token = "0x2002633")]
    private class State_BeginnerNotify : State<HomeWindow>
    {
      [Token(Token = "0x600AA61")]
      [Address(RVA = "0x6F1C90", Offset = "0x6F0A90", VA = "0x106F1C90", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA62")]
      [Address(RVA = "0x6F1CF0", Offset = "0x6F0AF0", VA = "0x106F1CF0", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA63")]
      [Address(RVA = "0x6F1D80", Offset = "0x6F0B80", VA = "0x106F1D80")]
      public State_BeginnerNotify()
      {
      }
    }

    [Token(Token = "0x2002634")]
    private class State_HotDeal : State<HomeWindow>
    {
      [Token(Token = "0x400B26D")]
      [FieldOffset(Offset = "0xC")]
      private bool wait_one_frame;

      [Token(Token = "0x600AA64")]
      [Address(RVA = "0x6F1E90", Offset = "0x6F0C90", VA = "0x106F1E90", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA65")]
      [Address(RVA = "0x6F1F60", Offset = "0x6F0D60", VA = "0x106F1F60", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA66")]
      [Address(RVA = "0x6F20C0", Offset = "0x6F0EC0", VA = "0x106F20C0")]
      public State_HotDeal()
      {
      }
    }

    [Token(Token = "0x2002635")]
    private class State_GachaRedraw : State<HomeWindow>
    {
      [Token(Token = "0x600AA67")]
      [Address(RVA = "0x6F1DC0", Offset = "0x6F0BC0", VA = "0x106F1DC0", Slot = "4")]
      public override void Begin(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA68")]
      [Address(RVA = "0x6F1DE0", Offset = "0x6F0BE0", VA = "0x106F1DE0", Slot = "5")]
      public override void Update(HomeWindow self)
      {
      }

      [Token(Token = "0x600AA69")]
      [Address(RVA = "0x6F1E50", Offset = "0x6F0C50", VA = "0x106F1E50")]
      public State_GachaRedraw()
      {
      }
    }
  }
}
