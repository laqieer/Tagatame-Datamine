// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B5B")]
  public class GuildRaidRewardParam : GuildRaidMasterParam<JSON_GuildRaidRewardParam>
  {
    [Token(Token = "0x17000D7B")]
    public string Id
    {
      [Token(Token = "0x60070E8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60070E9"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000D7C")]
    public List<GuildRaidReward> Rewards
    {
      [Token(Token = "0x60070EA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GuildRaidReward>) null;
      }
      [Token(Token = "0x60070EB"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60070EC")]
    [Address(RVA = "0x370AB0", Offset = "0x36F8B0", VA = "0x10370AB0", Slot = "4")]
    public override bool Deserialize(JSON_GuildRaidRewardParam json) => new bool();

    [Token(Token = "0x60070ED")]
    [Address(RVA = "0x370C10", Offset = "0x36FA10", VA = "0x10370C10")]
    public GuildRaidRewardParam()
    {
    }
  }
}
