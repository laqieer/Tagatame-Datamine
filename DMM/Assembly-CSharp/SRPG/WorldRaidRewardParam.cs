// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F1E")]
  public class WorldRaidRewardParam
  {
    [Token(Token = "0x40082F9")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40082FA")]
    [FieldOffset(Offset = "0xC")]
    private WorldRaidRewardParam.Reward[] mRewards;

    [Token(Token = "0x17001242")]
    public string Iname
    {
      [Token(Token = "0x6007F4B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001243")]
    public List<WorldRaidRewardParam.Reward> RewardList
    {
      [Token(Token = "0x6007F4C"), Address(RVA = "0x4162D0", Offset = "0x4150D0", VA = "0x104162D0")] get
      {
        return (List<WorldRaidRewardParam.Reward>) null;
      }
    }

    [Token(Token = "0x6007F4D")]
    [Address(RVA = "0x416020", Offset = "0x414E20", VA = "0x10416020")]
    public void Deserialize(JSON_WorldRaidRewardParam json)
    {
    }

    [Token(Token = "0x6007F4E")]
    [Address(RVA = "0x415EE0", Offset = "0x414CE0", VA = "0x10415EE0")]
    public static void Deserialize(
      ref List<WorldRaidRewardParam> list,
      JSON_WorldRaidRewardParam[] json)
    {
    }

    [Token(Token = "0x6007F4F")]
    [Address(RVA = "0x4161C0", Offset = "0x414FC0", VA = "0x104161C0")]
    public static WorldRaidRewardParam GetParam(string iname) => (WorldRaidRewardParam) null;

    [Token(Token = "0x6007F50")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WorldRaidRewardParam()
    {
    }

    [Token(Token = "0x2001F1F")]
    public class Reward
    {
      [Token(Token = "0x40082FE")]
      [FieldOffset(Offset = "0x14")]
      private ItemParam mItemParam;

      [Token(Token = "0x17001244")]
      public int ItemType
      {
        [Token(Token = "0x6007F51"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007F52"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x17001245")]
      public string ItemIname
      {
        [Token(Token = "0x6007F53"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6007F54"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
        {
        }
      }

      [Token(Token = "0x17001246")]
      public int ItemNum
      {
        [Token(Token = "0x6007F55"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x6007F56"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
        {
        }
      }

      [Token(Token = "0x17001247")]
      public ItemParam ItemParam
      {
        [Token(Token = "0x6007F57"), Address(RVA = "0x411580", Offset = "0x410380", VA = "0x10411580")] get
        {
          return (ItemParam) null;
        }
      }

      [Token(Token = "0x6007F58")]
      [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
      public void Deserialize(JSON_WorldRaidRewardParam.Reward json)
      {
      }

      [Token(Token = "0x6007F59")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}
