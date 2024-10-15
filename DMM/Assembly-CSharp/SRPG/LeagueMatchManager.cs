// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002697")]
  [AddComponentMenu("UI/LeagueMatch/LeagueMatchManager")]
  public class LeagueMatchManager : BaseManager<LeagueMatchManager>
  {
    [Token(Token = "0x400B45D")]
    [FieldOffset(Offset = "0xC")]
    private List<long> _used_units;
    [Token(Token = "0x400B45E")]
    [FieldOffset(Offset = "0x10")]
    private List<long> _used_cards;
    [Token(Token = "0x400B45F")]
    [FieldOffset(Offset = "0x14")]
    private List<long> _used_artifacts;
    [Token(Token = "0x400B460")]
    [FieldOffset(Offset = "0x18")]
    private List<long> _used_runes;
    [Token(Token = "0x400B461")]
    [FieldOffset(Offset = "0x1C")]
    private List<long> _used_crystals;
    [Token(Token = "0x400B462")]
    [FieldOffset(Offset = "0x20")]
    private List<long> _defense_used_units;
    [Token(Token = "0x400B463")]
    [FieldOffset(Offset = "0x24")]
    private List<long> _defense_used_cards;
    [Token(Token = "0x400B464")]
    [FieldOffset(Offset = "0x28")]
    private List<long> _defense_used_artifacts;
    [Token(Token = "0x400B465")]
    [FieldOffset(Offset = "0x2C")]
    private List<long> _defense_used_runes;
    [Token(Token = "0x400B466")]
    [FieldOffset(Offset = "0x30")]
    private List<long> _defense_used_crystals;
    [Token(Token = "0x400B467")]
    [FieldOffset(Offset = "0x34")]
    private string _used_map;
    [Token(Token = "0x400B468")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, ReqLeagueMatchHistory.Response> _historyResponseCache;
    [Token(Token = "0x400B469")]
    [FieldOffset(Offset = "0x3C")]
    private bool mIsLeagueMatchShamDefense;
    [Token(Token = "0x400B46A")]
    [FieldOffset(Offset = "0x3D")]
    private bool mIsLeagueMatchAtk;
    [Token(Token = "0x400B46B")]
    [FieldOffset(Offset = "0x3E")]
    private bool mIsLeagueMatchDefense;
    [Token(Token = "0x400B46C")]
    [FieldOffset(Offset = "0x3F")]
    public bool IsAtkEditor;
    [Token(Token = "0x400B46D")]
    [FieldOffset(Offset = "0x40")]
    public bool IsUsedNotSelect;
    [Token(Token = "0x400B46E")]
    [FieldOffset(Offset = "0x44")]
    public int HistoryPageMaxCache;
    [Token(Token = "0x400B46F")]
    [FieldOffset(Offset = "0x48")]
    public int LastHistoryPage;
    [Token(Token = "0x400B470")]
    [FieldOffset(Offset = "0x50")]
    public long LastHistoryDetailIid;
    [Token(Token = "0x400B471")]
    [FieldOffset(Offset = "0x58")]
    public bool IsShamBattleOpenHistory;

    [Token(Token = "0x17001805")]
    public List<long> UsedCards
    {
      [Token(Token = "0x600AC4E"), Address(RVA = "0x6FC440", Offset = "0x6FB240", VA = "0x106FC440")] get
      {
        return (List<long>) null;
      }
    }

    [Token(Token = "0x17001806")]
    public List<long> UsedArtifacts
    {
      [Token(Token = "0x600AC4F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<long>) null;
      }
    }

    [Token(Token = "0x17001807")]
    public List<long> UsedRunes
    {
      [Token(Token = "0x600AC50"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<long>) null;
      }
    }

    [Token(Token = "0x17001808")]
    public List<long> UsedCrystals
    {
      [Token(Token = "0x600AC51"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<long>) null;
      }
    }

    [Token(Token = "0x17001809")]
    public Dictionary<int, ReqLeagueMatchHistory.Response> HistoryResponseCache
    {
      [Token(Token = "0x600AC52"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (Dictionary<int, ReqLeagueMatchHistory.Response>) null;
      }
    }

    [Token(Token = "0x1700180A")]
    public bool IsLeagueMatchShamDefense
    {
      [Token(Token = "0x600AC53"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
      [Token(Token = "0x600AC54"), Address(RVA = "0x428390", Offset = "0x427190", VA = "0x10428390")] set
      {
      }
    }

    [Token(Token = "0x1700180B")]
    public bool IsLeagueMatchAtk
    {
      [Token(Token = "0x600AC55"), Address(RVA = "0x56B2D0", Offset = "0x56A0D0", VA = "0x1056B2D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600AC56"), Address(RVA = "0x56B2F0", Offset = "0x56A0F0", VA = "0x1056B2F0")] set
      {
      }
    }

    [Token(Token = "0x1700180C")]
    public bool IsLeagueMatchDefense
    {
      [Token(Token = "0x600AC57"), Address(RVA = "0x5F9550", Offset = "0x5F8350", VA = "0x105F9550")] get
      {
        return new bool();
      }
      [Token(Token = "0x600AC58"), Address(RVA = "0x6FC490", Offset = "0x6FB290", VA = "0x106FC490")] set
      {
      }
    }

    [Token(Token = "0x600AC59")]
    [Address(RVA = "0x6F91B0", Offset = "0x6F7FB0", VA = "0x106F91B0")]
    public void Deserialize(ReqLeagueMatchTop.Response response)
    {
    }

    [Token(Token = "0x600AC5A")]
    [Address(RVA = "0x6FA550", Offset = "0x6F9350", VA = "0x106FA550")]
    public bool IsUnitUsed(PlayerPartyTypes type, long id) => new bool();

    [Token(Token = "0x600AC5B")]
    [Address(RVA = "0x6F9C70", Offset = "0x6F8A70", VA = "0x106F9C70")]
    public bool IsArtifactUsed(PlayerPartyTypes type, long id) => new bool();

    [Token(Token = "0x600AC5C")]
    [Address(RVA = "0x6F9D10", Offset = "0x6F8B10", VA = "0x106F9D10")]
    public bool IsArtifactUsed(PlayerPartyTypes type, ArtifactData data) => new bool();

    [Token(Token = "0x600AC5D")]
    [Address(RVA = "0x6F9BE0", Offset = "0x6F89E0", VA = "0x106F9BE0")]
    public bool IsArtifactUsed(PlayerPartyTypes type, UnitData unit) => new bool();

    [Token(Token = "0x600AC5E")]
    [Address(RVA = "0x6F9FE0", Offset = "0x6F8DE0", VA = "0x106F9FE0")]
    public bool IsConceptCardUsed(PlayerPartyTypes type, long id) => new bool();

    [Token(Token = "0x600AC5F")]
    [Address(RVA = "0x6F9EC0", Offset = "0x6F8CC0", VA = "0x106F9EC0")]
    public bool IsConceptCardUsed(PlayerPartyTypes type, ConceptCardData data) => new bool();

    [Token(Token = "0x600AC60")]
    [Address(RVA = "0x6F9E30", Offset = "0x6F8C30", VA = "0x106F9E30")]
    public bool IsConceptCardUsed(PlayerPartyTypes type, UnitData unit) => new bool();

    [Token(Token = "0x600AC61")]
    [Address(RVA = "0x6FA270", Offset = "0x6F9070", VA = "0x106FA270")]
    public bool IsRuneUsed(PlayerPartyTypes type, long id) => new bool();

    [Token(Token = "0x600AC62")]
    [Address(RVA = "0x6FA310", Offset = "0x6F9110", VA = "0x106FA310")]
    public bool IsRuneUsed(PlayerPartyTypes type, UnitData unit) => new bool();

    [Token(Token = "0x600AC63")]
    [Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x106FA130")]
    public bool IsCrystalUsed(PlayerPartyTypes type, long id) => new bool();

    [Token(Token = "0x600AC64")]
    [Address(RVA = "0x6FA080", Offset = "0x6F8E80", VA = "0x106FA080")]
    public bool IsCrystalUsed(PlayerPartyTypes type, CrystalData data) => new bool();

    [Token(Token = "0x600AC65")]
    [Address(RVA = "0x6FA1D0", Offset = "0x6F8FD0", VA = "0x106FA1D0")]
    public bool IsCrystalUsed(PlayerPartyTypes type, UnitData unit) => new bool();

    [Token(Token = "0x600AC66")]
    [Address(RVA = "0x6FA240", Offset = "0x6F9040", VA = "0x106FA240")]
    public bool IsMapUsed(string iname) => new bool();

    [Token(Token = "0x600AC67")]
    [Address(RVA = "0x6FA5F0", Offset = "0x6F93F0", VA = "0x106FA5F0")]
    public void RegisterCreateMessage(
      JSON_LeagueMatchParties[] parties,
      UnitData[] units,
      int selectPartyNum,
      PlayerPartyTypes type)
    {
    }

    [Token(Token = "0x600AC68")]
    [Address(RVA = "0x6FC000", Offset = "0x6FAE00", VA = "0x106FC000")]
    public UnitData[] SetRemoveUsedItem(eOverWritePartyType type, UnitData[] units)
    {
      return (UnitData[]) null;
    }

    [Token(Token = "0x600AC69")]
    [Address(RVA = "0x6FB9B0", Offset = "0x6FA7B0", VA = "0x106FB9B0")]
    private void RemoveUnitUsedItems(
      eOverWritePartyType type,
      UnitData[] units,
      bool isOverWriteRemove = true)
    {
    }

    [Token(Token = "0x600AC6A")]
    [Address(RVA = "0x6F8DA0", Offset = "0x6F7BA0", VA = "0x106F8DA0")]
    public void CheckEquiped(
      eOverWritePartyType type,
      long[] checkUnitIid,
      ref List<UnitData> units,
      ref ShamCopyData shamCopyData)
    {
    }

    [Token(Token = "0x600AC6B")]
    [Address(RVA = "0x6F9150", Offset = "0x6F7F50", VA = "0x106F9150")]
    public bool CheckUsedItem(UnitData[] units, PlayerPartyTypes type) => new bool();

    [Token(Token = "0x600AC6C")]
    [Address(RVA = "0x6FA380", Offset = "0x6F9180", VA = "0x106FA380")]
    public bool IsUnitUsedItems(UnitData unit, PlayerPartyTypes type) => new bool();

    [Token(Token = "0x600AC6D")]
    [Address(RVA = "0x6FBF20", Offset = "0x6FAD20", VA = "0x106FBF20")]
    public void SetHistoryData(int page, ReqLeagueMatchHistory.Response data)
    {
    }

    [Token(Token = "0x600AC6E")]
    [Address(RVA = "0x6F9BB0", Offset = "0x6F89B0", VA = "0x106F9BB0")]
    public PlayerPartyTypes GetPartyTypes() => new PlayerPartyTypes();

    [Token(Token = "0x600AC6F")]
    [Address(RVA = "0x6FC1F0", Offset = "0x6FAFF0", VA = "0x106FC1F0")]
    public LeagueMatchManager()
    {
    }
  }
}
