// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.QeueueFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000491")]
  public sealed class QeueueFormatter<T> : 
    CollectionFormatterBase<T, Queue<T>, Queue<T>.Enumerator, Queue<T>>
  {
    [Token(Token = "0x6001680")]
    protected override int? GetCount(Queue<T> sequence) => new int?();

    [Token(Token = "0x6001681")]
    protected override void Add(Queue<T> collection, int index, T value)
    {
    }

    [Token(Token = "0x6001682")]
    protected override Queue<T> Create(int count) => (Queue<T>) null;

    [Token(Token = "0x6001683")]
    protected override Queue<T>.Enumerator GetSourceEnumerator(Queue<T> source)
    {
      return new Queue<T>.Enumerator();
    }

    [Token(Token = "0x6001684")]
    protected override Queue<T> Complete(Queue<T> intermediateCollection) => (Queue<T>) null;

    [Token(Token = "0x6001685")]
    public QeueueFormatter()
    {
    }
  }
}
