// Decompiled with JetBrains decompiler
// Type: SRPG.BondPieceParam
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
  [Token(Token = "0x20019B8")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondPieceParam
  {
    [Token(Token = "0x17000B20")]
    public string Iname
    {
      [Token(Token = "0x60068F1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068F2"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000B21")]
    public List<BondPieceMatsParam> Materials
    {
      [Token(Token = "0x60068F3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<BondPieceMatsParam>) null;
      }
      [Token(Token = "0x60068F4"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60068F5")]
    [Address(RVA = "0x34DAC0", Offset = "0x34C8C0", VA = "0x1034DAC0")]
    public bool Deserialize(Json_BondPieceParam json) => new bool();

    [Token(Token = "0x60068F6")]
    [Address(RVA = "0x34D870", Offset = "0x34C670", VA = "0x1034D870")]
    public static void Deserialize(ref List<BondPieceParam> param, Json_BondPieceParam[] json)
    {
    }

    [Token(Token = "0x60068F7")]
    [Address(RVA = "0x34DC20", Offset = "0x34CA20", VA = "0x1034DC20")]
    public static BondPieceParam GetParam(string piece_iname) => (BondPieceParam) null;

    [Token(Token = "0x60068F8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondPieceParam()
    {
    }
  }
}
