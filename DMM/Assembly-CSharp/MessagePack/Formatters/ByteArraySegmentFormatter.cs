// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ByteArraySegmentFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000489")]
  public sealed class ByteArraySegmentFormatter : 
    IMessagePackFormatter<ArraySegment<byte>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F3E")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ByteArraySegmentFormatter Instance;

    [Token(Token = "0x6001662")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ByteArraySegmentFormatter()
    {
    }

    [Token(Token = "0x6001663")]
    [Address(RVA = "0x696900", Offset = "0x695700", VA = "0x10696900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ArraySegment<byte> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001664")]
    [Address(RVA = "0x696800", Offset = "0x695600", VA = "0x10696800", Slot = "5")]
    public ArraySegment<byte> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ArraySegment<byte>();
    }

    [Token(Token = "0x6001665")]
    [Address(RVA = "0x6969D0", Offset = "0x6957D0", VA = "0x106969D0")]
    static ByteArraySegmentFormatter()
    {
    }
  }
}
