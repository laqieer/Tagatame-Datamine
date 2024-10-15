// Decompiled with JetBrains decompiler
// Type: SRPG.GuildManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002562")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "チャットボタン非表示", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(1020, "設立or加入", FlowNode.PinTypes.Output, 1020)]
  [AddComponentMenu("UI/GuildManager")]
  [FlowNode.Pin(1010, "ロビー生成", FlowNode.PinTypes.Output, 1010)]
  public class GuildManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AC99")]
    private const long INTERVAL_CHECK_GUILD_INVITE = 1800;
    [Token(Token = "0x400AC9A")]
    [FieldOffset(Offset = "0x0")]
    private static long LastCheckGuildInviteTime;
    [Token(Token = "0x400AC9B")]
    [FieldOffset(Offset = "0x8")]
    public static int NotifyEntryRequestCount;
    [Token(Token = "0x400AC9C")]
    public const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x400AC9D")]
    public const int PIN_INPUT_HIDE_CHAT_BUTTON = 20;
    [Token(Token = "0x400AC9E")]
    public const int PIN_OUTPUT_CREATE_LOBBY = 1010;
    [Token(Token = "0x400AC9F")]
    public const int PIN_OUTPUT_CREATE_COMMAND = 1020;
    [Token(Token = "0x400ACA0")]
    [FieldOffset(Offset = "0xC")]
    private static GuildManager mInstance;
    [Token(Token = "0x400ACA1")]
    [FieldOffset(Offset = "0xC")]
    private GuildMemberData[] mEntryRequests;
    [Token(Token = "0x400ACA4")]
    [FieldOffset(Offset = "0x18")]
    public GvGLeagueParam SelectLeagueParam;
    [Token(Token = "0x400ACA5")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsMasterChange;
    [Token(Token = "0x400ACA6")]
    [FieldOffset(Offset = "0x1D")]
    private bool mIsTrainingStatus;

    [Token(Token = "0x600A577")]
    [Address(RVA = "0x678FD0", Offset = "0x677DD0", VA = "0x10678FD0")]
    public static bool IsNeedGuildInviteRequest(long now) => new bool();

    [Token(Token = "0x1700170E")]
    public static GuildManager Instance
    {
      [Token(Token = "0x600A578"), Address(RVA = "0x6793F0", Offset = "0x6781F0", VA = "0x106793F0")] get
      {
        return (GuildManager) null;
      }
    }

    [Token(Token = "0x1700170F")]
    public GuildMemberData[] EntryRequests
    {
      [Token(Token = "0x600A579"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GuildMemberData[]) null;
      }
    }

    [Token(Token = "0x17001710")]
    public int AppearsGuildRaidPeriodId
    {
      [Token(Token = "0x600A57A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A57B"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17001711")]
    public GuildManager.GvGEntryStatus EntryStatus
    {
      [Token(Token = "0x600A57C"), Address(RVA = "0x6793B0", Offset = "0x6781B0", VA = "0x106793B0")] get
      {
        return new GuildManager.GvGEntryStatus();
      }
    }

    [Token(Token = "0x17001712")]
    public GuildManager.GuildAttendStatus AttendStatus
    {
      [Token(Token = "0x600A57D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new GuildManager.GuildAttendStatus();
      }
      [Token(Token = "0x600A57E"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17001713")]
    public bool IsMasterChange
    {
      [Token(Token = "0x600A57F"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001714")]
    public bool IsTrainingStatus
    {
      [Token(Token = "0x600A580"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A581")]
    [Address(RVA = "0x678CD0", Offset = "0x677AD0", VA = "0x10678CD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A582")]
    [Address(RVA = "0x678B80", Offset = "0x677980", VA = "0x10678B80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A583")]
    [Address(RVA = "0x678EF0", Offset = "0x677CF0", VA = "0x10678EF0")]
    private void Init()
    {
    }

    [Token(Token = "0x600A584")]
    [Address(RVA = "0x6791B0", Offset = "0x677FB0", VA = "0x106791B0")]
    public void SetEntryRequest(JSON_GuildMember[] json)
    {
    }

    [Token(Token = "0x600A585")]
    [Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")]
    public void SetGuildRaidPeriod(int period)
    {
    }

    [Token(Token = "0x600A586")]
    [Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")]
    public void SetGuildAttendStatus(int attend_status)
    {
    }

    [Token(Token = "0x600A587")]
    [Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")]
    public void SetGuildAttendStatus(GuildManager.GuildAttendStatus attend_status)
    {
    }

    [Token(Token = "0x600A588")]
    [Address(RVA = "0x678D30", Offset = "0x677B30", VA = "0x10678D30")]
    public static void GetEmblem(GameObject obj, string name, GameObject root)
    {
    }

    [Token(Token = "0x600A589")]
    [Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")]
    public void SetupDelegationType(bool flag)
    {
    }

    [Token(Token = "0x600A58A")]
    [Address(RVA = "0x5EDEC0", Offset = "0x5ECCC0", VA = "0x105EDEC0")]
    public void SetupTrainingStatus(bool flag)
    {
    }

    [Token(Token = "0x600A58B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildManager()
    {
    }

    [Token(Token = "0x600A58C")]
    [Address(RVA = "0x679360", Offset = "0x678160", VA = "0x10679360")]
    static GuildManager()
    {
    }

    [Token(Token = "0x2002563")]
    public enum GvGEntry
    {
      [Token(Token = "0x400ACA8")] NONE,
      [Token(Token = "0x400ACA9")] JOIN,
      [Token(Token = "0x400ACAA")] CANCEL,
    }

    [Token(Token = "0x2002564")]
    public enum GvGEntryStatus
    {
      [Token(Token = "0x400ACAC")] RESTTIME = -2, // 0xFFFFFFFE
      [Token(Token = "0x400ACAD")] MATCHINGPROCESS = -1, // 0xFFFFFFFF
      [Token(Token = "0x400ACAE")] NOT_MATCHING = 0,
      [Token(Token = "0x400ACAF")] MATCHING_OK = 1,
    }

    [Token(Token = "0x2002565")]
    public enum GuildAttendStatus
    {
      [Token(Token = "0x400ACB1")] UNATTENDED,
      [Token(Token = "0x400ACB2")] ATTENDED,
      [Token(Token = "0x400ACB3")] CAN_NOT_ATTENDED,
    }
  }
}
