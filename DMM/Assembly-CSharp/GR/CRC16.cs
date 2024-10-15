// Decompiled with JetBrains decompiler
// Type: GR.CRC16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Security.Cryptography;

#nullable disable
namespace GR
{
  [Token(Token = "0x2000330")]
  public sealed class CRC16 : HashAlgorithm
  {
    [Token(Token = "0x4000D00")]
    [FieldOffset(Offset = "0x0")]
    private static readonly uint MASK_CRC16;
    [Token(Token = "0x4000D01")]
    [FieldOffset(Offset = "0x18")]
    private uint mCrcValue;
    [Token(Token = "0x4000D02")]
    [FieldOffset(Offset = "0x4")]
    private static readonly uint[] TABLE_CRC16;

    [Token(Token = "0x600111C")]
    [Address(RVA = "0x12A0D60", Offset = "0x129FB60", VA = "0x112A0D60")]
    public CRC16()
    {
    }

    [Token(Token = "0x600111D")]
    [Address(RVA = "0x12A0C80", Offset = "0x129FA80", VA = "0x112A0C80", Slot = "20")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x600111E")]
    [Address(RVA = "0x12A0B60", Offset = "0x129F960", VA = "0x112A0B60", Slot = "18")]
    protected override void HashCore(byte[] bytes, int start, int size)
    {
    }

    [Token(Token = "0x600111F")]
    [Address(RVA = "0x12A0C00", Offset = "0x129FA00", VA = "0x112A0C00", Slot = "19")]
    protected override byte[] HashFinal() => (byte[]) null;

    [Token(Token = "0x6001120")]
    [Address(RVA = "0x12A0CD0", Offset = "0x129FAD0", VA = "0x112A0CD0")]
    static CRC16()
    {
    }
  }
}
