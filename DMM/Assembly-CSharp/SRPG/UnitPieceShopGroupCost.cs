// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPieceShopGroupCost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EA5")]
  public class UnitPieceShopGroupCost
  {
    [Token(Token = "0x4008036")]
    [FieldOffset(Offset = "0x8")]
    private int mCost;
    [Token(Token = "0x4008037")]
    [FieldOffset(Offset = "0xC")]
    private int mNum;

    [Token(Token = "0x17001191")]
    public int Cost
    {
      [Token(Token = "0x6007DA8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001192")]
    public int Num
    {
      [Token(Token = "0x6007DA9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007DAA")]
    [Address(RVA = "0x3722B0", Offset = "0x3710B0", VA = "0x103722B0")]
    public bool Deserialize(JSON_UnitPieceShopGroupCost json) => new bool();

    [Token(Token = "0x6007DAB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitPieceShopGroupCost()
    {
    }
  }
}
