// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitRentalParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200065C")]
  public sealed class JSON_UnitRentalParamFormatter : 
    IMessagePackFormatter<JSON_UnitRentalParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001150")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001151")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C62")]
    [Address(RVA = "0xBF4760", Offset = "0xBF3560", VA = "0x10BF4760")]
    public JSON_UnitRentalParamFormatter()
    {
    }

    [Token(Token = "0x6001C63")]
    [Address(RVA = "0xBF4260", Offset = "0xBF3060", VA = "0x10BF4260", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitRentalParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C64")]
    [Address(RVA = "0xBF3C00", Offset = "0xBF2A00", VA = "0x10BF3C00", Slot = "5")]
    public JSON_UnitRentalParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitRentalParam) null;
    }
  }
}
