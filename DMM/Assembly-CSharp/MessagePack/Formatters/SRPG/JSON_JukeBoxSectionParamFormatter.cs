// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_JukeBoxSectionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200068A")]
  public sealed class JSON_JukeBoxSectionParamFormatter : 
    IMessagePackFormatter<JSON_JukeBoxSectionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CEC")]
    [Address(RVA = "0xBFFFE0", Offset = "0xBFEDE0", VA = "0x10BFFFE0")]
    public JSON_JukeBoxSectionParamFormatter()
    {
    }

    [Token(Token = "0x6001CED")]
    [Address(RVA = "0xBFFE90", Offset = "0xBFEC90", VA = "0x10BFFE90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_JukeBoxSectionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CEE")]
    [Address(RVA = "0xBFFB60", Offset = "0xBFE960", VA = "0x10BFFB60", Slot = "5")]
    public JSON_JukeBoxSectionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_JukeBoxSectionParam) null;
    }
  }
}
