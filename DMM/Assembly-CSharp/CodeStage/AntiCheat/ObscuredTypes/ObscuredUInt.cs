// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200369D")]
  [Serializable]
  public struct ObscuredUInt : 
    IFormattable,
    IEquatable<ObscuredUInt>,
    IComparable<ObscuredUInt>,
    IComparable<uint>,
    IComparable
  {
    [Token(Token = "0x4010051")]
    [FieldOffset(Offset = "0x0")]
    private static uint cryptoKey;
    [Token(Token = "0x4010052")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private uint currentCryptoKey;
    [Token(Token = "0x4010053")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private uint hiddenValue;
    [Token(Token = "0x4010054")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x4010055")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private uint fakeValue;
    [Token(Token = "0x4010056")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F5E4")]
    [Address(RVA = "0xB5B180", Offset = "0xB59F80", VA = "0x10B5B180")]
    private ObscuredUInt(uint value)
    {
    }

    [Token(Token = "0x600F5E5")]
    [Address(RVA = "0xB5AF80", Offset = "0xB59D80", VA = "0x10B5AF80")]
    public static void SetNewCryptoKey(uint newKey)
    {
    }

    [Token(Token = "0x600F5E6")]
    [Address(RVA = "0xB5A9A0", Offset = "0xB597A0", VA = "0x10B5A9A0")]
    public static uint Encrypt(uint value) => new uint();

    [Token(Token = "0x600F5E7")]
    [Address(RVA = "0xB5A8C0", Offset = "0xB596C0", VA = "0x10B5A8C0")]
    public static uint Decrypt(uint value) => new uint();

    [Token(Token = "0x600F5E8")]
    [Address(RVA = "0xB5A940", Offset = "0xB59740", VA = "0x10B5A940")]
    public static uint Encrypt(uint value, uint key) => new uint();

    [Token(Token = "0x600F5E9")]
    [Address(RVA = "0xB5A860", Offset = "0xB59660", VA = "0x10B5A860")]
    public static uint Decrypt(uint value, uint key) => new uint();

    [Token(Token = "0x600F5EA")]
    [Address(RVA = "0xB5ABA0", Offset = "0xB599A0", VA = "0x10B5ABA0")]
    public static ObscuredUInt FromEncrypted(uint encrypted) => new ObscuredUInt();

    [Token(Token = "0x600F5EB")]
    [Address(RVA = "0xB5A670", Offset = "0xB59470", VA = "0x10B5A670")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F5EC")]
    [Address(RVA = "0xB5AE20", Offset = "0xB59C20", VA = "0x10B5AE20")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F5ED")]
    [Address(RVA = "0xB5AC50", Offset = "0xB59A50", VA = "0x10B5AC50")]
    public uint GetEncrypted() => new uint();

    [Token(Token = "0x600F5EE")]
    [Address(RVA = "0xB5AEE0", Offset = "0xB59CE0", VA = "0x10B5AEE0")]
    public void SetEncrypted(uint encrypted)
    {
    }

    [Token(Token = "0x600F5EF")]
    [Address(RVA = "0xB5AC00", Offset = "0xB59A00", VA = "0x10B5AC00")]
    public uint GetDecrypted() => new uint();

    [Token(Token = "0x600F5F0")]
    [Address(RVA = "0xB5AD00", Offset = "0xB59B00", VA = "0x10B5AD00")]
    private uint InternalDecrypt() => new uint();

    [Token(Token = "0x600F5F1")]
    [Address(RVA = "0xB5B3B0", Offset = "0xB5A1B0", VA = "0x10B5B3B0")]
    public static implicit operator ObscuredUInt(uint value) => new ObscuredUInt();

    [Token(Token = "0x600F5F2")]
    [Address(RVA = "0xB5B360", Offset = "0xB5A160", VA = "0x10B5B360")]
    public static implicit operator uint(ObscuredUInt value) => new uint();

    [Token(Token = "0x600F5F3")]
    [Address(RVA = "0xB5B2C0", Offset = "0xB5A0C0", VA = "0x10B5B2C0")]
    public static explicit operator ObscuredInt(ObscuredUInt value) => new ObscuredInt();

    [Token(Token = "0x600F5F4")]
    [Address(RVA = "0xB5B3E0", Offset = "0xB5A1E0", VA = "0x10B5B3E0")]
    public static ObscuredUInt operator ++(ObscuredUInt input) => new ObscuredUInt();

    [Token(Token = "0x600F5F5")]
    [Address(RVA = "0xB5B1F0", Offset = "0xB59FF0", VA = "0x10B5B1F0")]
    public static ObscuredUInt operator --(ObscuredUInt input) => new ObscuredUInt();

    [Token(Token = "0x600F5F6")]
    [Address(RVA = "0xB5ACA0", Offset = "0xB59AA0", VA = "0x10B5ACA0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F5F7")]
    [Address(RVA = "0xB5B030", Offset = "0xB59E30", VA = "0x10B5B030", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F5F8")]
    [Address(RVA = "0xB5B090", Offset = "0xB59E90", VA = "0x10B5B090")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F5F9")]
    [Address(RVA = "0xB5B0F0", Offset = "0xB59EF0", VA = "0x10B5B0F0")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F5FA")]
    [Address(RVA = "0xB5AFD0", Offset = "0xB59DD0", VA = "0x10B5AFD0", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F5FB")]
    [Address(RVA = "0xB5AB10", Offset = "0xB59910", VA = "0x10B5AB10", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F5FC")]
    [Address(RVA = "0xB5AA20", Offset = "0xB59820", VA = "0x10B5AA20", Slot = "5")]
    public bool Equals(ObscuredUInt obj) => new bool();

    [Token(Token = "0x600F5FD")]
    [Address(RVA = "0xB5A740", Offset = "0xB59540", VA = "0x10B5A740", Slot = "6")]
    public int CompareTo(ObscuredUInt other) => new int();

    [Token(Token = "0x600F5FE")]
    [Address(RVA = "0xB5A800", Offset = "0xB59600", VA = "0x10B5A800", Slot = "7")]
    public int CompareTo(uint other) => new int();

    [Token(Token = "0x600F5FF")]
    [Address(RVA = "0xB5A7A0", Offset = "0xB595A0", VA = "0x10B5A7A0", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F600")]
    [Address(RVA = "0xB5B150", Offset = "0xB59F50", VA = "0x10B5B150")]
    static ObscuredUInt()
    {
    }
  }
}
