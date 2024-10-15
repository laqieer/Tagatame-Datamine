// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.GenericDictionaryFormatter`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004AC")]
  public sealed class GenericDictionaryFormatter<TKey, TValue, TDictionary> : 
    DictionaryFormatterBase<TKey, TValue, TDictionary>
    where TDictionary : IDictionary<TKey, TValue>, new()
  {
    [Token(Token = "0x60016F1")]
    protected override void Add(TDictionary collection, int index, TKey key, TValue value)
    {
    }

    [Token(Token = "0x60016F2")]
    protected override TDictionary Create(int count) => (TDictionary) null;

    [Token(Token = "0x60016F3")]
    public GenericDictionaryFormatter()
    {
    }
  }
}
