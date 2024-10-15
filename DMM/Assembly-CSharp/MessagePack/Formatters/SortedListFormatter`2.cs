// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SortedListFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004AE")]
  public sealed class SortedListFormatter<TKey, TValue> : 
    DictionaryFormatterBase<TKey, TValue, SortedList<TKey, TValue>>
  {
    [Token(Token = "0x60016F8")]
    protected override void Add(
      SortedList<TKey, TValue> collection,
      int index,
      TKey key,
      TValue value)
    {
    }

    [Token(Token = "0x60016F9")]
    protected override SortedList<TKey, TValue> Create(int count)
    {
      return (SortedList<TKey, TValue>) null;
    }

    [Token(Token = "0x60016FA")]
    public SortedListFormatter()
    {
    }
  }
}
