// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GiftCrystalFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000898")]
  public sealed class Json_GiftCrystalFormatter : 
    IMessagePackFormatter<Json_GiftCrystal>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002316")]
    [Address(RVA = "0xDA5000", Offset = "0xDA3E00", VA = "0x10DA5000")]
    public Json_GiftCrystalFormatter()
    {
    }

    [Token(Token = "0x6002317")]
    [Address(RVA = "0xDA4E90", Offset = "0xDA3C90", VA = "0x10DA4E90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GiftCrystal value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002318")]
    [Address(RVA = "0xDA4B40", Offset = "0xDA3940", VA = "0x10DA4B40", Slot = "5")]
    public Json_GiftCrystal Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GiftCrystal) null;
    }
  }
}
