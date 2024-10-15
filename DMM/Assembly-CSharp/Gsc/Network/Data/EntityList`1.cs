// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Data.EntityList`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network.Data
{
  [Token(Token = "0x20035B4")]
  public class EntityList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable where T : Entity<T>
  {
    [Token(Token = "0x400FDB7")]
    [FieldOffset(Offset = "0x0")]
    private readonly SortedList<string, T> entityList;

    [Token(Token = "0x1700220A")]
    public bool IsReadOnly
    {
      [Token(Token = "0x600EE75")] get => new bool();
    }

    [Token(Token = "0x1700220B")]
    public int Count
    {
      [Token(Token = "0x600EE76")] get => new int();
    }

    [Token(Token = "0x600EE77")]
    public EntityList(SortedList<string, T> arg)
    {
    }

    [Token(Token = "0x600EE78")]
    public bool ContainsKey(string key) => new bool();

    [Token(Token = "0x600EE79")]
    public bool Contains(T value) => new bool();

    [Token(Token = "0x600EE7A")]
    public bool TryGetValue(string key, out T value) => new bool();

    [Token(Token = "0x600EE7B")]
    public void CopyTo(T[] array, int arrayIndex)
    {
    }

    [Token(Token = "0x600EE7C")]
    public int IndexOf(T value) => new int();

    [Token(Token = "0x600EE7D")]
    public IEnumerator<T> GetEnumerator() => (IEnumerator<T>) null;

    [Token(Token = "0x600EE7E")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x1700220C")]
    public T this[int index]
    {
      [Token(Token = "0x600EE7F")] get => (T) null;
      [Token(Token = "0x600EE80")] set
      {
      }
    }

    [Token(Token = "0x600EE81")]
    private static T CloneEntity(T entity) => (T) null;

    [Token(Token = "0x600EE82")]
    [Obsolete("Not Supported", true)]
    public void Insert(int index, T value)
    {
    }

    [Token(Token = "0x600EE83")]
    [Obsolete("Not Supported", true)]
    public void RemoveAt(int index)
    {
    }

    [Token(Token = "0x600EE84")]
    [Obsolete("Not Supported", true)]
    public void Add(T value)
    {
    }

    [Token(Token = "0x600EE85")]
    [Obsolete("Not Supported", true)]
    public void Clear()
    {
    }

    [Token(Token = "0x600EE86")]
    [Obsolete("Not Supported", true)]
    public bool Remove(T value) => new bool();
  }
}
