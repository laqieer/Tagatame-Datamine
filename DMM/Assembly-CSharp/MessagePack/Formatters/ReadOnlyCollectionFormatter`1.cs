// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ReadOnlyCollectionFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.ObjectModel;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000494")]
  public sealed class ReadOnlyCollectionFormatter<T> : 
    CollectionFormatterBase<T, T[], ReadOnlyCollection<T>>
  {
    [Token(Token = "0x6001692")]
    protected override void Add(T[] collection, int index, T value)
    {
    }

    [Token(Token = "0x6001693")]
    protected override ReadOnlyCollection<T> Complete(T[] intermediateCollection)
    {
      return (ReadOnlyCollection<T>) null;
    }

    [Token(Token = "0x6001694")]
    protected override T[] Create(int count) => (T[]) null;

    [Token(Token = "0x6001695")]
    public ReadOnlyCollectionFormatter()
    {
    }
  }
}
