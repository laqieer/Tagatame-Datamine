// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B32")]
  public class GuildTrainingUnit
  {
    [Token(Token = "0x4006798")]
    [FieldOffset(Offset = "0x8")]
    private string mUnitIname;
    [Token(Token = "0x4006799")]
    [FieldOffset(Offset = "0x10")]
    private TimeSpan mTrainingTime;
    [Token(Token = "0x400679A")]
    [FieldOffset(Offset = "0x18")]
    private GuildTrainingUnitPeriod[] mPeriods;

    [Token(Token = "0x17000D25")]
    public string UnitIname
    {
      [Token(Token = "0x6007013"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D26")]
    public TimeSpan TrainingTime
    {
      [Token(Token = "0x6007014"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new TimeSpan();
      }
    }

    [Token(Token = "0x17000D27")]
    public GuildTrainingUnitPeriod[] Periods
    {
      [Token(Token = "0x6007015"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (GuildTrainingUnitPeriod[]) null;
      }
    }

    [Token(Token = "0x6007016")]
    [Address(RVA = "0x3723D0", Offset = "0x3711D0", VA = "0x103723D0")]
    public bool Deserialize(JSON_GuildTrainingUnit json) => new bool();

    [Token(Token = "0x6007017")]
    [Address(RVA = "0x372750", Offset = "0x371550", VA = "0x10372750")]
    public static void Deserialize(ref List<GuildTrainingUnit> param, JSON_GuildTrainingUnit[] json)
    {
    }

    [Token(Token = "0x6007018")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildTrainingUnit()
    {
    }
  }
}
