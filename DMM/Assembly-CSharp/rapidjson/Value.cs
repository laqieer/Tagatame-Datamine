// Decompiled with JetBrains decompiler
// Type: rapidjson.Value
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace rapidjson
{
  [Token(Token = "0x2003514")]
  public struct Value
  {
    [Token(Token = "0x400FC02")]
    [FieldOffset(Offset = "0x0")]
    private readonly Document doc;
    [Token(Token = "0x400FC03")]
    [FieldOffset(Offset = "0x4")]
    private IntPtr ptr;

    [Token(Token = "0x600EA95")]
    [Address(RVA = "0xAFDBB0", Offset = "0xAFC9B0", VA = "0x10AFDBB0")]
    public Value(Document doc, ref IntPtr ptr)
    {
    }

    [Token(Token = "0x600EA96")]
    [Address(RVA = "0xAFC580", Offset = "0xAFB380", VA = "0x10AFC580")]
    public Object GetObject() => (Object) null;

    [Token(Token = "0x600EA97")]
    [Address(RVA = "0xAFC9E0", Offset = "0xAFB7E0", VA = "0x10AFC9E0")]
    public bool IsAllocated() => new bool();

    [Token(Token = "0x600EA98")]
    [Address(RVA = "0xAFCF40", Offset = "0xAFBD40", VA = "0x10AFCF40")]
    public bool IsObject() => new bool();

    [Token(Token = "0x600EA99")]
    [Address(RVA = "0xAFC410", Offset = "0xAFB210", VA = "0x10AFC410")]
    public Array GetArray() => (Array) null;

    [Token(Token = "0x600EA9A")]
    [Address(RVA = "0xAFCA30", Offset = "0xAFB830", VA = "0x10AFCA30")]
    public bool IsArray() => new bool();

    [Token(Token = "0x17002171")]
    public Value this[string name]
    {
      [Token(Token = "0x600EA9B"), Address(RVA = "0xAFDD90", Offset = "0xAFCB90", VA = "0x10AFDD90")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x17002172")]
    public Value this[int index]
    {
      [Token(Token = "0x600EA9C"), Address(RVA = "0xAFDBE0", Offset = "0xAFC9E0", VA = "0x10AFDBE0")] get
      {
        return new Value();
      }
    }

    [Token(Token = "0x600EA9D")]
    [Address(RVA = "0xAFDE60", Offset = "0xAFCC60", VA = "0x10AFDE60")]
    public static explicit operator int(Value self) => new int();

    [Token(Token = "0x600EA9E")]
    [Address(RVA = "0xAFD510", Offset = "0xAFC310", VA = "0x10AFD510")]
    public int ToInt() => new int();

    [Token(Token = "0x600EA9F")]
    [Address(RVA = "0xAFCCF0", Offset = "0xAFBAF0", VA = "0x10AFCCF0")]
    public bool IsInt() => new bool();

    [Token(Token = "0x600EAA0")]
    [Address(RVA = "0xAFDF00", Offset = "0xAFCD00", VA = "0x10AFDF00")]
    public static explicit operator uint(Value self) => new uint();

    [Token(Token = "0x600EAA1")]
    [Address(RVA = "0xAFD820", Offset = "0xAFC620", VA = "0x10AFD820")]
    public uint ToUInt() => new uint();

    [Token(Token = "0x600EAA2")]
    [Address(RVA = "0xAFD0A0", Offset = "0xAFBEA0", VA = "0x10AFD0A0")]
    public bool IsUInt() => new bool();

    [Token(Token = "0x600EAA3")]
    [Address(RVA = "0xAFDF40", Offset = "0xAFCD40", VA = "0x10AFDF40")]
    public static explicit operator long(Value self) => new long();

    [Token(Token = "0x600EAA4")]
    [Address(RVA = "0xAFD600", Offset = "0xAFC400", VA = "0x10AFD600")]
    public long ToLong() => new long();

    [Token(Token = "0x600EAA5")]
    [Address(RVA = "0xAFCDA0", Offset = "0xAFBBA0", VA = "0x10AFCDA0")]
    public bool IsLong() => new bool();

    [Token(Token = "0x600EAA6")]
    [Address(RVA = "0xAFDEC0", Offset = "0xAFCCC0", VA = "0x10AFDEC0")]
    public static explicit operator ulong(Value self) => new ulong();

    [Token(Token = "0x600EAA7")]
    [Address(RVA = "0xAFD910", Offset = "0xAFC710", VA = "0x10AFD910")]
    public ulong ToULong() => new ulong();

    [Token(Token = "0x600EAA8")]
    [Address(RVA = "0xAFD150", Offset = "0xAFBF50", VA = "0x10AFD150")]
    public bool IsULong() => new bool();

    [Token(Token = "0x600EAA9")]
    [Address(RVA = "0xAFDF20", Offset = "0xAFCD20", VA = "0x10AFDF20")]
    public static explicit operator float(Value self) => new float();

    [Token(Token = "0x600EAAA")]
    [Address(RVA = "0xAFD3E0", Offset = "0xAFC1E0", VA = "0x10AFD3E0")]
    public float ToFloat() => new float();

    [Token(Token = "0x600EAAB")]
    [Address(RVA = "0xAFCC40", Offset = "0xAFBA40", VA = "0x10AFCC40")]
    public bool IsFloat() => new bool();

    [Token(Token = "0x600EAAC")]
    [Address(RVA = "0xAFDE80", Offset = "0xAFCC80", VA = "0x10AFDE80")]
    public static explicit operator double(Value self) => new double();

    [Token(Token = "0x600EAAD")]
    [Address(RVA = "0xAFD2F0", Offset = "0xAFC0F0", VA = "0x10AFD2F0")]
    public double ToDouble() => new double();

    [Token(Token = "0x600EAAE")]
    [Address(RVA = "0xAFCB90", Offset = "0xAFB990", VA = "0x10AFCB90")]
    public bool IsDouble() => new bool();

    [Token(Token = "0x600EAAF")]
    [Address(RVA = "0xAFDEE0", Offset = "0xAFCCE0", VA = "0x10AFDEE0")]
    public static explicit operator bool(Value self) => new bool();

    [Token(Token = "0x600EAB0")]
    [Address(RVA = "0xAFD200", Offset = "0xAFC000", VA = "0x10AFD200")]
    public bool ToBool() => new bool();

    [Token(Token = "0x600EAB1")]
    [Address(RVA = "0xAFCAE0", Offset = "0xAFB8E0", VA = "0x10AFCAE0")]
    public bool IsBool() => new bool();

    [Token(Token = "0x600EAB2")]
    [Address(RVA = "0xAFDEA0", Offset = "0xAFCCA0", VA = "0x10AFDEA0")]
    public static explicit operator string(Value self) => (string) null;

    [Token(Token = "0x600EAB3")]
    [Address(RVA = "0xAFD700", Offset = "0xAFC500", VA = "0x10AFD700", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600EAB4")]
    [Address(RVA = "0xAFCFF0", Offset = "0xAFBDF0", VA = "0x10AFCFF0")]
    public bool IsString() => new bool();

    [Token(Token = "0x600EAB5")]
    [Address(RVA = "0xAFCE50", Offset = "0xAFBC50", VA = "0x10AFCE50")]
    public bool IsNull() => new bool();

    [Token(Token = "0x600EAB6")]
    [Address(RVA = "0xAFDA10", Offset = "0xAFC810", VA = "0x10AFDA10")]
    public bool TryGetValueByPointer(string pointer, out Value value) => new bool();

    [Token(Token = "0x600EAB7")]
    [Address(RVA = "0xAFC800", Offset = "0xAFB600", VA = "0x10AFC800")]
    public int GetValueByPointer(string pointer, int defaultValue) => new int();

    [Token(Token = "0x600EAB8")]
    [Address(RVA = "0xAFC740", Offset = "0xAFB540", VA = "0x10AFC740")]
    public uint GetValueByPointer(string pointer, uint defaultValue) => new uint();

    [Token(Token = "0x600EAB9")]
    [Address(RVA = "0xAFC860", Offset = "0xAFB660", VA = "0x10AFC860")]
    public long GetValueByPointer(string pointer, long defaultValue) => new long();

    [Token(Token = "0x600EABA")]
    [Address(RVA = "0xAFC7A0", Offset = "0xAFB5A0", VA = "0x10AFC7A0")]
    public ulong GetValueByPointer(string pointer, ulong defaultValue) => new ulong();

    [Token(Token = "0x600EABB")]
    [Address(RVA = "0xAFC980", Offset = "0xAFB780", VA = "0x10AFC980")]
    public float GetValueByPointer(string pointer, float defaultValue) => new float();

    [Token(Token = "0x600EABC")]
    [Address(RVA = "0xAFC8C0", Offset = "0xAFB6C0", VA = "0x10AFC8C0")]
    public double GetValueByPointer(string pointer, double defaultValue) => new double();

    [Token(Token = "0x600EABD")]
    [Address(RVA = "0xAFC6E0", Offset = "0xAFB4E0", VA = "0x10AFC6E0")]
    public bool GetValueByPointer(string pointer, bool defaultValue) => new bool();

    [Token(Token = "0x600EABE")]
    [Address(RVA = "0xAFC920", Offset = "0xAFB720", VA = "0x10AFC920")]
    public string GetValueByPointer(string pointer, string defaultValue) => (string) null;
  }
}
