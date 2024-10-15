// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidCoolDaysParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A7C")]
  public sealed class JSON_GuildRaidCoolDaysParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidCoolDaysParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001988")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001989")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028C2")]
    [Address(RVA = "0xEDBE50", Offset = "0xEDAC50", VA = "0x10EDBE50")]
    public JSON_GuildRaidCoolDaysParamFormatter()
    {
    }

    [Token(Token = "0x60028C3")]
    [Address(RVA = "0xEDBD20", Offset = "0xEDAB20", VA = "0x10EDBD20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidCoolDaysParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028C4")]
    [Address(RVA = "0xEDBA10", Offset = "0xEDA810", VA = "0x10EDBA10", Slot = "5")]
    public JSON_GuildRaidCoolDaysParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidCoolDaysParam) null;
    }
  }
}
