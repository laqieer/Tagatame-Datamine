// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidDamageRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F08")]
  public class WorldRaidDamageRewardParam
  {
    [Token(Token = "0x400829C")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400829D")]
    [FieldOffset(Offset = "0xC")]
    private WorldRaidDamageRewardParam.Reward[] mRewards;

    [Token(Token = "0x17001215")]
    public string Iname
    {
      [Token(Token = "0x6007EDE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001216")]
    public List<WorldRaidDamageRewardParam.Reward> RewardList
    {
      [Token(Token = "0x6007EDF"), Address(RVA = "0x414320", Offset = "0x413120", VA = "0x10414320")] get
      {
        return (List<WorldRaidDamageRewardParam.Reward>) null;
      }
    }

    [Token(Token = "0x6007EE0")]
    [Address(RVA = "0x413F30", Offset = "0x412D30", VA = "0x10413F30")]
    public void Deserialize(JSON_WorldRaidDamageRewardParam json)
    {
    }

    [Token(Token = "0x6007EE1")]
    [Address(RVA = "0x4140D0", Offset = "0x412ED0", VA = "0x104140D0")]
    public static void Deserialize(
      ref List<WorldRaidDamageRewardParam> list,
      JSON_WorldRaidDamageRewardParam[] json)
    {
    }

    [Token(Token = "0x6007EE2")]
    [Address(RVA = "0x414210", Offset = "0x413010", VA = "0x10414210")]
    public static WorldRaidDamageRewardParam GetParam(string iname)
    {
      return (WorldRaidDamageRewardParam) null;
    }

    [Token(Token = "0x6007EE3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidDamageRewardParam()
    {
    }

    [Token(Token = "0x2001F09")]
    public class Reward
    {
      [Token(Token = "0x40082A2")]
      [FieldOffset(Offset = "0x18")]
      private WorldRaidDamageLotteryParam mLotteryParam;

      [Token(Token = "0x17001217")]
      public int DmgMin
      {
        [Token(Token = "0x6007EE4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007EE5"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x17001218")]
      public int DmgMax
      {
        [Token(Token = "0x6007EE6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007EE7"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x17001219")]
      public string LotteryId
      {
        [Token(Token = "0x6007EE8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6007EE9"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
        {
        }
      }

      [Token(Token = "0x1700121A")]
      public int EffIdx
      {
        [Token(Token = "0x6007EEA"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x6007EEB"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
        {
        }
      }

      [Token(Token = "0x1700121B")]
      public WorldRaidDamageLotteryParam LotteryParam
      {
        [Token(Token = "0x6007EEC"), Address(RVA = "0x411680", Offset = "0x410480", VA = "0x10411680")] get
        {
          return (WorldRaidDamageLotteryParam) null;
        }
      }

      [Token(Token = "0x6007EED")]
      [Address(RVA = "0x35CD90", Offset = "0x35BB90", VA = "0x1035CD90")]
      public void Deserialize(JSON_WorldRaidDamageRewardParam.Reward json)
      {
      }

      [Token(Token = "0x6007EEE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}
