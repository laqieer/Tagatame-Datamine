// Decompiled with JetBrains decompiler
// Type: DependencyUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x20000A8")]
public class DependencyUtility
{
  [Token(Token = "0x400033E")]
  private const string MASTER_PARAM_PATH = "Data/MasterParam";
  [Token(Token = "0x400033F")]
  private const string QUEST_PARAM_PATH = "Data/QuestParam";
  [Token(Token = "0x4000340")]
  [FieldOffset(Offset = "0x8")]
  private HashSet<string> m_Dependency;
  [Token(Token = "0x4000341")]
  [FieldOffset(Offset = "0xC")]
  private AssetList m_AssetList;
  [Token(Token = "0x4000342")]
  [FieldOffset(Offset = "0x10")]
  private BadStatusEffects.BadStatusEffectParam m_BadStatusEffectParam;
  [Token(Token = "0x4000343")]
  [FieldOffset(Offset = "0x14")]
  private JSON_InitUnit[] m_InitUnits;
  [Token(Token = "0x4000344")]
  [FieldOffset(Offset = "0x0")]
  private static DependencyUtility instance;

  [Token(Token = "0x170000AC")]
  public static DependencyUtility Instance
  {
    [Token(Token = "0x60003FC"), Address(RVA = "0xB8A6E0", Offset = "0xB894E0", VA = "0x10B8A6E0")] get
    {
      return (DependencyUtility) null;
    }
  }

  [Token(Token = "0x170000AD")]
  private BadStatusEffects.BadStatusEffectParam badStatusEffectParam
  {
    [Token(Token = "0x60003FD"), Address(RVA = "0xB8A810", Offset = "0xB89610", VA = "0x10B8A810")] get
    {
      return (BadStatusEffects.BadStatusEffectParam) null;
    }
  }

  [Token(Token = "0x170000AE")]
  private bool IsReadyToUseMasterParam
  {
    [Token(Token = "0x60003FE"), Address(RVA = "0xB8A7B0", Offset = "0xB895B0", VA = "0x10B8A7B0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x60003FF")]
  [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
  public void Initialize(AssetList assetList)
  {
  }

  [Token(Token = "0x6000400")]
  [Address(RVA = "0xB8A3E0", Offset = "0xB891E0", VA = "0x10B8A3E0")]
  private static void InitializeMaster()
  {
  }

  [Token(Token = "0x6000401")]
  [Address(RVA = "0xB860E0", Offset = "0xB84EE0", VA = "0x10B860E0")]
  public void ClearDependencies()
  {
  }

  [Token(Token = "0x6000402")]
  [Address(RVA = "0xB882E0", Offset = "0xB870E0", VA = "0x10B882E0")]
  public List<string> GetDependencies_Tutorial() => (List<string>) null;

  [Token(Token = "0x6000403")]
  [Address(RVA = "0xB87700", Offset = "0xB86500", VA = "0x10B87700")]
  public List<string> GetDependencies_Quest(QuestParam questParam) => (List<string>) null;

  [Token(Token = "0x6000404")]
  [Address(RVA = "0xB86BC0", Offset = "0xB859C0", VA = "0x10B86BC0")]
  public void GetDependencies_QuestBase(QuestParam questParam)
  {
  }

  [Token(Token = "0x6000405")]
  [Address(RVA = "0xB86FF0", Offset = "0xB85DF0", VA = "0x10B86FF0")]
  public void GetDependencies_QuestMap(QuestParam questParam)
  {
  }

  [Token(Token = "0x6000406")]
  [Address(RVA = "0xB8A2B0", Offset = "0xB890B0", VA = "0x10B8A2B0")]
  public void GetDependencies_WeatherAsset(string weatherID)
  {
  }

  [Token(Token = "0x6000407")]
  [Address(RVA = "0xB887A0", Offset = "0xB875A0", VA = "0x10B887A0")]
  public void GetDependencies_UnitData(UnitData unitData)
  {
  }

  [Token(Token = "0x6000408")]
  [Address(RVA = "0xB86B50", Offset = "0xB85950", VA = "0x10B86B50")]
  public void GetDependencies_NPCSetting(NPCSetting npc)
  {
  }

  [Token(Token = "0x6000409")]
  [Address(RVA = "0xB89460", Offset = "0xB88260", VA = "0x10B89460")]
  public void GetDependencies_Unit(Unit unit, bool dlStatusEffects = false, bool dlUnitImage = false)
  {
  }

  [Token(Token = "0x600040A")]
  [Address(RVA = "0xB89140", Offset = "0xB87F40", VA = "0x10B89140")]
  public void GetDependencies_UnitVoice(UnitParam unitParam)
  {
  }

  [Token(Token = "0x600040B")]
  [Address(RVA = "0xB86A40", Offset = "0xB85840", VA = "0x10B86A40")]
  public void GetDependencies_ArtifactParam(ArtifactParam artifactParam)
  {
  }

  [Token(Token = "0x600040C")]
  [Address(RVA = "0xB86AB0", Offset = "0xB858B0", VA = "0x10B86AB0")]
  public void GetDependencies_JobParam(JobParam jobParam)
  {
  }

  [Token(Token = "0x600040D")]
  [Address(RVA = "0xB87750", Offset = "0xB86550", VA = "0x10B87750")]
  private void GetDependencies_SkillParam(CharacterDB.Job jobData, SkillParam skill)
  {
  }

  [Token(Token = "0x600040E")]
  [Address(RVA = "0xB889D0", Offset = "0xB877D0", VA = "0x10B889D0")]
  public void GetDependencies_UnitModel(CharacterDB.Job jobData)
  {
  }

  [Token(Token = "0x600040F")]
  [Address(RVA = "0xB88850", Offset = "0xB87650", VA = "0x10B88850")]
  public void GetDependencies_UnitJobModel(CharacterDB.Job jobData)
  {
  }

  [Token(Token = "0x6000410")]
  [Address(RVA = "0xB886B0", Offset = "0xB874B0", VA = "0x10B886B0")]
  private void GetDependencies_UnitAnimation(
    CharacterDB.Job jobData,
    string animationName,
    bool addJobName,
    bool is_collabo_skill = false)
  {
  }

  [Token(Token = "0x6000411")]
  [Address(RVA = "0xB88EA0", Offset = "0xB87CA0", VA = "0x10B88EA0")]
  public void GetDependencies_UnitTransformAnimation(Unit unit, Unit skill_unit)
  {
  }

  [Token(Token = "0x6000412")]
  [Address(RVA = "0xB85ED0", Offset = "0xB84CD0", VA = "0x10B85ED0")]
  private bool AddExternalDependencies(string path) => new bool();

  [Token(Token = "0x6000413")]
  [Address(RVA = "0xB867D0", Offset = "0xB855D0", VA = "0x10B867D0")]
  private List<string> GetDependenciesFromAssetList(string path) => (List<string>) null;

  [Token(Token = "0x6000414")]
  [Address(RVA = "0xB868C0", Offset = "0xB856C0", VA = "0x10B868C0")]
  private void GetDependenciesFromAssetList(
    ref HashSet<string> dependencies,
    AssetList assetList,
    string path)
  {
  }

  [Token(Token = "0x6000415")]
  [Address(RVA = "0xB8A590", Offset = "0xB89390", VA = "0x10B8A590")]
  public static string LoadText(string path) => (string) null;

  [Token(Token = "0x6000416")]
  [Address(RVA = "0xB86280", Offset = "0xB85080", VA = "0x10B86280")]
  public NPCSetting CreateBreakObjNPC(BreakObjParam bo_param, int gx = 0, int gy = 0)
  {
    return (NPCSetting) null;
  }

  [Token(Token = "0x6000417")]
  [Address(RVA = "0xB865C0", Offset = "0xB853C0", VA = "0x10B865C0")]
  public static CharacterDB.Job GetCharacterData(UnitParam unit, JobParam job, ArtifactParam skin)
  {
    return (CharacterDB.Job) null;
  }

  [Token(Token = "0x6000418")]
  [Address(RVA = "0xB86120", Offset = "0xB84F20", VA = "0x10B86120")]
  private static void CreateAbilityChangeSkillList(
    ref List<SkillParam> sp_lists,
    SkillParam skill_param)
  {
  }

  [Token(Token = "0x6000419")]
  [Address(RVA = "0xB8A670", Offset = "0xB89470", VA = "0x10B8A670")]
  public DependencyUtility()
  {
  }
}
