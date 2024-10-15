// Decompiled with JetBrains decompiler
// Type: DownloadUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x20000C9")]
public static class DownloadUtility
{
  [Token(Token = "0x60004E0")]
  [Address(RVA = "0xC69030", Offset = "0xC67E30", VA = "0x10C69030")]
  public static void DownloadQuestBase(QuestParam q)
  {
  }

  [Token(Token = "0x60004E1")]
  [Address(RVA = "0xC695D0", Offset = "0xC683D0", VA = "0x10C695D0")]
  public static void DownloadQuestMaps(QuestParam quest, bool dlStatusEffects = false)
  {
  }

  [Token(Token = "0x60004E2")]
  [Address(RVA = "0xC69D50", Offset = "0xC68B50", VA = "0x10C69D50")]
  public static void DownloadQuestResult(QuestParam q)
  {
  }

  [Token(Token = "0x60004E3")]
  [Address(RVA = "0xC6EB30", Offset = "0xC6D930", VA = "0x10C6EB30")]
  public static void WeatherPrepareAsset(string weather_id)
  {
  }

  [Token(Token = "0x60004E4")]
  [Address(RVA = "0xC69510", Offset = "0xC68310", VA = "0x10C69510")]
  public static void DownloadQuestEnemy(JSON_MapUnit mapset)
  {
  }

  [Token(Token = "0x60004E5")]
  [Address(RVA = "0xC69E40", Offset = "0xC68C40", VA = "0x10C69E40")]
  public static void DownloadTowerQuestEnemyIcon(JSON_MapUnit mapset)
  {
  }

  [Token(Token = "0x60004E6")]
  [Address(RVA = "0xC6CAF0", Offset = "0xC6B8F0", VA = "0x10C6CAF0")]
  public static void LoadUnitIconMedium(string iname)
  {
  }

  [Token(Token = "0x60004E7")]
  [Address(RVA = "0xC69F10", Offset = "0xC68D10", VA = "0x10C69F10")]
  public static void DownloadTowerQuests(List<TowerFloorParam> floorParams)
  {
  }

  [Token(Token = "0x60004E8")]
  [Address(RVA = "0xC68EB0", Offset = "0xC67CB0", VA = "0x10C68EB0")]
  public static void DownloadMultiTowerQuest(MultiTowerFloorParam floorParam)
  {
  }

  [Token(Token = "0x60004E9")]
  [Address(RVA = "0xC68E20", Offset = "0xC67C20", VA = "0x10C68E20")]
  public static void DownloadJobEquipment(JobParam job)
  {
  }

  [Token(Token = "0x60004EA")]
  [Address(RVA = "0xC684B0", Offset = "0xC672B0", VA = "0x10C684B0")]
  public static void DownloadArtifact(ArtifactParam artifalct)
  {
  }

  [Token(Token = "0x60004EB")]
  [Address(RVA = "0xC68840", Offset = "0xC67640", VA = "0x10C68840")]
  public static void DownloadConceptCard(ConceptCardParam concept_card)
  {
  }

  [Token(Token = "0x60004EC")]
  [Address(RVA = "0xC6BAA0", Offset = "0xC6A8A0", VA = "0x10C6BAA0")]
  public static void DownloadUnit(UnitParam unit, JobData[] jobs = null)
  {
  }

  [Token(Token = "0x60004ED")]
  [Address(RVA = "0xC6E5B0", Offset = "0xC6D3B0", VA = "0x10C6E5B0")]
  private static void PrepareUnitVoice(UnitParam unitParam)
  {
  }

  [Token(Token = "0x60004EE")]
  [Address(RVA = "0xC6CE00", Offset = "0xC6BC00", VA = "0x10C6CE00")]
  private static void PrepareDownloadUnitVoice(UnitParam unitParam, ArtifactParam artifact)
  {
  }

  [Token(Token = "0x60004EF")]
  [Address(RVA = "0xC6BA30", Offset = "0xC6A830", VA = "0x10C6BA30")]
  public static void DownloadUnit(NPCSetting npc)
  {
  }

  [Token(Token = "0x60004F0")]
  [Address(RVA = "0xC6B980", Offset = "0xC6A780", VA = "0x10C6B980")]
  public static void DownloadUnit(UnitData unitData, bool dlStatusEffects = false)
  {
  }

  [Token(Token = "0x60004F1")]
  [Address(RVA = "0xC6E390", Offset = "0xC6D190", VA = "0x10C6E390")]
  public static void PrepareUnitModels(CharacterDB.Job jobData)
  {
  }

  [Token(Token = "0x60004F2")]
  [Address(RVA = "0xC6DFD0", Offset = "0xC6CDD0", VA = "0x10C6DFD0")]
  private static void PrepareUnitAnimation(
    CharacterDB.Job jobData,
    string animationName,
    bool addJobName,
    bool is_collabo_skill = false)
  {
  }

  [Token(Token = "0x60004F3")]
  [Address(RVA = "0xC6C7B0", Offset = "0xC6B5B0", VA = "0x10C6C7B0")]
  public static CharacterDB.Job GetCharacterData(UnitParam unit, JobParam job, ArtifactParam skin)
  {
    return (CharacterDB.Job) null;
  }

  [Token(Token = "0x60004F4")]
  [Address(RVA = "0xC6A0B0", Offset = "0xC68EB0", VA = "0x10C6A0B0")]
  public static void DownloadTransformAnimation(Unit unit, Unit skill_unit)
  {
  }

  [Token(Token = "0x60004F5")]
  [Address(RVA = "0xC6A330", Offset = "0xC69130", VA = "0x10C6A330")]
  public static void DownloadUnit(
    Unit unit,
    bool dlStatusEffects = false,
    bool dlUnitImage = false,
    List<SkillData> addBattleSkill = null)
  {
  }

  [Token(Token = "0x60004F6")]
  [Address(RVA = "0xC67FC0", Offset = "0xC66DC0", VA = "0x10C67FC0")]
  private static void CreateAbilityChangeSkillList(
    ref List<SkillParam> sp_lists,
    SkillParam skill_param)
  {
  }

  [Token(Token = "0x60004F7")]
  [Address(RVA = "0xC6E9D0", Offset = "0xC6D7D0", VA = "0x10C6E9D0")]
  private static void ReplacementSkillAdd(Unit unit, ref List<SkillParam> sp_lists)
  {
  }

  [Token(Token = "0x60004F8")]
  [Address(RVA = "0xC6E140", Offset = "0xC6CF40", VA = "0x10C6E140")]
  public static void PrepareUnitAssets(CharacterDB.Job jobData)
  {
  }

  [Token(Token = "0x60004F9")]
  [Address(RVA = "0xC6D460", Offset = "0xC6C260", VA = "0x10C6D460")]
  public static void PrepareJobAssets(JobParam job)
  {
  }

  [Token(Token = "0x60004FA")]
  [Address(RVA = "0xC68170", Offset = "0xC66F70", VA = "0x10C68170")]
  public static NPCSetting CreateBreakObjNPC(BreakObjParam bo_param, int gx = 0, int gy = 0)
  {
    return (NPCSetting) null;
  }

  [Token(Token = "0x60004FB")]
  [Address(RVA = "0xC6D680", Offset = "0xC6C480", VA = "0x10C6D680")]
  private static void PrepareSkillAssets(CharacterDB.Job jobData, SkillParam skill)
  {
  }

  [Token(Token = "0x60004FC")]
  [Address(RVA = "0xC6D1C0", Offset = "0xC6BFC0", VA = "0x10C6D1C0")]
  public static void PrepareInventoryAssets(ItemData[] items = null)
  {
  }

  [Token(Token = "0x60004FD")]
  [Address(RVA = "0xC68540", Offset = "0xC67340", VA = "0x10C68540")]
  private static void DownloadBuffEffect(string _iname)
  {
  }

  [Token(Token = "0x60004FE")]
  [Address(RVA = "0xC6D060", Offset = "0xC6BE60", VA = "0x10C6D060")]
  public static void PrepareHomeBGAssets(SectionParam section)
  {
  }

  [Token(Token = "0x60004FF")]
  [Address(RVA = "0xC6D560", Offset = "0xC6C360", VA = "0x10C6D560")]
  public static void PrepareRaidBossAsset(RaidBossParam raidBoss)
  {
  }

  [Token(Token = "0x6000500")]
  [Address(RVA = "0xC6CF40", Offset = "0xC6BD40", VA = "0x10C6CF40")]
  public static void PrepareGuildRaidBossAsset(GuildRaidBossParam guildRaidBoss)
  {
  }

  [Token(Token = "0x6000501")]
  [Address(RVA = "0xC6CD30", Offset = "0xC6BB30", VA = "0x10C6CD30")]
  public static void PrepareAutoRepeatQuestUnitAssets(UnitData unit_data)
  {
  }

  [Token(Token = "0x6000502")]
  [Address(RVA = "0xC6D540", Offset = "0xC6C340", VA = "0x10C6D540")]
  public static void PrepareQuestAllAssets(QuestParam questParam, bool dsStatusEffects)
  {
  }

  [Token(Token = "0x6000503")]
  [Address(RVA = "0xC6E800", Offset = "0xC6D600", VA = "0x10C6E800")]
  private static void PrepareUnmanagedEventAsset(string demoID)
  {
  }

  [Token(Token = "0x6000504")]
  [Address(RVA = "0xC6CC70", Offset = "0xC6BA70", VA = "0x10C6CC70")]
  public static void PrepareAssetByAssetBundleFlags(AssetBundleFlags flags)
  {
  }

  [Token(Token = "0x6000505")]
  [Address(RVA = "0xC6E890", Offset = "0xC6D690", VA = "0x10C6E890")]
  public static void PrepareWorldRaidBossAsset(WorldRaidParam.BossInfo _info)
  {
  }
}
