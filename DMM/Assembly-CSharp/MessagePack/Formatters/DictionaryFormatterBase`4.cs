// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DictionaryFormatterBase`4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004A9")]
  public abstract class DictionaryFormatterBase<TKey, TValue, TIntermediate, TDictionary> : 
    DictionaryFormatterBase<TKey, TValue, TIntermediate, IEnumerator<KeyValuePair<TKey, TValue>>, TDictionary>
    where TDictionary : IEnumerable<KeyValuePair<TKey, TValue>>
  {
    [Token(Token = "0x60016E8")]
    protected override IEnumerator<KeyValuePair<TKey, TValue>> GetSourceEnumerator(
      TDictionary source)
    {
      return (IEnumerator<KeyValuePair<TKey, TValue>>) null;
    }

    [Token(Token = "0x60016E9")]
    protected DictionaryFormatterBase()
    {
    }
  }
}
