// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillCategoryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200057C")]
  public sealed class SkillCategoryFormatter : 
    IMessagePackFormatter<SkillCategory>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019C2")]
    [Address(RVA = "0x6AAA90", Offset = "0x6A9890", VA = "0x106AAA90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillCategory value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019C3")]
    [Address(RVA = "0x6AAA40", Offset = "0x6A9840", VA = "0x106AAA40", Slot = "5")]
    public SkillCategory Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new SkillCategory();
    }

    [Token(Token = "0x60019C4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillCategoryFormatter()
    {
    }
  }
}
