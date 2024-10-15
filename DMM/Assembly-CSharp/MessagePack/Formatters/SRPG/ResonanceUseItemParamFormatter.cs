// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceUseItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000847")]
  public sealed class ResonanceUseItemParamFormatter : 
    IMessagePackFormatter<ResonanceUseItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400151E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400151F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002223")]
    [Address(RVA = "0xD80EA0", Offset = "0xD7FCA0", VA = "0x10D80EA0")]
    public ResonanceUseItemParamFormatter()
    {
    }

    [Token(Token = "0x6002224")]
    [Address(RVA = "0xD80D70", Offset = "0xD7FB70", VA = "0x10D80D70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceUseItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002225")]
    [Address(RVA = "0xD80A60", Offset = "0xD7F860", VA = "0x10D80A60", Slot = "5")]
    public ResonanceUseItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceUseItemParam) null;
    }
  }
}
