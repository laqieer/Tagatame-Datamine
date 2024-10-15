// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchSeasonParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BCA")]
  [MessagePackObject(true)]
  public class LeagueMatchSeasonParam
  {
    [Token(Token = "0x4006A66")]
    [FieldOffset(Offset = "0x8")]
    private int mSeasonId;
    [Token(Token = "0x4006A67")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mSeason_begin_at;
    [Token(Token = "0x4006A68")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mSeason_end_at;
    [Token(Token = "0x4006A69")]
    [FieldOffset(Offset = "0x20")]
    private LeagueMatchAttackScheduleParam[] mAttacks;
    [Token(Token = "0x4006A6A")]
    [FieldOffset(Offset = "0x28")]
    private DateTime mShow_ranking_begin_at;
    [Token(Token = "0x4006A6B")]
    [FieldOffset(Offset = "0x30")]
    private DateTime mRanking_begin_at;
    [Token(Token = "0x4006A6C")]
    [FieldOffset(Offset = "0x38")]
    private string mEvent_url;
    [Token(Token = "0x4006A6D")]
    [FieldOffset(Offset = "0x3C")]
    private string mShop_iname;
    [Token(Token = "0x4006A6E")]
    [FieldOffset(Offset = "0x40")]
    private string mLeaguematch_rank;
    [Token(Token = "0x4006A6F")]
    [FieldOffset(Offset = "0x44")]
    private string mLeaguematch_buff;
    [Token(Token = "0x4006A70")]
    [FieldOffset(Offset = "0x48")]
    private int mBuff_use_num;
    [Token(Token = "0x4006A71")]
    [FieldOffset(Offset = "0x4C")]
    private string mSetting_iname;

    [Token(Token = "0x17000E1D")]
    public int Season
    {
      [Token(Token = "0x60072B7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E1E")]
    public DateTime Season_begin_at
    {
      [Token(Token = "0x60072B8"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E1F")]
    public DateTime Season_end_at
    {
      [Token(Token = "0x60072B9"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E20")]
    public LeagueMatchAttackScheduleParam[] Attacks
    {
      [Token(Token = "0x60072BA"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (LeagueMatchAttackScheduleParam[]) null;
      }
    }

    [Token(Token = "0x17000E21")]
    public DateTime Show_ranking_begin_at
    {
      [Token(Token = "0x60072BB"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E22")]
    public DateTime Ranking_begin_at
    {
      [Token(Token = "0x60072BC"), Address(RVA = "0x32ED20", Offset = "0x32DB20", VA = "0x1032ED20")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E23")]
    public string Event_url
    {
      [Token(Token = "0x60072BD"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E24")]
    public string Shop_iname
    {
      [Token(Token = "0x60072BE"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E25")]
    public string Leaguematch_rank
    {
      [Token(Token = "0x60072BF"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E26")]
    public string Leaguematch_buff
    {
      [Token(Token = "0x60072C0"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E27")]
    public int Buff_use_num
    {
      [Token(Token = "0x60072C1"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E28")]
    public string Setting_iname
    {
      [Token(Token = "0x60072C2"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60072C3")]
    [Address(RVA = "0x37A2B0", Offset = "0x3790B0", VA = "0x1037A2B0")]
    public bool Deserialize(JSON_LeagueMatchSeasonParam json) => new bool();

    [Token(Token = "0x60072C4")]
    [Address(RVA = "0x37A0E0", Offset = "0x378EE0", VA = "0x1037A0E0")]
    public static bool Deserialize(
      ref List<LeagueMatchSeasonParam> paramList,
      JSON_LeagueMatchSeasonParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x60072C5")]
    [Address(RVA = "0x37A7F0", Offset = "0x3795F0", VA = "0x1037A7F0")]
    public bool IsSeasonWithinPeriod() => new bool();

    [Token(Token = "0x60072C6")]
    [Address(RVA = "0x37A5F0", Offset = "0x3793F0", VA = "0x1037A5F0")]
    public bool IsAttackWithinPeriod() => new bool();

    [Token(Token = "0x60072C7")]
    [Address(RVA = "0x379F90", Offset = "0x378D90", VA = "0x10379F90")]
    public string AttackTargetTime(int addDay, string format = "MM/dd") => (string) null;

    [Token(Token = "0x60072C8")]
    [Address(RVA = "0x37A8C0", Offset = "0x3796C0", VA = "0x1037A8C0")]
    public bool IsShowRankingScreen() => new bool();

    [Token(Token = "0x60072C9")]
    [Address(RVA = "0x37A720", Offset = "0x379520", VA = "0x1037A720")]
    public bool IsRankingWithinPeriod() => new bool();

    [Token(Token = "0x60072CA")]
    [Address(RVA = "0x37A950", Offset = "0x379750", VA = "0x1037A950")]
    public LeagueMatchSeasonParam()
    {
    }
  }
}
