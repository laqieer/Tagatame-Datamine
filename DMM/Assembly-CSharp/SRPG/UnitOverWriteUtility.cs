// Decompiled with JetBrains decompiler
// Type: SRPG.UnitOverWriteUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E23")]
  public class UnitOverWriteUtility
  {
    [Token(Token = "0x400E60C")]
    [FieldOffset(Offset = "0x0")]
    public static eOverWritePartyType[] SupportPartyTypes;
    [Token(Token = "0x400E60D")]
    [FieldOffset(Offset = "0x4")]
    public static eOverWritePartyType[] SupportDefaultPartyTypes;

    [Token(Token = "0x600D9CA")]
    [Address(RVA = "0xA55DC0", Offset = "0xA54BC0", VA = "0x10A55DC0")]
    public static bool IsInitalized(eOverWritePartyType party_type) => new bool();

    [Token(Token = "0x600D9CB")]
    [Address(RVA = "0xA57AB0", Offset = "0xA568B0", VA = "0x10A57AB0")]
    public static eOverWritePartyType String2OverWritePartyType(string str)
    {
      return new eOverWritePartyType();
    }

    [Token(Token = "0x600D9CC")]
    [Address(RVA = "0xA56110", Offset = "0xA54F10", VA = "0x10A56110")]
    public static string OverWritePartyType2String(eOverWritePartyType party_type) => (string) null;

    [Token(Token = "0x600D9CD")]
    [Address(RVA = "0xA56090", Offset = "0xA54E90", VA = "0x10A56090")]
    public static PlayerPartyTypes OverWritePartyType2PlayerPartyType(
      eOverWritePartyType ow_party_type)
    {
      return new PlayerPartyTypes();
    }

    [Token(Token = "0x600D9CE")]
    [Address(RVA = "0xA56290", Offset = "0xA55090", VA = "0x10A56290")]
    public static eOverWritePartyType PlayerPartyType2OverWritePartyType(PlayerPartyTypes party_type)
    {
      return new eOverWritePartyType();
    }

    [Token(Token = "0x600D9CF")]
    [Address(RVA = "0xA56010", Offset = "0xA54E10", VA = "0x10A56010")]
    public static PartyWindow2.EditPartyTypes OverWritePartyType2EditPartyType(
      eOverWritePartyType ow_party_type)
    {
      return new PartyWindow2.EditPartyTypes();
    }

    [Token(Token = "0x600D9D0")]
    [Address(RVA = "0xA52AB0", Offset = "0xA518B0", VA = "0x10A52AB0")]
    public static eOverWritePartyType EditPartyType2OverWritePartyType(
      PartyWindow2.EditPartyTypes party_type)
    {
      return new eOverWritePartyType();
    }

    [Token(Token = "0x600D9D1")]
    [Address(RVA = "0xA52E90", Offset = "0xA51C90", VA = "0x10A52E90")]
    public static eOverWritePartyType Element2OverWritePartyType(EElement element)
    {
      return new eOverWritePartyType();
    }

    [Token(Token = "0x600D9D2")]
    [Address(RVA = "0xA50A90", Offset = "0xA4F890", VA = "0x10A50A90")]
    public static UnitData Apply(
      UnitData unit,
      eOverWritePartyType party_type,
      bool is_refresh_derive = true)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600D9D3")]
    [Address(RVA = "0xA50DA0", Offset = "0xA4FBA0", VA = "0x10A50DA0")]
    public static UnitData Apply(
      UnitData unit,
      PlayerPartyTypes party_type,
      bool is_refresh_derive = true)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600D9D4")]
    [Address(RVA = "0xA50D40", Offset = "0xA4FB40", VA = "0x10A50D40")]
    public static UnitData Apply(
      UnitData unit,
      PartyWindow2.EditPartyTypes party_type,
      bool is_refresh_derive = true)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600D9D5")]
    [Address(RVA = "0xA50800", Offset = "0xA4F600", VA = "0x10A50800")]
    public static List<PartyEditData> ApplyTeams(
      List<PartyEditData> teams,
      eOverWritePartyType party_type)
    {
      return (List<PartyEditData>) null;
    }

    [Token(Token = "0x600D9D6")]
    [Address(RVA = "0xA50640", Offset = "0xA4F440", VA = "0x10A50640")]
    public static PartyEditData ApplyPartyEdit(
      PartyEditData partyEditData,
      eOverWritePartyType party_type)
    {
      return (PartyEditData) null;
    }

    [Token(Token = "0x600D9D7")]
    [Address(RVA = "0xA507A0", Offset = "0xA4F5A0", VA = "0x10A507A0")]
    public static List<PartyEditData> ApplyTeams(
      List<PartyEditData> teams,
      PartyWindow2.EditPartyTypes party_type)
    {
      return (List<PartyEditData>) null;
    }

    [Token(Token = "0x600D9D8")]
    [Address(RVA = "0xA55F90", Offset = "0xA54D90", VA = "0x10A55F90")]
    public static bool IsSupportPartyType(eOverWritePartyType party_type) => new bool();

    [Token(Token = "0x600D9D9")]
    [Address(RVA = "0xA556E0", Offset = "0xA544E0", VA = "0x10A556E0")]
    public static List<UnitData> GetSupportAllUnits(bool is_refresh_derive = true)
    {
      return (List<UnitData>) null;
    }

    [Token(Token = "0x600D9DA")]
    [Address(RVA = "0xA557D0", Offset = "0xA545D0", VA = "0x10A557D0")]
    public static List<UnitData> GetSupportUnits(
      eOverWritePartyType party_type,
      bool is_refresh_derive = true)
    {
      return (List<UnitData>) null;
    }

    [Token(Token = "0x600D9DB")]
    [Address(RVA = "0xA55EB0", Offset = "0xA54CB0", VA = "0x10A55EB0")]
    public static bool IsMultiPartyType(eOverWritePartyType party_type) => new bool();

    [Token(Token = "0x600D9DC")]
    [Address(RVA = "0xA53B80", Offset = "0xA52980", VA = "0x10A53B80")]
    public static List<UnitData> GetMultiPartyUnits(
      eOverWritePartyType party_type,
      bool is_refresh_derive = true)
    {
      return (List<UnitData>) null;
    }

    [Token(Token = "0x600D9DD")]
    [Address(RVA = "0xA55AE0", Offset = "0xA548E0", VA = "0x10A55AE0")]
    public static List<UnitData> GetTempPartyUnits(
      eOverWritePartyType party_type,
      bool is_refresh_derive = true)
    {
      return (List<UnitData>) null;
    }

    [Token(Token = "0x600D9DE")]
    [Address(RVA = "0xA553B0", Offset = "0xA541B0", VA = "0x10A553B0")]
    public static List<UnitData> GetPartyUnits(
      eOverWritePartyType party_type,
      bool is_refresh_derive = true)
    {
      return (List<UnitData>) null;
    }

    [Token(Token = "0x600D9DF")]
    [Address(RVA = "0xA52F00", Offset = "0xA51D00", VA = "0x10A52F00")]
    public static List<UnitData> GetAllPartyUnits() => (List<UnitData>) null;

    [Token(Token = "0x600D9E0")]
    [Address(RVA = "0xA55F80", Offset = "0xA54D80", VA = "0x10A55F80")]
    public static bool IsNeedOverWrite(eOverWritePartyType party_type) => new bool();

    [Token(Token = "0x600D9E1")]
    [Address(RVA = "0xA55FF0", Offset = "0xA54DF0", VA = "0x10A55FF0")]
    public static bool IsTempOverWrite(eOverWritePartyType party_type) => new bool();

    [Token(Token = "0x600D9E2")]
    [Address(RVA = "0xA55F30", Offset = "0xA54D30", VA = "0x10A55F30")]
    public static bool IsNeedOverWrite(PlayerPartyTypes party_type) => new bool();

    [Token(Token = "0x600D9E3")]
    [Address(RVA = "0xA55EE0", Offset = "0xA54CE0", VA = "0x10A55EE0")]
    public static bool IsNeedOverWrite(PartyWindow2.EditPartyTypes party_type) => new bool();

    [Token(Token = "0x600D9E4")]
    [Address(RVA = "0xA54DD0", Offset = "0xA53BD0", VA = "0x10A54DD0")]
    public static UnitData GetOwner(ConceptCardData card) => (UnitData) null;

    [Token(Token = "0x600D9E5")]
    [Address(RVA = "0xA548D0", Offset = "0xA536D0", VA = "0x10A548D0")]
    public static UnitData GetOwner(ConceptCardData card, eOverWritePartyType ow_party_type)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600D9E6")]
    [Address(RVA = "0xA54B80", Offset = "0xA53980", VA = "0x10A54B80")]
    public static UnitData GetOwner(ArtifactData artifact) => (UnitData) null;

    [Token(Token = "0x600D9E7")]
    [Address(RVA = "0xA54170", Offset = "0xA52F70", VA = "0x10A54170")]
    public static UnitData GetOwner(ArtifactData artifact, eOverWritePartyType ow_party_type)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600D9E8")]
    [Address(RVA = "0xA54430", Offset = "0xA53230", VA = "0x10A54430")]
    public static UnitData GetOwner(RuneData rune) => (UnitData) null;

    [Token(Token = "0x600D9E9")]
    [Address(RVA = "0xA53E90", Offset = "0xA52C90", VA = "0x10A53E90")]
    public static UnitData GetOwner(RuneData rune, eOverWritePartyType ow_party_type)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600D9EA")]
    [Address(RVA = "0xA54680", Offset = "0xA53480", VA = "0x10A54680")]
    public static UnitData GetOwner(CrystalData _crystal) => (UnitData) null;

    [Token(Token = "0x600D9EB")]
    [Address(RVA = "0xA55020", Offset = "0xA53E20", VA = "0x10A55020")]
    public static UnitData GetOwner(CrystalData _crystal, eOverWritePartyType _ow_party_type)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600D9EC")]
    [Address(RVA = "0xA53700", Offset = "0xA52500", VA = "0x10A53700")]
    public static long GetEquipedUnitId(ArtifactData artifact, eOverWritePartyType ow_party_type)
    {
      return new long();
    }

    [Token(Token = "0x600D9ED")]
    [Address(RVA = "0xA53570", Offset = "0xA52370", VA = "0x10A53570")]
    public static long GetEquipedUnitId(ConceptCardData card, eOverWritePartyType ow_party_type)
    {
      return new long();
    }

    [Token(Token = "0x600D9EE")]
    [Address(RVA = "0xA53940", Offset = "0xA52740", VA = "0x10A53940")]
    public static long GetEquipedUnitId(RuneData rune, eOverWritePartyType ow_party_type)
    {
      return new long();
    }

    [Token(Token = "0x600D9EF")]
    [Address(RVA = "0xA53330", Offset = "0xA52130", VA = "0x10A53330")]
    public static long GetEquipedUnitId(CrystalData _crystal, eOverWritePartyType _ow_party_type)
    {
      return new long();
    }

    [Token(Token = "0x600D9F0")]
    [Address(RVA = "0xA52300", Offset = "0xA51100", VA = "0x10A52300")]
    public static void DestroyTempParty(eOverWritePartyType ow_party_type)
    {
    }

    [Token(Token = "0x600D9F1")]
    [Address(RVA = "0xA51CC0", Offset = "0xA50AC0", VA = "0x10A51CC0")]
    public static void CreateTempParty(eOverWritePartyType ow_party_type, int unit_max)
    {
    }

    [Token(Token = "0x600D9F2")]
    [Address(RVA = "0xA51540", Offset = "0xA50340", VA = "0x10A51540")]
    public static void CopyTempParty(eOverWritePartyType ow_party_type, UnitData[] units)
    {
    }

    [Token(Token = "0x600D9F3")]
    [Address(RVA = "0xA574A0", Offset = "0xA562A0", VA = "0x10A574A0")]
    public static void SetTempJob(eOverWritePartyType ow_party_type, UnitData unit)
    {
    }

    [Token(Token = "0x600D9F4")]
    [Address(RVA = "0xA56A40", Offset = "0xA55840", VA = "0x10A56A40")]
    public static void SetTempAblity(eOverWritePartyType ow_party_type, long unitId, long[] abils)
    {
    }

    [Token(Token = "0x600D9F5")]
    [Address(RVA = "0xA57690", Offset = "0xA56490", VA = "0x10A57690")]
    public static void SetTempLeaderSkill(
      eOverWritePartyType ow_party_type,
      long unitId,
      int isSet)
    {
    }

    [Token(Token = "0x600D9F6")]
    [Address(RVA = "0xA56BA0", Offset = "0xA559A0", VA = "0x10A56BA0")]
    public static void SetTempArtifact(
      eOverWritePartyType ow_party_type,
      long unitId,
      long jobId,
      long[] artifacts)
    {
    }

    [Token(Token = "0x600D9F7")]
    [Address(RVA = "0xA56320", Offset = "0xA55120", VA = "0x10A56320")]
    public static void RemoveTempArtifact(
      eOverWritePartyType ow_party_type,
      long unitId,
      long jobId,
      long artifact)
    {
    }

    [Token(Token = "0x600D9F8")]
    [Address(RVA = "0xA56DD0", Offset = "0xA55BD0", VA = "0x10A56DD0")]
    public static void SetTempConceptCard(
      eOverWritePartyType ow_party_type,
      long unitId,
      long[] conceptcards)
    {
    }

    [Token(Token = "0x600D9F9")]
    [Address(RVA = "0xA564C0", Offset = "0xA552C0", VA = "0x10A564C0")]
    public static void RemoveTempConceptCard(
      eOverWritePartyType ow_party_type,
      long unitId,
      long conceptcard)
    {
    }

    [Token(Token = "0x600D9FA")]
    [Address(RVA = "0xA577D0", Offset = "0xA565D0", VA = "0x10A577D0")]
    public static void SetTempRune(
      eOverWritePartyType ow_party_type,
      long unitId,
      BindRuneData[] runes)
    {
    }

    [Token(Token = "0x600D9FB")]
    [Address(RVA = "0xA568A0", Offset = "0xA556A0", VA = "0x10A568A0")]
    public static void RemoveTempRune(eOverWritePartyType ow_party_type, long unitId, long rune)
    {
    }

    [Token(Token = "0x600D9FC")]
    [Address(RVA = "0xA51A70", Offset = "0xA50870", VA = "0x10A51A70")]
    public static List<CrystalData> CopyToCrystal(long[] _crystal_iids) => (List<CrystalData>) null;

    [Token(Token = "0x600D9FD")]
    [Address(RVA = "0xA531F0", Offset = "0xA51FF0", VA = "0x10A531F0")]
    public static CrystalData GetCrystalData(long _crystal) => (CrystalData) null;

    [Token(Token = "0x600D9FE")]
    [Address(RVA = "0xA57250", Offset = "0xA56050", VA = "0x10A57250")]
    public static void SetTempCrystal(
      eOverWritePartyType _ow_party_type,
      long _unit_iid,
      long[] _crystal_iids)
    {
    }

    [Token(Token = "0x600D9FF")]
    [Address(RVA = "0xA521D0", Offset = "0xA50FD0", VA = "0x10A521D0")]
    private static void DeleteCrystal(UnitOverWriteData _data, long[] _list)
    {
    }

    [Token(Token = "0x600DA00")]
    [Address(RVA = "0xA566B0", Offset = "0xA554B0", VA = "0x10A566B0")]
    public static void RemoveTempCrystal(
      eOverWritePartyType _ow_party_type,
      long _unitId,
      long _crytals)
    {
    }

    [Token(Token = "0x600DA01")]
    [Address(RVA = "0xA57E10", Offset = "0xA56C10", VA = "0x10A57E10")]
    public static void UpdateInvalidSkillOverWriteData(
      UnitData unit_data,
      EInvalidSkillApplyType apply_type)
    {
    }

    [Token(Token = "0x600DA02")]
    [Address(RVA = "0xA50E00", Offset = "0xA4FC00", VA = "0x10A50E00")]
    public static UnitData CopyTempPartyInvalidSkillCommonToGvG(UnitData unitdata)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600DA03")]
    [Address(RVA = "0xA511A0", Offset = "0xA4FFA0", VA = "0x10A511A0")]
    public static UnitData CopyTempPartyInvalidSkill(
      UnitData unitdata,
      EInvalidSkillApplyType target_type,
      EInvalidSkillApplyType new_type)
    {
      return (UnitData) null;
    }

    [Token(Token = "0x600DA04")]
    [Address(RVA = "0xA52B30", Offset = "0xA51930", VA = "0x10A52B30")]
    public static void EditTempPartyInvalidSkill(
      long unit_iid,
      List<InvalidSkill> invalid_skills,
      EInvalidSkillApplyType type)
    {
    }

    [Token(Token = "0x600DA05")]
    [Address(RVA = "0xA523B0", Offset = "0xA511B0", VA = "0x10A523B0")]
    public static void DuplicateNotify(UnitData unit)
    {
    }

    [Token(Token = "0x600DA06")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitOverWriteUtility()
    {
    }

    [Token(Token = "0x600DA07")]
    [Address(RVA = "0xA581A0", Offset = "0xA56FA0", VA = "0x10A581A0")]
    static UnitOverWriteUtility()
    {
    }
  }
}
