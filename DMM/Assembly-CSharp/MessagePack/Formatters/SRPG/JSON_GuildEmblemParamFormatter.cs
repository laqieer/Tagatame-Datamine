﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildEmblemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000631")]
  public sealed class JSON_GuildEmblemParamFormatter : 
    IMessagePackFormatter<JSON_GuildEmblemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BE1")]
    [Address(RVA = "0xBBCF00", Offset = "0xBBBD00", VA = "0x10BBCF00")]
    public JSON_GuildEmblemParamFormatter()
    {
    }

    [Token(Token = "0x6001BE2")]
    [Address(RVA = "0xBBCC30", Offset = "0xBBBA30", VA = "0x10BBCC30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildEmblemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BE3")]
    [Address(RVA = "0xBBC7A0", Offset = "0xBBB5A0", VA = "0x10BBC7A0", Slot = "5")]
    public JSON_GuildEmblemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildEmblemParam) null;
    }
  }
}