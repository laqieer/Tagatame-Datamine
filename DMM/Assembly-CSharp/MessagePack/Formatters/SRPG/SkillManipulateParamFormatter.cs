// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.SkillManipulateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200075F")]
  public sealed class SkillManipulateParamFormatter : 
    IMessagePackFormatter<SkillManipulateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001356")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001357")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F6B")]
    [Address(RVA = "0xC9CFF0", Offset = "0xC9BDF0", VA = "0x10C9CFF0")]
    public SkillManipulateParamFormatter()
    {
    }

    [Token(Token = "0x6001F6C")]
    [Address(RVA = "0xC9C920", Offset = "0xC9B720", VA = "0x10C9C920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      SkillManipulateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F6D")]
    [Address(RVA = "0xC9C250", Offset = "0xC9B050", VA = "0x10C9C250", Slot = "5")]
    public SkillManipulateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (SkillManipulateParam) null;
    }
  }
}
