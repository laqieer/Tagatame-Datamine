// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ItemSellConvertListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008AB")]
  public sealed class Json_ItemSellConvertListFormatter : 
    IMessagePackFormatter<Json_ItemSellConvertList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600234F")]
    [Address(RVA = "0xDBB8E0", Offset = "0xDBA6E0", VA = "0x10DBB8E0")]
    public Json_ItemSellConvertListFormatter()
    {
    }

    [Token(Token = "0x6002350")]
    [Address(RVA = "0xDBB780", Offset = "0xDBA580", VA = "0x10DBB780", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_ItemSellConvertList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002351")]
    [Address(RVA = "0xDBB430", Offset = "0xDBA230", VA = "0x10DBB430", Slot = "5")]
    public Json_ItemSellConvertList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_ItemSellConvertList) null;
    }
  }
}
