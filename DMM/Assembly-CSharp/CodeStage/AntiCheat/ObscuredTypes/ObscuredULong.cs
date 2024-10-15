// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredULong
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200369E")]
  [Serializable]
  public struct ObscuredULong : 
    IFormattable,
    IEquatable<ObscuredULong>,
    IComparable<ObscuredULong>,
    IComparable<ulong>,
    IComparable
  {
    [Token(Token = "0x4010057")]
    [FieldOffset(Offset = "0x0")]
    private static ulong cryptoKey;
    [Token(Token = "0x4010058")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private ulong currentCryptoKey;
    [Token(Token = "0x4010059")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private ulong hiddenValue;
    [Token(Token = "0x401005A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x401005B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ulong fakeValue;
    [Token(Token = "0x401005C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F601")]
    [Address(RVA = "0xB5C090", Offset = "0xB5AE90", VA = "0x10B5C090")]
    private ObscuredULong(ulong value)
    {
    }

    [Token(Token = "0x600F602")]
    [Address(RVA = "0xB5BE70", Offset = "0xB5AC70", VA = "0x10B5BE70")]
    public static void SetNewCryptoKey(ulong newKey)
    {
    }

    [Token(Token = "0x600F603")]
    [Address(RVA = "0xB5B770", Offset = "0xB5A570", VA = "0x10B5B770")]
    public static ulong Encrypt(ulong value) => new ulong();

    [Token(Token = "0x600F604")]
    [Address(RVA = "0xB5B680", Offset = "0xB5A480", VA = "0x10B5B680")]
    public static ulong Decrypt(ulong value) => new ulong();

    [Token(Token = "0x600F605")]
    [Address(RVA = "0xB5B7F0", Offset = "0xB5A5F0", VA = "0x10B5B7F0")]
    public static ulong Encrypt(ulong value, ulong key) => new ulong();

    [Token(Token = "0x600F606")]
    [Address(RVA = "0xB5B700", Offset = "0xB5A500", VA = "0x10B5B700")]
    public static ulong Decrypt(ulong value, ulong key) => new ulong();

    [Token(Token = "0x600F607")]
    [Address(RVA = "0xB5B9B0", Offset = "0xB5A7B0", VA = "0x10B5B9B0")]
    public static ObscuredULong FromEncrypted(ulong encrypted) => new ObscuredULong();

    [Token(Token = "0x600F608")]
    [Address(RVA = "0xB5B4B0", Offset = "0xB5A2B0", VA = "0x10B5B4B0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F609")]
    [Address(RVA = "0xB5BC30", Offset = "0xB5AA30", VA = "0x10B5BC30")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F60A")]
    [Address(RVA = "0xB5BA60", Offset = "0xB5A860", VA = "0x10B5BA60")]
    public ulong GetEncrypted() => new ulong();

    [Token(Token = "0x600F60B")]
    [Address(RVA = "0xB5BCC0", Offset = "0xB5AAC0", VA = "0x10B5BCC0")]
    public void SetEncrypted(ulong encrypted)
    {
    }

    [Token(Token = "0x600F60C")]
    [Address(RVA = "0xB5BA10", Offset = "0xB5A810", VA = "0x10B5BA10")]
    public ulong GetDecrypted() => new ulong();

    [Token(Token = "0x600F60D")]
    [Address(RVA = "0xB5BB10", Offset = "0xB5A910", VA = "0x10B5BB10")]
    private ulong InternalDecrypt() => new ulong();

    [Token(Token = "0x600F60E")]
    [Address(RVA = "0xB5C210", Offset = "0xB5B010", VA = "0x10B5C210")]
    public static implicit operator ObscuredULong(ulong value) => new ObscuredULong();

    [Token(Token = "0x600F60F")]
    [Address(RVA = "0xB5C1C0", Offset = "0xB5AFC0", VA = "0x10B5C1C0")]
    public static implicit operator ulong(ObscuredULong value) => new ulong();

    [Token(Token = "0x600F610")]
    [Address(RVA = "0xB5C240", Offset = "0xB5B040", VA = "0x10B5C240")]
    public static ObscuredULong operator ++(ObscuredULong input) => new ObscuredULong();

    [Token(Token = "0x600F611")]
    [Address(RVA = "0xB5C120", Offset = "0xB5AF20", VA = "0x10B5C120")]
    public static ObscuredULong operator --(ObscuredULong input) => new ObscuredULong();

    [Token(Token = "0x600F612")]
    [Address(RVA = "0xB5BAB0", Offset = "0xB5A8B0", VA = "0x10B5BAB0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F613")]
    [Address(RVA = "0xB5BF80", Offset = "0xB5AD80", VA = "0x10B5BF80", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F614")]
    [Address(RVA = "0xB5BF20", Offset = "0xB5AD20", VA = "0x10B5BF20")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F615")]
    [Address(RVA = "0xB5BEC0", Offset = "0xB5ACC0", VA = "0x10B5BEC0")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F616")]
    [Address(RVA = "0xB5BFF0", Offset = "0xB5ADF0", VA = "0x10B5BFF0", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F617")]
    [Address(RVA = "0xB5B910", Offset = "0xB5A710", VA = "0x10B5B910", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F618")]
    [Address(RVA = "0xB5B860", Offset = "0xB5A660", VA = "0x10B5B860", Slot = "5")]
    public bool Equals(ObscuredULong obj) => new bool();

    [Token(Token = "0x600F619")]
    [Address(RVA = "0xB5B5B0", Offset = "0xB5A3B0", VA = "0x10B5B5B0", Slot = "6")]
    public int CompareTo(ObscuredULong other) => new int();

    [Token(Token = "0x600F61A")]
    [Address(RVA = "0xB5B550", Offset = "0xB5A350", VA = "0x10B5B550", Slot = "7")]
    public int CompareTo(ulong other) => new int();

    [Token(Token = "0x600F61B")]
    [Address(RVA = "0xB5B620", Offset = "0xB5A420", VA = "0x10B5B620", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F61C")]
    [Address(RVA = "0xB5C050", Offset = "0xB5AE50", VA = "0x10B5C050")]
    static ObscuredULong()
    {
    }
  }
}
