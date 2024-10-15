// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DictionaryFormatterBase`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004AA")]
  public abstract class DictionaryFormatterBase<TKey, TValue, TDictionary> : 
    DictionaryFormatterBase<TKey, TValue, TDictionary, TDictionary>
    where TDictionary : IDictionary<TKey, TValue>
  {
    [Token(Token = "0x60016EA")]
    protected override TDictionary Complete(TDictionary intermediateCollection)
    {
      return (TDictionary) null;
    }

    [Token(Token = "0x60016EB")]
    protected DictionaryFormatterBase()
    {
    }
  }
}
