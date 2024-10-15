// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.Grouping`2
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
  [Token(Token = "0x200049A")]
  internal class Grouping<TKey, TElement> : 
    IGrouping<TKey, TElement>,
    IEnumerable<TElement>,
    IEnumerable
  {
    [Token(Token = "0x4000F3F")]
    [FieldOffset(Offset = "0x0")]
    private readonly TKey key;
    [Token(Token = "0x4000F40")]
    [FieldOffset(Offset = "0x0")]
    private readonly IEnumerable<TElement> elements;

    [Token(Token = "0x60016A9")]
    public Grouping(TKey key, IEnumerable<TElement> elements)
    {
    }

    [Token(Token = "0x1700020F")]
    public TKey Key
    {
      [Token(Token = "0x60016AA")] get => (TKey) null;
    }

    [Token(Token = "0x60016AB")]
    public IEnumerator<TElement> GetEnumerator() => (IEnumerator<TElement>) null;

    [Token(Token = "0x60016AC")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }
  }
}
