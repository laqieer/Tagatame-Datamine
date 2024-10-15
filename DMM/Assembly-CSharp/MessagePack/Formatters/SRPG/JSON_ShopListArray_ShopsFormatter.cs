// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ShopListArray_ShopsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000814")]
  public sealed class JSON_ShopListArray_ShopsFormatter : 
    IMessagePackFormatter<JSON_ShopListArray.Shops>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600218A")]
    [Address(RVA = "0xD4A8C0", Offset = "0xD496C0", VA = "0x10D4A8C0")]
    public JSON_ShopListArray_ShopsFormatter()
    {
    }

    [Token(Token = "0x600218B")]
    [Address(RVA = "0xD4A430", Offset = "0xD49230", VA = "0x10D4A430", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ShopListArray.Shops value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600218C")]
    [Address(RVA = "0xD49EA0", Offset = "0xD48CA0", VA = "0x10D49EA0", Slot = "5")]
    public JSON_ShopListArray.Shops Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ShopListArray.Shops) null;
    }
  }
}
