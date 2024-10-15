// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillManipulateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006BC")]
  public sealed class JSON_SkillManipulateParamFormatter : 
    IMessagePackFormatter<JSON_SkillManipulateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001210")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001211")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D82")]
    [Address(RVA = "0xC1CF10", Offset = "0xC1BD10", VA = "0x10C1CF10")]
    public JSON_SkillManipulateParamFormatter()
    {
    }

    [Token(Token = "0x6001D83")]
    [Address(RVA = "0xC1CC00", Offset = "0xC1BA00", VA = "0x10C1CC00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillManipulateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D84")]
    [Address(RVA = "0xC1C720", Offset = "0xC1B520", VA = "0x10C1C720", Slot = "5")]
    public JSON_SkillManipulateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillManipulateParam) null;
    }
  }
}
