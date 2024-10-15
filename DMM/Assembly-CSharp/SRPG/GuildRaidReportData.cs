// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidReportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FB8")]
  public class GuildRaidReportData
  {
    [Token(Token = "0x170005B3")]
    public int ReportId
    {
      [Token(Token = "0x6004123"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004124"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x170005B4")]
    public int BossId
    {
      [Token(Token = "0x6004125"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004126"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x170005B5")]
    public int Round
    {
      [Token(Token = "0x6004127"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004128"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x170005B6")]
    public int Damage
    {
      [Token(Token = "0x6004129"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x600412A"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x170005B7")]
    public DateTime PostedAt
    {
      [Token(Token = "0x600412B"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600412C"), Address(RVA = "0x372E10", Offset = "0x371C10", VA = "0x10372E10")] private set
      {
      }
    }

    [Token(Token = "0x170005B8")]
    public List<UnitData> Deck
    {
      [Token(Token = "0x600412D"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600412E"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x170005B9")]
    public int PeriodId
    {
      [Token(Token = "0x600412F"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x6004130"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x170005BA")]
    public bool CanPost
    {
      [Token(Token = "0x6004131"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004132"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] private set
      {
      }
    }

    [Token(Token = "0x6004133")]
    [Address(RVA = "0x1193080", Offset = "0x1191E80", VA = "0x11193080")]
    public void Deserialize(JSON_GuildRaidReport json, bool canPost = false)
    {
    }

    [Token(Token = "0x6004134")]
    [Address(RVA = "0x1193240", Offset = "0x1192040", VA = "0x11193240")]
    public void Deserialize(JSON_GuildRaidTrainingBattleLog json, bool canPost = false)
    {
    }

    [Token(Token = "0x6004135")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidReportData()
    {
    }
  }
}
