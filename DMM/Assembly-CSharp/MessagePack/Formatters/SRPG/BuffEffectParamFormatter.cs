// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffEffectParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200077C")]
  public sealed class BuffEffectParamFormatter : 
    IMessagePackFormatter<BuffEffectParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001390")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001391")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FC2")]
    [Address(RVA = "0xCC37A0", Offset = "0xCC25A0", VA = "0x10CC37A0")]
    public BuffEffectParamFormatter()
    {
    }

    [Token(Token = "0x6001FC3")]
    [Address(RVA = "0xCC2B40", Offset = "0xCC1940", VA = "0x10CC2B40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffEffectParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FC4")]
    [Address(RVA = "0xCC20F0", Offset = "0xCC0EF0", VA = "0x10CC20F0", Slot = "5")]
    public BuffEffectParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (BuffEffectParam) null;
    }
  }
}
