// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.TupleFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000514")]
  public sealed class TupleFormatter<T1> : IMessagePackFormatter<Tuple<T1>>, IMessagePackFormatter
  {
    [Token(Token = "0x600187B")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Tuple<T1> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600187C")]
    public Tuple<T1> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Tuple<T1>) null;
    }

    [Token(Token = "0x600187D")]
    public TupleFormatter()
    {
    }
  }
}
