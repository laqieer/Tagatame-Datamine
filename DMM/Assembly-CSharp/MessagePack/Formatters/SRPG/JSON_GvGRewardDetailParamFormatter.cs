﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGRewardDetailParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E0")]
  public sealed class JSON_GvGRewardDetailParamFormatter : 
    IMessagePackFormatter<JSON_GvGRewardDetailParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001450")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001451")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020EE")]
    [Address(RVA = "0xD17710", Offset = "0xD16510", VA = "0x10D17710")]
    public JSON_GvGRewardDetailParamFormatter()
    {
    }

    [Token(Token = "0x60020EF")]
    [Address(RVA = "0xD175B0", Offset = "0xD163B0", VA = "0x10D175B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGRewardDetailParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020F0")]
    [Address(RVA = "0xD17260", Offset = "0xD16060", VA = "0x10D17260", Slot = "5")]
    public JSON_GvGRewardDetailParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGRewardDetailParam) null;
    }
  }
}