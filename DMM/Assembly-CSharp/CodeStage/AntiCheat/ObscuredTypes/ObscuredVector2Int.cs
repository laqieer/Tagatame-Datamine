// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2Int
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x20036A2")]
  [Serializable]
  public struct ObscuredVector2Int
  {
    [Token(Token = "0x401006C")]
    [FieldOffset(Offset = "0x0")]
    private static int cryptoKey;
    [Token(Token = "0x401006D")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Vector2Int zero;
    [Token(Token = "0x401006E")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private int currentCryptoKey;
    [Token(Token = "0x401006F")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private ObscuredVector2Int.RawEncryptedVector2Int hiddenValue;
    [Token(Token = "0x4010070")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x4010071")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Vector2Int fakeValue;
    [Token(Token = "0x4010072")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F656")]
    [Address(RVA = "0xB5DC00", Offset = "0xB5CA00", VA = "0x10B5DC00")]
    private ObscuredVector2Int(Vector2Int value)
    {
    }

    [Token(Token = "0x600F657")]
    [Address(RVA = "0xB5DCB0", Offset = "0xB5CAB0", VA = "0x10B5DCB0")]
    public ObscuredVector2Int(int x, int y)
    {
    }

    [Token(Token = "0x17002364")]
    public int x
    {
      [Token(Token = "0x600F658"), Address(RVA = "0xB5DE30", Offset = "0xB5CC30", VA = "0x10B5DE30")] get
      {
        return new int();
      }
      [Token(Token = "0x600F659"), Address(RVA = "0xB5E1C0", Offset = "0xB5CFC0", VA = "0x10B5E1C0")] set
      {
      }
    }

    [Token(Token = "0x17002365")]
    public int y
    {
      [Token(Token = "0x600F65A"), Address(RVA = "0xB5DF10", Offset = "0xB5CD10", VA = "0x10B5DF10")] get
      {
        return new int();
      }
      [Token(Token = "0x600F65B"), Address(RVA = "0xB5E250", Offset = "0xB5D050", VA = "0x10B5E250")] set
      {
      }
    }

    [Token(Token = "0x17002366")]
    public int this[int index]
    {
      [Token(Token = "0x600F65C"), Address(RVA = "0xB5DD70", Offset = "0xB5CB70", VA = "0x10B5DD70")] get
      {
        return new int();
      }
      [Token(Token = "0x600F65D"), Address(RVA = "0xB5E0F0", Offset = "0xB5CEF0", VA = "0x10B5E0F0")] set
      {
      }
    }

    [Token(Token = "0x600F65E")]
    [Address(RVA = "0xB5DAE0", Offset = "0xB5C8E0", VA = "0x10B5DAE0")]
    public static void SetNewCryptoKey(int newKey)
    {
    }

    [Token(Token = "0x600F65F")]
    [Address(RVA = "0xB5D310", Offset = "0xB5C110", VA = "0x10B5D310")]
    public static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(Vector2Int value)
    {
      return new ObscuredVector2Int.RawEncryptedVector2Int();
    }

    [Token(Token = "0x600F660")]
    [Address(RVA = "0xB5D490", Offset = "0xB5C290", VA = "0x10B5D490")]
    public static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(Vector2Int value, int key)
    {
      return new ObscuredVector2Int.RawEncryptedVector2Int();
    }

    [Token(Token = "0x600F661")]
    [Address(RVA = "0xB5D390", Offset = "0xB5C190", VA = "0x10B5D390")]
    public static ObscuredVector2Int.RawEncryptedVector2Int Encrypt(int x, int y, int key)
    {
      return new ObscuredVector2Int.RawEncryptedVector2Int();
    }

    [Token(Token = "0x600F662")]
    [Address(RVA = "0xB5D1E0", Offset = "0xB5BFE0", VA = "0x10B5D1E0")]
    public static Vector2Int Decrypt(ObscuredVector2Int.RawEncryptedVector2Int value)
    {
      return new Vector2Int();
    }

    [Token(Token = "0x600F663")]
    [Address(RVA = "0xB5D0E0", Offset = "0xB5BEE0", VA = "0x10B5D0E0")]
    public static Vector2Int Decrypt(ObscuredVector2Int.RawEncryptedVector2Int value, int key)
    {
      return new Vector2Int();
    }

    [Token(Token = "0x600F664")]
    [Address(RVA = "0xB5D4E0", Offset = "0xB5C2E0", VA = "0x10B5D4E0")]
    public static ObscuredVector2Int FromEncrypted(
      ObscuredVector2Int.RawEncryptedVector2Int encrypted)
    {
      return new ObscuredVector2Int();
    }

    [Token(Token = "0x600F665")]
    [Address(RVA = "0xB5D000", Offset = "0xB5BE00", VA = "0x10B5D000")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F666")]
    [Address(RVA = "0xB5D970", Offset = "0xB5C770", VA = "0x10B5D970")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F667")]
    [Address(RVA = "0xB5D590", Offset = "0xB5C390", VA = "0x10B5D590")]
    public ObscuredVector2Int.RawEncryptedVector2Int GetEncrypted()
    {
      return new ObscuredVector2Int.RawEncryptedVector2Int();
    }

    [Token(Token = "0x600F668")]
    [Address(RVA = "0xB5DA40", Offset = "0xB5C840", VA = "0x10B5DA40")]
    public void SetEncrypted(
      ObscuredVector2Int.RawEncryptedVector2Int encrypted)
    {
    }

    [Token(Token = "0x600F669")]
    [Address(RVA = "0xB5D540", Offset = "0xB5C340", VA = "0x10B5D540")]
    public Vector2Int GetDecrypted() => new Vector2Int();

    [Token(Token = "0x600F66A")]
    [Address(RVA = "0xB5D700", Offset = "0xB5C500", VA = "0x10B5D700")]
    private Vector2Int InternalDecrypt() => new Vector2Int();

    [Token(Token = "0x600F66B")]
    [Address(RVA = "0xB5D650", Offset = "0xB5C450", VA = "0x10B5D650")]
    private int InternalDecryptField(int encrypted) => new int();

    [Token(Token = "0x600F66C")]
    [Address(RVA = "0xB5D8C0", Offset = "0xB5C6C0", VA = "0x10B5D8C0")]
    private int InternalEncryptField(int encrypted) => new int();

    [Token(Token = "0x600F66D")]
    [Address(RVA = "0xB5E050", Offset = "0xB5CE50", VA = "0x10B5E050")]
    public static implicit operator ObscuredVector2Int(Vector2Int value)
    {
      return new ObscuredVector2Int();
    }

    [Token(Token = "0x600F66E")]
    [Address(RVA = "0xB5E000", Offset = "0xB5CE00", VA = "0x10B5E000")]
    public static implicit operator Vector2Int(ObscuredVector2Int value) => new Vector2Int();

    [Token(Token = "0x600F66F")]
    [Address(RVA = "0xB5E080", Offset = "0xB5CE80", VA = "0x10B5E080")]
    public static implicit operator Vector2(ObscuredVector2Int value) => new Vector2();

    [Token(Token = "0x600F670")]
    [Address(RVA = "0xB5D5E0", Offset = "0xB5C3E0", VA = "0x10B5D5E0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F671")]
    [Address(RVA = "0xB5DB30", Offset = "0xB5C930", VA = "0x10B5DB30", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F672")]
    [Address(RVA = "0xB5DB90", Offset = "0xB5C990", VA = "0x10B5DB90")]
    static ObscuredVector2Int()
    {
    }

    [Token(Token = "0x20036A3")]
    [Serializable]
    public struct RawEncryptedVector2Int
    {
      [Token(Token = "0x4010073")]
      [FieldOffset(Offset = "0x0")]
      public int x;
      [Token(Token = "0x4010074")]
      [FieldOffset(Offset = "0x4")]
      public int y;
    }
  }
}
