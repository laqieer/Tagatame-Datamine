// Decompiled with JetBrains decompiler
// Type: SRPG.CondEffectParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DEB")]
  [MessagePackObject(true)]
  public class CondEffectParam
  {
    [Token(Token = "0x400786D")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400786E")]
    [FieldOffset(Offset = "0xC")]
    public string job;
    [Token(Token = "0x400786F")]
    [FieldOffset(Offset = "0x10")]
    public string buki;
    [Token(Token = "0x4007870")]
    [FieldOffset(Offset = "0x14")]
    public string birth;
    [Token(Token = "0x4007871")]
    [FieldOffset(Offset = "0x18")]
    public ESex sex;
    [Token(Token = "0x4007872")]
    [FieldOffset(Offset = "0x1C")]
    public EElement elem;
    [Token(Token = "0x4007873")]
    [FieldOffset(Offset = "0x1D")]
    public ConditionEffectTypes type;
    [Token(Token = "0x4007874")]
    [FieldOffset(Offset = "0x1E")]
    public ESkillCondition cond;
    [Token(Token = "0x4007875")]
    [FieldOffset(Offset = "0x20")]
    public OInt value_ini;
    [Token(Token = "0x4007876")]
    [FieldOffset(Offset = "0x34")]
    public OInt value_max;
    [Token(Token = "0x4007877")]
    [FieldOffset(Offset = "0x48")]
    public OInt rate_ini;
    [Token(Token = "0x4007878")]
    [FieldOffset(Offset = "0x5C")]
    public OInt rate_max;
    [Token(Token = "0x4007879")]
    [FieldOffset(Offset = "0x70")]
    public OInt turn_ini;
    [Token(Token = "0x400787A")]
    [FieldOffset(Offset = "0x84")]
    public OInt turn_max;
    [Token(Token = "0x400787B")]
    [FieldOffset(Offset = "0x98")]
    public EffectCheckTargets chk_target;
    [Token(Token = "0x400787C")]
    [FieldOffset(Offset = "0x99")]
    public EffectCheckTimings chk_timing;
    [Token(Token = "0x400787D")]
    [FieldOffset(Offset = "0x9C")]
    public EUnitCondition[] conditions;
    [Token(Token = "0x400787E")]
    [FieldOffset(Offset = "0xA0")]
    public string[] BuffIds;
    [Token(Token = "0x400787F")]
    [FieldOffset(Offset = "0xA4")]
    public string[] tags;
    [Token(Token = "0x4007880")]
    [FieldOffset(Offset = "0xA8")]
    public string un_group;
    [Token(Token = "0x4007881")]
    [FieldOffset(Offset = "0xAC")]
    public string[] custom_targets;
    [Token(Token = "0x4007882")]
    [FieldOffset(Offset = "0xB0")]
    public OInt v_poison_rate;
    [Token(Token = "0x4007883")]
    [FieldOffset(Offset = "0xC4")]
    public OInt v_poison_fix;
    [Token(Token = "0x4007884")]
    [FieldOffset(Offset = "0xD8")]
    public OInt v_paralyse_rate;
    [Token(Token = "0x4007885")]
    [FieldOffset(Offset = "0xEC")]
    public OInt v_blink_hit;
    [Token(Token = "0x4007886")]
    [FieldOffset(Offset = "0x100")]
    public OInt v_blink_avo;
    [Token(Token = "0x4007887")]
    [FieldOffset(Offset = "0x114")]
    public OInt v_death_count;
    [Token(Token = "0x4007888")]
    [FieldOffset(Offset = "0x128")]
    public OInt v_berserk_atk;
    [Token(Token = "0x4007889")]
    [FieldOffset(Offset = "0x13C")]
    public OInt v_berserk_def;
    [Token(Token = "0x400788A")]
    [FieldOffset(Offset = "0x150")]
    public OInt v_fast;
    [Token(Token = "0x400788B")]
    [FieldOffset(Offset = "0x164")]
    public OInt v_slow;
    [Token(Token = "0x400788C")]
    [FieldOffset(Offset = "0x178")]
    public OInt v_donmov;
    [Token(Token = "0x400788D")]
    [FieldOffset(Offset = "0x18C")]
    public OInt v_auto_hp_heal;
    [Token(Token = "0x400788E")]
    [FieldOffset(Offset = "0x1A0")]
    public OInt v_auto_hp_heal_fix;
    [Token(Token = "0x400788F")]
    [FieldOffset(Offset = "0x1B4")]
    public OInt v_auto_mp_heal;
    [Token(Token = "0x4007890")]
    [FieldOffset(Offset = "0x1C8")]
    public OInt v_auto_mp_heal_fix;
    [Token(Token = "0x4007891")]
    [FieldOffset(Offset = "0x1DC")]
    public OInt curse;
    [Token(Token = "0x4007892")]
    [FieldOffset(Offset = "0x1F0")]
    private BitArray mFlags;

    [Token(Token = "0x1700109B")]
    public bool IsLinkBuffDupli
    {
      [Token(Token = "0x6007A65"), Address(RVA = "0x3BDB40", Offset = "0x3BC940", VA = "0x103BDB40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700109C")]
    public bool IsLinkBuffResist
    {
      [Token(Token = "0x6007A66"), Address(RVA = "0x3BDB70", Offset = "0x3BC970", VA = "0x103BDB70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007A67")]
    [Address(RVA = "0x3BD380", Offset = "0x3BC180", VA = "0x103BD380")]
    public bool Deserialize(JSON_CondEffectParam json) => new bool();

    [Token(Token = "0x6007A68")]
    [Address(RVA = "0x3BDA40", Offset = "0x3BC840", VA = "0x103BDA40")]
    public string GetLinkageBuffId(EUnitCondition cond) => (string) null;

    [Token(Token = "0x6007A69")]
    [Address(RVA = "0x3BDAB0", Offset = "0x3BC8B0", VA = "0x103BDAB0")]
    public static bool IsFailCondition(ConditionEffectTypes ce_type) => new bool();

    [Token(Token = "0x6007A6A")]
    [Address(RVA = "0x3BDAD0", Offset = "0x3BC8D0", VA = "0x103BDAD0")]
    public CondEffectParam()
    {
    }

    [Token(Token = "0x2001DEC")]
    private enum eFlags
    {
      [Token(Token = "0x4007894")] LINK_BUFF_DUPLI,
      [Token(Token = "0x4007895")] LINK_BUFF_RESIST,
      [Token(Token = "0x4007896")] MAX,
    }
  }
}
