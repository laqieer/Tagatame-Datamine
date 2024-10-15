// Decompiled with JetBrains decompiler
// Type: SRPG.Models.SkillModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033C0")]
  public class SkillModel
  {
    [Token(Token = "0x400F509")]
    [FieldOffset(Offset = "0x8")]
    private SkillData skillData;
    [Token(Token = "0x400F50A")]
    [FieldOffset(Offset = "0xC")]
    private SkillParam skillParam;

    [Token(Token = "0x170020C1")]
    public SkillData GetSkillData
    {
      [Token(Token = "0x600E767"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (SkillData) null;
      }
    }

    [Token(Token = "0x170020C2")]
    public SkillParam GetSkillParam
    {
      [Token(Token = "0x600E768"), Address(RVA = "0xACD300", Offset = "0xACC100", VA = "0x10ACD300")] get
      {
        return (SkillParam) null;
      }
    }

    [Token(Token = "0x170020C3")]
    public string Name
    {
      [Token(Token = "0x600E769"), Address(RVA = "0xACD350", Offset = "0xACC150", VA = "0x10ACD350")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020C4")]
    public string Expr
    {
      [Token(Token = "0x600E76A"), Address(RVA = "0xACD2D0", Offset = "0xACC0D0", VA = "0x10ACD2D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020C5")]
    public int UseCount
    {
      [Token(Token = "0x600E76B"), Address(RVA = "0xACD480", Offset = "0xACC280", VA = "0x10ACD480")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020C6")]
    public int RangeMin
    {
      [Token(Token = "0x600E76C"), Address(RVA = "0xACD3C0", Offset = "0xACC1C0", VA = "0x10ACD3C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020C7")]
    public int RangeMax
    {
      [Token(Token = "0x600E76D"), Address(RVA = "0xACD380", Offset = "0xACC180", VA = "0x10ACD380")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020C8")]
    public int Scope
    {
      [Token(Token = "0x600E76E"), Address(RVA = "0xACD400", Offset = "0xACC200", VA = "0x10ACD400")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020C9")]
    public int EffectHight
    {
      [Token(Token = "0x600E76F"), Address(RVA = "0xACD250", Offset = "0xACC050", VA = "0x10ACD250")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020CA")]
    public EElement Element
    {
      [Token(Token = "0x600E770"), Address(RVA = "0xACD290", Offset = "0xACC090", VA = "0x10ACD290")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x170020CB")]
    public AttackTypes AtkType
    {
      [Token(Token = "0x600E771"), Address(RVA = "0xACD1C0", Offset = "0xACBFC0", VA = "0x10ACD1C0")] get
      {
        return new AttackTypes();
      }
    }

    [Token(Token = "0x170020CC")]
    public AttackDetailTypes AtkDetail
    {
      [Token(Token = "0x600E772"), Address(RVA = "0xACD180", Offset = "0xACBF80", VA = "0x10ACD180")] get
      {
        return new AttackDetailTypes();
      }
    }

    [Token(Token = "0x170020CD")]
    public bool IsCastSkill
    {
      [Token(Token = "0x600E773"), Address(RVA = "0xACD320", Offset = "0xACC120", VA = "0x10ACD320")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020CE")]
    public int CastSpeed
    {
      [Token(Token = "0x600E774"), Address(RVA = "0xACD200", Offset = "0xACC000", VA = "0x10ACD200")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020CF")]
    public int UseCost
    {
      [Token(Token = "0x600E775"), Address(RVA = "0xACD440", Offset = "0xACC240", VA = "0x10ACD440")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E776")]
    [Address(RVA = "0xACD140", Offset = "0xACBF40", VA = "0x10ACD140")]
    public void Initialize(SkillData _skilldata = null)
    {
    }

    [Token(Token = "0x600E777")]
    [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
    public void Initialize(SkillParam _skillParam)
    {
    }

    [Token(Token = "0x600E778")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillModel()
    {
    }
  }
}
