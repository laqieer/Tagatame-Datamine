// Decompiled with JetBrains decompiler
// Type: SRPG.InspSkillParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BA4")]
  [MessagePackObject(true)]
  public class InspSkillParam
  {
    [Token(Token = "0x4006966")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x4006967")]
    [FieldOffset(Offset = "0xC")]
    private string ability;
    [Token(Token = "0x4006968")]
    [FieldOffset(Offset = "0x10")]
    private List<InspSkillTriggerParam> triggers;
    [Token(Token = "0x4006969")]
    [FieldOffset(Offset = "0x14")]
    private int gen_id;
    [Token(Token = "0x400696A")]
    [FieldOffset(Offset = "0x18")]
    private int ctr_min;
    [Token(Token = "0x400696B")]
    [FieldOffset(Offset = "0x1C")]
    private int ctr_max;
    [Token(Token = "0x400696C")]
    [FieldOffset(Offset = "0x20")]
    private List<InspSkillParam> derivation;
    [Token(Token = "0x400696D")]
    [FieldOffset(Offset = "0x24")]
    private bool enable_passive;
    [Token(Token = "0x400696E")]
    [FieldOffset(Offset = "0x28")]
    private InspSkillParam parent;
    [Token(Token = "0x400696F")]
    [FieldOffset(Offset = "0x2C")]
    private AbilityParam mAbilityParam;
    [Token(Token = "0x4006970")]
    [FieldOffset(Offset = "0x30")]
    private SkillParam mSkillParam;

    [Token(Token = "0x17000DD9")]
    public AbilityParam Ability
    {
      [Token(Token = "0x6007224"), Address(RVA = "0x376FA0", Offset = "0x375DA0", VA = "0x10376FA0")] get
      {
        return (AbilityParam) null;
      }
    }

    [Token(Token = "0x17000DDA")]
    public SkillParam Skill
    {
      [Token(Token = "0x6007225"), Address(RVA = "0x377140", Offset = "0x375F40", VA = "0x10377140")] get
      {
        return (SkillParam) null;
      }
    }

    [Token(Token = "0x17000DDB")]
    public string Iname
    {
      [Token(Token = "0x6007226"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DDC")]
    public string SkillID
    {
      [Token(Token = "0x6007227"), Address(RVA = "0x377080", Offset = "0x375E80", VA = "0x10377080")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DDD")]
    public string AbilityID
    {
      [Token(Token = "0x6007228"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DDE")]
    public List<InspSkillTriggerParam> Triggers
    {
      [Token(Token = "0x6007229"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<InspSkillTriggerParam>) null;
      }
    }

    [Token(Token = "0x17000DDF")]
    public int CtrMin
    {
      [Token(Token = "0x600722A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DE0")]
    public int CtrMax
    {
      [Token(Token = "0x600722B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DE1")]
    public int LvCap
    {
      [Token(Token = "0x600722C"), Address(RVA = "0x377040", Offset = "0x375E40", VA = "0x10377040")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DE2")]
    public int GenId
    {
      [Token(Token = "0x600722D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000DE3")]
    public List<InspSkillParam> Derivation
    {
      [Token(Token = "0x600722E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<InspSkillParam>) null;
      }
    }

    [Token(Token = "0x17000DE4")]
    public bool EnablePassive
    {
      [Token(Token = "0x600722F"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000DE5")]
    public InspSkillParam Parent
    {
      [Token(Token = "0x6007230"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (InspSkillParam) null;
      }
    }

    [Token(Token = "0x17000DE6")]
    public bool IsBase
    {
      [Token(Token = "0x6007231"), Address(RVA = "0x377030", Offset = "0x375E30", VA = "0x10377030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007232")]
    [Address(RVA = "0x376570", Offset = "0x375370", VA = "0x10376570")]
    public static bool Deserialize(
      JSON_InspSkillParam[] insp_skill_jsons,
      JSON_InspSkillTriggerParam[] insp_skill_trigger_jsons,
      ref Dictionary<string, InspSkillParam> insp_skill_dic)
    {
      return new bool();
    }

    [Token(Token = "0x6007233")]
    [Address(RVA = "0x376A90", Offset = "0x375890", VA = "0x10376A90")]
    private bool Deserialize(
      JSON_InspSkillParam json,
      Dictionary<string, InspSkillTriggerParam> insp_skill_trigger_dic)
    {
      return new bool();
    }

    [Token(Token = "0x6007234")]
    [Address(RVA = "0x376C40", Offset = "0x375A40", VA = "0x10376C40")]
    public int GetCheckNum() => new int();

    [Token(Token = "0x6007235")]
    [Address(RVA = "0x376290", Offset = "0x375090", VA = "0x10376290")]
    public static bool Check(
      UnitData unit,
      List<UnitData> targets,
      ArtifactData artifact,
      int slot_no,
      SkillData use)
    {
      return new bool();
    }

    [Token(Token = "0x6007236")]
    [Address(RVA = "0x376EB0", Offset = "0x375CB0", VA = "0x10376EB0")]
    public static bool IsCanLevelUp(UnitData unit, ArtifactData artifact, SkillData skill)
    {
      return new bool();
    }

    [Token(Token = "0x6007237")]
    [Address(RVA = "0x376E50", Offset = "0x375C50", VA = "0x10376E50")]
    public InspSkillCostParam GetResetCost() => (InspSkillCostParam) null;

    [Token(Token = "0x6007238")]
    [Address(RVA = "0x376E30", Offset = "0x375C30", VA = "0x10376E30")]
    public int GetInspSkillGen() => new int();

    [Token(Token = "0x6007239")]
    [Address(RVA = "0x376D30", Offset = "0x375B30", VA = "0x10376D30")]
    public static int GetInspLvUpCostTotal(string iname, int current_lv, int up) => new int();

    [Token(Token = "0x600723A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public InspSkillParam()
    {
    }
  }
}
