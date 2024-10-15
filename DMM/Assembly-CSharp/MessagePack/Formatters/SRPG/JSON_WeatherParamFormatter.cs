// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WeatherParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000603")]
  public sealed class JSON_WeatherParamFormatter : 
    IMessagePackFormatter<JSON_WeatherParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400109E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400109F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B57")]
    [Address(RVA = "0xBB3BB0", Offset = "0xBB29B0", VA = "0x10BB3BB0")]
    public JSON_WeatherParamFormatter()
    {
    }

    [Token(Token = "0x6001B58")]
    [Address(RVA = "0xBB37C0", Offset = "0xBB25C0", VA = "0x10BB37C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WeatherParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B59")]
    [Address(RVA = "0xBB3290", Offset = "0xBB2090", VA = "0x10BB3290", Slot = "5")]
    public JSON_WeatherParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WeatherParam) null;
    }
  }
}
