﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGLeagueGuildFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005CF")]
  public sealed class JSON_GvGLeagueGuildFormatter : 
    IMessagePackFormatter<JSON_GvGLeagueGuild>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001036")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001037")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001ABB")]
    [Address(RVA = "0x951120", Offset = "0x94FF20", VA = "0x10951120")]
    public JSON_GvGLeagueGuildFormatter()
    {
    }

    [Token(Token = "0x6001ABC")]
    [Address(RVA = "0x950F80", Offset = "0x94FD80", VA = "0x10950F80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGLeagueGuild value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001ABD")]
    [Address(RVA = "0x950C00", Offset = "0x94FA00", VA = "0x10950C00", Slot = "5")]
    public JSON_GvGLeagueGuild Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGLeagueGuild) null;
    }
  }
}