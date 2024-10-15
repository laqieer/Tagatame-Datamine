// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.TupleFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000515")]
  public sealed class TupleFormatter<T1, T2> : 
    IMessagePackFormatter<Tuple<T1, T2>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600187E")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Tuple<T1, T2> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600187F")]
    public Tuple<T1, T2> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Tuple<T1, T2>) null;
    }

    [Token(Token = "0x6001880")]
    public TupleFormatter()
    {
    }
  }
}
