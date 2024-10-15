// Decompiled with JetBrains decompiler
// Type: SRPG.RaidBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C6E")]
  public class RaidBossParam : RaidMasterParam<JSON_RaidBossParam>
  {
    [Token(Token = "0x4006FB6")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x4006FB7")]
    [FieldOffset(Offset = "0xC")]
    private int mStampIndex;
    [Token(Token = "0x4006FB8")]
    [FieldOffset(Offset = "0x10")]
    private int mPeriodId;
    [Token(Token = "0x4006FB9")]
    [FieldOffset(Offset = "0x14")]
    private int mWeight;
    [Token(Token = "0x4006FBA")]
    [FieldOffset(Offset = "0x18")]
    private string mName;
    [Token(Token = "0x4006FBB")]
    [FieldOffset(Offset = "0x1C")]
    private int mHP;
    [Token(Token = "0x4006FBC")]
    [FieldOffset(Offset = "0x20")]
    private string mUnitIName;
    [Token(Token = "0x4006FBD")]
    [FieldOffset(Offset = "0x24")]
    private string mQuestIName;
    [Token(Token = "0x4006FBE")]
    [FieldOffset(Offset = "0x28")]
    private string mTimeLimit;
    [Token(Token = "0x4006FBF")]
    [FieldOffset(Offset = "0x30")]
    private TimeSpan mTimeLimitSpan;
    [Token(Token = "0x4006FC0")]
    [FieldOffset(Offset = "0x38")]
    private int mBattleRewardId;
    [Token(Token = "0x4006FC1")]
    [FieldOffset(Offset = "0x3C")]
    private int mBeatRewardId;
    [Token(Token = "0x4006FC2")]
    [FieldOffset(Offset = "0x40")]
    private int mDamageRatioRewardId;
    [Token(Token = "0x4006FC3")]
    [FieldOffset(Offset = "0x44")]
    private int mDamageAmountRewardId;
    [Token(Token = "0x4006FC4")]
    [FieldOffset(Offset = "0x48")]
    private string mBuffId;
    [Token(Token = "0x4006FC5")]
    [FieldOffset(Offset = "0x4C")]
    private string mMobBuffId;
    [Token(Token = "0x4006FC6")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsBoss;

    [Token(Token = "0x17000F04")]
    public int Id
    {
      [Token(Token = "0x600754B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F05")]
    public int StampIndex
    {
      [Token(Token = "0x600754C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F06")]
    public int PeriodId
    {
      [Token(Token = "0x600754D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F07")]
    public int Weight
    {
      [Token(Token = "0x600754E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F08")]
    public string Name
    {
      [Token(Token = "0x600754F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F09")]
    public int HP
    {
      [Token(Token = "0x6007550"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F0A")]
    public string UnitIName
    {
      [Token(Token = "0x6007551"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F0B")]
    public string QuestIName
    {
      [Token(Token = "0x6007552"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F0C")]
    public string TimeLimit
    {
      [Token(Token = "0x6007553"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F0D")]
    public TimeSpan TimeLimitSpan
    {
      [Token(Token = "0x6007554"), Address(RVA = "0x32ED20", Offset = "0x32DB20", VA = "0x1032ED20")] get
      {
        return new TimeSpan();
      }
    }

    [Token(Token = "0x17000F0E")]
    public int BattleRewardId
    {
      [Token(Token = "0x6007555"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F0F")]
    public int BeatRewardId
    {
      [Token(Token = "0x6007556"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F10")]
    public int DamageRatioRewardId
    {
      [Token(Token = "0x6007557"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F11")]
    public int DamageAmountRewardId
    {
      [Token(Token = "0x6007558"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F12")]
    public string BuffId
    {
      [Token(Token = "0x6007559"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F13")]
    public string MobBuffId
    {
      [Token(Token = "0x600755A"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F14")]
    public bool IsBoss
    {
      [Token(Token = "0x600755B"), Address(RVA = "0x2AABD0", Offset = "0x2A99D0", VA = "0x102AABD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600755C")]
    [Address(RVA = "0x392EB0", Offset = "0x391CB0", VA = "0x10392EB0", Slot = "4")]
    public override bool Deserialize(JSON_RaidBossParam json) => new bool();

    [Token(Token = "0x600755D")]
    [Address(RVA = "0x392D20", Offset = "0x391B20", VA = "0x10392D20")]
    public static int CalcMaxHP(RaidBossParam param, int round) => new int();

    [Token(Token = "0x600755E")]
    [Address(RVA = "0x393080", Offset = "0x391E80", VA = "0x10393080")]
    public RaidBossParam()
    {
    }
  }
}
