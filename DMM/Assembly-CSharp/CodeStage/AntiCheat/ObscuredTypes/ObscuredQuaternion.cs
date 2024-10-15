// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x2003698")]
  [Serializable]
  public struct ObscuredQuaternion
  {
    [Token(Token = "0x4010034")]
    [FieldOffset(Offset = "0x0")]
    private static int cryptoKey;
    [Token(Token = "0x4010035")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Quaternion identity;
    [Token(Token = "0x4010036")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private int currentCryptoKey;
    [Token(Token = "0x4010037")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;
    [Token(Token = "0x4010038")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x4010039")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Quaternion fakeValue;
    [Token(Token = "0x401003A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F57B")]
    [Address(RVA = "0xB57650", Offset = "0xB56450", VA = "0x10B57650")]
    private ObscuredQuaternion(Quaternion value)
    {
    }

    [Token(Token = "0x600F57C")]
    [Address(RVA = "0xB57710", Offset = "0xB56510", VA = "0x10B57710")]
    public ObscuredQuaternion(float x, float y, float z, float w)
    {
    }

    [Token(Token = "0x600F57D")]
    [Address(RVA = "0xB574D0", Offset = "0xB562D0", VA = "0x10B574D0")]
    public static void SetNewCryptoKey(int newKey)
    {
    }

    [Token(Token = "0x600F57E")]
    [Address(RVA = "0xB56DD0", Offset = "0xB55BD0", VA = "0x10B56DD0")]
    public static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(Quaternion value)
    {
      return new ObscuredQuaternion.RawEncryptedQuaternion();
    }

    [Token(Token = "0x600F57F")]
    [Address(RVA = "0xB56E60", Offset = "0xB55C60", VA = "0x10B56E60")]
    public static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(Quaternion value, int key)
    {
      return new ObscuredQuaternion.RawEncryptedQuaternion();
    }

    [Token(Token = "0x600F580")]
    [Address(RVA = "0xB56EC0", Offset = "0xB55CC0", VA = "0x10B56EC0")]
    public static ObscuredQuaternion.RawEncryptedQuaternion Encrypt(
      float x,
      float y,
      float z,
      float w,
      int key)
    {
      return new ObscuredQuaternion.RawEncryptedQuaternion();
    }

    [Token(Token = "0x600F581")]
    [Address(RVA = "0xB56BC0", Offset = "0xB559C0", VA = "0x10B56BC0")]
    public static Quaternion Decrypt(ObscuredQuaternion.RawEncryptedQuaternion value)
    {
      return new Quaternion();
    }

    [Token(Token = "0x600F582")]
    [Address(RVA = "0xB56CE0", Offset = "0xB55AE0", VA = "0x10B56CE0")]
    public static Quaternion Decrypt(ObscuredQuaternion.RawEncryptedQuaternion value, int key)
    {
      return new Quaternion();
    }

    [Token(Token = "0x600F583")]
    [Address(RVA = "0xB56FB0", Offset = "0xB55DB0", VA = "0x10B56FB0")]
    public static ObscuredQuaternion FromEncrypted(
      ObscuredQuaternion.RawEncryptedQuaternion encrypted)
    {
      return new ObscuredQuaternion();
    }

    [Token(Token = "0x600F584")]
    [Address(RVA = "0xB569D0", Offset = "0xB557D0", VA = "0x10B569D0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F585")]
    [Address(RVA = "0xB57350", Offset = "0xB56150", VA = "0x10B57350")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F586")]
    [Address(RVA = "0xB57080", Offset = "0xB55E80", VA = "0x10B57080")]
    public ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted()
    {
      return new ObscuredQuaternion.RawEncryptedQuaternion();
    }

    [Token(Token = "0x600F587")]
    [Address(RVA = "0xB57430", Offset = "0xB56230", VA = "0x10B57430")]
    public void SetEncrypted(
      ObscuredQuaternion.RawEncryptedQuaternion encrypted)
    {
    }

    [Token(Token = "0x600F588")]
    [Address(RVA = "0xB57020", Offset = "0xB55E20", VA = "0x10B57020")]
    public Quaternion GetDecrypted() => new Quaternion();

    [Token(Token = "0x600F589")]
    [Address(RVA = "0xB57170", Offset = "0xB55F70", VA = "0x10B57170")]
    private Quaternion InternalDecrypt() => new Quaternion();

    [Token(Token = "0x600F58A")]
    [Address(RVA = "0xB56A80", Offset = "0xB55880", VA = "0x10B56A80")]
    private bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2) => new bool();

    [Token(Token = "0x600F58B")]
    [Address(RVA = "0xB57820", Offset = "0xB56620", VA = "0x10B57820")]
    public static implicit operator ObscuredQuaternion(Quaternion value)
    {
      return new ObscuredQuaternion();
    }

    [Token(Token = "0x600F58C")]
    [Address(RVA = "0xB57850", Offset = "0xB56650", VA = "0x10B57850")]
    public static implicit operator Quaternion(ObscuredQuaternion value) => new Quaternion();

    [Token(Token = "0x600F58D")]
    [Address(RVA = "0xB570D0", Offset = "0xB55ED0", VA = "0x10B570D0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F58E")]
    [Address(RVA = "0xB57520", Offset = "0xB56320", VA = "0x10B57520", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F58F")]
    [Address(RVA = "0xB57580", Offset = "0xB56380", VA = "0x10B57580")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F590")]
    [Address(RVA = "0xB575F0", Offset = "0xB563F0", VA = "0x10B575F0")]
    static ObscuredQuaternion()
    {
    }

    [Token(Token = "0x2003699")]
    [Serializable]
    public struct RawEncryptedQuaternion
    {
      [Token(Token = "0x401003B")]
      [FieldOffset(Offset = "0x0")]
      public int x;
      [Token(Token = "0x401003C")]
      [FieldOffset(Offset = "0x4")]
      public int y;
      [Token(Token = "0x401003D")]
      [FieldOffset(Offset = "0x8")]
      public int z;
      [Token(Token = "0x401003E")]
      [FieldOffset(Offset = "0xC")]
      public int w;
    }
  }
}
