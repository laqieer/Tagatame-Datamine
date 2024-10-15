// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WeatherReleaseParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000605")]
  public sealed class JSON_WeatherReleaseParamFormatter : 
    IMessagePackFormatter<JSON_WeatherReleaseParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B5D")]
    [Address(RVA = "0xBB4BD0", Offset = "0xBB39D0", VA = "0x10BB4BD0")]
    public JSON_WeatherReleaseParamFormatter()
    {
    }

    [Token(Token = "0x6001B5E")]
    [Address(RVA = "0xBB49B0", Offset = "0xBB37B0", VA = "0x10BB49B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WeatherReleaseParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B5F")]
    [Address(RVA = "0xBB4630", Offset = "0xBB3430", VA = "0x10BB4630", Slot = "5")]
    public JSON_WeatherReleaseParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WeatherReleaseParam) null;
    }
  }
}
