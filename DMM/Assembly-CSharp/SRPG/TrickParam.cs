// Decompiled with JetBrains decompiler
// Type: SRPG.TrickParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D84")]
  public class TrickParam
  {
    [Token(Token = "0x40074BD")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40074BE")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x40074BF")]
    [FieldOffset(Offset = "0x10")]
    private string mExpr;
    [Token(Token = "0x40074C0")]
    [FieldOffset(Offset = "0x14")]
    private eTrickDamageType mDamageType;
    [Token(Token = "0x40074C1")]
    [FieldOffset(Offset = "0x18")]
    private OInt mDamageVal;
    [Token(Token = "0x40074C2")]
    [FieldOffset(Offset = "0x2C")]
    private SkillParamCalcTypes mCalcType;
    [Token(Token = "0x40074C3")]
    [FieldOffset(Offset = "0x2D")]
    private EElement mElem;
    [Token(Token = "0x40074C4")]
    [FieldOffset(Offset = "0x2E")]
    private AttackDetailTypes mAttackDetail;
    [Token(Token = "0x40074C5")]
    [FieldOffset(Offset = "0x30")]
    private string mBuffId;
    [Token(Token = "0x40074C6")]
    [FieldOffset(Offset = "0x34")]
    private string mCondId;
    [Token(Token = "0x40074C7")]
    [FieldOffset(Offset = "0x38")]
    private OInt mKnockBackRate;
    [Token(Token = "0x40074C8")]
    [FieldOffset(Offset = "0x4C")]
    private OInt mKnockBackVal;
    [Token(Token = "0x40074C9")]
    [FieldOffset(Offset = "0x60")]
    private ESkillTarget mTarget;
    [Token(Token = "0x40074CA")]
    [FieldOffset(Offset = "0x64")]
    private eTrickVisualType mVisualType;
    [Token(Token = "0x40074CB")]
    [FieldOffset(Offset = "0x68")]
    private OInt mActionCount;
    [Token(Token = "0x40074CC")]
    [FieldOffset(Offset = "0x7C")]
    private OInt mValidClock;
    [Token(Token = "0x40074CD")]
    [FieldOffset(Offset = "0x90")]
    private string mMarkerName;
    [Token(Token = "0x40074CE")]
    [FieldOffset(Offset = "0x94")]
    private string mEffectName;
    [Token(Token = "0x40074CF")]
    [FieldOffset(Offset = "0x98")]
    private ESkillTarget mEffTarget;
    [Token(Token = "0x40074D0")]
    [FieldOffset(Offset = "0x99")]
    private ESelectType mEffShape;
    [Token(Token = "0x40074D1")]
    [FieldOffset(Offset = "0x9C")]
    private OInt mEffScope;
    [Token(Token = "0x40074D2")]
    [FieldOffset(Offset = "0xB0")]
    private OInt mEffHeight;
    [Token(Token = "0x40074D3")]
    [FieldOffset(Offset = "0xC4")]
    private eMovType[] mIgnoreMovTypes;
    [Token(Token = "0x40074D4")]
    [FieldOffset(Offset = "0xC8")]
    private EnumBitArray<TrickParam.eFlag> mFlag;

    [Token(Token = "0x1700102B")]
    public string Iname
    {
      [Token(Token = "0x60078A9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700102C")]
    public string Name
    {
      [Token(Token = "0x60078AA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700102D")]
    public string Expr
    {
      [Token(Token = "0x60078AB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700102E")]
    public eTrickDamageType DamageType
    {
      [Token(Token = "0x60078AC"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new eTrickDamageType();
      }
    }

    [Token(Token = "0x1700102F")]
    public OInt DamageVal
    {
      [Token(Token = "0x60078AD"), Address(RVA = "0x3A6440", Offset = "0x3A5240", VA = "0x103A6440")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001030")]
    public SkillParamCalcTypes CalcType
    {
      [Token(Token = "0x60078AE"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new SkillParamCalcTypes();
      }
    }

    [Token(Token = "0x17001031")]
    public EElement Elem
    {
      [Token(Token = "0x60078AF"), Address(RVA = "0x34B870", Offset = "0x34A670", VA = "0x1034B870")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x17001032")]
    public AttackDetailTypes AttackDetail
    {
      [Token(Token = "0x60078B0"), Address(RVA = "0x39CB50", Offset = "0x39B950", VA = "0x1039CB50")] get
      {
        return new AttackDetailTypes();
      }
    }

    [Token(Token = "0x17001033")]
    public string BuffId
    {
      [Token(Token = "0x60078B1"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001034")]
    public string CondId
    {
      [Token(Token = "0x60078B2"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001035")]
    public OInt KnockBackRate
    {
      [Token(Token = "0x60078B3"), Address(RVA = "0x3A6630", Offset = "0x3A5430", VA = "0x103A6630")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001036")]
    public OInt KnockBackVal
    {
      [Token(Token = "0x60078B4"), Address(RVA = "0x3A6650", Offset = "0x3A5450", VA = "0x103A6650")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001037")]
    public ESkillTarget Target
    {
      [Token(Token = "0x60078B5"), Address(RVA = "0x3A6670", Offset = "0x3A5470", VA = "0x103A6670")] get
      {
        return new ESkillTarget();
      }
    }

    [Token(Token = "0x17001038")]
    public eTrickVisualType VisualType
    {
      [Token(Token = "0x60078B6"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return new eTrickVisualType();
      }
    }

    [Token(Token = "0x17001039")]
    public OInt ActionCount
    {
      [Token(Token = "0x60078B7"), Address(RVA = "0x3A6420", Offset = "0x3A5220", VA = "0x103A6420")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700103A")]
    public OInt ValidClock
    {
      [Token(Token = "0x60078B8"), Address(RVA = "0x3A6680", Offset = "0x3A5480", VA = "0x103A6680")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x1700103B")]
    public bool IsNoOverWrite
    {
      [Token(Token = "0x60078B9"), Address(RVA = "0x3A6590", Offset = "0x3A5390", VA = "0x103A6590")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700103C")]
    public string MarkerName
    {
      [Token(Token = "0x60078BA"), Address(RVA = "0x3492D0", Offset = "0x3480D0", VA = "0x103492D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700103D")]
    public string EffectName
    {
      [Token(Token = "0x60078BB"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700103E")]
    public ESkillTarget EffTarget
    {
      [Token(Token = "0x60078BC"), Address(RVA = "0x3A64B0", Offset = "0x3A52B0", VA = "0x103A64B0")] get
      {
        return new ESkillTarget();
      }
    }

    [Token(Token = "0x1700103F")]
    public ESelectType EffShape
    {
      [Token(Token = "0x60078BD"), Address(RVA = "0x3A64A0", Offset = "0x3A52A0", VA = "0x103A64A0")] get
      {
        return new ESelectType();
      }
    }

    [Token(Token = "0x17001040")]
    public OInt EffScope
    {
      [Token(Token = "0x60078BE"), Address(RVA = "0x3A6480", Offset = "0x3A5280", VA = "0x103A6480")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001041")]
    public OInt EffHeight
    {
      [Token(Token = "0x60078BF"), Address(RVA = "0x3A6460", Offset = "0x3A5260", VA = "0x103A6460")] get
      {
        return new OInt();
      }
    }

    [Token(Token = "0x17001042")]
    public bool IsAreaEff
    {
      [Token(Token = "0x60078C0"), Address(RVA = "0x3A6560", Offset = "0x3A5360", VA = "0x103A6560")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001043")]
    public List<eMovType> IgnoreMovTypeList
    {
      [Token(Token = "0x60078C1"), Address(RVA = "0x3A64C0", Offset = "0x3A52C0", VA = "0x103A64C0")] get
      {
        return (List<eMovType>) null;
      }
    }

    [Token(Token = "0x17001044")]
    public bool IsReinforcement
    {
      [Token(Token = "0x60078C2"), Address(RVA = "0x3A65E0", Offset = "0x3A53E0", VA = "0x103A65E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60078C3")]
    [Address(RVA = "0x3A6090", Offset = "0x3A4E90", VA = "0x103A6090")]
    public void Deserialize(JSON_TrickParam json)
    {
    }

    [Token(Token = "0x60078C4")]
    [Address(RVA = "0x3A63A0", Offset = "0x3A51A0", VA = "0x103A63A0")]
    public TrickParam()
    {
    }

    [Token(Token = "0x2001D85")]
    private enum eFlag
    {
      [Token(Token = "0x40074D6")] IS_NO_OVER_WRITE,
      [Token(Token = "0x40074D7")] IS_REINFORCEMENT,
      [Token(Token = "0x40074D8")] MAX,
    }
  }
}
