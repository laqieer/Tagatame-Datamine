// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ESkillAbilityDeriveCondsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000574")]
  public sealed class ESkillAbilityDeriveCondsFormatter : 
    IMessagePackFormatter<ESkillAbilityDeriveConds>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019AA")]
    [Address(RVA = "0x69BAE0", Offset = "0x69A8E0", VA = "0x1069BAE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ESkillAbilityDeriveConds value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019AB")]
    [Address(RVA = "0x69BA90", Offset = "0x69A890", VA = "0x1069BA90", Slot = "5")]
    public ESkillAbilityDeriveConds Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ESkillAbilityDeriveConds();
    }

    [Token(Token = "0x60019AC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ESkillAbilityDeriveCondsFormatter()
    {
    }
  }
}
