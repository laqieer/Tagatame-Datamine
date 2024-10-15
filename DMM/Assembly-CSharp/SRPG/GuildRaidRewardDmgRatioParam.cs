// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRewardDmgRatioParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B57")]
  public class GuildRaidRewardDmgRatioParam : GuildRaidMasterParam<JSON_GuildRaidRewardDmgRatioParam>
  {
    [Token(Token = "0x17000D76")]
    public string Id
    {
      [Token(Token = "0x60070D8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60070D9"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000D77")]
    public List<GuildRaidRewardDmgRatio> Reward
    {
      [Token(Token = "0x60070DA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GuildRaidRewardDmgRatio>) null;
      }
      [Token(Token = "0x60070DB"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60070DC")]
    [Address(RVA = "0x370910", Offset = "0x36F710", VA = "0x10370910", Slot = "4")]
    public override bool Deserialize(JSON_GuildRaidRewardDmgRatioParam json) => new bool();

    [Token(Token = "0x60070DD")]
    [Address(RVA = "0x370A70", Offset = "0x36F870", VA = "0x10370A70")]
    public GuildRaidRewardDmgRatioParam()
    {
    }
  }
}
