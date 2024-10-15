// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OShortFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000535")]
  public sealed class OShortFormatter : IMessagePackFormatter<OShort>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FC6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FC7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018ED")]
    [Address(RVA = "0x6A6DF0", Offset = "0x6A5BF0", VA = "0x106A6DF0")]
    public OShortFormatter()
    {
    }

    [Token(Token = "0x60018EE")]
    [Address(RVA = "0x6A6DA0", Offset = "0x6A5BA0", VA = "0x106A6DA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OShort value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018EF")]
    [Address(RVA = "0x6A6B00", Offset = "0x6A5900", VA = "0x106A6B00", Slot = "5")]
    public OShort Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OShort();
    }
  }
}
