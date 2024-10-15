// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.Common;
using Il2CppDummyDll;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200368C")]
  [Serializable]
  public struct ObscuredDecimal : 
    IFormattable,
    IEquatable<ObscuredDecimal>,
    IComparable<ObscuredDecimal>,
    IComparable<Decimal>,
    IComparable
  {
    [Token(Token = "0x400FFE3")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    private static long cryptoKey;
    [Token(Token = "0x400FFE4")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    [SerializeField]
    private long currentCryptoKey;
    [Token(Token = "0x400FFE5")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
    [SerializeField]
    private ACTkByte16 hiddenValue;
    [Token(Token = "0x400FFE6")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x400FFE7")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x20")]
    private Decimal fakeValue;
    [Token(Token = "0x400FFE8")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F475")]
    [Address(RVA = "0xB4B330", Offset = "0xB4A130", VA = "0x10B4B330")]
    private ObscuredDecimal(Decimal value)
    {
    }

    [Token(Token = "0x600F476")]
    [Address(RVA = "0xB4B070", Offset = "0xB49E70", VA = "0x10B4B070")]
    public static void SetNewCryptoKey(long newKey)
    {
    }

    [Token(Token = "0x600F477")]
    [Address(RVA = "0xB4A770", Offset = "0xB49570", VA = "0x10B4A770")]
    public static Decimal Encrypt(Decimal value) => 0M;

    [Token(Token = "0x600F478")]
    [Address(RVA = "0xB4A6B0", Offset = "0xB494B0", VA = "0x10B4A6B0")]
    public static Decimal Encrypt(Decimal value, long key) => 0M;

    [Token(Token = "0x600F479")]
    [Address(RVA = "0xB4AC70", Offset = "0xB49A70", VA = "0x10B4AC70")]
    private static ACTkByte16 InternalEncrypt(Decimal value) => new ACTkByte16();

    [Token(Token = "0x600F47A")]
    [Address(RVA = "0xB4AD20", Offset = "0xB49B20", VA = "0x10B4AD20")]
    private static ACTkByte16 InternalEncrypt(Decimal value, long key) => new ACTkByte16();

    [Token(Token = "0x600F47B")]
    [Address(RVA = "0xB4A6F0", Offset = "0xB494F0", VA = "0x10B4A6F0")]
    public static Decimal Decrypt(Decimal value) => 0M;

    [Token(Token = "0x600F47C")]
    [Address(RVA = "0xB4A6B0", Offset = "0xB494B0", VA = "0x10B4A6B0")]
    public static Decimal Decrypt(Decimal value, long key) => 0M;

    [Token(Token = "0x600F47D")]
    [Address(RVA = "0xB4A950", Offset = "0xB49750", VA = "0x10B4A950")]
    public static ObscuredDecimal FromEncrypted(Decimal encrypted) => new ObscuredDecimal();

    [Token(Token = "0x600F47E")]
    [Address(RVA = "0xB4A420", Offset = "0xB49220", VA = "0x10B4A420")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F47F")]
    [Address(RVA = "0xB4ADA0", Offset = "0xB49BA0", VA = "0x10B4ADA0")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F480")]
    [Address(RVA = "0xB4AA20", Offset = "0xB49820", VA = "0x10B4AA20")]
    public Decimal GetEncrypted() => 0M;

    [Token(Token = "0x600F481")]
    [Address(RVA = "0xB4AE60", Offset = "0xB49C60", VA = "0x10B4AE60")]
    public void SetEncrypted(Decimal encrypted)
    {
    }

    [Token(Token = "0x600F482")]
    [Address(RVA = "0xB4A9C0", Offset = "0xB497C0", VA = "0x10B4A9C0")]
    public Decimal GetDecrypted() => 0M;

    [Token(Token = "0x600F483")]
    [Address(RVA = "0xB4AAF0", Offset = "0xB498F0", VA = "0x10B4AAF0")]
    private Decimal InternalDecrypt() => 0M;

    [Token(Token = "0x600F484")]
    [Address(RVA = "0xB4B650", Offset = "0xB4A450", VA = "0x10B4B650")]
    public static implicit operator ObscuredDecimal(Decimal value) => new ObscuredDecimal();

    [Token(Token = "0x600F485")]
    [Address(RVA = "0xB4B680", Offset = "0xB4A480", VA = "0x10B4B680")]
    public static implicit operator Decimal(ObscuredDecimal value) => 0M;

    [Token(Token = "0x600F486")]
    [Address(RVA = "0xB4B510", Offset = "0xB4A310", VA = "0x10B4B510")]
    public static explicit operator ObscuredDecimal(ObscuredFloat f) => new ObscuredDecimal();

    [Token(Token = "0x600F487")]
    [Address(RVA = "0xB4B6E0", Offset = "0xB4A4E0", VA = "0x10B4B6E0")]
    public static ObscuredDecimal operator ++(ObscuredDecimal input) => new ObscuredDecimal();

    [Token(Token = "0x600F488")]
    [Address(RVA = "0xB4B400", Offset = "0xB4A200", VA = "0x10B4B400")]
    public static ObscuredDecimal operator --(ObscuredDecimal input) => new ObscuredDecimal();

    [Token(Token = "0x600F489")]
    [Address(RVA = "0xB4AA70", Offset = "0xB49870", VA = "0x10B4AA70", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F48A")]
    [Address(RVA = "0xB4B150", Offset = "0xB49F50", VA = "0x10B4B150", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F48B")]
    [Address(RVA = "0xB4B0C0", Offset = "0xB49EC0", VA = "0x10B4B0C0")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F48C")]
    [Address(RVA = "0xB4B260", Offset = "0xB4A060", VA = "0x10B4B260")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F48D")]
    [Address(RVA = "0xB4B1D0", Offset = "0xB49FD0", VA = "0x10B4B1D0", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F48E")]
    [Address(RVA = "0xB4A8A0", Offset = "0xB496A0", VA = "0x10B4A8A0", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F48F")]
    [Address(RVA = "0xB4A7F0", Offset = "0xB495F0", VA = "0x10B4A7F0", Slot = "5")]
    public bool Equals(ObscuredDecimal obj) => new bool();

    [Token(Token = "0x600F490")]
    [Address(RVA = "0xB4A570", Offset = "0xB49370", VA = "0x10B4A570", Slot = "6")]
    public int CompareTo(ObscuredDecimal other) => new int();

    [Token(Token = "0x600F491")]
    [Address(RVA = "0xB4A620", Offset = "0xB49420", VA = "0x10B4A620", Slot = "7")]
    public int CompareTo(Decimal other) => new int();

    [Token(Token = "0x600F492")]
    [Address(RVA = "0xB4A4E0", Offset = "0xB492E0", VA = "0x10B4A4E0", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F493")]
    [Address(RVA = "0xB4B2F0", Offset = "0xB4A0F0", VA = "0x10B4B2F0")]
    static ObscuredDecimal()
    {
    }

    [Token(Token = "0x200368D")]
    [StructLayout(LayoutKind.Explicit)]
    private struct DecimalLongBytesUnion
    {
      [Token(Token = "0x400FFE9")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public Decimal d;
      [Token(Token = "0x400FFEA")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public long l1;
      [Token(Token = "0x400FFEB")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
      public long l2;
      [Token(Token = "0x400FFEC")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public ACTkByte16 b16;
    }
  }
}
