// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WeatherSetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A73")]
  public sealed class JSON_WeatherSetParamFormatter : 
    IMessagePackFormatter<JSON_WeatherSetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001976")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001977")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028A7")]
    [Address(RVA = "0xED0EA0", Offset = "0xECFCA0", VA = "0x10ED0EA0")]
    public JSON_WeatherSetParamFormatter()
    {
    }

    [Token(Token = "0x60028A8")]
    [Address(RVA = "0xED0B40", Offset = "0xECF940", VA = "0x10ED0B40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WeatherSetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028A9")]
    [Address(RVA = "0xED0630", Offset = "0xECF430", VA = "0x10ED0630", Slot = "5")]
    public JSON_WeatherSetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WeatherSetParam) null;
    }
  }
}
