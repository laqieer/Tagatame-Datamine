// Decompiled with JetBrains decompiler
// Type: SRPG.TowerResuponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015AD")]
  public class TowerResuponse
  {
    [Token(Token = "0x4004ECA")]
    [FieldOffset(Offset = "0x8")]
    public long rtime;
    [Token(Token = "0x4004ECB")]
    [FieldOffset(Offset = "0x10")]
    public TowerResuponse.Status status;
    [Token(Token = "0x4004ECC")]
    [FieldOffset(Offset = "0x14")]
    public List<TowerResuponse.PlayerUnit> pdeck;
    [Token(Token = "0x4004ECD")]
    [FieldOffset(Offset = "0x18")]
    public List<TowerResuponse.EnemyUnit> edeck;
    [Token(Token = "0x4004ECE")]
    [FieldOffset(Offset = "0x1C")]
    private TowerFloorParam currentFloor;
    [Token(Token = "0x4004ECF")]
    [FieldOffset(Offset = "0x20")]
    public string TowerID;
    [Token(Token = "0x4004ED0")]
    [FieldOffset(Offset = "0x24")]
    public short reset_cost;
    [Token(Token = "0x4004ED1")]
    [FieldOffset(Offset = "0x26")]
    public byte round;
    [Token(Token = "0x4004ED2")]
    [FieldOffset(Offset = "0x27")]
    public bool is_reset;
    [Token(Token = "0x4004ED3")]
    [FieldOffset(Offset = "0x28")]
    public int arrived_num;
    [Token(Token = "0x4004ED4")]
    [FieldOffset(Offset = "0x2C")]
    public int clear;
    [Token(Token = "0x4004ED5")]
    [FieldOffset(Offset = "0x30")]
    public int speedRank;
    [Token(Token = "0x4004ED6")]
    [FieldOffset(Offset = "0x34")]
    public int techRank;
    [Token(Token = "0x4004ED7")]
    [FieldOffset(Offset = "0x38")]
    public int turn_num;
    [Token(Token = "0x4004ED8")]
    [FieldOffset(Offset = "0x3C")]
    public int died_num;
    [Token(Token = "0x4004ED9")]
    [FieldOffset(Offset = "0x40")]
    public int retire_num;
    [Token(Token = "0x4004EDA")]
    [FieldOffset(Offset = "0x44")]
    public int recover_num;
    [Token(Token = "0x4004EDB")]
    [FieldOffset(Offset = "0x48")]
    public int challenge_num;
    [Token(Token = "0x4004EDC")]
    [FieldOffset(Offset = "0x4C")]
    public int lose_num;
    [Token(Token = "0x4004EDD")]
    [FieldOffset(Offset = "0x50")]
    public int reset_num;
    [Token(Token = "0x4004EDE")]
    [FieldOffset(Offset = "0x54")]
    public int spd_score;
    [Token(Token = "0x4004EDF")]
    [FieldOffset(Offset = "0x58")]
    public int tec_score;
    [Token(Token = "0x4004EE0")]
    [FieldOffset(Offset = "0x5C")]
    public int ret_score;
    [Token(Token = "0x4004EE1")]
    [FieldOffset(Offset = "0x60")]
    public int rcv_score;
    [Token(Token = "0x4004EE2")]
    [FieldOffset(Offset = "0x64")]
    public int challenge_score;
    [Token(Token = "0x4004EE3")]
    [FieldOffset(Offset = "0x68")]
    public int lose_score;
    [Token(Token = "0x4004EE4")]
    [FieldOffset(Offset = "0x6C")]
    public int reset_score;
    [Token(Token = "0x4004EE5")]
    [FieldOffset(Offset = "0x70")]
    public TowerResuponse.TowerRankParam[] SpdRank;
    [Token(Token = "0x4004EE6")]
    [FieldOffset(Offset = "0x74")]
    public TowerResuponse.TowerRankParam[] TecRank;
    [Token(Token = "0x4004EE7")]
    [FieldOffset(Offset = "0x78")]
    public RandDeckResult[] lot_enemies;
    [Token(Token = "0x4004EE8")]
    [FieldOffset(Offset = "0x7C")]
    public TowerScore.ViewParam FloorScores;
    [Token(Token = "0x4004EE9")]
    [FieldOffset(Offset = "0x80")]
    public TowerResuponse.TowerRankParam[] FloorSpdRank;
    [Token(Token = "0x4004EEA")]
    [FieldOffset(Offset = "0x84")]
    public TowerResuponse.TowerRankParam[] FloorTecRank;

    [Token(Token = "0x17000979")]
    public TowerClear.TOWER_CLEAR_FLAG ClearFlag
    {
      [Token(Token = "0x6005939"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new TowerClear.TOWER_CLEAR_FLAG();
      }
    }

    [Token(Token = "0x1700097A")]
    public bool IsNotClear
    {
      [Token(Token = "0x600593A"), Address(RVA = "0x37AD40", Offset = "0x379B40", VA = "0x1037AD40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700097B")]
    public bool IsFirstClear
    {
      [Token(Token = "0x600593B"), Address(RVA = "0x12F1AA0", Offset = "0x12F08A0", VA = "0x112F1AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700097C")]
    public bool IsRoundClear
    {
      [Token(Token = "0x600593C"), Address(RVA = "0x12F1AC0", Offset = "0x12F08C0", VA = "0x112F1AC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700097D")]
    public long FreeRecoverTime
    {
      [Token(Token = "0x600593D"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700097E")]
    public DateTime FreeRecoverEndTime
    {
      [Token(Token = "0x600593E"), Address(RVA = "0x12F19C0", Offset = "0x12F07C0", VA = "0x112F19C0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600593F")]
    [Address(RVA = "0x12EF5D0", Offset = "0x12EE3D0", VA = "0x112EF5D0")]
    public void Deserialize(JSON_ReqTowerResuponse res)
    {
    }

    [Token(Token = "0x6005940")]
    [Address(RVA = "0x12EFAF0", Offset = "0x12EE8F0", VA = "0x112EFAF0")]
    private void Deserialize(JSON_ReqTowerResuponse.Json_RankStatus json)
    {
    }

    [Token(Token = "0x6005941")]
    [Address(RVA = "0x12EFF10", Offset = "0x12EED10", VA = "0x112EFF10")]
    public void Deserialize(JSON_ReqTowerResuponse.Json_TowerPlayerUnit[] res)
    {
    }

    [Token(Token = "0x6005942")]
    [Address(RVA = "0x12EF400", Offset = "0x12EE200", VA = "0x112EF400")]
    public void Deserialize(JSON_ReqTowerResuponse.Json_TowerEnemyUnit[] res)
    {
    }

    [Token(Token = "0x6005943")]
    [Address(RVA = "0x12F00D0", Offset = "0x12EEED0", VA = "0x112F00D0")]
    public void Deserialize(ReqTowerRank.JSON_TowerRankResponse json)
    {
    }

    [Token(Token = "0x6005944")]
    [Address(RVA = "0x12F1860", Offset = "0x12F0660", VA = "0x112F1860")]
    private void UpdateCurrentFloor()
    {
    }

    [Token(Token = "0x6005945")]
    [Address(RVA = "0x12EFB60", Offset = "0x12EE960", VA = "0x112EFB60")]
    public void Deserialize(JSON_ReqTowerResuponse.Json_TowerStatus json)
    {
    }

    [Token(Token = "0x6005946")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void UpdateFloorQuestsState()
    {
    }

    [Token(Token = "0x6005947")]
    [Address(RVA = "0x12F1730", Offset = "0x12F0530", VA = "0x112F1730")]
    private void SetQuestState(
      List<QuestParam> referenceQuestList,
      QuestParam questParam,
      QuestStates state,
      bool cond_recursive)
    {
    }

    [Token(Token = "0x6005948")]
    [Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")]
    public TowerFloorParam GetCurrentFloor() => (TowerFloorParam) null;

    [Token(Token = "0x6005949")]
    [Address(RVA = "0x12EECF0", Offset = "0x12EDAF0", VA = "0x112EECF0")]
    public void CalcDamage(List<Unit> player)
    {
    }

    [Token(Token = "0x600594A")]
    [Address(RVA = "0x12F0C40", Offset = "0x12EFA40", VA = "0x112F0C40")]
    public int GetPlayerUnitHP(UnitData data) => new int();

    [Token(Token = "0x600594B")]
    [Address(RVA = "0x12F0CC0", Offset = "0x12EFAC0", VA = "0x112F0CC0")]
    public int GetUnitDamage(UnitData unit_data) => new int();

    [Token(Token = "0x600594C")]
    [Address(RVA = "0x12EEE70", Offset = "0x12EDC70", VA = "0x112EEE70")]
    public void CalcEnemyDamage(List<Unit> enemy, bool is_menu = false)
    {
    }

    [Token(Token = "0x600594D")]
    [Address(RVA = "0x12EF240", Offset = "0x12EE040", VA = "0x112EF240")]
    public int CalcRecoverCost() => new int();

    [Token(Token = "0x600594E")]
    [Address(RVA = "0x12F0950", Offset = "0x12EF750", VA = "0x112F0950")]
    public bool ExistDamagedUnit() => new bool();

    [Token(Token = "0x600594F")]
    [Address(RVA = "0x12F0BB0", Offset = "0x12EF9B0", VA = "0x112F0BB0")]
    public int GetDiedUnitNum() => new int();

    [Token(Token = "0x6005950")]
    [Address(RVA = "0x12F0AA0", Offset = "0x12EF8A0", VA = "0x112F0AA0")]
    public List<UnitData> GetAvailableUnits() => (List<UnitData>) null;

    [Token(Token = "0x6005951")]
    [Address(RVA = "0x12F09E0", Offset = "0x12EF7E0", VA = "0x112F09E0")]
    public TowerResuponse.PlayerUnit FindPlayerUnit(UnitData unit)
    {
      return (TowerResuponse.PlayerUnit) null;
    }

    [Token(Token = "0x6005952")]
    [Address(RVA = "0x12F0CF0", Offset = "0x12EFAF0", VA = "0x112F0CF0")]
    public bool IsDied_PlayerUnit(UnitData unit) => new bool();

    [Token(Token = "0x6005953")]
    [Address(RVA = "0x12F16F0", Offset = "0x12F04F0", VA = "0x112F16F0")]
    public void OnFloorReset()
    {
    }

    [Token(Token = "0x6005954")]
    [Address(RVA = "0x12F0DF0", Offset = "0x12EFBF0", VA = "0x112F0DF0")]
    public void OnFloorRanking(ReqTowerFloorRanking.Json_Response json)
    {
    }

    [Token(Token = "0x6005955")]
    [Address(RVA = "0x12EF3F0", Offset = "0x12EE1F0", VA = "0x112EF3F0")]
    public bool CheckEnemyDeck() => new bool();

    [Token(Token = "0x6005956")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TowerResuponse()
    {
    }

    [Token(Token = "0x20015AE")]
    public class Status
    {
      [Token(Token = "0x4004EEB")]
      [FieldOffset(Offset = "0x8")]
      public string fname;
      [Token(Token = "0x4004EEC")]
      [FieldOffset(Offset = "0xC")]
      public QuestStates state;

      [Token(Token = "0x6005957")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Status()
      {
      }
    }

    [Token(Token = "0x20015AF")]
    public class PlayerUnit
    {
      [Token(Token = "0x4004EED")]
      [FieldOffset(Offset = "0x8")]
      public string unitname;
      [Token(Token = "0x4004EEE")]
      [FieldOffset(Offset = "0xC")]
      public int dmg;
      [Token(Token = "0x4004EEF")]
      [FieldOffset(Offset = "0x10")]
      public int is_died;

      [Token(Token = "0x1700097F")]
      public bool isDied
      {
        [Token(Token = "0x6005958"), Address(RVA = "0x61CA00", Offset = "0x61B800", VA = "0x1061CA00")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6005959")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public PlayerUnit()
      {
      }
    }

    [Token(Token = "0x20015B0")]
    public class EnemyUnit
    {
      [Token(Token = "0x4004EF0")]
      [FieldOffset(Offset = "0x8")]
      public long id;
      [Token(Token = "0x4004EF1")]
      [FieldOffset(Offset = "0x10")]
      public string iname;
      [Token(Token = "0x4004EF2")]
      [FieldOffset(Offset = "0x14")]
      public string eid;
      [Token(Token = "0x4004EF3")]
      [FieldOffset(Offset = "0x18")]
      public int hp;
      [Token(Token = "0x4004EF4")]
      [FieldOffset(Offset = "0x1C")]
      public int jewel;

      [Token(Token = "0x600595A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EnemyUnit()
      {
      }
    }

    [Token(Token = "0x20015B1")]
    public class TowerRankParam
    {
      [Token(Token = "0x4004EF5")]
      [FieldOffset(Offset = "0x8")]
      public string name;
      [Token(Token = "0x4004EF6")]
      [FieldOffset(Offset = "0xC")]
      public int lv;
      [Token(Token = "0x4004EF7")]
      [FieldOffset(Offset = "0x10")]
      public int rank;
      [Token(Token = "0x4004EF8")]
      [FieldOffset(Offset = "0x14")]
      public int score;
      [Token(Token = "0x4004EF9")]
      [FieldOffset(Offset = "0x18")]
      public string uid;
      [Token(Token = "0x4004EFA")]
      [FieldOffset(Offset = "0x1C")]
      public UnitData unit;
      [Token(Token = "0x4004EFB")]
      [FieldOffset(Offset = "0x20")]
      public string selected_award;
      [Token(Token = "0x4004EFC")]
      [FieldOffset(Offset = "0x24")]
      public ViewGuildData ViewGuild;

      [Token(Token = "0x600595B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TowerRankParam()
      {
      }
    }
  }
}
