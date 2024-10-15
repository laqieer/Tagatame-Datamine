// Decompiled with JetBrains decompiler
// Type: SRPG.DuelSeasonParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ABC")]
  public class DuelSeasonParam
  {
    [Token(Token = "0x4006315")]
    [FieldOffset(Offset = "0x8")]
    private int mSeason;
    [Token(Token = "0x4006316")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mBeginAt;
    [Token(Token = "0x4006317")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEndAt;
    [Token(Token = "0x4006318")]
    [FieldOffset(Offset = "0x20")]
    private string mSeasonReward;
    [Token(Token = "0x4006319")]
    [FieldOffset(Offset = "0x24")]
    private string mDailyReward;
    [Token(Token = "0x400631A")]
    [FieldOffset(Offset = "0x28")]
    private string mWinReward;
    [Token(Token = "0x400631B")]
    [FieldOffset(Offset = "0x2C")]
    private string mLoseReward;
    [Token(Token = "0x400631C")]
    [FieldOffset(Offset = "0x30")]
    private DUEL_WIN_BONUS_TYPE mWinBonusType;
    [Token(Token = "0x400631D")]
    [FieldOffset(Offset = "0x34")]
    private string mChainWinReward;
    [Token(Token = "0x400631E")]
    [FieldOffset(Offset = "0x38")]
    private List<DuelBonusUnit> mBonusUnits;

    [Token(Token = "0x17000C59")]
    public int Season
    {
      [Token(Token = "0x6006E1F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C5A")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6006E20"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000C5B")]
    public DateTime EndAt
    {
      [Token(Token = "0x6006E21"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000C5C")]
    public string WinReward
    {
      [Token(Token = "0x6006E22"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C5D")]
    public string LoseReward
    {
      [Token(Token = "0x6006E23"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C5E")]
    public DUEL_WIN_BONUS_TYPE WinBonusType
    {
      [Token(Token = "0x6006E24"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new DUEL_WIN_BONUS_TYPE();
      }
    }

    [Token(Token = "0x17000C5F")]
    public string ChainWinReward
    {
      [Token(Token = "0x6006E25"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C60")]
    public List<DuelBonusUnit> BonusUnits
    {
      [Token(Token = "0x6006E26"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (List<DuelBonusUnit>) null;
      }
    }

    [Token(Token = "0x6006E27")]
    [Address(RVA = "0x360080", Offset = "0x35EE80", VA = "0x10360080")]
    public bool Deserialize(JSON_DuelSeasonParam json) => new bool();

    [Token(Token = "0x6006E28")]
    [Address(RVA = "0x360410", Offset = "0x35F210", VA = "0x10360410")]
    public static void Deserialize(ref DuelSeasonParam[] param, JSON_DuelSeasonParam[] json)
    {
    }

    [Token(Token = "0x6006E29")]
    [Address(RVA = "0x3605B0", Offset = "0x35F3B0", VA = "0x103605B0")]
    public DuelRankingRewardParam GetRankingReward_Daily() => (DuelRankingRewardParam) null;

    [Token(Token = "0x6006E2A")]
    [Address(RVA = "0x360650", Offset = "0x35F450", VA = "0x10360650")]
    public DuelRankingRewardParam GetRankingReward_Season() => (DuelRankingRewardParam) null;

    [Token(Token = "0x6006E2B")]
    [Address(RVA = "0x3606F0", Offset = "0x35F4F0", VA = "0x103606F0")]
    public bool IsCalcRankingNow() => new bool();

    [Token(Token = "0x6006E2C")]
    [Address(RVA = "0x3607E0", Offset = "0x35F5E0", VA = "0x103607E0")]
    public bool IsSeasonOutPeriod() => new bool();

    [Token(Token = "0x6006E2D")]
    [Address(RVA = "0x360930", Offset = "0x35F730", VA = "0x10360930")]
    public DuelSeasonParam()
    {
    }
  }
}
