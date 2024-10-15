// Decompiled with JetBrains decompiler
// Type: SRPG.BuffEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DDD")]
  [MessagePackObject(true)]
  public class BuffEffectParam
  {
    [Token(Token = "0x4007814")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007815")]
    [FieldOffset(Offset = "0xC")]
    public string job;
    [Token(Token = "0x4007816")]
    [FieldOffset(Offset = "0x10")]
    public string buki;
    [Token(Token = "0x4007817")]
    [FieldOffset(Offset = "0x14")]
    public string birth;
    [Token(Token = "0x4007818")]
    [FieldOffset(Offset = "0x18")]
    public ESex sex;
    [Token(Token = "0x4007819")]
    [FieldOffset(Offset = "0x1C")]
    public string un_group;
    [Token(Token = "0x400781A")]
    [FieldOffset(Offset = "0x20")]
    public int elem;
    [Token(Token = "0x400781B")]
    [FieldOffset(Offset = "0x24")]
    public ESkillCondition cond;
    [Token(Token = "0x400781C")]
    [FieldOffset(Offset = "0x28")]
    public OInt rate;
    [Token(Token = "0x400781D")]
    [FieldOffset(Offset = "0x3C")]
    public OInt turn;
    [Token(Token = "0x400781E")]
    [FieldOffset(Offset = "0x50")]
    public EffectCheckTargets chk_target;
    [Token(Token = "0x400781F")]
    [FieldOffset(Offset = "0x51")]
    public EffectCheckTimings chk_timing;
    [Token(Token = "0x4007820")]
    [FieldOffset(Offset = "0x54")]
    public OBool mIsUpBuff;
    [Token(Token = "0x4007821")]
    [FieldOffset(Offset = "0x60")]
    public EffectCheckTimings mUpTiming;
    [Token(Token = "0x4007822")]
    [FieldOffset(Offset = "0x64")]
    public EAppType mAppType;
    [Token(Token = "0x4007823")]
    [FieldOffset(Offset = "0x68")]
    public int mAppMct;
    [Token(Token = "0x4007824")]
    [FieldOffset(Offset = "0x6C")]
    public EEffRange mEffRange;
    [Token(Token = "0x4007825")]
    [FieldOffset(Offset = "0x70")]
    public BuffFlags mFlags;
    [Token(Token = "0x4007826")]
    [FieldOffset(Offset = "0x74")]
    public string[] custom_targets;
    [Token(Token = "0x4007827")]
    [FieldOffset(Offset = "0x78")]
    public string[] tags;
    [Token(Token = "0x4007828")]
    [FieldOffset(Offset = "0x7C")]
    public BuffEffectParam.Buff[] buffs;

    [Token(Token = "0x1700108E")]
    [IgnoreMember]
    public BuffEffectParam.Buff this[ParamTypes type]
    {
      [Token(Token = "0x6007A35"), Address(RVA = "0x3BBE50", Offset = "0x3BAC50", VA = "0x103BBE50")] get
      {
        return (BuffEffectParam.Buff) null;
      }
    }

    [Token(Token = "0x6007A36")]
    [Address(RVA = "0x3BA8A0", Offset = "0x3B96A0", VA = "0x103BA8A0")]
    public bool Deserialize(JSON_BuffEffectParam json) => new bool();

    [Token(Token = "0x1700108F")]
    public bool IsUpReplenish
    {
      [Token(Token = "0x6007A37"), Address(RVA = "0x3BBE40", Offset = "0x3BAC40", VA = "0x103BBE40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001090")]
    public bool IsUpReplenishUseSkillCtr
    {
      [Token(Token = "0x6007A38"), Address(RVA = "0x3BBE30", Offset = "0x3BAC30", VA = "0x103BBE30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001091")]
    public bool IsNoDisabled
    {
      [Token(Token = "0x6007A39"), Address(RVA = "0x3BBE20", Offset = "0x3BAC20", VA = "0x103BBE20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001092")]
    public bool IsDependIgnore
    {
      [Token(Token = "0x6007A3A"), Address(RVA = "0x3BBE00", Offset = "0x3BAC00", VA = "0x103BBE00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007A3B")]
    [Address(RVA = "0x3BBD80", Offset = "0x3BAB80", VA = "0x103BBD80")]
    public static bool IsNegativeValueIsBuff(ParamTypes param_type) => new bool();

    [Token(Token = "0x17001093")]
    public bool IsNoBuffTurn
    {
      [Token(Token = "0x6007A3C"), Address(RVA = "0x3BBE10", Offset = "0x3BAC10", VA = "0x103BBE10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007A3D")]
    [Address(RVA = "0x3B9FC0", Offset = "0x3B8DC0", VA = "0x103B9FC0")]
    public static bool CheckCustomTarget(
      string[] custom_targets,
      Unit target,
      ESkillCondition skillCond)
    {
      return new bool();
    }

    [Token(Token = "0x17001094")]
    public bool IsAvoidMissType
    {
      [Token(Token = "0x6007A3E"), Address(RVA = "0x3BBDE0", Offset = "0x3BABE0", VA = "0x103BBDE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001095")]
    public bool IsAvoidPerfectType
    {
      [Token(Token = "0x6007A3F"), Address(RVA = "0x3BBDF0", Offset = "0x3BABF0", VA = "0x103BBDF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001096")]
    public bool IsAvoidAllType
    {
      [Token(Token = "0x6007A40"), Address(RVA = "0x3BBDC0", Offset = "0x3BABC0", VA = "0x103BBDC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007A41")]
    [Address(RVA = "0x3B9EA0", Offset = "0x3B8CA0", VA = "0x103B9EA0")]
    public long CalcMaxHP(long hp, int rank, int rankCap) => new long();

    [Token(Token = "0x6007A42")]
    [Address(RVA = "0x3B9E80", Offset = "0x3B8C80", VA = "0x103B9E80")]
    public static void CalcExpensiveBuff(
      List<BuffEffectParam> _buff_list,
      EElement _element,
      BaseStatus _judge_status,
      ref BaseStatus _base_status,
      ref BaseStatus _scale_status)
    {
    }

    [Token(Token = "0x6007A43")]
    [Address(RVA = "0x3B98E0", Offset = "0x3B86E0", VA = "0x103B98E0")]
    public static void CalcBuff(
      List<BuffEffectParam> _buff_list,
      EElement _element,
      ref BaseStatus _base_status,
      ref BaseStatus _scale_status,
      BaseStatus _judge_status = null)
    {
    }

    [Token(Token = "0x6007A44")]
    [Address(RVA = "0x3B9280", Offset = "0x3B8080", VA = "0x103B9280")]
    public static void CalcBuffEffect(
      Unit owner,
      Unit target,
      SkillData skill,
      SkillEffectTargets skill_effect_target,
      BuffEffect effect,
      int turn,
      bool is_passive = true,
      int dupli = 0,
      bool is_predict = false)
    {
    }

    [Token(Token = "0x6007A45")]
    [Address(RVA = "0x3BA610", Offset = "0x3B9410", VA = "0x103BA610")]
    private static BuffAttachment CreateBuffAttachment(
      Unit user,
      Unit target,
      SkillData skill,
      SkillEffectTargets skilltarget,
      BuffEffect buff_effect,
      BuffTypes buffType,
      bool is_negative_value_is_buff,
      SkillParamCalcTypes calcType,
      BaseStatus status,
      ESkillCondition cond,
      int turn,
      EffectCheckTargets chktgt,
      EffectCheckTimings timing,
      bool is_passive,
      int dupli,
      bool is_predict)
    {
      return (BuffAttachment) null;
    }

    [Token(Token = "0x6007A46")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuffEffectParam()
    {
    }

    [Token(Token = "0x2001DDE")]
    [MessagePackObject(true)]
    public class Buff
    {
      [Token(Token = "0x4007829")]
      [FieldOffset(Offset = "0x8")]
      public ParamTypes type;
      [Token(Token = "0x400782A")]
      [FieldOffset(Offset = "0xC")]
      public int value_ini;
      [Token(Token = "0x400782B")]
      [FieldOffset(Offset = "0x10")]
      public int value_max;
      [Token(Token = "0x400782C")]
      [FieldOffset(Offset = "0x14")]
      public short value_one;
      [Token(Token = "0x400782D")]
      [FieldOffset(Offset = "0x18")]
      public string tokkou;
      [Token(Token = "0x400782E")]
      [FieldOffset(Offset = "0x1C")]
      public SkillParamCalcTypes calc;

      [Token(Token = "0x6007A47")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Buff()
      {
      }
    }
  }
}
