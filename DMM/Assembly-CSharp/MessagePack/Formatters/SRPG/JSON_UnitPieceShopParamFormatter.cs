// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitPieceShopParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000665")]
  public sealed class JSON_UnitPieceShopParamFormatter : 
    IMessagePackFormatter<JSON_UnitPieceShopParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001162")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001163")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C7D")]
    [Address(RVA = "0xBF2C70", Offset = "0xBF1A70", VA = "0x10BF2C70")]
    public JSON_UnitPieceShopParamFormatter()
    {
    }

    [Token(Token = "0x6001C7E")]
    [Address(RVA = "0xBF2A00", Offset = "0xBF1800", VA = "0x10BF2A00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitPieceShopParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C7F")]
    [Address(RVA = "0xBF25E0", Offset = "0xBF13E0", VA = "0x10BF25E0", Slot = "5")]
    public JSON_UnitPieceShopParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitPieceShopParam) null;
    }
  }
}
