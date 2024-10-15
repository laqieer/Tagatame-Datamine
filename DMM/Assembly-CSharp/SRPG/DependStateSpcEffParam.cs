// Decompiled with JetBrains decompiler
// Type: SRPG.DependStateSpcEffParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DF0")]
  public class DependStateSpcEffParam
  {
    [Token(Token = "0x40078BF")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40078C0")]
    [FieldOffset(Offset = "0xC")]
    private DependStateSpcEffParam.Flags mFlags;
    [Token(Token = "0x40078C1")]
    [FieldOffset(Offset = "0x10")]
    private List<DependStateSpcEffParam.BuffInfo> mBuffList;
    [Token(Token = "0x40078C2")]
    [FieldOffset(Offset = "0x14")]
    private List<EUnitCondition> mCondList;
    [Token(Token = "0x40078C3")]
    [FieldOffset(Offset = "0x18")]
    private int mInvSaRate;

    [Token(Token = "0x1700109D")]
    private bool mIsAnd
    {
      [Token(Token = "0x6007A6F"), Address(RVA = "0x3BEC60", Offset = "0x3BDA60", VA = "0x103BEC60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700109E")]
    private bool mIsInvTargetBuff
    {
      [Token(Token = "0x6007A70"), Address(RVA = "0x3BEC90", Offset = "0x3BDA90", VA = "0x103BEC90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700109F")]
    private bool mIsInvTargetCond
    {
      [Token(Token = "0x6007A71"), Address(RVA = "0x3BECA0", Offset = "0x3BDAA0", VA = "0x103BECA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010A0")]
    private bool mIsInvSelfBuff
    {
      [Token(Token = "0x6007A72"), Address(RVA = "0x3BEC70", Offset = "0x3BDA70", VA = "0x103BEC70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010A1")]
    private bool mIsInvSelfCond
    {
      [Token(Token = "0x6007A73"), Address(RVA = "0x3BEC80", Offset = "0x3BDA80", VA = "0x103BEC80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170010A2")]
    public string Iname
    {
      [Token(Token = "0x6007A74"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170010A3")]
    public int InvSaRate
    {
      [Token(Token = "0x6007A75"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007A76")]
    [Address(RVA = "0x3BE220", Offset = "0x3BD020", VA = "0x103BE220")]
    public void Deserialize(JSON_DependStateSpcEffParam json)
    {
    }

    [Token(Token = "0x6007A77")]
    [Address(RVA = "0x3BE840", Offset = "0x3BD640", VA = "0x103BE840")]
    private bool IsExistBuff(BuffAttachment ba, DependStateSpcEffParam.BuffInfo bi) => new bool();

    [Token(Token = "0x6007A78")]
    [Address(RVA = "0x3BE930", Offset = "0x3BD730", VA = "0x103BE930")]
    public bool IsSatisfyCondition(Unit target) => new bool();

    [Token(Token = "0x6007A79")]
    [Address(RVA = "0x3BE680", Offset = "0x3BD480", VA = "0x103BE680")]
    public bool IsApplyBuff(Unit target, SkillEffectTargets buff_target) => new bool();

    [Token(Token = "0x6007A7A")]
    [Address(RVA = "0x3BE6C0", Offset = "0x3BD4C0", VA = "0x103BE6C0")]
    public bool IsApplyBuff(List<Unit> target_list, SkillEffectTargets buff_target) => new bool();

    [Token(Token = "0x6007A7B")]
    [Address(RVA = "0x3BE760", Offset = "0x3BD560", VA = "0x103BE760")]
    public bool IsApplyCond(Unit target, SkillEffectTargets cond_target) => new bool();

    [Token(Token = "0x6007A7C")]
    [Address(RVA = "0x3BE7A0", Offset = "0x3BD5A0", VA = "0x103BE7A0")]
    public bool IsApplyCond(List<Unit> target_list, SkillEffectTargets cond_target) => new bool();

    [Token(Token = "0x6007A7D")]
    [Address(RVA = "0x3BE540", Offset = "0x3BD340", VA = "0x103BE540")]
    public static void Deserialize(
      ref List<DependStateSpcEffParam> list,
      JSON_DependStateSpcEffParam[] json)
    {
    }

    [Token(Token = "0x6007A7E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DependStateSpcEffParam()
    {
    }

    [Token(Token = "0x2001DF1")]
    public enum Flags
    {
      [Token(Token = "0x40078C5")] IsAnd = 1,
      [Token(Token = "0x40078C6")] IsInvTargetBuff = 2,
      [Token(Token = "0x40078C7")] IsInvTargetCond = 4,
      [Token(Token = "0x40078C8")] IsInvSelfBuff = 8,
      [Token(Token = "0x40078C9")] IsInvSelfCond = 16, // 0x00000010
    }

    [Token(Token = "0x2001DF2")]
    public enum CondBuffTypes
    {
      [Token(Token = "0x40078CB")] All,
      [Token(Token = "0x40078CC")] Buff,
      [Token(Token = "0x40078CD")] Debuff,
    }

    [Token(Token = "0x2001DF3")]
    public class BuffInfo
    {
      [Token(Token = "0x40078CE")]
      [FieldOffset(Offset = "0x8")]
      public ParamTypes mParamType;
      [Token(Token = "0x40078CF")]
      [FieldOffset(Offset = "0xC")]
      public DependStateSpcEffParam.CondBuffTypes mCondBuffType;

      [Token(Token = "0x6007A7F")]
      [Address(RVA = "0x3BBF10", Offset = "0x3BAD10", VA = "0x103BBF10")]
      public BuffInfo(ParamTypes pt, DependStateSpcEffParam.CondBuffTypes cbt)
      {
      }
    }
  }
}
