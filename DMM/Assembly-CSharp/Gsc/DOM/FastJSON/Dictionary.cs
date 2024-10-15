// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.FastJSON.Dictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.DOM.FastJSON
{
  [Token(Token = "0x20035DB")]
  public class Dictionary : 
    IDictionary,
    ICollection,
    IEnumerable,
    IDictionary<string, object>,
    ICollection<KeyValuePair<string, object>>,
    IEnumerable<KeyValuePair<string, object>>
  {
    [Token(Token = "0x400FE0B")]
    [FieldOffset(Offset = "0x8")]
    private readonly Dictionary<string, object> values;

    [Token(Token = "0x1700224F")]
    public int Count
    {
      [Token(Token = "0x600EFD8"), Address(RVA = "0xB05540", Offset = "0xB04340", VA = "0x10B05540", Slot = "27")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002250")]
    public ICollection<string> Keys
    {
      [Token(Token = "0x600EFD9"), Address(RVA = "0xB055D0", Offset = "0xB043D0", VA = "0x10B055D0", Slot = "22")] get
      {
        return (ICollection<string>) null;
      }
    }

    [Token(Token = "0x17002251")]
    private ICollection System\u002ECollections\u002EIDictionary\u002EKeys
    {
      [Token(Token = "0x600EFDA"), Address(RVA = "0xB050E0", Offset = "0xB03EE0", VA = "0x10B050E0", Slot = "6")] get
      {
        return (ICollection) null;
      }
    }

    [Token(Token = "0x17002252")]
    public ICollection<object> Values
    {
      [Token(Token = "0x600EFDB"), Address(RVA = "0xB05610", Offset = "0xB04410", VA = "0x10B05610", Slot = "23")] get
      {
        return (ICollection<object>) null;
      }
    }

    [Token(Token = "0x17002253")]
    private ICollection System\u002ECollections\u002EIDictionary\u002EValues
    {
      [Token(Token = "0x600EFDC"), Address(RVA = "0xB05120", Offset = "0xB03F20", VA = "0x10B05120", Slot = "7")] get
      {
        return (ICollection) null;
      }
    }

    [Token(Token = "0x600EFDD")]
    [Address(RVA = "0xB051F0", Offset = "0xB03FF0", VA = "0x10B051F0")]
    public Dictionary(IObject value)
    {
    }

    [Token(Token = "0x17002254")]
    public object this[string key]
    {
      [Token(Token = "0x600EFDE"), Address(RVA = "0xB05580", Offset = "0xB04380", VA = "0x10B05580", Slot = "20")] get
      {
        return (object) null;
      }
      [Token(Token = "0x600EFDF"), Address(RVA = "0xB05650", Offset = "0xB04450", VA = "0x10B05650", Slot = "21")] set
      {
      }
    }

    [Token(Token = "0x600EFE0")]
    [Address(RVA = "0xB05070", Offset = "0xB03E70", VA = "0x10B05070", Slot = "4")]
    private object System\u002ECollections\u002EIDictionary\u002Eget_Item(object key)
    {
      return (object) null;
    }

    [Token(Token = "0x600EFE1")]
    [Address(RVA = "0xB05160", Offset = "0xB03F60", VA = "0x10B05160", Slot = "5")]
    private void System\u002ECollections\u002EIDictionary\u002Eset_Item(object key, object value)
    {
    }

    [Token(Token = "0x600EFE2")]
    [Address(RVA = "0xB04EA0", Offset = "0xB03CA0", VA = "0x10B04EA0", Slot = "24")]
    public bool ContainsKey(string key) => new bool();

    [Token(Token = "0x600EFE3")]
    [Address(RVA = "0xB04F70", Offset = "0xB03D70", VA = "0x10B04F70", Slot = "8")]
    private bool System\u002ECollections\u002EIDictionary\u002EContains(object key) => new bool();

    [Token(Token = "0x600EFE4")]
    [Address(RVA = "0xB051A0", Offset = "0xB03FA0", VA = "0x10B051A0", Slot = "26")]
    public bool TryGetValue(string key, out object value) => new bool();

    [Token(Token = "0x600EFE5")]
    [Address(RVA = "0xB04EF0", Offset = "0xB03CF0", VA = "0x10B04EF0", Slot = "34")]
    public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
    {
      return (IEnumerator<KeyValuePair<string, object>>) null;
    }

    [Token(Token = "0x600EFE6")]
    [Address(RVA = "0xB04EF0", Offset = "0xB03CF0", VA = "0x10B04EF0", Slot = "19")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600EFE7")]
    [Address(RVA = "0xB04FF0", Offset = "0xB03DF0", VA = "0x10B04FF0", Slot = "13")]
    private IDictionaryEnumerator System\u002ECollections\u002EIDictionary\u002EGetEnumerator()
    {
      return (IDictionaryEnumerator) null;
    }

    [Token(Token = "0x17002256")]
    public bool IsReadOnly
    {
      [Token(Token = "0x600EFE8"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "28")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002257")]
    private bool System\u002ECollections\u002EIDictionary\u002EIsFixedSize
    {
      [Token(Token = "0x600EFE9"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002258")]
    private bool System\u002ECollections\u002EICollection\u002EIsSynchronized
    {
      [Token(Token = "0x600EFEA"), Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002259")]
    private object System\u002ECollections\u002EICollection\u002ESyncRoot
    {
      [Token(Token = "0x600EFEB"), Address(RVA = "0x7DFE90", Offset = "0x7DEC90", VA = "0x107DFE90", Slot = "17")] get
      {
        return (object) null;
      }
    }

    [Token(Token = "0x600EFEC")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "31")]
    [Obsolete("not supported.", true)]
    public bool Contains(KeyValuePair<string, object> member) => new bool();

    [Token(Token = "0x600EFED")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "32")]
    [Obsolete("not supported.", true)]
    public void CopyTo(KeyValuePair<string, object>[] dst, int index)
    {
    }

    [Token(Token = "0x600EFEE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "15")]
    [Obsolete("not supported.", true)]
    private void System\u002ECollections\u002EICollection\u002ECopyTo(Array array, int index)
    {
    }

    [Token(Token = "0x600EFEF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "25")]
    [Obsolete("not supported.", true)]
    public void Add(string key, object value)
    {
    }

    [Token(Token = "0x600EFF0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "29")]
    [Obsolete("not supported.", true)]
    public void Add(KeyValuePair<string, object> member)
    {
    }

    [Token(Token = "0x600EFF1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "30")]
    [Obsolete("not supported.", true)]
    public void Clear()
    {
    }

    [Token(Token = "0x600EFF2")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "35")]
    [Obsolete("not supported.", true)]
    public bool Remove(string key) => new bool();

    [Token(Token = "0x600EFF3")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "33")]
    [Obsolete("not supported.", true)]
    public bool Remove(KeyValuePair<string, object> member) => new bool();

    [Token(Token = "0x600EFF4")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
    [Obsolete("not supported.", true)]
    private void System\u002ECollections\u002EIDictionary\u002EAdd(object key, object value)
    {
    }

    [Token(Token = "0x600EFF5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "14")]
    [Obsolete("not supported.", true)]
    private void System\u002ECollections\u002EIDictionary\u002ERemove(object key)
    {
    }
  }
}
