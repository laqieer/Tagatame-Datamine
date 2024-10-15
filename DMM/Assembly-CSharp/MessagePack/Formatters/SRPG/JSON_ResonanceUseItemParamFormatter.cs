// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ResonanceUseItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C4")]
  public sealed class JSON_ResonanceUseItemParamFormatter : 
    IMessagePackFormatter<JSON_ResonanceUseItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001220")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001221")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D9A")]
    [Address(RVA = "0xC1BC20", Offset = "0xC1AA20", VA = "0x10C1BC20")]
    public JSON_ResonanceUseItemParamFormatter()
    {
    }

    [Token(Token = "0x6001D9B")]
    [Address(RVA = "0xC1BAF0", Offset = "0xC1A8F0", VA = "0x10C1BAF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ResonanceUseItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D9C")]
    [Address(RVA = "0xC1B7E0", Offset = "0xC1A5E0", VA = "0x10C1B7E0", Slot = "5")]
    public JSON_ResonanceUseItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ResonanceUseItemParam) null;
    }
  }
}
