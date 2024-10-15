// Decompiled with JetBrains decompiler
// Type: SRPG.LogMapTrick
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BDB")]
  public class LogMapTrick : BattleLog
  {
    [Token(Token = "0x4001E0C")]
    [FieldOffset(Offset = "0x8")]
    public TrickData TrickData;
    [Token(Token = "0x4001E0D")]
    [FieldOffset(Offset = "0xC")]
    public List<LogMapTrick.TargetInfo> TargetInfoLists;

    [Token(Token = "0x6002FA8")]
    [Address(RVA = "0xFE5EF0", Offset = "0xFE4CF0", VA = "0x10FE5EF0")]
    public LogMapTrick()
    {
    }

    [Token(Token = "0x2000BDC")]
    public class TargetInfo
    {
      [Token(Token = "0x4001E0E")]
      [FieldOffset(Offset = "0x8")]
      public Unit Target;
      [Token(Token = "0x4001E0F")]
      [FieldOffset(Offset = "0xC")]
      public bool IsEffective;
      [Token(Token = "0x4001E10")]
      [FieldOffset(Offset = "0x10")]
      public int Heal;
      [Token(Token = "0x4001E11")]
      [FieldOffset(Offset = "0x14")]
      public int Damage;
      [Token(Token = "0x4001E12")]
      [FieldOffset(Offset = "0x18")]
      public EUnitCondition FailCondition;
      [Token(Token = "0x4001E13")]
      [FieldOffset(Offset = "0x20")]
      public EUnitCondition CureCondition;
      [Token(Token = "0x4001E14")]
      [FieldOffset(Offset = "0x28")]
      public Grid KnockBackGrid;

      [Token(Token = "0x6002FA9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TargetInfo()
      {
      }
    }
  }
}
