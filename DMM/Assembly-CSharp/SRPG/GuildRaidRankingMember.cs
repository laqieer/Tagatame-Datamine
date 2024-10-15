// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRankingMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FBB")]
  public class GuildRaidRankingMember
  {
    [Token(Token = "0x170005C0")]
    public int Role
    {
      [Token(Token = "0x6004144"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004145"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x170005C1")]
    public int Rank
    {
      [Token(Token = "0x6004146"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004147"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x170005C2")]
    public long Score
    {
      [Token(Token = "0x6004148"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
      [Token(Token = "0x6004149"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] private set
      {
      }
    }

    [Token(Token = "0x170005C3")]
    public string Name
    {
      [Token(Token = "0x600414A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600414B"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x170005C4")]
    public int Lv
    {
      [Token(Token = "0x600414C"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600414D"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x170005C5")]
    public UnitParam Unit
    {
      [Token(Token = "0x600414E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (UnitParam) null;
      }
      [Token(Token = "0x600414F"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x170005C6")]
    public int UnitStrengthTotal
    {
      [Token(Token = "0x6004150"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x6004151"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x170005C7")]
    public List<GuildRaidRankingMemberBoss> Bosses
    {
      [Token(Token = "0x6004152"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<GuildRaidRankingMemberBoss>) null;
      }
      [Token(Token = "0x6004153"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x6004154")]
    [Address(RVA = "0x1192E10", Offset = "0x1191C10", VA = "0x11192E10")]
    public bool Deserialize(JSON_GuildRaidRankingMember json) => new bool();

    [Token(Token = "0x6004155")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidRankingMember()
    {
    }
  }
}
