// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C2")]
  public sealed class JSON_ResonanceUnitParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400121C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400121D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D94")]
    [Address(RVA = "0xC1B5F0", Offset = "0xC1A3F0", VA = "0x10C1B5F0")]
    public JSON_ResonanceUnitParamFormatter()
    {
    }

    [Token(Token = "0x6001D95")]
    [Address(RVA = "0xC1B440", Offset = "0xC1A240", VA = "0x10C1B440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D96")]
    [Address(RVA = "0xC1B0B0", Offset = "0xC19EB0", VA = "0x10C1B0B0", Slot = "5")]
    public JSON_ResonanceUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceUnitParam) null;
    }
  }
}
