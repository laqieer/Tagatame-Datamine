// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ElementPieceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006CC")]
  public sealed class JSON_ElementPieceParamFormatter : 
    IMessagePackFormatter<JSON_ElementPieceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001230")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001231")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DB2")]
    [Address(RVA = "0xC16100", Offset = "0xC14F00", VA = "0x10C16100")]
    public JSON_ElementPieceParamFormatter()
    {
    }

    [Token(Token = "0x6001DB3")]
    [Address(RVA = "0xC15EE0", Offset = "0xC14CE0", VA = "0x10C15EE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ElementPieceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DB4")]
    [Address(RVA = "0xC15B00", Offset = "0xC14900", VA = "0x10C15B00", Slot = "5")]
    public JSON_ElementPieceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ElementPieceParam) null;
    }
  }
}
