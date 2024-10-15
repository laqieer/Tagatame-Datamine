// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBossInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010DD")]
  public class RaidBossInfo
  {
    [Token(Token = "0x4003CDC")]
    [FieldOffset(Offset = "0x8")]
    private int mNo;
    [Token(Token = "0x4003CDD")]
    [FieldOffset(Offset = "0xC")]
    private int mBossId;
    [Token(Token = "0x4003CDE")]
    [FieldOffset(Offset = "0x10")]
    private int mRound;
    [Token(Token = "0x4003CDF")]
    [FieldOffset(Offset = "0x14")]
    private int mMaxHP;
    [Token(Token = "0x4003CE0")]
    [FieldOffset(Offset = "0x18")]
    private int mHP;
    [Token(Token = "0x4003CE1")]
    [FieldOffset(Offset = "0x20")]
    private long mStartTime;
    [Token(Token = "0x4003CE2")]
    [FieldOffset(Offset = "0x28")]
    private bool mIsReward;
    [Token(Token = "0x4003CE3")]
    [FieldOffset(Offset = "0x29")]
    private bool mIsTimeOver;
    [Token(Token = "0x4003CE4")]
    [FieldOffset(Offset = "0x2C")]
    private RaidBossParam mRaidBossParam;

    [Token(Token = "0x17000710")]
    public int No
    {
      [Token(Token = "0x6004733"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000711")]
    public int BossId
    {
      [Token(Token = "0x6004734"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000712")]
    public int Round
    {
      [Token(Token = "0x6004735"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000713")]
    public int MaxHP
    {
      [Token(Token = "0x6004736"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000714")]
    public int HP
    {
      [Token(Token = "0x6004737"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000715")]
    public long StartTime
    {
      [Token(Token = "0x6004738"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000716")]
    public bool IsReward
    {
      [Token(Token = "0x6004739"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000717")]
    public bool IsTimeOver
    {
      [Token(Token = "0x600473A"), Address(RVA = "0x11E83E0", Offset = "0x11E71E0", VA = "0x111E83E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000718")]
    public RaidBossParam RaidBossParam
    {
      [Token(Token = "0x600473B"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (RaidBossParam) null;
      }
    }

    [Token(Token = "0x600473C")]
    [Address(RVA = "0x11E8310", Offset = "0x11E7110", VA = "0x111E8310")]
    public bool Deserialize(JSON_RaidBossInfo json) => new bool();

    [Token(Token = "0x600473D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidBossInfo()
    {
    }
  }
}
