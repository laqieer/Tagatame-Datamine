// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.InterfaceDictionaryFormatter`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004AD")]
  public sealed class InterfaceDictionaryFormatter<TKey, TValue> : 
    DictionaryFormatterBase<TKey, TValue, Dictionary<TKey, TValue>, IDictionary<TKey, TValue>>
  {
    [Token(Token = "0x60016F4")]
    protected override void Add(
      Dictionary<TKey, TValue> collection,
      int index,
      TKey key,
      TValue value)
    {
    }

    [Token(Token = "0x60016F5")]
    protected override Dictionary<TKey, TValue> Create(int count)
    {
      return (Dictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x60016F6")]
    protected override IDictionary<TKey, TValue> Complete(
      Dictionary<TKey, TValue> intermediateCollection)
    {
      return (IDictionary<TKey, TValue>) null;
    }

    [Token(Token = "0x60016F7")]
    public InterfaceDictionaryFormatter()
    {
    }
  }
}
