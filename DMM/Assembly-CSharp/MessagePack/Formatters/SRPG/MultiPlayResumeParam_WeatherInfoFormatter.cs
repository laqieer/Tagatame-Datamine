// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayResumeParam_WeatherInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000751")]
  public sealed class MultiPlayResumeParam_WeatherInfoFormatter : 
    IMessagePackFormatter<MultiPlayResumeParam.WeatherInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400133A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400133B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F41")]
    [Address(RVA = "0xC97960", Offset = "0xC96760", VA = "0x10C97960")]
    public MultiPlayResumeParam_WeatherInfoFormatter()
    {
    }

    [Token(Token = "0x6001F42")]
    [Address(RVA = "0xC97660", Offset = "0xC96460", VA = "0x10C97660", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayResumeParam.WeatherInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F43")]
    [Address(RVA = "0xC97210", Offset = "0xC96010", VA = "0x10C97210", Slot = "5")]
    public MultiPlayResumeParam.WeatherInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayResumeParam.WeatherInfo) null;
    }
  }
}
