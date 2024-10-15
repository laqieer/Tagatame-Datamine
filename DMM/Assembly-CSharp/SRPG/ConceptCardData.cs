// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E89")]
  [MessagePackObject(true)]
  public class ConceptCardData
  {
    [Token(Token = "0x4002CA6")]
    public const int NO_EQUIPED_INDEX = 255;
    [Token(Token = "0x4002CA7")]
    [FieldOffset(Offset = "0x8")]
    private OLong mUniqueID;
    [Token(Token = "0x4002CA8")]
    [FieldOffset(Offset = "0x30")]
    private OInt mLv;
    [Token(Token = "0x4002CA9")]
    [FieldOffset(Offset = "0x44")]
    private OInt mExp;
    [Token(Token = "0x4002CAA")]
    [FieldOffset(Offset = "0x58")]
    private OInt mTrust;
    [Token(Token = "0x4002CAB")]
    [FieldOffset(Offset = "0x6C")]
    private bool mFavorite;
    [Token(Token = "0x4002CAC")]
    [FieldOffset(Offset = "0x70")]
    private int mTrustBonus;
    [Token(Token = "0x4002CAD")]
    [FieldOffset(Offset = "0x74")]
    private int mTrustBonusCount;
    [Token(Token = "0x4002CAE")]
    [FieldOffset(Offset = "0x78")]
    private OInt mAwakeCount;
    [Token(Token = "0x4002CAF")]
    [FieldOffset(Offset = "0x8C")]
    private ConceptCardParam mConceptCardParam;
    [Token(Token = "0x4002CB0")]
    [FieldOffset(Offset = "0x90")]
    private List<ConceptCardEquipEffect> mEquipEffects;
    [Token(Token = "0x4002CB1")]
    [FieldOffset(Offset = "0x94")]
    private BaseStatus mFixStatus;
    [Token(Token = "0x4002CB2")]
    [FieldOffset(Offset = "0x98")]
    private BaseStatus mScaleSatus;
    [Token(Token = "0x4002CB3")]
    [FieldOffset(Offset = "0x9C")]
    private SkillData mLeaderSkill;
    [Token(Token = "0x4002CB4")]
    [FieldOffset(Offset = "0xA0")]
    private byte mEquipedSlotIndex;
    [Token(Token = "0x4002CB5")]
    [FieldOffset(Offset = "0xA4")]
    private int mExRarePoint;
    [Token(Token = "0x4002CB6")]
    [FieldOffset(Offset = "0xA8")]
    private bool mExRareFlg;

    [Token(Token = "0x17000493")]
    public OLong UniqueID
    {
      [Token(Token = "0x6003C51"), Address(RVA = "0x305BB0", Offset = "0x3049B0", VA = "0x10305BB0")] get
      {
        return new OLong();
      }
    }

    [Token(Token = "0x17000494")]
    public OInt Rarity
    {
      [Token(Token = "0x6003C52"), Address(RVA = "0x10EF1D0", Offset = "0x10EDFD0", VA = "0x110EF1D0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000495")]
    public OInt Lv
    {
      [Token(Token = "0x6003C53"), Address(RVA = "0x4791D0", Offset = "0x477FD0", VA = "0x104791D0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000496")]
    public OInt Exp
    {
      [Token(Token = "0x6003C54"), Address(RVA = "0x10EEC20", Offset = "0x10EDA20", VA = "0x110EEC20")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000497")]
    public OInt Trust
    {
      [Token(Token = "0x6003C55"), Address(RVA = "0x10EF3F0", Offset = "0x10EE1F0", VA = "0x110EF3F0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17000498")]
    public bool Favorite
    {
      [Token(Token = "0x6003C56"), Address(RVA = "0x10EEC80", Offset = "0x10EDA80", VA = "0x110EEC80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000499")]
    public int TrustBonus
    {
      [Token(Token = "0x6003C57"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700049A")]
    public int TrustBonusCount
    {
      [Token(Token = "0x6003C58"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700049B")]
    public ConceptCardParam Param
    {
      [Token(Token = "0x6003C59"), Address(RVA = "0x2B5F90", Offset = "0x2B4D90", VA = "0x102B5F90")] get
      {
        return (ConceptCardParam) null;
      }
    }

    [Token(Token = "0x1700049C")]
    public List<ConceptCardEquipEffect> EquipEffects
    {
      [Token(Token = "0x6003C5A"), Address(RVA = "0x3492D0", Offset = "0x3480D0", VA = "0x103492D0")] get
      {
        return (List<ConceptCardEquipEffect>) null;
      }
    }

    [Token(Token = "0x1700049D")]
    public OInt CurrentLvCap
    {
      [Token(Token = "0x6003C5B"), Address(RVA = "0x10EEB20", Offset = "0x10ED920", VA = "0x110EEB20")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700049E")]
    public OInt LvCap
    {
      [Token(Token = "0x6003C5C"), Address(RVA = "0x10EF0D0", Offset = "0x10EDED0", VA = "0x110EF0D0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700049F")]
    public OInt AwakeLevel
    {
      [Token(Token = "0x6003C5D"), Address(RVA = "0x10EE870", Offset = "0x10ED670", VA = "0x110EE870")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170004A0")]
    public bool IsEnableAwake
    {
      [Token(Token = "0x6003C5E"), Address(RVA = "0x10EEDC0", Offset = "0x10EDBC0", VA = "0x110EEDC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004A1")]
    public int AwakeCountCap
    {
      [Token(Token = "0x6003C5F"), Address(RVA = "0x10EE6D0", Offset = "0x10ED4D0", VA = "0x110EE6D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004A2")]
    public int AwakeLevelCap
    {
      [Token(Token = "0x6003C60"), Address(RVA = "0x10EE840", Offset = "0x10ED640", VA = "0x110EE840")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004A3")]
    [IgnoreMember]
    public OInt ExtraRarityLevelCap
    {
      [Token(Token = "0x6003C61"), Address(RVA = "0x10EEC40", Offset = "0x10EDA40", VA = "0x110EEC40")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170004A4")]
    [IgnoreMember]
    public int ExtraRarePoint
    {
      [Token(Token = "0x6003C62"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004A5")]
    [IgnoreMember]
    public bool IsEnableExtraRarity
    {
      [Token(Token = "0x6003C63"), Address(RVA = "0x10EEDF0", Offset = "0x10EDBF0", VA = "0x110EEDF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004A6")]
    [IgnoreMember]
    public bool IsExtraRarity
    {
      [Token(Token = "0x6003C64"), Address(RVA = "0x10EEEF0", Offset = "0x10EDCF0", VA = "0x110EEEF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004A7")]
    [IgnoreMember]
    public bool IsCanExtraRarity
    {
      [Token(Token = "0x6003C65"), Address(RVA = "0x10EEC90", Offset = "0x10EDA90", VA = "0x110EEC90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004A8")]
    [IgnoreMember]
    public bool IsEnableTrust
    {
      [Token(Token = "0x6003C66"), Address(RVA = "0x10EEE20", Offset = "0x10EDC20", VA = "0x110EEE20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004A9")]
    public string LeaderSkillName
    {
      [Token(Token = "0x6003C67"), Address(RVA = "0x10EF0B0", Offset = "0x10EDEB0", VA = "0x110EF0B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004AA")]
    public SkillData LeaderSkill
    {
      [Token(Token = "0x6003C68"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x170004AB")]
    public int EquipedSlotIndex
    {
      [Token(Token = "0x6003C69"), Address(RVA = "0x10EEC10", Offset = "0x10EDA10", VA = "0x110EEC10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004AC")]
    public OInt AwakeCount
    {
      [Token(Token = "0x6003C6A"), Address(RVA = "0x10EE700", Offset = "0x10ED500", VA = "0x110EE700")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170004AD")]
    [IgnoreMember]
    public bool IsLimitAwakeCount
    {
      [Token(Token = "0x6003C6B"), Address(RVA = "0x10EEFB0", Offset = "0x10EDDB0", VA = "0x110EEFB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004AE")]
    [IgnoreMember]
    public bool IsLimitLevel
    {
      [Token(Token = "0x6003C6C"), Address(RVA = "0x10EF030", Offset = "0x10EDE30", VA = "0x110EF030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004AF")]
    public bool IsEquipedMainSlot
    {
      [Token(Token = "0x6003C6D"), Address(RVA = "0x10EEEB0", Offset = "0x10EDCB0", VA = "0x110EEEB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004B0")]
    public bool IsEquipedSubSlot
    {
      [Token(Token = "0x6003C6E"), Address(RVA = "0x10EEED0", Offset = "0x10EDCD0", VA = "0x110EEED0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170004B1")]
    public int CurrentDecreaseEffectRate
    {
      [Token(Token = "0x6003C6F"), Address(RVA = "0x10EE930", Offset = "0x10ED730", VA = "0x110EE930")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003C70")]
    [Address(RVA = "0x10EC250", Offset = "0x10EB050", VA = "0x110EC250")]
    public int GetDecreaseEffectRate(UnitData unit = null) => new int();

    [Token(Token = "0x6003C71")]
    [Address(RVA = "0x10EDC00", Offset = "0x10ECA00", VA = "0x110EDC00")]
    public bool LeaderSkillIsAvailable() => new bool();

    [Token(Token = "0x6003C72")]
    [Address(RVA = "0x10EB3A0", Offset = "0x10EA1A0", VA = "0x110EB3A0")]
    public bool Deserialize(JSON_ConceptCard json) => new bool();

    [Token(Token = "0x6003C73")]
    [Address(RVA = "0x10EDCF0", Offset = "0x10ECAF0", VA = "0x110EDCF0")]
    public JSON_ConceptCard Serialize() => (JSON_ConceptCard) null;

    [Token(Token = "0x6003C74")]
    [Address(RVA = "0x10EB090", Offset = "0x10E9E90", VA = "0x110EB090")]
    public ConceptCardData Clone() => (ConceptCardData) null;

    [Token(Token = "0x170004B2")]
    public int SellGold
    {
      [Token(Token = "0x6003C75"), Address(RVA = "0x10EF340", Offset = "0x10EE140", VA = "0x110EF340")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004B3")]
    public int SellCoinItemNum
    {
      [Token(Token = "0x6003C76"), Address(RVA = "0x10EF210", Offset = "0x10EE010", VA = "0x110EF210")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170004B4")]
    public int MixExp
    {
      [Token(Token = "0x6003C77"), Address(RVA = "0x10EF120", Offset = "0x10EDF20", VA = "0x110EF120")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003C78")]
    [Address(RVA = "0x10EDE60", Offset = "0x10ECC60", VA = "0x110EDE60")]
    public void SetTrust(int trust)
    {
    }

    [Token(Token = "0x6003C79")]
    [Address(RVA = "0x10EDE30", Offset = "0x10ECC30", VA = "0x110EDE30")]
    public void SetBonus(int bonus)
    {
    }

    [Token(Token = "0x6003C7A")]
    [Address(RVA = "0x5FE320", Offset = "0x5FD120", VA = "0x105FE320")]
    public void SetBonusCount(int bonusCount)
    {
    }

    [Token(Token = "0x6003C7B")]
    [Address(RVA = "0x10EDE40", Offset = "0x10ECC40", VA = "0x110EDE40")]
    public void SetSlotIndex(int slotIndex)
    {
    }

    [Token(Token = "0x6003C7C")]
    [Address(RVA = "0x10EDCE0", Offset = "0x10ECAE0", VA = "0x110EDCE0")]
    public void ResetSlotIndex()
    {
    }

    [Token(Token = "0x6003C7D")]
    [Address(RVA = "0x10EDF50", Offset = "0x10ECD50", VA = "0x110EDF50")]
    private void UpdateEquipEffect()
    {
    }

    [Token(Token = "0x6003C7E")]
    [Address(RVA = "0x10EB2D0", Offset = "0x10EA0D0", VA = "0x110EB2D0")]
    private ConceptCardEffectsParam CreateEffectParamForExtraRarityParam(
      ConceptCardExtraRarityEffect effect)
    {
      return (ConceptCardEffectsParam) null;
    }

    [Token(Token = "0x6003C7F")]
    [Address(RVA = "0x10EAFA0", Offset = "0x10E9DA0", VA = "0x110EAFA0")]
    private int CalcCardLevel() => new int();

    [Token(Token = "0x6003C80")]
    [Address(RVA = "0x10EC920", Offset = "0x10EB720", VA = "0x110EC920")]
    public int GetExpToLevelMax() => new int();

    [Token(Token = "0x6003C81")]
    [Address(RVA = "0x10EDA20", Offset = "0x10EC820", VA = "0x110EDA20")]
    public int GetTrustToLevelMax() => new int();

    [Token(Token = "0x6003C82")]
    [Address(RVA = "0x10EC800", Offset = "0x10EB600", VA = "0x110EC800")]
    public List<ConceptCardEquipEffect> GetEnableEquipEffects(
      UnitData unit_data,
      JobData job_data,
      bool is_force = false)
    {
      return (List<ConceptCardEquipEffect>) null;
    }

    [Token(Token = "0x6003C83")]
    [Address(RVA = "0x10EDB90", Offset = "0x10EC990", VA = "0x110EDB90")]
    public bool IsMatchConditions(UnitParam unit_param, JobData job_data, string conditions_iname)
    {
      return new bool();
    }

    [Token(Token = "0x6003C84")]
    [Address(RVA = "0x10EB220", Offset = "0x10EA020", VA = "0x110EB220")]
    public static ConceptCardData CreateConceptCardDataForDisplay(string iname, int iid = 1)
    {
      return (ConceptCardData) null;
    }

    [Token(Token = "0x6003C85")]
    [Address(RVA = "0x10EB660", Offset = "0x10EA460", VA = "0x110EB660")]
    public bool Filter(FilterConceptCardPrefs filter) => new bool();

    [Token(Token = "0x6003C86")]
    [Address(RVA = "0x10EB630", Offset = "0x10EA430", VA = "0x110EB630")]
    public bool FilterEnhance(string filter_iname) => new bool();

    [Token(Token = "0x6003C87")]
    [Address(RVA = "0x10ED750", Offset = "0x10EC550", VA = "0x110ED750")]
    public long GetSortData(ConceptCardListSortWindow.Type type) => new long();

    [Token(Token = "0x6003C88")]
    [Address(RVA = "0x10ED9B0", Offset = "0x10EC7B0", VA = "0x110ED9B0")]
    public int GetSortParam(ParamTypes types) => new int();

    [Token(Token = "0x6003C89")]
    [Address(RVA = "0x10EE570", Offset = "0x10ED370", VA = "0x110EE570")]
    public void UpdateStatus(ref BaseStatus fix, ref BaseStatus scale)
    {
    }

    [Token(Token = "0x6003C8A")]
    [Address(RVA = "0x10ED9E0", Offset = "0x10EC7E0", VA = "0x110ED9E0")]
    public void GetStatus(ref BaseStatus fix, ref BaseStatus scale)
    {
    }

    [Token(Token = "0x6003C8B")]
    [Address(RVA = "0x10ED370", Offset = "0x10EC170", VA = "0x110ED370")]
    public List<ConceptCardEquipEffect> GetNoConditionsEquipEffects()
    {
      return (List<ConceptCardEquipEffect>) null;
    }

    [Token(Token = "0x6003C8C")]
    [Address(RVA = "0x10ED110", Offset = "0x10EBF10", VA = "0x110ED110")]
    public BaseStatus GetNoConditionsEquipEffectStatus() => (BaseStatus) null;

    [Token(Token = "0x6003C8D")]
    [Address(RVA = "0x10EC600", Offset = "0x10EB400", VA = "0x110EC600")]
    public List<SkillData> GetEnableCardSkills(UnitData unit) => (List<SkillData>) null;

    [Token(Token = "0x6003C8E")]
    [Address(RVA = "0x10EC2C0", Offset = "0x10EB0C0", VA = "0x110EC2C0")]
    public List<BuffEffect> GetEnableCardSkillAddBuffs(UnitData unit, SkillParam parent_card_skill)
    {
      return (List<BuffEffect>) null;
    }

    [Token(Token = "0x6003C8F")]
    [Address(RVA = "0x10EBA60", Offset = "0x10EA860", VA = "0x110EBA60")]
    public List<ConceptCardEquipEffect> GetAbilities() => (List<ConceptCardEquipEffect>) null;

    [Token(Token = "0x6003C90")]
    [Address(RVA = "0x10ECD70", Offset = "0x10EBB70", VA = "0x110ECD70")]
    public List<AbilityParam> GetMaxLerningAbilities() => (List<AbilityParam>) null;

    [Token(Token = "0x6003C91")]
    [Address(RVA = "0x10EC170", Offset = "0x10EAF70", VA = "0x110EC170")]
    public List<ConceptCardEquipEffect> GetCardSkills() => (List<ConceptCardEquipEffect>) null;

    [Token(Token = "0x6003C92")]
    [Address(RVA = "0x10EBB40", Offset = "0x10EA940", VA = "0x110EBB40")]
    public List<ConceptCardSkillDatailData> GetAbilityDatailData()
    {
      return (List<ConceptCardSkillDatailData>) null;
    }

    [Token(Token = "0x6003C93")]
    [Address(RVA = "0x10ED6D0", Offset = "0x10EC4D0", VA = "0x110ED6D0")]
    public ConceptCardTrustRewardItemParam GetReward() => (ConceptCardTrustRewardItemParam) null;

    [Token(Token = "0x6003C94")]
    [Address(RVA = "0x10ED4D0", Offset = "0x10EC2D0", VA = "0x110ED4D0")]
    public UnitData GetOwner(bool is_include_over_write = false) => (UnitData) null;

    [Token(Token = "0x6003C95")]
    [Address(RVA = "0x10EDE90", Offset = "0x10ECC90", VA = "0x110EDE90", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6003C96")]
    [Address(RVA = "0x39DD30", Offset = "0x39CB30", VA = "0x1039DD30")]
    public static bool IsMainSlot(int conceptCardSlotIndex) => new bool();

    [Token(Token = "0x6003C97")]
    [Address(RVA = "0x10ECA10", Offset = "0x10EB810", VA = "0x110ECA10")]
    public int GetExtraRarityDecrease() => new int();

    [Token(Token = "0x6003C98")]
    [Address(RVA = "0x10ECBC0", Offset = "0x10EB9C0", VA = "0x110ECBC0")]
    public int GetExtraRarityMaterialPoint(ConceptCardData card) => new int();

    [Token(Token = "0x6003C99")]
    [Address(RVA = "0x10EDAA0", Offset = "0x10EC8A0", VA = "0x110EDAA0")]
    public bool IsCanExtraRarityMaterial(ConceptCardData card) => new bool();

    [Token(Token = "0x6003C9A")]
    [Address(RVA = "0x10EE600", Offset = "0x10ED400", VA = "0x110EE600")]
    public ConceptCardData()
    {
    }

    [Token(Token = "0x2000E8A")]
    public enum ESlotIndex
    {
      [Token(Token = "0x4002CB8")] MAIN_SLOT,
      [Token(Token = "0x4002CB9")] SUB1_SLOT,
      [Token(Token = "0x4002CBA")] MAX,
    }
  }
}
