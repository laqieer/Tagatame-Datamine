// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ShopListArray_Shops_JSON_ShopListInfo_JSON_ShopListInfoCostFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000930")]
  public sealed class JSON_ShopListArray_Shops_JSON_ShopListInfo_JSON_ShopListInfoCostFormatter : 
    IMessagePackFormatter<JSON_ShopListArray.Shops.JSON_ShopListInfo.JSON_ShopListInfoCost>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024DE")]
    [Address(RVA = "0xE00EA0", Offset = "0xDFFCA0", VA = "0x10E00EA0")]
    public JSON_ShopListArray_Shops_JSON_ShopListInfo_JSON_ShopListInfoCostFormatter()
    {
    }

    [Token(Token = "0x60024DF")]
    [Address(RVA = "0xE00E30", Offset = "0xDFFC30", VA = "0x10E00E30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ShopListArray.Shops.JSON_ShopListInfo.JSON_ShopListInfoCost value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024E0")]
    [Address(RVA = "0xE00BC0", Offset = "0xDFF9C0", VA = "0x10E00BC0", Slot = "5")]
    public JSON_ShopListArray.Shops.JSON_ShopListInfo.JSON_ShopListInfoCost Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ShopListArray.Shops.JSON_ShopListInfo.JSON_ShopListInfoCost) null;
    }
  }
}
