// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRewardRankingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B5F")]
  public class GuildRaidRewardRankingParam : GuildRaidMasterParam<JSON_GuildRaidRewardRankingParam>
  {
    [Token(Token = "0x17000D80")]
    public string Id
    {
      [Token(Token = "0x60070F8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60070F9"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000D81")]
    public List<GuildRaidRewardRankingDataParam> Ranking
    {
      [Token(Token = "0x60070FA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GuildRaidRewardRankingDataParam>) null;
      }
      [Token(Token = "0x60070FB"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60070FC")]
    [Address(RVA = "0x370C50", Offset = "0x36FA50", VA = "0x10370C50", Slot = "4")]
    public override bool Deserialize(JSON_GuildRaidRewardRankingParam json) => new bool();

    [Token(Token = "0x60070FD")]
    [Address(RVA = "0x370DB0", Offset = "0x36FBB0", VA = "0x10370DB0")]
    public GuildRaidRewardRankingParam()
    {
    }
  }
}
