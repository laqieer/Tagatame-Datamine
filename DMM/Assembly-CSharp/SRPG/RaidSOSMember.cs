// Decompiled with JetBrains decompiler
// Type: SRPG.RaidSOSMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010DE")]
  public class RaidSOSMember
  {
    [Token(Token = "0x4003CE5")]
    [FieldOffset(Offset = "0x8")]
    private string mFUID;
    [Token(Token = "0x4003CE6")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4003CE7")]
    [FieldOffset(Offset = "0x10")]
    private int mLv;
    [Token(Token = "0x4003CE8")]
    [FieldOffset(Offset = "0x14")]
    private UnitData mUnit;
    [Token(Token = "0x4003CE9")]
    [FieldOffset(Offset = "0x18")]
    private RaidRescueMemberType mMemberType;
    [Token(Token = "0x4003CEA")]
    [FieldOffset(Offset = "0x20")]
    private long mLastBattleTime;

    [Token(Token = "0x17000719")]
    public string FUID
    {
      [Token(Token = "0x600473E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700071A")]
    public string Name
    {
      [Token(Token = "0x600473F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700071B")]
    public int Lv
    {
      [Token(Token = "0x6004740"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700071C")]
    public UnitData Unit
    {
      [Token(Token = "0x6004741"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x1700071D")]
    public RaidRescueMemberType MemberType
    {
      [Token(Token = "0x6004742"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new RaidRescueMemberType();
      }
    }

    [Token(Token = "0x1700071E")]
    public long LastBattleTime
    {
      [Token(Token = "0x6004743"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6004744")]
    [Address(RVA = "0x11E9130", Offset = "0x11E7F30", VA = "0x111E9130")]
    public bool Deserialize(JSON_RaidSOSMember json) => new bool();

    [Token(Token = "0x6004745")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidSOSMember()
    {
    }
  }
}
