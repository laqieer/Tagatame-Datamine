// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EInvalidSkillTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200055C")]
  public sealed class EInvalidSkillTypeFormatter : 
    IMessagePackFormatter<EInvalidSkillType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001962")]
    [Address(RVA = "0x69B720", Offset = "0x69A520", VA = "0x1069B720", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EInvalidSkillType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001963")]
    [Address(RVA = "0x69B6D0", Offset = "0x69A4D0", VA = "0x1069B6D0", Slot = "5")]
    public EInvalidSkillType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EInvalidSkillType();
    }

    [Token(Token = "0x6001964")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EInvalidSkillTypeFormatter()
    {
    }
  }
}
