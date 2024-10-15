// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_BondUsePieceFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C4")]
  public sealed class JSON_BondUsePieceFormatter : 
    IMessagePackFormatter<JSON_BondUsePiece>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001818")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001819")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600269A")]
    [Address(RVA = "0xE6E4D0", Offset = "0xE6D2D0", VA = "0x10E6E4D0")]
    public JSON_BondUsePieceFormatter()
    {
    }

    [Token(Token = "0x600269B")]
    [Address(RVA = "0xE6E3A0", Offset = "0xE6D1A0", VA = "0x10E6E3A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_BondUsePiece value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600269C")]
    [Address(RVA = "0xE6E090", Offset = "0xE6CE90", VA = "0x10E6E090", Slot = "5")]
    public JSON_BondUsePiece Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_BondUsePiece) null;
    }
  }
}
