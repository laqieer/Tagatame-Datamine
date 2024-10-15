// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidLapRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F0D")]
  public class WorldRaidLapRewardParam
  {
    [Token(Token = "0x40082A9")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40082AA")]
    [FieldOffset(Offset = "0xC")]
    private List<WorldRaidLapRewardParam.Reward> mRewards;

    [Token(Token = "0x1700121C")]
    public string Iname
    {
      [Token(Token = "0x6007EF3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700121D")]
    public List<WorldRaidLapRewardParam.Reward> Rewards
    {
      [Token(Token = "0x6007EF4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<WorldRaidLapRewardParam.Reward>) null;
      }
    }

    [Token(Token = "0x6007EF5")]
    [Address(RVA = "0x4143C0", Offset = "0x4131C0", VA = "0x104143C0")]
    public void Deserialize(JSON_WorldRaidLapRewardParam _json)
    {
    }

    [Token(Token = "0x6007EF6")]
    [Address(RVA = "0x414530", Offset = "0x413330", VA = "0x10414530")]
    public static void Deserialize(
      ref List<WorldRaidLapRewardParam> _list,
      JSON_WorldRaidLapRewardParam[] _json)
    {
    }

    [Token(Token = "0x6007EF7")]
    [Address(RVA = "0x414900", Offset = "0x413700", VA = "0x10414900")]
    public string GetRewardIname(int _lap) => (string) null;

    [Token(Token = "0x6007EF8")]
    [Address(RVA = "0x4147E0", Offset = "0x4135E0", VA = "0x104147E0")]
    public static WorldRaidLapRewardParam GetParam(string _iname) => (WorldRaidLapRewardParam) null;

    [Token(Token = "0x6007EF9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidLapRewardParam()
    {
    }

    [Token(Token = "0x2001F0E")]
    public class Reward
    {
      [Token(Token = "0x1700121E")]
      public int LapMin
      {
        [Token(Token = "0x6007EFA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007EFB"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x1700121F")]
      public int LapMax
      {
        [Token(Token = "0x6007EFC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007EFD"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x17001220")]
      public string RewardId
      {
        [Token(Token = "0x6007EFE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6007EFF"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
        {
        }
      }

      [Token(Token = "0x6007F00")]
      [Address(RVA = "0x411450", Offset = "0x410250", VA = "0x10411450")]
      public void Deserialize(JSON_WorldRaidLapRewardParam.Reward _json)
      {
      }

      [Token(Token = "0x6007F01")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}
