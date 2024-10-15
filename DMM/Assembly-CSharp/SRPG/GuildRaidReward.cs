// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B59")]
  public class GuildRaidReward
  {
    [Token(Token = "0x17000D78")]
    public RaidRewardType Type
    {
      [Token(Token = "0x60070DF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RaidRewardType();
      }
      [Token(Token = "0x60070E0"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000D79")]
    public string IName
    {
      [Token(Token = "0x60070E1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60070E2"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000D7A")]
    public int Num
    {
      [Token(Token = "0x60070E3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60070E4"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x60070E5")]
    [Address(RVA = "0x3569E0", Offset = "0x3557E0", VA = "0x103569E0")]
    public bool Deserialize(JSON_GuildRaidReward json) => new bool();

    [Token(Token = "0x60070E6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidReward()
    {
    }
  }
}
