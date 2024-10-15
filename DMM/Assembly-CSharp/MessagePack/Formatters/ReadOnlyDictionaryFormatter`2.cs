// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ReadOnlyDictionaryFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004B0")]
  public sealed class ReadOnlyDictionaryFormatter<TKey, TValue> : 
    DictionaryFormatterBase<TKey, TValue, Dictionary<TKey, TValue>, ReadOnlyDictionary<TKey, TValue>>
  {
    [Token(Token = "0x6001700")]
    protected override void Add(
      Dictionary<TKey, TValue> collection,
      int index,
      TKey key,
      TValue value)
    {
    }

    [Token(Token = "0x6001701")]
    protected override ReadOnlyDictionary<TKey, TValue> Complete(
      Dictionary<TKey, TValue> intermediateCollection)
    {
      return (ReadOnlyDictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x6001702")]
    protected override Dictionary<TKey, TValue> Create(int count)
    {
      return (Dictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x6001703")]
    public ReadOnlyDictionaryFormatter()
    {
    }
  }
}
