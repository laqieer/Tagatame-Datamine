// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat
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
  [Token(Token = "0x2003690")]
  [Serializable]
  public struct ObscuredFloat : 
    IFormattable,
    IEquatable<ObscuredFloat>,
    IComparable<ObscuredFloat>,
    IComparable<float>,
    IComparable
  {
    [Token(Token = "0x400FFF7")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    private static int cryptoKey;
    [Token(Token = "0x400FFF8")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    [SerializeField]
    private int currentCryptoKey;
    [Token(Token = "0x400FFF9")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x4")]
    [SerializeField]
    private int hiddenValue;
    [Token(Token = "0x400FFFA")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
    [FormerlySerializedAs("hiddenValue")]
    [SerializeField]
    private ACTkByte4 hiddenValueOldByte4;
    [Token(Token = "0x400FFFB")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xC")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x400FFFC")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
    [SerializeField]
    private float fakeValue;
    [Token(Token = "0x400FFFD")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F4B3")]
    [Address(RVA = "0xB4D780", Offset = "0xB4C580", VA = "0x10B4D780")]
    private ObscuredFloat(float value)
    {
    }

    [Token(Token = "0x600F4B4")]
    [Address(RVA = "0xB4D580", Offset = "0xB4C380", VA = "0x10B4D580")]
    public static void SetNewCryptoKey(int newKey)
    {
    }

    [Token(Token = "0x600F4B5")]
    [Address(RVA = "0xB4CD10", Offset = "0xB4BB10", VA = "0x10B4CD10")]
    public static int Encrypt(float value) => new int();

    [Token(Token = "0x600F4B6")]
    [Address(RVA = "0xB4CCE0", Offset = "0xB4BAE0", VA = "0x10B4CCE0")]
    public static int Encrypt(float value, int key) => new int();

    [Token(Token = "0x600F4B7")]
    [Address(RVA = "0xB4D1D0", Offset = "0xB4BFD0", VA = "0x10B4D1D0")]
    private static int InternalEncrypt(float value, int key = 0) => new int();

    [Token(Token = "0x600F4B8")]
    [Address(RVA = "0xB4CC80", Offset = "0xB4BA80", VA = "0x10B4CC80")]
    public static float Decrypt(int value) => new float();

    [Token(Token = "0x600F4B9")]
    [Address(RVA = "0xB4CC50", Offset = "0xB4BA50", VA = "0x10B4CC50")]
    public static float Decrypt(int value, int key) => new float();

    [Token(Token = "0x600F4BA")]
    [Address(RVA = "0xB4D250", Offset = "0xB4C050", VA = "0x10B4D250")]
    public static int MigrateEncrypted(int encrypted, byte fromVersion = 0, byte toVersion = 2)
    {
      return new int();
    }

    [Token(Token = "0x600F4BB")]
    [Address(RVA = "0xB4CE90", Offset = "0xB4BC90", VA = "0x10B4CE90")]
    public static ObscuredFloat FromEncrypted(int encrypted) => new ObscuredFloat();

    [Token(Token = "0x600F4BC")]
    [Address(RVA = "0xB4CA60", Offset = "0xB4B860", VA = "0x10B4CA60")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F4BD")]
    [Address(RVA = "0xB4D280", Offset = "0xB4C080", VA = "0x10B4D280")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F4BE")]
    [Address(RVA = "0xB4CF40", Offset = "0xB4BD40", VA = "0x10B4CF40")]
    public int GetEncrypted() => new int();

    [Token(Token = "0x600F4BF")]
    [Address(RVA = "0xB4D320", Offset = "0xB4C120", VA = "0x10B4D320")]
    public void SetEncrypted(int encrypted)
    {
    }

    [Token(Token = "0x600F4C0")]
    [Address(RVA = "0xB4CEF0", Offset = "0xB4BCF0", VA = "0x10B4CEF0")]
    public float GetDecrypted() => new float();

    [Token(Token = "0x600F4C1")]
    [Address(RVA = "0xB4D000", Offset = "0xB4BE00", VA = "0x10B4D000")]
    private float InternalDecrypt() => new float();

    [Token(Token = "0x600F4C2")]
    [Address(RVA = "0xB4D910", Offset = "0xB4C710", VA = "0x10B4D910")]
    public static implicit operator ObscuredFloat(float value) => new ObscuredFloat();

    [Token(Token = "0x600F4C3")]
    [Address(RVA = "0xB4D940", Offset = "0xB4C740", VA = "0x10B4D940")]
    public static implicit operator float(ObscuredFloat value) => new float();

    [Token(Token = "0x600F4C4")]
    [Address(RVA = "0xB4D990", Offset = "0xB4C790", VA = "0x10B4D990")]
    public static ObscuredFloat operator ++(ObscuredFloat input) => new ObscuredFloat();

    [Token(Token = "0x600F4C5")]
    [Address(RVA = "0xB4D870", Offset = "0xB4C670", VA = "0x10B4D870")]
    public static ObscuredFloat operator --(ObscuredFloat input) => new ObscuredFloat();

    [Token(Token = "0x600F4C6")]
    [Address(RVA = "0xB4CF90", Offset = "0xB4BD90", VA = "0x10B4CF90", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F4C7")]
    [Address(RVA = "0xB4D690", Offset = "0xB4C490", VA = "0x10B4D690", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F4C8")]
    [Address(RVA = "0xB4D630", Offset = "0xB4C430", VA = "0x10B4D630")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F4C9")]
    [Address(RVA = "0xB4D6F0", Offset = "0xB4C4F0", VA = "0x10B4D6F0")]
    public string ToString(IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F4CA")]
    [Address(RVA = "0xB4D5D0", Offset = "0xB4C3D0", VA = "0x10B4D5D0", Slot = "4")]
    public string ToString(string format, IFormatProvider provider) => (string) null;

    [Token(Token = "0x600F4CB")]
    [Address(RVA = "0xB4CDF0", Offset = "0xB4BBF0", VA = "0x10B4CDF0", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F4CC")]
    [Address(RVA = "0xB4CD70", Offset = "0xB4BB70", VA = "0x10B4CD70", Slot = "5")]
    public bool Equals(ObscuredFloat obj) => new bool();

    [Token(Token = "0x600F4CD")]
    [Address(RVA = "0xB4CB70", Offset = "0xB4B970", VA = "0x10B4CB70", Slot = "6")]
    public int CompareTo(ObscuredFloat other) => new int();

    [Token(Token = "0x600F4CE")]
    [Address(RVA = "0xB4CB00", Offset = "0xB4B900", VA = "0x10B4CB00", Slot = "7")]
    public int CompareTo(float other) => new int();

    [Token(Token = "0x600F4CF")]
    [Address(RVA = "0xB4CBF0", Offset = "0xB4B9F0", VA = "0x10B4CBF0", Slot = "8")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F4D0")]
    [Address(RVA = "0xB4D750", Offset = "0xB4C550", VA = "0x10B4D750")]
    static ObscuredFloat()
    {
    }

    [Token(Token = "0x2003691")]
    [StructLayout(LayoutKind.Explicit)]
    internal struct FloatIntBytesUnion
    {
      [Token(Token = "0x400FFFE")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public float f;
      [Token(Token = "0x400FFFF")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public int i;
      [Token(Token = "0x4010000")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
      public ACTkByte4 b4;
    }
  }
}
