// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceTobiraBuffRateParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006CB")]
  public sealed class JSON_ResonanceTobiraBuffRateParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceTobiraBuffRateParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400122E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400122F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DAF")]
    [Address(RVA = "0xC1AF30", Offset = "0xC19D30", VA = "0x10C1AF30")]
    public JSON_ResonanceTobiraBuffRateParamFormatter()
    {
    }

    [Token(Token = "0x6001DB0")]
    [Address(RVA = "0xC1AD50", Offset = "0xC19B50", VA = "0x10C1AD50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceTobiraBuffRateParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DB1")]
    [Address(RVA = "0xC1AA10", Offset = "0xC19810", VA = "0x10C1AA10", Slot = "5")]
    public JSON_ResonanceTobiraBuffRateParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceTobiraBuffRateParam) null;
    }
  }
}
