// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraCategoriesParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000609")]
  public sealed class JSON_TobiraCategoriesParamFormatter : 
    IMessagePackFormatter<JSON_TobiraCategoriesParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B69")]
    [Address(RVA = "0xBA9E40", Offset = "0xBA8C40", VA = "0x10BA9E40")]
    public JSON_TobiraCategoriesParamFormatter()
    {
    }

    [Token(Token = "0x6001B6A")]
    [Address(RVA = "0xBA9D10", Offset = "0xBA8B10", VA = "0x10BA9D10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraCategoriesParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B6B")]
    [Address(RVA = "0xBA9A00", Offset = "0xBA8800", VA = "0x10BA9A00", Slot = "5")]
    public JSON_TobiraCategoriesParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraCategoriesParam) null;
    }
  }
}
