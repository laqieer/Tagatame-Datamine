// Decompiled with JetBrains decompiler
// Type: SRPG.SkillAbilityDeriveTriggerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E1D")]
  [MessagePackObject(false)]
  public class SkillAbilityDeriveTriggerParam
  {
    [Token(Token = "0x4007AA3")]
    [FieldOffset(Offset = "0x8")]
    [Key(0)]
    public ESkillAbilityDeriveConds m_TriggerType;
    [Token(Token = "0x4007AA4")]
    [FieldOffset(Offset = "0xC")]
    [Key(1)]
    public string m_TriggerIname;

    [Token(Token = "0x6007B8F")]
    [Address(RVA = "0x3E5470", Offset = "0x3E4270", VA = "0x103E5470")]
    [SerializationConstructor]
    public SkillAbilityDeriveTriggerParam(ESkillAbilityDeriveConds triggerType, string triggerIname)
    {
    }

    [Token(Token = "0x6007B90")]
    [Address(RVA = "0x3E5310", Offset = "0x3E4110", VA = "0x103E5310")]
    public static List<SkillAbilityDeriveTriggerParam[]> CreateCombination(
      SkillAbilityDeriveTriggerParam[] triggerParams)
    {
      return (List<SkillAbilityDeriveTriggerParam[]>) null;
    }
  }
}
