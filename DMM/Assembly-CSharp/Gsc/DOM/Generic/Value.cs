// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Generic.Value
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Runtime.InteropServices;

#nullable disable
namespace Gsc.DOM.Generic
{
  [Token(Token = "0x20035D6")]
  public struct Value : IValue
  {
    [Token(Token = "0x400FDFB")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    private Value.InternalValue value;
    [Token(Token = "0x400FDFC")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
    private ValueType valueType;

    [Token(Token = "0x600EF76")]
    [Address(RVA = "0xB17350", Offset = "0xB16150", VA = "0x10B17350")]
    public void SetNull()
    {
    }

    [Token(Token = "0x600EF77")]
    [Address(RVA = "0xB17370", Offset = "0xB16170", VA = "0x10B17370")]
    public Object SetObject() => (Object) null;

    [Token(Token = "0x600EF78")]
    [Address(RVA = "0xB172F0", Offset = "0xB160F0", VA = "0x10B172F0")]
    public Array SetArray() => (Array) null;

    [Token(Token = "0x600EF79")]
    [Address(RVA = "0xB17410", Offset = "0xB16210", VA = "0x10B17410")]
    public void Set(bool b)
    {
    }

    [Token(Token = "0x600EF7A")]
    [Address(RVA = "0xB174F0", Offset = "0xB162F0", VA = "0x10B174F0")]
    public void Set(string s)
    {
    }

    [Token(Token = "0x600EF7B")]
    [Address(RVA = "0xB17450", Offset = "0xB16250", VA = "0x10B17450")]
    public void Set(int i)
    {
    }

    [Token(Token = "0x600EF7C")]
    [Address(RVA = "0xB17470", Offset = "0xB16270", VA = "0x10B17470")]
    public void Set(uint i)
    {
    }

    [Token(Token = "0x600EF7D")]
    [Address(RVA = "0xB174D0", Offset = "0xB162D0", VA = "0x10B174D0")]
    public void Set(long i)
    {
    }

    [Token(Token = "0x600EF7E")]
    [Address(RVA = "0xB17430", Offset = "0xB16230", VA = "0x10B17430")]
    public void Set(ulong i)
    {
    }

    [Token(Token = "0x600EF7F")]
    [Address(RVA = "0xB17490", Offset = "0xB16290", VA = "0x10B17490")]
    public void Set(float f)
    {
    }

    [Token(Token = "0x600EF80")]
    [Address(RVA = "0xB173F0", Offset = "0xB161F0", VA = "0x10B173F0")]
    public void Set(double d)
    {
    }

    [Token(Token = "0x600EF81")]
    [Address(RVA = "0xB173D0", Offset = "0xB161D0", VA = "0x10B173D0")]
    private void Set(long i, ValueType t)
    {
    }

    [Token(Token = "0x600EF82")]
    [Address(RVA = "0xB173D0", Offset = "0xB161D0", VA = "0x10B173D0")]
    private void Set(ulong i, ValueType t)
    {
    }

    [Token(Token = "0x600EF83")]
    [Address(RVA = "0xB174B0", Offset = "0xB162B0", VA = "0x10B174B0")]
    private void Set(double d, ValueType t)
    {
    }

    [Token(Token = "0x600EF84")]
    [Address(RVA = "0xB17510", Offset = "0xB16310", VA = "0x10B17510")]
    private void Set(Object o)
    {
    }

    [Token(Token = "0x600EF85")]
    [Address(RVA = "0xB17530", Offset = "0xB16330", VA = "0x10B17530")]
    private void Set(Array a)
    {
    }

    [Token(Token = "0x600EF86")]
    [Address(RVA = "0x4F7560", Offset = "0x4F6360", VA = "0x104F7560", Slot = "4")]
    public bool IsNull() => new bool();

    [Token(Token = "0x600EF87")]
    [Address(RVA = "0x4F7530", Offset = "0x4F6330", VA = "0x104F7530", Slot = "5")]
    public bool IsObject() => new bool();

    [Token(Token = "0x600EF88")]
    [Address(RVA = "0x4F7550", Offset = "0x4F6350", VA = "0x104F7550", Slot = "6")]
    public bool IsArray() => new bool();

    [Token(Token = "0x600EF89")]
    [Address(RVA = "0xB16FF0", Offset = "0xB15DF0", VA = "0x10B16FF0", Slot = "7")]
    public bool IsBool() => new bool();

    [Token(Token = "0x600EF8A")]
    [Address(RVA = "0xB17220", Offset = "0xB16020", VA = "0x10B17220", Slot = "8")]
    public bool IsString() => new bool();

    [Token(Token = "0x600EF8B")]
    [Address(RVA = "0x3F4970", Offset = "0x3F3770", VA = "0x103F4970", Slot = "9")]
    public bool IsInt() => new bool();

    [Token(Token = "0x600EF8C")]
    [Address(RVA = "0xB17270", Offset = "0xB16070", VA = "0x10B17270", Slot = "10")]
    public bool IsUInt() => new bool();

    [Token(Token = "0x600EF8D")]
    [Address(RVA = "0xB17170", Offset = "0xB15F70", VA = "0x10B17170", Slot = "11")]
    public bool IsLong() => new bool();

    [Token(Token = "0x600EF8E")]
    [Address(RVA = "0xB172D0", Offset = "0xB160D0", VA = "0x10B172D0", Slot = "12")]
    public bool IsULong() => new bool();

    [Token(Token = "0x600EF8F")]
    [Address(RVA = "0xB17070", Offset = "0xB15E70", VA = "0x10B17070", Slot = "13")]
    public bool IsFloat() => new bool();

    [Token(Token = "0x600EF90")]
    [Address(RVA = "0xB17000", Offset = "0xB15E00", VA = "0x10B17000", Slot = "14")]
    public bool IsDouble() => new bool();

    [Token(Token = "0x600EF91")]
    [Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060")]
    public Object GetObject() => (Object) null;

    [Token(Token = "0x600EF92")]
    [Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060")]
    public Array GetArray() => (Array) null;

    [Token(Token = "0x600EF93")]
    [Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060", Slot = "15")]
    private IObject Gsc\u002EDOM\u002EIValue\u002EGetObject() => (IObject) null;

    [Token(Token = "0x600EF94")]
    [Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060", Slot = "16")]
    private IArray Gsc\u002EDOM\u002EIValue\u002EGetArray() => (IArray) null;

    [Token(Token = "0x600EF95")]
    [Address(RVA = "0x28E4D0", Offset = "0x28D2D0", VA = "0x1028E4D0", Slot = "17")]
    public bool ToBool() => new bool();

    [Token(Token = "0x600EF96")]
    [Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600EF97")]
    [Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060", Slot = "19")]
    public int ToInt() => new int();

    [Token(Token = "0x600EF98")]
    [Address(RVA = "0x294060", Offset = "0x292E60", VA = "0x10294060", Slot = "20")]
    public uint ToUInt() => new uint();

    [Token(Token = "0x600EF99")]
    [Address(RVA = "0x5BE900", Offset = "0x5BD700", VA = "0x105BE900", Slot = "21")]
    public long ToLong() => new long();

    [Token(Token = "0x600EF9A")]
    [Address(RVA = "0x5BE900", Offset = "0x5BD700", VA = "0x105BE900", Slot = "22")]
    public ulong ToULong() => new ulong();

    [Token(Token = "0x600EF9B")]
    [Address(RVA = "0xB17810", Offset = "0xB16610", VA = "0x10B17810", Slot = "23")]
    public float ToFloat() => new float();

    [Token(Token = "0x600EF9C")]
    [Address(RVA = "0xB176D0", Offset = "0xB164D0", VA = "0x10B176D0", Slot = "24")]
    public double ToDouble() => new double();

    [Token(Token = "0x600EF9D")]
    [Address(RVA = "0xB16CA0", Offset = "0xB15AA0", VA = "0x10B16CA0")]
    public bool GetValueByPointer(string pointer, bool defaultValue) => new bool();

    [Token(Token = "0x600EF9E")]
    [Address(RVA = "0x5953A0", Offset = "0x5941A0", VA = "0x105953A0")]
    public string GetValueByPointer(string pointer, string defaultValue) => (string) null;

    [Token(Token = "0x600EF9F")]
    [Address(RVA = "0x5953A0", Offset = "0x5941A0", VA = "0x105953A0")]
    public int GetValueByPointer(string pointer, int defaultValue) => new int();

    [Token(Token = "0x600EFA0")]
    [Address(RVA = "0x5953A0", Offset = "0x5941A0", VA = "0x105953A0")]
    public uint GetValueByPointer(string pointer, uint defaultValue) => new uint();

    [Token(Token = "0x600EFA1")]
    [Address(RVA = "0xB16B60", Offset = "0xB15960", VA = "0x10B16B60")]
    public long GetValueByPointer(string pointer, long defaultValue) => new long();

    [Token(Token = "0x600EFA2")]
    [Address(RVA = "0xB16B60", Offset = "0xB15960", VA = "0x10B16B60")]
    public ulong GetValueByPointer(string pointer, ulong defaultValue) => new ulong();

    [Token(Token = "0x600EFA3")]
    [Address(RVA = "0xB16BF0", Offset = "0xB159F0", VA = "0x10B16BF0")]
    public float GetValueByPointer(string pointer, float defaultValue) => new float();

    [Token(Token = "0x600EFA4")]
    [Address(RVA = "0xB16CB0", Offset = "0xB15AB0", VA = "0x10B16CB0")]
    public double GetValueByPointer(string pointer, double defaultValue) => new double();

    [Token(Token = "0x17002243")]
    public Value this[string name]
    {
      [Token(Token = "0x600EFA5"), Address(RVA = "0xB179F0", Offset = "0xB167F0", VA = "0x10B179F0")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x17002244")]
    public Value this[int index]
    {
      [Token(Token = "0x600EFA6"), Address(RVA = "0xB17BE0", Offset = "0xB169E0", VA = "0x10B17BE0")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x600EFA7")]
    [Address(RVA = "0xB16DE0", Offset = "0xB15BE0", VA = "0x10B16DE0", Slot = "26")]
    private IValue Gsc\u002EDOM\u002EIValue\u002Eget_Item(string name) => (IValue) null;

    [Token(Token = "0x600EFA8")]
    [Address(RVA = "0xB16E40", Offset = "0xB15C40", VA = "0x10B16E40", Slot = "25")]
    private IValue Gsc\u002EDOM\u002EIValue\u002Eget_Item(int index) => (IValue) null;

    [Token(Token = "0x600EFA9")]
    [Address(RVA = "0xB17F20", Offset = "0xB16D20", VA = "0x10B17F20")]
    public static implicit operator Value(Object o) => new Value();

    [Token(Token = "0x600EFAA")]
    [Address(RVA = "0xB17F70", Offset = "0xB16D70", VA = "0x10B17F70")]
    public static implicit operator Value(Array a) => new Value();

    [Token(Token = "0x600EFAB")]
    [Address(RVA = "0xB17F50", Offset = "0xB16D50", VA = "0x10B17F50")]
    public static implicit operator Value(bool b) => new Value();

    [Token(Token = "0x600EFAC")]
    [Address(RVA = "0xB17FF0", Offset = "0xB16DF0", VA = "0x10B17FF0")]
    public static implicit operator Value(string s) => new Value();

    [Token(Token = "0x600EFAD")]
    [Address(RVA = "0xB17FC0", Offset = "0xB16DC0", VA = "0x10B17FC0")]
    public static implicit operator Value(int i) => new Value();

    [Token(Token = "0x600EFAE")]
    [Address(RVA = "0xB18050", Offset = "0xB16E50", VA = "0x10B18050")]
    public static implicit operator Value(uint i) => new Value();

    [Token(Token = "0x600EFAF")]
    [Address(RVA = "0xB18020", Offset = "0xB16E20", VA = "0x10B18020")]
    public static implicit operator Value(long i) => new Value();

    [Token(Token = "0x600EFB0")]
    [Address(RVA = "0xB18080", Offset = "0xB16E80", VA = "0x10B18080")]
    public static implicit operator Value(ulong i) => new Value();

    [Token(Token = "0x600EFB1")]
    [Address(RVA = "0xB17EF0", Offset = "0xB16CF0", VA = "0x10B17EF0")]
    public static implicit operator Value(float f) => new Value();

    [Token(Token = "0x600EFB2")]
    [Address(RVA = "0xB17FA0", Offset = "0xB16DA0", VA = "0x10B17FA0")]
    public static implicit operator Value(double d) => new Value();

    [Token(Token = "0x600EFB3")]
    [Address(RVA = "0x866950", Offset = "0x865750", VA = "0x10866950")]
    public static explicit operator bool(Value self) => new bool();

    [Token(Token = "0x600EFB4")]
    [Address(RVA = "0x7DFE90", Offset = "0x7DEC90", VA = "0x107DFE90")]
    public static explicit operator string(Value self) => (string) null;

    [Token(Token = "0x600EFB5")]
    [Address(RVA = "0x7DFE90", Offset = "0x7DEC90", VA = "0x107DFE90")]
    public static explicit operator int(Value self) => new int();

    [Token(Token = "0x600EFB6")]
    [Address(RVA = "0x7DFE90", Offset = "0x7DEC90", VA = "0x107DFE90")]
    public static explicit operator uint(Value self) => new uint();

    [Token(Token = "0x600EFB7")]
    [Address(RVA = "0xB17D80", Offset = "0xB16B80", VA = "0x10B17D80")]
    public static explicit operator long(Value self) => new long();

    [Token(Token = "0x600EFB8")]
    [Address(RVA = "0xB17D80", Offset = "0xB16B80", VA = "0x10B17D80")]
    public static explicit operator ulong(Value self) => new ulong();

    [Token(Token = "0x600EFB9")]
    [Address(RVA = "0xB17D00", Offset = "0xB16B00", VA = "0x10B17D00")]
    public static explicit operator float(Value self) => new float();

    [Token(Token = "0x600EFBA")]
    [Address(RVA = "0xB17E80", Offset = "0xB16C80", VA = "0x10B17E80")]
    public static explicit operator double(Value self) => new double();

    [Token(Token = "0x20035D7")]
    [StructLayout(LayoutKind.Explicit)]
    private struct InternalValue
    {
      [Token(Token = "0x400FDFD")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public Object o;
      [Token(Token = "0x400FDFE")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public Array a;
      [Token(Token = "0x400FDFF")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public double d;
      [Token(Token = "0x400FE00")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public long l;
      [Token(Token = "0x400FE01")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public ulong ul;
      [Token(Token = "0x400FE02")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public string s;
      [Token(Token = "0x400FE03")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public bool b;
    }
  }
}
