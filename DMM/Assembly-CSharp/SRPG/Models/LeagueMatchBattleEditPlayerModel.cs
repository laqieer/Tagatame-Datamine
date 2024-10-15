// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchBattleEditPlayerModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003354")]
  public class LeagueMatchBattleEditPlayerModel
  {
    [Token(Token = "0x400F244")]
    [FieldOffset(Offset = "0x8")]
    private LeagueMatchSeasonParam _seasonParam;
    [Token(Token = "0x400F245")]
    [FieldOffset(Offset = "0xC")]
    private LeagueMatchSettingParam _settingParam;
    [Token(Token = "0x400F246")]
    [FieldOffset(Offset = "0x10")]
    private JSON_LeagueMatchParties _playerResponse;
    [Token(Token = "0x400F247")]
    [FieldOffset(Offset = "0x14")]
    private int _seasonID;
    [Token(Token = "0x400F248")]
    [FieldOffset(Offset = "0x18")]
    private int _totalPower;
    [Token(Token = "0x400F249")]
    [FieldOffset(Offset = "0x1C")]
    private List<UnitModel> _unitModelList;
    [Token(Token = "0x400F24A")]
    [FieldOffset(Offset = "0x20")]
    private List<UnitData> _unitdataList;
    [Token(Token = "0x400F24B")]
    [FieldOffset(Offset = "0x24")]
    private PartyEditData _partyEditData;
    [Token(Token = "0x400F24C")]
    [FieldOffset(Offset = "0x28")]
    private List<PartyEditData> _partyEditDataList;
    [Token(Token = "0x400F24D")]
    [FieldOffset(Offset = "0x2C")]
    private int _index;

    [Token(Token = "0x17001E91")]
    public int TotalPower
    {
      [Token(Token = "0x600E339"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E92")]
    public string TeamName
    {
      [Token(Token = "0x600E33A"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E33B"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
    }

    [Token(Token = "0x17001E93")]
    public List<UnitModel> UnitModelList
    {
      [Token(Token = "0x600E33C"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<UnitModel>) null;
      }
    }

    [Token(Token = "0x17001E94")]
    public JSON_LeagueMatchParties PlayerResponse
    {
      [Token(Token = "0x600E33D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (JSON_LeagueMatchParties) null;
      }
    }

    [Token(Token = "0x17001E95")]
    public PartyEditData PartyEditData
    {
      [Token(Token = "0x600E33E"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (PartyEditData) null;
      }
    }

    [Token(Token = "0x17001E96")]
    public List<PartyEditData> PartyEditDataList
    {
      [Token(Token = "0x600E33F"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<PartyEditData>) null;
      }
    }

    [Token(Token = "0x17001E97")]
    public int PartyNo
    {
      [Token(Token = "0x600E340"), Address(RVA = "0xAB4A80", Offset = "0xAB3880", VA = "0x10AB4A80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E98")]
    public bool IsCheckBox
    {
      [Token(Token = "0x600E341"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E342"), Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")] set
      {
      }
    }

    [Token(Token = "0x17001E99")]
    public bool IsUnitReady
    {
      [Token(Token = "0x600E343"), Address(RVA = "0xAB4860", Offset = "0xAB3660", VA = "0x10AB4860")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E9A")]
    public bool IsUnitUsedItem
    {
      [Token(Token = "0x600E344"), Address(RVA = "0xAB49C0", Offset = "0xAB37C0", VA = "0x10AB49C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E9B")]
    public bool IsNotEditParty
    {
      [Token(Token = "0x600E345"), Address(RVA = "0xAB4440", Offset = "0xAB3240", VA = "0x10AB4440")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E346")]
    [Address(RVA = "0xAB4410", Offset = "0xAB3210", VA = "0x10AB4410")]
    public void Initialize(int seasonID, JSON_LeagueMatchParties response, int index)
    {
    }

    [Token(Token = "0x600E347")]
    [Address(RVA = "0xAB3D90", Offset = "0xAB2B90", VA = "0x10AB3D90")]
    private void InitializeData()
    {
    }

    [Token(Token = "0x600E348")]
    [Address(RVA = "0xAB4540", Offset = "0xAB3340", VA = "0x10AB4540")]
    private void RefreshAtkUnit(JSON_LeagueMatchParties json)
    {
    }

    [Token(Token = "0x600E349")]
    [Address(RVA = "0xAB4440", Offset = "0xAB3240", VA = "0x10AB4440")]
    private bool IsNotParty() => new bool();

    [Token(Token = "0x600E34A")]
    [Address(RVA = "0xAB4720", Offset = "0xAB3520", VA = "0x10AB4720")]
    public LeagueMatchBattleEditPlayerModel()
    {
    }
  }
}
