// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_StatusCoefficientParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200061A")]
  public sealed class JSON_StatusCoefficientParamFormatter : 
    IMessagePackFormatter<JSON_StatusCoefficientParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B9C")]
    [Address(RVA = "0xBC82C0", Offset = "0xBC70C0", VA = "0x10BC82C0")]
    public JSON_StatusCoefficientParamFormatter()
    {
    }

    [Token(Token = "0x6001B9D")]
    [Address(RVA = "0xBC7F20", Offset = "0xBC6D20", VA = "0x10BC7F20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_StatusCoefficientParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B9E")]
    [Address(RVA = "0xBC7960", Offset = "0xBC6760", VA = "0x10BC7960", Slot = "5")]
    public JSON_StatusCoefficientParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_StatusCoefficientParam) null;
    }
  }
}
