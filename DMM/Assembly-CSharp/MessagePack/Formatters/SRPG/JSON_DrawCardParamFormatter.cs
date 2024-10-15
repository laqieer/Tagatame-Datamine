// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DrawCardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000660")]
  public sealed class JSON_DrawCardParamFormatter : 
    IMessagePackFormatter<JSON_DrawCardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001158")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001159")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C6E")]
    [Address(RVA = "0xBE0A30", Offset = "0xBDF830", VA = "0x10BE0A30")]
    public JSON_DrawCardParamFormatter()
    {
    }

    [Token(Token = "0x6001C6F")]
    [Address(RVA = "0xBE0760", Offset = "0xBDF560", VA = "0x10BE0760", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DrawCardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C70")]
    [Address(RVA = "0xBE0350", Offset = "0xBDF150", VA = "0x10BE0350", Slot = "5")]
    public JSON_DrawCardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DrawCardParam) null;
    }
  }
}
