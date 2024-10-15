// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ProductSaleInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B29")]
  public sealed class JSON_ProductSaleInfoFormatter : 
    IMessagePackFormatter<JSON_ProductSaleInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AE2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AE3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AC9")]
    [Address(RVA = "0xF68CC0", Offset = "0xF67AC0", VA = "0x10F68CC0")]
    public JSON_ProductSaleInfoFormatter()
    {
    }

    [Token(Token = "0x6002ACA")]
    [Address(RVA = "0xF68B00", Offset = "0xF67900", VA = "0x10F68B00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ProductSaleInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002ACB")]
    [Address(RVA = "0xF68770", Offset = "0xF67570", VA = "0x10F68770", Slot = "5")]
    public JSON_ProductSaleInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ProductSaleInfo) null;
    }
  }
}
