// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidCoolDaysParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B48")]
  public class GuildRaidCoolDaysParam : GuildRaidMasterParam<JSON_GuildRaidCoolDaysParam>
  {
    [Token(Token = "0x17000D57")]
    public int PeriodId
    {
      [Token(Token = "0x600707E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600707F"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000D58")]
    public List<DateTime> Schedule
    {
      [Token(Token = "0x6007080"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<DateTime>) null;
      }
      [Token(Token = "0x6007081"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6007082")]
    [Address(RVA = "0x36F660", Offset = "0x36E460", VA = "0x1036F660", Slot = "4")]
    public override bool Deserialize(JSON_GuildRaidCoolDaysParam json) => new bool();

    [Token(Token = "0x6007083")]
    [Address(RVA = "0x36F800", Offset = "0x36E600", VA = "0x1036F800")]
    public bool GetCoolDays() => new bool();

    [Token(Token = "0x6007084")]
    [Address(RVA = "0x36FA20", Offset = "0x36E820", VA = "0x1036FA20")]
    public GuildRaidCoolDaysParam()
    {
    }
  }
}
