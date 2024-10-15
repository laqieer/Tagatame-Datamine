// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceLimitRateListParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A2F")]
  public sealed class ResonanceLimitRateListParamFormatter : 
    IMessagePackFormatter<ResonanceLimitRateListParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027DB")]
    [Address(RVA = "0xEBE4F0", Offset = "0xEBD2F0", VA = "0x10EBE4F0")]
    public ResonanceLimitRateListParamFormatter()
    {
    }

    [Token(Token = "0x60027DC")]
    [Address(RVA = "0xEBE390", Offset = "0xEBD190", VA = "0x10EBE390", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceLimitRateListParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027DD")]
    [Address(RVA = "0xEBE0A0", Offset = "0xEBCEA0", VA = "0x10EBE0A0", Slot = "5")]
    public ResonanceLimitRateListParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceLimitRateListParam) null;
    }
  }
}
