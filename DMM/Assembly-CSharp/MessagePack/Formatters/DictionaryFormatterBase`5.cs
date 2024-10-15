// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DictionaryFormatterBase`5
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A8")]
  public abstract class DictionaryFormatterBase<TKey, TValue, TIntermediate, TEnumerator, TDictionary> : 
    IMessagePackFormatter<TDictionary>,
    IMessagePackFormatter
    where TEnumerator : IEnumerator<KeyValuePair<TKey, TValue>>
    where TDictionary : IEnumerable<KeyValuePair<TKey, TValue>>
  {
    [Token(Token = "0x60016E1")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TDictionary value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60016E2")]
    public TDictionary Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TDictionary) null;
    }

    [Token(Token = "0x60016E3")]
    protected abstract TEnumerator GetSourceEnumerator(TDictionary source);

    [Token(Token = "0x60016E4")]
    protected abstract TIntermediate Create(int count);

    [Token(Token = "0x60016E5")]
    protected abstract void Add(TIntermediate collection, int index, TKey key, TValue value);

    [Token(Token = "0x60016E6")]
    protected abstract TDictionary Complete(TIntermediate intermediateCollection);

    [Token(Token = "0x60016E7")]
    protected DictionaryFormatterBase()
    {
    }
  }
}
