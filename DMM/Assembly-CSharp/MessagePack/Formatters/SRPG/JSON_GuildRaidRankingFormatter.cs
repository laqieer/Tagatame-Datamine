// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRankingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000919")]
  public sealed class JSON_GuildRaidRankingFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRanking>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016C2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016C3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002499")]
    [Address(RVA = "0xDFD9B0", Offset = "0xDFC7B0", VA = "0x10DFD9B0")]
    public JSON_GuildRaidRankingFormatter()
    {
    }

    [Token(Token = "0x600249A")]
    [Address(RVA = "0xDFD7C0", Offset = "0xDFC5C0", VA = "0x10DFD7C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRanking value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600249B")]
    [Address(RVA = "0xDFD450", Offset = "0xDFC250", VA = "0x10DFD450", Slot = "5")]
    public JSON_GuildRaidRanking Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRanking) null;
    }
  }
}
