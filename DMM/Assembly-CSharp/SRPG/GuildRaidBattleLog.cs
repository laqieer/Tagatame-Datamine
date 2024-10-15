// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidBattleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FB7")]
  public class GuildRaidBattleLog
  {
    [Token(Token = "0x170005AF")]
    public string Message
    {
      [Token(Token = "0x6004119"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600411A"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x170005B0")]
    public int ReportId
    {
      [Token(Token = "0x600411B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600411C"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x170005B1")]
    public DateTime PostedAt
    {
      [Token(Token = "0x600411D"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600411E"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] private set
      {
      }
    }

    [Token(Token = "0x170005B2")]
    public int PeriodId
    {
      [Token(Token = "0x600411F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x6004120"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x6004121")]
    [Address(RVA = "0x11926B0", Offset = "0x11914B0", VA = "0x111926B0")]
    public bool Deserialize(JSON_GuildRaidBattleLog json) => new bool();

    [Token(Token = "0x6004122")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidBattleLog()
    {
    }
  }
}
