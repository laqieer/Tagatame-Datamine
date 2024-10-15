// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRewardRankingDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B5D")]
  public class GuildRaidRewardRankingDataParam
  {
    [Token(Token = "0x17000D7D")]
    public int RankStart
    {
      [Token(Token = "0x60070EF"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60070F0"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000D7E")]
    public int RankEnd
    {
      [Token(Token = "0x60070F1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60070F2"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17000D7F")]
    public string RewardId
    {
      [Token(Token = "0x60070F3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60070F4"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x60070F5")]
    [Address(RVA = "0x3708D0", Offset = "0x36F6D0", VA = "0x103708D0")]
    public bool Deserialize(JSON_GuildRaidRewardRankingDataParam json) => new bool();

    [Token(Token = "0x60070F6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidRewardRankingDataParam()
    {
    }
  }
}
