// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidDeckFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000737")]
  public sealed class JSON_GuildRaidDeckFormatter : 
    IMessagePackFormatter<JSON_GuildRaidDeck>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001306")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001307")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EF3")]
    [Address(RVA = "0xC84C70", Offset = "0xC83A70", VA = "0x10C84C70")]
    public JSON_GuildRaidDeckFormatter()
    {
    }

    [Token(Token = "0x6001EF4")]
    [Address(RVA = "0xC84A40", Offset = "0xC83840", VA = "0x10C84A40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidDeck value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EF5")]
    [Address(RVA = "0xC84700", Offset = "0xC83500", VA = "0x10C84700", Slot = "5")]
    public JSON_GuildRaidDeck Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidDeck) null;
    }
  }
}
