// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AutoRuneDisassemblySetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000686")]
  public sealed class JSON_AutoRuneDisassemblySetParamFormatter : 
    IMessagePackFormatter<JSON_AutoRuneDisassemblySetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CE0")]
    [Address(RVA = "0xBF6620", Offset = "0xBF5420", VA = "0x10BF6620")]
    public JSON_AutoRuneDisassemblySetParamFormatter()
    {
    }

    [Token(Token = "0x6001CE1")]
    [Address(RVA = "0xBF6440", Offset = "0xBF5240", VA = "0x10BF6440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AutoRuneDisassemblySetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CE2")]
    [Address(RVA = "0xBF6100", Offset = "0xBF4F00", VA = "0x10BF6100", Slot = "5")]
    public JSON_AutoRuneDisassemblySetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AutoRuneDisassemblySetParam) null;
    }
  }
}
