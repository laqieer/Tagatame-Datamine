// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.GenericCollectionFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200048F")]
  public sealed class GenericCollectionFormatter<TElement, TCollection> : 
    CollectionFormatterBase<TElement, TCollection>
    where TCollection : ICollection<TElement>, new()
  {
    [Token(Token = "0x6001678")]
    protected override TCollection Create(int count) => (TCollection) null;

    [Token(Token = "0x6001679")]
    protected override void Add(TCollection collection, int index, TElement value)
    {
    }

    [Token(Token = "0x600167A")]
    public GenericCollectionFormatter()
    {
    }
  }
}
