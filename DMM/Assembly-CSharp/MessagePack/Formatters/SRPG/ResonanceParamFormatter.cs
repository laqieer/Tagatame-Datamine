// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AE4")]
  public sealed class ResonanceParamFormatter : 
    IMessagePackFormatter<ResonanceParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A58")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A59")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029FA")]
    [Address(RVA = "0xF302B0", Offset = "0xF2F0B0", VA = "0x10F302B0")]
    public ResonanceParamFormatter()
    {
    }

    [Token(Token = "0x60029FB")]
    [Address(RVA = "0xF30010", Offset = "0xF2EE10", VA = "0x10F30010", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029FC")]
    [Address(RVA = "0xF2FD00", Offset = "0xF2EB00", VA = "0x10F2FD00", Slot = "5")]
    public ResonanceParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceParam) null;
    }
  }
}
