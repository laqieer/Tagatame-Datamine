// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200369A")]
  [Serializable]
  public struct ObscuredSByte : 
    IFormattable,
    IEquatable<ObscuredSByte>,
    IComparable<ObscuredSByte>,
    IComparable<sbyte>,
    IComparable
  {
    [Token(Token = "0x401003F")]
    [FieldOffset(Offset = "0x0")]
    private static sbyte cryptoKey;
    [Token(Token = "0x4010040")]
    [FieldOffset(Offset = "0x0")]
    private sbyte currentCryptoKey;
    [Token(Token = "0x4010041")]
    [FieldOffset(Offset = "0x1")]
    private sbyte hiddenValue;
    [Token(Token = "0x4010042")]
    [FieldOffset(Offset = "0x2")]
    private bool inited;
    [Token(Token = "0x4010043")]
    [FieldOffset(Offset = "0x3")]
    private sbyte fakeValue;
    [Token(Token = "0x4010044")]
    [FieldOffset(Offset = "0x4")]
    private bool fakeValueActive;

    [Token(Token = "0x600F591")]
    [Address(RVA = "0xB582F0", Offset = "0xB570F0", VA = "0x10B582F0")]
    private ObscuredSByte(sbyte value)
    {
    }

    [Token(Token = "0x600F592")]
    [Address(RVA = "0xB580F0", Offset = "0xB56EF0", VA = "0x10B580F0")]
    public static void SetNewCryptoKey(sbyte newKey)
    {
    }

    [Token(Token = "0x600F593")]
    [Address(RVA = "0xB57AB0", Offset = "0xB568B0", VA = "0x10B57AB0")]
    public static sbyte EncryptDecrypt(sbyte value) => new sbyte();

    [Token(Token = "0x600F594")]
    [Address(RVA = "0xB57B30", Offset = "0xB56930", VA = "0x10B57B30")]
    public static sbyte EncryptDecrypt(sbyte value, sbyte key) => new sbyte();

    [Token(Token = "0x600F595")]
    [Address(RVA = "0xB57D10", Offset = "0xB56B10", VA = "0x10B57D10")]
    public static ObscuredSByte FromEncrypted(sbyte encrypted) => new ObscuredSByte();

    [Token(Token = "0x600F596")]
    [Address(RVA = "0xB578B0", Offset = "0xB566B0", VA = "0x10B578B0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F597")]
    [Address(RVA = "0xB57F90", Offset = "0xB56D90", VA = "0x10B57F90")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F598")]
    [Address(RVA = "0xB57DC0", Offset = "0xB56BC0", VA = "0x10B57DC0")]
    public sbyte GetEncrypted() => new sbyte();

    [Token(Token = "0x600F599")]
    [Address(RVA = "0xB58050", Offset = "0xB56E50", VA = "0x10B58050")]
    public void SetEncrypted(sbyte encrypted)
    {
    }

    [Token(Token = "0x600F59A")]
    [Address(RVA = "0xB57D70", Offset = "0xB56B70", VA = "0x10B57D70")]
    public sbyte GetDecrypted() => new sbyte();

    [Token(Token = "0x600F59B")]
    [Address(RVA = "0xB57E70", Offset = "0xB56C70", VA = "0x10B57E70")]
    private sbyte InternalDecrypt() => new sbyte();

    [Token(Token = "0x600F59C")]
    [Address(RVA = "0xB58440", Offset = "0xB57240", VA = "0x10B58440")]
    public static implicit operator ObscuredSByte(sbyte value) => new ObscuredSByte();

    [Token(Token = "0x600F59D")]
    [Address(RVA = "0xB58470", Offset = "0xB57270", VA = "0x10B58470")]
    public static implicit operator sbyte(ObscuredSByte value) => new sbyte();

    [Token(Token = "0x600F59E")]
    [Address(RVA = "0xB584C0", Offset = "0xB572C0", VA = "0x10B584C0")]
    public static ObscuredSByte operator ++(ObscuredSByte input) => new ObscuredSByte();

    [Token(Token = "0x600F59F")]
    [Address(RVA = "0xB58380", Offset = "0xB57180", VA = "0x10B58380")]
    public static ObscuredSByte operator --(ObscuredSByte input) => new ObscuredSByte();

    [Token(Token = "0x600F5A0")]
    [Address(RVA = "0xB57E10", Offset = "0xB56C10", VA = "0x10B57E10", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F5A1")]
    [Address(RVA = "0xB58200", Offset = "0xB57000", VA = "0x10B58200", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F5A2")]
    [Address(RVA = "0xB58140", Offset = "0xB56F40", VA = "0x10B58140")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F5A3")]
    [Address(RVA = "0xB581A0", Offset = "0xB56FA0", VA = "0x10B581A0")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F5A4")]
    [Address(RVA = "0xB58260", Offset = "0xB57060", VA = "0x10B58260", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F5A5")]
    [Address(RVA = "0xB57C80", Offset = "0xB56A80", VA = "0x10B57C80", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F5A6")]
    [Address(RVA = "0xB57B90", Offset = "0xB56990", VA = "0x10B57B90", Slot = "5")]
    public bool Equals(ObscuredSByte obj) => new bool();

    [Token(Token = "0x600F5A7")]
    [Address(RVA = "0xB579E0", Offset = "0xB567E0", VA = "0x10B579E0", Slot = "6")]
    public int CompareTo(ObscuredSByte other) => new int();

    [Token(Token = "0x600F5A8")]
    [Address(RVA = "0xB57980", Offset = "0xB56780", VA = "0x10B57980", Slot = "7")]
    public int CompareTo(sbyte other) => new int();

    [Token(Token = "0x600F5A9")]
    [Address(RVA = "0xB57A50", Offset = "0xB56850", VA = "0x10B57A50", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F5AA")]
    [Address(RVA = "0xB582C0", Offset = "0xB570C0", VA = "0x10B582C0")]
    static ObscuredSByte()
    {
    }
  }
}
