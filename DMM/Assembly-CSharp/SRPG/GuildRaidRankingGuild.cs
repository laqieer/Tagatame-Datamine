// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRankingGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FBA")]
  public class GuildRaidRankingGuild : ViewGuildData
  {
    [Token(Token = "0x170005BE")]
    public int MemberCount
    {
      [Token(Token = "0x600413E"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600413F"), Address(RVA = "0x373930", Offset = "0x372730", VA = "0x10373930")] private set
      {
      }
    }

    [Token(Token = "0x170005BF")]
    public int MemberMax
    {
      [Token(Token = "0x6004140"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
      [Token(Token = "0x6004141"), Address(RVA = "0x49D280", Offset = "0x49C080", VA = "0x1049D280")] private set
      {
      }
    }

    [Token(Token = "0x6004142")]
    [Address(RVA = "0x1192DD0", Offset = "0x1191BD0", VA = "0x11192DD0")]
    public bool Deserialize(JSON_GuildRaidRankingGuild json) => new bool();

    [Token(Token = "0x6004143")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidRankingGuild()
    {
    }
  }
}
