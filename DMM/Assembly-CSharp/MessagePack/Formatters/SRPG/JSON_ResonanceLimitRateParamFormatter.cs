// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceLimitRateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C9")]
  public sealed class JSON_ResonanceLimitRateParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceLimitRateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400122A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400122B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DA9")]
    [Address(RVA = "0xC19270", Offset = "0xC18070", VA = "0x10C19270")]
    public JSON_ResonanceLimitRateParamFormatter()
    {
    }

    [Token(Token = "0x6001DAA")]
    [Address(RVA = "0xC19090", Offset = "0xC17E90", VA = "0x10C19090", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceLimitRateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DAB")]
    [Address(RVA = "0xC18D50", Offset = "0xC17B50", VA = "0x10C18D50", Slot = "5")]
    public JSON_ResonanceLimitRateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceLimitRateParam) null;
    }
  }
}
