// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillAbilityDeriveTriggerParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A3")]
  public sealed class SkillAbilityDeriveTriggerParamFormatter : 
    IMessagePackFormatter<SkillAbilityDeriveTriggerParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6002037")]
    [Address(RVA = "0xCF6040", Offset = "0xCF4E40", VA = "0x10CF6040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillAbilityDeriveTriggerParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002038")]
    [Address(RVA = "0xCF5E60", Offset = "0xCF4C60", VA = "0x10CF5E60", Slot = "5")]
    public SkillAbilityDeriveTriggerParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillAbilityDeriveTriggerParam) null;
    }

    [Token(Token = "0x6002039")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillAbilityDeriveTriggerParamFormatter()
    {
    }
  }
}
