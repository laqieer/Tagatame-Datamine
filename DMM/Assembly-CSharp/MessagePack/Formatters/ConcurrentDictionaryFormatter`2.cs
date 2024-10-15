// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ConcurrentDictionaryFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Concurrent;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004B2")]
  public sealed class ConcurrentDictionaryFormatter<TKey, TValue> : 
    DictionaryFormatterBase<TKey, TValue, ConcurrentDictionary<TKey, TValue>>
  {
    [Token(Token = "0x6001708")]
    protected override void Add(
      ConcurrentDictionary<TKey, TValue> collection,
      int index,
      TKey key,
      TValue value)
    {
    }

    [Token(Token = "0x6001709")]
    protected override ConcurrentDictionary<TKey, TValue> Create(int count)
    {
      return (ConcurrentDictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x600170A")]
    public ConcurrentDictionaryFormatter()
    {
    }
  }
}
