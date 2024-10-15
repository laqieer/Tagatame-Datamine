// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.StackFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000492")]
  public sealed class StackFormatter<T> : 
    CollectionFormatterBase<T, T[], Stack<T>.Enumerator, Stack<T>>
  {
    [Token(Token = "0x6001686")]
    protected override int? GetCount(Stack<T> sequence) => new int?();

    [Token(Token = "0x6001687")]
    protected override void Add(T[] collection, int index, T value)
    {
    }

    [Token(Token = "0x6001688")]
    protected override T[] Create(int count) => (T[]) null;

    [Token(Token = "0x6001689")]
    protected override Stack<T>.Enumerator GetSourceEnumerator(Stack<T> source)
    {
      return new Stack<T>.Enumerator();
    }

    [Token(Token = "0x600168A")]
    protected override Stack<T> Complete(T[] intermediateCollection) => (Stack<T>) null;

    [Token(Token = "0x600168B")]
    public StackFormatter()
    {
    }
  }
}
