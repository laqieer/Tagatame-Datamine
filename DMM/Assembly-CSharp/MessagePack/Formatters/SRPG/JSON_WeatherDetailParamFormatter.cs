// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WeatherDetailParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000602")]
  public sealed class JSON_WeatherDetailParamFormatter : 
    IMessagePackFormatter<JSON_WeatherDetailParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400109C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400109D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B54")]
    [Address(RVA = "0xBB2E10", Offset = "0xBB1C10", VA = "0x10BB2E10")]
    public JSON_WeatherDetailParamFormatter()
    {
    }

    [Token(Token = "0x6001B55")]
    [Address(RVA = "0xBB2AA0", Offset = "0xBB18A0", VA = "0x10BB2AA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WeatherDetailParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B56")]
    [Address(RVA = "0xBB2570", Offset = "0xBB1370", VA = "0x10BB2570", Slot = "5")]
    public JSON_WeatherDetailParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WeatherDetailParam) null;
    }
  }
}
