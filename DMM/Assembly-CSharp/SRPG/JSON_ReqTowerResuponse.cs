// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ReqTowerResuponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015A5")]
  public class JSON_ReqTowerResuponse
  {
    [Token(Token = "0x4004EA0")]
    [FieldOffset(Offset = "0x8")]
    public long rtime;
    [Token(Token = "0x4004EA1")]
    [FieldOffset(Offset = "0x10")]
    public JSON_ReqTowerResuponse.Json_TowerStatus stats;
    [Token(Token = "0x4004EA2")]
    [FieldOffset(Offset = "0x14")]
    public JSON_ReqTowerResuponse.Json_TowerPlayerUnit[] pdeck;
    [Token(Token = "0x4004EA3")]
    [FieldOffset(Offset = "0x18")]
    public JSON_ReqTowerResuponse.Json_TowerEnemyUnit[] edeck;
    [Token(Token = "0x4004EA4")]
    [FieldOffset(Offset = "0x1C")]
    public RandDeckResult[] lot_enemies;
    [Token(Token = "0x4004EA5")]
    [FieldOffset(Offset = "0x20")]
    public short reset_cost;
    [Token(Token = "0x4004EA6")]
    [FieldOffset(Offset = "0x22")]
    public byte round;
    [Token(Token = "0x4004EA7")]
    [FieldOffset(Offset = "0x23")]
    public byte is_reset;
    [Token(Token = "0x4004EA8")]
    [FieldOffset(Offset = "0x24")]
    public int turn_num;
    [Token(Token = "0x4004EA9")]
    [FieldOffset(Offset = "0x28")]
    public int died_num;
    [Token(Token = "0x4004EAA")]
    [FieldOffset(Offset = "0x2C")]
    public int retire_num;
    [Token(Token = "0x4004EAB")]
    [FieldOffset(Offset = "0x30")]
    public int recover_num;
    [Token(Token = "0x4004EAC")]
    [FieldOffset(Offset = "0x34")]
    public JSON_ReqTowerResuponse.Json_RankStatus rank;

    [Token(Token = "0x600592A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ReqTowerResuponse()
    {
    }

    [Token(Token = "0x20015A6")]
    public class Json_TowerStatus
    {
      [Token(Token = "0x4004EAD")]
      [FieldOffset(Offset = "0x8")]
      public string fname;
      [Token(Token = "0x4004EAE")]
      [FieldOffset(Offset = "0xC")]
      public string state;

      [Token(Token = "0x17000978")]
      public QuestStates questStates
      {
        [Token(Token = "0x600592B"), Address(RVA = "0x12EEA10", Offset = "0x12ED810", VA = "0x112EEA10")] get
        {
          return new QuestStates();
        }
        [Token(Token = "0x600592C"), Address(RVA = "0x12EEAC0", Offset = "0x12ED8C0", VA = "0x112EEAC0")] set
        {
        }
      }

      [Token(Token = "0x600592D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_TowerStatus()
      {
      }
    }

    [Token(Token = "0x20015A7")]
    public class Json_TowerProg
    {
      [Token(Token = "0x4004EAF")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4004EB0")]
      [FieldOffset(Offset = "0xC")]
      public int is_open;

      [Token(Token = "0x600592E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_TowerProg()
      {
      }
    }

    [Token(Token = "0x20015A8")]
    public class Json_TowerPlayerUnit
    {
      [Token(Token = "0x4004EB1")]
      [FieldOffset(Offset = "0x8")]
      public string uname;
      [Token(Token = "0x4004EB2")]
      [FieldOffset(Offset = "0xC")]
      public int damage;
      [Token(Token = "0x4004EB3")]
      [FieldOffset(Offset = "0x10")]
      public int is_died;

      [Token(Token = "0x600592F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_TowerPlayerUnit()
      {
      }
    }

    [Token(Token = "0x20015A9")]
    public class Json_TowerEnemyUnit
    {
      [Token(Token = "0x4004EB4")]
      [FieldOffset(Offset = "0x8")]
      public int eid;
      [Token(Token = "0x4004EB5")]
      [FieldOffset(Offset = "0xC")]
      public int hp;
      [Token(Token = "0x4004EB6")]
      [FieldOffset(Offset = "0x10")]
      public int jewel;

      [Token(Token = "0x6005930")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_TowerEnemyUnit()
      {
      }
    }

    [Token(Token = "0x20015AA")]
    public class Json_RankStatus
    {
      [Token(Token = "0x4004EB7")]
      [FieldOffset(Offset = "0x8")]
      public int turn_num;
      [Token(Token = "0x4004EB8")]
      [FieldOffset(Offset = "0xC")]
      public int died_num;
      [Token(Token = "0x4004EB9")]
      [FieldOffset(Offset = "0x10")]
      public int retire_num;
      [Token(Token = "0x4004EBA")]
      [FieldOffset(Offset = "0x14")]
      public int recovery_num;
      [Token(Token = "0x4004EBB")]
      [FieldOffset(Offset = "0x18")]
      public int spd_rank;
      [Token(Token = "0x4004EBC")]
      [FieldOffset(Offset = "0x1C")]
      public int tec_rank;
      [Token(Token = "0x4004EBD")]
      [FieldOffset(Offset = "0x20")]
      public int spd_score;
      [Token(Token = "0x4004EBE")]
      [FieldOffset(Offset = "0x24")]
      public int tec_score;
      [Token(Token = "0x4004EBF")]
      [FieldOffset(Offset = "0x28")]
      public int ret_score;
      [Token(Token = "0x4004EC0")]
      [FieldOffset(Offset = "0x2C")]
      public int rcv_score;
      [Token(Token = "0x4004EC1")]
      [FieldOffset(Offset = "0x30")]
      public int challenge_num;
      [Token(Token = "0x4004EC2")]
      [FieldOffset(Offset = "0x34")]
      public int lose_num;
      [Token(Token = "0x4004EC3")]
      [FieldOffset(Offset = "0x38")]
      public int reset_num;
      [Token(Token = "0x4004EC4")]
      [FieldOffset(Offset = "0x3C")]
      public int challenge_score;
      [Token(Token = "0x4004EC5")]
      [FieldOffset(Offset = "0x40")]
      public int lose_score;
      [Token(Token = "0x4004EC6")]
      [FieldOffset(Offset = "0x44")]
      public int reset_score;

      [Token(Token = "0x6005931")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_RankStatus()
      {
      }
    }

    [Token(Token = "0x20015AB")]
    public class Json_UserCoin
    {
      [Token(Token = "0x4004EC7")]
      [FieldOffset(Offset = "0x8")]
      public int free;
      [Token(Token = "0x4004EC8")]
      [FieldOffset(Offset = "0xC")]
      public int paid;
      [Token(Token = "0x4004EC9")]
      [FieldOffset(Offset = "0x10")]
      public int com;

      [Token(Token = "0x6005932")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_UserCoin()
      {
      }
    }
  }
}
