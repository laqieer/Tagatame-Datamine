// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredInt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x2003692")]
  [Serializable]
  public struct ObscuredInt : 
    IFormattable,
    IEquatable<ObscuredInt>,
    IComparable<ObscuredInt>,
    IComparable<int>,
    IComparable
  {
    [Token(Token = "0x4010001")]
    [FieldOffset(Offset = "0x0")]
    private static int cryptoKey;
    [Token(Token = "0x4010002")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private int currentCryptoKey;
    [Token(Token = "0x4010003")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private int hiddenValue;
    [Token(Token = "0x4010004")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x4010005")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private int fakeValue;
    [Token(Token = "0x4010006")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F4D1")]
    [Address(RVA = "0xB4E540", Offset = "0xB4D340", VA = "0x10B4E540")]
    private ObscuredInt(int value)
    {
    }

    [Token(Token = "0x600F4D2")]
    [Address(RVA = "0xB4E340", Offset = "0xB4D140", VA = "0x10B4E340")]
    public static void SetNewCryptoKey(int newKey)
    {
    }

    [Token(Token = "0x600F4D3")]
    [Address(RVA = "0xB4DD00", Offset = "0xB4CB00", VA = "0x10B4DD00")]
    public static int Encrypt(int value) => new int();

    [Token(Token = "0x600F4D4")]
    [Address(RVA = "0xB4DD80", Offset = "0xB4CB80", VA = "0x10B4DD80")]
    public static int Encrypt(int value, int key) => new int();

    [Token(Token = "0x600F4D5")]
    [Address(RVA = "0xB4DC20", Offset = "0xB4CA20", VA = "0x10B4DC20")]
    public static int Decrypt(int value) => new int();

    [Token(Token = "0x600F4D6")]
    [Address(RVA = "0xB4DCA0", Offset = "0xB4CAA0", VA = "0x10B4DCA0")]
    public static int Decrypt(int value, int key) => new int();

    [Token(Token = "0x600F4D7")]
    [Address(RVA = "0xB4DF60", Offset = "0xB4CD60", VA = "0x10B4DF60")]
    public static ObscuredInt FromEncrypted(int encrypted) => new ObscuredInt();

    [Token(Token = "0x600F4D8")]
    [Address(RVA = "0xB4DA30", Offset = "0xB4C830", VA = "0x10B4DA30")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F4D9")]
    [Address(RVA = "0xB4E1E0", Offset = "0xB4CFE0", VA = "0x10B4E1E0")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F4DA")]
    [Address(RVA = "0xB4E010", Offset = "0xB4CE10", VA = "0x10B4E010")]
    public int GetEncrypted() => new int();

    [Token(Token = "0x600F4DB")]
    [Address(RVA = "0xB4E2A0", Offset = "0xB4D0A0", VA = "0x10B4E2A0")]
    public void SetEncrypted(int encrypted)
    {
    }

    [Token(Token = "0x600F4DC")]
    [Address(RVA = "0xB4DFC0", Offset = "0xB4CDC0", VA = "0x10B4DFC0")]
    public int GetDecrypted() => new int();

    [Token(Token = "0x600F4DD")]
    [Address(RVA = "0xB4E0C0", Offset = "0xB4CEC0", VA = "0x10B4E0C0")]
    private int InternalDecrypt() => new int();

    [Token(Token = "0x600F4DE")]
    [Address(RVA = "0xB4E8E0", Offset = "0xB4D6E0", VA = "0x10B4E8E0")]
    public static implicit operator ObscuredInt(int value) => new ObscuredInt();

    [Token(Token = "0x600F4DF")]
    [Address(RVA = "0xB4E720", Offset = "0xB4D520", VA = "0x10B4E720")]
    public static implicit operator int(ObscuredInt value) => new int();

    [Token(Token = "0x600F4E0")]
    [Address(RVA = "0xB4E770", Offset = "0xB4D570", VA = "0x10B4E770")]
    public static implicit operator ObscuredFloat(ObscuredInt value) => new ObscuredFloat();

    [Token(Token = "0x600F4E1")]
    [Address(RVA = "0xB4E820", Offset = "0xB4D620", VA = "0x10B4E820")]
    public static implicit operator ObscuredDouble(ObscuredInt value) => new ObscuredDouble();

    [Token(Token = "0x600F4E2")]
    [Address(RVA = "0xB4E680", Offset = "0xB4D480", VA = "0x10B4E680")]
    public static explicit operator ObscuredUInt(ObscuredInt value) => new ObscuredUInt();

    [Token(Token = "0x600F4E3")]
    [Address(RVA = "0xB4E910", Offset = "0xB4D710", VA = "0x10B4E910")]
    public static ObscuredInt operator ++(ObscuredInt input) => new ObscuredInt();

    [Token(Token = "0x600F4E4")]
    [Address(RVA = "0xB4E5B0", Offset = "0xB4D3B0", VA = "0x10B4E5B0")]
    public static ObscuredInt operator --(ObscuredInt input) => new ObscuredInt();

    [Token(Token = "0x600F4E5")]
    [Address(RVA = "0xB4E060", Offset = "0xB4CE60", VA = "0x10B4E060", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F4E6")]
    [Address(RVA = "0xB4E450", Offset = "0xB4D250", VA = "0x10B4E450", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F4E7")]
    [Address(RVA = "0xB4E3F0", Offset = "0xB4D1F0", VA = "0x10B4E3F0")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F4E8")]
    [Address(RVA = "0xB4E4B0", Offset = "0xB4D2B0", VA = "0x10B4E4B0")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F4E9")]
    [Address(RVA = "0xB4E390", Offset = "0xB4D190", VA = "0x10B4E390", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F4EA")]
    [Address(RVA = "0xB4DED0", Offset = "0xB4CCD0", VA = "0x10B4DED0", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F4EB")]
    [Address(RVA = "0xB4DDE0", Offset = "0xB4CBE0", VA = "0x10B4DDE0", Slot = "5")]
    public bool Equals(ObscuredInt obj) => new bool();

    [Token(Token = "0x600F4EC")]
    [Address(RVA = "0xB4DB60", Offset = "0xB4C960", VA = "0x10B4DB60", Slot = "6")]
    public int CompareTo(ObscuredInt other) => new int();

    [Token(Token = "0x600F4ED")]
    [Address(RVA = "0xB4DBC0", Offset = "0xB4C9C0", VA = "0x10B4DBC0", Slot = "7")]
    public int CompareTo(int other) => new int();

    [Token(Token = "0x600F4EE")]
    [Address(RVA = "0xB4DB00", Offset = "0xB4C900", VA = "0x10B4DB00", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F4EF")]
    [Address(RVA = "0xB4E510", Offset = "0xB4D310", VA = "0x10B4E510")]
    static ObscuredInt()
    {
    }
  }
}
