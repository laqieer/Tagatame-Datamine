// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ElementParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200073F")]
  public sealed class ElementParamFormatter : 
    IMessagePackFormatter<ElementParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001316")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001317")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F0B")]
    [Address(RVA = "0xC7FEA0", Offset = "0xC7ECA0", VA = "0x10C7FEA0")]
    public ElementParamFormatter()
    {
    }

    [Token(Token = "0x6001F0C")]
    [Address(RVA = "0xC7FBA0", Offset = "0xC7E9A0", VA = "0x10C7FBA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ElementParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F0D")]
    [Address(RVA = "0xC7F740", Offset = "0xC7E540", VA = "0x10C7F740", Slot = "5")]
    public ElementParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ElementParam) null;
    }
  }
}
