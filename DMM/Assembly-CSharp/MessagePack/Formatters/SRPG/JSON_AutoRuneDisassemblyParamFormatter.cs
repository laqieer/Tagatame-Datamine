// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AutoRuneDisassemblyParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000684")]
  public sealed class JSON_AutoRuneDisassemblyParamFormatter : 
    IMessagePackFormatter<JSON_AutoRuneDisassemblyParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CDA")]
    [Address(RVA = "0xBF5EA0", Offset = "0xBF4CA0", VA = "0x10BF5EA0")]
    public JSON_AutoRuneDisassemblyParamFormatter()
    {
    }

    [Token(Token = "0x6001CDB")]
    [Address(RVA = "0xBF5CC0", Offset = "0xBF4AC0", VA = "0x10BF5CC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AutoRuneDisassemblyParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CDC")]
    [Address(RVA = "0xBF5910", Offset = "0xBF4710", VA = "0x10BF5910", Slot = "5")]
    public JSON_AutoRuneDisassemblyParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AutoRuneDisassemblyParam) null;
    }
  }
}
