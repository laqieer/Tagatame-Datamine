// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E59")]
  [MessagePackObject(true)]
  public class ArtifactData
  {
    [Token(Token = "0x4002BC2")]
    [FieldOffset(Offset = "0x8")]
    private OLong mUniqueID;
    [Token(Token = "0x4002BC3")]
    [FieldOffset(Offset = "0x30")]
    private ArtifactParam mArtifactParam;
    [Token(Token = "0x4002BC4")]
    [FieldOffset(Offset = "0x34")]
    private RarityParam mRarityParam;
    [Token(Token = "0x4002BC5")]
    [FieldOffset(Offset = "0x38")]
    private OInt mRarity;
    [Token(Token = "0x4002BC6")]
    [FieldOffset(Offset = "0x4C")]
    private OInt mLv;
    [Token(Token = "0x4002BC7")]
    [FieldOffset(Offset = "0x60")]
    private OInt mExp;
    [Token(Token = "0x4002BC8")]
    [FieldOffset(Offset = "0x74")]
    private bool mFavorite;
    [Token(Token = "0x4002BC9")]
    [FieldOffset(Offset = "0x78")]
    private SkillData mEquipSkill;
    [Token(Token = "0x4002BCA")]
    [FieldOffset(Offset = "0x7C")]
    private SkillData mBattleEffectSkill;
    [Token(Token = "0x4002BCB")]
    [FieldOffset(Offset = "0x80")]
    private List<AbilityData> mLearningAbilities;
    [Token(Token = "0x4002BCC")]
    [FieldOffset(Offset = "0x84")]
    private OInt mInspirationSkillSlotNum;
    [Token(Token = "0x4002BCD")]
    [FieldOffset(Offset = "0x98")]
    private List<InspirationSkillData> mInspirationSkillList;
    [Token(Token = "0x4002BCE")]
    [FieldOffset(Offset = "0x9C")]
    private bool mIsOpenStoneEff;
    [Token(Token = "0x4002BCF")]
    [FieldOffset(Offset = "0xA0")]
    private string mStoneSkillIname;
    [Token(Token = "0x4002BD0")]
    [FieldOffset(Offset = "0xA4")]
    private eArtifactSortType sortType;
    [Token(Token = "0x4002BD1")]
    [FieldOffset(Offset = "0xA8")]
    private int sortValue;
    [Token(Token = "0x4002BD2")]
    [FieldOffset(Offset = "0x0")]
    private static BaseStatus WorkScaleStatus;

    [Token(Token = "0x17000458")]
    public int Exp
    {
      [Token(Token = "0x6003B15"), Address(RVA = "0xA23600", Offset = "0xA22400", VA = "0x10A23600")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000459")]
    public OLong UniqueID
    {
      [Token(Token = "0x6003B16"), Address(RVA = "0x305BB0", Offset = "0x3049B0", VA = "0x10305BB0")] get
      {
        return new OLong();
      }
    }

    [Token(Token = "0x1700045A")]
    public ArtifactParam ArtifactParam
    {
      [Token(Token = "0x6003B17"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (ArtifactParam) null;
      }
    }

    [Token(Token = "0x1700045B")]
    public RarityParam RarityParam
    {
      [Token(Token = "0x6003B18"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (RarityParam) null;
      }
    }

    [Token(Token = "0x1700045C")]
    public OInt Rarity
    {
      [Token(Token = "0x6003B19"), Address(RVA = "0x3A6630", Offset = "0x3A5430", VA = "0x103A6630")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700045D")]
    public OInt RarityCap
    {
      [Token(Token = "0x6003B1A"), Address(RVA = "0x10D23C0", Offset = "0x10D11C0", VA = "0x110D23C0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700045E")]
    public OInt Lv
    {
      [Token(Token = "0x6003B1B"), Address(RVA = "0x3A6650", Offset = "0x3A5450", VA = "0x103A6650")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700045F")]
    public OInt LvCap
    {
      [Token(Token = "0x6003B1C"), Address(RVA = "0x10D2360", Offset = "0x10D1160", VA = "0x110D2360")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000460")]
    public ItemParam Kakera
    {
      [Token(Token = "0x6003B1D"), Address(RVA = "0x10D2300", Offset = "0x10D1100", VA = "0x110D2300")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000461")]
    public ItemData KakeraData
    {
      [Token(Token = "0x6003B1E"), Address(RVA = "0x10D2260", Offset = "0x10D1060", VA = "0x110D2260")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17000462")]
    public ItemParam RarityKakera
    {
      [Token(Token = "0x6003B1F"), Address(RVA = "0x10D2540", Offset = "0x10D1340", VA = "0x110D2540")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000463")]
    public ItemData RarityKakeraData
    {
      [Token(Token = "0x6003B20"), Address(RVA = "0x10D2400", Offset = "0x10D1200", VA = "0x110D2400")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17000464")]
    public ItemParam CommonKakera
    {
      [Token(Token = "0x6003B21"), Address(RVA = "0x10D2170", Offset = "0x10D0F70", VA = "0x110D2170")] get
      {
        return (ItemParam) null;
      }
    }

    [Token(Token = "0x17000465")]
    public ItemData CommonKakeraData
    {
      [Token(Token = "0x6003B22"), Address(RVA = "0x10D20B0", Offset = "0x10D0EB0", VA = "0x110D20B0")] get
      {
        return (ItemData) null;
      }
    }

    [Token(Token = "0x17000466")]
    public bool IsFavorite
    {
      [Token(Token = "0x6003B23"), Address(RVA = "0x445580", Offset = "0x444380", VA = "0x10445580")] get
      {
        return new bool();
      }
      [Token(Token = "0x6003B24"), Address(RVA = "0x579A70", Offset = "0x578870", VA = "0x10579A70")] set
      {
      }
    }

    [Token(Token = "0x17000467")]
    public SkillData EquipSkill
    {
      [Token(Token = "0x6003B25"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x17000468")]
    public SkillData BattleEffectSkill
    {
      [Token(Token = "0x6003B26"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x17000469")]
    public List<AbilityData> LearningAbilities
    {
      [Token(Token = "0x6003B27"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x1700046A")]
    public OInt InspirationSkillSlotNum
    {
      [Token(Token = "0x6003B28"), Address(RVA = "0x10D21F0", Offset = "0x10D0FF0", VA = "0x110D21F0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700046B")]
    public List<InspirationSkillData> InspirationSkillList
    {
      [Token(Token = "0x6003B29"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (List<InspirationSkillData>) null;
      }
    }

    [Token(Token = "0x1700046C")]
    public bool IsOpenStoneEff
    {
      [Token(Token = "0x6003B2A"), Address(RVA = "0x7446B0", Offset = "0x7434B0", VA = "0x107446B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700046D")]
    public string StoneEffectIname
    {
      [Token(Token = "0x6003B2B"), Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700046E")]
    public bool IsExchangeConversionStone
    {
      [Token(Token = "0x6003B2C"), Address(RVA = "0x10D2210", Offset = "0x10D1010", VA = "0x110D2210")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700046F")]
    public int SortValue
    {
      [Token(Token = "0x6003B2D"), Address(RVA = "0x4601C0", Offset = "0x45EFC0", VA = "0x104601C0")] get
      {
        return new int();
      }
      [Token(Token = "0x6003B2E"), Address(RVA = "0x690E80", Offset = "0x68FC80", VA = "0x10690E80")] set
      {
      }
    }

    [Token(Token = "0x17000470")]
    public eArtifactSortType SortType
    {
      [Token(Token = "0x6003B2F"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return new eArtifactSortType();
      }
      [Token(Token = "0x6003B30"), Address(RVA = "0x6855C0", Offset = "0x6843C0", VA = "0x106855C0")] set
      {
      }
    }

    [Token(Token = "0x6003B31")]
    [Address(RVA = "0x10CE2F0", Offset = "0x10CD0F0", VA = "0x110CE2F0")]
    public void Deserialize(Json_Artifact json)
    {
    }

    [Token(Token = "0x6003B32")]
    [Address(RVA = "0x10CE190", Offset = "0x10CCF90", VA = "0x110CE190")]
    public void DeserializeInspSkill(Json_InspirationSkill json)
    {
    }

    [Token(Token = "0x6003B33")]
    [Address(RVA = "0x10D0EA0", Offset = "0x10CFCA0", VA = "0x110D0EA0")]
    public void RemoveInspSkill(long uniqueId)
    {
    }

    [Token(Token = "0x6003B34")]
    [Address(RVA = "0x10D0FB0", Offset = "0x10CFDB0", VA = "0x110D0FB0")]
    public void Reset()
    {
    }

    [Token(Token = "0x6003B35")]
    [Address(RVA = "0x10CDC20", Offset = "0x10CCA20", VA = "0x110CDC20")]
    public ArtifactData Copy() => (ArtifactData) null;

    [Token(Token = "0x6003B36")]
    [Address(RVA = "0x10D0BD0", Offset = "0x10CF9D0", VA = "0x110D0BD0")]
    public bool IsValid() => new bool();

    [Token(Token = "0x6003B37")]
    [Address(RVA = "0x10D15E0", Offset = "0x10D03E0", VA = "0x110D15E0")]
    private void UpdateLearningAbilities(bool bRarityUp = false)
    {
    }

    [Token(Token = "0x6003B38")]
    [Address(RVA = "0x10D1600", Offset = "0x10D0400", VA = "0x110D1600")]
    private void UpdateLearningArtifactAbilities(bool bRarityUp = false)
    {
    }

    [Token(Token = "0x6003B39")]
    [Address(RVA = "0x10D1990", Offset = "0x10D0790", VA = "0x110D1990")]
    private void UpdateLearningStoneAbilities(bool bRarityUp = false)
    {
    }

    [Token(Token = "0x6003B3A")]
    [Address(RVA = "0x10CEF20", Offset = "0x10CDD20", VA = "0x110CEF20")]
    public List<AbilityData> GetEnableAbitilies(UnitData unit, int job_index)
    {
      return (List<AbilityData>) null;
    }

    [Token(Token = "0x6003B3B")]
    [Address(RVA = "0x10CEA00", Offset = "0x10CD800", VA = "0x110CEA00")]
    public List<SkillData> GetAllLearningSkills(UnitData unit, int job_index)
    {
      return (List<SkillData>) null;
    }

    [Token(Token = "0x6003B3C")]
    [Address(RVA = "0x10CD7A0", Offset = "0x10CC5A0", VA = "0x110CD7A0")]
    public bool CheckEnableEquip(UnitData unit, int jobIndex = -1) => new bool();

    [Token(Token = "0x6003B3D")]
    [Address(RVA = "0x10D1220", Offset = "0x10D0020", VA = "0x110D1220")]
    private void UpdateEquipEffect()
    {
    }

    [Token(Token = "0x6003B3E")]
    [Address(RVA = "0x10CF940", Offset = "0x10CE740", VA = "0x110CF940")]
    public int GetLevelCap() => new int();

    [Token(Token = "0x6003B3F")]
    [Address(RVA = "0x10CF980", Offset = "0x10CE780", VA = "0x110CF980")]
    public int GetLevelFromExp(int exp) => new int();

    [Token(Token = "0x6003B40")]
    [Address(RVA = "0x10D1140", Offset = "0x10CFF40", VA = "0x110D1140")]
    public static int StaticCalcLevelFromExp(int exp) => new int();

    [Token(Token = "0x6003B41")]
    [Address(RVA = "0x10D0230", Offset = "0x10CF030", VA = "0x110D0230")]
    public int GetTotalExpFromLevel(int lv) => new int();

    [Token(Token = "0x6003B42")]
    [Address(RVA = "0x10D1060", Offset = "0x10CFE60", VA = "0x110D1060")]
    public static int StaticCalcExpFromLevel(int lv) => new int();

    [Token(Token = "0x6003B43")]
    [Address(RVA = "0x10CFB00", Offset = "0x10CE900", VA = "0x110CFB00")]
    public int GetNextExpFromLevel(int lv) => new int();

    [Token(Token = "0x6003B44")]
    [Address(RVA = "0x10D01D0", Offset = "0x10CEFD0", VA = "0x110D01D0")]
    public int GetShowExp() => new int();

    [Token(Token = "0x6003B45")]
    [Address(RVA = "0x10CFC20", Offset = "0x10CEA20", VA = "0x110CFC20")]
    public int GetNextExp() => new int();

    [Token(Token = "0x6003B46")]
    [Address(RVA = "0x10CE6F0", Offset = "0x10CD4F0", VA = "0x110CE6F0")]
    public void GainExp(ItemData item, int num)
    {
    }

    [Token(Token = "0x6003B47")]
    [Address(RVA = "0x10CE8A0", Offset = "0x10CD6A0", VA = "0x110CE8A0")]
    public void GainExp(int exp)
    {
    }

    [Token(Token = "0x6003B48")]
    [Address(RVA = "0x10CF050", Offset = "0x10CDE50", VA = "0x110CF050")]
    public int GetGainExpCap() => new int();

    [Token(Token = "0x6003B49")]
    [Address(RVA = "0x10D0BE0", Offset = "0x10CF9E0", VA = "0x110D0BE0")]
    public void LevelUp()
    {
    }

    [Token(Token = "0x6003B4A")]
    [Address(RVA = "0x10CF6D0", Offset = "0x10CE4D0", VA = "0x110CF6D0")]
    public int GetKakeraCreateNum() => new int();

    [Token(Token = "0x6003B4B")]
    [Address(RVA = "0x10CF830", Offset = "0x10CE630", VA = "0x110CF830")]
    public int GetKakeraNeedNum() => new int();

    [Token(Token = "0x6003B4C")]
    [Address(RVA = "0x10CF690", Offset = "0x10CE490", VA = "0x110CF690")]
    public int GetKakeraChangeNum() => new int();

    [Token(Token = "0x6003B4D")]
    [Address(RVA = "0x10CD6A0", Offset = "0x10CC4A0", VA = "0x110CD6A0")]
    public bool CheckEnableCreate() => new bool();

    [Token(Token = "0x6003B4E")]
    [Address(RVA = "0x10CF870", Offset = "0x10CE670", VA = "0x110CF870")]
    public int GetKakeraNumForRarityUp() => new int();

    [Token(Token = "0x6003B4F")]
    [Address(RVA = "0x10CF710", Offset = "0x10CE510", VA = "0x110CF710")]
    public List<ItemData> GetKakeraDataListForRarityUp() => (List<ItemData>) null;

    [Token(Token = "0x6003B50")]
    [Address(RVA = "0x10CD7D0", Offset = "0x10CC5D0", VA = "0x110CD7D0")]
    public ArtifactData.RarityUpResults CheckEnableRarityUp() => new ArtifactData.RarityUpResults();

    [Token(Token = "0x6003B51")]
    [Address(RVA = "0x10CDA40", Offset = "0x10CC840", VA = "0x110CDA40")]
    public bool ConsumeKakera(int num) => new bool();

    [Token(Token = "0x6003B52")]
    [Address(RVA = "0x10D0C10", Offset = "0x10CFA10", VA = "0x110D0C10")]
    public void RarityUp()
    {
    }

    [Token(Token = "0x6003B53")]
    [Address(RVA = "0x10D0170", Offset = "0x10CEF70", VA = "0x110D0170")]
    public int GetSellPrice() => new int();

    [Token(Token = "0x6003B54")]
    [Address(RVA = "0x10CF0B0", Offset = "0x10CDEB0", VA = "0x110CF0B0")]
    public void GetHomePassiveBuffDrawStatus(
      ref BaseStatus fixed_status,
      ref BaseStatus scale_status,
      UnitData user = null,
      int job_index = 0,
      bool bCheckCondition = true)
    {
    }

    [Token(Token = "0x6003B55")]
    [Address(RVA = "0x10CF0E0", Offset = "0x10CDEE0", VA = "0x110CF0E0")]
    public void GetHomePassiveBuffStatus(
      ref BaseStatus fixed_status,
      ref BaseStatus scale_status,
      UnitData user = null,
      int job_index = 0,
      bool bCheckCondition = true,
      bool isDraw = false)
    {
    }

    [Token(Token = "0x6003B56")]
    [Address(RVA = "0x10CD410", Offset = "0x10CC210", VA = "0x110CD410")]
    private void CalcStatus_ArtifactStoneAbility(
      ref BaseStatus fixed_status,
      ref BaseStatus scale_status)
    {
    }

    [Token(Token = "0x6003B57")]
    [Address(RVA = "0x10CD9B0", Offset = "0x10CC7B0", VA = "0x110CD9B0")]
    public bool CheckEquiped() => new bool();

    [Token(Token = "0x6003B58")]
    [Address(RVA = "0x10D0910", Offset = "0x10CF710", VA = "0x110D0910")]
    public bool IsInspiration() => new bool();

    [Token(Token = "0x6003B59")]
    [Address(RVA = "0x10D1E70", Offset = "0x10D0C70", VA = "0x110D1E70")]
    public bool UsableInspirationSkillLvUp(
      ArtifactParam source_artifact_param,
      AbilityParam source_ability_param)
    {
      return new bool();
    }

    [Token(Token = "0x6003B5A")]
    [Address(RVA = "0x10CEE10", Offset = "0x10CDC10", VA = "0x110CEE10")]
    public InspirationSkillData GetCurrentInspirationSkillData() => (InspirationSkillData) null;

    [Token(Token = "0x6003B5B")]
    [Address(RVA = "0x10CF5C0", Offset = "0x10CE3C0", VA = "0x110CF5C0")]
    public InspirationSkillData GetInspirationSkillDataBySlot(int slot_no)
    {
      return (InspirationSkillData) null;
    }

    [Token(Token = "0x6003B5C")]
    [Address(RVA = "0x10D08A0", Offset = "0x10CF6A0", VA = "0x110D08A0")]
    public bool IsEquipped(bool is_include_over_write = false) => new bool();

    [Token(Token = "0x6003B5D")]
    [Address(RVA = "0x10CFC80", Offset = "0x10CEA80", VA = "0x110CFC80")]
    public int GetNextOpenInspSlot() => new int();

    [Token(Token = "0x6003B5E")]
    [Address(RVA = "0x10D03A0", Offset = "0x10CF1A0", VA = "0x110D03A0")]
    public int GetTotalInspLvUpCount(InspSkillParam base_skill_param, List<ArtifactData> materials)
    {
      return new int();
    }

    [Token(Token = "0x6003B5F")]
    [Address(RVA = "0x10CF350", Offset = "0x10CE150", VA = "0x110CF350")]
    private int GetInspLvUpCount(InspSkillParam base_skill_param, ArtifactData material)
    {
      return new int();
    }

    [Token(Token = "0x6003B60")]
    [Address(RVA = "0x10D04E0", Offset = "0x10CF2E0", VA = "0x110D04E0")]
    public List<ArtifactData> InspMaterialListSort(
      InspSkillParam base_skill_param,
      List<ArtifactData> materials)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x6003B61")]
    [Address(RVA = "0x10D07F0", Offset = "0x10CF5F0", VA = "0x110D07F0")]
    public bool IsAddStone() => new bool();

    [Token(Token = "0x6003B62")]
    [Address(RVA = "0x10D0AD0", Offset = "0x10CF8D0", VA = "0x110D0AD0")]
    public bool IsStoneCost() => new bool();

    [Token(Token = "0x6003B63")]
    [Address(RVA = "0x10D0A20", Offset = "0x10CF820", VA = "0x110D0A20")]
    public bool IsSameBaseAndOtherIndividual(ArtifactData artifact) => new bool();

    [Token(Token = "0x6003B64")]
    [Address(RVA = "0x10D09C0", Offset = "0x10CF7C0", VA = "0x110D09C0")]
    public bool IsLimitCheck(int minLevel, int minRarity) => new bool();

    [Token(Token = "0x6003B65")]
    [Address(RVA = "0x10CFD00", Offset = "0x10CEB00", VA = "0x110CFD00")]
    public bool GetOwner(List<UnitData> units, out UnitData owner, out JobData owner_job)
    {
      return new bool();
    }

    [Token(Token = "0x6003B66")]
    [Address(RVA = "0x10CFF50", Offset = "0x10CED50", VA = "0x110CFF50")]
    public List<UnitData> GetOwners(List<UnitData> units) => (List<UnitData>) null;

    [Token(Token = "0x6003B67")]
    [Address(RVA = "0x10D0F90", Offset = "0x10CFD90", VA = "0x110D0F90")]
    public void ResetSortValue()
    {
    }

    [Token(Token = "0x6003B68")]
    [Address(RVA = "0x10CDA20", Offset = "0x10CC820", VA = "0x110CDA20")]
    public bool CheckSortValue() => new bool();

    [Token(Token = "0x6003B69")]
    [Address(RVA = "0x10CDE90", Offset = "0x10CCC90", VA = "0x110CDE90")]
    public static ArtifactData CreateArtifactDataForDisplay(string iname, int rarity = -1)
    {
      return (ArtifactData) null;
    }

    [Token(Token = "0x6003B6A")]
    [Address(RVA = "0x10CE070", Offset = "0x10CCE70", VA = "0x110CE070")]
    public static ArtifactData CreateArtifactDataForDisplay(ArtifactParam param, int rarity = -1)
    {
      return (ArtifactData) null;
    }

    [Token(Token = "0x6003B6B")]
    [Address(RVA = "0x10D2030", Offset = "0x10D0E30", VA = "0x110D2030")]
    public ArtifactData()
    {
    }

    [Token(Token = "0x6003B6C")]
    [Address(RVA = "0x10D1FC0", Offset = "0x10D0DC0", VA = "0x110D1FC0")]
    static ArtifactData()
    {
    }

    [Token(Token = "0x2000E5A")]
    [Flags]
    public enum RarityUpResults
    {
      [Token(Token = "0x4002BD4")] Success = 0,
      [Token(Token = "0x4002BD5")] NoLv = 1,
      [Token(Token = "0x4002BD6")] NoGold = 2,
      [Token(Token = "0x4002BD7")] NoKakera = 4,
      [Token(Token = "0x4002BD8")] RarityMaxed = 8,
    }
  }
}
