// Decompiled with JetBrains decompiler
// Type: SRPG.WeaponParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EA1")]
  public class WeaponParam
  {
    [Token(Token = "0x400802D")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400802E")]
    [FieldOffset(Offset = "0xC")]
    public OInt atk;
    [Token(Token = "0x400802F")]
    [FieldOffset(Offset = "0x20")]
    public OInt formula;

    [Token(Token = "0x1700118E")]
    public WeaponFormulaTypes FormulaType
    {
      [Token(Token = "0x6007D9E"), Address(RVA = "0x3B4040", Offset = "0x3B2E40", VA = "0x103B4040")] get
      {
        return new WeaponFormulaTypes();
      }
    }

    [Token(Token = "0x6007D9F")]
    [Address(RVA = "0x3FDBA0", Offset = "0x3FC9A0", VA = "0x103FDBA0")]
    public bool Deserialize(JSON_WeaponParam json) => new bool();

    [Token(Token = "0x6007DA0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WeaponParam()
    {
    }
  }
}
