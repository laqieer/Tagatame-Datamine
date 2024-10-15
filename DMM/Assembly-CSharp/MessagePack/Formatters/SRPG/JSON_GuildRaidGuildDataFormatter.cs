// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidGuildDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A66")]
  public sealed class JSON_GuildRaidGuildDataFormatter : 
    IMessagePackFormatter<JSON_GuildRaidGuildData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400195C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400195D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002880")]
    [Address(RVA = "0xEC7800", Offset = "0xEC6600", VA = "0x10EC7800")]
    public JSON_GuildRaidGuildDataFormatter()
    {
    }

    [Token(Token = "0x6002881")]
    [Address(RVA = "0xEC7570", Offset = "0xEC6370", VA = "0x10EC7570", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidGuildData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002882")]
    [Address(RVA = "0xEC7110", Offset = "0xEC5F10", VA = "0x10EC7110", Slot = "5")]
    public JSON_GuildRaidGuildData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidGuildData) null;
    }
  }
}
