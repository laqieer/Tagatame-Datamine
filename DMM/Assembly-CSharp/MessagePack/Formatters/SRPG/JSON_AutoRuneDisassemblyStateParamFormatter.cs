// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AutoRuneDisassemblyStateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000688")]
  public sealed class JSON_AutoRuneDisassemblyStateParamFormatter : 
    IMessagePackFormatter<JSON_AutoRuneDisassemblyStateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CE6")]
    [Address(RVA = "0xBF7470", Offset = "0xBF6270", VA = "0x10BF7470")]
    public JSON_AutoRuneDisassemblyStateParamFormatter()
    {
    }

    [Token(Token = "0x6001CE7")]
    [Address(RVA = "0xBF7290", Offset = "0xBF6090", VA = "0x10BF7290", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AutoRuneDisassemblyStateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CE8")]
    [Address(RVA = "0xBF6F50", Offset = "0xBF5D50", VA = "0x10BF6F50", Slot = "5")]
    public JSON_AutoRuneDisassemblyStateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AutoRuneDisassemblyStateParam) null;
    }
  }
}
