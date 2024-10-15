// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredBool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Serialization;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x2003689")]
  [Serializable]
  public struct ObscuredBool : 
    IEquatable<ObscuredBool>,
    IComparable<ObscuredBool>,
    IComparable<bool>,
    IComparable
  {
    [Token(Token = "0x400FFD1")]
    [FieldOffset(Offset = "0x0")]
    private static byte cryptoKey;
    [Token(Token = "0x400FFD2")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private byte currentCryptoKey;
    [Token(Token = "0x400FFD3")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private int hiddenValue;
    [Token(Token = "0x400FFD4")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x400FFD5")]
    [FieldOffset(Offset = "0x9")]
    [SerializeField]
    private bool fakeValue;
    [Token(Token = "0x400FFD6")]
    [FieldOffset(Offset = "0xA")]
    [SerializeField]
    [FormerlySerializedAs("fakeValueChanged")]
    private bool fakeValueActive;

    [Token(Token = "0x600F42A")]
    [Address(RVA = "0xB47DB0", Offset = "0xB46BB0", VA = "0x10B47DB0")]
    private ObscuredBool(bool value)
    {
    }

    [Token(Token = "0x600F42B")]
    [Address(RVA = "0xB47CB0", Offset = "0xB46AB0", VA = "0x10B47CB0")]
    public static void SetNewCryptoKey(byte newKey)
    {
    }

    [Token(Token = "0x600F42C")]
    [Address(RVA = "0xB47640", Offset = "0xB46440", VA = "0x10B47640")]
    public static int Encrypt(bool value) => new int();

    [Token(Token = "0x600F42D")]
    [Address(RVA = "0xB476D0", Offset = "0xB464D0", VA = "0x10B476D0")]
    public static int Encrypt(bool value, byte key) => new int();

    [Token(Token = "0x600F42E")]
    [Address(RVA = "0xB475C0", Offset = "0xB463C0", VA = "0x10B475C0")]
    public static bool Decrypt(int value) => new bool();

    [Token(Token = "0x600F42F")]
    [Address(RVA = "0xB47560", Offset = "0xB46360", VA = "0x10B47560")]
    public static bool Decrypt(int value, byte key) => new bool();

    [Token(Token = "0x600F430")]
    [Address(RVA = "0xB47850", Offset = "0xB46650", VA = "0x10B47850")]
    public static ObscuredBool FromEncrypted(int encrypted) => new ObscuredBool();

    [Token(Token = "0x600F431")]
    [Address(RVA = "0xB47330", Offset = "0xB46130", VA = "0x10B47330")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F432")]
    [Address(RVA = "0xB47A90", Offset = "0xB46890", VA = "0x10B47A90")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F433")]
    [Address(RVA = "0xB47900", Offset = "0xB46700", VA = "0x10B47900")]
    public int GetEncrypted() => new int();

    [Token(Token = "0x600F434")]
    [Address(RVA = "0xB47B70", Offset = "0xB46970", VA = "0x10B47B70")]
    public void SetEncrypted(int encrypted)
    {
    }

    [Token(Token = "0x600F435")]
    [Address(RVA = "0xB478B0", Offset = "0xB466B0", VA = "0x10B478B0")]
    public bool GetDecrypted() => new bool();

    [Token(Token = "0x600F436")]
    [Address(RVA = "0xB479D0", Offset = "0xB467D0", VA = "0x10B479D0")]
    private bool InternalDecrypt() => new bool();

    [Token(Token = "0x600F437")]
    [Address(RVA = "0xB47E90", Offset = "0xB46C90", VA = "0x10B47E90")]
    public static implicit operator ObscuredBool(bool value) => new ObscuredBool();

    [Token(Token = "0x600F438")]
    [Address(RVA = "0xB47E40", Offset = "0xB46C40", VA = "0x10B47E40")]
    public static implicit operator bool(ObscuredBool value) => new bool();

    [Token(Token = "0x600F439")]
    [Address(RVA = "0xB47950", Offset = "0xB46750", VA = "0x10B47950", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F43A")]
    [Address(RVA = "0xB47D00", Offset = "0xB46B00", VA = "0x10B47D00", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F43B")]
    [Address(RVA = "0xB477B0", Offset = "0xB465B0", VA = "0x10B477B0", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F43C")]
    [Address(RVA = "0xB47730", Offset = "0xB46530", VA = "0x10B47730", Slot = "4")]
    public bool Equals(ObscuredBool obj) => new bool();

    [Token(Token = "0x600F43D")]
    [Address(RVA = "0xB473D0", Offset = "0xB461D0", VA = "0x10B473D0", Slot = "5")]
    public int CompareTo(ObscuredBool other) => new int();

    [Token(Token = "0x600F43E")]
    [Address(RVA = "0xB474E0", Offset = "0xB462E0", VA = "0x10B474E0", Slot = "6")]
    public int CompareTo(bool other) => new int();

    [Token(Token = "0x600F43F")]
    [Address(RVA = "0xB47460", Offset = "0xB46260", VA = "0x10B47460", Slot = "7")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F440")]
    [Address(RVA = "0xB47D80", Offset = "0xB46B80", VA = "0x10B47D80")]
    static ObscuredBool()
    {
    }
  }
}
