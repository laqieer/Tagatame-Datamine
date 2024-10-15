// Decompiled with JetBrains decompiler
// Type: SRPG.ShamBattleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200119E")]
  public class ShamBattleData
  {
    [Token(Token = "0x4003FFA")]
    [FieldOffset(Offset = "0x8")]
    public string MapIname;
    [Token(Token = "0x4003FFB")]
    [FieldOffset(Offset = "0xC")]
    public string[] Buffs;
    [Token(Token = "0x4003FFC")]
    [FieldOffset(Offset = "0x10")]
    public JSON_LeagueMatchSet[] DefensePlacements;
    [Token(Token = "0x4003FFD")]
    [FieldOffset(Offset = "0x14")]
    public JSON_LeagueMatchSet[] OffensePlacements;
    [Token(Token = "0x4003FFE")]
    [FieldOffset(Offset = "0x18")]
    public List<UnitData> OffenseUnits;
    [Token(Token = "0x4003FFF")]
    [FieldOffset(Offset = "0x1C")]
    public List<UnitData> DefenseUnits;
    [Token(Token = "0x4004000")]
    [FieldOffset(Offset = "0x20")]
    public bool IsHistoryBattle;
    [Token(Token = "0x4004001")]
    [FieldOffset(Offset = "0x21")]
    public bool IsBattleStart;
    [Token(Token = "0x4004002")]
    [FieldOffset(Offset = "0x22")]
    public bool IsReBattle;

    [Token(Token = "0x6004B18")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ShamBattleData()
    {
    }
  }
}
