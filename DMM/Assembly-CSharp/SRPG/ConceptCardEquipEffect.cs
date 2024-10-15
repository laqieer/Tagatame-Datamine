// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEquipEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E88")]
  [MessagePackObject(true)]
  public class ConceptCardEquipEffect
  {
    [Token(Token = "0x4002C9B")]
    [FieldOffset(Offset = "0x8")]
    private string mConditionsIname;
    [Token(Token = "0x4002C9C")]
    [FieldOffset(Offset = "0xC")]
    private string mSkin;
    [Token(Token = "0x4002C9D")]
    [FieldOffset(Offset = "0x10")]
    private ConceptCardEffectsParam mEffectParam;
    [Token(Token = "0x4002C9E")]
    [FieldOffset(Offset = "0x14")]
    private SkillData mCardSkill;
    [Token(Token = "0x4002C9F")]
    [FieldOffset(Offset = "0x18")]
    private SkillData mEquipSkill;
    [Token(Token = "0x4002CA0")]
    [FieldOffset(Offset = "0x1C")]
    private AbilityData mAbilityDefault;
    [Token(Token = "0x4002CA1")]
    [FieldOffset(Offset = "0x20")]
    private AbilityData mAbilityLvMax;
    [Token(Token = "0x4002CA2")]
    [FieldOffset(Offset = "0x24")]
    private BuffEffect mAddCardSkillBuffEffectAwake;
    [Token(Token = "0x4002CA3")]
    [FieldOffset(Offset = "0x28")]
    private BuffEffect mAddCardSkillBuffEffectLvMax;
    [Token(Token = "0x4002CA4")]
    [FieldOffset(Offset = "0x2C")]
    private bool is_levelmax;
    [Token(Token = "0x4002CA5")]
    [FieldOffset(Offset = "0x30")]
    private int mShowOpenLevel;

    [Token(Token = "0x17000487")]
    public string ConditionsIname
    {
      [Token(Token = "0x6003C38"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000488")]
    public string Skin
    {
      [Token(Token = "0x6003C39"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000489")]
    public SkillData CardSkill
    {
      [Token(Token = "0x6003C3A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x1700048A")]
    public SkillData EquipSkill
    {
      [Token(Token = "0x6003C3B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x1700048B")]
    public AbilityData Ability
    {
      [Token(Token = "0x6003C3C"), Address(RVA = "0x10F0410", Offset = "0x10EF210", VA = "0x110F0410")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x1700048C")]
    public BuffEffect AddCardSkillBuffEffectAwake
    {
      [Token(Token = "0x6003C3D"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (BuffEffect) null;
      }
    }

    [Token(Token = "0x1700048D")]
    public BuffEffect AddCardSkillBuffEffectLvMax
    {
      [Token(Token = "0x6003C3E"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (BuffEffect) null;
      }
    }

    [Token(Token = "0x1700048E")]
    public bool IsExistAbilityLvMax
    {
      [Token(Token = "0x6003C3F"), Address(RVA = "0x10F0450", Offset = "0x10EF250", VA = "0x110F0450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700048F")]
    public bool IsDecreaseEffectOnSub
    {
      [Token(Token = "0x6003C40"), Address(RVA = "0x10F0430", Offset = "0x10EF230", VA = "0x110F0430")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000490")]
    [IgnoreMember]
    public bool IsLevelMax
    {
      [Token(Token = "0x6003C41"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000491")]
    [IgnoreMember]
    public int ShowOpenLevel
    {
      [Token(Token = "0x6003C42"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000492")]
    [IgnoreMember]
    public bool IsLimitBonus
    {
      [Token(Token = "0x6003C43"), Address(RVA = "0x10F04A0", Offset = "0x10EF2A0", VA = "0x110F04A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003C44")]
    [Address(RVA = "0x10EF470", Offset = "0x10EE270", VA = "0x110EF470")]
    public static ConceptCardEquipEffect CreateFromAbility(AbilityData abilityData)
    {
      return (ConceptCardEquipEffect) null;
    }

    [Token(Token = "0x6003C45")]
    [Address(RVA = "0x10EF4D0", Offset = "0x10EE2D0", VA = "0x110EF4D0")]
    public static ConceptCardEquipEffect CreateFromGroupSkill(SkillData skillData)
    {
      return (ConceptCardEquipEffect) null;
    }

    [Token(Token = "0x6003C46")]
    [Address(RVA = "0x10EFF60", Offset = "0x10EED60", VA = "0x110EFF60")]
    public void Setup(
      ConceptCardData conceptCard,
      ConceptCardEffectsParam param,
      int lv,
      int lvcap,
      int awake_count,
      int awake_count_cap)
    {
    }

    [Token(Token = "0x6003C47")]
    [Address(RVA = "0x10EFDA0", Offset = "0x10EEBA0", VA = "0x110EFDA0")]
    public void GetStatus(ref BaseStatus fixed_status, ref BaseStatus scale_status)
    {
    }

    [Token(Token = "0x6003C48")]
    [Address(RVA = "0x10EF5D0", Offset = "0x10EE3D0", VA = "0x110EF5D0")]
    public string GetBufText(BuffEffect effect, BuffEffect.BuffTarget target) => (string) null;

    [Token(Token = "0x6003C49")]
    [Address(RVA = "0x10EFD40", Offset = "0x10EEB40", VA = "0x110EFD40")]
    public ConceptCardConditionsParam GetCondition() => (ConceptCardConditionsParam) null;

    [Token(Token = "0x6003C4A")]
    [Address(RVA = "0x10EFBC0", Offset = "0x10EE9C0", VA = "0x110EFBC0")]
    public UnitParam[] GetConditionUnit() => (UnitParam[]) null;

    [Token(Token = "0x6003C4B")]
    [Address(RVA = "0x10EFA40", Offset = "0x10EE840", VA = "0x110EFA40")]
    public JobParam[] GetConditionJob() => (JobParam[]) null;

    [Token(Token = "0x6003C4C")]
    [Address(RVA = "0x10EF410", Offset = "0x10EE210", VA = "0x110EF410")]
    public BuffEffect CreateAddCardSkillBuffEffectAwake(int awake, int awake_cap)
    {
      return (BuffEffect) null;
    }

    [Token(Token = "0x6003C4D")]
    [Address(RVA = "0x10EF440", Offset = "0x10EE240", VA = "0x110EF440")]
    public BuffEffect CreateAddCardSkillBuffEffectLvMax(int lv, int lv_cap, int awake)
    {
      return (BuffEffect) null;
    }

    [Token(Token = "0x6003C4E")]
    [Address(RVA = "0x10EF530", Offset = "0x10EE330", VA = "0x110EF530")]
    public void GetAddCardSkillBuffStatusAwake(
      int awake,
      int awake_cap,
      ref BaseStatus total_add,
      ref BaseStatus total_scale)
    {
    }

    [Token(Token = "0x6003C4F")]
    [Address(RVA = "0x10EF580", Offset = "0x10EE380", VA = "0x110EF580")]
    public void GetAddCardSkillBuffStatusLvMax(
      int lv,
      int lv_cap,
      int awake,
      ref BaseStatus total_add,
      ref BaseStatus total_scale)
    {
    }

    [Token(Token = "0x6003C50")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardEquipEffect()
    {
    }
  }
}
