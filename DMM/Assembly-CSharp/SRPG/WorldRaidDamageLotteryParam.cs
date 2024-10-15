// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidDamageLotteryParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F03")]
  public class WorldRaidDamageLotteryParam
  {
    [Token(Token = "0x400828E")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400828F")]
    [FieldOffset(Offset = "0xC")]
    private WorldRaidDamageLotteryParam.Reward[] mRewards;

    [Token(Token = "0x1700120E")]
    public string Iname
    {
      [Token(Token = "0x6007EC9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700120F")]
    public List<WorldRaidDamageLotteryParam.Reward> RewardList
    {
      [Token(Token = "0x6007ECA"), Address(RVA = "0x413E90", Offset = "0x412C90", VA = "0x10413E90")] get
      {
        return (List<WorldRaidDamageLotteryParam.Reward>) null;
      }
    }

    [Token(Token = "0x6007ECB")]
    [Address(RVA = "0x413AA0", Offset = "0x4128A0", VA = "0x10413AA0")]
    public void Deserialize(JSON_WorldRaidDamageLotteryParam json)
    {
    }

    [Token(Token = "0x6007ECC")]
    [Address(RVA = "0x413C40", Offset = "0x412A40", VA = "0x10413C40")]
    public static void Deserialize(
      ref List<WorldRaidDamageLotteryParam> list,
      JSON_WorldRaidDamageLotteryParam[] json)
    {
    }

    [Token(Token = "0x6007ECD")]
    [Address(RVA = "0x413D80", Offset = "0x412B80", VA = "0x10413D80")]
    public static WorldRaidDamageLotteryParam GetParam(string iname)
    {
      return (WorldRaidDamageLotteryParam) null;
    }

    [Token(Token = "0x6007ECE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidDamageLotteryParam()
    {
    }

    [Token(Token = "0x2001F04")]
    public class Reward
    {
      [Token(Token = "0x4008294")]
      [FieldOffset(Offset = "0x18")]
      private ItemParam mItemParam;

      [Token(Token = "0x17001210")]
      public int Weight
      {
        [Token(Token = "0x6007ECF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007ED0"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x17001211")]
      public int ItemType
      {
        [Token(Token = "0x6007ED1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007ED2"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
        {
        }
      }

      [Token(Token = "0x17001212")]
      public string ItemIname
      {
        [Token(Token = "0x6007ED3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6007ED4"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
        {
        }
      }

      [Token(Token = "0x17001213")]
      public int ItemNum
      {
        [Token(Token = "0x6007ED5"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x6007ED6"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
        {
        }
      }

      [Token(Token = "0x17001214")]
      public ItemParam ItemParam
      {
        [Token(Token = "0x6007ED7"), Address(RVA = "0x411600", Offset = "0x410400", VA = "0x10411600")] get
        {
          return (ItemParam) null;
        }
      }

      [Token(Token = "0x6007ED8")]
      [Address(RVA = "0x35CD90", Offset = "0x35BB90", VA = "0x1035CD90")]
      public void Deserialize(JSON_WorldRaidDamageLotteryParam.Reward json)
      {
      }

      [Token(Token = "0x6007ED9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}
