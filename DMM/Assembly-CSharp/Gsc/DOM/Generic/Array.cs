// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Generic.Array
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.DOM.Generic
{
  [Token(Token = "0x20035CD")]
  public class Array : IArray, IEnumerable<IValue>, IEnumerable, IEnumerable<Value>
  {
    [Token(Token = "0x400FDE5")]
    [FieldOffset(Offset = "0x8")]
    private readonly List<Value> values;

    [Token(Token = "0x17002230")]
    public int Length
    {
      [Token(Token = "0x600EF39"), Address(RVA = "0xB01240", Offset = "0xB00040", VA = "0x10B01240", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EF3A")]
    [Address(RVA = "0xB010A0", Offset = "0xAFFEA0", VA = "0x10B010A0")]
    public Array()
    {
    }

    [Token(Token = "0x600EF3B")]
    [Address(RVA = "0xB00DC0", Offset = "0xAFFBC0", VA = "0x10B00DC0", Slot = "8")]
    public IEnumerator<Value> GetEnumerator() => (IEnumerator<Value>) null;

    [Token(Token = "0x600EF3C")]
    [Address(RVA = "0xB01020", Offset = "0xAFFE20", VA = "0x10B01020", Slot = "6")]
    private IEnumerator<IValue> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CGsc\u002EDOM\u002EIValue\u003E\u002EGetEnumerator()
    {
      return (IEnumerator<IValue>) null;
    }

    [Token(Token = "0x600EF3D")]
    [Address(RVA = "0xB00DC0", Offset = "0xAFFBC0", VA = "0x10B00DC0", Slot = "7")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600EF3E")]
    [Address(RVA = "0xB00D20", Offset = "0xAFFB20", VA = "0x10B00D20", Slot = "9")]
    public virtual void Add(Value value)
    {
    }

    [Token(Token = "0x17002231")]
    public Value this[int index]
    {
      [Token(Token = "0x600EF3F"), Address(RVA = "0xB01190", Offset = "0xAFFF90", VA = "0x10B01190")] get
      {
        return new Value();
      }
      [Token(Token = "0x600EF40"), Address(RVA = "0xB01280", Offset = "0xB00080", VA = "0x10B01280")] set
      {
      }
    }

    [Token(Token = "0x600EF41")]
    [Address(RVA = "0xB00EA0", Offset = "0xAFFCA0", VA = "0x10B00EA0", Slot = "5")]
    private IValue Gsc\u002EDOM\u002EIArray\u002Eget_Item(int index) => (IValue) null;
  }
}
