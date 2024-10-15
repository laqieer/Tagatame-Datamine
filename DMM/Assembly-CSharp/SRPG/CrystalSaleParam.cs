// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSaleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A98")]
  [MessagePackObject(true)]
  [Serializable]
  public class CrystalSaleParam
  {
    [Token(Token = "0x17000C2A")]
    public string Iname
    {
      [Token(Token = "0x6006D83"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D84"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C2B")]
    public List<CrystalSaleRewardParam> SaleRewards
    {
      [Token(Token = "0x6006D85"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<CrystalSaleRewardParam>) null;
      }
      [Token(Token = "0x6006D86"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6006D87")]
    [Address(RVA = "0x35BE30", Offset = "0x35AC30", VA = "0x1035BE30")]
    public bool Deserialize(JSON_CrystalSaleParam json) => new bool();

    [Token(Token = "0x6006D88")]
    [Address(RVA = "0x35BBE0", Offset = "0x35A9E0", VA = "0x1035BBE0")]
    public static void Deserialize(ref List<CrystalSaleParam> param, JSON_CrystalSaleParam[] json)
    {
    }

    [Token(Token = "0x6006D89")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalSaleParam()
    {
    }
  }
}
