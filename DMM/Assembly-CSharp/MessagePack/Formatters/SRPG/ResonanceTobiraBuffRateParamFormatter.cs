// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceTobiraBuffRateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000983")]
  public sealed class ResonanceTobiraBuffRateParamFormatter : 
    IMessagePackFormatter<ResonanceTobiraBuffRateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001796")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001797")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025D7")]
    [Address(RVA = "0xE35D50", Offset = "0xE34B50", VA = "0x10E35D50")]
    public ResonanceTobiraBuffRateParamFormatter()
    {
    }

    [Token(Token = "0x60025D8")]
    [Address(RVA = "0xE35B70", Offset = "0xE34970", VA = "0x10E35B70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceTobiraBuffRateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025D9")]
    [Address(RVA = "0xE35860", Offset = "0xE34660", VA = "0x10E35860", Slot = "5")]
    public ResonanceTobiraBuffRateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceTobiraBuffRateParam) null;
    }
  }
}
