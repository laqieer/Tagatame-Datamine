// Decompiled with JetBrains decompiler
// Type: SRPG.GuildMemberData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F8B")]
  public class GuildMemberData
  {
    [Token(Token = "0x40036A7")]
    [FieldOffset(Offset = "0x8")]
    private long mGid;
    [Token(Token = "0x40036A8")]
    [FieldOffset(Offset = "0x10")]
    private string mUid;
    [Token(Token = "0x40036A9")]
    [FieldOffset(Offset = "0x14")]
    private GuildMemberData.eRole mRoleId;
    [Token(Token = "0x40036AA")]
    [FieldOffset(Offset = "0x18")]
    private string mName;
    [Token(Token = "0x40036AB")]
    [FieldOffset(Offset = "0x1C")]
    private int mLevel;
    [Token(Token = "0x40036AC")]
    [FieldOffset(Offset = "0x20")]
    private string mAward;
    [Token(Token = "0x40036AD")]
    [FieldOffset(Offset = "0x24")]
    private UnitData mUnit;
    [Token(Token = "0x40036AE")]
    [FieldOffset(Offset = "0x28")]
    private long mAppliedAt;
    [Token(Token = "0x40036AF")]
    [FieldOffset(Offset = "0x30")]
    private long mJoinedAt;
    [Token(Token = "0x40036B0")]
    [FieldOffset(Offset = "0x38")]
    private long mLeaveAt;
    [Token(Token = "0x40036B1")]
    [FieldOffset(Offset = "0x40")]
    private long mLastLogin;

    [Token(Token = "0x17000579")]
    public long Gid
    {
      [Token(Token = "0x6004089"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700057A")]
    public string Uid
    {
      [Token(Token = "0x600408A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700057B")]
    public GuildMemberData.eRole RoleId
    {
      [Token(Token = "0x600408B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new GuildMemberData.eRole();
      }
    }

    [Token(Token = "0x1700057C")]
    public string Name
    {
      [Token(Token = "0x600408C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700057D")]
    public int Level
    {
      [Token(Token = "0x600408D"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700057E")]
    public string Award
    {
      [Token(Token = "0x600408E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700057F")]
    public UnitData Unit
    {
      [Token(Token = "0x600408F"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17000580")]
    public long AppliedAt
    {
      [Token(Token = "0x6004090"), Address(RVA = "0x3057C0", Offset = "0x3045C0", VA = "0x103057C0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000581")]
    public long JoinedAt
    {
      [Token(Token = "0x6004091"), Address(RVA = "0x3057D0", Offset = "0x3045D0", VA = "0x103057D0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000582")]
    public long LeaveAt
    {
      [Token(Token = "0x6004092"), Address(RVA = "0x1105E50", Offset = "0x1104C50", VA = "0x11105E50")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000583")]
    public long LastLogin
    {
      [Token(Token = "0x6004093"), Address(RVA = "0x66AFE0", Offset = "0x669DE0", VA = "0x1066AFE0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6004094")]
    [Address(RVA = "0x11925B0", Offset = "0x11913B0", VA = "0x111925B0")]
    public bool Deserialize(JSON_GuildMember json) => new bool();

    [Token(Token = "0x6004095")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildMemberData()
    {
    }

    [Token(Token = "0x2000F8C")]
    public enum eRole
    {
      [Token(Token = "0x40036B3")] NONE,
      [Token(Token = "0x40036B4")] MASTAER,
      [Token(Token = "0x40036B5")] MEMBER,
      [Token(Token = "0x40036B6")] SUB_MASTAER,
    }
  }
}
