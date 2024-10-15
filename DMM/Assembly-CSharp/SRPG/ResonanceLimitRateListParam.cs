// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceLimitRateListParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CBA")]
  [MessagePackObject(true)]
  public class ResonanceLimitRateListParam
  {
    [Token(Token = "0x40070B8")]
    [FieldOffset(Offset = "0x8")]
    private int mMin_plus;
    [Token(Token = "0x40070B9")]
    [FieldOffset(Offset = "0xC")]
    private int mMax_plus;
    [Token(Token = "0x40070BA")]
    [FieldOffset(Offset = "0x10")]
    private string mBuff_rate;

    [Token(Token = "0x17000F58")]
    public int Min_plus
    {
      [Token(Token = "0x600763C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F59")]
    public int Max_plus
    {
      [Token(Token = "0x600763D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F5A")]
    public string Buff_rate
    {
      [Token(Token = "0x600763E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600763F")]
    [Address(RVA = "0x3974D0", Offset = "0x3962D0", VA = "0x103974D0")]
    public bool Deserialize(JSON_ResonanceLimitRateListParam json) => new bool();

    [Token(Token = "0x6007640")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceLimitRateListParam()
    {
    }
  }
}
