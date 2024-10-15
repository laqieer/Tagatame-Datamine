// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ConceptLimitUpItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000779")]
  public sealed class ConceptLimitUpItemParamFormatter : 
    IMessagePackFormatter<ConceptLimitUpItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400138A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400138B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FB9")]
    [Address(RVA = "0xCCBC10", Offset = "0xCCAA10", VA = "0x10CCBC10")]
    public ConceptLimitUpItemParamFormatter()
    {
    }

    [Token(Token = "0x6001FBA")]
    [Address(RVA = "0xCCBAE0", Offset = "0xCCA8E0", VA = "0x10CCBAE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ConceptLimitUpItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FBB")]
    [Address(RVA = "0xCCB7D0", Offset = "0xCCA5D0", VA = "0x10CCB7D0", Slot = "5")]
    public ConceptLimitUpItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ConceptLimitUpItemParam) null;
    }
  }
}
