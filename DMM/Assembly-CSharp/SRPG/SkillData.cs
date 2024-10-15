// Decompiled with JetBrains decompiler
// Type: SRPG.SkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200112A")]
  [MessagePackObject(true)]
  public class SkillData
  {
    [Token(Token = "0x4003E5D")]
    [FieldOffset(Offset = "0x8")]
    private SkillParam mSkillParam;
    [Token(Token = "0x4003E5E")]
    [FieldOffset(Offset = "0xC")]
    private OInt mRank;
    [Token(Token = "0x4003E5F")]
    [FieldOffset(Offset = "0x20")]
    private OInt mRankCap;
    [Token(Token = "0x4003E60")]
    [FieldOffset(Offset = "0x34")]
    private OInt mCastSpeed;
    [Token(Token = "0x4003E61")]
    [FieldOffset(Offset = "0x48")]
    private OInt mEffectRate;
    [Token(Token = "0x4003E62")]
    [FieldOffset(Offset = "0x5C")]
    private OInt mEffectValue;
    [Token(Token = "0x4003E63")]
    [FieldOffset(Offset = "0x70")]
    private OInt mEffectRange;
    [Token(Token = "0x4003E64")]
    [FieldOffset(Offset = "0x84")]
    private OInt mElementValue;
    [Token(Token = "0x4003E65")]
    [FieldOffset(Offset = "0x98")]
    private OInt mControlDamageRate;
    [Token(Token = "0x4003E66")]
    [FieldOffset(Offset = "0xAC")]
    private OInt mControlDamageValue;
    [Token(Token = "0x4003E67")]
    [FieldOffset(Offset = "0xC0")]
    private OInt mControlChargeTimeRate;
    [Token(Token = "0x4003E68")]
    [FieldOffset(Offset = "0xD4")]
    private OInt mControlChargeTimeValue;
    [Token(Token = "0x4003E69")]
    [FieldOffset(Offset = "0xE8")]
    private OInt mShieldTurn;
    [Token(Token = "0x4003E6A")]
    [FieldOffset(Offset = "0xFC")]
    private OInt mShieldValue;
    [Token(Token = "0x4003E6B")]
    [FieldOffset(Offset = "0x110")]
    public BuffEffect mTargetBuffEffect;
    [Token(Token = "0x4003E6C")]
    [FieldOffset(Offset = "0x114")]
    public CondEffect mTargetCondEffect;
    [Token(Token = "0x4003E6D")]
    [FieldOffset(Offset = "0x118")]
    public BuffEffect mSelfBuffEffect;
    [Token(Token = "0x4003E6E")]
    [FieldOffset(Offset = "0x11C")]
    public CondEffect mSelfCondEffect;
    [Token(Token = "0x4003E6F")]
    [FieldOffset(Offset = "0x120")]
    private OInt mUseRate;
    [Token(Token = "0x4003E70")]
    [FieldOffset(Offset = "0x134")]
    private SkillLockCondition mUseCondition;
    [Token(Token = "0x4003E71")]
    [FieldOffset(Offset = "0x138")]
    private bool mCheckCount;
    [Token(Token = "0x4003E72")]
    [FieldOffset(Offset = "0x13C")]
    private OBool mIsCollabo;
    [Token(Token = "0x4003E73")]
    [FieldOffset(Offset = "0x148")]
    private string mReplaceSkillId;
    [Token(Token = "0x4003E74")]
    [FieldOffset(Offset = "0x14C")]
    public string m_BaseSkillIname;
    [Token(Token = "0x4003E75")]
    [FieldOffset(Offset = "0x150")]
    private AbilityData m_OwnerAbility;
    [Token(Token = "0x4003E76")]
    [FieldOffset(Offset = "0x154")]
    private SkillDeriveParam m_SkillDeriveParam;
    [Token(Token = "0x4003E77")]
    [FieldOffset(Offset = "0x158")]
    private ConceptCardData m_ConceptCardData;
    [Token(Token = "0x4003E78")]
    [FieldOffset(Offset = "0x15C")]
    private int mProtectValue;
    [Token(Token = "0x4003E79")]
    [FieldOffset(Offset = "0x160")]
    private int mManipulateValue;
    [Token(Token = "0x4003E7A")]
    [FieldOffset(Offset = "0x164")]
    private bool m_IsDecreaseEffectOnSubSlot;
    [Token(Token = "0x4003E7B")]
    [FieldOffset(Offset = "0x168")]
    private DependStateSpcEffParam mDependStateSpcEffParam;
    [Token(Token = "0x4003E7C")]
    [FieldOffset(Offset = "0x16C")]
    private DependStateSpcEffParam mDependStateSpcEffParamSelf;
    [Token(Token = "0x4003E7D")]
    private const int ANTI_SHIELD_RATE_MAX = 100;
    [Token(Token = "0x4003E7E")]
    [FieldOffset(Offset = "0x170")]
    private short mAntiShieldIgnoreRate;
    [Token(Token = "0x4003E7F")]
    [FieldOffset(Offset = "0x172")]
    private short mAntiShieldDestroyRate;

    [Token(Token = "0x1700079C")]
    public SkillParam SkillParam
    {
      [Token(Token = "0x60048A3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (SkillParam) null;
      }
    }

    [Token(Token = "0x1700079D")]
    public string SkillID
    {
      [Token(Token = "0x60048A4"), Address(RVA = "0xAA87D0", Offset = "0xAA75D0", VA = "0x10AA87D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700079E")]
    public int Rank
    {
      [Token(Token = "0x60048A5"), Address(RVA = "0x11FB450", Offset = "0x11FA250", VA = "0x111FB450")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700079F")]
    public string Name
    {
      [Token(Token = "0x60048A6"), Address(RVA = "0x805480", Offset = "0x804280", VA = "0x10805480")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170007A0")]
    public ESkillType SkillType
    {
      [Token(Token = "0x60048A7"), Address(RVA = "0x11FB750", Offset = "0x11FA550", VA = "0x111FB750")] get
      {
        return new ESkillType();
      }
    }

    [Token(Token = "0x170007A1")]
    public ESkillTarget Target
    {
      [Token(Token = "0x60048A8"), Address(RVA = "0x11FB770", Offset = "0x11FA570", VA = "0x111FB770")] get
      {
        return new ESkillTarget();
      }
    }

    [Token(Token = "0x170007A2")]
    public ESkillTiming Timing
    {
      [Token(Token = "0x60048A9"), Address(RVA = "0x11FB830", Offset = "0x11FA630", VA = "0x111FB830")] get
      {
        return new ESkillTiming();
      }
    }

    [Token(Token = "0x170007A3")]
    public ESkillCondition Condition
    {
      [Token(Token = "0x60048AA"), Address(RVA = "0x11FAC40", Offset = "0x11F9A40", VA = "0x111FAC40")] get
      {
        return new ESkillCondition();
      }
    }

    [Token(Token = "0x170007A4")]
    public int Cost
    {
      [Token(Token = "0x60048AB"), Address(RVA = "0xACD0C0", Offset = "0xACBEC0", VA = "0x10ACD0C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007A5")]
    public ELineType LineType
    {
      [Token(Token = "0x60048AC"), Address(RVA = "0xACCFF0", Offset = "0xACBDF0", VA = "0x10ACCFF0")] get
      {
        return new ELineType();
      }
    }

    [Token(Token = "0x170007A6")]
    public int EnableAttackGridHeight
    {
      [Token(Token = "0x60048AD"), Address(RVA = "0x11FAED0", Offset = "0x11F9CD0", VA = "0x111FAED0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007A7")]
    public int RangeMin
    {
      [Token(Token = "0x60048AE"), Address(RVA = "0xACD050", Offset = "0xACBE50", VA = "0x10ACD050")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007A8")]
    public int RangeMax
    {
      [Token(Token = "0x60048AF"), Address(RVA = "0x11FB430", Offset = "0x11FA230", VA = "0x111FB430")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007A9")]
    public int Scope
    {
      [Token(Token = "0x60048B0"), Address(RVA = "0x11FB4A0", Offset = "0x11FA2A0", VA = "0x111FB4A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007AA")]
    public int HpCostRate
    {
      [Token(Token = "0x60048B1"), Address(RVA = "0x11FAF10", Offset = "0x11F9D10", VA = "0x111FAF10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007AB")]
    public ECastTypes CastType
    {
      [Token(Token = "0x60048B2"), Address(RVA = "0x11FAC10", Offset = "0x11F9A10", VA = "0x111FAC10")] get
      {
        return new ECastTypes();
      }
    }

    [Token(Token = "0x170007AC")]
    public OInt CastSpeed
    {
      [Token(Token = "0x60048B3"), Address(RVA = "0x90BB40", Offset = "0x90A940", VA = "0x1090BB40")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007AD")]
    public SkillEffectTypes EffectType
    {
      [Token(Token = "0x60048B4"), Address(RVA = "0x11FAE50", Offset = "0x11F9C50", VA = "0x111FAE50")] get
      {
        return new SkillEffectTypes();
      }
    }

    [Token(Token = "0x170007AE")]
    public OInt EffectRate
    {
      [Token(Token = "0x60048B5"), Address(RVA = "0x1196310", Offset = "0x1195110", VA = "0x11196310")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007AF")]
    public OInt EffectValue
    {
      [Token(Token = "0x60048B6"), Address(RVA = "0x11FAE70", Offset = "0x11F9C70", VA = "0x111FAE70")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007B0")]
    public OInt EffectRange
    {
      [Token(Token = "0x60048B7"), Address(RVA = "0x11FAE30", Offset = "0x11F9C30", VA = "0x111FAE30")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007B1")]
    public int EffectHpMaxRate
    {
      [Token(Token = "0x60048B8"), Address(RVA = "0x11FAE10", Offset = "0x11F9C10", VA = "0x111FAE10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007B2")]
    public int EffectGemsMaxRate
    {
      [Token(Token = "0x60048B9"), Address(RVA = "0x11FADF0", Offset = "0x11F9BF0", VA = "0x111FADF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007B3")]
    public int EffectEnemyGemsMaxRate
    {
      [Token(Token = "0x60048BA"), Address(RVA = "0x11FADD0", Offset = "0x11F9BD0", VA = "0x111FADD0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007B4")]
    public SkillParamCalcTypes EffectCalcType
    {
      [Token(Token = "0x60048BB"), Address(RVA = "0x11FADB0", Offset = "0x11F9BB0", VA = "0x111FADB0")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x170007B5")]
    public EElement ElementType
    {
      [Token(Token = "0x60048BC"), Address(RVA = "0x11FAEB0", Offset = "0x11F9CB0", VA = "0x111FAEB0")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x170007B6")]
    public OInt ElementValue
    {
      [Token(Token = "0x60048BD"), Address(RVA = "0x10D21F0", Offset = "0x10D0FF0", VA = "0x110D21F0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007B7")]
    public AttackTypes AttackType
    {
      [Token(Token = "0x60048BE"), Address(RVA = "0x11FABF0", Offset = "0x11F99F0", VA = "0x111FABF0")] get
      {
        return new AttackTypes();
      }
    }

    [Token(Token = "0x170007B8")]
    public AttackDetailTypes AttackDetailType
    {
      [Token(Token = "0x60048BF"), Address(RVA = "0x11FABD0", Offset = "0x11F99D0", VA = "0x111FABD0")] get
      {
        return new AttackDetailTypes();
      }
    }

    [Token(Token = "0x170007B9")]
    public int BackAttackDefenseDownRate
    {
      [Token(Token = "0x60048C0"), Address(RVA = "0xACD120", Offset = "0xACBF20", VA = "0x10ACD120")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007BA")]
    public int SideAttackDefenseDownRate
    {
      [Token(Token = "0x60048C1"), Address(RVA = "0x11FB540", Offset = "0x11FA340", VA = "0x111FB540")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007BB")]
    public DamageTypes ReactionDamageType
    {
      [Token(Token = "0x60048C2"), Address(RVA = "0x11FB480", Offset = "0x11FA280", VA = "0x111FB480")] get
      {
        return new DamageTypes();
      }
    }

    [Token(Token = "0x170007BC")]
    public int DamageAbsorbRate
    {
      [Token(Token = "0x60048C3"), Address(RVA = "0x11FAD40", Offset = "0x11F9B40", VA = "0x111FAD40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007BD")]
    public OInt ControlDamageRate
    {
      [Token(Token = "0x60048C4"), Address(RVA = "0x11FACE0", Offset = "0x11F9AE0", VA = "0x111FACE0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007BE")]
    public OInt ControlDamageValue
    {
      [Token(Token = "0x60048C5"), Address(RVA = "0x11FAD00", Offset = "0x11F9B00", VA = "0x111FAD00")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007BF")]
    public SkillParamCalcTypes ControlDamageCalcType
    {
      [Token(Token = "0x60048C6"), Address(RVA = "0x11FACC0", Offset = "0x11F9AC0", VA = "0x111FACC0")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x170007C0")]
    public OInt ControlChargeTimeRate
    {
      [Token(Token = "0x60048C7"), Address(RVA = "0x11FAC80", Offset = "0x11F9A80", VA = "0x111FAC80")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007C1")]
    public OInt ControlChargeTimeValue
    {
      [Token(Token = "0x60048C8"), Address(RVA = "0x11FACA0", Offset = "0x11F9AA0", VA = "0x111FACA0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007C2")]
    public SkillParamCalcTypes ControlChargeTimeCalcType
    {
      [Token(Token = "0x60048C9"), Address(RVA = "0x11FAC60", Offset = "0x11F9A60", VA = "0x111FAC60")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x170007C3")]
    public ShieldTypes ShieldType
    {
      [Token(Token = "0x60048CA"), Address(RVA = "0x11FB500", Offset = "0x11FA300", VA = "0x111FB500")] get
      {
        return new ShieldTypes();
      }
    }

    [Token(Token = "0x170007C4")]
    public DamageTypes ShieldDamageType
    {
      [Token(Token = "0x60048CB"), Address(RVA = "0x11FB4C0", Offset = "0x11FA2C0", VA = "0x111FB4C0")] get
      {
        return new DamageTypes();
      }
    }

    [Token(Token = "0x170007C5")]
    public OInt ShieldTurn
    {
      [Token(Token = "0x60048CC"), Address(RVA = "0x11FB4E0", Offset = "0x11FA2E0", VA = "0x111FB4E0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007C6")]
    public OInt ShieldValue
    {
      [Token(Token = "0x60048CD"), Address(RVA = "0x11FB520", Offset = "0x11FA320", VA = "0x111FB520")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007C7")]
    public OInt UseRate
    {
      [Token(Token = "0x60048CE"), Address(RVA = "0x11FB850", Offset = "0x11FA650", VA = "0x111FB850")] get
      {
        return new OInt();
      }
      [Token(Token = "0x60048CF"), Address(RVA = "0x11FB990", Offset = "0x11FA790", VA = "0x111FB990")] set
      {
      }
    }

    [Token(Token = "0x170007C8")]
    public SkillLockCondition UseCondition
    {
      [Token(Token = "0x60048D0"), Address(RVA = "0xFC5440", Offset = "0xFC4240", VA = "0x10FC5440")] get
      {
        return (SkillLockCondition) null;
      }
      [Token(Token = "0x60048D1"), Address(RVA = "0x11FB910", Offset = "0x11FA710", VA = "0x111FB910")] set
      {
      }
    }

    [Token(Token = "0x170007C9")]
    public bool CheckCount
    {
      [Token(Token = "0x60048D2"), Address(RVA = "0x11FAC30", Offset = "0x11F9A30", VA = "0x111FAC30")] get
      {
        return new bool();
      }
      [Token(Token = "0x60048D3"), Address(RVA = "0x11FB8B0", Offset = "0x11FA6B0", VA = "0x111FB8B0")] set
      {
      }
    }

    [Token(Token = "0x170007CA")]
    public int DuplicateCount
    {
      [Token(Token = "0x60048D4"), Address(RVA = "0x11FAD90", Offset = "0x11F9B90", VA = "0x111FAD90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007CB")]
    public OBool IsCollabo
    {
      [Token(Token = "0x60048D5"), Address(RVA = "0x11FAF90", Offset = "0x11F9D90", VA = "0x111FAF90")] get
      {
        return new OBool();
      }
      [Token(Token = "0x60048D6"), Address(RVA = "0x11FB8D0", Offset = "0x11FA6D0", VA = "0x111FB8D0")] set
      {
      }
    }

    [Token(Token = "0x170007CC")]
    public string ReplaceSkillId
    {
      [Token(Token = "0x60048D7"), Address(RVA = "0x5E0360", Offset = "0x5DF160", VA = "0x105E0360")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60048D8"), Address(RVA = "0x11FB8F0", Offset = "0x11FA6F0", VA = "0x111FB8F0")] set
      {
      }
    }

    [Token(Token = "0x170007CD")]
    public eTeleportType TeleportType
    {
      [Token(Token = "0x60048D9"), Address(RVA = "0x11FB810", Offset = "0x11FA610", VA = "0x111FB810")] get
      {
        return new eTeleportType();
      }
    }

    [Token(Token = "0x170007CE")]
    public ESkillTarget TeleportTarget
    {
      [Token(Token = "0x60048DA"), Address(RVA = "0x11FB7F0", Offset = "0x11FA5F0", VA = "0x111FB7F0")] get
      {
        return new ESkillTarget();
      }
    }

    [Token(Token = "0x170007CF")]
    public int TeleportHeight
    {
      [Token(Token = "0x60048DB"), Address(RVA = "0x11FB790", Offset = "0x11FA590", VA = "0x111FB790")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007D0")]
    public bool TeleportIsMove
    {
      [Token(Token = "0x60048DC"), Address(RVA = "0x11FB7B0", Offset = "0x11FA5B0", VA = "0x111FB7B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007D1")]
    public eTeleportSkillPos TeleportSkillPos
    {
      [Token(Token = "0x60048DD"), Address(RVA = "0x11FB7D0", Offset = "0x11FA5D0", VA = "0x111FB7D0")] get
      {
        return new eTeleportSkillPos();
      }
    }

    [Token(Token = "0x170007D2")]
    public OInt KnockBackRate
    {
      [Token(Token = "0x60048DE"), Address(RVA = "0x11FB1F0", Offset = "0x11F9FF0", VA = "0x111FB1F0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007D3")]
    public OInt KnockBackVal
    {
      [Token(Token = "0x60048DF"), Address(RVA = "0x11FB230", Offset = "0x11FA030", VA = "0x111FB230")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007D4")]
    public eKnockBackDir KnockBackDir
    {
      [Token(Token = "0x60048E0"), Address(RVA = "0x11FB1B0", Offset = "0x11F9FB0", VA = "0x111FB1B0")] get
      {
        return new eKnockBackDir();
      }
    }

    [Token(Token = "0x170007D5")]
    public eKnockBackDs KnockBackDs
    {
      [Token(Token = "0x60048E1"), Address(RVA = "0x11FB1D0", Offset = "0x11F9FD0", VA = "0x111FB1D0")] get
      {
        return new eKnockBackDs();
      }
    }

    [Token(Token = "0x170007D6")]
    public int WeatherRate
    {
      [Token(Token = "0x60048E2"), Address(RVA = "0x11FB890", Offset = "0x11FA690", VA = "0x111FB890")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007D7")]
    public string WeatherId
    {
      [Token(Token = "0x60048E3"), Address(RVA = "0x11FB870", Offset = "0x11FA670", VA = "0x111FB870")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170007D8")]
    public int ElementSpcAtkRate
    {
      [Token(Token = "0x60048E4"), Address(RVA = "0x11FAE90", Offset = "0x11F9C90", VA = "0x111FAE90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007D9")]
    public int MaxDamageValue
    {
      [Token(Token = "0x60048E5"), Address(RVA = "0x11FB270", Offset = "0x11FA070", VA = "0x111FB270")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007DA")]
    public string CutInConceptCardId
    {
      [Token(Token = "0x60048E6"), Address(RVA = "0x11FAD20", Offset = "0x11F9B20", VA = "0x111FAD20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170007DB")]
    public eAbsorbAndGive AbsorbAndGive
    {
      [Token(Token = "0x60048E7"), Address(RVA = "0x11FABB0", Offset = "0x11F99B0", VA = "0x111FABB0")] get
      {
        return new eAbsorbAndGive();
      }
    }

    [Token(Token = "0x170007DC")]
    public int JumpSpcAtkRate
    {
      [Token(Token = "0x60048E8"), Address(RVA = "0x11FB190", Offset = "0x11F9F90", VA = "0x111FB190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007DD")]
    public AbilityData OwnerAbiliy
    {
      [Token(Token = "0x60048E9"), Address(RVA = "0xA23400", Offset = "0xA22200", VA = "0x10A23400")] get
      {
        return (AbilityData) null;
      }
    }

    [Token(Token = "0x170007DE")]
    public bool IsDerivedSkill
    {
      [Token(Token = "0x60048EA"), Address(RVA = "0x11FAFD0", Offset = "0x11F9DD0", VA = "0x111FAFD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007DF")]
    public SkillDeriveParam DeriveParam
    {
      [Token(Token = "0x60048EB"), Address(RVA = "0x3495B0", Offset = "0x3483B0", VA = "0x103495B0")] get
      {
        return (SkillDeriveParam) null;
      }
    }

    [Token(Token = "0x170007E0")]
    public bool IsCreatedByConceptCard
    {
      [Token(Token = "0x60048EC"), Address(RVA = "0x11FAFB0", Offset = "0x11F9DB0", VA = "0x111FAFB0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007E1")]
    public ConceptCardData ConceptCard
    {
      [Token(Token = "0x60048ED"), Address(RVA = "0x3405B0", Offset = "0x33F3B0", VA = "0x103405B0")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x170007E2")]
    public bool IsDecreaseEffectOnSubSlot
    {
      [Token(Token = "0x60048EE"), Address(RVA = "0x101C990", Offset = "0x101B790", VA = "0x1101C990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007E3")]
    public int DecreaseEffectRate
    {
      [Token(Token = "0x60048EF"), Address(RVA = "0x11FAD60", Offset = "0x11F9B60", VA = "0x111FAD60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007E4")]
    public ProtectSkillParam ProtectSkill
    {
      [Token(Token = "0x60048F0"), Address(RVA = "0x11FB3C0", Offset = "0x11FA1C0", VA = "0x111FB3C0")] get
      {
        return (ProtectSkillParam) null;
      }
    }

    [Token(Token = "0x170007E5")]
    public ProtectTypes ProtectType
    {
      [Token(Token = "0x60048F1"), Address(RVA = "0x11FB3E0", Offset = "0x11FA1E0", VA = "0x111FB3E0")] get
      {
        return new ProtectTypes();
      }
    }

    [Token(Token = "0x170007E6")]
    public DamageTypes ProtectDamageType
    {
      [Token(Token = "0x60048F2"), Address(RVA = "0x11FB290", Offset = "0x11FA090", VA = "0x111FB290")] get
      {
        return new DamageTypes();
      }
    }

    [Token(Token = "0x170007E7")]
    public OInt ProtectRange
    {
      [Token(Token = "0x60048F3"), Address(RVA = "0x11FB350", Offset = "0x11FA150", VA = "0x111FB350")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007E8")]
    public OInt ProtectHeight
    {
      [Token(Token = "0x60048F4"), Address(RVA = "0x11FB2E0", Offset = "0x11FA0E0", VA = "0x111FB2E0")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x170007E9")]
    public int ProtectValue
    {
      [Token(Token = "0x60048F5"), Address(RVA = "0x3B12F0", Offset = "0x3B00F0", VA = "0x103B12F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007EA")]
    public int SkillManipulateValue
    {
      [Token(Token = "0x60048F6"), Address(RVA = "0xFA0CB0", Offset = "0xF9FAB0", VA = "0x10FA0CB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60048F7")]
    [Address(RVA = "0x11F9FE0", Offset = "0x11F8DE0", VA = "0x111F9FE0")]
    public void Setup(
      string iname,
      int rank,
      int rankcap = 1,
      MasterParam master = null,
      ConceptCardEffectDecreaseInfo decreaseInfo = null)
    {
    }

    [Token(Token = "0x60048F8")]
    [Address(RVA = "0x11F9F90", Offset = "0x11F8D90", VA = "0x111F9F90")]
    private void Reset()
    {
    }

    [Token(Token = "0x60048F9")]
    [Address(RVA = "0x39EF50", Offset = "0x39DD50", VA = "0x1039EF50")]
    public bool IsValid() => new bool();

    [Token(Token = "0x60048FA")]
    [Address(RVA = "0x3B4040", Offset = "0x3B2E40", VA = "0x103B4040")]
    public int GetRankCap() => new int();

    [Token(Token = "0x60048FB")]
    [Address(RVA = "0x11FA780", Offset = "0x11F9580", VA = "0x111FA780")]
    public void UpdateParam()
    {
    }

    [Token(Token = "0x60048FC")]
    [Address(RVA = "0x11F9BC0", Offset = "0x11F89C0", VA = "0x111F9BC0")]
    public bool IsNormalAttack() => new bool();

    [Token(Token = "0x60048FD")]
    [Address(RVA = "0x11F9BE0", Offset = "0x11F89E0", VA = "0x111F9BE0")]
    public bool IsPassiveSkill() => new bool();

    [Token(Token = "0x60048FE")]
    [Address(RVA = "0x11F9A30", Offset = "0x11F8830", VA = "0x111F9A30")]
    public bool IsItem() => new bool();

    [Token(Token = "0x60048FF")]
    [Address(RVA = "0x11F9D50", Offset = "0x11F8B50", VA = "0x111F9D50")]
    public bool IsReactionSkill() => new bool();

    [Token(Token = "0x6004900")]
    [Address(RVA = "0x11F9880", Offset = "0x11F8680", VA = "0x111F9880")]
    public bool IsEnableChangeRange() => new bool();

    [Token(Token = "0x6004901")]
    [Address(RVA = "0x11F98E0", Offset = "0x11F86E0", VA = "0x111F98E0")]
    public bool IsEnableHeightRangeBonus() => new bool();

    [Token(Token = "0x6004902")]
    [Address(RVA = "0x11F98B0", Offset = "0x11F86B0", VA = "0x111F98B0")]
    public bool IsEnableHeightParamAdjust() => new bool();

    [Token(Token = "0x6004903")]
    [Address(RVA = "0x11F9910", Offset = "0x11F8710", VA = "0x111F9910")]
    public bool IsEnableUnitLockTarget() => new bool();

    [Token(Token = "0x6004904")]
    [Address(RVA = "0x11F9820", Offset = "0x11F8620", VA = "0x111F9820")]
    public bool IsDamagedSkill() => new bool();

    [Token(Token = "0x6004905")]
    [Address(RVA = "0x11F9CF0", Offset = "0x11F8AF0", VA = "0x111F9CF0")]
    public bool IsRateDamagedSkill() => new bool();

    [Token(Token = "0x6004906")]
    [Address(RVA = "0x11F99D0", Offset = "0x11F87D0", VA = "0x111F99D0")]
    public bool IsHealSkill() => new bool();

    [Token(Token = "0x6004907")]
    [Address(RVA = "0x11F9F00", Offset = "0x11F8D00", VA = "0x111F9F00")]
    public bool IsSupportedSkill() => new bool();

    [Token(Token = "0x6004908")]
    [Address(RVA = "0x11F9C30", Offset = "0x11F8A30", VA = "0x111F9C30")]
    public bool IsPierce() => new bool();

    [Token(Token = "0x6004909")]
    [Address(RVA = "0x11F9A50", Offset = "0x11F8850", VA = "0x111F9A50")]
    public bool IsJewelAttack() => new bool();

    [Token(Token = "0x600490A")]
    [Address(RVA = "0x11F9970", Offset = "0x11F8770", VA = "0x111F9970")]
    public bool IsForceHit() => new bool();

    [Token(Token = "0x600490B")]
    [Address(RVA = "0x11F9EA0", Offset = "0x11F8CA0", VA = "0x111F9EA0")]
    public bool IsSuicide() => new bool();

    [Token(Token = "0x600490C")]
    [Address(RVA = "0x11F9E70", Offset = "0x11F8C70", VA = "0x111F9E70")]
    public bool IsSubActuate() => new bool();

    [Token(Token = "0x600490D")]
    [Address(RVA = "0x11F9940", Offset = "0x11F8740", VA = "0x111F9940")]
    public bool IsFixedDamage() => new bool();

    [Token(Token = "0x600490E")]
    [Address(RVA = "0x11F99A0", Offset = "0x11F87A0", VA = "0x111F99A0")]
    public bool IsForceUnitLock() => new bool();

    [Token(Token = "0x600490F")]
    [Address(RVA = "0x11F9670", Offset = "0x11F8470", VA = "0x111F9670")]
    public bool IsAllDamageReaction() => new bool();

    [Token(Token = "0x6004910")]
    [Address(RVA = "0x11F9A00", Offset = "0x11F8800", VA = "0x111F9A00")]
    public bool IsIgnoreElement() => new bool();

    [Token(Token = "0x6004911")]
    [Address(RVA = "0x11F9C60", Offset = "0x11F8A60", VA = "0x111F9C60")]
    public bool IsPrevApply() => new bool();

    [Token(Token = "0x6004912")]
    [Address(RVA = "0x11F9B30", Offset = "0x11F8930", VA = "0x111F9B30")]
    public bool IsMhmDamage() => new bool();

    [Token(Token = "0x6004913")]
    [Address(RVA = "0x11F9730", Offset = "0x11F8530", VA = "0x111F9730")]
    public bool IsCastBreak() => new bool();

    [Token(Token = "0x6004914")]
    [Address(RVA = "0x11F9760", Offset = "0x11F8560", VA = "0x111F9760")]
    public bool IsCastSkill() => new bool();

    [Token(Token = "0x6004915")]
    [Address(RVA = "0x11F97F0", Offset = "0x11F85F0", VA = "0x111F97F0")]
    public bool IsCutin() => new bool();

    [Token(Token = "0x6004916")]
    [Address(RVA = "0x11F9B00", Offset = "0x11F8900", VA = "0x111F9B00")]
    public bool IsMapSkill() => new bool();

    [Token(Token = "0x6004917")]
    [Address(RVA = "0x11F9700", Offset = "0x11F8500", VA = "0x111F9700")]
    public bool IsBattleSkill() => new bool();

    [Token(Token = "0x6004918")]
    [Address(RVA = "0x11F96D0", Offset = "0x11F84D0", VA = "0x111F96D0")]
    public bool IsAreaSkill() => new bool();

    [Token(Token = "0x6004919")]
    [Address(RVA = "0x11F96A0", Offset = "0x11F84A0", VA = "0x111F96A0")]
    public bool IsAllEffect() => new bool();

    [Token(Token = "0x600491A")]
    [Address(RVA = "0x11F9AB0", Offset = "0x11F88B0", VA = "0x111F9AB0")]
    public bool IsLongRangeSkill() => new bool();

    [Token(Token = "0x600491B")]
    [Address(RVA = "0x11F9ED0", Offset = "0x11F8CD0", VA = "0x111F9ED0")]
    public bool IsSupportSkill() => new bool();

    [Token(Token = "0x600491C")]
    [Address(RVA = "0x11F9F60", Offset = "0x11F8D60", VA = "0x111F9F60")]
    public bool IsTrickSkill() => new bool();

    [Token(Token = "0x600491D")]
    [Address(RVA = "0x11F9F30", Offset = "0x11F8D30", VA = "0x111F9F30")]
    public bool IsTransformSkill() => new bool();

    [Token(Token = "0x600491E")]
    [Address(RVA = "0x11F9850", Offset = "0x11F8650", VA = "0x111F9850")]
    public bool IsDynamicTransformSkill() => new bool();

    [Token(Token = "0x600491F")]
    [Address(RVA = "0x11F9DB0", Offset = "0x11F8BB0", VA = "0x111F9DB0")]
    public bool IsSetBreakObjSkill() => new bool();

    [Token(Token = "0x6004920")]
    [Address(RVA = "0x11F9790", Offset = "0x11F8590", VA = "0x111F9790")]
    public bool IsChangeWeatherSkill() => new bool();

    [Token(Token = "0x6004921")]
    [Address(RVA = "0x11F9A80", Offset = "0x11F8880", VA = "0x111F9A80")]
    public bool IsJudgeHp(Unit unit) => new bool();

    [Token(Token = "0x6004922")]
    [Address(RVA = "0x11F97C0", Offset = "0x11F85C0", VA = "0x111F97C0")]
    public bool IsConditionSkill() => new bool();

    [Token(Token = "0x6004923")]
    [Address(RVA = "0x11F9C10", Offset = "0x11F8A10", VA = "0x111F9C10")]
    public bool IsPhysicalAttack() => new bool();

    [Token(Token = "0x6004924")]
    [Address(RVA = "0x11F9AE0", Offset = "0x11F88E0", VA = "0x111F9AE0")]
    public bool IsMagicalAttack() => new bool();

    [Token(Token = "0x6004925")]
    [Address(RVA = "0x11F9D80", Offset = "0x11F8B80", VA = "0x111F9D80")]
    public bool IsSelfTargetSelect() => new bool();

    [Token(Token = "0x6004926")]
    [Address(RVA = "0x11F9610", Offset = "0x11F8410", VA = "0x111F9610")]
    public bool IsAdvantage() => new bool();

    [Token(Token = "0x6004927")]
    [Address(RVA = "0x11F9640", Offset = "0x11F8440", VA = "0x111F9640")]
    public bool IsAiNoAutoTiming() => new bool();

    [Token(Token = "0x6004928")]
    [Address(RVA = "0x11F9B60", Offset = "0x11F8960", VA = "0x111F9B60")]
    public bool IsMpUseAfter() => new bool();

    [Token(Token = "0x170007EB")]
    public bool IsForcedTargeting
    {
      [Token(Token = "0x6004929"), Address(RVA = "0x11FB050", Offset = "0x11F9E50", VA = "0x111FB050")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007EC")]
    public int ForcedTargetingTurn
    {
      [Token(Token = "0x600492A"), Address(RVA = "0x11FAEF0", Offset = "0x11F9CF0", VA = "0x111FAEF0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170007ED")]
    public bool IsForcedTargetingSkillEffect
    {
      [Token(Token = "0x600492B"), Address(RVA = "0x11FB020", Offset = "0x11F9E20", VA = "0x111FB020")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600492C")]
    [Address(RVA = "0x11F8350", Offset = "0x11F7150", VA = "0x111F8350")]
    public bool CheckGridLineSkill() => new bool();

    [Token(Token = "0x600492D")]
    [Address(RVA = "0x11F8380", Offset = "0x11F7180", VA = "0x111F8380")]
    public bool CheckUnitSkillTarget() => new bool();

    [Token(Token = "0x600492E")]
    [Address(RVA = "0x11F8D50", Offset = "0x11F7B50", VA = "0x111F8D50")]
    public int GetHpCost(Unit self) => new int();

    [Token(Token = "0x600492F")]
    [Address(RVA = "0x11F8710", Offset = "0x11F7510", VA = "0x111F8710")]
    public BuffEffect GetBuffEffect(SkillEffectTargets target = SkillEffectTargets.Target)
    {
      return (BuffEffect) null;
    }

    [Token(Token = "0x6004930")]
    [Address(RVA = "0x11F8770", Offset = "0x11F7570", VA = "0x111F8770")]
    public CondEffect GetCondEffect(SkillEffectTargets target = SkillEffectTargets.Target)
    {
      return (CondEffect) null;
    }

    [Token(Token = "0x6004931")]
    [Address(RVA = "0x11F81D0", Offset = "0x11F6FD0", VA = "0x111F81D0")]
    public int CalcBuffEffectValue(
      ESkillTiming timing,
      ParamTypes type,
      int src,
      SkillEffectTargets target = SkillEffectTargets.Target)
    {
      return new int();
    }

    [Token(Token = "0x6004932")]
    [Address(RVA = "0x11F82A0", Offset = "0x11F70A0", VA = "0x111F82A0")]
    public int CalcBuffEffectValue(ParamTypes type, int src, SkillEffectTargets target = SkillEffectTargets.Target)
    {
      return new int();
    }

    [Token(Token = "0x6004933")]
    [Address(RVA = "0x11F86B0", Offset = "0x11F74B0", VA = "0x111F86B0")]
    public int GetBuffEffectValue(ParamTypes type, SkillEffectTargets target = SkillEffectTargets.Target)
    {
      return new int();
    }

    [Token(Token = "0x6004934")]
    [Address(RVA = "0x11F7F50", Offset = "0x11F6D50", VA = "0x111F7F50")]
    public bool BuffSkill(
      ESkillTiming timing,
      EElement element,
      BaseStatus buff,
      BaseStatus buff_negative,
      BaseStatus buff_scale,
      BaseStatus debuff,
      BaseStatus debuff_negative,
      BaseStatus debuff_scale,
      RandXorshift rand = null,
      SkillEffectTargets buff_target = SkillEffectTargets.Target,
      bool is_resume = false,
      List<BuffEffect.BuffValues> list = null,
      bool calcDecreaseEffect = false,
      UnitData unit = null)
    {
      return new bool();
    }

    [Token(Token = "0x6004935")]
    [Address(RVA = "0x11F9340", Offset = "0x11F8140", VA = "0x111F9340")]
    private void InternalBuffSkill(
      BuffEffect effect,
      EElement element,
      BuffTypes buffType,
      bool is_check_negative_value,
      bool is_negative_value_is_buff,
      SkillParamCalcTypes calcType,
      BaseStatus status,
      List<BuffEffect.BuffValues> list = null,
      bool calcDecreaseEffect = false,
      UnitData unit = null)
    {
    }

    [Token(Token = "0x6004936")]
    [Address(RVA = "0x11F8740", Offset = "0x11F7540", VA = "0x111F8740")]
    private BuffMethodTypes GetBuffMethodType(BuffTypes buff, SkillParamCalcTypes calc)
    {
      return new BuffMethodTypes();
    }

    [Token(Token = "0x6004937")]
    [Address(RVA = "0x11F9D20", Offset = "0x11F8B20", VA = "0x111F9D20")]
    public bool IsReactionDet(AttackDetailTypes atk_detail_type) => new bool();

    [Token(Token = "0x6004938")]
    [Address(RVA = "0x11F88E0", Offset = "0x11F76E0", VA = "0x111F88E0")]
    public static void GetHomePassiveBuffStatus(
      SkillData skill,
      EElement element,
      ref BaseStatus status,
      ref BaseStatus scale_status,
      bool calcDecreaseEffect = false,
      UnitData unit = null)
    {
    }

    [Token(Token = "0x6004939")]
    [Address(RVA = "0x11F8910", Offset = "0x11F7710", VA = "0x111F8910")]
    public static void GetHomePassiveBuffStatus(
      SkillData skill,
      EElement element,
      ref BaseStatus status,
      ref BaseStatus negative_status,
      ref BaseStatus debuff_status,
      ref BaseStatus negative_debuff_status,
      ref BaseStatus scale_status,
      bool calcDecreaseEffect = false,
      UnitData unit = null)
    {
    }

    [Token(Token = "0x600493A")]
    [Address(RVA = "0x11F8E20", Offset = "0x11F7C20", VA = "0x111F8E20")]
    public static void GetPassiveBuffStatus(
      SkillData skill,
      BuffEffect[] add_buff_effects,
      EElement element,
      ref BaseStatus status,
      ref BaseStatus scale_status)
    {
    }

    [Token(Token = "0x600493B")]
    [Address(RVA = "0x11F8E50", Offset = "0x11F7C50", VA = "0x111F8E50")]
    public static void GetPassiveBuffStatus(
      SkillData skill,
      BuffEffect[] add_buff_effects,
      EElement element,
      ref BaseStatus status,
      ref BaseStatus negative_status,
      ref BaseStatus debuff_status,
      ref BaseStatus negative_debuff_status,
      ref BaseStatus scale_status)
    {
    }

    [Token(Token = "0x170007EE")]
    public bool IsTargetGridNoUnit
    {
      [Token(Token = "0x600493C"), Address(RVA = "0x11FB100", Offset = "0x11F9F00", VA = "0x111FB100")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007EF")]
    public bool IsTargetValidGrid
    {
      [Token(Token = "0x600493D"), Address(RVA = "0x11FB160", Offset = "0x11F9F60", VA = "0x111FB160")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007F0")]
    public bool IsSkillCountNoLimit
    {
      [Token(Token = "0x600493E"), Address(RVA = "0x11FB0D0", Offset = "0x11F9ED0", VA = "0x111FB0D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007F1")]
    public bool IsTargetTeleport
    {
      [Token(Token = "0x600493F"), Address(RVA = "0x11FB130", Offset = "0x11F9F30", VA = "0x111FB130")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004940")]
    [Address(RVA = "0xA464B0", Offset = "0xA452B0", VA = "0x10A464B0")]
    public void SetOwnerAbility(AbilityData owner)
    {
    }

    [Token(Token = "0x6004941")]
    [Address(RVA = "0x11F83C0", Offset = "0x11F71C0", VA = "0x111F83C0")]
    public SkillData CreateDeriveSkill(SkillDeriveParam skillDeriveParam) => (SkillData) null;

    [Token(Token = "0x6004942")]
    [Address(RVA = "0x11F8840", Offset = "0x11F7640", VA = "0x111F8840")]
    public DependStateSpcEffParam GetDependStateSpcEffParam() => (DependStateSpcEffParam) null;

    [Token(Token = "0x6004943")]
    [Address(RVA = "0x11F87A0", Offset = "0x11F75A0", VA = "0x111F87A0")]
    public DependStateSpcEffParam GetDependStateSpcEffParamSelf() => (DependStateSpcEffParam) null;

    [Token(Token = "0x6004944")]
    [Address(RVA = "0x11F9B90", Offset = "0x11F8990", VA = "0x111F9B90")]
    public bool IsNeedDecreaseEffect() => new bool();

    [Token(Token = "0x6004945")]
    [Address(RVA = "0x11F9CC0", Offset = "0x11F8AC0", VA = "0x111F9CC0")]
    public bool IsProtectSkill() => new bool();

    [Token(Token = "0x6004946")]
    [Address(RVA = "0x11F9C90", Offset = "0x11F8A90", VA = "0x111F9C90")]
    public bool IsProtectReactionSkill() => new bool();

    [Token(Token = "0x170007F2")]
    public bool IsNeedResetDirection
    {
      [Token(Token = "0x6004947"), Address(RVA = "0x11FB070", Offset = "0x11F9E70", VA = "0x111FB070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007F3")]
    public bool IsShowSkillNamePlate
    {
      [Token(Token = "0x6004948"), Address(RVA = "0x11FB0A0", Offset = "0x11F9EA0", VA = "0x111FB0A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007F4")]
    public bool IsAllowCutIn
    {
      [Token(Token = "0x6004949"), Address(RVA = "0x11FAF60", Offset = "0x11F9D60", VA = "0x111FAF60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007F5")]
    public bool IsAdditionalSkill
    {
      [Token(Token = "0x600494A"), Address(RVA = "0x11FAF30", Offset = "0x11F9D30", VA = "0x111FAF30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007F6")]
    public SkillAdditionalParam SkillAdditional
    {
      [Token(Token = "0x600494B"), Address(RVA = "0x11FB560", Offset = "0x11FA360", VA = "0x111FB560")] get
      {
        return (SkillAdditionalParam) null;
      }
    }

    [Token(Token = "0x170007F7")]
    public SkillAntiShieldParam SkillAntiShield
    {
      [Token(Token = "0x600494C"), Address(RVA = "0x11FB590", Offset = "0x11FA390", VA = "0x111FB590")] get
      {
        return (SkillAntiShieldParam) null;
      }
    }

    [Token(Token = "0x600494D")]
    [Address(RVA = "0x11F85E0", Offset = "0x11F73E0", VA = "0x111F85E0")]
    public int GetAntiShieldIgnoreRate() => new int();

    [Token(Token = "0x600494E")]
    [Address(RVA = "0x11F8510", Offset = "0x11F7310", VA = "0x111F8510")]
    public int GetAntiShieldDestroyRate() => new int();

    [Token(Token = "0x170007F8")]
    public SkillRevivalParam SkillRevival
    {
      [Token(Token = "0x600494F"), Address(RVA = "0x11FB720", Offset = "0x11FA520", VA = "0x111FB720")] get
      {
        return (SkillRevivalParam) null;
      }
    }

    [Token(Token = "0x6004950")]
    [Address(RVA = "0x11F92E0", Offset = "0x11F80E0", VA = "0x111F92E0")]
    public string GetSkillRevivalBuffName(AttackDetailTypes type) => (string) null;

    [Token(Token = "0x170007F9")]
    public SkillAutoHpJudgeParam SkillAutoHpJudge
    {
      [Token(Token = "0x6004951"), Address(RVA = "0x11FB5C0", Offset = "0x11FA3C0", VA = "0x111FB5C0")] get
      {
        return (SkillAutoHpJudgeParam) null;
      }
    }

    [Token(Token = "0x6004952")]
    [Address(RVA = "0x11F9230", Offset = "0x11F8030", VA = "0x111F9230")]
    public List<SkillAutoHpJudgeSkill> GetSkillByHp(int hp, int max)
    {
      return (List<SkillAutoHpJudgeSkill>) null;
    }

    [Token(Token = "0x170007FA")]
    public SkillCriticalHealParam SkillCriticalHeal
    {
      [Token(Token = "0x6004953"), Address(RVA = "0x11FB5F0", Offset = "0x11FA3F0", VA = "0x111FB5F0")] get
      {
        return (SkillCriticalHealParam) null;
      }
    }

    [Token(Token = "0x170007FB")]
    public bool IsDuplicateResetSkill
    {
      [Token(Token = "0x6004954"), Address(RVA = "0x11FAFF0", Offset = "0x11F9DF0", VA = "0x111FAFF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170007FC")]
    public SkillDuplicateResetParam SkillDuplicateReset
    {
      [Token(Token = "0x6004955"), Address(RVA = "0x11FB620", Offset = "0x11FA420", VA = "0x111FB620")] get
      {
        return (SkillDuplicateResetParam) null;
      }
    }

    [Token(Token = "0x6004956")]
    [Address(RVA = "0x11F92B0", Offset = "0x11F80B0", VA = "0x111F92B0")]
    public SkillManipulateParam GetSkillManipulate() => (SkillManipulateParam) null;

    [Token(Token = "0x6004957")]
    [Address(RVA = "0x11F9E40", Offset = "0x11F8C40", VA = "0x111F9E40")]
    public bool IsSkillManipulate() => new bool();

    [Token(Token = "0x6004958")]
    [Address(RVA = "0x11F9280", Offset = "0x11F8080", VA = "0x111F9280")]
    public SkillManipulatePierceParam GetSkillManipulatePierce()
    {
      return (SkillManipulatePierceParam) null;
    }

    [Token(Token = "0x6004959")]
    [Address(RVA = "0x11F9E10", Offset = "0x11F8C10", VA = "0x111F9E10")]
    public bool IsSkillManipulatePierce() => new bool();

    [Token(Token = "0x600495A")]
    [Address(RVA = "0x11F9DE0", Offset = "0x11F8BE0", VA = "0x111F9DE0")]
    public bool IsSkillForceBomb() => new bool();

    [Token(Token = "0x170007FD")]
    public SkillReactionCondParam SkillReactionCond
    {
      [Token(Token = "0x600495B"), Address(RVA = "0x11FB650", Offset = "0x11FA450", VA = "0x111FB650")] get
      {
        return (SkillReactionCondParam) null;
      }
    }

    [Token(Token = "0x600495C")]
    [Address(RVA = "0x11FAB50", Offset = "0x11F9950", VA = "0x111FAB50")]
    public SkillData()
    {
    }
  }
}
