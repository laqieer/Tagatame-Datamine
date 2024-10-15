// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRescueMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010DF")]
  public class RaidRescueMember
  {
    [Token(Token = "0x4003CEB")]
    [FieldOffset(Offset = "0x8")]
    private string mUID;
    [Token(Token = "0x4003CEC")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4003CED")]
    [FieldOffset(Offset = "0x10")]
    private int mLv;
    [Token(Token = "0x4003CEE")]
    [FieldOffset(Offset = "0x14")]
    private RaidRescueMemberType mMemberType;
    [Token(Token = "0x4003CEF")]
    [FieldOffset(Offset = "0x18")]
    private UnitData mUnit;
    [Token(Token = "0x4003CF0")]
    [FieldOffset(Offset = "0x1C")]
    private string mSelectedAward;
    [Token(Token = "0x4003CF1")]
    [FieldOffset(Offset = "0x20")]
    private DateTime mLastLogin;
    [Token(Token = "0x4003CF2")]
    [FieldOffset(Offset = "0x28")]
    private int mAreaId;
    [Token(Token = "0x4003CF3")]
    [FieldOffset(Offset = "0x2C")]
    private int mBossId;
    [Token(Token = "0x4003CF4")]
    [FieldOffset(Offset = "0x30")]
    private int mRound;
    [Token(Token = "0x4003CF5")]
    [FieldOffset(Offset = "0x34")]
    private int mCurrentHp;
    [Token(Token = "0x4003CF6")]
    [FieldOffset(Offset = "0x38")]
    private long mStartTime;

    [Token(Token = "0x1700071F")]
    public string UID
    {
      [Token(Token = "0x6004746"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000720")]
    public string Name
    {
      [Token(Token = "0x6004747"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000721")]
    public int Lv
    {
      [Token(Token = "0x6004748"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000722")]
    public RaidRescueMemberType MemberType
    {
      [Token(Token = "0x6004749"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new RaidRescueMemberType();
      }
    }

    [Token(Token = "0x17000723")]
    public UnitData Unit
    {
      [Token(Token = "0x600474A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17000724")]
    public string SelectedAward
    {
      [Token(Token = "0x600474B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000725")]
    public DateTime LastLogin
    {
      [Token(Token = "0x600474C"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000726")]
    public int AreaId
    {
      [Token(Token = "0x600474D"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000727")]
    public int BossId
    {
      [Token(Token = "0x600474E"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000728")]
    public int Round
    {
      [Token(Token = "0x600474F"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000729")]
    public int CurrentHp
    {
      [Token(Token = "0x6004750"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700072A")]
    public long StartTime
    {
      [Token(Token = "0x6004751"), Address(RVA = "0x1105E50", Offset = "0x1104C50", VA = "0x11105E50")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6004752")]
    [Address(RVA = "0x11E8D40", Offset = "0x11E7B40", VA = "0x111E8D40")]
    public bool Deserialize(JSON_RaidRescueMember json) => new bool();

    [Token(Token = "0x6004753")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidRescueMember()
    {
    }
  }
}
