// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardSkillDatailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E96")]
  public class ConceptCardSkillDatailData
  {
    [Token(Token = "0x4002CD0")]
    [FieldOffset(Offset = "0x8")]
    public ConceptCardEquipEffect effect;
    [Token(Token = "0x4002CD1")]
    [FieldOffset(Offset = "0xC")]
    public SkillData skill_data;
    [Token(Token = "0x4002CD2")]
    [FieldOffset(Offset = "0x10")]
    public LearningSkill learning_skill;
    [Token(Token = "0x4002CD3")]
    [FieldOffset(Offset = "0x14")]
    public ConceptCardDetailAbility.ShowType type;

    [Token(Token = "0x6003CC2")]
    [Address(RVA = "0x10F16F0", Offset = "0x10F04F0", VA = "0x110F16F0")]
    public ConceptCardSkillDatailData(
      ConceptCardEquipEffect _effect,
      SkillData _data,
      ConceptCardDetailAbility.ShowType _type,
      LearningSkill _learning_skill = null)
    {
    }
  }
}
