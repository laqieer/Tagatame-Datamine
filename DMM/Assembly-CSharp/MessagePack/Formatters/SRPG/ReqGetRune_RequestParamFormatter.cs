﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqGetRune_RequestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000989")]
  public sealed class ReqGetRune_RequestParamFormatter : 
    IMessagePackFormatter<ReqGetRune.RequestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025E9")]
    [Address(RVA = "0xE40C60", Offset = "0xE3FA60", VA = "0x10E40C60")]
    public ReqGetRune_RequestParamFormatter()
    {
    }

    [Token(Token = "0x60025EA")]
    [Address(RVA = "0xE40BA0", Offset = "0xE3F9A0", VA = "0x10E40BA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqGetRune.RequestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025EB")]
    [Address(RVA = "0xE408E0", Offset = "0xE3F6E0", VA = "0x10E408E0", Slot = "5")]
    public ReqGetRune.RequestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqGetRune.RequestParam) null;
    }
  }
}