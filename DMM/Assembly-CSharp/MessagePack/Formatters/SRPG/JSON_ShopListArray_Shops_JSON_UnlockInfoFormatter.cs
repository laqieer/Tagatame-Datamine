// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ShopListArray_Shops_JSON_UnlockInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000813")]
  public sealed class JSON_ShopListArray_Shops_JSON_UnlockInfoFormatter : 
    IMessagePackFormatter<JSON_ShopListArray.Shops.JSON_UnlockInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002187")]
    [Address(RVA = "0xD4BAB0", Offset = "0xD4A8B0", VA = "0x10D4BAB0")]
    public JSON_ShopListArray_Shops_JSON_UnlockInfoFormatter()
    {
    }

    [Token(Token = "0x6002188")]
    [Address(RVA = "0xD4B980", Offset = "0xD4A780", VA = "0x10D4B980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ShopListArray.Shops.JSON_UnlockInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002189")]
    [Address(RVA = "0xD4B670", Offset = "0xD4A470", VA = "0x10D4B670", Slot = "5")]
    public JSON_ShopListArray.Shops.JSON_UnlockInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ShopListArray.Shops.JSON_UnlockInfo) null;
    }
  }
}
