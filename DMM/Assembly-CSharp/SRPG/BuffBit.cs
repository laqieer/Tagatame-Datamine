// Decompiled with JetBrains decompiler
// Type: SRPG.BuffBit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DD8")]
  [MessagePackObject(true)]
  public class BuffBit
  {
    [Token(Token = "0x40077A8")]
    [FieldOffset(Offset = "0x0")]
    private static readonly int MaxBitArray;
    [Token(Token = "0x40077A9")]
    [FieldOffset(Offset = "0x8")]
    public int[] bits;

    [Token(Token = "0x6007A2C")]
    [Address(RVA = "0x3B9150", Offset = "0x3B7F50", VA = "0x103B9150")]
    public void SetBit(ParamTypes type)
    {
    }

    [Token(Token = "0x6007A2D")]
    [Address(RVA = "0x3B9100", Offset = "0x3B7F00", VA = "0x103B9100")]
    public void ResetBit(ParamTypes type)
    {
    }

    [Token(Token = "0x6007A2E")]
    [Address(RVA = "0x3B8FF0", Offset = "0x3B7DF0", VA = "0x103B8FF0")]
    public bool CheckBit(ParamTypes type) => new bool();

    [Token(Token = "0x6007A2F")]
    [Address(RVA = "0x3B9090", Offset = "0x3B7E90", VA = "0x103B9090")]
    public void CopyTo(BuffBit dsc)
    {
    }

    [Token(Token = "0x6007A30")]
    [Address(RVA = "0x3B84B0", Offset = "0x3B72B0", VA = "0x103B84B0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6007A31")]
    [Address(RVA = "0x3B9040", Offset = "0x3B7E40", VA = "0x103B9040")]
    public bool CheckEffect() => new bool();

    [Token(Token = "0x6007A32")]
    [Address(RVA = "0x3B9200", Offset = "0x3B8000", VA = "0x103B9200")]
    public BuffBit()
    {
    }

    [Token(Token = "0x6007A33")]
    [Address(RVA = "0x3B91A0", Offset = "0x3B7FA0", VA = "0x103B91A0")]
    static BuffBit()
    {
    }
  }
}
