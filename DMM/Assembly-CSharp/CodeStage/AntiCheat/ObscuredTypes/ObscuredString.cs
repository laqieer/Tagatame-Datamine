// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x200369C")]
  [Serializable]
  public sealed class ObscuredString : IComparable<ObscuredString>, IComparable<string>, IComparable
  {
    [Token(Token = "0x401004B")]
    [FieldOffset(Offset = "0x0")]
    private static string cryptoKey;
    [Token(Token = "0x401004C")]
    [FieldOffset(Offset = "0x8")]
    [SerializeField]
    private string currentCryptoKey;
    [Token(Token = "0x401004D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private byte[] hiddenValue;
    [Token(Token = "0x401004E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x401004F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private string fakeValue;
    [Token(Token = "0x4010050")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F5C5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ObscuredString()
    {
    }

    [Token(Token = "0x600F5C6")]
    [Address(RVA = "0xB5A280", Offset = "0xB59080", VA = "0x10B5A280")]
    private ObscuredString(string value)
    {
    }

    [Token(Token = "0x600F5C7")]
    [Address(RVA = "0xB5A1D0", Offset = "0xB58FD0", VA = "0x10B5A1D0")]
    public static void SetNewCryptoKey(string newKey)
    {
    }

    [Token(Token = "0x600F5C8")]
    [Address(RVA = "0xB59430", Offset = "0xB58230", VA = "0x10B59430")]
    public static string EncryptDecrypt(string value) => (string) null;

    [Token(Token = "0x600F5C9")]
    [Address(RVA = "0xB59490", Offset = "0xB58290", VA = "0x10B59490")]
    public static string EncryptDecrypt(string value, string key) => (string) null;

    [Token(Token = "0x600F5CA")]
    [Address(RVA = "0xB598E0", Offset = "0xB586E0", VA = "0x10B598E0")]
    public static ObscuredString FromEncrypted(string encrypted) => (ObscuredString) null;

    [Token(Token = "0x600F5CB")]
    [Address(RVA = "0xB59230", Offset = "0xB58030", VA = "0x10B59230")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F5CC")]
    [Address(RVA = "0xB5A000", Offset = "0xB58E00", VA = "0x10B5A000")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F5CD")]
    [Address(RVA = "0xB59AD0", Offset = "0xB588D0", VA = "0x10B59AD0")]
    public string GetEncrypted() => (string) null;

    [Token(Token = "0x600F5CE")]
    [Address(RVA = "0xB5A0B0", Offset = "0xB58EB0", VA = "0x10B5A0B0")]
    public void SetEncrypted(string encrypted)
    {
    }

    [Token(Token = "0x600F5CF")]
    [Address(RVA = "0xB59AC0", Offset = "0xB588C0", VA = "0x10B59AC0")]
    public string GetDecrypted() => (string) null;

    [Token(Token = "0x600F5D0")]
    [Address(RVA = "0xB59FA0", Offset = "0xB58DA0", VA = "0x10B59FA0")]
    private static byte[] InternalEncrypt(string value) => (byte[]) null;

    [Token(Token = "0x600F5D1")]
    [Address(RVA = "0xB59EF0", Offset = "0xB58CF0", VA = "0x10B59EF0")]
    private static byte[] InternalEncrypt(string value, string key) => (byte[]) null;

    [Token(Token = "0x600F5D2")]
    [Address(RVA = "0xB59CF0", Offset = "0xB58AF0", VA = "0x10B59CF0")]
    private string InternalDecrypt() => (string) null;

    [Token(Token = "0x17002360")]
    public int Length
    {
      [Token(Token = "0x600F5D3"), Address(RVA = "0xB5A360", Offset = "0xB59160", VA = "0x10B5A360")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F5D4")]
    [Address(RVA = "0xB5A490", Offset = "0xB59290", VA = "0x10B5A490")]
    public static implicit operator ObscuredString(string value) => (ObscuredString) null;

    [Token(Token = "0x600F5D5")]
    [Address(RVA = "0xB5A5B0", Offset = "0xB593B0", VA = "0x10B5A5B0")]
    public static implicit operator string(ObscuredString value) => (string) null;

    [Token(Token = "0x600F5D6")]
    [Address(RVA = "0xB5A380", Offset = "0xB59180", VA = "0x10B5A380")]
    public static bool operator ==(ObscuredString a, ObscuredString b) => new bool();

    [Token(Token = "0x600F5D7")]
    [Address(RVA = "0xB5A620", Offset = "0xB59420", VA = "0x10B5A620")]
    public static bool operator !=(ObscuredString a, ObscuredString b) => new bool();

    [Token(Token = "0x600F5D8")]
    [Address(RVA = "0xB59C50", Offset = "0xB58A50", VA = "0x10B59C50", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F5D9")]
    [Address(RVA = "0xB59AC0", Offset = "0xB588C0", VA = "0x10B59AC0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F5DA")]
    [Address(RVA = "0xB59650", Offset = "0xB58450", VA = "0x10B59650", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F5DB")]
    [Address(RVA = "0xB597C0", Offset = "0xB585C0", VA = "0x10B597C0")]
    public bool Equals(ObscuredString value) => new bool();

    [Token(Token = "0x600F5DC")]
    [Address(RVA = "0xB595C0", Offset = "0xB583C0", VA = "0x10B595C0")]
    public bool Equals(ObscuredString value, StringComparison comparisonType) => new bool();

    [Token(Token = "0x600F5DD")]
    [Address(RVA = "0xB593C0", Offset = "0xB581C0", VA = "0x10B593C0", Slot = "4")]
    public int CompareTo(ObscuredString other) => new int();

    [Token(Token = "0x600F5DE")]
    [Address(RVA = "0xB59390", Offset = "0xB58190", VA = "0x10B59390", Slot = "5")]
    public int CompareTo(string other) => new int();

    [Token(Token = "0x600F5DF")]
    [Address(RVA = "0xB59400", Offset = "0xB58200", VA = "0x10B59400", Slot = "6")]
    public int CompareTo(object obj) => new int();

    [Token(Token = "0x600F5E0")]
    [Address(RVA = "0xB59A50", Offset = "0xB58850", VA = "0x10B59A50")]
    private static byte[] GetBytes(string str) => (byte[]) null;

    [Token(Token = "0x600F5E1")]
    [Address(RVA = "0xB59C80", Offset = "0xB58A80", VA = "0x10B59C80")]
    private static string GetString(byte[] bytes) => (string) null;

    [Token(Token = "0x600F5E2")]
    [Address(RVA = "0xB59320", Offset = "0xB58120", VA = "0x10B59320")]
    private static bool ArraysEquals(byte[] a1, byte[] a2) => new bool();

    [Token(Token = "0x600F5E3")]
    [Address(RVA = "0xB5A230", Offset = "0xB59030", VA = "0x10B5A230")]
    static ObscuredString()
    {
    }
  }
}
