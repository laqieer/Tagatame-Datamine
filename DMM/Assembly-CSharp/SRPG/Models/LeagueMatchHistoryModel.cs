// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchHistoryModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200335B")]
  public class LeagueMatchHistoryModel
  {
    [Token(Token = "0x400F281")]
    [FieldOffset(Offset = "0x8")]
    private JSON_LeagueMatchHistory _detailData;
    [Token(Token = "0x400F282")]
    [FieldOffset(Offset = "0xC")]
    private int _type;
    [Token(Token = "0x400F283")]
    [FieldOffset(Offset = "0x10")]
    private int _battleResult;
    [Token(Token = "0x400F284")]
    [FieldOffset(Offset = "0x14")]
    private string _playerName;
    [Token(Token = "0x400F285")]
    [FieldOffset(Offset = "0x18")]
    private int _playerLv;
    [Token(Token = "0x400F286")]
    [FieldOffset(Offset = "0x1C")]
    private int _totalCombatPower;
    [Token(Token = "0x400F287")]
    [FieldOffset(Offset = "0x20")]
    private string _rankImgPath;
    [Token(Token = "0x400F288")]
    [FieldOffset(Offset = "0x24")]
    private int _score;
    [Token(Token = "0x400F289")]
    [FieldOffset(Offset = "0x28")]
    private UnitModel _unitModelData;

    [Token(Token = "0x17001EBB")]
    public JSON_LeagueMatchHistory DetailData
    {
      [Token(Token = "0x600E383"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (JSON_LeagueMatchHistory) null;
      }
    }

    [Token(Token = "0x17001EBC")]
    public int Type
    {
      [Token(Token = "0x600E384"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EBD")]
    public int BattleResult
    {
      [Token(Token = "0x600E385"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EBE")]
    public string PlayerName
    {
      [Token(Token = "0x600E386"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EBF")]
    public int PlayerLv
    {
      [Token(Token = "0x600E387"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EC0")]
    public int TotalCombatPower
    {
      [Token(Token = "0x600E388"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EC1")]
    public string RankImgPath
    {
      [Token(Token = "0x600E389"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001EC2")]
    public int Score
    {
      [Token(Token = "0x600E38A"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EC3")]
    public UnitModel UnitModelData
    {
      [Token(Token = "0x600E38B"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x600E38C")]
    [Address(RVA = "0xAB6420", Offset = "0xAB5220", VA = "0x10AB6420")]
    public void Initialize(JSON_LeagueMatchHistory data)
    {
    }

    [Token(Token = "0x600E38D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchHistoryModel()
    {
    }
  }
}
