// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidRankingDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FBD")]
  public class GuildRaidRankingDamage
  {
    [Token(Token = "0x170005CA")]
    public int Role
    {
      [Token(Token = "0x600415C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600415D"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x170005CB")]
    public int Rank
    {
      [Token(Token = "0x600415E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600415F"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x170005CC")]
    public long Score
    {
      [Token(Token = "0x6004160"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
      [Token(Token = "0x6004161"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] private set
      {
      }
    }

    [Token(Token = "0x170005CD")]
    public string Name
    {
      [Token(Token = "0x6004162"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004163"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x170005CE")]
    public int Lv
    {
      [Token(Token = "0x6004164"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004165"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x170005CF")]
    public UnitParam Unit
    {
      [Token(Token = "0x6004166"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (UnitParam) null;
      }
      [Token(Token = "0x6004167"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x170005D0")]
    public int UnitStrengthTotal
    {
      [Token(Token = "0x6004168"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x6004169"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x170005D1")]
    public int BossId
    {
      [Token(Token = "0x600416A"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
      [Token(Token = "0x600416B"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] private set
      {
      }
    }

    [Token(Token = "0x170005D2")]
    public int Round
    {
      [Token(Token = "0x600416C"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600416D"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] private set
      {
      }
    }

    [Token(Token = "0x170005D3")]
    public DateTime KnockDownAt
    {
      [Token(Token = "0x600416E"), Address(RVA = "0x32ED20", Offset = "0x32DB20", VA = "0x1032ED20")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600416F"), Address(RVA = "0x305850", Offset = "0x304650", VA = "0x10305850")] private set
      {
      }
    }

    [Token(Token = "0x6004170")]
    [Address(RVA = "0x1192CD0", Offset = "0x1191AD0", VA = "0x11192CD0")]
    public bool Deserialize(JSON_GuildRaidRankingDamage json) => new bool();

    [Token(Token = "0x6004171")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidRankingDamage()
    {
    }
  }
}
