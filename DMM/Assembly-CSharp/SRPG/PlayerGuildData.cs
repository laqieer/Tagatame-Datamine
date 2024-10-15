// Decompiled with JetBrains decompiler
// Type: SRPG.PlayerGuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F88")]
  public class PlayerGuildData
  {
    [Token(Token = "0x400368F")]
    [FieldOffset(Offset = "0x8")]
    private int mGid;
    [Token(Token = "0x4003690")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4003691")]
    [FieldOffset(Offset = "0x10")]
    private GuildMemberData.eRole mRoleId;
    [Token(Token = "0x4003692")]
    [FieldOffset(Offset = "0x18")]
    private long mAppliedAt;
    [Token(Token = "0x4003693")]
    [FieldOffset(Offset = "0x20")]
    private long mJoinedAt;
    [Token(Token = "0x4003694")]
    [FieldOffset(Offset = "0x28")]
    private long mLeavedAt;

    [Token(Token = "0x1700055F")]
    public int Gid
    {
      [Token(Token = "0x600405C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000560")]
    public string Name
    {
      [Token(Token = "0x600405D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000561")]
    public GuildMemberData.eRole RoleId
    {
      [Token(Token = "0x600405E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new GuildMemberData.eRole();
      }
    }

    [Token(Token = "0x17000562")]
    public long AppliedAt
    {
      [Token(Token = "0x600405F"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000563")]
    public long JoinedAt
    {
      [Token(Token = "0x6004060"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000564")]
    public long LeavedAt
    {
      [Token(Token = "0x6004061"), Address(RVA = "0x3057C0", Offset = "0x3045C0", VA = "0x103057C0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000565")]
    public bool IsJoined
    {
      [Token(Token = "0x6004062"), Address(RVA = "0x119C0E0", Offset = "0x119AEE0", VA = "0x1119C0E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000566")]
    public bool IsGuildMaster
    {
      [Token(Token = "0x6004063"), Address(RVA = "0x61CA00", Offset = "0x61B800", VA = "0x1061CA00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000567")]
    public bool IsSubGuildMaster
    {
      [Token(Token = "0x6004064"), Address(RVA = "0x119C100", Offset = "0x119AF00", VA = "0x1119C100")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004065")]
    [Address(RVA = "0x119C080", Offset = "0x119AE80", VA = "0x1119C080")]
    public bool Deserialize(JSON_PlayerGuild json) => new bool();

    [Token(Token = "0x6004066")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PlayerGuildData()
    {
    }
  }
}
