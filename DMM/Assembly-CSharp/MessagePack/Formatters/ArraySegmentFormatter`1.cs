// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ArraySegmentFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200048A")]
  public sealed class ArraySegmentFormatter<T> : 
    IMessagePackFormatter<ArraySegment<T>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001666")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ArraySegment<T> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001667")]
    public ArraySegment<T> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ArraySegment<T>();
    }

    [Token(Token = "0x6001668")]
    public ArraySegmentFormatter()
    {
    }
  }
}
