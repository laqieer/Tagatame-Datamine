// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceLimitRateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A30")]
  public sealed class ResonanceLimitRateParamFormatter : 
    IMessagePackFormatter<ResonanceLimitRateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027DE")]
    [Address(RVA = "0xEBEBD0", Offset = "0xEBD9D0", VA = "0x10EBEBD0")]
    public ResonanceLimitRateParamFormatter()
    {
    }

    [Token(Token = "0x60027DF")]
    [Address(RVA = "0xEBE9F0", Offset = "0xEBD7F0", VA = "0x10EBE9F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceLimitRateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027E0")]
    [Address(RVA = "0xEBE6E0", Offset = "0xEBD4E0", VA = "0x10EBE6E0", Slot = "5")]
    public ResonanceLimitRateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceLimitRateParam) null;
    }
  }
}
