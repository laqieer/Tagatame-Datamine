﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TipsParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000630")]
  public sealed class JSON_TipsParamFormatter : 
    IMessagePackFormatter<JSON_TipsParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BDE")]
    [Address(RVA = "0xBC9080", Offset = "0xBC7E80", VA = "0x10BC9080")]
    public JSON_TipsParamFormatter()
    {
    }

    [Token(Token = "0x6001BDF")]
    [Address(RVA = "0xBC8D60", Offset = "0xBC7B60", VA = "0x10BC8D60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TipsParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BE0")]
    [Address(RVA = "0xBC8880", Offset = "0xBC7680", VA = "0x10BC8880", Slot = "5")]
    public JSON_TipsParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TipsParam) null;
    }
  }
}