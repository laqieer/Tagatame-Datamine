// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidKnockDownInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A64")]
  public sealed class JSON_GuildRaidKnockDownInfoFormatter : 
    IMessagePackFormatter<JSON_GuildRaidKnockDownInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001958")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001959")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600287A")]
    [Address(RVA = "0xEC8740", Offset = "0xEC7540", VA = "0x10EC8740")]
    public JSON_GuildRaidKnockDownInfoFormatter()
    {
    }

    [Token(Token = "0x600287B")]
    [Address(RVA = "0xEC85E0", Offset = "0xEC73E0", VA = "0x10EC85E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidKnockDownInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600287C")]
    [Address(RVA = "0xEC8290", Offset = "0xEC7090", VA = "0x10EC8290", Slot = "5")]
    public JSON_GuildRaidKnockDownInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidKnockDownInfo) null;
    }
  }
}
