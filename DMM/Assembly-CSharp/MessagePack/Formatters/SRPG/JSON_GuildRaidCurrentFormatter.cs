// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidCurrentFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A61")]
  public sealed class JSON_GuildRaidCurrentFormatter : 
    IMessagePackFormatter<JSON_GuildRaidCurrent>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001952")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001953")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002871")]
    [Address(RVA = "0xEC6310", Offset = "0xEC5110", VA = "0x10EC6310")]
    public JSON_GuildRaidCurrentFormatter()
    {
    }

    [Token(Token = "0x6002872")]
    [Address(RVA = "0xEC61E0", Offset = "0xEC4FE0", VA = "0x10EC61E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidCurrent value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002873")]
    [Address(RVA = "0xEC5EC0", Offset = "0xEC4CC0", VA = "0x10EC5EC0", Slot = "5")]
    public JSON_GuildRaidCurrent Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidCurrent) null;
    }
  }
}
