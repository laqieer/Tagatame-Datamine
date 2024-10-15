// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnitOverWriteDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A4")]
  public sealed class JSON_UnitOverWriteDataFormatter : 
    IMessagePackFormatter<JSON_UnitOverWriteData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FE0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FE1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A3A")]
    [Address(RVA = "0x7961B0", Offset = "0x794FB0", VA = "0x107961B0")]
    public JSON_UnitOverWriteDataFormatter()
    {
    }

    [Token(Token = "0x6001A3B")]
    [Address(RVA = "0x795DC0", Offset = "0x794BC0", VA = "0x10795DC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnitOverWriteData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A3C")]
    [Address(RVA = "0x795860", Offset = "0x794660", VA = "0x10795860", Slot = "5")]
    public JSON_UnitOverWriteData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnitOverWriteData) null;
    }
  }
}
