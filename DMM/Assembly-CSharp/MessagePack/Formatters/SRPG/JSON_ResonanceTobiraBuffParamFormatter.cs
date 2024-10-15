// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceTobiraBuffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006CA")]
  public sealed class JSON_ResonanceTobiraBuffParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceTobiraBuffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400122C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400122D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DAC")]
    [Address(RVA = "0xC1A820", Offset = "0xC19620", VA = "0x10C1A820")]
    public JSON_ResonanceTobiraBuffParamFormatter()
    {
    }

    [Token(Token = "0x6001DAD")]
    [Address(RVA = "0xC1A6C0", Offset = "0xC194C0", VA = "0x10C1A6C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceTobiraBuffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DAE")]
    [Address(RVA = "0xC1A370", Offset = "0xC19170", VA = "0x10C1A370", Slot = "5")]
    public JSON_ResonanceTobiraBuffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceTobiraBuffParam) null;
    }
  }
}
