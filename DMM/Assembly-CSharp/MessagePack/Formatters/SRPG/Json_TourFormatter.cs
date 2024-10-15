// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_TourFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200071A")]
  public sealed class Json_TourFormatter : IMessagePackFormatter<Json_Tour>, IMessagePackFormatter
  {
    [Token(Token = "0x40012CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E9C")]
    [Address(RVA = "0xC65A10", Offset = "0xC64810", VA = "0x10C65A10")]
    public Json_TourFormatter()
    {
    }

    [Token(Token = "0x6001E9D")]
    [Address(RVA = "0xC65950", Offset = "0xC64750", VA = "0x10C65950", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Tour value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E9E")]
    [Address(RVA = "0xC656B0", Offset = "0xC644B0", VA = "0x10C656B0", Slot = "5")]
    public Json_Tour Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Tour) null;
    }
  }
}
