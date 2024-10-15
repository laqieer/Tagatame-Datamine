// Decompiled with JetBrains decompiler
// Type: SRPG.ParamDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BE3")]
  public class ParamDictionary<TKey, TValue>
  {
    [Token(Token = "0x4006BDD")]
    [FieldOffset(Offset = "0x0")]
    public Dictionary<TKey, TValue> m_Dictionary;

    [Token(Token = "0x17000E42")]
    public TValue this[TKey key]
    {
      [Token(Token = "0x600730A")] get => (TValue) null;
      [Token(Token = "0x600730B")] set
      {
      }
    }

    [Token(Token = "0x600730C")]
    public ParamDictionary()
    {
    }

    [Token(Token = "0x600730D")]
    public ParamDictionary(int capacity)
    {
    }

    [Token(Token = "0x17000E43")]
    public int Count
    {
      [Token(Token = "0x600730E")] get => new int();
    }

    [Token(Token = "0x17000E44")]
    public Dictionary<TKey, TValue>.KeyCollection Keys
    {
      [Token(Token = "0x600730F")] get => (Dictionary<TKey, TValue>.KeyCollection) null;
    }

    [Token(Token = "0x17000E45")]
    public Dictionary<TKey, TValue>.ValueCollection Values
    {
      [Token(Token = "0x6007310")] get => (Dictionary<TKey, TValue>.ValueCollection) null;
    }

    [Token(Token = "0x6007311")]
    public void AddSafe(TKey key, TValue value)
    {
    }

    [Token(Token = "0x6007312")]
    public bool TryGetValue(TKey key, out TValue value) => new bool();

    [Token(Token = "0x6007313")]
    public bool ContainsKey(TKey key) => new bool();

    [Token(Token = "0x6007314")]
    public bool ContainsValue(TValue value) => new bool();

    [Token(Token = "0x6007315")]
    public void Clear()
    {
    }
  }
}
