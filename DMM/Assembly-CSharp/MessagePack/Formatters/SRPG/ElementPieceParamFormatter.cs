// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ElementPieceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B40")]
  public sealed class ElementPieceParamFormatter : 
    IMessagePackFormatter<ElementPieceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B10")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B11")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002B0E")]
    [Address(RVA = "0xF5D950", Offset = "0xF5C750", VA = "0x10F5D950")]
    public ElementPieceParamFormatter()
    {
    }

    [Token(Token = "0x6002B0F")]
    [Address(RVA = "0xF5D6D0", Offset = "0xF5C4D0", VA = "0x10F5D6D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ElementPieceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002B10")]
    [Address(RVA = "0xF5D390", Offset = "0xF5C190", VA = "0x10F5D390", Slot = "5")]
    public ElementPieceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ElementPieceParam) null;
    }
  }
}
