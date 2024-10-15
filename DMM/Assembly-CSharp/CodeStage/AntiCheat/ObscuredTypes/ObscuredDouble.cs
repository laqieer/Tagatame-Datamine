// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using CodeStage.AntiCheat.Common;
using Il2CppDummyDll;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Serialization;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200368E")]
  [Serializable]
  public struct ObscuredDouble : 
    IFormattable,
    IEquatable<ObscuredDouble>,
    IComparable<ObscuredDouble>,
    IComparable<double>,
    IComparable
  {
    [Token(Token = "0x400FFED")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    private static long cryptoKey;
    [Token(Token = "0x400FFEE")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    [SerializeField]
    private long currentCryptoKey;
    [Token(Token = "0x400FFEF")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
    [SerializeField]
    private long hiddenValue;
    [Token(Token = "0x400FFF0")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
    [SerializeField]
    [FormerlySerializedAs("hiddenValue")]
    private ACTkByte8 hiddenValueOldByte8;
    [Token(Token = "0x400FFF1")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x400FFF2")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x20")]
    [SerializeField]
    private double fakeValue;
    [Token(Token = "0x400FFF3")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F494")]
    [Address(RVA = "0xB4C660", Offset = "0xB4B460", VA = "0x10B4C660")]
    private ObscuredDouble(double value)
    {
    }

    [Token(Token = "0x600F495")]
    [Address(RVA = "0xB4C450", Offset = "0xB4B250", VA = "0x10B4C450")]
    public static void SetNewCryptoKey(long newKey)
    {
    }

    [Token(Token = "0x600F496")]
    [Address(RVA = "0xB4BAD0", Offset = "0xB4A8D0", VA = "0x10B4BAD0")]
    public static long Encrypt(double value) => new long();

    [Token(Token = "0x600F497")]
    [Address(RVA = "0xB4BAA0", Offset = "0xB4A8A0", VA = "0x10B4BAA0")]
    public static long Encrypt(double value, long key) => new long();

    [Token(Token = "0x600F498")]
    [Address(RVA = "0xB4C030", Offset = "0xB4AE30", VA = "0x10B4C030")]
    private static long InternalEncrypt(double value, long key = 0) => new long();

    [Token(Token = "0x600F499")]
    [Address(RVA = "0xB4BA00", Offset = "0xB4A800", VA = "0x10B4BA00")]
    public static double Decrypt(long value) => new double();

    [Token(Token = "0x600F49A")]
    [Address(RVA = "0xB4BA70", Offset = "0xB4A870", VA = "0x10B4BA70")]
    public static double Decrypt(long value, long key) => new double();

    [Token(Token = "0x600F49B")]
    [Address(RVA = "0xB4C0C0", Offset = "0xB4AEC0", VA = "0x10B4C0C0")]
    public static long MigrateEncrypted(long encrypted, byte fromVersion = 0, byte toVersion = 2)
    {
      return new long();
    }

    [Token(Token = "0x600F49C")]
    [Address(RVA = "0xB4BC60", Offset = "0xB4AA60", VA = "0x10B4BC60")]
    public static ObscuredDouble FromEncrypted(long encrypted) => new ObscuredDouble();

    [Token(Token = "0x600F49D")]
    [Address(RVA = "0xB4B7F0", Offset = "0xB4A5F0", VA = "0x10B4B7F0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F49E")]
    [Address(RVA = "0xB4C100", Offset = "0xB4AF00", VA = "0x10B4C100")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F49F")]
    [Address(RVA = "0xB4BD10", Offset = "0xB4AB10", VA = "0x10B4BD10")]
    public long GetEncrypted() => new long();

    [Token(Token = "0x600F4A0")]
    [Address(RVA = "0xB4C1B0", Offset = "0xB4AFB0", VA = "0x10B4C1B0")]
    public void SetEncrypted(long encrypted)
    {
    }

    [Token(Token = "0x600F4A1")]
    [Address(RVA = "0xB4BCC0", Offset = "0xB4AAC0", VA = "0x10B4BCC0")]
    public double GetDecrypted() => new double();

    [Token(Token = "0x600F4A2")]
    [Address(RVA = "0xB4BE20", Offset = "0xB4AC20", VA = "0x10B4BE20")]
    private double InternalDecrypt() => new double();

    [Token(Token = "0x600F4A3")]
    [Address(RVA = "0xB4C970", Offset = "0xB4B770", VA = "0x10B4C970")]
    public static implicit operator ObscuredDouble(double value) => new ObscuredDouble();

    [Token(Token = "0x600F4A4")]
    [Address(RVA = "0xB4C920", Offset = "0xB4B720", VA = "0x10B4C920")]
    public static implicit operator double(ObscuredDouble value) => new double();

    [Token(Token = "0x600F4A5")]
    [Address(RVA = "0xB4C820", Offset = "0xB4B620", VA = "0x10B4C820")]
    public static explicit operator ObscuredDouble(ObscuredFloat f) => new ObscuredDouble();

    [Token(Token = "0x600F4A6")]
    [Address(RVA = "0xB4C9B0", Offset = "0xB4B7B0", VA = "0x10B4C9B0")]
    public static ObscuredDouble operator ++(ObscuredDouble input) => new ObscuredDouble();

    [Token(Token = "0x600F4A7")]
    [Address(RVA = "0xB4C770", Offset = "0xB4B570", VA = "0x10B4C770")]
    public static ObscuredDouble operator --(ObscuredDouble input) => new ObscuredDouble();

    [Token(Token = "0x600F4A8")]
    [Address(RVA = "0xB4BD60", Offset = "0xB4AB60", VA = "0x10B4BD60", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F4A9")]
    [Address(RVA = "0xB4C560", Offset = "0xB4B360", VA = "0x10B4C560", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F4AA")]
    [Address(RVA = "0xB4C4A0", Offset = "0xB4B2A0", VA = "0x10B4C4A0")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F4AB")]
    [Address(RVA = "0xB4C5C0", Offset = "0xB4B3C0", VA = "0x10B4C5C0")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F4AC")]
    [Address(RVA = "0xB4C500", Offset = "0xB4B300", VA = "0x10B4C500", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F4AD")]
    [Address(RVA = "0xB4BBC0", Offset = "0xB4A9C0", VA = "0x10B4BBC0", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F4AE")]
    [Address(RVA = "0xB4BB40", Offset = "0xB4A940", VA = "0x10B4BB40", Slot = "5")]
    public bool Equals(ObscuredDouble obj) => new bool();

    [Token(Token = "0x600F4AF")]
    [Address(RVA = "0xB4B980", Offset = "0xB4A780", VA = "0x10B4B980", Slot = "6")]
    public int CompareTo(ObscuredDouble other) => new int();

    [Token(Token = "0x600F4B0")]
    [Address(RVA = "0xB4B910", Offset = "0xB4A710", VA = "0x10B4B910", Slot = "7")]
    public int CompareTo(double other) => new int();

    [Token(Token = "0x600F4B1")]
    [Address(RVA = "0xB4B8B0", Offset = "0xB4A6B0", VA = "0x10B4B8B0", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F4B2")]
    [Address(RVA = "0xB4C620", Offset = "0xB4B420", VA = "0x10B4C620")]
    static ObscuredDouble()
    {
    }

    [Token(Token = "0x200368F")]
    [StructLayout(LayoutKind.Explicit)]
    private struct DoubleLongBytesUnion
    {
      [Token(Token = "0x400FFF4")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public double d;
      [Token(Token = "0x400FFF5")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public long l;
      [Token(Token = "0x400FFF6")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public ACTkByte8 b8;
    }
  }
}
