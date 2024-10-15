// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GrowParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005EC")]
  public sealed class JSON_GrowParamFormatter : 
    IMessagePackFormatter<JSON_GrowParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001070")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001071")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B12")]
    [Address(RVA = "0xB97120", Offset = "0xB95F20", VA = "0x10B97120")]
    public JSON_GrowParamFormatter()
    {
    }

    [Token(Token = "0x6001B13")]
    [Address(RVA = "0xB96F40", Offset = "0xB95D40", VA = "0x10B96F40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GrowParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B14")]
    [Address(RVA = "0xB96C00", Offset = "0xB95A00", VA = "0x10B96C00", Slot = "5")]
    public JSON_GrowParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GrowParam) null;
    }
  }
}
