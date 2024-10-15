// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.LazyFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200050F")]
  public sealed class LazyFormatter<T> : IMessagePackFormatter<Lazy<T>>, IMessagePackFormatter
  {
    [Token(Token = "0x600186C")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Lazy<T> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600186D")]
    public Lazy<T> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Lazy<T>) null;
    }

    [Token(Token = "0x600186E")]
    public LazyFormatter()
    {
    }
  }
}
