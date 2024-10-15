// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SkillGroupParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006FF")]
  public sealed class JSON_SkillGroupParamFormatter : 
    IMessagePackFormatter<JSON_SkillGroupParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001296")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001297")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E4B")]
    [Address(RVA = "0xC383D0", Offset = "0xC371D0", VA = "0x10C383D0")]
    public JSON_SkillGroupParamFormatter()
    {
    }

    [Token(Token = "0x6001E4C")]
    [Address(RVA = "0xC38270", Offset = "0xC37070", VA = "0x10C38270", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SkillGroupParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E4D")]
    [Address(RVA = "0xC37F30", Offset = "0xC36D30", VA = "0x10C37F30", Slot = "5")]
    public JSON_SkillGroupParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SkillGroupParam) null;
    }
  }
}
