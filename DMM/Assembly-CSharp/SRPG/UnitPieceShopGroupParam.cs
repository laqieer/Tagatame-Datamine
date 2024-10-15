// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPieceShopGroupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EA4")]
  public class UnitPieceShopGroupParam
  {
    [Token(Token = "0x4008034")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4008035")]
    [FieldOffset(Offset = "0xC")]
    private List<UnitPieceShopGroupCost> mCosts;

    [Token(Token = "0x1700118F")]
    public string Iname
    {
      [Token(Token = "0x6007DA3"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001190")]
    public List<UnitPieceShopGroupCost> Costs
    {
      [Token(Token = "0x6007DA4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<UnitPieceShopGroupCost>) null;
      }
    }

    [Token(Token = "0x6007DA5")]
    [Address(RVA = "0x3F4AC0", Offset = "0x3F38C0", VA = "0x103F4AC0")]
    public bool Deserialize(JSON_UnitPieceShopGroupParam json) => new bool();

    [Token(Token = "0x6007DA6")]
    [Address(RVA = "0x3F4C20", Offset = "0x3F3A20", VA = "0x103F4C20")]
    public static void Deserialize(
      ref List<UnitPieceShopGroupParam> param,
      JSON_UnitPieceShopGroupParam[] json)
    {
    }

    [Token(Token = "0x6007DA7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitPieceShopGroupParam()
    {
    }
  }
}
