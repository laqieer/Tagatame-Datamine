// Decompiled with JetBrains decompiler
// Type: PartyUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x200012E")]
public static class PartyUtility
{
  [Token(Token = "0x6000778")]
  [Address(RVA = "0xD671C0", Offset = "0xD65FC0", VA = "0x10D671C0")]
  public static List<PartyEditData> LoadTeamPresets(
    PlayerPartyTypes partyType,
    out int lastSelectionIndex,
    bool containsNotFree = false)
  {
    return (List<PartyEditData>) null;
  }

  [Token(Token = "0x6000779")]
  [Address(RVA = "0xD66D60", Offset = "0xD65B60", VA = "0x10D66D60")]
  public static List<PartyEditData> LoadTeamPresets(
    PartyWindow2.EditPartyTypes partyType,
    out int lastSelectionIndex,
    bool containsNotFree = false)
  {
    return (List<PartyEditData>) null;
  }

  [Token(Token = "0x600077A")]
  [Address(RVA = "0xD67C60", Offset = "0xD66A60", VA = "0x10D67C60")]
  public static void SaveTeamPresets(
    PartyWindow2.EditPartyTypes partyType,
    int teamIndex,
    List<PartyEditData> teams,
    bool containsNotFree = false,
    List<PartySlotData> slot = null)
  {
  }

  [Token(Token = "0x600077B")]
  [Address(RVA = "0xD64D20", Offset = "0xD63B20", VA = "0x10D64D20")]
  public static string CreateDefaultPartyNameFromIndex(int index) => (string) null;

  [Token(Token = "0x600077C")]
  [Address(RVA = "0xD64DE0", Offset = "0xD63BE0", VA = "0x10D64DE0")]
  public static string CreateOrdealPartyNameFromIndex(int index) => (string) null;

  [Token(Token = "0x600077D")]
  [Address(RVA = "0xD66340", Offset = "0xD65140", VA = "0x10D66340")]
  public static string GetCurrentTeamID(PartyWindow2.EditPartyTypes partyType, bool containForced = false)
  {
    return (string) null;
  }

  [Token(Token = "0x600077E")]
  [Address(RVA = "0xD68000", Offset = "0xD66E00", VA = "0x10D68000")]
  public static bool SetUnitIfEmptyParty(
    QuestParam quest,
    List<PartyEditData> teams,
    string[] units_list,
    List<PartySlotData> slotData)
  {
    return new bool();
  }

  [Token(Token = "0x600077F")]
  [Address(RVA = "0xD63E00", Offset = "0xD62C00", VA = "0x10D63E00")]
  public static bool AutoSetLeaderUnit(
    QuestParam quest,
    PartyEditData party,
    string[] kyouseiUnitIds,
    List<UnitData> units,
    List<PartySlotData> slotData)
  {
    return new bool();
  }

  [Token(Token = "0x6000780")]
  [Address(RVA = "0xD66500", Offset = "0xD65300", VA = "0x10D66500")]
  public static bool IsHeloQuest(QuestParam quest) => new bool();

  [Token(Token = "0x6000781")]
  [Address(RVA = "0xD66670", Offset = "0xD65470", VA = "0x10D66670")]
  public static bool IsTeamLegalForOrdealQuest(QuestParam quest, IEnumerable<PartyEditData> teams)
  {
    return new bool();
  }

  [Token(Token = "0x6000782")]
  [Address(RVA = "0xD66950", Offset = "0xD65750", VA = "0x10D66950")]
  public static bool IsTeamLegal(PlayerPartyTypes partyType, QuestParam quest, PartyEditData team)
  {
    return new bool();
  }

  [Token(Token = "0x6000783")]
  [Address(RVA = "0xD669B0", Offset = "0xD657B0", VA = "0x10D669B0")]
  public static bool IsTeamLegal(
    PartyWindow2.EditPartyTypes partyType,
    QuestParam quest,
    PartyEditData team)
  {
    return new bool();
  }

  [Token(Token = "0x6000784")]
  [Address(RVA = "0xD66530", Offset = "0xD65330", VA = "0x10D66530")]
  public static bool IsHeroesAvailable(PartyWindow2.EditPartyTypes partyType, QuestParam quest)
  {
    return new bool();
  }

  [Token(Token = "0x6000785")]
  [Address(RVA = "0xD665B0", Offset = "0xD653B0", VA = "0x10D665B0")]
  public static bool IsSoloStoryParty(QuestParam quest) => new bool();

  [Token(Token = "0x6000786")]
  [Address(RVA = "0xD66540", Offset = "0xD65340", VA = "0x10D66540")]
  public static bool IsSoloStoryOrEventParty(QuestParam quest) => new bool();

  [Token(Token = "0x6000787")]
  [Address(RVA = "0xD66B70", Offset = "0xD65970", VA = "0x10D66B70")]
  public static bool KyouseiUnitPartyEdit(QuestParam quest, PartyEditData edit) => new bool();

  [Token(Token = "0x6000788")]
  [Address(RVA = "0xD676F0", Offset = "0xD664F0", VA = "0x10D676F0")]
  public static bool PartyUnitsRemoveHelo(PartyEditData party, string[] kyouseiUnitIds)
  {
    return new bool();
  }

  [Token(Token = "0x6000789")]
  [Address(RVA = "0xD67A80", Offset = "0xD66880", VA = "0x10D67A80")]
  public static bool ResetToDefaultTeamIfNeeded(
    PlayerPartyTypes partyType,
    QuestParam quest,
    List<PartyEditData> teams)
  {
    return new bool();
  }

  [Token(Token = "0x600078A")]
  [Address(RVA = "0xD678E0", Offset = "0xD666E0", VA = "0x10D678E0")]
  public static bool ResetToDefaultTeamIfNeededForOrdealQuest(
    QuestParam quest,
    List<PartyEditData> teams)
  {
    return new bool();
  }

  [Token(Token = "0x600078B")]
  [Address(RVA = "0xD66420", Offset = "0xD65220", VA = "0x10D66420")]
  public static PartyWindow2.EditPartyTypes GetEditPartyTypes(QuestParam quest)
  {
    return new PartyWindow2.EditPartyTypes();
  }

  [Token(Token = "0x600078C")]
  [Address(RVA = "0xD67840", Offset = "0xD66640", VA = "0x10D67840")]
  public static int RecommendTypeToComparatorOrder(GlobalVars.RecommendType targetType)
  {
    return new int();
  }

  [Token(Token = "0x600078D")]
  [Address(RVA = "0xD64460", Offset = "0xD63260", VA = "0x10D64460")]
  public static int CalcTotalAttack(
    PartyEditData party,
    List<UnitData> ownUnits,
    SupportData support = null,
    List<UnitData> guest = null)
  {
    return new int();
  }

  [Token(Token = "0x600078E")]
  [Address(RVA = "0xD64180", Offset = "0xD62F80", VA = "0x10D64180")]
  public static int CalcTotalAttack(
    PartyEditData party,
    int lockedSlots,
    List<UnitData> ownUnits,
    SupportData support,
    List<UnitData> guest = null)
  {
    return new int();
  }

  [Token(Token = "0x600078F")]
  [Address(RVA = "0xD64510", Offset = "0xD63310", VA = "0x10D64510")]
  public static int CalcTotalCombatPower(
    PartyEditData party,
    List<UnitData> ownUnits,
    SupportData support = null,
    List<UnitData> guest = null)
  {
    return new int();
  }

  [Token(Token = "0x6000790")]
  [Address(RVA = "0xD646F0", Offset = "0xD634F0", VA = "0x10D646F0")]
  public static int CalcTotalCombatPower(
    PartyEditData party,
    int lockedSlots,
    List<UnitData> ownUnits,
    SupportData support = null,
    List<UnitData> guest = null)
  {
    return new int();
  }

  [Token(Token = "0x6000791")]
  [Address(RVA = "0xD64620", Offset = "0xD63420", VA = "0x10D64620")]
  public static int CalcTotalCombatPower(
    IEnumerable<UnitData> units,
    SupportData support = null,
    List<UnitData> guest = null)
  {
    return new int();
  }

  [Token(Token = "0x6000792")]
  [Address(RVA = "0xD64480", Offset = "0xD63280", VA = "0x10D64480")]
  public static int CalcTotalCombatPower(List<UnitData> units) => new int();

  [Token(Token = "0x6000793")]
  [Address(RVA = "0xD68210", Offset = "0xD67010", VA = "0x10D68210")]
  public static bool ValidateOrdealTeams(
    QuestParam quest,
    List<PartyEditData> teams,
    List<SupportData> supports,
    bool validateOnly)
  {
    return new bool();
  }

  [Token(Token = "0x6000794")]
  [Address(RVA = "0xD64810", Offset = "0xD63610", VA = "0x10D64810")]
  public static bool CheckWarningForOrdealTeams(List<PartyEditData> teams, Action okAction)
  {
    return new bool();
  }

  [Token(Token = "0x6000795")]
  [Address(RVA = "0xD662B0", Offset = "0xD650B0", VA = "0x10D662B0")]
  public static UnitData FindUnit(long uniqueID, List<UnitData> ownUnits) => (UnitData) null;

  [Token(Token = "0x6000796")]
  [Address(RVA = "0xD661E0", Offset = "0xD64FE0", VA = "0x10D661E0")]
  public static UnitData FindUnit(UnitData source, List<UnitData> ownUnits) => (UnitData) null;

  [Token(Token = "0x6000797")]
  [Address(RVA = "0xD64F50", Offset = "0xD63D50", VA = "0x10D64F50")]
  public static void CreatePartySlotData(
    QuestParam param,
    out List<PartySlotData> mainSlotData,
    out List<PartySlotData> subSlotData,
    out PartySlotData supportSlotData)
  {
  }

  [Token(Token = "0x6000798")]
  [Address(RVA = "0xD67220", Offset = "0xD66020", VA = "0x10D67220")]
  public static void MergePartySlotWithPartyUnits(
    QuestParam questParam,
    List<PartySlotData> partySlotData,
    UnitData[] partyUnits,
    List<UnitData> guestUnits,
    bool isOwnUnits)
  {
  }

  [Token(Token = "0x200012F")]
  private class JSON_Team
  {
    [Token(Token = "0x4000567")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4000568")]
    [FieldOffset(Offset = "0xC")]
    public long[] u;

    [Token(Token = "0x6000799")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_Team()
    {
    }
  }

  [Token(Token = "0x2000130")]
  private class JSON_TeamSettings
  {
    [Token(Token = "0x4000569")]
    [FieldOffset(Offset = "0x8")]
    public int n;
    [Token(Token = "0x400056A")]
    [FieldOffset(Offset = "0xC")]
    public PartyUtility.JSON_Team[] t;

    [Token(Token = "0x600079A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TeamSettings()
    {
    }
  }
}
