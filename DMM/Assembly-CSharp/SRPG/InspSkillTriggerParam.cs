// Decompiled with JetBrains decompiler
// Type: SRPG.InspSkillTriggerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BA8")]
  [MessagePackObject(true)]
  public class InspSkillTriggerParam
  {
    [Token(Token = "0x4006983")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x4006984")]
    [FieldOffset(Offset = "0xC")]
    private List<InspSkillTriggerParam.TriggerData> triggers;

    [Token(Token = "0x17000DE7")]
    public string Iname
    {
      [Token(Token = "0x600723D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DE8")]
    public List<InspSkillTriggerParam.TriggerData> Triggers
    {
      [Token(Token = "0x600723E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<InspSkillTriggerParam.TriggerData>) null;
      }
    }

    [Token(Token = "0x600723F")]
    [Address(RVA = "0x377710", Offset = "0x376510", VA = "0x10377710")]
    private bool Deserialize(JSON_InspSkillTriggerParam json) => new bool();

    [Token(Token = "0x6007240")]
    [Address(RVA = "0x377AC0", Offset = "0x3768C0", VA = "0x10377AC0")]
    public static bool Deserialize(
      JSON_InspSkillTriggerParam[] jsons,
      ref Dictionary<string, InspSkillTriggerParam> insp_skill_trigger_dic)
    {
      return new bool();
    }

    [Token(Token = "0x6007241")]
    [Address(RVA = "0x3775A0", Offset = "0x3763A0", VA = "0x103775A0")]
    public bool Check(UnitData unit, List<UnitData> targets, SkillData use) => new bool();

    [Token(Token = "0x6007242")]
    [Address(RVA = "0x3771E0", Offset = "0x375FE0", VA = "0x103771E0")]
    private bool CheckCondition(
      InspSkillTriggerParam.TriggerData trigger,
      UnitData unit,
      List<UnitData> targets,
      SkillData use)
    {
      return new bool();
    }

    [Token(Token = "0x6007243")]
    [Address(RVA = "0x377360", Offset = "0x376160", VA = "0x10377360")]
    private bool CheckTargets(InspSkillTriggerParam.TriggerData trigger, List<UnitData> targets)
    {
      return new bool();
    }

    [Token(Token = "0x6007244")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public InspSkillTriggerParam()
    {
    }

    [Token(Token = "0x2001BA9")]
    [MessagePackObject(true)]
    public class TriggerData
    {
      [Token(Token = "0x4006985")]
      [FieldOffset(Offset = "0x8")]
      public eInspSkillTriggerType type;
      [Token(Token = "0x4006986")]
      [FieldOffset(Offset = "0xC")]
      public string val;
      [Token(Token = "0x4006987")]
      [FieldOffset(Offset = "0x10")]
      public int val_int;
      [Token(Token = "0x4006988")]
      [FieldOffset(Offset = "0x14")]
      public EElement element;

      [Token(Token = "0x6007245")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TriggerData()
      {
      }
    }
  }
}
