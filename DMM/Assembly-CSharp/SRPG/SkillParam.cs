// Decompiled with JetBrains decompiler
// Type: SRPG.SkillParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E71")]
  [MessagePackObject(true)]
  public class SkillParam
  {
    [Token(Token = "0x4007DC9")]
    public const int FORCED_TARGETING_ETERNAL = 99;
    [Token(Token = "0x4007DCA")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int MAX_PARAMTYPES;
    [Token(Token = "0x4007DCB")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007DCC")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007DCD")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4007DCE")]
    [FieldOffset(Offset = "0x14")]
    public string motion;
    [Token(Token = "0x4007DCF")]
    [FieldOffset(Offset = "0x18")]
    public string effect;
    [Token(Token = "0x4007DD0")]
    [FieldOffset(Offset = "0x1C")]
    public string defend_effect;
    [Token(Token = "0x4007DD1")]
    [FieldOffset(Offset = "0x20")]
    public string weapon;
    [Token(Token = "0x4007DD2")]
    [FieldOffset(Offset = "0x24")]
    public string tokkou;
    [Token(Token = "0x4007DD3")]
    [FieldOffset(Offset = "0x28")]
    public int tk_rate;
    [Token(Token = "0x4007DD4")]
    [FieldOffset(Offset = "0x2C")]
    public ESkillType type;
    [Token(Token = "0x4007DD5")]
    [FieldOffset(Offset = "0x2D")]
    public ESkillTiming timing;
    [Token(Token = "0x4007DD6")]
    [FieldOffset(Offset = "0x2E")]
    public ESkillCondition condition;
    [Token(Token = "0x4007DD7")]
    [FieldOffset(Offset = "0x30")]
    public int lvcap;
    [Token(Token = "0x4007DD8")]
    [FieldOffset(Offset = "0x34")]
    public int cost;
    [Token(Token = "0x4007DD9")]
    [FieldOffset(Offset = "0x38")]
    public int count;
    [Token(Token = "0x4007DDA")]
    [FieldOffset(Offset = "0x3C")]
    public int rate;
    [Token(Token = "0x4007DDB")]
    [FieldOffset(Offset = "0x40")]
    public int back_defrate;
    [Token(Token = "0x4007DDC")]
    [FieldOffset(Offset = "0x44")]
    public int side_defrate;
    [Token(Token = "0x4007DDD")]
    [FieldOffset(Offset = "0x48")]
    public int ignore_defense_rate;
    [Token(Token = "0x4007DDE")]
    [FieldOffset(Offset = "0x4C")]
    public ELineType line_type;
    [Token(Token = "0x4007DDF")]
    [FieldOffset(Offset = "0x4D")]
    public ESelectType select_range;
    [Token(Token = "0x4007DE0")]
    [FieldOffset(Offset = "0x50")]
    public int range_min;
    [Token(Token = "0x4007DE1")]
    [FieldOffset(Offset = "0x54")]
    public int range_max;
    [Token(Token = "0x4007DE2")]
    [FieldOffset(Offset = "0x58")]
    public ESelectType select_scope;
    [Token(Token = "0x4007DE3")]
    [FieldOffset(Offset = "0x5C")]
    public int scope;
    [Token(Token = "0x4007DE4")]
    [FieldOffset(Offset = "0x60")]
    public int effect_height;
    [Token(Token = "0x4007DE5")]
    [FieldOffset(Offset = "0x64")]
    private BitArray mFlags;
    [Token(Token = "0x4007DE6")]
    [FieldOffset(Offset = "0x68")]
    public int hp_cost_rate;
    [Token(Token = "0x4007DE7")]
    [FieldOffset(Offset = "0x6C")]
    public int hp_cost;
    [Token(Token = "0x4007DE8")]
    [FieldOffset(Offset = "0x70")]
    public int random_hit_rate;
    [Token(Token = "0x4007DE9")]
    [FieldOffset(Offset = "0x74")]
    public ECastTypes cast_type;
    [Token(Token = "0x4007DEA")]
    [FieldOffset(Offset = "0x78")]
    public SkillRankUpValueShort cast_speed;
    [Token(Token = "0x4007DEB")]
    [FieldOffset(Offset = "0x7C")]
    public ESkillTarget target;
    [Token(Token = "0x4007DEC")]
    [FieldOffset(Offset = "0x7D")]
    public SkillEffectTypes effect_type;
    [Token(Token = "0x4007DED")]
    [FieldOffset(Offset = "0x80")]
    public SkillRankUpValueShort effect_rate;
    [Token(Token = "0x4007DEE")]
    [FieldOffset(Offset = "0x84")]
    public SkillRankUpValue effect_value;
    [Token(Token = "0x4007DEF")]
    [FieldOffset(Offset = "0x88")]
    public SkillRankUpValueShort effect_range;
    [Token(Token = "0x4007DF0")]
    [FieldOffset(Offset = "0x8C")]
    public SkillParamCalcTypes effect_calc;
    [Token(Token = "0x4007DF1")]
    [FieldOffset(Offset = "0x8E")]
    public short effect_hprate;
    [Token(Token = "0x4007DF2")]
    [FieldOffset(Offset = "0x90")]
    public short effect_mprate;
    [Token(Token = "0x4007DF3")]
    [FieldOffset(Offset = "0x92")]
    public short effect_enemy_mprate;
    [Token(Token = "0x4007DF4")]
    [FieldOffset(Offset = "0x94")]
    public short effect_dead_rate;
    [Token(Token = "0x4007DF5")]
    [FieldOffset(Offset = "0x96")]
    public short effect_lvrate;
    [Token(Token = "0x4007DF6")]
    [FieldOffset(Offset = "0x98")]
    public short absorb_damage_rate;
    [Token(Token = "0x4007DF7")]
    [FieldOffset(Offset = "0x9A")]
    public EElement element_type;
    [Token(Token = "0x4007DF8")]
    [FieldOffset(Offset = "0x9B")]
    public AttackTypes attack_type;
    [Token(Token = "0x4007DF9")]
    [FieldOffset(Offset = "0x9C")]
    public AttackDetailTypes attack_detail;
    [Token(Token = "0x4007DFA")]
    [FieldOffset(Offset = "0x9D")]
    public DamageTypes reaction_damage_type;
    [Token(Token = "0x4007DFB")]
    [FieldOffset(Offset = "0xA0")]
    public List<AttackDetailTypes> reaction_det_lists;
    [Token(Token = "0x4007DFC")]
    [FieldOffset(Offset = "0xA4")]
    public SkillRankUpValueShort control_damage_rate;
    [Token(Token = "0x4007DFD")]
    [FieldOffset(Offset = "0xA8")]
    public SkillRankUpValueShort control_damage_value;
    [Token(Token = "0x4007DFE")]
    [FieldOffset(Offset = "0xAC")]
    public SkillParamCalcTypes control_damage_calc;
    [Token(Token = "0x4007DFF")]
    [FieldOffset(Offset = "0xB0")]
    public SkillRankUpValueShort control_ct_rate;
    [Token(Token = "0x4007E00")]
    [FieldOffset(Offset = "0xB4")]
    public SkillRankUpValueShort control_ct_value;
    [Token(Token = "0x4007E01")]
    [FieldOffset(Offset = "0xB8")]
    public SkillParamCalcTypes control_ct_calc;
    [Token(Token = "0x4007E02")]
    [FieldOffset(Offset = "0xBC")]
    public string buff_effect_iname;
    [Token(Token = "0x4007E03")]
    [FieldOffset(Offset = "0xC0")]
    public string target_buff_iname;
    [Token(Token = "0x4007E04")]
    [FieldOffset(Offset = "0xC4")]
    public string target_cond_iname;
    [Token(Token = "0x4007E05")]
    [FieldOffset(Offset = "0xC8")]
    public string self_buff_iname;
    [Token(Token = "0x4007E06")]
    [FieldOffset(Offset = "0xCC")]
    public string self_cond_iname;
    [Token(Token = "0x4007E07")]
    [FieldOffset(Offset = "0xD0")]
    public ShieldTypes shield_type;
    [Token(Token = "0x4007E08")]
    [FieldOffset(Offset = "0xD1")]
    public DamageTypes shield_damage_type;
    [Token(Token = "0x4007E09")]
    [FieldOffset(Offset = "0xD4")]
    public SkillRankUpValueShort shield_turn;
    [Token(Token = "0x4007E0A")]
    [FieldOffset(Offset = "0xD8")]
    public SkillRankUpValue shield_value;
    [Token(Token = "0x4007E0B")]
    [FieldOffset(Offset = "0xDC")]
    public string job;
    [Token(Token = "0x4007E0C")]
    [FieldOffset(Offset = "0xE0")]
    public int ComboNum;
    [Token(Token = "0x4007E0D")]
    [FieldOffset(Offset = "0xE4")]
    public int ComboDamageRate;
    [Token(Token = "0x4007E0E")]
    [FieldOffset(Offset = "0xE8")]
    public JewelDamageTypes JewelDamageType;
    [Token(Token = "0x4007E0F")]
    [FieldOffset(Offset = "0xEC")]
    public int JewelDamageValue;
    [Token(Token = "0x4007E10")]
    [FieldOffset(Offset = "0xF0")]
    public int DuplicateCount;
    [Token(Token = "0x4007E11")]
    [FieldOffset(Offset = "0xF4")]
    public string SceneName;
    [Token(Token = "0x4007E12")]
    [FieldOffset(Offset = "0xF8")]
    public string SceneNameBigUnit;
    [Token(Token = "0x4007E13")]
    [FieldOffset(Offset = "0xFC")]
    public string CollaboMainId;
    [Token(Token = "0x4007E14")]
    [FieldOffset(Offset = "0x100")]
    public int CollaboHeight;
    [Token(Token = "0x4007E15")]
    [FieldOffset(Offset = "0x104")]
    public int KnockBackRate;
    [Token(Token = "0x4007E16")]
    [FieldOffset(Offset = "0x108")]
    public int KnockBackVal;
    [Token(Token = "0x4007E17")]
    [FieldOffset(Offset = "0x10C")]
    public eKnockBackDir KnockBackDir;
    [Token(Token = "0x4007E18")]
    [FieldOffset(Offset = "0x10D")]
    public eKnockBackDs KnockBackDs;
    [Token(Token = "0x4007E19")]
    [FieldOffset(Offset = "0x10E")]
    public eDamageDispType DamageDispType;
    [Token(Token = "0x4007E1A")]
    [FieldOffset(Offset = "0x10F")]
    public eTeleportType TeleportType;
    [Token(Token = "0x4007E1B")]
    [FieldOffset(Offset = "0x110")]
    public ESkillTarget TeleportTarget;
    [Token(Token = "0x4007E1C")]
    [FieldOffset(Offset = "0x114")]
    public int TeleportHeight;
    [Token(Token = "0x4007E1D")]
    [FieldOffset(Offset = "0x118")]
    public bool TeleportIsMove;
    [Token(Token = "0x4007E1E")]
    [FieldOffset(Offset = "0x11C")]
    public List<string> ReplaceTargetIdLists;
    [Token(Token = "0x4007E1F")]
    [FieldOffset(Offset = "0x120")]
    public List<string> ReplaceChangeIdLists;
    [Token(Token = "0x4007E20")]
    [FieldOffset(Offset = "0x124")]
    public List<string> AbilityReplaceTargetIdLists;
    [Token(Token = "0x4007E21")]
    [FieldOffset(Offset = "0x128")]
    public List<string> AbilityReplaceChangeIdLists;
    [Token(Token = "0x4007E22")]
    [FieldOffset(Offset = "0x12C")]
    public string CollaboVoiceId;
    [Token(Token = "0x4007E23")]
    [FieldOffset(Offset = "0x130")]
    public int CollaboVoicePlayDelayFrame;
    [Token(Token = "0x4007E24")]
    [FieldOffset(Offset = "0x134")]
    public string ReplacedTargetId;
    [Token(Token = "0x4007E25")]
    [FieldOffset(Offset = "0x138")]
    public string TrickId;
    [Token(Token = "0x4007E26")]
    [FieldOffset(Offset = "0x13C")]
    public eTrickSetType TrickSetType;
    [Token(Token = "0x4007E27")]
    [FieldOffset(Offset = "0x140")]
    public string BreakObjId;
    [Token(Token = "0x4007E28")]
    [FieldOffset(Offset = "0x144")]
    public string MapEffectDesc;
    [Token(Token = "0x4007E29")]
    [FieldOffset(Offset = "0x148")]
    public int WeatherRate;
    [Token(Token = "0x4007E2A")]
    [FieldOffset(Offset = "0x14C")]
    public string WeatherId;
    [Token(Token = "0x4007E2B")]
    [FieldOffset(Offset = "0x150")]
    public int ElementSpcAtkRate;
    [Token(Token = "0x4007E2C")]
    [FieldOffset(Offset = "0x154")]
    public int MaxDamageValue;
    [Token(Token = "0x4007E2D")]
    [FieldOffset(Offset = "0x158")]
    public string CutInConceptCardId;
    [Token(Token = "0x4007E2E")]
    [FieldOffset(Offset = "0x15C")]
    public int JudgeHpVal;
    [Token(Token = "0x4007E2F")]
    [FieldOffset(Offset = "0x160")]
    public SkillParamCalcTypes JudgeHpCalc;
    [Token(Token = "0x4007E30")]
    [FieldOffset(Offset = "0x164")]
    public string AcFromAbilId;
    [Token(Token = "0x4007E31")]
    [FieldOffset(Offset = "0x168")]
    public string AcToAbilId;
    [Token(Token = "0x4007E32")]
    [FieldOffset(Offset = "0x16C")]
    public int AcTurn;
    [Token(Token = "0x4007E33")]
    [FieldOffset(Offset = "0x170")]
    public int EffectHitTargetNumRate;
    [Token(Token = "0x4007E34")]
    [FieldOffset(Offset = "0x174")]
    public eAbsorbAndGive AbsorbAndGive;
    [Token(Token = "0x4007E35")]
    [FieldOffset(Offset = "0x175")]
    public eSkillTargetEx TargetEx;
    [Token(Token = "0x4007E36")]
    [FieldOffset(Offset = "0x178")]
    public int JumpSpcAtkRate;
    [Token(Token = "0x4007E37")]
    [FieldOffset(Offset = "0x17C")]
    public eTeleportSkillPos TeleportSkillPos;
    [Token(Token = "0x4007E38")]
    [FieldOffset(Offset = "0x180")]
    public string DynamicTransformUnitId;
    [Token(Token = "0x4007E39")]
    [FieldOffset(Offset = "0x184")]
    public string SkillMotionId;
    [Token(Token = "0x4007E3A")]
    [FieldOffset(Offset = "0x188")]
    public string DependStateSpcEffId;
    [Token(Token = "0x4007E3B")]
    [FieldOffset(Offset = "0x18C")]
    public string DependStateSpcEffSelfId;
    [Token(Token = "0x4007E3C")]
    [FieldOffset(Offset = "0x190")]
    public int ForcedTargetingTurn;
    [Token(Token = "0x4007E3D")]
    [FieldOffset(Offset = "0x194")]
    public string ProtectSkillId;
    [Token(Token = "0x4007E3E")]
    [FieldOffset(Offset = "0x198")]
    private ProtectSkillParam mProtectSkill;
    [Token(Token = "0x4007E3F")]
    [FieldOffset(Offset = "0x19C")]
    public string SkillAdditionalId;
    [Token(Token = "0x4007E40")]
    [FieldOffset(Offset = "0x1A0")]
    private SkillAdditionalParam mSkillAdditional;
    [Token(Token = "0x4007E41")]
    [FieldOffset(Offset = "0x1A4")]
    public string SkillAntiShieldId;
    [Token(Token = "0x4007E42")]
    [FieldOffset(Offset = "0x1A8")]
    private SkillAntiShieldParam mSkillAntiShield;
    [Token(Token = "0x4007E43")]
    [FieldOffset(Offset = "0x1AC")]
    public string SkillRevivalId;
    [Token(Token = "0x4007E44")]
    [FieldOffset(Offset = "0x1B0")]
    private SkillRevivalParam mSkillRevival;
    [Token(Token = "0x4007E45")]
    [FieldOffset(Offset = "0x1B4")]
    public string SkillAutoHpJudgeId;
    [Token(Token = "0x4007E46")]
    [FieldOffset(Offset = "0x1B8")]
    private SkillAutoHpJudgeParam mSkillAutoHpJudge;
    [Token(Token = "0x4007E47")]
    [FieldOffset(Offset = "0x1BC")]
    private string mSkillCriticalHealId;
    [Token(Token = "0x4007E48")]
    [FieldOffset(Offset = "0x1C0")]
    private SkillCriticalHealParam mSkillCriticalHeal;
    [Token(Token = "0x4007E49")]
    [FieldOffset(Offset = "0x1C4")]
    public string SkillDuplicateResetId;
    [Token(Token = "0x4007E4A")]
    [FieldOffset(Offset = "0x1C8")]
    private SkillDuplicateResetParam mSkillDuplicateReset;
    [Token(Token = "0x4007E4B")]
    [FieldOffset(Offset = "0x1CC")]
    public string SkillManipulateId;
    [Token(Token = "0x4007E4C")]
    [FieldOffset(Offset = "0x1D0")]
    private SkillManipulateParam mSkillManipulate;
    [Token(Token = "0x4007E4D")]
    [FieldOffset(Offset = "0x1D4")]
    public string SkillManipulatePierceId;
    [Token(Token = "0x4007E4E")]
    [FieldOffset(Offset = "0x1D8")]
    private SkillManipulatePierceParam mSkillManipulatePierce;

    [Token(Token = "0x17001148")]
    public ProtectSkillParam ProtectSkill
    {
      [Token(Token = "0x6007C5C"), Address(RVA = "0x3EB2F0", Offset = "0x3EA0F0", VA = "0x103EB2F0")] get
      {
        return (ProtectSkillParam) null;
      }
    }

    [Token(Token = "0x17001149")]
    public SkillAdditionalParam SkillAdditional
    {
      [Token(Token = "0x6007C5D"), Address(RVA = "0x3EB570", Offset = "0x3EA370", VA = "0x103EB570")] get
      {
        return (SkillAdditionalParam) null;
      }
    }

    [Token(Token = "0x1700114A")]
    public SkillAntiShieldParam SkillAntiShield
    {
      [Token(Token = "0x6007C5E"), Address(RVA = "0x3EB630", Offset = "0x3EA430", VA = "0x103EB630")] get
      {
        return (SkillAntiShieldParam) null;
      }
    }

    [Token(Token = "0x1700114B")]
    public SkillRevivalParam SkillRevival
    {
      [Token(Token = "0x6007C5F"), Address(RVA = "0x3EBD20", Offset = "0x3EAB20", VA = "0x103EBD20")] get
      {
        return (SkillRevivalParam) null;
      }
    }

    [Token(Token = "0x1700114C")]
    public SkillAutoHpJudgeParam SkillAutoHpJudge
    {
      [Token(Token = "0x6007C60"), Address(RVA = "0x3EB6F0", Offset = "0x3EA4F0", VA = "0x103EB6F0")] get
      {
        return (SkillAutoHpJudgeParam) null;
      }
    }

    [Token(Token = "0x1700114D")]
    public string SkillCriticalHealId
    {
      [Token(Token = "0x6007C61"), Address(RVA = "0x33F220", Offset = "0x33E020", VA = "0x1033F220")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700114E")]
    public SkillCriticalHealParam SkillCriticalHeal
    {
      [Token(Token = "0x6007C62"), Address(RVA = "0x3EB8A0", Offset = "0x3EA6A0", VA = "0x103EB8A0")] get
      {
        return (SkillCriticalHealParam) null;
      }
    }

    [Token(Token = "0x1700114F")]
    public SkillDuplicateResetParam SkillDuplicateReset
    {
      [Token(Token = "0x6007C63"), Address(RVA = "0x3EBA20", Offset = "0x3EA820", VA = "0x103EBA20")] get
      {
        return (SkillDuplicateResetParam) null;
      }
    }

    [Token(Token = "0x17001150")]
    public SkillManipulateParam SkillManipulate
    {
      [Token(Token = "0x6007C64"), Address(RVA = "0x3EA060", Offset = "0x3E8E60", VA = "0x103EA060")] get
      {
        return (SkillManipulateParam) null;
      }
    }

    [Token(Token = "0x17001151")]
    public SkillManipulatePierceParam SkillManipulatePierce
    {
      [Token(Token = "0x6007C65"), Address(RVA = "0x3EBBD0", Offset = "0x3EA9D0", VA = "0x103EBBD0")] get
      {
        return (SkillManipulatePierceParam) null;
      }
    }

    [Token(Token = "0x6007C66")]
    [Address(RVA = "0x3E88C0", Offset = "0x3E76C0", VA = "0x103E88C0")]
    public bool Deserialize(JSON_SkillParam json) => new bool();

    [Token(Token = "0x6007C67")]
    [Address(RVA = "0x3EAD90", Offset = "0x3E9B90", VA = "0x103EAD90")]
    public static void UpdateReplaceSkill(List<SkillParam> sp_lists)
    {
    }

    [Token(Token = "0x17001152")]
    public bool IsCritical
    {
      [Token(Token = "0x6007C68"), Address(RVA = "0x3EB1D0", Offset = "0x3E9FD0", VA = "0x103EB1D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001153")]
    public bool IsJewelAbsorb
    {
      [Token(Token = "0x6007C69"), Address(RVA = "0x3EB250", Offset = "0x3EA050", VA = "0x103EB250")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007C6A")]
    [Address(RVA = "0x3EA380", Offset = "0x3E9180", VA = "0x103EA380")]
    public bool IsDamagedSkill() => new bool();

    [Token(Token = "0x6007C6B")]
    [Address(RVA = "0x3EAA10", Offset = "0x3E9810", VA = "0x103EAA10")]
    public bool IsRateDamagedSkill() => new bool();

    [Token(Token = "0x6007C6C")]
    [Address(RVA = "0x3EA5C0", Offset = "0x3E93C0", VA = "0x103EA5C0")]
    public bool IsHealSkill() => new bool();

    [Token(Token = "0x6007C6D")]
    [Address(RVA = "0x3EAAA0", Offset = "0x3E98A0", VA = "0x103EAAA0")]
    public bool IsReactionSkill() => new bool();

    [Token(Token = "0x6007C6E")]
    [Address(RVA = "0x3EAC50", Offset = "0x3E9A50", VA = "0x103EAC50")]
    public bool IsSupportedSkill() => new bool();

    [Token(Token = "0x6007C6F")]
    [Address(RVA = "0x3EA400", Offset = "0x3E9200", VA = "0x103EA400")]
    public bool IsEnableChangeRange() => new bool();

    [Token(Token = "0x6007C70")]
    [Address(RVA = "0x3EA460", Offset = "0x3E9260", VA = "0x103EA460")]
    public bool IsEnableHeightRangeBonus() => new bool();

    [Token(Token = "0x6007C71")]
    [Address(RVA = "0x3EA430", Offset = "0x3E9230", VA = "0x103EA430")]
    public bool IsEnableHeightParamAdjust() => new bool();

    [Token(Token = "0x6007C72")]
    [Address(RVA = "0x3EA920", Offset = "0x3E9720", VA = "0x103EA920")]
    public bool IsPierce() => new bool();

    [Token(Token = "0x6007C73")]
    [Address(RVA = "0x3EA670", Offset = "0x3E9470", VA = "0x103EA670")]
    public bool IsJewelAttack() => new bool();

    [Token(Token = "0x6007C74")]
    [Address(RVA = "0x3EA560", Offset = "0x3E9360", VA = "0x103EA560")]
    public bool IsForceHit() => new bool();

    [Token(Token = "0x6007C75")]
    [Address(RVA = "0x3EAC00", Offset = "0x3E9A00", VA = "0x103EAC00")]
    public bool IsSuicide() => new bool();

    [Token(Token = "0x6007C76")]
    [Address(RVA = "0x3EABD0", Offset = "0x3E99D0", VA = "0x103EABD0")]
    public bool IsSubActuate() => new bool();

    [Token(Token = "0x6007C77")]
    [Address(RVA = "0x3EA530", Offset = "0x3E9330", VA = "0x103EA530")]
    public bool IsFixedDamage() => new bool();

    [Token(Token = "0x6007C78")]
    [Address(RVA = "0x3EA590", Offset = "0x3E9390", VA = "0x103EA590")]
    public bool IsForceUnitLock() => new bool();

    [Token(Token = "0x6007C79")]
    [Address(RVA = "0x3EA250", Offset = "0x3E9050", VA = "0x103EA250")]
    public bool IsAllDamageReaction() => new bool();

    [Token(Token = "0x6007C7A")]
    [Address(RVA = "0x3EAAF0", Offset = "0x3E98F0", VA = "0x103EAAF0")]
    public bool IsShieldReset() => new bool();

    [Token(Token = "0x6007C7B")]
    [Address(RVA = "0x3EA610", Offset = "0x3E9410", VA = "0x103EA610")]
    public bool IsIgnoreElement() => new bool();

    [Token(Token = "0x6007C7C")]
    [Address(RVA = "0x3EA980", Offset = "0x3E9780", VA = "0x103EA980")]
    public bool IsPrevApply() => new bool();

    [Token(Token = "0x6007C7D")]
    [Address(RVA = "0x3EA7D0", Offset = "0x3E95D0", VA = "0x103EA7D0")]
    public bool IsMhmDamage() => new bool();

    [Token(Token = "0x6007C7E")]
    [Address(RVA = "0x3EA140", Offset = "0x3E8F40", VA = "0x103EA140")]
    public bool IsAcSelf() => new bool();

    [Token(Token = "0x6007C7F")]
    [Address(RVA = "0x3EA110", Offset = "0x3E8F10", VA = "0x103EA110")]
    public bool IsAcReset() => new bool();

    [Token(Token = "0x6007C80")]
    [Address(RVA = "0x3EA5E0", Offset = "0x3E93E0", VA = "0x103EA5E0")]
    public bool IsHitTargetNumDiv() => new bool();

    [Token(Token = "0x6007C81")]
    [Address(RVA = "0x3EA830", Offset = "0x3E9630", VA = "0x103EA830")]
    public bool IsNoChargeCalcCT() => new bool();

    [Token(Token = "0x6007C82")]
    [Address(RVA = "0x3EA740", Offset = "0x3E9540", VA = "0x103EA740")]
    public bool IsJumpBreak() => new bool();

    [Token(Token = "0x6007C83")]
    [Address(RVA = "0x3EA8F0", Offset = "0x3E96F0", VA = "0x103EA8F0")]
    public bool IsObstReaction() => new bool();

    [Token(Token = "0x6007C84")]
    [Address(RVA = "0x3EA8C0", Offset = "0x3E96C0", VA = "0x103EA8C0")]
    public bool IsNoUsedJewelBuff() => new bool();

    [Token(Token = "0x6007C85")]
    [Address(RVA = "0x3EA220", Offset = "0x3E9020", VA = "0x103EA220")]
    public bool IsAiNoAutoTiming() => new bool();

    [Token(Token = "0x6007C86")]
    [Address(RVA = "0x3EA800", Offset = "0x3E9600", VA = "0x103EA800")]
    public bool IsMpUseAfter() => new bool();

    [Token(Token = "0x6007C87")]
    [Address(RVA = "0x3EA500", Offset = "0x3E9300", VA = "0x103EA500")]
    public bool IsEnableUnitLockTarget() => new bool();

    [Token(Token = "0x6007C88")]
    [Address(RVA = "0x3EA2E0", Offset = "0x3E90E0", VA = "0x103EA2E0")]
    public bool IsCastBreak() => new bool();

    [Token(Token = "0x6007C89")]
    [Address(RVA = "0x3EA310", Offset = "0x3E9110", VA = "0x103EA310")]
    public bool IsCastSkill() => new bool();

    [Token(Token = "0x6007C8A")]
    [Address(RVA = "0x3EA350", Offset = "0x3E9150", VA = "0x103EA350")]
    public bool IsCutin() => new bool();

    [Token(Token = "0x6007C8B")]
    [Address(RVA = "0x3EA7A0", Offset = "0x3E95A0", VA = "0x103EA7A0")]
    public bool IsMapSkill() => new bool();

    [Token(Token = "0x6007C8C")]
    [Address(RVA = "0x3EA2B0", Offset = "0x3E90B0", VA = "0x103EA2B0")]
    public bool IsBattleSkill() => new bool();

    [Token(Token = "0x6007C8D")]
    [Address(RVA = "0x3EA640", Offset = "0x3E9440", VA = "0x103EA640")]
    public bool IsIgnoreSkillDistance() => new bool();

    [Token(Token = "0x6007C8E")]
    [Address(RVA = "0x3EA290", Offset = "0x3E9090", VA = "0x103EA290")]
    public bool IsAreaSkill() => new bool();

    [Token(Token = "0x6007C8F")]
    [Address(RVA = "0x3EA280", Offset = "0x3E9080", VA = "0x103EA280")]
    public bool IsAllEffect() => new bool();

    [Token(Token = "0x6007C90")]
    [Address(RVA = "0x3EA770", Offset = "0x3E9570", VA = "0x103EA770")]
    public bool IsLongRangeSkill() => new bool();

    [Token(Token = "0x6007C91")]
    [Address(RVA = "0x3EAC30", Offset = "0x3E9A30", VA = "0x103EAC30")]
    public bool IsSupportSkill() => new bool();

    [Token(Token = "0x6007C92")]
    [Address(RVA = "0x3EA330", Offset = "0x3E9130", VA = "0x103EA330")]
    public bool IsConditionSkill() => new bool();

    [Token(Token = "0x6007C93")]
    [Address(RVA = "0x3EACD0", Offset = "0x3E9AD0", VA = "0x103EACD0")]
    public bool IsTrickSkill() => new bool();

    [Token(Token = "0x6007C94")]
    [Address(RVA = "0x3EACB0", Offset = "0x3E9AB0", VA = "0x103EACB0")]
    public bool IsTransformSkill() => new bool();

    [Token(Token = "0x6007C95")]
    [Address(RVA = "0x3EA3F0", Offset = "0x3E91F0", VA = "0x103EA3F0")]
    public bool IsDynamicTransformSkill() => new bool();

    [Token(Token = "0x6007C96")]
    [Address(RVA = "0x3EAAE0", Offset = "0x3E98E0", VA = "0x103EAAE0")]
    public bool IsSetBreakObjSkill() => new bool();

    [Token(Token = "0x6007C97")]
    [Address(RVA = "0x3EA320", Offset = "0x3E9120", VA = "0x103EA320")]
    public bool IsChangeWeatherSkill() => new bool();

    [Token(Token = "0x6007C98")]
    [Address(RVA = "0x3EA6A0", Offset = "0x3E94A0", VA = "0x103EA6A0")]
    public bool IsJudgeHp(Unit unit) => new bool();

    [Token(Token = "0x6007C99")]
    [Address(RVA = "0x3EAAB0", Offset = "0x3E98B0", VA = "0x103EAAB0")]
    public bool IsSelfTargetSelect() => new bool();

    [Token(Token = "0x6007C9A")]
    [Address(RVA = "0x3EA170", Offset = "0x3E8F70", VA = "0x103EA170")]
    public bool IsAdvantage() => new bool();

    [Token(Token = "0x6007C9B")]
    [Address(RVA = "0x3EA3B0", Offset = "0x3E91B0", VA = "0x103EA3B0")]
    public bool IsDynamicSwitchSkill() => new bool();

    [Token(Token = "0x6007C9C")]
    [Address(RVA = "0x3E87D0", Offset = "0x3E75D0", VA = "0x103E87D0")]
    public int CalcCurrentRankValue(int rank, int rankcap, SkillRankUpValue param) => new int();

    [Token(Token = "0x6007C9D")]
    [Address(RVA = "0x3E8760", Offset = "0x3E7560", VA = "0x103E8760")]
    public int CalcCurrentRankValueShort(int rank, int rankcap, SkillRankUpValueShort param)
    {
      return new int();
    }

    [Token(Token = "0x6007C9E")]
    [Address(RVA = "0x3E8840", Offset = "0x3E7640", VA = "0x103E8840")]
    public int CalcCurrentRankValue(int rank, int rankcap, int ini, int max) => new int();

    [Token(Token = "0x6007C9F")]
    [Address(RVA = "0x3E8890", Offset = "0x3E7690", VA = "0x103E8890")]
    public static int CalcSkillEffectValue(SkillParamCalcTypes calctype, int skillval, int target)
    {
      return new int();
    }

    [Token(Token = "0x17001154")]
    public bool IsTargetGridNoUnit
    {
      [Token(Token = "0x6007CA0"), Address(RVA = "0x38DAF0", Offset = "0x38C8F0", VA = "0x1038DAF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001155")]
    public bool IsTargetValidGrid
    {
      [Token(Token = "0x6007CA1"), Address(RVA = "0x3EB2E0", Offset = "0x3EA0E0", VA = "0x103EB2E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007CA2")]
    [Address(RVA = "0x3EACE0", Offset = "0x3E9AE0", VA = "0x103EACE0")]
    public static bool IsTypeLaser(ESelectType type) => new bool();

    [Token(Token = "0x17001156")]
    public bool IsSkillCountNoLimit
    {
      [Token(Token = "0x6007CA3"), Address(RVA = "0x37AD50", Offset = "0x379B50", VA = "0x1037AD50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007CA4")]
    [Address(RVA = "0x3EA9F0", Offset = "0x3E97F0", VA = "0x103EA9F0")]
    public bool IsProtectSkill() => new bool();

    [Token(Token = "0x6007CA5")]
    [Address(RVA = "0x3EA9B0", Offset = "0x3E97B0", VA = "0x103EA9B0")]
    public bool IsProtectReactionSkill() => new bool();

    [Token(Token = "0x6007CA6")]
    [Address(RVA = "0x3EA890", Offset = "0x3E9690", VA = "0x103EA890")]
    public bool IsNoUseForArena() => new bool();

    [Token(Token = "0x6007CA7")]
    [Address(RVA = "0x3EA860", Offset = "0x3E9660", VA = "0x103EA860")]
    public bool IsNoDispInvalid() => new bool();

    [Token(Token = "0x6007CA8")]
    [Address(RVA = "0x3EA950", Offset = "0x3E9750", VA = "0x103EA950")]
    public bool IsPreemptBuffRemoveSkill() => new bool();

    [Token(Token = "0x6007CA9")]
    [Address(RVA = "0x3EAA40", Offset = "0x3E9840", VA = "0x103EAA40")]
    public bool IsReactionDet(AttackDetailTypes atk_detail_type) => new bool();

    [Token(Token = "0x17001157")]
    public bool IsTargetTeleport
    {
      [Token(Token = "0x6007CAA"), Address(RVA = "0x3EB2C0", Offset = "0x3EA0C0", VA = "0x103EB2C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007CAB")]
    [Address(RVA = "0x3EA0D0", Offset = "0x3E8ED0", VA = "0x103EA0D0")]
    public static bool IsAagTypeGive(eAbsorbAndGive aag) => new bool();

    [Token(Token = "0x6007CAC")]
    [Address(RVA = "0x3EA0F0", Offset = "0x3E8EF0", VA = "0x103EA0F0")]
    public static bool IsAagTypeSame(eAbsorbAndGive aag) => new bool();

    [Token(Token = "0x6007CAD")]
    [Address(RVA = "0x3EA0B0", Offset = "0x3E8EB0", VA = "0x103EA0B0")]
    public static bool IsAagTypeDiv(eAbsorbAndGive aag) => new bool();

    [Token(Token = "0x17001158")]
    public bool IsForcedTargetingSkillEffect
    {
      [Token(Token = "0x6007CAE"), Address(RVA = "0x3EB200", Offset = "0x3EA000", VA = "0x103EB200")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001159")]
    public bool IsNeedResetDirection
    {
      [Token(Token = "0x6007CAF"), Address(RVA = "0x3EB280", Offset = "0x3EA080", VA = "0x103EB280")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700115A")]
    public bool IsShowSkillNamePlate
    {
      [Token(Token = "0x6007CB0"), Address(RVA = "0x3EB2A0", Offset = "0x3EA0A0", VA = "0x103EB2A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700115B")]
    public bool IsAllowCutIn
    {
      [Token(Token = "0x6007CB1"), Address(RVA = "0x3EB1B0", Offset = "0x3E9FB0", VA = "0x103EB1B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700115C")]
    public bool IsAdditionalSkill
    {
      [Token(Token = "0x6007CB2"), Address(RVA = "0x3EB1A0", Offset = "0x3E9FA0", VA = "0x103EB1A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007CB3")]
    [Address(RVA = "0x3EA060", Offset = "0x3E8E60", VA = "0x103EA060")]
    public SkillManipulateParam GetSkillManipulate() => (SkillManipulateParam) null;

    [Token(Token = "0x6007CB4")]
    [Address(RVA = "0x3EAB70", Offset = "0x3E9970", VA = "0x103EAB70")]
    public bool IsSkillManipulate() => new bool();

    [Token(Token = "0x6007CB5")]
    [Address(RVA = "0x3EA050", Offset = "0x3E8E50", VA = "0x103EA050")]
    public SkillManipulatePierceParam GetSkillManipulatePierce()
    {
      return (SkillManipulatePierceParam) null;
    }

    [Token(Token = "0x6007CB6")]
    [Address(RVA = "0x3EAB50", Offset = "0x3E9950", VA = "0x103EAB50")]
    public bool IsSkillManipulatePierce() => new bool();

    [Token(Token = "0x6007CB7")]
    [Address(RVA = "0x3EAB20", Offset = "0x3E9920", VA = "0x103EAB20")]
    public bool IsSkillForceBomb() => new bool();

    [Token(Token = "0x6007CB8")]
    [Address(RVA = "0x3EB130", Offset = "0x3E9F30", VA = "0x103EB130")]
    public SkillParam()
    {
    }

    [Token(Token = "0x6007CB9")]
    [Address(RVA = "0x3EB090", Offset = "0x3E9E90", VA = "0x103EB090")]
    static SkillParam()
    {
    }
  }
}
