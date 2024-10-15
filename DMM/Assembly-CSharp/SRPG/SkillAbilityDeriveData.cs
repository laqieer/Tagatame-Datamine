// Decompiled with JetBrains decompiler
// Type: SRPG.SkillAbilityDeriveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E25")]
  public class SkillAbilityDeriveData
  {
    [Token(Token = "0x4007ABB")]
    [FieldOffset(Offset = "0x8")]
    public SkillAbilityDeriveParam m_SkillAbilityDeriveParam;
    [Token(Token = "0x4007ABC")]
    [FieldOffset(Offset = "0xC")]
    public List<SkillDeriveData> m_SkillDeriveData;
    [Token(Token = "0x4007ABD")]
    [FieldOffset(Offset = "0x10")]
    public List<AbilityDeriveData> m_AbilityDeriveData;
    [Token(Token = "0x4007ABE")]
    [FieldOffset(Offset = "0x14")]
    public HashSet<SkillAbilityDeriveParam> m_AdditionalSkillAbilityDeriveParam;

    [Token(Token = "0x1700110E")]
    public int MasterIndex
    {
      [Token(Token = "0x6007BBA"), Address(RVA = "0x3E4290", Offset = "0x3E3090", VA = "0x103E4290")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007BBB")]
    [Address(RVA = "0x3E2FE0", Offset = "0x3E1DE0", VA = "0x103E2FE0")]
    public bool CheckContainsTriggerIname(ESkillAbilityDeriveConds triggerType, string triggerIname)
    {
      return new bool();
    }

    [Token(Token = "0x6007BBC")]
    [Address(RVA = "0x3E30D0", Offset = "0x3E1ED0", VA = "0x103E30D0")]
    public bool CheckContainsTriggerInames(
      SkillAbilityDeriveTriggerParam[] searchKeyTriggerParam)
    {
      return new bool();
    }

    [Token(Token = "0x6007BBD")]
    [Address(RVA = "0x3E3460", Offset = "0x3E2260", VA = "0x103E3460")]
    public void Setup(
      SkillAbilityDeriveParam skillAbilityDeriveParam,
      List<SkillAbilityDeriveParam> additionalSkillAbilityDeriveParams)
    {
    }

    [Token(Token = "0x6007BBE")]
    [Address(RVA = "0x3E32B0", Offset = "0x3E20B0", VA = "0x103E32B0")]
    public List<SkillDeriveParam> GetAvailableSkillDeriveParams() => (List<SkillDeriveParam>) null;

    [Token(Token = "0x6007BBF")]
    [Address(RVA = "0x3E3100", Offset = "0x3E1F00", VA = "0x103E3100")]
    public List<AbilityDeriveParam> GetAvailableAbilityDeriveParams()
    {
      return (List<AbilityDeriveParam>) null;
    }

    [Token(Token = "0x6007BC0")]
    [Address(RVA = "0x3E4220", Offset = "0x3E3020", VA = "0x103E4220")]
    public SkillAbilityDeriveData()
    {
    }
  }
}
