// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRewardRoundParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B63")]
  public class GuildRaidRewardRoundParam : GuildRaidMasterParam<JSON_GuildRaidRewardRoundParam>
  {
    [Token(Token = "0x17000D84")]
    public string Id
    {
      [Token(Token = "0x6007106"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007107"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000D85")]
    public List<GuildRaidRewardRound> Reward
    {
      [Token(Token = "0x6007108"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GuildRaidRewardRound>) null;
      }
      [Token(Token = "0x6007109"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600710A")]
    [Address(RVA = "0x370DF0", Offset = "0x36FBF0", VA = "0x10370DF0", Slot = "4")]
    public override bool Deserialize(JSON_GuildRaidRewardRoundParam json) => new bool();

    [Token(Token = "0x600710B")]
    [Address(RVA = "0x370F50", Offset = "0x36FD50", VA = "0x10370F50")]
    public GuildRaidRewardRoundParam()
    {
    }
  }
}
