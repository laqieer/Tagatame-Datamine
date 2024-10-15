// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.ObscuredTypes
{
  [Token(Token = "0x20036A4")]
  [Serializable]
  public struct ObscuredVector3
  {
    [Token(Token = "0x4010075")]
    [FieldOffset(Offset = "0x0")]
    private static int cryptoKey;
    [Token(Token = "0x4010076")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Vector3 zero;
    [Token(Token = "0x4010077")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private int currentCryptoKey;
    [Token(Token = "0x4010078")]
    [FieldOffset(Offset = "0x4")]
    [SerializeField]
    private ObscuredVector3.RawEncryptedVector3 hiddenValue;
    [Token(Token = "0x4010079")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool inited;
    [Token(Token = "0x401007A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Vector3 fakeValue;
    [Token(Token = "0x401007B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool fakeValueActive;

    [Token(Token = "0x600F673")]
    [Address(RVA = "0xB62910", Offset = "0xB61710", VA = "0x10B62910")]
    private ObscuredVector3(Vector3 value)
    {
    }

    [Token(Token = "0x600F674")]
    [Address(RVA = "0xB62A10", Offset = "0xB61810", VA = "0x10B62A10")]
    public ObscuredVector3(float x, float y, float z)
    {
    }

    [Token(Token = "0x17002367")]
    public float x
    {
      [Token(Token = "0x600F675"), Address(RVA = "0xB62C20", Offset = "0xB61A20", VA = "0x10B62C20")] get
      {
        return new float();
      }
      [Token(Token = "0x600F676"), Address(RVA = "0xB63DC0", Offset = "0xB62BC0", VA = "0x10B63DC0")] set
      {
      }
    }

    [Token(Token = "0x17002368")]
    public float y
    {
      [Token(Token = "0x600F677"), Address(RVA = "0xB62D50", Offset = "0xB61B50", VA = "0x10B62D50")] get
      {
        return new float();
      }
      [Token(Token = "0x600F678"), Address(RVA = "0xB63E70", Offset = "0xB62C70", VA = "0x10B63E70")] set
      {
      }
    }

    [Token(Token = "0x17002369")]
    public float z
    {
      [Token(Token = "0x600F679"), Address(RVA = "0xB62E80", Offset = "0xB61C80", VA = "0x10B62E80")] get
      {
        return new float();
      }
      [Token(Token = "0x600F67A"), Address(RVA = "0xB63F20", Offset = "0xB62D20", VA = "0x10B63F20")] set
      {
      }
    }

    [Token(Token = "0x1700236A")]
    public float this[int index]
    {
      [Token(Token = "0x600F67B"), Address(RVA = "0xB62B30", Offset = "0xB61930", VA = "0x10B62B30")] get
      {
        return new float();
      }
      [Token(Token = "0x600F67C"), Address(RVA = "0xB63CB0", Offset = "0xB62AB0", VA = "0x10B63CB0")] set
      {
      }
    }

    [Token(Token = "0x600F67D")]
    [Address(RVA = "0xB62770", Offset = "0xB61570", VA = "0x10B62770")]
    public static void SetNewCryptoKey(int newKey)
    {
    }

    [Token(Token = "0x600F67E")]
    [Address(RVA = "0xB61FC0", Offset = "0xB60DC0", VA = "0x10B61FC0")]
    public static ObscuredVector3.RawEncryptedVector3 Encrypt(Vector3 value)
    {
      return new ObscuredVector3.RawEncryptedVector3();
    }

    [Token(Token = "0x600F67F")]
    [Address(RVA = "0xB61F40", Offset = "0xB60D40", VA = "0x10B61F40")]
    public static ObscuredVector3.RawEncryptedVector3 Encrypt(Vector3 value, int key)
    {
      return new ObscuredVector3.RawEncryptedVector3();
    }

    [Token(Token = "0x600F680")]
    [Address(RVA = "0xB61E60", Offset = "0xB60C60", VA = "0x10B61E60")]
    public static ObscuredVector3.RawEncryptedVector3 Encrypt(float x, float y, float z, int key)
    {
      return new ObscuredVector3.RawEncryptedVector3();
    }

    [Token(Token = "0x600F681")]
    [Address(RVA = "0xB61C60", Offset = "0xB60A60", VA = "0x10B61C60")]
    public static Vector3 Decrypt(ObscuredVector3.RawEncryptedVector3 value) => new Vector3();

    [Token(Token = "0x600F682")]
    [Address(RVA = "0xB61D80", Offset = "0xB60B80", VA = "0x10B61D80")]
    public static Vector3 Decrypt(ObscuredVector3.RawEncryptedVector3 value, int key)
    {
      return new Vector3();
    }

    [Token(Token = "0x600F683")]
    [Address(RVA = "0xB62130", Offset = "0xB60F30", VA = "0x10B62130")]
    public static ObscuredVector3 FromEncrypted(ObscuredVector3.RawEncryptedVector3 encrypted)
    {
      return new ObscuredVector3();
    }

    [Token(Token = "0x600F684")]
    [Address(RVA = "0xB61A90", Offset = "0xB60890", VA = "0x10B61A90")]
    public void ApplyNewCryptoKey()
    {
    }

    [Token(Token = "0x600F685")]
    [Address(RVA = "0xB62600", Offset = "0xB61400", VA = "0x10B62600")]
    public void RandomizeCryptoKey()
    {
    }

    [Token(Token = "0x600F686")]
    [Address(RVA = "0xB62200", Offset = "0xB61000", VA = "0x10B62200")]
    public ObscuredVector3.RawEncryptedVector3 GetEncrypted()
    {
      return new ObscuredVector3.RawEncryptedVector3();
    }

    [Token(Token = "0x600F687")]
    [Address(RVA = "0xB626C0", Offset = "0xB614C0", VA = "0x10B626C0")]
    public void SetEncrypted(ObscuredVector3.RawEncryptedVector3 encrypted)
    {
    }

    [Token(Token = "0x600F688")]
    [Address(RVA = "0xB621A0", Offset = "0xB60FA0", VA = "0x10B621A0")]
    public Vector3 GetDecrypted() => new Vector3();

    [Token(Token = "0x600F689")]
    [Address(RVA = "0xB62390", Offset = "0xB61190", VA = "0x10B62390")]
    private Vector3 InternalDecrypt() => new Vector3();

    [Token(Token = "0x600F68A")]
    [Address(RVA = "0xB61B50", Offset = "0xB60950", VA = "0x10B61B50")]
    private bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2) => new bool();

    [Token(Token = "0x600F68B")]
    [Address(RVA = "0xB62300", Offset = "0xB61100", VA = "0x10B62300")]
    private float InternalDecryptField(int encrypted) => new float();

    [Token(Token = "0x600F68C")]
    [Address(RVA = "0xB62580", Offset = "0xB61380", VA = "0x10B62580")]
    private int InternalEncryptField(float encrypted) => new int();

    [Token(Token = "0x600F68D")]
    [Address(RVA = "0xB63570", Offset = "0xB62370", VA = "0x10B63570")]
    public static implicit operator ObscuredVector3(Vector3 value) => new ObscuredVector3();

    [Token(Token = "0x600F68E")]
    [Address(RVA = "0xB63510", Offset = "0xB62310", VA = "0x10B63510")]
    public static implicit operator Vector3(ObscuredVector3 value) => new Vector3();

    [Token(Token = "0x600F68F")]
    [Address(RVA = "0xB62FB0", Offset = "0xB61DB0", VA = "0x10B62FB0")]
    public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b)
    {
      return new ObscuredVector3();
    }

    [Token(Token = "0x600F690")]
    [Address(RVA = "0xB630A0", Offset = "0xB61EA0", VA = "0x10B630A0")]
    public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b) => new ObscuredVector3();

    [Token(Token = "0x600F691")]
    [Address(RVA = "0xB63170", Offset = "0xB61F70", VA = "0x10B63170")]
    public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b) => new ObscuredVector3();

    [Token(Token = "0x600F692")]
    [Address(RVA = "0xB63AF0", Offset = "0xB628F0", VA = "0x10B63AF0")]
    public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b)
    {
      return new ObscuredVector3();
    }

    [Token(Token = "0x600F693")]
    [Address(RVA = "0xB63950", Offset = "0xB62750", VA = "0x10B63950")]
    public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b) => new ObscuredVector3();

    [Token(Token = "0x600F694")]
    [Address(RVA = "0xB63A20", Offset = "0xB62820", VA = "0x10B63A20")]
    public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b) => new ObscuredVector3();

    [Token(Token = "0x600F695")]
    [Address(RVA = "0xB63BE0", Offset = "0xB629E0", VA = "0x10B63BE0")]
    public static ObscuredVector3 operator -(ObscuredVector3 a) => new ObscuredVector3();

    [Token(Token = "0x600F696")]
    [Address(RVA = "0xB63880", Offset = "0xB62680", VA = "0x10B63880")]
    public static ObscuredVector3 operator *(ObscuredVector3 a, float d) => new ObscuredVector3();

    [Token(Token = "0x600F697")]
    [Address(RVA = "0xB637B0", Offset = "0xB625B0", VA = "0x10B637B0")]
    public static ObscuredVector3 operator *(float d, ObscuredVector3 a) => new ObscuredVector3();

    [Token(Token = "0x600F698")]
    [Address(RVA = "0xB63240", Offset = "0xB62040", VA = "0x10B63240")]
    public static ObscuredVector3 operator /(ObscuredVector3 a, float d) => new ObscuredVector3();

    [Token(Token = "0x600F699")]
    [Address(RVA = "0xB63310", Offset = "0xB62110", VA = "0x10B63310")]
    public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs) => new bool();

    [Token(Token = "0x600F69A")]
    [Address(RVA = "0xB63470", Offset = "0xB62270", VA = "0x10B63470")]
    public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs) => new bool();

    [Token(Token = "0x600F69B")]
    [Address(RVA = "0xB633D0", Offset = "0xB621D0", VA = "0x10B633D0")]
    public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs) => new bool();

    [Token(Token = "0x600F69C")]
    [Address(RVA = "0xB63650", Offset = "0xB62450", VA = "0x10B63650")]
    public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs) => new bool();

    [Token(Token = "0x600F69D")]
    [Address(RVA = "0xB63710", Offset = "0xB62510", VA = "0x10B63710")]
    public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs) => new bool();

    [Token(Token = "0x600F69E")]
    [Address(RVA = "0xB635B0", Offset = "0xB623B0", VA = "0x10B635B0")]
    public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs) => new bool();

    [Token(Token = "0x600F69F")]
    [Address(RVA = "0xB62030", Offset = "0xB60E30", VA = "0x10B62030", Slot = "0")]
    public override bool Equals(object other) => new bool();

    [Token(Token = "0x600F6A0")]
    [Address(RVA = "0xB62260", Offset = "0xB61060", VA = "0x10B62260", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F6A1")]
    [Address(RVA = "0xB62830", Offset = "0xB61630", VA = "0x10B62830", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F6A2")]
    [Address(RVA = "0xB627C0", Offset = "0xB615C0", VA = "0x10B627C0")]
    public string ToString(string format) => (string) null;

    [Token(Token = "0x600F6A3")]
    [Address(RVA = "0xB628A0", Offset = "0xB616A0", VA = "0x10B628A0")]
    static ObscuredVector3()
    {
    }

    [Token(Token = "0x20036A5")]
    [Serializable]
    public struct RawEncryptedVector3
    {
      [Token(Token = "0x401007C")]
      [FieldOffset(Offset = "0x0")]
      public int x;
      [Token(Token = "0x401007D")]
      [FieldOffset(Offset = "0x4")]
      public int y;
      [Token(Token = "0x401007E")]
      [FieldOffset(Offset = "0x8")]
      public int z;
    }
  }
}
