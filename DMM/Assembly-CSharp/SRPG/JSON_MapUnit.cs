// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MapUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BFF")]
  public class JSON_MapUnit
  {
    [Token(Token = "0x4001EA1")]
    [FieldOffset(Offset = "0x8")]
    public JSON_MapPartyUnit[] party;
    [Token(Token = "0x4001EA2")]
    [FieldOffset(Offset = "0xC")]
    public JSON_MapEnemyUnit[] enemy;
    [Token(Token = "0x4001EA3")]
    [FieldOffset(Offset = "0x10")]
    public JSON_MapPartyUnit[] arena;
    [Token(Token = "0x4001EA4")]
    [FieldOffset(Offset = "0x14")]
    public JSON_QuestMonitorCondition w_cond;
    [Token(Token = "0x4001EA5")]
    [FieldOffset(Offset = "0x18")]
    public JSON_QuestMonitorCondition l_cond;
    [Token(Token = "0x4001EA6")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_GimmickEvent[] gs;
    [Token(Token = "0x4001EA7")]
    [FieldOffset(Offset = "0x20")]
    public JSON_MapEnemyUnit[] deck;
    [Token(Token = "0x4001EA8")]
    [FieldOffset(Offset = "0x24")]
    public JSON_RandUnitTag[] rand_tag;
    [Token(Token = "0x4001EA9")]
    [FieldOffset(Offset = "0x28")]
    public JSON_MapPartySubCT[] party_subs;
    [Token(Token = "0x4001EAA")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_MapTrick[] tricks;
    [Token(Token = "0x4001EAB")]
    [FieldOffset(Offset = "0x30")]
    public JSON_InfinitySpawnGroup[] inf_spawn_group;
    [Token(Token = "0x4001EAC")]
    [FieldOffset(Offset = "0x34")]
    public JSON_InfinitySpawn[] inf_spawn;
    [Token(Token = "0x4001EAD")]
    [FieldOffset(Offset = "0x38")]
    public JSON_MapEnemyUnit[] inf_deck;

    [Token(Token = "0x6003005")]
    [Address(RVA = "0xFE5010", Offset = "0xFE3E10", VA = "0x10FE5010")]
    public List<JSON_MapEnemyUnit> GetRandFixedUnit() => (List<JSON_MapEnemyUnit>) null;

    [Token(Token = "0x170002D2")]
    public bool HasRandomEnemies
    {
      [Token(Token = "0x6003006"), Address(RVA = "0xFE5390", Offset = "0xFE4190", VA = "0x10FE5390")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003007")]
    [Address(RVA = "0xFE5180", Offset = "0xFE3F80", VA = "0x10FE5180")]
    public JSON_MapEnemyUnit[] ReplacedRandEnemy(
      RandDeckResult[] rand_lot_result,
      bool delete_rand_symbol = true)
    {
      return (JSON_MapEnemyUnit[]) null;
    }

    [Token(Token = "0x6003008")]
    [Address(RVA = "0xFE4B60", Offset = "0xFE3960", VA = "0x10FE4B60")]
    private void DeleteRandSymbolInEnemies()
    {
    }

    [Token(Token = "0x6003009")]
    [Address(RVA = "0xFE4DB0", Offset = "0xFE3BB0", VA = "0x10FE4DB0")]
    public JSON_MapEnemyUnit[] GetMapEnemyUnits_AvailableRandom() => (JSON_MapEnemyUnit[]) null;

    [Token(Token = "0x600300A")]
    [Address(RVA = "0xFE4CB0", Offset = "0xFE3AB0", VA = "0x10FE4CB0")]
    public JSON_MapEnemyUnit[] GetMapEnemyUnits_AvailableInfinitySpawn()
    {
      return (JSON_MapEnemyUnit[]) null;
    }

    [Token(Token = "0x600300B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MapUnit()
    {
    }
  }
}
