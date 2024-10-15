// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ArenaFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000719")]
  public sealed class Json_ArenaFormatter : IMessagePackFormatter<Json_Arena>, IMessagePackFormatter
  {
    [Token(Token = "0x40012CA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012CB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E99")]
    [Address(RVA = "0xC5D6C0", Offset = "0xC5C4C0", VA = "0x10C5D6C0")]
    public Json_ArenaFormatter()
    {
    }

    [Token(Token = "0x6001E9A")]
    [Address(RVA = "0xC5D590", Offset = "0xC5C390", VA = "0x10C5D590", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Arena value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E9B")]
    [Address(RVA = "0xC5D250", Offset = "0xC5C050", VA = "0x10C5D250", Slot = "5")]
    public Json_Arena Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Arena) null;
    }
  }
}
