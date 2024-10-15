// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.LinkedListFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000490")]
  public sealed class LinkedListFormatter<T> : 
    CollectionFormatterBase<T, LinkedList<T>, LinkedList<T>.Enumerator, LinkedList<T>>
  {
    [Token(Token = "0x600167B")]
    protected override void Add(LinkedList<T> collection, int index, T value)
    {
    }

    [Token(Token = "0x600167C")]
    protected override LinkedList<T> Complete(LinkedList<T> intermediateCollection)
    {
      return (LinkedList<T>) null;
    }

    [Token(Token = "0x600167D")]
    protected override LinkedList<T> Create(int count) => (LinkedList<T>) null;

    [Token(Token = "0x600167E")]
    protected override LinkedList<T>.Enumerator GetSourceEnumerator(LinkedList<T> source)
    {
      return new LinkedList<T>.Enumerator();
    }

    [Token(Token = "0x600167F")]
    public LinkedListFormatter()
    {
    }
  }
}
