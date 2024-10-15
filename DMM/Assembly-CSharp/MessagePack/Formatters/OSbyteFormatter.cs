// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OSbyteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000534")]
  public sealed class OSbyteFormatter : IMessagePackFormatter<OSbyte>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FC4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FC5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018EA")]
    [Address(RVA = "0x6A6A70", Offset = "0x6A5870", VA = "0x106A6A70")]
    public OSbyteFormatter()
    {
    }

    [Token(Token = "0x60018EB")]
    [Address(RVA = "0x6A6A20", Offset = "0x6A5820", VA = "0x106A6A20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OSbyte value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018EC")]
    [Address(RVA = "0x6A6780", Offset = "0x6A5580", VA = "0x106A6780", Slot = "5")]
    public OSbyte Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OSbyte();
    }
  }
}
