// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SortedDictionaryFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004AF")]
  public sealed class SortedDictionaryFormatter<TKey, TValue> : 
    DictionaryFormatterBase<TKey, TValue, SortedDictionary<TKey, TValue>, SortedDictionary<TKey, TValue>.Enumerator, SortedDictionary<TKey, TValue>>
  {
    [Token(Token = "0x60016FB")]
    protected override void Add(
      SortedDictionary<TKey, TValue> collection,
      int index,
      TKey key,
      TValue value)
    {
    }

    [Token(Token = "0x60016FC")]
    protected override SortedDictionary<TKey, TValue> Complete(
      SortedDictionary<TKey, TValue> intermediateCollection)
    {
      return (SortedDictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x60016FD")]
    protected override SortedDictionary<TKey, TValue> Create(int count)
    {
      return (SortedDictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x60016FE")]
    protected override SortedDictionary<TKey, TValue>.Enumerator GetSourceEnumerator(
      SortedDictionary<TKey, TValue> source)
    {
      return new SortedDictionary<TKey, TValue>.Enumerator();
    }

    [Token(Token = "0x60016FF")]
    public SortedDictionaryFormatter()
    {
    }
  }
}
