// Decompiled with JetBrains decompiler
// Type: GR.RandXorshift
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GR
{
  [Token(Token = "0x200032E")]
  public class RandXorshift
  {
    [Token(Token = "0x4000CFD")]
    [FieldOffset(Offset = "0x8")]
    private uint[] mSeed;
    [Token(Token = "0x4000CFE")]
    [FieldOffset(Offset = "0xC")]
    public string mName;

    [Token(Token = "0x6001113")]
    [Address(RVA = "0x12A5140", Offset = "0x12A3F40", VA = "0x112A5140")]
    public RandXorshift Clone() => (RandXorshift) null;

    [Token(Token = "0x6001114")]
    [Address(RVA = "0x12A5440", Offset = "0x12A4240", VA = "0x112A5440")]
    public RandXorshift(string name = "unknown")
    {
    }

    [Token(Token = "0x6001115")]
    [Address(RVA = "0x12A5350", Offset = "0x12A4150", VA = "0x112A5350")]
    public void Reset()
    {
    }

    [Token(Token = "0x6001116")]
    [Address(RVA = "0x12A53C0", Offset = "0x12A41C0", VA = "0x112A53C0")]
    public void Seed(uint seed)
    {
    }

    [Token(Token = "0x6001117")]
    [Address(RVA = "0x12A52A0", Offset = "0x12A40A0", VA = "0x112A52A0")]
    public uint Get() => new uint();

    [Token(Token = "0x6001118")]
    [Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")]
    public uint[] GetSeed() => (uint[]) null;

    [Token(Token = "0x6001119")]
    [Address(RVA = "0x12A5410", Offset = "0x12A4210", VA = "0x112A5410")]
    public void SetSeed(int index, uint seed)
    {
    }
  }
}
