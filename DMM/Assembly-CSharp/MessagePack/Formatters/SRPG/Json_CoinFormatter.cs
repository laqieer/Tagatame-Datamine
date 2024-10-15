// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_CoinFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000714")]
  public sealed class Json_CoinFormatter : IMessagePackFormatter<Json_Coin>, IMessagePackFormatter
  {
    [Token(Token = "0x40012C0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012C1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E8A")]
    [Address(RVA = "0xC5EF60", Offset = "0xC5DD60", VA = "0x10C5EF60")]
    public Json_CoinFormatter()
    {
    }

    [Token(Token = "0x6001E8B")]
    [Address(RVA = "0xC5EE30", Offset = "0xC5DC30", VA = "0x10C5EE30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Coin value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E8C")]
    [Address(RVA = "0xC5EB10", Offset = "0xC5D910", VA = "0x10C5EB10", Slot = "5")]
    public Json_Coin Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Coin) null;
    }
  }
}
