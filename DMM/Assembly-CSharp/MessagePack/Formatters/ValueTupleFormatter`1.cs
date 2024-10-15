// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ValueTupleFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000522")]
  public sealed class ValueTupleFormatter<T1> : 
    IMessagePackFormatter<ValueTuple<T1>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60018B2")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ValueTuple<T1> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018B3")]
    public ValueTuple<T1> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return ();
    }

    [Token(Token = "0x60018B4")]
    public ValueTupleFormatter()
    {
    }
  }
}
