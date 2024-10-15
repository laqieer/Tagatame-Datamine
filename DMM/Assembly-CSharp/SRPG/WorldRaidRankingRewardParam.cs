// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidRankingRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F19")]
  public class WorldRaidRankingRewardParam
  {
    [Token(Token = "0x40082ED")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40082EE")]
    [FieldOffset(Offset = "0xC")]
    private WorldRaidRankingRewardParam.Reward[] mRewards;

    [Token(Token = "0x1700123C")]
    public string Iname
    {
      [Token(Token = "0x6007F37"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700123D")]
    public List<WorldRaidRankingRewardParam.Reward> RewardList
    {
      [Token(Token = "0x6007F38"), Address(RVA = "0x415E40", Offset = "0x414C40", VA = "0x10415E40")] get
      {
        return (List<WorldRaidRankingRewardParam.Reward>) null;
      }
    }

    [Token(Token = "0x6007F39")]
    [Address(RVA = "0x415BA0", Offset = "0x4149A0", VA = "0x10415BA0")]
    public void Deserialize(JSON_WorldRaidRankingRewardParam json)
    {
    }

    [Token(Token = "0x6007F3A")]
    [Address(RVA = "0x415A60", Offset = "0x414860", VA = "0x10415A60")]
    public static void Deserialize(
      ref List<WorldRaidRankingRewardParam> list,
      JSON_WorldRaidRankingRewardParam[] json)
    {
    }

    [Token(Token = "0x6007F3B")]
    [Address(RVA = "0x415D30", Offset = "0x414B30", VA = "0x10415D30")]
    public static WorldRaidRankingRewardParam GetParam(string iname)
    {
      return (WorldRaidRankingRewardParam) null;
    }

    [Token(Token = "0x6007F3C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidRankingRewardParam()
    {
    }

    [Token(Token = "0x2001F1A")]
    public class Reward
    {
      [Token(Token = "0x40082F2")]
      [FieldOffset(Offset = "0x14")]
      private WorldRaidRewardParam mRewardParam;

      [Token(Token = "0x1700123E")]
      public int RankBegin
      {
        [Token(Token = "0x6007F3D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007F3E"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x1700123F")]
      public int RankEnd
      {
        [Token(Token = "0x6007F3F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007F40"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x17001240")]
      public string RewardId
      {
        [Token(Token = "0x6007F41"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6007F42"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
        {
        }
      }

      [Token(Token = "0x17001241")]
      public WorldRaidRewardParam RewardParam
      {
        [Token(Token = "0x6007F43"), Address(RVA = "0x4117D0", Offset = "0x4105D0", VA = "0x104117D0")] get
        {
          return (WorldRaidRewardParam) null;
        }
      }

      [Token(Token = "0x6007F44")]
      [Address(RVA = "0x411490", Offset = "0x410290", VA = "0x10411490")]
      public WorldRaidRewardParam GetRewardParam(int lap) => (WorldRaidRewardParam) null;

      [Token(Token = "0x6007F45")]
      [Address(RVA = "0x39D030", Offset = "0x39BE30", VA = "0x1039D030")]
      public void Deserialize(JSON_WorldRaidRankingRewardParam.Reward json)
      {
      }

      [Token(Token = "0x6007F46")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}
