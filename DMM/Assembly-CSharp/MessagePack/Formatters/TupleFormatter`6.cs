// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.TupleFormatter`6
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000519")]
  public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6> : 
    IMessagePackFormatter<Tuple<T1, T2, T3, T4, T5, T6>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600188A")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Tuple<T1, T2, T3, T4, T5, T6> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600188B")]
    public Tuple<T1, T2, T3, T4, T5, T6> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Tuple<T1, T2, T3, T4, T5, T6>) null;
    }

    [Token(Token = "0x600188C")]
    public TupleFormatter()
    {
    }
  }
}
