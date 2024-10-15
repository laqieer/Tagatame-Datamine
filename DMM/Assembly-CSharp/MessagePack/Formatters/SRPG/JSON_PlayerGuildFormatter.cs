// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PlayerGuildFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A2")]
  public sealed class JSON_PlayerGuildFormatter : 
    IMessagePackFormatter<JSON_PlayerGuild>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002334")]
    [Address(RVA = "0xDB3DF0", Offset = "0xDB2BF0", VA = "0x10DB3DF0")]
    public JSON_PlayerGuildFormatter()
    {
    }

    [Token(Token = "0x6002335")]
    [Address(RVA = "0xDB3BA0", Offset = "0xDB29A0", VA = "0x10DB3BA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PlayerGuild value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002336")]
    [Address(RVA = "0xDB3710", Offset = "0xDB2510", VA = "0x10DB3710", Slot = "5")]
    public JSON_PlayerGuild Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PlayerGuild) null;
    }
  }
}
