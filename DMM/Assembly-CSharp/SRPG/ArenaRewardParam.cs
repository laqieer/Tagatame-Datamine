// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200198B")]
  public class ArenaRewardParam
  {
    [Token(Token = "0x4005D14")]
    [FieldOffset(Offset = "0x8")]
    private int mRank;
    [Token(Token = "0x4005D15")]
    [FieldOffset(Offset = "0xC")]
    private int mCoin;
    [Token(Token = "0x4005D16")]
    [FieldOffset(Offset = "0x10")]
    private int mGold;
    [Token(Token = "0x4005D17")]
    [FieldOffset(Offset = "0x14")]
    private int mArenaCoin;
    [Token(Token = "0x4005D18")]
    [FieldOffset(Offset = "0x18")]
    private int mFrom;
    [Token(Token = "0x4005D19")]
    [FieldOffset(Offset = "0x1C")]
    private List<ArenaRewardParam.RewardItem> mItems;
    [Token(Token = "0x4005D1A")]
    [FieldOffset(Offset = "0x20")]
    private DateTime begin_at;
    [Token(Token = "0x4005D1B")]
    [FieldOffset(Offset = "0x28")]
    private DateTime end_at;

    [Token(Token = "0x17000AC6")]
    public int Rank
    {
      [Token(Token = "0x6006812"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AC7")]
    public int FromRank
    {
      [Token(Token = "0x6006813"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AC8")]
    public int Coin
    {
      [Token(Token = "0x6006814"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000AC9")]
    public int Gold
    {
      [Token(Token = "0x6006815"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ACA")]
    public int ArenaCoin
    {
      [Token(Token = "0x6006816"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000ACB")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6006817"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000ACC")]
    public DateTime EndAt
    {
      [Token(Token = "0x6006818"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000ACD")]
    public List<ArenaRewardParam.RewardItem> Items
    {
      [Token(Token = "0x6006819"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<ArenaRewardParam.RewardItem>) null;
      }
    }

    [Token(Token = "0x600681A")]
    [Address(RVA = "0x31F050", Offset = "0x31DE50", VA = "0x1031F050")]
    public static bool Deserialize(
      ref List<ArenaRewardParam> param_list,
      JSON_ArenaResult[] json_arena_results)
    {
      return new bool();
    }

    [Token(Token = "0x600681B")]
    [Address(RVA = "0x31F4D0", Offset = "0x31E2D0", VA = "0x1031F4D0")]
    public static List<ArenaRewardParam> GetSortedRewardParams(List<ArenaRewardParam> reward_params)
    {
      return (List<ArenaRewardParam>) null;
    }

    [Token(Token = "0x600681C")]
    [Address(RVA = "0x31F880", Offset = "0x31E680", VA = "0x1031F880")]
    public ArenaRewardParam()
    {
    }

    [Token(Token = "0x200198C")]
    public class RewardItem
    {
      [Token(Token = "0x4005D1C")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4005D1D")]
      [FieldOffset(Offset = "0xC")]
      public int num;

      [Token(Token = "0x600681D")]
      [Address(RVA = "0x32D280", Offset = "0x32C080", VA = "0x1032D280")]
      public RewardItem(string _iname, int _num)
      {
      }
    }
  }
}
