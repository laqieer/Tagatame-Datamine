// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredLong
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x2003693")]
  [Serializable]
  public struct ObscuredLong : 
    IFormattable,
    IEquatable<ObscuredLong>,
    IComparable<ObscuredLong>,
    IComparable<long>,
    IComparable
  {
    [Token(Token = "0x4010007")]
    [FieldOffset(Offset = "0x0")]
    private static long cryptoKey;
    [Token(Token = "0x4010008")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private long currentCryptoKey;
    [Token(Token = "0x4010009")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private long hiddenValue;
    [Token(Token = "0x401000A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x401000B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private long fakeValue;
    [Token(Token = "0x401000C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F4F0")]
    [Address(RVA = "0xB4F5C0", Offset = "0xB4E3C0", VA = "0x10B4F5C0")]
    private ObscuredLong(long value)
    {
    }

    [Token(Token = "0x600F4F1")]
    [Address(RVA = "0xB4F3B0", Offset = "0xB4E1B0", VA = "0x10B4F3B0")]
    public static void SetNewCryptoKey(long newKey)
    {
    }

    [Token(Token = "0x600F4F2")]
    [Address(RVA = "0xB4ED10", Offset = "0xB4DB10", VA = "0x10B4ED10")]
    public static long Encrypt(long value) => new long();

    [Token(Token = "0x600F4F3")]
    [Address(RVA = "0xB4EBB0", Offset = "0xB4D9B0", VA = "0x10B4EBB0")]
    public static long Decrypt(long value) => new long();

    [Token(Token = "0x600F4F4")]
    [Address(RVA = "0xB4ECA0", Offset = "0xB4DAA0", VA = "0x10B4ECA0")]
    public static long Encrypt(long value, long key) => new long();

    [Token(Token = "0x600F4F5")]
    [Address(RVA = "0xB4EC30", Offset = "0xB4DA30", VA = "0x10B4EC30")]
    public static long Decrypt(long value, long key) => new long();

    [Token(Token = "0x600F4F6")]
    [Address(RVA = "0xB4EEE0", Offset = "0xB4DCE0", VA = "0x10B4EEE0")]
    public static ObscuredLong FromEncrypted(long encrypted) => new ObscuredLong();

    [Token(Token = "0x600F4F7")]
    [Address(RVA = "0xB4E9E0", Offset = "0xB4D7E0", VA = "0x10B4E9E0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F4F8")]
    [Address(RVA = "0xB4F170", Offset = "0xB4DF70", VA = "0x10B4F170")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F4F9")]
    [Address(RVA = "0xB4EF90", Offset = "0xB4DD90", VA = "0x10B4EF90")]
    public long GetEncrypted() => new long();

    [Token(Token = "0x600F4FA")]
    [Address(RVA = "0xB4F200", Offset = "0xB4E000", VA = "0x10B4F200")]
    public void SetEncrypted(long encrypted)
    {
    }

    [Token(Token = "0x600F4FB")]
    [Address(RVA = "0xB4EF40", Offset = "0xB4DD40", VA = "0x10B4EF40")]
    public long GetDecrypted() => new long();

    [Token(Token = "0x600F4FC")]
    [Address(RVA = "0xB4F050", Offset = "0xB4DE50", VA = "0x10B4F050")]
    private long InternalDecrypt() => new long();

    [Token(Token = "0x600F4FD")]
    [Address(RVA = "0xB4F6F0", Offset = "0xB4E4F0", VA = "0x10B4F6F0")]
    public static implicit operator ObscuredLong(long value) => new ObscuredLong();

    [Token(Token = "0x600F4FE")]
    [Address(RVA = "0xB4F720", Offset = "0xB4E520", VA = "0x10B4F720")]
    public static implicit operator long(ObscuredLong value) => new long();

    [Token(Token = "0x600F4FF")]
    [Address(RVA = "0xB4F770", Offset = "0xB4E570", VA = "0x10B4F770")]
    public static ObscuredLong operator ++(ObscuredLong input) => new ObscuredLong();

    [Token(Token = "0x600F500")]
    [Address(RVA = "0xB4F650", Offset = "0xB4E450", VA = "0x10B4F650")]
    public static ObscuredLong operator --(ObscuredLong input) => new ObscuredLong();

    [Token(Token = "0x600F501")]
    [Address(RVA = "0xB4EFF0", Offset = "0xB4DDF0", VA = "0x10B4EFF0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F502")]
    [Address(RVA = "0xB4F520", Offset = "0xB4E320", VA = "0x10B4F520", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F503")]
    [Address(RVA = "0xB4F400", Offset = "0xB4E200", VA = "0x10B4F400")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F504")]
    [Address(RVA = "0xB4F460", Offset = "0xB4E260", VA = "0x10B4F460")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F505")]
    [Address(RVA = "0xB4F4C0", Offset = "0xB4E2C0", VA = "0x10B4F4C0", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F506")]
    [Address(RVA = "0xB4ED90", Offset = "0xB4DB90", VA = "0x10B4ED90", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F507")]
    [Address(RVA = "0xB4EE30", Offset = "0xB4DC30", VA = "0x10B4EE30", Slot = "5")]
    public bool Equals(ObscuredLong obj) => new bool();

    [Token(Token = "0x600F508")]
    [Address(RVA = "0xB4EA80", Offset = "0xB4D880", VA = "0x10B4EA80", Slot = "6")]
    public int CompareTo(ObscuredLong other) => new int();

    [Token(Token = "0x600F509")]
    [Address(RVA = "0xB4EB50", Offset = "0xB4D950", VA = "0x10B4EB50", Slot = "7")]
    public int CompareTo(long other) => new int();

    [Token(Token = "0x600F50A")]
    [Address(RVA = "0xB4EAF0", Offset = "0xB4D8F0", VA = "0x10B4EAF0", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F50B")]
    [Address(RVA = "0xB4F580", Offset = "0xB4E380", VA = "0x10B4F580")]
    static ObscuredLong()
    {
    }
  }
}
