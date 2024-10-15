// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F12")]
  public class WorldRaidParam
  {
    [Token(Token = "0x40082C6")]
    private const string DEFAULT_START_TIME = "00:00:00";
    [Token(Token = "0x40082C7")]
    private const string DEFAULT_END_TIME = "23:59:59";
    [Token(Token = "0x40082C8")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40082C9")]
    [FieldOffset(Offset = "0xC")]
    private string mBeginTime;
    [Token(Token = "0x40082CA")]
    [FieldOffset(Offset = "0x10")]
    private string mChallengeEndTime;
    [Token(Token = "0x40082CB")]
    [FieldOffset(Offset = "0x14")]
    private string mDescURL;
    [Token(Token = "0x40082CC")]
    [FieldOffset(Offset = "0x18")]
    private string mDescTitle;
    [Token(Token = "0x40082CD")]
    [FieldOffset(Offset = "0x1C")]
    private List<WorldRaidParam.BossInfo> mBossInfoList;
    [Token(Token = "0x40082CE")]
    [FieldOffset(Offset = "0x20")]
    private DateTime mBeginAt;
    [Token(Token = "0x40082CF")]
    [FieldOffset(Offset = "0x28")]
    private DateTime mEndAt;
    [Token(Token = "0x40082D0")]
    [FieldOffset(Offset = "0x30")]
    private DateTime mChPermAt;
    [Token(Token = "0x40082D1")]
    [FieldOffset(Offset = "0x38")]
    private DateTime mRankingEndAt;
    [Token(Token = "0x40082D2")]
    [FieldOffset(Offset = "0x40")]
    private WorldRaidParam.eCostType mCostType;
    [Token(Token = "0x40082D3")]
    [FieldOffset(Offset = "0x44")]
    private int mMaxBp;
    [Token(Token = "0x40082D4")]
    [FieldOffset(Offset = "0x48")]
    private string mAddBpTime;
    [Token(Token = "0x40082D5")]
    [FieldOffset(Offset = "0x4C")]
    private string mBpHealId;
    [Token(Token = "0x40082D6")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsLap;

    [Token(Token = "0x17001221")]
    public string Iname
    {
      [Token(Token = "0x6007F06"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001222")]
    public string BeginTime
    {
      [Token(Token = "0x6007F07"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001223")]
    public string ChallengeEndTime
    {
      [Token(Token = "0x6007F08"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001224")]
    public string DescURL
    {
      [Token(Token = "0x6007F09"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001225")]
    public string DescTitle
    {
      [Token(Token = "0x6007F0A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001226")]
    public List<WorldRaidParam.BossInfo> BossInfoList
    {
      [Token(Token = "0x6007F0B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<WorldRaidParam.BossInfo>) null;
      }
    }

    [Token(Token = "0x17001227")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6007F0C"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17001228")]
    public DateTime EndAt
    {
      [Token(Token = "0x6007F0D"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17001229")]
    public DateTime ChPermAt
    {
      [Token(Token = "0x6007F0E"), Address(RVA = "0x32ED20", Offset = "0x32DB20", VA = "0x1032ED20")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x1700122A")]
    public DateTime RankingEndAt
    {
      [Token(Token = "0x6007F0F"), Address(RVA = "0x370600", Offset = "0x36F400", VA = "0x10370600")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x1700122B")]
    public WorldRaidParam.eCostType CostType
    {
      [Token(Token = "0x6007F10"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new WorldRaidParam.eCostType();
      }
    }

    [Token(Token = "0x1700122C")]
    public int MaxBp
    {
      [Token(Token = "0x6007F11"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700122D")]
    public string AddBpTime
    {
      [Token(Token = "0x6007F12"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700122E")]
    public string BpHealId
    {
      [Token(Token = "0x6007F13"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700122F")]
    public bool IsLap
    {
      [Token(Token = "0x6007F14"), Address(RVA = "0x2AABD0", Offset = "0x2A99D0", VA = "0x102AABD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007F15")]
    [Address(RVA = "0x414C20", Offset = "0x413A20", VA = "0x10414C20")]
    public void Deserialize(JSON_WorldRaidParam json)
    {
    }

    [Token(Token = "0x6007F16")]
    [Address(RVA = "0x414B10", Offset = "0x413910", VA = "0x10414B10")]
    public DateTime BossChallengeStartTime() => new DateTime();

    [Token(Token = "0x6007F17")]
    [Address(RVA = "0x414A00", Offset = "0x413800", VA = "0x10414A00")]
    public DateTime BossChallengeEndTime() => new DateTime();

    [Token(Token = "0x6007F18")]
    [Address(RVA = "0x415920", Offset = "0x414720", VA = "0x10415920")]
    public bool IsWithinRankingEnd() => new bool();

    [Token(Token = "0x6007F19")]
    [Address(RVA = "0x415850", Offset = "0x414650", VA = "0x10415850")]
    public bool IsWithinPeriod() => new bool();

    [Token(Token = "0x6007F1A")]
    [Address(RVA = "0x415650", Offset = "0x414450", VA = "0x10415650")]
    public bool IsWithinChallenge() => new bool();

    [Token(Token = "0x6007F1B")]
    [Address(RVA = "0x415130", Offset = "0x413F30", VA = "0x10415130")]
    public WorldRaidParam.BossInfo GetBossInfo(string wrb_iname) => (WorldRaidParam.BossInfo) null;

    [Token(Token = "0x6007F1C")]
    [Address(RVA = "0x414F90", Offset = "0x413D90", VA = "0x10414F90")]
    public static void Deserialize(ref List<WorldRaidParam> list, JSON_WorldRaidParam[] json)
    {
    }

    [Token(Token = "0x6007F1D")]
    [Address(RVA = "0x415200", Offset = "0x414000", VA = "0x10415200")]
    public static WorldRaidParam GetParam(string iname) => (WorldRaidParam) null;

    [Token(Token = "0x6007F1E")]
    [Address(RVA = "0x415470", Offset = "0x414270", VA = "0x10415470")]
    public bool IsNextTimeBossChallenge() => new bool();

    [Token(Token = "0x6007F1F")]
    [Address(RVA = "0x415310", Offset = "0x414110", VA = "0x10415310")]
    public bool IsChallengeTimelimited() => new bool();

    [Token(Token = "0x6007F20")]
    [Address(RVA = "0x4159F0", Offset = "0x4147F0", VA = "0x104159F0")]
    public WorldRaidParam()
    {
    }

    [Token(Token = "0x2001F13")]
    public enum eCostType
    {
      [Token(Token = "0x40082D8")] UseAp,
      [Token(Token = "0x40082D9")] UseBp,
    }

    [Token(Token = "0x2001F14")]
    public class BossInfo
    {
      [Token(Token = "0x40082DA")]
      [FieldOffset(Offset = "0x8")]
      private bool mIsLastBoss;
      [Token(Token = "0x40082DB")]
      [FieldOffset(Offset = "0xC")]
      private string mBossId;
      [Token(Token = "0x40082DC")]
      [FieldOffset(Offset = "0x10")]
      private WorldRaidBossParam mBossParam;
      [Token(Token = "0x40082DD")]
      [FieldOffset(Offset = "0x14")]
      private string mBeatRewardId;
      [Token(Token = "0x40082DE")]
      [FieldOffset(Offset = "0x18")]
      private string mLaRewardId;
      [Token(Token = "0x40082DF")]
      [FieldOffset(Offset = "0x1C")]
      private string mDmgRewardId;
      [Token(Token = "0x40082E0")]
      [FieldOffset(Offset = "0x20")]
      private WorldRaidDamageRewardParam mDmgRewardParam;
      [Token(Token = "0x40082E1")]
      [FieldOffset(Offset = "0x24")]
      private string mRankRewardId;
      [Token(Token = "0x40082E2")]
      [FieldOffset(Offset = "0x28")]
      private WorldRaidRankingRewardParam mRankRewardParam;
      [Token(Token = "0x40082E3")]
      [FieldOffset(Offset = "0x2C")]
      private string mBossBuffId;
      [Token(Token = "0x40082E4")]
      [FieldOffset(Offset = "0x30")]
      private BuffEffectParam mBossBuffParam;
      [Token(Token = "0x40082E5")]
      [FieldOffset(Offset = "0x34")]
      private int mMaxLapBuff;

      [Token(Token = "0x17001230")]
      public bool IsLastBoss
      {
        [Token(Token = "0x6007F21"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001231")]
      public string BossId
      {
        [Token(Token = "0x6007F22"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001232")]
      public WorldRaidBossParam BossParam
      {
        [Token(Token = "0x6007F23"), Address(RVA = "0x410EE0", Offset = "0x40FCE0", VA = "0x10410EE0")] get
        {
          return (WorldRaidBossParam) null;
        }
      }

      [Token(Token = "0x17001233")]
      public string BeatRewardId
      {
        [Token(Token = "0x6007F24"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6007F25")]
      [Address(RVA = "0x410D90", Offset = "0x40FB90", VA = "0x10410D90")]
      public WorldRaidRewardParam GetBeatRewardParam(int _lap) => (WorldRaidRewardParam) null;

      [Token(Token = "0x17001234")]
      public string LaRewardId
      {
        [Token(Token = "0x6007F26"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x6007F27")]
      [Address(RVA = "0x410DE0", Offset = "0x40FBE0", VA = "0x10410DE0")]
      public WorldRaidRewardParam LaRewardParam(int _lap) => (WorldRaidRewardParam) null;

      [Token(Token = "0x17001235")]
      public string DmgRewardId
      {
        [Token(Token = "0x6007F28"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001236")]
      public WorldRaidDamageRewardParam DmgRewardParam
      {
        [Token(Token = "0x6007F29"), Address(RVA = "0x411030", Offset = "0x40FE30", VA = "0x10411030")] get
        {
          return (WorldRaidDamageRewardParam) null;
        }
      }

      [Token(Token = "0x17001237")]
      public string RankRewardId
      {
        [Token(Token = "0x6007F2A"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17001238")]
      public WorldRaidRankingRewardParam RankRewardParam
      {
        [Token(Token = "0x6007F2B"), Address(RVA = "0x411180", Offset = "0x40FF80", VA = "0x10411180")] get
        {
          return (WorldRaidRankingRewardParam) null;
        }
      }

      [Token(Token = "0x17001239")]
      public string BossBuffId
      {
        [Token(Token = "0x6007F2C"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700123A")]
      public BuffEffectParam BossBuffParam
      {
        [Token(Token = "0x6007F2D"), Address(RVA = "0x410E30", Offset = "0x40FC30", VA = "0x10410E30")] get
        {
          return (BuffEffectParam) null;
        }
      }

      [Token(Token = "0x1700123B")]
      public int MaxLapBuff
      {
        [Token(Token = "0x6007F2E"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6007F2F")]
      [Address(RVA = "0x410D10", Offset = "0x40FB10", VA = "0x10410D10")]
      public void Deserialize(JSON_WorldRaidParam.BossInfo json)
      {
      }

      [Token(Token = "0x6007F30")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BossInfo()
      {
      }
    }
  }
}
