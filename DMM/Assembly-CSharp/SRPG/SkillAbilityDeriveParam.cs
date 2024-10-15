// Decompiled with JetBrains decompiler
// Type: SRPG.SkillAbilityDeriveParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E1E")]
  [MessagePackObject(false)]
  public class SkillAbilityDeriveParam
  {
    [Token(Token = "0x4007AA5")]
    [FieldOffset(Offset = "0x8")]
    [Key(1)]
    public string iname;
    [Token(Token = "0x4007AA6")]
    [FieldOffset(Offset = "0xC")]
    [Key(2)]
    public SkillAbilityDeriveTriggerParam[] deriveTriggers;
    [Token(Token = "0x4007AA7")]
    [FieldOffset(Offset = "0x10")]
    [Key(3)]
    public string[] base_abils;
    [Token(Token = "0x4007AA8")]
    [FieldOffset(Offset = "0x14")]
    [Key(4)]
    public string[] derive_abils;
    [Token(Token = "0x4007AA9")]
    [FieldOffset(Offset = "0x18")]
    [Key(5)]
    public string[] base_skills;
    [Token(Token = "0x4007AAA")]
    [FieldOffset(Offset = "0x1C")]
    [Key(6)]
    public string[] derive_skills;
    [Token(Token = "0x4007AAB")]
    [FieldOffset(Offset = "0x20")]
    [Key(0)]
    public int m_OriginIndex;
    [Token(Token = "0x4007AAC")]
    [FieldOffset(Offset = "0x24")]
    private List<SkillDeriveParam> m_SkillDeriveParams;
    [Token(Token = "0x4007AAD")]
    [FieldOffset(Offset = "0x28")]
    private List<AbilityDeriveParam> m_AbilityDeriveParams;

    [Token(Token = "0x170010FD")]
    [Key(7)]
    public List<SkillDeriveParam> SkillDeriveParams
    {
      [Token(Token = "0x6007B91"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<SkillDeriveParam>) null;
      }
    }

    [Token(Token = "0x170010FE")]
    [Key(8)]
    public List<AbilityDeriveParam> AbilityDeriveParams
    {
      [Token(Token = "0x6007B92"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<AbilityDeriveParam>) null;
      }
    }

    [Token(Token = "0x6007B93")]
    [Address(RVA = "0x3E52F0", Offset = "0x3E40F0", VA = "0x103E52F0")]
    [SerializationConstructor]
    public SkillAbilityDeriveParam(int index)
    {
    }

    [Token(Token = "0x6007B94")]
    [Address(RVA = "0x3E51D0", Offset = "0x3E3FD0", VA = "0x103E51D0")]
    public string GetTriggerArtifactIname(int index) => (string) null;

    [Token(Token = "0x6007B95")]
    [Address(RVA = "0x3E5230", Offset = "0x3E4030", VA = "0x103E5230")]
    public ArtifactParam GetTriggerArtifactParam(int index) => (ArtifactParam) null;

    [Token(Token = "0x6007B96")]
    [Address(RVA = "0x3E46B0", Offset = "0x3E34B0", VA = "0x103E46B0")]
    private void Deserialize(JSON_SkillAbilityDeriveParam json)
    {
    }

    [Token(Token = "0x6007B97")]
    [Address(RVA = "0x3E4660", Offset = "0x3E3460", VA = "0x103E4660")]
    public void Deserialize(JSON_SkillAbilityDeriveParam json, MasterParam masterParam)
    {
    }

    [Token(Token = "0x6007B98")]
    [Address(RVA = "0x3E4E10", Offset = "0x3E3C10", VA = "0x103E4E10")]
    private void FindSkillAbilityDeriveParams(MasterParam masterParam)
    {
    }

    [Token(Token = "0x6007B99")]
    [Address(RVA = "0x3E42B0", Offset = "0x3E30B0", VA = "0x103E42B0")]
    public bool CheckContainsTriggerIname(
      ESkillAbilityDeriveConds conditionsType,
      string triggerIname)
    {
      return new bool();
    }

    [Token(Token = "0x6007B9A")]
    [Address(RVA = "0x3E4390", Offset = "0x3E3190", VA = "0x103E4390")]
    public bool CheckContainsTriggerInames(
      SkillAbilityDeriveTriggerParam[] searchKeyTriggerParam)
    {
      return new bool();
    }

    [Token(Token = "0x6007B9B")]
    [Address(RVA = "0x3E5010", Offset = "0x3E3E10", VA = "0x103E5010")]
    private List<SkillDeriveParam> GetSkillDeriveParams(MasterParam masterParam)
    {
      return (List<SkillDeriveParam>) null;
    }

    [Token(Token = "0x6007B9C")]
    [Address(RVA = "0x3E4E50", Offset = "0x3E3C50", VA = "0x103E4E50")]
    private List<AbilityDeriveParam> GetAbilityDeriveParams(MasterParam masterParam)
    {
      return (List<AbilityDeriveParam>) null;
    }
  }
}
