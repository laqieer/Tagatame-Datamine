// Decompiled with JetBrains decompiler
// Type: SRPG.LogCondDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BEA")]
  public class LogCondDamage : BattleLog
  {
    [Token(Token = "0x4001E66")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001E67")]
    [FieldOffset(Offset = "0x10")]
    public EUnitCondition condition;
    [Token(Token = "0x4001E68")]
    [FieldOffset(Offset = "0x18")]
    public int damage;
    [Token(Token = "0x4001E69")]
    [FieldOffset(Offset = "0x1C")]
    public int mp_damage;
    [Token(Token = "0x4001E6A")]
    [FieldOffset(Offset = "0x20")]
    public Grid dead_grid;
    [Token(Token = "0x4001E6B")]
    [FieldOffset(Offset = "0x24")]
    public bool isRefreshEffect;
    [Token(Token = "0x4001E6C")]
    [FieldOffset(Offset = "0x28")]
    public List<LogCondDamage.Data> DamageList;

    [Token(Token = "0x6002FDA")]
    [Address(RVA = "0xFE58F0", Offset = "0xFE46F0", VA = "0x10FE58F0")]
    public void IsRefreshEffect()
    {
    }

    [Token(Token = "0x6002FDB")]
    [Address(RVA = "0xFE5900", Offset = "0xFE4700", VA = "0x10FE5900")]
    public LogCondDamage()
    {
    }

    [Token(Token = "0x2000BEB")]
    public class Data
    {
      [Token(Token = "0x4001E6D")]
      [FieldOffset(Offset = "0x8")]
      private Unit mFrom;
      [Token(Token = "0x4001E6E")]
      [FieldOffset(Offset = "0xC")]
      private int mDamage;
      [Token(Token = "0x4001E6F")]
      [FieldOffset(Offset = "0x10")]
      private int mMpDamage;

      [Token(Token = "0x170002CF")]
      public Unit From
      {
        [Token(Token = "0x6002FDC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (Unit) null;
        }
      }

      [Token(Token = "0x170002D0")]
      public int Damage
      {
        [Token(Token = "0x6002FDD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170002D1")]
      public int MpDamage
      {
        [Token(Token = "0x6002FDE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6002FDF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Data()
      {
      }

      [Token(Token = "0x6002FE0")]
      [Address(RVA = "0xFD2E00", Offset = "0xFD1C00", VA = "0x10FD2E00")]
      public Data(Unit unit, int damage, int mp_damage)
      {
      }

      [Token(Token = "0x6002FE1")]
      [Address(RVA = "0xFE4010", Offset = "0xFE2E10", VA = "0x10FE4010")]
      public void AddDamage(int add_damage, int add_mp_damage)
      {
      }
    }
  }
}
