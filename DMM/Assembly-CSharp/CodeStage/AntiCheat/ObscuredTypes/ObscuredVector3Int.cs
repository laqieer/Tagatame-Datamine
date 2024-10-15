// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3Int
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x20036A6")]
  [Serializable]
  public struct ObscuredVector3Int
  {
    [Token(Token = "0x401007F")]
    [FieldOffset(Offset = "0x0")]
    private static int cryptoKey;
    [Token(Token = "0x4010080")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Vector3Int zero;
    [Token(Token = "0x4010081")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private int currentCryptoKey;
    [Token(Token = "0x4010082")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private ObscuredVector3Int.RawEncryptedVector3Int hiddenValue;
    [Token(Token = "0x4010083")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x4010084")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Vector3Int fakeValue;
    [Token(Token = "0x4010085")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F6A4")]
    [Address(RVA = "0xB60910", Offset = "0xB5F710", VA = "0x10B60910")]
    private ObscuredVector3Int(Vector3Int value)
    {
    }

    [Token(Token = "0x600F6A5")]
    [Address(RVA = "0xB60830", Offset = "0xB5F630", VA = "0x10B60830")]
    public ObscuredVector3Int(int x, int y, int z)
    {
    }

    [Token(Token = "0x1700236B")]
    public int x
    {
      [Token(Token = "0x600F6A6"), Address(RVA = "0xB60B30", Offset = "0xB5F930", VA = "0x10B60B30")] get
      {
        return new int();
      }
      [Token(Token = "0x600F6A7"), Address(RVA = "0xB618B0", Offset = "0xB606B0", VA = "0x10B618B0")] set
      {
      }
    }

    [Token(Token = "0x1700236C")]
    public int y
    {
      [Token(Token = "0x600F6A8"), Address(RVA = "0xB60C10", Offset = "0xB5FA10", VA = "0x10B60C10")] get
      {
        return new int();
      }
      [Token(Token = "0x600F6A9"), Address(RVA = "0xB61950", Offset = "0xB60750", VA = "0x10B61950")] set
      {
      }
    }

    [Token(Token = "0x1700236D")]
    public int z
    {
      [Token(Token = "0x600F6AA"), Address(RVA = "0xB60CF0", Offset = "0xB5FAF0", VA = "0x10B60CF0")] get
      {
        return new int();
      }
      [Token(Token = "0x600F6AB"), Address(RVA = "0xB619F0", Offset = "0xB607F0", VA = "0x10B619F0")] set
      {
      }
    }

    [Token(Token = "0x1700236E")]
    public int this[int index]
    {
      [Token(Token = "0x600F6AC"), Address(RVA = "0xB60A40", Offset = "0xB5F840", VA = "0x10B60A40")] get
      {
        return new int();
      }
      [Token(Token = "0x600F6AD"), Address(RVA = "0xB617C0", Offset = "0xB605C0", VA = "0x10B617C0")] set
      {
      }
    }

    [Token(Token = "0x600F6AE")]
    [Address(RVA = "0xB60690", Offset = "0xB5F490", VA = "0x10B60690")]
    public static void SetNewCryptoKey(int newKey)
    {
    }

    [Token(Token = "0x600F6AF")]
    [Address(RVA = "0xB5FC40", Offset = "0xB5EA40", VA = "0x10B5FC40")]
    public static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(Vector3Int value)
    {
      return new ObscuredVector3Int.RawEncryptedVector3Int();
    }

    [Token(Token = "0x600F6B0")]
    [Address(RVA = "0xB5FE40", Offset = "0xB5EC40", VA = "0x10B5FE40")]
    public static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(Vector3Int value, int key)
    {
      return new ObscuredVector3Int.RawEncryptedVector3Int();
    }

    [Token(Token = "0x600F6B1")]
    [Address(RVA = "0xB5FCE0", Offset = "0xB5EAE0", VA = "0x10B5FCE0")]
    public static ObscuredVector3Int.RawEncryptedVector3Int Encrypt(int x, int y, int z, int key)
    {
      return new ObscuredVector3Int.RawEncryptedVector3Int();
    }

    [Token(Token = "0x600F6B2")]
    [Address(RVA = "0xB5FAB0", Offset = "0xB5E8B0", VA = "0x10B5FAB0")]
    public static Vector3Int Decrypt(ObscuredVector3Int.RawEncryptedVector3Int value)
    {
      return new Vector3Int();
    }

    [Token(Token = "0x600F6B3")]
    [Address(RVA = "0xB5F940", Offset = "0xB5E740", VA = "0x10B5F940")]
    public static Vector3Int Decrypt(ObscuredVector3Int.RawEncryptedVector3Int value, int key)
    {
      return new Vector3Int();
    }

    [Token(Token = "0x600F6B4")]
    [Address(RVA = "0xB5FF90", Offset = "0xB5ED90", VA = "0x10B5FF90")]
    public static ObscuredVector3Int FromEncrypted(
      ObscuredVector3Int.RawEncryptedVector3Int encrypted)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6B5")]
    [Address(RVA = "0xB5F880", Offset = "0xB5E680", VA = "0x10B5F880")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F6B6")]
    [Address(RVA = "0xB60520", Offset = "0xB5F320", VA = "0x10B60520")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F6B7")]
    [Address(RVA = "0xB60060", Offset = "0xB5EE60", VA = "0x10B60060")]
    public ObscuredVector3Int.RawEncryptedVector3Int GetEncrypted()
    {
      return new ObscuredVector3Int.RawEncryptedVector3Int();
    }

    [Token(Token = "0x600F6B8")]
    [Address(RVA = "0xB605E0", Offset = "0xB5F3E0", VA = "0x10B605E0")]
    public void SetEncrypted(
      ObscuredVector3Int.RawEncryptedVector3Int encrypted)
    {
    }

    [Token(Token = "0x600F6B9")]
    [Address(RVA = "0xB60000", Offset = "0xB5EE00", VA = "0x10B60000")]
    public Vector3Int GetDecrypted() => new Vector3Int();

    [Token(Token = "0x600F6BA")]
    [Address(RVA = "0xB60220", Offset = "0xB5F020", VA = "0x10B60220")]
    private Vector3Int InternalDecrypt() => new Vector3Int();

    [Token(Token = "0x600F6BB")]
    [Address(RVA = "0xB60170", Offset = "0xB5EF70", VA = "0x10B60170")]
    private int InternalDecryptField(int encrypted) => new int();

    [Token(Token = "0x600F6BC")]
    [Address(RVA = "0xB60470", Offset = "0xB5F270", VA = "0x10B60470")]
    private int InternalEncryptField(int encrypted) => new int();

    [Token(Token = "0x600F6BD")]
    [Address(RVA = "0xB611D0", Offset = "0xB5FFD0", VA = "0x10B611D0")]
    public static implicit operator ObscuredVector3Int(Vector3Int value)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6BE")]
    [Address(RVA = "0xB612A0", Offset = "0xB600A0", VA = "0x10B612A0")]
    public static implicit operator Vector3Int(ObscuredVector3Int value) => new Vector3Int();

    [Token(Token = "0x600F6BF")]
    [Address(RVA = "0xB61210", Offset = "0xB60010", VA = "0x10B61210")]
    public static implicit operator Vector3(ObscuredVector3Int value) => new Vector3();

    [Token(Token = "0x600F6C0")]
    [Address(RVA = "0xB60DD0", Offset = "0xB5FBD0", VA = "0x10B60DD0")]
    public static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6C1")]
    [Address(RVA = "0xB60F70", Offset = "0xB5FD70", VA = "0x10B60F70")]
    public static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6C2")]
    [Address(RVA = "0xB60EB0", Offset = "0xB5FCB0", VA = "0x10B60EB0")]
    public static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6C3")]
    [Address(RVA = "0xB61620", Offset = "0xB60420", VA = "0x10B61620")]
    public static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6C4")]
    [Address(RVA = "0xB61560", Offset = "0xB60360", VA = "0x10B61560")]
    public static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6C5")]
    [Address(RVA = "0xB61700", Offset = "0xB60500", VA = "0x10B61700")]
    public static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6C6")]
    [Address(RVA = "0xB614A0", Offset = "0xB602A0", VA = "0x10B614A0")]
    public static ObscuredVector3Int operator *(ObscuredVector3Int a, int d)
    {
      return new ObscuredVector3Int();
    }

    [Token(Token = "0x600F6C7")]
    [Address(RVA = "0xB61130", Offset = "0xB5FF30", VA = "0x10B61130")]
    public static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs) => new bool();

    [Token(Token = "0x600F6C8")]
    [Address(RVA = "0xB610B0", Offset = "0xB5FEB0", VA = "0x10B610B0")]
    public static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs) => new bool();

    [Token(Token = "0x600F6C9")]
    [Address(RVA = "0xB61030", Offset = "0xB5FE30", VA = "0x10B61030")]
    public static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs) => new bool();

    [Token(Token = "0x600F6CA")]
    [Address(RVA = "0xB61400", Offset = "0xB60200", VA = "0x10B61400")]
    public static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs) => new bool();

    [Token(Token = "0x600F6CB")]
    [Address(RVA = "0xB61300", Offset = "0xB60100", VA = "0x10B61300")]
    public static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs) => new bool();

    [Token(Token = "0x600F6CC")]
    [Address(RVA = "0xB61380", Offset = "0xB60180", VA = "0x10B61380")]
    public static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs) => new bool();

    [Token(Token = "0x600F6CD")]
    [Address(RVA = "0xB5FEB0", Offset = "0xB5ECB0", VA = "0x10B5FEB0", Slot = "0")]
    public override bool Equals(object other) => new bool();

    [Token(Token = "0x600F6CE")]
    [Address(RVA = "0xB600C0", Offset = "0xB5EEC0", VA = "0x10B600C0", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F6CF")]
    [Address(RVA = "0xB60750", Offset = "0xB5F550", VA = "0x10B60750", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F6D0")]
    [Address(RVA = "0xB606E0", Offset = "0xB5F4E0", VA = "0x10B606E0")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F6D1")]
    [Address(RVA = "0xB607C0", Offset = "0xB5F5C0", VA = "0x10B607C0")]
    static ObscuredVector3Int()
    {
    }

    [Token(Token = "0x20036A7")]
    [Serializable]
    public struct RawEncryptedVector3Int
    {
      [Token(Token = "0x4010086")]
      [FieldOffset(Offset = "0x0")]
      public int x;
      [Token(Token = "0x4010087")]
      [FieldOffset(Offset = "0x4")]
      public int y;
      [Token(Token = "0x4010088")]
      [FieldOffset(Offset = "0x8")]
      public int z;
    }
  }
}
