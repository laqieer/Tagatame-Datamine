// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRewardRound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B61")]
  public class GuildRaidRewardRound
  {
    [Token(Token = "0x17000D82")]
    public int Round
    {
      [Token(Token = "0x60070FF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007100"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000D83")]
    public string RewardId
    {
      [Token(Token = "0x6007101"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007102"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6007103")]
    [Address(RVA = "0x35F6F0", Offset = "0x35E4F0", VA = "0x1035F6F0")]
    public bool Deserialize(JSON_GuildRaidRewardRound json) => new bool();

    [Token(Token = "0x6007104")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidRewardRound()
    {
    }
  }
}
