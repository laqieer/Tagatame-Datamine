// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondUsePieceFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C8")]
  public sealed class BondUsePieceFormatter : 
    IMessagePackFormatter<BondUsePiece>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001820")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001821")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026A6")]
    [Address(RVA = "0xE67120", Offset = "0xE65F20", VA = "0x10E67120")]
    public BondUsePieceFormatter()
    {
    }

    [Token(Token = "0x60026A7")]
    [Address(RVA = "0xE66FC0", Offset = "0xE65DC0", VA = "0x10E66FC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondUsePiece value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026A8")]
    [Address(RVA = "0xE66C70", Offset = "0xE65A70", VA = "0x10E66C70", Slot = "5")]
    public BondUsePiece Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondUsePiece) null;
    }
  }
}
