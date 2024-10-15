// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eAdditionalCondFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200053A")]
  public sealed class eAdditionalCondFormatter : 
    IMessagePackFormatter<SkillAdditionalParam.eAdditionalCond>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60018FC")]
    [Address(RVA = "0x6B1200", Offset = "0x6B0000", VA = "0x106B1200", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillAdditionalParam.eAdditionalCond value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018FD")]
    [Address(RVA = "0x6B11B0", Offset = "0x6AFFB0", VA = "0x106B11B0", Slot = "5")]
    public SkillAdditionalParam.eAdditionalCond Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new SkillAdditionalParam.eAdditionalCond();
    }

    [Token(Token = "0x60018FE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eAdditionalCondFormatter()
    {
    }
  }
}
