// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E35")]
  [MessagePackObject(true)]
  public class AbilityData
  {
    [Token(Token = "0x4002B36")]
    public const long UNIQUE_ID_MAP_EFFECT = -1;
    [Token(Token = "0x4002B37")]
    [FieldOffset(Offset = "0x8")]
    private UnitData mOwner;
    [Token(Token = "0x4002B38")]
    [FieldOffset(Offset = "0x10")]
    private OLong mUniqueID;
    [Token(Token = "0x4002B39")]
    [FieldOffset(Offset = "0x38")]
    private AbilityParam mAbilityParam;
    [Token(Token = "0x4002B3A")]
    [FieldOffset(Offset = "0x3C")]
    private OInt mExp;
    [Token(Token = "0x4002B3B")]
    [FieldOffset(Offset = "0x50")]
    private OInt mRank;
    [Token(Token = "0x4002B3C")]
    [FieldOffset(Offset = "0x64")]
    private OInt mRankCap;
    [Token(Token = "0x4002B3D")]
    [FieldOffset(Offset = "0x78")]
    private List<SkillData> mSkills;
    [Token(Token = "0x4002B3E")]
    [FieldOffset(Offset = "0x7C")]
    public bool IsNoneCategory;
    [Token(Token = "0x4002B3F")]
    [FieldOffset(Offset = "0x7D")]
    public bool IsHideList;
    [Token(Token = "0x4002B40")]
    [FieldOffset(Offset = "0x80")]
    private AbilityData m_BaseAbility;
    [Token(Token = "0x4002B41")]
    [FieldOffset(Offset = "0x84")]
    private List<AbilityData> m_DeriveAbility;
    [Token(Token = "0x4002B42")]
    [FieldOffset(Offset = "0x88")]
    private List<SkillData> m_DeriveSkills;
    [Token(Token = "0x4002B43")]
    [FieldOffset(Offset = "0x8C")]
    private AbilityDeriveParam m_AbilityDeriveParam;
    [Token(Token = "0x4002B44")]
    [FieldOffset(Offset = "0x90")]
    private ConceptCardEffectDecreaseInfo m_ConceptCardEffectDecreaseInfo;

    [Token(Token = "0x17000441")]
    public UnitData Owner
    {
      [Token(Token = "0x6003AA0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17000442")]
    public long UniqueID
    {
      [Token(Token = "0x6003AA1"), Address(RVA = "0x10CB8C0", Offset = "0x10CA6C0", VA = "0x110CB8C0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000443")]
    public AbilityParam Param
    {
      [Token(Token = "0x6003AA2"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (AbilityParam) null;
      }
    }

    [Token(Token = "0x17000444")]
    public string AbilityID
    {
      [Token(Token = "0x6003AA3"), Address(RVA = "0x10CB710", Offset = "0x10CA510", VA = "0x110CB710")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000445")]
    public string AbilityName
    {
      [Token(Token = "0x6003AA4"), Address(RVA = "0x10CB730", Offset = "0x10CA530", VA = "0x110CB730")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000446")]
    public int Rank
    {
      [Token(Token = "0x6003AA5"), Address(RVA = "0xA45FF0", Offset = "0xA44DF0", VA = "0x10A45FF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000447")]
    public int Exp
    {
      [Token(Token = "0x6003AA6"), Address(RVA = "0xA457E0", Offset = "0xA445E0", VA = "0x10A457E0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000448")]
    public EAbilityType AbilityType
    {
      [Token(Token = "0x6003AA7"), Address(RVA = "0x10CB750", Offset = "0x10CA550", VA = "0x110CB750")] get
      {
        return new EAbilityType();
      }
    }

    [Token(Token = "0x17000449")]
    public EAbilitySlot SlotType
    {
      [Token(Token = "0x6003AA8"), Address(RVA = "0x10CB8A0", Offset = "0x10CA6A0", VA = "0x110CB8A0")] get
      {
        return new EAbilitySlot();
      }
    }

    [Token(Token = "0x1700044A")]
    public LearningSkill[] LearningSkills
    {
      [Token(Token = "0x6003AA9"), Address(RVA = "0x10CB860", Offset = "0x10CA660", VA = "0x110CB860")] get
      {
        return (LearningSkill[]) null;
      }
    }

    [Token(Token = "0x1700044B")]
    public List<SkillData> Skills
    {
      [Token(Token = "0x6003AAA"), Address(RVA = "0x10CB880", Offset = "0x10CA680", VA = "0x110CB880")] get
      {
        return (List<SkillData>) null;
      }
    }

    [Token(Token = "0x1700044C")]
    public bool IsDerivedAbility
    {
      [Token(Token = "0x6003AAB"), Address(RVA = "0x10CB840", Offset = "0x10CA640", VA = "0x110CB840")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700044D")]
    public bool IsDeriveBaseAbility
    {
      [Token(Token = "0x6003AAC"), Address(RVA = "0x10CB800", Offset = "0x10CA600", VA = "0x110CB800")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700044E")]
    public AbilityData DeriveBaseAbility
    {
      [Token(Token = "0x6003AAD"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x1700044F")]
    public AbilityDeriveParam DeriveParam
    {
      [Token(Token = "0x6003AAE"), Address(RVA = "0x2B5F90", Offset = "0x2B4D90", VA = "0x102B5F90")] get
      {
        return (AbilityDeriveParam) null;
      }
    }

    [Token(Token = "0x17000450")]
    public AbilityData DerivedAbility
    {
      [Token(Token = "0x6003AAF"), Address(RVA = "0x10CB770", Offset = "0x10CA570", VA = "0x110CB770")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x17000451")]
    public bool IsCreatedByConceptCard
    {
      [Token(Token = "0x6003AB0"), Address(RVA = "0x10CB7E0", Offset = "0x10CA5E0", VA = "0x110CB7E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003AB1")]
    [Address(RVA = "0x10CA370", Offset = "0x10C9170", VA = "0x110CA370")]
    public void Setup(
      UnitData owner,
      long iid,
      string iname,
      int exp,
      int rank_cap = 0,
      ConceptCardEffectDecreaseInfo decreaseInfo = null)
    {
    }

    [Token(Token = "0x6003AB2")]
    [Address(RVA = "0x10CA2D0", Offset = "0x10C90D0", VA = "0x110CA2D0")]
    private void Reset()
    {
    }

    [Token(Token = "0x6003AB3")]
    [Address(RVA = "0xFCAE30", Offset = "0xFC9C30", VA = "0x10FCAE30")]
    public bool IsValid() => new bool();

    [Token(Token = "0x6003AB4")]
    [Address(RVA = "0x10C9DF0", Offset = "0x10C8BF0", VA = "0x110C9DF0")]
    public int GetRankCap() => new int();

    [Token(Token = "0x6003AB5")]
    [Address(RVA = "0x10C9E90", Offset = "0x10C8C90", VA = "0x110C9E90")]
    public int GetRankMaxCap() => new int();

    [Token(Token = "0x6003AB6")]
    [Address(RVA = "0x10C9020", Offset = "0x10C7E20", VA = "0x110C9020")]
    public int CalcRank() => new int();

    [Token(Token = "0x6003AB7")]
    [Address(RVA = "0x10C9D50", Offset = "0x10C8B50", VA = "0x110C9D50")]
    public int GetNextGold() => new int();

    [Token(Token = "0x6003AB8")]
    [Address(RVA = "0x10C9600", Offset = "0x10C8400", VA = "0x110C9600")]
    public void GainExp(int exp = 1)
    {
    }

    [Token(Token = "0x6003AB9")]
    [Address(RVA = "0x10CAFB0", Offset = "0x10C9DB0", VA = "0x110CAFB0")]
    public void UpdateLearningsSkill(bool locked, List<SkillData> sd_lists = null)
    {
    }

    [Token(Token = "0x6003ABA")]
    [Address(RVA = "0x10CA200", Offset = "0x10C9000", VA = "0x110CA200")]
    public void ReplaceSkills(List<SkillData> rpl_lists)
    {
    }

    [Token(Token = "0x6003ABB")]
    [Address(RVA = "0x10CA0D0", Offset = "0x10C8ED0", VA = "0x110CA0D0")]
    private void ReplaceSkills(List<SkillData> org_lists, List<SkillData> rpl_lists)
    {
    }

    [Token(Token = "0x6003ABC")]
    [Address(RVA = "0x10C9910", Offset = "0x10C8710", VA = "0x110C9910")]
    public List<string> GetLearningSkillList2(int rank) => (List<string>) null;

    [Token(Token = "0x6003ABD")]
    [Address(RVA = "0x10C9C10", Offset = "0x10C8A10", VA = "0x110C9C10")]
    public List<string> GetLearningSkillList(int rank) => (List<string>) null;

    [Token(Token = "0x6003ABE")]
    [Address(RVA = "0x10C90A0", Offset = "0x10C7EA0", VA = "0x110C90A0")]
    public bool CheckEnableUseAbility(UnitData self, int job_index) => new bool();

    [Token(Token = "0x6003ABF")]
    [Address(RVA = "0x10CA8B0", Offset = "0x10C96B0", VA = "0x110CA8B0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6003AC0")]
    [Address(RVA = "0x10CA5D0", Offset = "0x10C93D0", VA = "0x110CA5D0")]
    public static MixedAbilityData ToMix(AbilityData[] abilitys, string name, string iconName)
    {
      return (MixedAbilityData) null;
    }

    [Token(Token = "0x6003AC1")]
    [Address(RVA = "0x10C9470", Offset = "0x10C8270", VA = "0x110C9470")]
    public SkillData FindSkillDataInSkills(string iname) => (SkillData) null;

    [Token(Token = "0x6003AC2")]
    [Address(RVA = "0x10CACF0", Offset = "0x10C9AF0", VA = "0x110CACF0")]
    public void UpdateLearningsSkillCollabo(Json_CollaboSkill[] skills)
    {
    }

    [Token(Token = "0x6003AC3")]
    [Address(RVA = "0x10C90D0", Offset = "0x10C7ED0", VA = "0x110C90D0")]
    public AbilityData CreateDeriveAbility(AbilityDeriveParam deriveParam) => (AbilityData) null;

    [Token(Token = "0x6003AC4")]
    [Address(RVA = "0x10C9F00", Offset = "0x10C8D00", VA = "0x110C9F00")]
    private static List<SkillData> MakeDerivedSkillList(
      List<SkillData> originSkills,
      List<SkillData> deriveSkills)
    {
      return (List<SkillData>) null;
    }

    [Token(Token = "0x6003AC5")]
    [Address(RVA = "0x10CA230", Offset = "0x10C9030", VA = "0x110CA230")]
    public void ResetDeriveAbility()
    {
    }

    [Token(Token = "0x6003AC6")]
    [Address(RVA = "0x10C8EE0", Offset = "0x10C7CE0", VA = "0x110C8EE0")]
    public void AddDeriveAbility(AbilityData deriveAbility)
    {
    }

    [Token(Token = "0x6003AC7")]
    [Address(RVA = "0x10C8F80", Offset = "0x10C7D80", VA = "0x110C8F80")]
    public void AddDeriveSkill(SkillData skillData)
    {
    }

    [Token(Token = "0x6003AC8")]
    [Address(RVA = "0x10C91D0", Offset = "0x10C7FD0", VA = "0x110C91D0")]
    public string[] FindDeriveSkillIDs(string baseSkillIname) => (string[]) null;

    [Token(Token = "0x6003AC9")]
    [Address(RVA = "0x10C9380", Offset = "0x10C8180", VA = "0x110C9380")]
    public SkillData[] FindDeriveSkills(string baseSkillIname) => (SkillData[]) null;

    [Token(Token = "0x6003ACA")]
    [Address(RVA = "0x10CB680", Offset = "0x10CA480", VA = "0x110CB680")]
    public AbilityData()
    {
    }
  }
}
