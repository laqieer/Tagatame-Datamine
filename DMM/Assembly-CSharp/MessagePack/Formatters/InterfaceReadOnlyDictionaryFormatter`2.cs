// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceReadOnlyDictionaryFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004B1")]
  public sealed class InterfaceReadOnlyDictionaryFormatter<TKey, TValue> : 
    DictionaryFormatterBase<TKey, TValue, Dictionary<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
  {
    [Token(Token = "0x6001704")]
    protected override void Add(
      Dictionary<TKey, TValue> collection,
      int index,
      TKey key,
      TValue value)
    {
    }

    [Token(Token = "0x6001705")]
    protected override IReadOnlyDictionary<TKey, TValue> Complete(
      Dictionary<TKey, TValue> intermediateCollection)
    {
      return (IReadOnlyDictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x6001706")]
    protected override Dictionary<TKey, TValue> Create(int count)
    {
      return (Dictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x6001707")]
    public InterfaceReadOnlyDictionaryFormatter()
    {
    }
  }
}
