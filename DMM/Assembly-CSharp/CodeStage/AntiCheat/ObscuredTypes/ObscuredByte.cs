// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredByte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200368A")]
  [Serializable]
  public struct ObscuredByte : 
    IFormattable,
    IEquatable<ObscuredByte>,
    IComparable<ObscuredByte>,
    IComparable<byte>,
    IComparable
  {
    [Token(Token = "0x400FFD7")]
    [FieldOffset(Offset = "0x0")]
    private static byte cryptoKey;
    [Token(Token = "0x400FFD8")]
    [FieldOffset(Offset = "0x0")]
    private byte currentCryptoKey;
    [Token(Token = "0x400FFD9")]
    [FieldOffset(Offset = "0x1")]
    private byte hiddenValue;
    [Token(Token = "0x400FFDA")]
    [FieldOffset(Offset = "0x2")]
    private bool inited;
    [Token(Token = "0x400FFDB")]
    [FieldOffset(Offset = "0x3")]
    private byte fakeValue;
    [Token(Token = "0x400FFDC")]
    [FieldOffset(Offset = "0x4")]
    private bool fakeValueActive;

    [Token(Token = "0x600F441")]
    [Address(RVA = "0xB48A60", Offset = "0xB47860", VA = "0x10B48A60")]
    private ObscuredByte(byte value)
    {
    }

    [Token(Token = "0x600F442")]
    [Address(RVA = "0xB48860", Offset = "0xB47660", VA = "0x10B48860")]
    public static void SetNewCryptoKey(byte newKey)
    {
    }

    [Token(Token = "0x600F443")]
    [Address(RVA = "0xB48290", Offset = "0xB47090", VA = "0x10B48290")]
    public static byte EncryptDecrypt(byte value) => new byte();

    [Token(Token = "0x600F444")]
    [Address(RVA = "0xB480D0", Offset = "0xB46ED0", VA = "0x10B480D0")]
    public static void EncryptDecrypt(byte[] value)
    {
    }

    [Token(Token = "0x600F445")]
    [Address(RVA = "0xB48230", Offset = "0xB47030", VA = "0x10B48230")]
    public static byte EncryptDecrypt(byte value, byte key) => new byte();

    [Token(Token = "0x600F446")]
    [Address(RVA = "0xB48190", Offset = "0xB46F90", VA = "0x10B48190")]
    public static void EncryptDecrypt(byte[] value, byte key)
    {
    }

    [Token(Token = "0x600F447")]
    [Address(RVA = "0xB48490", Offset = "0xB47290", VA = "0x10B48490")]
    public static ObscuredByte FromEncrypted(byte encrypted) => new ObscuredByte();

    [Token(Token = "0x600F448")]
    [Address(RVA = "0xB47EC0", Offset = "0xB46CC0", VA = "0x10B47EC0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F449")]
    [Address(RVA = "0xB48700", Offset = "0xB47500", VA = "0x10B48700")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F44A")]
    [Address(RVA = "0xB48540", Offset = "0xB47340", VA = "0x10B48540")]
    public byte GetEncrypted() => new byte();

    [Token(Token = "0x600F44B")]
    [Address(RVA = "0xB487C0", Offset = "0xB475C0", VA = "0x10B487C0")]
    public void SetEncrypted(byte encrypted)
    {
    }

    [Token(Token = "0x600F44C")]
    [Address(RVA = "0xB484F0", Offset = "0xB472F0", VA = "0x10B484F0")]
    public byte GetDecrypted() => new byte();

    [Token(Token = "0x600F44D")]
    [Address(RVA = "0xB485F0", Offset = "0xB473F0", VA = "0x10B485F0")]
    private byte InternalDecrypt() => new byte();

    [Token(Token = "0x600F44E")]
    [Address(RVA = "0xB48C00", Offset = "0xB47A00", VA = "0x10B48C00")]
    public static implicit operator ObscuredByte(byte value) => new ObscuredByte();

    [Token(Token = "0x600F44F")]
    [Address(RVA = "0xB48BB0", Offset = "0xB479B0", VA = "0x10B48BB0")]
    public static implicit operator byte(ObscuredByte value) => new byte();

    [Token(Token = "0x600F450")]
    [Address(RVA = "0xB48C30", Offset = "0xB47A30", VA = "0x10B48C30")]
    public static ObscuredByte operator ++(ObscuredByte input) => new ObscuredByte();

    [Token(Token = "0x600F451")]
    [Address(RVA = "0xB48AF0", Offset = "0xB478F0", VA = "0x10B48AF0")]
    public static ObscuredByte operator --(ObscuredByte input) => new ObscuredByte();

    [Token(Token = "0x600F452")]
    [Address(RVA = "0xB48590", Offset = "0xB47390", VA = "0x10B48590", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F453")]
    [Address(RVA = "0xB489D0", Offset = "0xB477D0", VA = "0x10B489D0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F454")]
    [Address(RVA = "0xB488B0", Offset = "0xB476B0", VA = "0x10B488B0")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F455")]
    [Address(RVA = "0xB48970", Offset = "0xB47770", VA = "0x10B48970")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F456")]
    [Address(RVA = "0xB48910", Offset = "0xB47710", VA = "0x10B48910", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F457")]
    [Address(RVA = "0xB48400", Offset = "0xB47200", VA = "0x10B48400", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F458")]
    [Address(RVA = "0xB48310", Offset = "0xB47110", VA = "0x10B48310", Slot = "5")]
    public bool Equals(ObscuredByte obj) => new bool();

    [Token(Token = "0x600F459")]
    [Address(RVA = "0xB48060", Offset = "0xB46E60", VA = "0x10B48060", Slot = "6")]
    public int CompareTo(ObscuredByte other) => new int();

    [Token(Token = "0x600F45A")]
    [Address(RVA = "0xB47F90", Offset = "0xB46D90", VA = "0x10B47F90", Slot = "7")]
    public int CompareTo(byte other) => new int();

    [Token(Token = "0x600F45B")]
    [Address(RVA = "0xB48000", Offset = "0xB46E00", VA = "0x10B48000", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F45C")]
    [Address(RVA = "0xB48A30", Offset = "0xB47830", VA = "0x10B48A30")]
    static ObscuredByte()
    {
    }
  }
}
