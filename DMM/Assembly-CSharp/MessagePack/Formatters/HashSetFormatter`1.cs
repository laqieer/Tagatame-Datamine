// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.HashSetFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000493")]
  public sealed class HashSetFormatter<T> : 
    CollectionFormatterBase<T, HashSet<T>, HashSet<T>.Enumerator, HashSet<T>>
  {
    [Token(Token = "0x600168C")]
    protected override int? GetCount(HashSet<T> sequence) => new int?();

    [Token(Token = "0x600168D")]
    protected override void Add(HashSet<T> collection, int index, T value)
    {
    }

    [Token(Token = "0x600168E")]
    protected override HashSet<T> Complete(HashSet<T> intermediateCollection) => (HashSet<T>) null;

    [Token(Token = "0x600168F")]
    protected override HashSet<T> Create(int count) => (HashSet<T>) null;

    [Token(Token = "0x6001690")]
    protected override HashSet<T>.Enumerator GetSourceEnumerator(HashSet<T> source)
    {
      return new HashSet<T>.Enumerator();
    }

    [Token(Token = "0x6001691")]
    public HashSetFormatter()
    {
    }
  }
}
