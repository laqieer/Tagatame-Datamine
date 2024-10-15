// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGUsedUnitDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D2")]
  public sealed class JSON_GvGUsedUnitDataFormatter : 
    IMessagePackFormatter<JSON_GvGUsedUnitData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400103C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400103D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AC4")]
    [Address(RVA = "0x95AB90", Offset = "0x959990", VA = "0x1095AB90")]
    public JSON_GvGUsedUnitDataFormatter()
    {
    }

    [Token(Token = "0x6001AC5")]
    [Address(RVA = "0x95AA00", Offset = "0x959800", VA = "0x1095AA00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGUsedUnitData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AC6")]
    [Address(RVA = "0x95A690", Offset = "0x959490", VA = "0x1095A690", Slot = "5")]
    public JSON_GvGUsedUnitData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGUsedUnitData) null;
    }
  }
}
