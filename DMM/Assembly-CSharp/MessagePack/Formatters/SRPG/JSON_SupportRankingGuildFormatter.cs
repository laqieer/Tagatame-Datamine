// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SupportRankingGuildFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008AE")]
  public sealed class JSON_SupportRankingGuildFormatter : 
    IMessagePackFormatter<JSON_SupportRankingGuild>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002358")]
    [Address(RVA = "0xDB7CA0", Offset = "0xDB6AA0", VA = "0x10DB7CA0")]
    public JSON_SupportRankingGuildFormatter()
    {
    }

    [Token(Token = "0x6002359")]
    [Address(RVA = "0xDB7B70", Offset = "0xDB6970", VA = "0x10DB7B70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SupportRankingGuild value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600235A")]
    [Address(RVA = "0xDB7860", Offset = "0xDB6660", VA = "0x10DB7860", Slot = "5")]
    public JSON_SupportRankingGuild Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SupportRankingGuild) null;
    }
  }
}
