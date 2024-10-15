// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.Lookup`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200049B")]
  internal class Lookup<TKey, TElement> : 
    ILookup<TKey, TElement>,
    IEnumerable<IGrouping<TKey, TElement>>,
    IEnumerable
  {
    [Token(Token = "0x4000F41")]
    [FieldOffset(Offset = "0x0")]
    private readonly Dictionary<TKey, IGrouping<TKey, TElement>> groupings;

    [Token(Token = "0x60016AD")]
    public Lookup(
      Dictionary<TKey, IGrouping<TKey, TElement>> groupings)
    {
    }

    [Token(Token = "0x17000210")]
    public IEnumerable<TElement> this[TKey key]
    {
      [Token(Token = "0x60016AE")] get => (IEnumerable<TElement>) null;
    }

    [Token(Token = "0x17000211")]
    public int Count
    {
      [Token(Token = "0x60016AF")] get => new int();
    }

    [Token(Token = "0x60016B0")]
    public bool Contains(TKey key) => new bool();

    [Token(Token = "0x60016B1")]
    public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
    {
      return (IEnumerator<IGrouping<TKey, TElement>>) null;
    }

    [Token(Token = "0x60016B2")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }
  }
}
