// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ShopListArray_Shops_JSON_ShopListInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000812")]
  public sealed class JSON_ShopListArray_Shops_JSON_ShopListInfoFormatter : 
    IMessagePackFormatter<JSON_ShopListArray.Shops.JSON_ShopListInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002184")]
    [Address(RVA = "0xD4B3A0", Offset = "0xD4A1A0", VA = "0x10D4B3A0")]
    public JSON_ShopListArray_Shops_JSON_ShopListInfoFormatter()
    {
    }

    [Token(Token = "0x6002185")]
    [Address(RVA = "0xD4B180", Offset = "0xD49F80", VA = "0x10D4B180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ShopListArray.Shops.JSON_ShopListInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002186")]
    [Address(RVA = "0xD4ADA0", Offset = "0xD49BA0", VA = "0x10D4ADA0", Slot = "5")]
    public JSON_ShopListArray.Shops.JSON_ShopListInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ShopListArray.Shops.JSON_ShopListInfo) null;
    }
  }
}
