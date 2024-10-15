// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchRankClassParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BC3")]
  [MessagePackObject(true)]
  public class LeagueMatchRankClassParam
  {
    [Token(Token = "0x4006A44")]
    [FieldOffset(Offset = "0x8")]
    private int mRank_class_id;
    [Token(Token = "0x4006A45")]
    [FieldOffset(Offset = "0xC")]
    private string mRank_class;
    [Token(Token = "0x4006A46")]
    [FieldOffset(Offset = "0x10")]
    private int mMin_rank_rate;
    [Token(Token = "0x4006A47")]
    [FieldOffset(Offset = "0x14")]
    private int mMax_rank_rate;
    [Token(Token = "0x4006A48")]
    [FieldOffset(Offset = "0x18")]
    private int mMin_rate;
    [Token(Token = "0x4006A49")]
    [FieldOffset(Offset = "0x1C")]
    private int mMax_rate;
    [Token(Token = "0x4006A4A")]
    [FieldOffset(Offset = "0x20")]
    private string mReward_iname;
    [Token(Token = "0x4006A4B")]
    [FieldOffset(Offset = "0x24")]
    private int mDefense_win_point;
    [Token(Token = "0x4006A4C")]
    [FieldOffset(Offset = "0x28")]
    private int mDefense_lose_point;
    [Token(Token = "0x4006A4D")]
    [FieldOffset(Offset = "0x2C")]
    private int[] mAttack_win_points;

    [Token(Token = "0x17000E0E")]
    public int Rank_class_id
    {
      [Token(Token = "0x600729D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E0F")]
    public string Rank_class
    {
      [Token(Token = "0x600729E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E10")]
    public int Min_rank_rate
    {
      [Token(Token = "0x600729F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E11")]
    public int Max_rank_rate
    {
      [Token(Token = "0x60072A0"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E12")]
    public int Min_rate
    {
      [Token(Token = "0x60072A1"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E13")]
    public int Max_rate
    {
      [Token(Token = "0x60072A2"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E14")]
    public string Reward_iname
    {
      [Token(Token = "0x60072A3"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E15")]
    public int Defense_win_point
    {
      [Token(Token = "0x60072A4"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E16")]
    public int Defense_lose_point
    {
      [Token(Token = "0x60072A5"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E17")]
    public int[] Attack_win_points
    {
      [Token(Token = "0x60072A6"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x60072A7")]
    [Address(RVA = "0x3797A0", Offset = "0x3785A0", VA = "0x103797A0")]
    public bool Deserialize(JSON_LeagueMatchRankClassParam json) => new bool();

    [Token(Token = "0x60072A8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchRankClassParam()
    {
    }
  }
}
