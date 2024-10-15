// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillAbilityDeriveParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A4")]
  public sealed class SkillAbilityDeriveParamFormatter : 
    IMessagePackFormatter<SkillAbilityDeriveParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600203A")]
    [Address(RVA = "0xCF5A70", Offset = "0xCF4870", VA = "0x10CF5A70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillAbilityDeriveParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600203B")]
    [Address(RVA = "0xCF5620", Offset = "0xCF4420", VA = "0x10CF5620", Slot = "5")]
    public SkillAbilityDeriveParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillAbilityDeriveParam) null;
    }

    [Token(Token = "0x600203C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillAbilityDeriveParamFormatter()
    {
    }
  }
}
