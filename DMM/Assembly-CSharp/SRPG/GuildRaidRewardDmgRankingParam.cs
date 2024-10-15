// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRewardDmgRankingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B53")]
  public class GuildRaidRewardDmgRankingParam : 
    GuildRaidMasterParam<JSON_GuildRaidRewardDmgRankingParam>
  {
    [Token(Token = "0x17000D72")]
    public string Id
    {
      [Token(Token = "0x60070CA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60070CB"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000D73")]
    public List<GuildRaidRewardDmgRankingRankParam> Ranking
    {
      [Token(Token = "0x60070CC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GuildRaidRewardDmgRankingRankParam>) null;
      }
      [Token(Token = "0x60070CD"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60070CE")]
    [Address(RVA = "0x370730", Offset = "0x36F530", VA = "0x10370730", Slot = "4")]
    public override bool Deserialize(JSON_GuildRaidRewardDmgRankingParam json) => new bool();

    [Token(Token = "0x60070CF")]
    [Address(RVA = "0x370890", Offset = "0x36F690", VA = "0x10370890")]
    public GuildRaidRewardDmgRankingParam()
    {
    }
  }
}
