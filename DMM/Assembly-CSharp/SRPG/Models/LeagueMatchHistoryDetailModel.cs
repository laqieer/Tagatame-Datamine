// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchHistoryDetailModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003358")]
  public class LeagueMatchHistoryDetailModel
  {
    [Token(Token = "0x400F263")]
    [FieldOffset(Offset = "0x8")]
    private LeagueMatchHistoryDetailView _historyDetailView;
    [Token(Token = "0x400F264")]
    [FieldOffset(Offset = "0xC")]
    private string _playerName;
    [Token(Token = "0x400F265")]
    [FieldOffset(Offset = "0x10")]
    private int _playerLv;
    [Token(Token = "0x400F266")]
    [FieldOffset(Offset = "0x14")]
    private int _playerTotalCombatPower;
    [Token(Token = "0x400F267")]
    [FieldOffset(Offset = "0x18")]
    private List<UnitModel> _playerBattleUnit;
    [Token(Token = "0x400F268")]
    [FieldOffset(Offset = "0x1C")]
    private SkillParam _playerLeaderSkill;
    [Token(Token = "0x400F269")]
    [FieldOffset(Offset = "0x20")]
    private string _enemyName;
    [Token(Token = "0x400F26A")]
    [FieldOffset(Offset = "0x24")]
    private int _enemyLv;
    [Token(Token = "0x400F26B")]
    [FieldOffset(Offset = "0x28")]
    private int _enemyTotalCombatPower;
    [Token(Token = "0x400F26C")]
    [FieldOffset(Offset = "0x2C")]
    private List<UnitModel> _enemyBattleUnit;
    [Token(Token = "0x400F26D")]
    [FieldOffset(Offset = "0x30")]
    private SkillParam _enemyLeaderSkill;
    [Token(Token = "0x400F26E")]
    [FieldOffset(Offset = "0x34")]
    private LeagueMatchAttckType _playerAttckType;
    [Token(Token = "0x400F26F")]
    [FieldOffset(Offset = "0x38")]
    private bool _isShambBattle;

    [Token(Token = "0x17001EAD")]
    public string PlayerName
    {
      [Token(Token = "0x600E36A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EAE")]
    public int PlayerLv
    {
      [Token(Token = "0x600E36B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EAF")]
    public int PlayerTotalCombatPower
    {
      [Token(Token = "0x600E36C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EB0")]
    public List<UnitModel> PlayerBattleUnit
    {
      [Token(Token = "0x600E36D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<UnitModel>) null;
      }
    }

    [Token(Token = "0x17001EB1")]
    public string PlayerLeaderSkillName
    {
      [Token(Token = "0x600E36E"), Address(RVA = "0xAB5520", Offset = "0xAB4320", VA = "0x10AB5520")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EB2")]
    public string PlayerLeaderSkillExpr
    {
      [Token(Token = "0x600E36F"), Address(RVA = "0xAB54E0", Offset = "0xAB42E0", VA = "0x10AB54E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EB3")]
    public string EnemyName
    {
      [Token(Token = "0x600E370"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EB4")]
    public int EnemyLv
    {
      [Token(Token = "0x600E371"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EB5")]
    public int EnemyTotalCombatPower
    {
      [Token(Token = "0x600E372"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EB6")]
    public List<UnitModel> EnemyBattleUnit
    {
      [Token(Token = "0x600E373"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<UnitModel>) null;
      }
    }

    [Token(Token = "0x17001EB7")]
    public string EnemyLeaderSkillName
    {
      [Token(Token = "0x600E374"), Address(RVA = "0xAB54A0", Offset = "0xAB42A0", VA = "0x10AB54A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EB8")]
    public string EnemyLeaderSkillExpr
    {
      [Token(Token = "0x600E375"), Address(RVA = "0xAB5460", Offset = "0xAB4260", VA = "0x10AB5460")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EB9")]
    public LeagueMatchAttckType PlayerAttckType
    {
      [Token(Token = "0x600E376"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new LeagueMatchAttckType();
      }
    }

    [Token(Token = "0x17001EBA")]
    public bool IsShambBattle
    {
      [Token(Token = "0x600E377"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E378")]
    [Address(RVA = "0xAB4EB0", Offset = "0xAB3CB0", VA = "0x10AB4EB0")]
    public void Initialize(
      LeagueMatchHistoryDetailView historyDetailView,
      JSON_LeagueMatchHistory data)
    {
    }

    [Token(Token = "0x600E379")]
    [Address(RVA = "0xAB5060", Offset = "0xAB3E60", VA = "0x10AB5060")]
    public void OnClickUnitDetail(UnitData unit)
    {
    }

    [Token(Token = "0x600E37A")]
    [Address(RVA = "0xAB5240", Offset = "0xAB4040", VA = "0x10AB5240")]
    private void SetPartyData(
      JSON_LeagueMatchBattleUnit[] battle_unit,
      JSON_PlayerBuff _player_buff,
      bool isEnemy,
      ref List<UnitModel> unit_models,
      ref int combat_power,
      ref SkillParam skill)
    {
    }

    [Token(Token = "0x600E37B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchHistoryDetailModel()
    {
    }

    [Token(Token = "0x2003359")]
    public class LeagueMatchUnitData
    {
      [Token(Token = "0x400F270")]
      [FieldOffset(Offset = "0x8")]
      public UnitData unitData;
      [Token(Token = "0x400F271")]
      [FieldOffset(Offset = "0xC")]
      public JSON_LeagueMatchBattleUnit battleData;

      [Token(Token = "0x600E37C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LeagueMatchUnitData()
      {
      }
    }
  }
}
