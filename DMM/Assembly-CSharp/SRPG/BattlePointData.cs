// Decompiled with JetBrains decompiler
// Type: SRPG.BattlePointData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C3F")]
  public class BattlePointData
  {
    [Token(Token = "0x6003085")]
    [Address(RVA = "0xFDC000", Offset = "0xFDAE00", VA = "0x10FDC000")]
    public Json_BtlPointResult CreateBtlPointResult(BattleCore btl) => (Json_BtlPointResult) null;

    [Token(Token = "0x6003086")]
    [Address(RVA = "0xFDC5C0", Offset = "0xFDB3C0", VA = "0x10FDC5C0")]
    public List<PointQuestBonusObjective> GetBonusObjectiveList(BattleCore btl)
    {
      return (List<PointQuestBonusObjective>) null;
    }

    [Token(Token = "0x6003087")]
    [Address(RVA = "0xFDC6F0", Offset = "0xFDB4F0", VA = "0x10FDC6F0")]
    public List<PointQuestBonusObjective> GetBonusObjectiveList(string _quest_id)
    {
      return (List<PointQuestBonusObjective>) null;
    }

    [Token(Token = "0x6003088")]
    [Address(RVA = "0xFDC380", Offset = "0xFDB180", VA = "0x10FDC380")]
    public List<PointQuestBonusObjective> GetBonusObjectiveClearList(BattleCore btl)
    {
      return (List<PointQuestBonusObjective>) null;
    }

    [Token(Token = "0x6003089")]
    [Address(RVA = "0xFDC320", Offset = "0xFDB120", VA = "0x10FDC320")]
    private int GetActionNum(BattleCore btl) => new int();

    [Token(Token = "0x600308A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BattlePointData()
    {
    }
  }
}
