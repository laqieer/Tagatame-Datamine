// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FB9")]
  public class GuildRaidRanking
  {
    [Token(Token = "0x170005BB")]
    public int Rank
    {
      [Token(Token = "0x6004136"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004137"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x170005BC")]
    public long Score
    {
      [Token(Token = "0x6004138"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
      [Token(Token = "0x6004139"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] private set
      {
      }
    }

    [Token(Token = "0x170005BD")]
    public GuildRaidRankingGuild Guild
    {
      [Token(Token = "0x600413A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (GuildRaidRankingGuild) null;
      }
      [Token(Token = "0x600413B"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x600413C")]
    [Address(RVA = "0x1192FD0", Offset = "0x1191DD0", VA = "0x11192FD0")]
    public bool Deserialize(JSON_GuildRaidRanking json) => new bool();

    [Token(Token = "0x600413D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidRanking()
    {
    }
  }
}
