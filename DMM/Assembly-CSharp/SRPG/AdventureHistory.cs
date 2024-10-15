// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F8B")]
  public class AdventureHistory
  {
    [Token(Token = "0x4008539")]
    [FieldOffset(Offset = "0x8")]
    private List<UnitData> mUnitList;
    [Token(Token = "0x400853A")]
    [FieldOffset(Offset = "0xC")]
    private int mCombatPower;
    [Token(Token = "0x400853B")]
    [FieldOffset(Offset = "0x10")]
    private List<AdventureDrop> mDropList;
    [Token(Token = "0x400853C")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mCompleteTime;
    [Token(Token = "0x400853D")]
    [FieldOffset(Offset = "0x20")]
    private int mLevel;

    [Token(Token = "0x1700129E")]
    public List<UnitData> UnitList
    {
      [Token(Token = "0x6008194"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x1700129F")]
    public int CombatPower
    {
      [Token(Token = "0x6008195"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170012A0")]
    public List<AdventureDrop> DropList
    {
      [Token(Token = "0x6008196"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<AdventureDrop>) null;
      }
    }

    [Token(Token = "0x170012A1")]
    public DateTime CompleteTime
    {
      [Token(Token = "0x6008197"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x170012A2")]
    public int Level
    {
      [Token(Token = "0x6008198"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008199")]
    [Address(RVA = "0x4230C0", Offset = "0x421EC0", VA = "0x104230C0")]
    public bool Deserialize(JSON_AdventureHistory json) => new bool();

    [Token(Token = "0x600819A")]
    [Address(RVA = "0x423380", Offset = "0x422180", VA = "0x10423380")]
    public AdventureHistory()
    {
    }
  }
}
