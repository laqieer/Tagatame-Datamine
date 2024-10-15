// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.HomeUnitVoiceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A0E")]
  public sealed class HomeUnitVoiceParamFormatter : 
    IMessagePackFormatter<HomeUnitVoiceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002778")]
    [Address(RVA = "0xE9E1A0", Offset = "0xE9CFA0", VA = "0x10E9E1A0")]
    public HomeUnitVoiceParamFormatter()
    {
    }

    [Token(Token = "0x6002779")]
    [Address(RVA = "0xE9E040", Offset = "0xE9CE40", VA = "0x10E9E040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      HomeUnitVoiceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600277A")]
    [Address(RVA = "0xE9DD30", Offset = "0xE9CB30", VA = "0x10E9DD30", Slot = "5")]
    public HomeUnitVoiceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (HomeUnitVoiceParam) null;
    }
  }
}
