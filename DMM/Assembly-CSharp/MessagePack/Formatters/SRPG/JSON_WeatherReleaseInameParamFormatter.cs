﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WeatherReleaseInameParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000604")]
  public sealed class JSON_WeatherReleaseInameParamFormatter : 
    IMessagePackFormatter<JSON_WeatherReleaseInameParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B5A")]
    [Address(RVA = "0xBB44B0", Offset = "0xBB32B0", VA = "0x10BB44B0")]
    public JSON_WeatherReleaseInameParamFormatter()
    {
    }

    [Token(Token = "0x6001B5B")]
    [Address(RVA = "0xBB4360", Offset = "0xBB3160", VA = "0x10BB4360", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WeatherReleaseInameParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B5C")]
    [Address(RVA = "0xBB4030", Offset = "0xBB2E30", VA = "0x10BB4030", Slot = "5")]
    public JSON_WeatherReleaseInameParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WeatherReleaseInameParam) null;
    }
  }
}