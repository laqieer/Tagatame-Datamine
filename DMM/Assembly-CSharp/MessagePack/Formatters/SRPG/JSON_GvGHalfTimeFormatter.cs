// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGHalfTimeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D0")]
  public sealed class JSON_GvGHalfTimeFormatter : 
    IMessagePackFormatter<JSON_GvGHalfTime>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001038")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001039")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ABE")]
    [Address(RVA = "0x950370", Offset = "0x94F170", VA = "0x10950370")]
    public JSON_GvGHalfTimeFormatter()
    {
    }

    [Token(Token = "0x6001ABF")]
    [Address(RVA = "0x950210", Offset = "0x94F010", VA = "0x10950210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGHalfTime value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AC0")]
    [Address(RVA = "0x94FEC0", Offset = "0x94ECC0", VA = "0x1094FEC0", Slot = "5")]
    public JSON_GvGHalfTime Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGHalfTime) null;
    }
  }
}
