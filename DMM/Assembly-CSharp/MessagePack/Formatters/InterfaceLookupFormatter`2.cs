// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceLookupFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000499")]
  public sealed class InterfaceLookupFormatter<TKey, TElement> : 
    CollectionFormatterBase<IGrouping<TKey, TElement>, Dictionary<TKey, IGrouping<TKey, TElement>>, ILookup<TKey, TElement>>
  {
    [Token(Token = "0x60016A5")]
    protected override void Add(
      Dictionary<TKey, IGrouping<TKey, TElement>> collection,
      int index,
      IGrouping<TKey, TElement> value)
    {
    }

    [Token(Token = "0x60016A6")]
    protected override ILookup<TKey, TElement> Complete(
      Dictionary<TKey, IGrouping<TKey, TElement>> intermediateCollection)
    {
      return (ILookup<TKey, TElement>) null;
    }

    [Token(Token = "0x60016A7")]
    protected override Dictionary<TKey, IGrouping<TKey, TElement>> Create(int count)
    {
      return (Dictionary<TKey, IGrouping<TKey, TElement>>) null;
    }

    [Token(Token = "0x60016A8")]
    public InterfaceLookupFormatter()
    {
    }
  }
}
