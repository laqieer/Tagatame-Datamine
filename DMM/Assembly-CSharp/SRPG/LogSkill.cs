// Decompiled with JetBrains decompiler
// Type: SRPG.LogSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000BDF")]
  public class LogSkill : BattleLog
  {
    [Token(Token = "0x4001E1C")]
    [FieldOffset(Offset = "0x8")]
    public Unit self;
    [Token(Token = "0x4001E1D")]
    [FieldOffset(Offset = "0xC")]
    public int hp_cost;
    [Token(Token = "0x4001E1E")]
    [FieldOffset(Offset = "0x10")]
    public int rad;
    [Token(Token = "0x4001E1F")]
    [FieldOffset(Offset = "0x14")]
    public int height;
    [Token(Token = "0x4001E20")]
    [FieldOffset(Offset = "0x18")]
    public long buff;
    [Token(Token = "0x4001E21")]
    [FieldOffset(Offset = "0x20")]
    public long debuff;
    [Token(Token = "0x4001E22")]
    [FieldOffset(Offset = "0x28")]
    public SkillData skill;
    [Token(Token = "0x4001E23")]
    [FieldOffset(Offset = "0x2C")]
    public IntVector2 pos;
    [Token(Token = "0x4001E24")]
    [FieldOffset(Offset = "0x34")]
    public IntVector2 camera_pos;
    [Token(Token = "0x4001E25")]
    [FieldOffset(Offset = "0x3C")]
    public bool IsSetCameraPos;
    [Token(Token = "0x4001E26")]
    [FieldOffset(Offset = "0x40")]
    public Grid landing;
    [Token(Token = "0x4001E27")]
    [FieldOffset(Offset = "0x44")]
    public Grid TeleportGrid;
    [Token(Token = "0x4001E28")]
    [FieldOffset(Offset = "0x48")]
    public LogSkill.Target self_effect;
    [Token(Token = "0x4001E29")]
    [FieldOffset(Offset = "0x4C")]
    public List<LogSkill.Target> targets;
    [Token(Token = "0x4001E2A")]
    [FieldOffset(Offset = "0x50")]
    public SkillData additional_skill;
    [Token(Token = "0x4001E2B")]
    [FieldOffset(Offset = "0x54")]
    public List<LogSkill.Target> additional_targets;
    [Token(Token = "0x4001E2C")]
    [FieldOffset(Offset = "0x58")]
    public LogSkill.Reflection reflect;
    [Token(Token = "0x4001E2D")]
    [FieldOffset(Offset = "0x5C")]
    public Unit CauseOfReaction;
    [Token(Token = "0x4001E2E")]
    [FieldOffset(Offset = "0x60")]
    public IntVector2 CauseOfReactionPos;
    [Token(Token = "0x4001E2F")]
    [FieldOffset(Offset = "0x68")]
    public bool is_append;
    [Token(Token = "0x4001E30")]
    [FieldOffset(Offset = "0x69")]
    public bool is_gimmick;
    [Token(Token = "0x4001E31")]
    [FieldOffset(Offset = "0x6C")]
    public List<Unit> guard_units;
    [Token(Token = "0x4001E32")]
    [FieldOffset(Offset = "0x70")]
    public List<Unit> protect_units;
    [Token(Token = "0x4001E33")]
    [FieldOffset(Offset = "0x74")]
    public List<Unit> protect_targets;

    [Token(Token = "0x6002FAC")]
    [Address(RVA = "0xFE6160", Offset = "0xFE4F60", VA = "0x10FE6160")]
    public LogSkill.Target FindTarget(Unit target) => (LogSkill.Target) null;

    [Token(Token = "0x6002FAD")]
    [Address(RVA = "0xFE70F0", Offset = "0xFE5EF0", VA = "0x10FE70F0")]
    public LogSkill.Target SetSkillTarget(Unit unit, Unit other) => (LogSkill.Target) null;

    [Token(Token = "0x6002FAE")]
    [Address(RVA = "0xFE5F60", Offset = "0xFE4D60", VA = "0x10FE5F60")]
    public void CheckAliveTarget()
    {
    }

    [Token(Token = "0x6002FAF")]
    [Address(RVA = "0xFE6E70", Offset = "0xFE5C70", VA = "0x10FE6E70")]
    public void Hit(
      Unit unit,
      Unit other,
      int hp_damage,
      int mp_damage,
      int ch_damage,
      int ca_damage,
      int hp_heal,
      int mp_heal,
      int ch_heal,
      int ca_heal,
      int dropgems,
      bool is_critical,
      bool is_avoid,
      bool is_combination,
      bool is_guts,
      int absorbed = 0,
      bool is_pf_avoid = false,
      int critical_rate = 0,
      int avoid_rate = 0)
    {
    }

    [Token(Token = "0x6002FB0")]
    [Address(RVA = "0xFE71A0", Offset = "0xFE5FA0", VA = "0x10FE71A0")]
    public void ToSelfSkillEffect(
      int hp_damage,
      int mp_damage,
      int ch_damage,
      int ca_damage,
      int hp_heal,
      int mp_heal,
      int ch_heal,
      int ca_heal,
      int dropgems,
      bool is_critical,
      bool is_avoid,
      bool is_combination,
      bool is_guts)
    {
    }

    [Token(Token = "0x6002FB1")]
    [Address(RVA = "0xFE70D0", Offset = "0xFE5ED0", VA = "0x10FE70D0")]
    public void SetDefendEffect(Unit defender)
    {
    }

    [Token(Token = "0x6002FB2")]
    [Address(RVA = "0xFE6200", Offset = "0xFE5000", VA = "0x10FE6200")]
    public int GetGainJewel() => new int();

    [Token(Token = "0x6002FB3")]
    [Address(RVA = "0xFE7050", Offset = "0xFE5E50", VA = "0x10FE7050")]
    public bool IsRenkei() => new bool();

    [Token(Token = "0x6002FB4")]
    [Address(RVA = "0xFE6D00", Offset = "0xFE5B00", VA = "0x10FE6D00")]
    public int GetTruthTotalHpHeal() => new int();

    [Token(Token = "0x6002FB5")]
    [Address(RVA = "0xFE6BE0", Offset = "0xFE59E0", VA = "0x10FE6BE0")]
    public int GetTruthTotalHpHealCount() => new int();

    [Token(Token = "0x6002FB6")]
    [Address(RVA = "0xFE6AC0", Offset = "0xFE58C0", VA = "0x10FE6AC0")]
    public int GetTruthTotalHpDamage() => new int();

    [Token(Token = "0x6002FB7")]
    [Address(RVA = "0xFE65B0", Offset = "0xFE53B0", VA = "0x10FE65B0")]
    public int GetTotalDeathCount() => new int();

    [Token(Token = "0x6002FB8")]
    [Address(RVA = "0xFE6400", Offset = "0xFE5200", VA = "0x10FE6400")]
    public int GetTotalCureConditionCount() => new int();

    [Token(Token = "0x6002FB9")]
    [Address(RVA = "0xFE67E0", Offset = "0xFE55E0", VA = "0x10FE67E0")]
    public int GetTotalFailConditionCount() => new int();

    [Token(Token = "0x6002FBA")]
    [Address(RVA = "0xFE6680", Offset = "0xFE5480", VA = "0x10FE6680")]
    public int GetTotalDisableConditionCount() => new int();

    [Token(Token = "0x6002FBB")]
    [Address(RVA = "0xFE62D0", Offset = "0xFE50D0", VA = "0x10FE62D0")]
    public void GetTotalBuffEffect(out int buff_count, out int buff_value)
    {
    }

    [Token(Token = "0x6002FBC")]
    [Address(RVA = "0xFE7260", Offset = "0xFE6060", VA = "0x10FE7260")]
    public LogSkill()
    {
    }

    [Token(Token = "0x2000BE0")]
    [Flags]
    public enum EHitTypes
    {
      [Token(Token = "0x4001E35")] BackAttack = 1,
      [Token(Token = "0x4001E36")] SideAttack = 2,
      [Token(Token = "0x4001E37")] ItemSteal = 4,
      [Token(Token = "0x4001E38")] GoldSteal = 8,
      [Token(Token = "0x4001E39")] GemsSteal = 16, // 0x00000010
      [Token(Token = "0x4001E3A")] Guts = 32, // 0x00000020
      [Token(Token = "0x4001E3B")] Combination = 64, // 0x00000040
      [Token(Token = "0x4001E3C")] Defend = 128, // 0x00000080
      [Token(Token = "0x4001E3D")] CastBreak = 256, // 0x00000100
      [Token(Token = "0x4001E3E")] PerfectAvoid = 512, // 0x00000200
    }

    [Token(Token = "0x2000BE1")]
    public class Target
    {
      [Token(Token = "0x4001E3F")]
      [FieldOffset(Offset = "0x8")]
      public Unit target;
      [Token(Token = "0x4001E40")]
      [FieldOffset(Offset = "0xC")]
      public List<BattleCore.HitData> hits;
      [Token(Token = "0x4001E41")]
      [FieldOffset(Offset = "0x10")]
      public LogSkill.EHitTypes hitType;
      [Token(Token = "0x4001E42")]
      [FieldOffset(Offset = "0x14")]
      public int gems;
      [Token(Token = "0x4001E43")]
      [FieldOffset(Offset = "0x18")]
      public SkillData defSkill;
      [Token(Token = "0x4001E44")]
      [FieldOffset(Offset = "0x1C")]
      public int defSkillUseCount;
      [Token(Token = "0x4001E45")]
      [FieldOffset(Offset = "0x20")]
      public int shieldDamage;
      [Token(Token = "0x4001E46")]
      [FieldOffset(Offset = "0x24")]
      public bool isProcShield;
      [Token(Token = "0x4001E47")]
      [FieldOffset(Offset = "0x28")]
      public BuffBit buff;
      [Token(Token = "0x4001E48")]
      [FieldOffset(Offset = "0x2C")]
      public BuffBit debuff;
      [Token(Token = "0x4001E49")]
      [FieldOffset(Offset = "0x30")]
      public EUnitCondition failCondition;
      [Token(Token = "0x4001E4A")]
      [FieldOffset(Offset = "0x38")]
      public EUnitCondition cureCondition;
      [Token(Token = "0x4001E4B")]
      [FieldOffset(Offset = "0x40")]
      public Unit guard;
      [Token(Token = "0x4001E4C")]
      [FieldOffset(Offset = "0x44")]
      public bool is_force_reaction;
      [Token(Token = "0x4001E4D")]
      [FieldOffset(Offset = "0x48")]
      public int element_effect_rate;
      [Token(Token = "0x4001E4E")]
      [FieldOffset(Offset = "0x4C")]
      public int element_effect_resist;
      [Token(Token = "0x4001E4F")]
      [FieldOffset(Offset = "0x50")]
      public Grid KnockBackGrid;
      [Token(Token = "0x4001E50")]
      [FieldOffset(Offset = "0x54")]
      public int ChangeValueCT;
      [Token(Token = "0x4001E51")]
      [FieldOffset(Offset = "0x58")]
      public bool IsOldDying;
      [Token(Token = "0x4001E52")]
      [FieldOffset(Offset = "0x5C")]
      public Grid BattleMapResetGrid;
      [Token(Token = "0x4001E53")]
      [FieldOffset(Offset = "0x60")]
      public List<LogSkill.Target.CondHit> CondHitLists;

      [Token(Token = "0x6002FBD")]
      [Address(RVA = "0xFEB200", Offset = "0xFEA000", VA = "0x10FEB200")]
      public int GetTotalHpDamage() => new int();

      [Token(Token = "0x6002FBE")]
      [Address(RVA = "0xFEB280", Offset = "0xFEA080", VA = "0x10FEB280")]
      public int GetTotalHpHeal() => new int();

      [Token(Token = "0x6002FBF")]
      [Address(RVA = "0xFEB300", Offset = "0xFEA100", VA = "0x10FEB300")]
      public int GetTotalMpDamage() => new int();

      [Token(Token = "0x6002FC0")]
      [Address(RVA = "0xFEB380", Offset = "0xFEA180", VA = "0x10FEB380")]
      public int GetTotalMpHeal() => new int();

      [Token(Token = "0x6002FC1")]
      [Address(RVA = "0xFEB170", Offset = "0xFE9F70", VA = "0x10FEB170")]
      public int GetTotalCriticalRate() => new int();

      [Token(Token = "0x6002FC2")]
      [Address(RVA = "0xFEB0E0", Offset = "0xFE9EE0", VA = "0x10FEB0E0")]
      public int GetTotalAvoidRate() => new int();

      [Token(Token = "0x6002FC3")]
      [Address(RVA = "0xFEB5F0", Offset = "0xFEA3F0", VA = "0x10FEB5F0")]
      public bool IsCritical() => new bool();

      [Token(Token = "0x6002FC4")]
      [Address(RVA = "0xFEB490", Offset = "0xFEA290", VA = "0x10FEB490")]
      public bool IsAvoid() => new bool();

      [Token(Token = "0x6002FC5")]
      [Address(RVA = "0xFEB5B0", Offset = "0xFEA3B0", VA = "0x10FEB5B0")]
      public bool IsCombo() => new bool();

      [Token(Token = "0x6002FC6")]
      [Address(RVA = "0xFEB400", Offset = "0xFEA200", VA = "0x10FEB400")]
      public bool IsAvoidJustOne() => new bool();

      [Token(Token = "0x6002FC7")]
      [Address(RVA = "0xFEB720", Offset = "0xFEA520", VA = "0x10FEB720")]
      public void SetDefend(bool flag)
      {
      }

      [Token(Token = "0x6002FC8")]
      [Address(RVA = "0xFEB6A0", Offset = "0xFEA4A0", VA = "0x10FEB6A0")]
      public bool IsDefend() => new bool();

      [Token(Token = "0x6002FC9")]
      [Address(RVA = "0xFEB750", Offset = "0xFEA550", VA = "0x10FEB750")]
      public void SetPerfectAvoid(bool flag)
      {
      }

      [Token(Token = "0x6002FCA")]
      [Address(RVA = "0xFEB6F0", Offset = "0xFEA4F0", VA = "0x10FEB6F0")]
      public bool IsPerfectAvoid() => new bool();

      [Token(Token = "0x6002FCB")]
      [Address(RVA = "0xAAFB30", Offset = "0xAAE930", VA = "0x10AAFB30")]
      public void SetForceReaction(bool flag)
      {
      }

      [Token(Token = "0x6002FCC")]
      [Address(RVA = "0xFEB520", Offset = "0xFEA320", VA = "0x10FEB520")]
      public bool IsBuffEffect() => new bool();

      [Token(Token = "0x6002FCD")]
      [Address(RVA = "0xFEB6C0", Offset = "0xFEA4C0", VA = "0x10FEB6C0")]
      public bool IsFailCondition() => new bool();

      [Token(Token = "0x6002FCE")]
      [Address(RVA = "0xFEB680", Offset = "0xFEA480", VA = "0x10FEB680")]
      public bool IsCureCondition() => new bool();

      [Token(Token = "0x6002FCF")]
      [Address(RVA = "0xFEB710", Offset = "0xFEA510", VA = "0x10FEB710")]
      public bool IsWeakEffectElement() => new bool();

      [Token(Token = "0x6002FD0")]
      [Address(RVA = "0xAC2160", Offset = "0xAC0F60", VA = "0x10AC2160")]
      public bool IsResistEffectElement() => new bool();

      [Token(Token = "0x6002FD1")]
      [Address(RVA = "0xFEB6E0", Offset = "0xFEA4E0", VA = "0x10FEB6E0")]
      public bool IsNormalEffectElement() => new bool();

      [Token(Token = "0x6002FD2")]
      [Address(RVA = "0xFEB780", Offset = "0xFEA580", VA = "0x10FEB780")]
      public Target()
      {
      }

      [Token(Token = "0x2000BE2")]
      public class CondHit
      {
        [Token(Token = "0x4001E54")]
        [FieldOffset(Offset = "0x8")]
        public EUnitCondition Cond;
        [Token(Token = "0x4001E55")]
        [FieldOffset(Offset = "0x10")]
        public int Per;

        [Token(Token = "0x6002FD3")]
        [Address(RVA = "0xA7DD30", Offset = "0xA7CB30", VA = "0x10A7DD30")]
        public CondHit(EUnitCondition cond, int per = 0)
        {
        }
      }
    }

    [Token(Token = "0x2000BE3")]
    public class Reflection
    {
      [Token(Token = "0x4001E56")]
      [FieldOffset(Offset = "0x8")]
      public int damage;

      [Token(Token = "0x6002FD4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reflection()
      {
      }
    }
  }
}
