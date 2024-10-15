// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceReadOnlyCollectionFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A3")]
  public sealed class InterfaceReadOnlyCollectionFormatter<T> : 
    CollectionFormatterBase<T, T[], IReadOnlyCollection<T>>
  {
    [Token(Token = "0x60016CC")]
    protected override void Add(T[] collection, int index, T value)
    {
    }

    [Token(Token = "0x60016CD")]
    protected override T[] Create(int count) => (T[]) null;

    [Token(Token = "0x60016CE")]
    protected override IReadOnlyCollection<T> Complete(T[] intermediateCollection)
    {
      return (IReadOnlyCollection<T>) null;
    }

    [Token(Token = "0x60016CF")]
    public InterfaceReadOnlyCollectionFormatter()
    {
    }
  }
}
