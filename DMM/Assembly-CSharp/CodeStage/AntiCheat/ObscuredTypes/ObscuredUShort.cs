// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200369F")]
  [Serializable]
  public struct ObscuredUShort : 
    IFormattable,
    IEquatable<ObscuredUShort>,
    IComparable<ObscuredUShort>,
    IComparable<ushort>,
    IComparable
  {
    [Token(Token = "0x401005D")]
    [FieldOffset(Offset = "0x0")]
    private static ushort cryptoKey;
    [Token(Token = "0x401005E")]
    [FieldOffset(Offset = "0x0")]
    private ushort currentCryptoKey;
    [Token(Token = "0x401005F")]
    [FieldOffset(Offset = "0x2")]
    private ushort hiddenValue;
    [Token(Token = "0x4010060")]
    [FieldOffset(Offset = "0x4")]
    private bool inited;
    [Token(Token = "0x4010061")]
    [FieldOffset(Offset = "0x6")]
    private ushort fakeValue;
    [Token(Token = "0x4010062")]
    [FieldOffset(Offset = "0x8")]
    private bool fakeValueActive;

    [Token(Token = "0x600F61D")]
    [Address(RVA = "0xB5CD50", Offset = "0xB5BB50", VA = "0x10B5CD50")]
    private ObscuredUShort(ushort value)
    {
    }

    [Token(Token = "0x600F61E")]
    [Address(RVA = "0xB5CB40", Offset = "0xB5B940", VA = "0x10B5CB40")]
    public static void SetNewCryptoKey(ushort newKey)
    {
    }

    [Token(Token = "0x600F61F")]
    [Address(RVA = "0xB5C4B0", Offset = "0xB5B2B0", VA = "0x10B5C4B0")]
    public static ushort EncryptDecrypt(ushort value) => new ushort();

    [Token(Token = "0x600F620")]
    [Address(RVA = "0xB5C530", Offset = "0xB5B330", VA = "0x10B5C530")]
    public static ushort EncryptDecrypt(ushort value, ushort key) => new ushort();

    [Token(Token = "0x600F621")]
    [Address(RVA = "0xB5C6B0", Offset = "0xB5B4B0", VA = "0x10B5C6B0")]
    public static ObscuredUShort FromEncrypted(ushort encrypted) => new ObscuredUShort();

    [Token(Token = "0x600F622")]
    [Address(RVA = "0xB5C2E0", Offset = "0xB5B0E0", VA = "0x10B5C2E0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F623")]
    [Address(RVA = "0xB5C8F0", Offset = "0xB5B6F0", VA = "0x10B5C8F0")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F624")]
    [Address(RVA = "0xB5C760", Offset = "0xB5B560", VA = "0x10B5C760")]
    public ushort GetEncrypted() => new ushort();

    [Token(Token = "0x600F625")]
    [Address(RVA = "0xB5C9D0", Offset = "0xB5B7D0", VA = "0x10B5C9D0")]
    public void SetEncrypted(ushort encrypted)
    {
    }

    [Token(Token = "0x600F626")]
    [Address(RVA = "0xB5C710", Offset = "0xB5B510", VA = "0x10B5C710")]
    public ushort GetDecrypted() => new ushort();

    [Token(Token = "0x600F627")]
    [Address(RVA = "0xB5C810", Offset = "0xB5B610", VA = "0x10B5C810")]
    private ushort InternalDecrypt() => new ushort();

    [Token(Token = "0x600F628")]
    [Address(RVA = "0xB5CF00", Offset = "0xB5BD00", VA = "0x10B5CF00")]
    public static implicit operator ObscuredUShort(ushort value) => new ObscuredUShort();

    [Token(Token = "0x600F629")]
    [Address(RVA = "0xB5CEB0", Offset = "0xB5BCB0", VA = "0x10B5CEB0")]
    public static implicit operator ushort(ObscuredUShort value) => new ushort();

    [Token(Token = "0x600F62A")]
    [Address(RVA = "0xB5CF30", Offset = "0xB5BD30", VA = "0x10B5CF30")]
    public static ObscuredUShort operator ++(ObscuredUShort input) => new ObscuredUShort();

    [Token(Token = "0x600F62B")]
    [Address(RVA = "0xB5CDE0", Offset = "0xB5BBE0", VA = "0x10B5CDE0")]
    public static ObscuredUShort operator --(ObscuredUShort input) => new ObscuredUShort();

    [Token(Token = "0x600F62C")]
    [Address(RVA = "0xB5C7B0", Offset = "0xB5B5B0", VA = "0x10B5C7B0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F62D")]
    [Address(RVA = "0xB5CBA0", Offset = "0xB5B9A0", VA = "0x10B5CBA0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F62E")]
    [Address(RVA = "0xB5CCC0", Offset = "0xB5BAC0", VA = "0x10B5CCC0")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F62F")]
    [Address(RVA = "0xB5CC60", Offset = "0xB5BA60", VA = "0x10B5CC60")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F630")]
    [Address(RVA = "0xB5CC00", Offset = "0xB5BA00", VA = "0x10B5CC00", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F631")]
    [Address(RVA = "0xB5C590", Offset = "0xB5B390", VA = "0x10B5C590", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F632")]
    [Address(RVA = "0xB5C630", Offset = "0xB5B430", VA = "0x10B5C630", Slot = "5")]
    public bool Equals(ObscuredUShort obj) => new bool();

    [Token(Token = "0x600F633")]
    [Address(RVA = "0xB5C380", Offset = "0xB5B180", VA = "0x10B5C380", Slot = "6")]
    public int CompareTo(ObscuredUShort other) => new int();

    [Token(Token = "0x600F634")]
    [Address(RVA = "0xB5C3F0", Offset = "0xB5B1F0", VA = "0x10B5C3F0", Slot = "7")]
    public int CompareTo(ushort other) => new int();

    [Token(Token = "0x600F635")]
    [Address(RVA = "0xB5C450", Offset = "0xB5B250", VA = "0x10B5C450", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F636")]
    [Address(RVA = "0xB5CD20", Offset = "0xB5BB20", VA = "0x10B5CD20")]
    static ObscuredUShort()
    {
    }
  }
}
