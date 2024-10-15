// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConvertUnitPieceExcludeParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200063A")]
  public sealed class JSON_ConvertUnitPieceExcludeParamFormatter : 
    IMessagePackFormatter<JSON_ConvertUnitPieceExcludeParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400110C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400110D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BFC")]
    [Address(RVA = "0xBD1130", Offset = "0xBCFF30", VA = "0x10BD1130")]
    public JSON_ConvertUnitPieceExcludeParamFormatter()
    {
    }

    [Token(Token = "0x6001BFD")]
    [Address(RVA = "0xBD1000", Offset = "0xBCFE00", VA = "0x10BD1000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConvertUnitPieceExcludeParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BFE")]
    [Address(RVA = "0xBD0CF0", Offset = "0xBCFAF0", VA = "0x10BD0CF0", Slot = "5")]
    public JSON_ConvertUnitPieceExcludeParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConvertUnitPieceExcludeParam) null;
    }
  }
}
