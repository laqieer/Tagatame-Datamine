// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.Json.Value
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.DOM.Json
{
  [Token(Token = "0x20035C1")]
  public struct Value : IValue
  {
    [Token(Token = "0x400FDCC")]
    [FieldOffset(Offset = "0x0")]
    private readonly object value;

    [Token(Token = "0x600EEC0")]
    [Address(RVA = "0xB01110", Offset = "0xAFFF10", VA = "0x10B01110")]
    public Value(object value)
    {
    }

    [Token(Token = "0x600EEC1")]
    [Address(RVA = "0xB17190", Offset = "0xB15F90", VA = "0x10B17190", Slot = "4")]
    public bool IsNull() => new bool();

    [Token(Token = "0x600EEC2")]
    [Address(RVA = "0xB171A0", Offset = "0xB15FA0", VA = "0x10B171A0", Slot = "5")]
    public bool IsObject() => new bool();

    [Token(Token = "0x600EEC3")]
    [Address(RVA = "0xB16F70", Offset = "0xB15D70", VA = "0x10B16F70", Slot = "6")]
    public bool IsArray() => new bool();

    [Token(Token = "0x600EEC4")]
    [Address(RVA = "0xB16FB0", Offset = "0xB15DB0", VA = "0x10B16FB0", Slot = "7")]
    public bool IsBool() => new bool();

    [Token(Token = "0x600EEC5")]
    [Address(RVA = "0xB171E0", Offset = "0xB15FE0", VA = "0x10B171E0", Slot = "8")]
    public bool IsString() => new bool();

    [Token(Token = "0x600EEC6")]
    [Address(RVA = "0xB170F0", Offset = "0xB15EF0", VA = "0x10B170F0", Slot = "9")]
    public bool IsInt() => new bool();

    [Token(Token = "0x600EEC7")]
    [Address(RVA = "0xB17230", Offset = "0xB16030", VA = "0x10B17230", Slot = "10")]
    public bool IsUInt() => new bool();

    [Token(Token = "0x600EEC8")]
    [Address(RVA = "0xB17130", Offset = "0xB15F30", VA = "0x10B17130", Slot = "11")]
    public bool IsLong() => new bool();

    [Token(Token = "0x600EEC9")]
    [Address(RVA = "0xB17290", Offset = "0xB16090", VA = "0x10B17290", Slot = "12")]
    public bool IsULong() => new bool();

    [Token(Token = "0x600EECA")]
    [Address(RVA = "0xB17090", Offset = "0xB15E90", VA = "0x10B17090", Slot = "13")]
    public bool IsFloat() => new bool();

    [Token(Token = "0x600EECB")]
    [Address(RVA = "0xB17020", Offset = "0xB15E20", VA = "0x10B17020", Slot = "14")]
    public bool IsDouble() => new bool();

    [Token(Token = "0x600EECC")]
    [Address(RVA = "0xB16A70", Offset = "0xB15870", VA = "0x10B16A70")]
    public Object GetObject() => new Object();

    [Token(Token = "0x600EECD")]
    [Address(RVA = "0xB16A00", Offset = "0xB15800", VA = "0x10B16A00")]
    public Array GetArray() => new Array();

    [Token(Token = "0x600EECE")]
    [Address(RVA = "0xB16D90", Offset = "0xB15B90", VA = "0x10B16D90", Slot = "15")]
    private IObject Gsc\u002EDOM\u002EIValue\u002EGetObject() => (IObject) null;

    [Token(Token = "0x600EECF")]
    [Address(RVA = "0xB16D40", Offset = "0xB15B40", VA = "0x10B16D40", Slot = "16")]
    private IArray Gsc\u002EDOM\u002EIValue\u002EGetArray() => (IArray) null;

    [Token(Token = "0x600EED0")]
    [Address(RVA = "0xB17550", Offset = "0xB16350", VA = "0x10B17550", Slot = "17")]
    public bool ToBool() => new bool();

    [Token(Token = "0x600EED1")]
    [Address(RVA = "0xB178E0", Offset = "0xB166E0", VA = "0x10B178E0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600EED2")]
    [Address(RVA = "0xB17820", Offset = "0xB16620", VA = "0x10B17820", Slot = "19")]
    public int ToInt() => new int();

    [Token(Token = "0x600EED3")]
    [Address(RVA = "0xB17930", Offset = "0xB16730", VA = "0x10B17930", Slot = "20")]
    public uint ToUInt() => new uint();

    [Token(Token = "0x600EED4")]
    [Address(RVA = "0xB17880", Offset = "0xB16680", VA = "0x10B17880", Slot = "21")]
    public long ToLong() => new long();

    [Token(Token = "0x600EED5")]
    [Address(RVA = "0xB17990", Offset = "0xB16790", VA = "0x10B17990", Slot = "22")]
    public ulong ToULong() => new ulong();

    [Token(Token = "0x600EED6")]
    [Address(RVA = "0xB176E0", Offset = "0xB164E0", VA = "0x10B176E0", Slot = "23")]
    public float ToFloat() => new float();

    [Token(Token = "0x600EED7")]
    [Address(RVA = "0xB175B0", Offset = "0xB163B0", VA = "0x10B175B0", Slot = "24")]
    public double ToDouble() => new double();

    [Token(Token = "0x600EED8")]
    [Address(RVA = "0xB16BB0", Offset = "0xB159B0", VA = "0x10B16BB0")]
    public bool GetValueByPointer(string pointer, bool defaultValue) => new bool();

    [Token(Token = "0x600EED9")]
    [Address(RVA = "0xB16AE0", Offset = "0xB158E0", VA = "0x10B16AE0")]
    public string GetValueByPointer(string pointer, string defaultValue) => (string) null;

    [Token(Token = "0x600EEDA")]
    [Address(RVA = "0xB16B70", Offset = "0xB15970", VA = "0x10B16B70")]
    public int GetValueByPointer(string pointer, int defaultValue) => new int();

    [Token(Token = "0x600EEDB")]
    [Address(RVA = "0xB16CC0", Offset = "0xB15AC0", VA = "0x10B16CC0")]
    public uint GetValueByPointer(string pointer, uint defaultValue) => new uint();

    [Token(Token = "0x600EEDC")]
    [Address(RVA = "0xB16B20", Offset = "0xB15920", VA = "0x10B16B20")]
    public long GetValueByPointer(string pointer, long defaultValue) => new long();

    [Token(Token = "0x600EEDD")]
    [Address(RVA = "0xB16D00", Offset = "0xB15B00", VA = "0x10B16D00")]
    public ulong GetValueByPointer(string pointer, ulong defaultValue) => new ulong();

    [Token(Token = "0x600EEDE")]
    [Address(RVA = "0xB16C50", Offset = "0xB15A50", VA = "0x10B16C50")]
    public float GetValueByPointer(string pointer, float defaultValue) => new float();

    [Token(Token = "0x600EEDF")]
    [Address(RVA = "0xB16C00", Offset = "0xB15A00", VA = "0x10B16C00")]
    public double GetValueByPointer(string pointer, double defaultValue) => new double();

    [Token(Token = "0x600EEE0")]
    private T GetValueByPointer<T>(string pointer, T defaultValue) => (T) null;

    [Token(Token = "0x1700221B")]
    public Value this[string name]
    {
      [Token(Token = "0x600EEE1"), Address(RVA = "0xB17A70", Offset = "0xB16870", VA = "0x10B17A70")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x1700221C")]
    public Value this[int index]
    {
      [Token(Token = "0x600EEE2"), Address(RVA = "0xB17B50", Offset = "0xB16950", VA = "0x10B17B50")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x600EEE3")]
    [Address(RVA = "0xB16ED0", Offset = "0xB15CD0", VA = "0x10B16ED0", Slot = "26")]
    private IValue Gsc\u002EDOM\u002EIValue\u002Eget_Item(string name) => (IValue) null;

    [Token(Token = "0x600EEE4")]
    [Address(RVA = "0xB16F20", Offset = "0xB15D20", VA = "0x10B16F20", Slot = "25")]
    private IValue Gsc\u002EDOM\u002EIValue\u002Eget_Item(int index) => (IValue) null;

    [Token(Token = "0x600EEE5")]
    [Address(RVA = "0xB17E90", Offset = "0xB16C90", VA = "0x10B17E90")]
    public static explicit operator bool(Value self) => new bool();

    [Token(Token = "0x600EEE6")]
    [Address(RVA = "0xB17D90", Offset = "0xB16B90", VA = "0x10B17D90")]
    public static explicit operator string(Value self) => (string) null;

    [Token(Token = "0x600EEE7")]
    [Address(RVA = "0xB17CA0", Offset = "0xB16AA0", VA = "0x10B17CA0")]
    public static explicit operator int(Value self) => new int();

    [Token(Token = "0x600EEE8")]
    [Address(RVA = "0xB17D20", Offset = "0xB16B20", VA = "0x10B17D20")]
    public static explicit operator uint(Value self) => new uint();

    [Token(Token = "0x600EEE9")]
    [Address(RVA = "0xB17C40", Offset = "0xB16A40", VA = "0x10B17C40")]
    public static explicit operator long(Value self) => new long();

    [Token(Token = "0x600EEEA")]
    [Address(RVA = "0xB17DE0", Offset = "0xB16BE0", VA = "0x10B17DE0")]
    public static explicit operator ulong(Value self) => new ulong();

    [Token(Token = "0x600EEEB")]
    [Address(RVA = "0xB17E40", Offset = "0xB16C40", VA = "0x10B17E40")]
    public static explicit operator float(Value self) => new float();

    [Token(Token = "0x600EEEC")]
    [Address(RVA = "0xB17E60", Offset = "0xB16C60", VA = "0x10B17E60")]
    public static explicit operator double(Value self) => new double();
  }
}
