// Decompiled with JetBrains decompiler
// Type: SRPG.InvalidSkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FCF")]
  [MessagePackObject(true)]
  [Serializable]
  public class InvalidSkillData
  {
    [Token(Token = "0x40037DC")]
    public const string SYS_USE_INVALIDSKILL_KEY = "SYS_USE_INVALIDSKILL";
    [Token(Token = "0x40037DD")]
    [FieldOffset(Offset = "0x8")]
    private List<InvalidSkill> mInvalidSkills;

    [Token(Token = "0x170005E1")]
    public List<InvalidSkill> InvalidSkills
    {
      [Token(Token = "0x60041B3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<InvalidSkill>) null;
      }
    }

    [Token(Token = "0x170005E2")]
    public bool InvalidSkillsIsNullOrEmpty
    {
      [Token(Token = "0x60041B4"), Address(RVA = "0x1197E20", Offset = "0x1196C20", VA = "0x11197E20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60041B5")]
    [Address(RVA = "0x11976F0", Offset = "0x11964F0", VA = "0x111976F0")]
    public bool IsInvalidSkill(Unit unit, SkillData skill, long job_iid, QuestTypes quest_type)
    {
      return new bool();
    }

    [Token(Token = "0x60041B6")]
    [Address(RVA = "0x1197430", Offset = "0x1196230", VA = "0x11197430")]
    public EInvalidSkillApplyType[] GetInvalidSkillApplyType(QuestTypes quest_type, Unit unit = null)
    {
      return (EInvalidSkillApplyType[]) null;
    }

    [Token(Token = "0x60041B7")]
    [Address(RVA = "0x11975F0", Offset = "0x11963F0", VA = "0x111975F0")]
    public bool IsEnableInvalidSkillSetting(QuestTypes quest_type, Unit unit) => new bool();

    [Token(Token = "0x60041B8")]
    [Address(RVA = "0x1196330", Offset = "0x1195130", VA = "0x11196330")]
    public string CheckMasterAbilityType(Unit unit, SkillData skill) => (string) null;

    [Token(Token = "0x60041B9")]
    [Address(RVA = "0x1196F10", Offset = "0x1195D10", VA = "0x11196F10")]
    public Json_InvalidSkillApplyType[] ConvertJsonInvaldSkillData(EInvalidSkillApplyType apply_type)
    {
      return (Json_InvalidSkillApplyType[]) null;
    }

    [Token(Token = "0x60041BA")]
    [Address(RVA = "0x1196C70", Offset = "0x1195A70", VA = "0x11196C70")]
    public Json_InvalidSkillApplyType[] ConvertJsonInvaldSkillData(
      EInvalidSkillApplyType apply_type,
      List<InvalidSkill> skills)
    {
      return (Json_InvalidSkillApplyType[]) null;
    }

    [Token(Token = "0x60041BB")]
    [Address(RVA = "0x1197030", Offset = "0x1195E30", VA = "0x11197030")]
    public bool Deserialize(Json_InvalidSkillApplyType[] json) => new bool();

    [Token(Token = "0x60041BC")]
    [Address(RVA = "0x11978F0", Offset = "0x11966F0", VA = "0x111978F0")]
    public string Serialize() => (string) null;

    [Token(Token = "0x60041BD")]
    [Address(RVA = "0x1197DB0", Offset = "0x1196BB0", VA = "0x11197DB0")]
    public InvalidSkillData()
    {
    }
  }
}
