﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.TupleFormatter`7
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200051A")]
  public sealed class TupleFormatter<T1, T2, T3, T4, T5, T6, T7> : 
    IMessagePackFormatter<Tuple<T1, T2, T3, T4, T5, T6, T7>>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600188D")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Tuple<T1, T2, T3, T4, T5, T6, T7> value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600188E")]
    public Tuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Tuple<T1, T2, T3, T4, T5, T6, T7>) null;
    }

    [Token(Token = "0x600188F")]
    public TupleFormatter()
    {
    }
  }
}