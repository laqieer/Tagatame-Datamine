// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ESkillTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200053E")]
  public sealed class ESkillTypeFormatter : IMessagePackFormatter<ESkillType>, IMessagePackFormatter
  {
    [Token(Token = "0x6001908")]
    [Address(RVA = "0x69BE00", Offset = "0x69AC00", VA = "0x1069BE00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ESkillType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001909")]
    [Address(RVA = "0x69BDB0", Offset = "0x69ABB0", VA = "0x1069BDB0", Slot = "5")]
    public ESkillType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ESkillType();
    }

    [Token(Token = "0x600190A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ESkillTypeFormatter()
    {
    }
  }
}
