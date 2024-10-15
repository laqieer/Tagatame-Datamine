// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceLapBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200195D")]
  public class AdvanceLapBossParam
  {
    [Token(Token = "0x4005C59")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4005C5A")]
    [FieldOffset(Offset = "0xC")]
    private int mRoundBuffMax;
    [Token(Token = "0x4005C5B")]
    [FieldOffset(Offset = "0x10")]
    private string mBossBuffId;
    [Token(Token = "0x4005C5C")]
    [FieldOffset(Offset = "0x14")]
    private string mOtherBuffId;
    [Token(Token = "0x4005C5D")]
    [FieldOffset(Offset = "0x18")]
    private AdvanceLapBossParam.LapInfo[] mLapInfo;
    [Token(Token = "0x4005C5E")]
    [FieldOffset(Offset = "0x1C")]
    private BuffEffectParam mBossBuffParam;
    [Token(Token = "0x4005C5F")]
    [FieldOffset(Offset = "0x20")]
    private BuffEffectParam mOtherBuffParam;

    [Token(Token = "0x17000A85")]
    public string Iname
    {
      [Token(Token = "0x6006771"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A86")]
    public int RoundBuffMax
    {
      [Token(Token = "0x6006772"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A87")]
    public string BossBuffId
    {
      [Token(Token = "0x6006773"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A88")]
    public BuffEffectParam BossBuffParam
    {
      [Token(Token = "0x6006774"), Address(RVA = "0x31AD80", Offset = "0x319B80", VA = "0x1031AD80")] get
      {
        return (BuffEffectParam) null;
      }
    }

    [Token(Token = "0x17000A89")]
    public string OtherBuffId
    {
      [Token(Token = "0x6006775"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A8A")]
    public BuffEffectParam OtherBuffParam
    {
      [Token(Token = "0x6006776"), Address(RVA = "0x31AEC0", Offset = "0x319CC0", VA = "0x1031AEC0")] get
      {
        return (BuffEffectParam) null;
      }
    }

    [Token(Token = "0x17000A8B")]
    public List<AdvanceLapBossParam.LapInfo> LapInfoList
    {
      [Token(Token = "0x6006777"), Address(RVA = "0x31AE20", Offset = "0x319C20", VA = "0x1031AE20")] get
      {
        return (List<AdvanceLapBossParam.LapInfo>) null;
      }
    }

    [Token(Token = "0x6006778")]
    [Address(RVA = "0x31A9A0", Offset = "0x3197A0", VA = "0x1031A9A0")]
    public void Deserialize(JSON_AdvanceLapBossParam json)
    {
    }

    [Token(Token = "0x6006779")]
    [Address(RVA = "0x31AC80", Offset = "0x319A80", VA = "0x1031AC80")]
    public AdvanceRewardParam GetRoundReward(int round) => (AdvanceRewardParam) null;

    [Token(Token = "0x600677A")]
    [Address(RVA = "0x31AB40", Offset = "0x319940", VA = "0x1031AB40")]
    public static void Deserialize(
      ref List<AdvanceLapBossParam> list,
      JSON_AdvanceLapBossParam[] json)
    {
    }

    [Token(Token = "0x600677B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdvanceLapBossParam()
    {
    }

    [Token(Token = "0x200195E")]
    public class LapInfo
    {
      [Token(Token = "0x4005C60")]
      [FieldOffset(Offset = "0x8")]
      private int mRound;
      [Token(Token = "0x4005C61")]
      [FieldOffset(Offset = "0xC")]
      private string mRewardId;
      [Token(Token = "0x4005C62")]
      [FieldOffset(Offset = "0x10")]
      private AdvanceRewardParam mReward;

      [Token(Token = "0x17000A8C")]
      public int Round
      {
        [Token(Token = "0x600677C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17000A8D")]
      public string RewardId
      {
        [Token(Token = "0x600677D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17000A8E")]
      public AdvanceRewardParam Reward
      {
        [Token(Token = "0x600677E"), Address(RVA = "0x321730", Offset = "0x320530", VA = "0x10321730")] get
        {
          return (AdvanceRewardParam) null;
        }
      }

      [Token(Token = "0x600677F")]
      [Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x1031B680")]
      public void Deserialize(JSON_AdvanceLapBossParam.LapInfo json)
      {
      }

      [Token(Token = "0x6006780")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LapInfo()
      {
      }
    }
  }
}
