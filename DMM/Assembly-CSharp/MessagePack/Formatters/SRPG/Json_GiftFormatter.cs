// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GiftFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000899")]
  public sealed class Json_GiftFormatter : IMessagePackFormatter<Json_Gift>, IMessagePackFormatter
  {
    [Token(Token = "0x40015C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002319")]
    [Address(RVA = "0xDA5B70", Offset = "0xDA4970", VA = "0x10DA5B70")]
    public Json_GiftFormatter()
    {
    }

    [Token(Token = "0x600231A")]
    [Address(RVA = "0xDA5720", Offset = "0xDA4520", VA = "0x10DA5720", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Gift value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600231B")]
    [Address(RVA = "0xDA51F0", Offset = "0xDA3FF0", VA = "0x10DA51F0", Slot = "5")]
    public Json_Gift Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Gift) null;
    }
  }
}
