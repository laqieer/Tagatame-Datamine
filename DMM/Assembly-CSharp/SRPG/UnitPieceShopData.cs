// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPieceShopData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200117D")]
  public class UnitPieceShopData
  {
    [Token(Token = "0x17000829")]
    public string ShopIName
    {
      [Token(Token = "0x6004A9D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004A9E"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700082A")]
    public string CostIName
    {
      [Token(Token = "0x6004A9F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004AA0"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x1700082B")]
    public List<UnitPieceShopItem> ShopItems
    {
      [Token(Token = "0x6004AA1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<UnitPieceShopItem>) null;
      }
      [Token(Token = "0x6004AA2"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x6004AA3")]
    [Address(RVA = "0x12144B0", Offset = "0x12132B0", VA = "0x112144B0")]
    public bool Deserialize(ReqUnitPieceShopItemList.Response json) => new bool();

    [Token(Token = "0x6004AA4")]
    [Address(RVA = "0x1214390", Offset = "0x1213190", VA = "0x11214390")]
    public bool Deserialize(ReqUnitPieceShopBuypaid.Response json) => new bool();

    [Token(Token = "0x6004AA5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitPieceShopData()
    {
    }
  }
}
