// Decompiled with JetBrains decompiler
// Type: GR.CRC32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Security.Cryptography;

#nullable disable
namespace GR
{
  [Token(Token = "0x2000331")]
  public sealed class CRC32 : HashAlgorithm
  {
    [Token(Token = "0x4000D03")]
    [FieldOffset(Offset = "0x0")]
    private static readonly uint MASK_CRC32;
    [Token(Token = "0x4000D04")]
    [FieldOffset(Offset = "0x18")]
    private uint mCrcValue;
    [Token(Token = "0x4000D05")]
    [FieldOffset(Offset = "0x4")]
    private static readonly uint[] TABLE_CRC32;

    [Token(Token = "0x6001121")]
    [Address(RVA = "0x12A1030", Offset = "0x129FE30", VA = "0x112A1030")]
    public CRC32()
    {
    }

    [Token(Token = "0x6001122")]
    [Address(RVA = "0x12A0F40", Offset = "0x129FD40", VA = "0x112A0F40", Slot = "20")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6001123")]
    [Address(RVA = "0x12A0DD0", Offset = "0x129FBD0", VA = "0x112A0DD0", Slot = "18")]
    protected override void HashCore(byte[] bytes, int start, int size)
    {
    }

    [Token(Token = "0x6001124")]
    [Address(RVA = "0x12A0E70", Offset = "0x129FC70", VA = "0x112A0E70", Slot = "19")]
    protected override byte[] HashFinal() => (byte[]) null;

    [Token(Token = "0x6001125")]
    [Address(RVA = "0x12A0FA0", Offset = "0x129FDA0", VA = "0x112A0FA0")]
    static CRC32()
    {
    }
  }
}
