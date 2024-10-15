// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.FastJSON.List
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
  [Token(Token = "0x20035D9")]
  public class List : 
    IList,
    ICollection,
    IEnumerable,
    IList<object>,
    ICollection<object>,
    IEnumerable<object>
  {
    [Token(Token = "0x400FE04")]
    [FieldOffset(Offset = "0x8")]
    private readonly IArray value;
    [Token(Token = "0x400FE05")]
    [FieldOffset(Offset = "0xC")]
    private object[] _elements;

    [Token(Token = "0x17002247")]
    public int Count
    {
      [Token(Token = "0x600EFBC"), Address(RVA = "0xB0BB40", Offset = "0xB0A940", VA = "0x10B0BB40", Slot = "25")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EFBD")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public List(IArray value)
    {
    }

    [Token(Token = "0x600EFBE")]
    [Address(RVA = "0xB0B880", Offset = "0xB0A680", VA = "0x10B0B880")]
    private object[] GetElements(bool create) => (object[]) null;

    [Token(Token = "0x600EFBF")]
    [Address(RVA = "0xB0B830", Offset = "0xB0A630", VA = "0x10B0B830", Slot = "29")]
    public bool Contains(object value) => new bool();

    [Token(Token = "0x600EFC0")]
    [Address(RVA = "0xB0BB00", Offset = "0xB0A900", VA = "0x10B0BB00", Slot = "22")]
    public int IndexOf(object value) => new int();

    [Token(Token = "0x17002248")]
    public object this[int index]
    {
      [Token(Token = "0x600EFC1"), Address(RVA = "0xB0BB90", Offset = "0xB0A990", VA = "0x10B0BB90", Slot = "20")] get
      {
        return (object) null;
      }
      [Token(Token = "0x600EFC2"), Address(RVA = "0xB0BC10", Offset = "0xB0AA10", VA = "0x10B0BC10", Slot = "21")] set
      {
      }
    }

    [Token(Token = "0x600EFC3")]
    [Address(RVA = "0xB0BA90", Offset = "0xB0A890", VA = "0x10B0BA90", Slot = "32")]
    public IEnumerator<object> GetEnumerator() => (IEnumerator<object>) null;

    [Token(Token = "0x600EFC4")]
    [Address(RVA = "0xB0BA90", Offset = "0xB0A890", VA = "0x10B0BA90", Slot = "19")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17002249")]
    public bool IsReadOnly
    {
      [Token(Token = "0x600EFC5"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600EFC6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "30")]
    [Obsolete("not supported.", true)]
    public void CopyTo(object[] dst, int index)
    {
    }

    [Token(Token = "0x600EFC7")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "15")]
    [Obsolete("not supported.", true)]
    private void System\u002ECollections\u002EICollection\u002ECopyTo(Array array, int index)
    {
    }

    [Token(Token = "0x600EFC8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "27")]
    [Obsolete("not supported.", true)]
    public void Add(object value)
    {
    }

    [Token(Token = "0x600EFC9")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "28")]
    [Obsolete("not supported.", true)]
    public void Clear()
    {
    }

    [Token(Token = "0x600EFCA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "23")]
    [Obsolete("not supported.", true)]
    public void Insert(int index, object value)
    {
    }

    [Token(Token = "0x600EFCB")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "31")]
    [Obsolete("not supported.", true)]
    public bool Remove(object value) => new bool();

    [Token(Token = "0x600EFCC")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "24")]
    [Obsolete("not supported.", true)]
    public void RemoveAt(int index)
    {
    }

    [Token(Token = "0x600EFCD")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "6")]
    [Obsolete("not supported.", true)]
    private int System\u002ECollections\u002EIList\u002EAdd(object value) => new int();

    [Token(Token = "0x600EFCE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "13")]
    [Obsolete("not supported.", true)]
    private void System\u002ECollections\u002EIList\u002ERemove(object value)
    {
    }

    [Token(Token = "0x1700224A")]
    private bool System\u002ECollections\u002EIList\u002EIsFixedSize
    {
      [Token(Token = "0x600EFCF"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700224B")]
    private bool System\u002ECollections\u002EICollection\u002EIsSynchronized
    {
      [Token(Token = "0x600EFD0"), Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700224C")]
    private object System\u002ECollections\u002EICollection\u002ESyncRoot
    {
      [Token(Token = "0x600EFD1"), Address(RVA = "0x7DFE90", Offset = "0x7DEC90", VA = "0x107DFE90", Slot = "17")] get
      {
        return (object) null;
      }
    }
  }
}
