// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidScoreDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009CD")]
  public sealed class JSON_GuildRaidScoreDataParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidScoreDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400182A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400182B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026B5")]
    [Address(RVA = "0xE70B50", Offset = "0xE6F950", VA = "0x10E70B50")]
    public JSON_GuildRaidScoreDataParamFormatter()
    {
    }

    [Token(Token = "0x60026B6")]
    [Address(RVA = "0xE70A50", Offset = "0xE6F850", VA = "0x10E70A50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidScoreDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026B7")]
    [Address(RVA = "0xE70770", Offset = "0xE6F570", VA = "0x10E70770", Slot = "5")]
    public JSON_GuildRaidScoreDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidScoreDataParam) null;
    }
  }
}
