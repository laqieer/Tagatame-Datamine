// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x20036A0")]
  [Serializable]
  public struct ObscuredVector2
  {
    [Token(Token = "0x4010063")]
    [FieldOffset(Offset = "0x0")]
    private static int cryptoKey;
    [Token(Token = "0x4010064")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Vector2 zero;
    [Token(Token = "0x4010065")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private int currentCryptoKey;
    [Token(Token = "0x4010066")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private ObscuredVector2.RawEncryptedVector2 hiddenValue;
    [Token(Token = "0x4010067")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x4010068")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Vector2 fakeValue;
    [Token(Token = "0x4010069")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F637")]
    [Address(RVA = "0xB5F0C0", Offset = "0xB5DEC0", VA = "0x10B5F0C0")]
    private ObscuredVector2(Vector2 value)
    {
    }

    [Token(Token = "0x600F638")]
    [Address(RVA = "0xB5F170", Offset = "0xB5DF70", VA = "0x10B5F170")]
    public ObscuredVector2(float x, float y)
    {
    }

    [Token(Token = "0x17002361")]
    public float x
    {
      [Token(Token = "0x600F639"), Address(RVA = "0xB5F310", Offset = "0xB5E110", VA = "0x10B5F310")] get
      {
        return new float();
      }
      [Token(Token = "0x600F63A"), Address(RVA = "0xB5F740", Offset = "0xB5E540", VA = "0x10B5F740")] set
      {
      }
    }

    [Token(Token = "0x17002362")]
    public float y
    {
      [Token(Token = "0x600F63B"), Address(RVA = "0xB5F440", Offset = "0xB5E240", VA = "0x10B5F440")] get
      {
        return new float();
      }
      [Token(Token = "0x600F63C"), Address(RVA = "0xB5F7E0", Offset = "0xB5E5E0", VA = "0x10B5F7E0")] set
      {
      }
    }

    [Token(Token = "0x17002363")]
    public float this[int index]
    {
      [Token(Token = "0x600F63D"), Address(RVA = "0xB5F250", Offset = "0xB5E050", VA = "0x10B5F250")] get
      {
        return new float();
      }
      [Token(Token = "0x600F63E"), Address(RVA = "0xB5F660", Offset = "0xB5E460", VA = "0x10B5F660")] set
      {
      }
    }

    [Token(Token = "0x600F63F")]
    [Address(RVA = "0xB5EF30", Offset = "0xB5DD30", VA = "0x10B5EF30")]
    public static void SetNewCryptoKey(int newKey)
    {
    }

    [Token(Token = "0x600F640")]
    [Address(RVA = "0xB5E680", Offset = "0xB5D480", VA = "0x10B5E680")]
    public static ObscuredVector2.RawEncryptedVector2 Encrypt(Vector2 value)
    {
      return new ObscuredVector2.RawEncryptedVector2();
    }

    [Token(Token = "0x600F641")]
    [Address(RVA = "0xB5E620", Offset = "0xB5D420", VA = "0x10B5E620")]
    public static ObscuredVector2.RawEncryptedVector2 Encrypt(Vector2 value, int key)
    {
      return new ObscuredVector2.RawEncryptedVector2();
    }

    [Token(Token = "0x600F642")]
    [Address(RVA = "0xB5E710", Offset = "0xB5D510", VA = "0x10B5E710")]
    public static ObscuredVector2.RawEncryptedVector2 Encrypt(float x, float y, int key)
    {
      return new ObscuredVector2.RawEncryptedVector2();
    }

    [Token(Token = "0x600F643")]
    [Address(RVA = "0xB5E550", Offset = "0xB5D350", VA = "0x10B5E550")]
    public static Vector2 Decrypt(ObscuredVector2.RawEncryptedVector2 value) => new Vector2();

    [Token(Token = "0x600F644")]
    [Address(RVA = "0xB5E4B0", Offset = "0xB5D2B0", VA = "0x10B5E4B0")]
    public static Vector2 Decrypt(ObscuredVector2.RawEncryptedVector2 value, int key)
    {
      return new Vector2();
    }

    [Token(Token = "0x600F645")]
    [Address(RVA = "0xB5E7B0", Offset = "0xB5D5B0", VA = "0x10B5E7B0")]
    public static ObscuredVector2 FromEncrypted(ObscuredVector2.RawEncryptedVector2 encrypted)
    {
      return new ObscuredVector2();
    }

    [Token(Token = "0x600F646")]
    [Address(RVA = "0xB5E2F0", Offset = "0xB5D0F0", VA = "0x10B5E2F0")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F647")]
    [Address(RVA = "0xB5EBF0", Offset = "0xB5D9F0", VA = "0x10B5EBF0")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F648")]
    [Address(RVA = "0xB5E860", Offset = "0xB5D660", VA = "0x10B5E860")]
    public ObscuredVector2.RawEncryptedVector2 GetEncrypted()
    {
      return new ObscuredVector2.RawEncryptedVector2();
    }

    [Token(Token = "0x600F649")]
    [Address(RVA = "0xB5ECD0", Offset = "0xB5DAD0", VA = "0x10B5ECD0")]
    public void SetEncrypted(ObscuredVector2.RawEncryptedVector2 encrypted)
    {
    }

    [Token(Token = "0x600F64A")]
    [Address(RVA = "0xB5E810", Offset = "0xB5D610", VA = "0x10B5E810")]
    public Vector2 GetDecrypted() => new Vector2();

    [Token(Token = "0x600F64B")]
    [Address(RVA = "0xB5E9B0", Offset = "0xB5D7B0", VA = "0x10B5E9B0")]
    private Vector2 InternalDecrypt() => new Vector2();

    [Token(Token = "0x600F64C")]
    [Address(RVA = "0xB5E3E0", Offset = "0xB5D1E0", VA = "0x10B5E3E0")]
    private bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2) => new bool();

    [Token(Token = "0x600F64D")]
    [Address(RVA = "0xB5E920", Offset = "0xB5D720", VA = "0x10B5E920")]
    private float InternalDecryptField(int encrypted) => new float();

    [Token(Token = "0x600F64E")]
    [Address(RVA = "0xB5EB70", Offset = "0xB5D970", VA = "0x10B5EB70")]
    private int InternalEncryptField(float encrypted) => new int();

    [Token(Token = "0x600F64F")]
    [Address(RVA = "0xB5F630", Offset = "0xB5E430", VA = "0x10B5F630")]
    public static implicit operator ObscuredVector2(Vector2 value) => new ObscuredVector2();

    [Token(Token = "0x600F650")]
    [Address(RVA = "0xB5F5E0", Offset = "0xB5E3E0", VA = "0x10B5F5E0")]
    public static implicit operator Vector2(ObscuredVector2 value) => new Vector2();

    [Token(Token = "0x600F651")]
    [Address(RVA = "0xB5F570", Offset = "0xB5E370", VA = "0x10B5F570")]
    public static implicit operator Vector3(ObscuredVector2 value) => new Vector3();

    [Token(Token = "0x600F652")]
    [Address(RVA = "0xB5E8B0", Offset = "0xB5D6B0", VA = "0x10B5E8B0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F653")]
    [Address(RVA = "0xB5EFF0", Offset = "0xB5DDF0", VA = "0x10B5EFF0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F654")]
    [Address(RVA = "0xB5EF80", Offset = "0xB5DD80", VA = "0x10B5EF80")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F655")]
    [Address(RVA = "0xB5F050", Offset = "0xB5DE50", VA = "0x10B5F050")]
    static ObscuredVector2()
    {
    }

    [Token(Token = "0x20036A1")]
    [Serializable]
    public struct RawEncryptedVector2
    {
      [Token(Token = "0x401006A")]
      [FieldOffset(Offset = "0x0")]
      public int x;
      [Token(Token = "0x401006B")]
      [FieldOffset(Offset = "0x4")]
      public int y;
    }
  }
}
