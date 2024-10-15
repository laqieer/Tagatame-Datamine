// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OIntVector2Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000532")]
  public sealed class OIntVector2Formatter : 
    IMessagePackFormatter<OIntVector2>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FC0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FC1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018E4")]
    [Address(RVA = "0x6A6280", Offset = "0x6A5080", VA = "0x106A6280")]
    public OIntVector2Formatter()
    {
    }

    [Token(Token = "0x60018E5")]
    [Address(RVA = "0x6A6140", Offset = "0x6A4F40", VA = "0x106A6140", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OIntVector2 value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018E6")]
    [Address(RVA = "0x6A5DD0", Offset = "0x6A4BD0", VA = "0x106A5DD0", Slot = "5")]
    public OIntVector2 Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OIntVector2();
    }
  }
}
