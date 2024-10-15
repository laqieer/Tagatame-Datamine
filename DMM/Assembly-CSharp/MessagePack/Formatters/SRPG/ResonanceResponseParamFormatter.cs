// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceResponseParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200083F")]
  public sealed class ResonanceResponseParamFormatter : 
    IMessagePackFormatter<ResonanceResponseParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400150E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400150F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600220B")]
    [Address(RVA = "0xD80790", Offset = "0xD7F590", VA = "0x10D80790")]
    public ResonanceResponseParamFormatter()
    {
    }

    [Token(Token = "0x600220C")]
    [Address(RVA = "0xD803B0", Offset = "0xD7F1B0", VA = "0x10D803B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceResponseParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600220D")]
    [Address(RVA = "0xD7FF40", Offset = "0xD7ED40", VA = "0x10D7FF40", Slot = "5")]
    public ResonanceResponseParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceResponseParam) null;
    }
  }
}
