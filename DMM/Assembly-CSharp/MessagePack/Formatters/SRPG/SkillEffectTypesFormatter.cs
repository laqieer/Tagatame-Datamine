// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillEffectTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000545")]
  public sealed class SkillEffectTypesFormatter : 
    IMessagePackFormatter<SkillEffectTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600191D")]
    [Address(RVA = "0x6AABD0", Offset = "0x6A99D0", VA = "0x106AABD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillEffectTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600191E")]
    [Address(RVA = "0x6AAB80", Offset = "0x6A9980", VA = "0x106AAB80", Slot = "5")]
    public SkillEffectTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new SkillEffectTypes();
    }

    [Token(Token = "0x600191F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillEffectTypesFormatter()
    {
    }
  }
}
