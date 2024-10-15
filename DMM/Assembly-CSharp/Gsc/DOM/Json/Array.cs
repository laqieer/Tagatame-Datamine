// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Json.Array
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Gsc.DOM.Json
{
  [Token(Token = "0x20035C8")]
  public struct Array : IArray, IEnumerable<IValue>, IEnumerable, IEnumerable<Value>
  {
    [Token(Token = "0x400FDDC")]
    [FieldOffset(Offset = "0x0")]
    private readonly IList<object> value;

    [Token(Token = "0x17002229")]
    public int Length
    {
      [Token(Token = "0x600EF15"), Address(RVA = "0xB011F0", Offset = "0xAFFFF0", VA = "0x10B011F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600EF16")]
    [Address(RVA = "0xB01110", Offset = "0xAFFF10", VA = "0x10B01110")]
    public Array(IList<object> value)
    {
    }

    [Token(Token = "0x600EF17")]
    [Address(RVA = "0xB00E30", Offset = "0xAFFC30", VA = "0x10B00E30", Slot = "8")]
    public IEnumerator<Value> GetEnumerator() => (IEnumerator<Value>) null;

    [Token(Token = "0x600EF18")]
    [Address(RVA = "0xB00FB0", Offset = "0xAFFDB0", VA = "0x10B00FB0", Slot = "6")]
    private IEnumerator<IValue> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CGsc\u002EDOM\u002EIValue\u003E\u002EGetEnumerator()
    {
      return (IEnumerator<IValue>) null;
    }

    [Token(Token = "0x600EF19")]
    [Address(RVA = "0xB01090", Offset = "0xAFFE90", VA = "0x10B01090", Slot = "7")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x1700222A")]
    public Value this[int index]
    {
      [Token(Token = "0x600EF1A"), Address(RVA = "0xB01130", Offset = "0xAFFF30", VA = "0x10B01130")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x600EF1B")]
    [Address(RVA = "0xB00F20", Offset = "0xAFFD20", VA = "0x10B00F20", Slot = "5")]
    private IValue Gsc\u002EDOM\u002EIArray\u002Eget_Item(int index) => (IValue) null;
  }
}
