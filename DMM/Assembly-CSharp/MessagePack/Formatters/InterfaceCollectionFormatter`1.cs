// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceCollectionFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000496")]
  public sealed class InterfaceCollectionFormatter<T> : 
    CollectionFormatterBase<T, T[], ICollection<T>>
  {
    [Token(Token = "0x600169A")]
    protected override void Add(T[] collection, int index, T value)
    {
    }

    [Token(Token = "0x600169B")]
    protected override T[] Create(int count) => (T[]) null;

    [Token(Token = "0x600169C")]
    protected override ICollection<T> Complete(T[] intermediateCollection) => (ICollection<T>) null;

    [Token(Token = "0x600169D")]
    public InterfaceCollectionFormatter()
    {
    }
  }
}
