// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BondSubPieceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B28")]
  public sealed class BondSubPieceParamFormatter : 
    IMessagePackFormatter<BondSubPieceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AE0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AE1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AC6")]
    [Address(RVA = "0xF31590", Offset = "0xF30390", VA = "0x10F31590")]
    public BondSubPieceParamFormatter()
    {
    }

    [Token(Token = "0x6002AC7")]
    [Address(RVA = "0xF313B0", Offset = "0xF301B0", VA = "0x10F313B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BondSubPieceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AC8")]
    [Address(RVA = "0xF310A0", Offset = "0xF2FEA0", VA = "0x10F310A0", Slot = "5")]
    public BondSubPieceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BondSubPieceParam) null;
    }
  }
}
