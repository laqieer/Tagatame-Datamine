// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ShopListArray_BannersFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000931")]
  public sealed class JSON_ShopListArray_BannersFormatter : 
    IMessagePackFormatter<JSON_ShopListArray.Banners>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024E1")]
    [Address(RVA = "0xE008F0", Offset = "0xDFF6F0", VA = "0x10E008F0")]
    public JSON_ShopListArray_BannersFormatter()
    {
    }

    [Token(Token = "0x60024E2")]
    [Address(RVA = "0xE00650", Offset = "0xDFF450", VA = "0x10E00650", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ShopListArray.Banners value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024E3")]
    [Address(RVA = "0xE00250", Offset = "0xDFF050", VA = "0x10E00250", Slot = "5")]
    public JSON_ShopListArray.Banners Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ShopListArray.Banners) null;
    }
  }
}
