// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ConcurrentStackFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Concurrent;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A7")]
  public sealed class ConcurrentStackFormatter<T> : 
    CollectionFormatterBase<T, T[], ConcurrentStack<T>>
  {
    [Token(Token = "0x60016DC")]
    protected override int? GetCount(ConcurrentStack<T> sequence) => new int?();

    [Token(Token = "0x60016DD")]
    protected override void Add(T[] collection, int index, T value)
    {
    }

    [Token(Token = "0x60016DE")]
    protected override T[] Create(int count) => (T[]) null;

    [Token(Token = "0x60016DF")]
    protected override ConcurrentStack<T> Complete(T[] intermediateCollection)
    {
      return (ConcurrentStack<T>) null;
    }

    [Token(Token = "0x60016E0")]
    public ConcurrentStackFormatter()
    {
    }
  }
}
