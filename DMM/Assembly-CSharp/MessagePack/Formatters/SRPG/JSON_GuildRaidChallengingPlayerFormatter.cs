// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidChallengingPlayerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000925")]
  public sealed class JSON_GuildRaidChallengingPlayerFormatter : 
    IMessagePackFormatter<JSON_GuildRaidChallengingPlayer>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016DA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016DB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024BD")]
    [Address(RVA = "0xDFD120", Offset = "0xDFBF20", VA = "0x10DFD120")]
    public JSON_GuildRaidChallengingPlayerFormatter()
    {
    }

    [Token(Token = "0x60024BE")]
    [Address(RVA = "0xDFCED0", Offset = "0xDFBCD0", VA = "0x10DFCED0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidChallengingPlayer value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024BF")]
    [Address(RVA = "0xDFCAB0", Offset = "0xDFB8B0", VA = "0x10DFCAB0", Slot = "5")]
    public JSON_GuildRaidChallengingPlayer Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidChallengingPlayer) null;
    }
  }
}
