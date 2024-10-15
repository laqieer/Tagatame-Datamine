// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidScoreParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009CE")]
  public sealed class JSON_GuildRaidScoreParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidScoreParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400182C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400182D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026B8")]
    [Address(RVA = "0xE71180", Offset = "0xE6FF80", VA = "0x10E71180")]
    public JSON_GuildRaidScoreParamFormatter()
    {
    }

    [Token(Token = "0x60026B9")]
    [Address(RVA = "0xE70FE0", Offset = "0xE6FDE0", VA = "0x10E70FE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidScoreParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026BA")]
    [Address(RVA = "0xE70CD0", Offset = "0xE6FAD0", VA = "0x10E70CD0", Slot = "5")]
    public JSON_GuildRaidScoreParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidScoreParam) null;
    }
  }
}
