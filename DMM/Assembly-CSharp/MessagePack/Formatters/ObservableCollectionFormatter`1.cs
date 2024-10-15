// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ObservableCollectionFormatter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.ObjectModel;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A0")]
  public sealed class ObservableCollectionFormatter<T> : 
    CollectionFormatterBase<T, ObservableCollection<T>>
  {
    [Token(Token = "0x60016C1")]
    protected override void Add(ObservableCollection<T> collection, int index, T value)
    {
    }

    [Token(Token = "0x60016C2")]
    protected override ObservableCollection<T> Create(int count) => (ObservableCollection<T>) null;

    [Token(Token = "0x60016C3")]
    public ObservableCollectionFormatter()
    {
    }
  }
}
