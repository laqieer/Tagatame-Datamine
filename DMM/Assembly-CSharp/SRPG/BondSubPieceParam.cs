// Decompiled with JetBrains decompiler
// Type: SRPG.BondSubPieceParam
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
  [Token(Token = "0x20020CD")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondSubPieceParam
  {
    [Token(Token = "0x1700134C")]
    public string Iname
    {
      [Token(Token = "0x60088AD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60088AE"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700134D")]
    public List<BondSubPieceMatsParam> Materials
    {
      [Token(Token = "0x60088AF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<BondSubPieceMatsParam>) null;
      }
      [Token(Token = "0x60088B0"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x60088B1")]
    [Address(RVA = "0x49E4A0", Offset = "0x49D2A0", VA = "0x1049E4A0")]
    public bool Deserialize(Json_BondSubPieceParam json) => new bool();

    [Token(Token = "0x60088B2")]
    [Address(RVA = "0x49E5F0", Offset = "0x49D3F0", VA = "0x1049E5F0")]
    public static void Deserialize(ref List<BondSubPieceParam> param, Json_BondSubPieceParam[] json)
    {
    }

    [Token(Token = "0x60088B3")]
    [Address(RVA = "0x49E820", Offset = "0x49D620", VA = "0x1049E820")]
    public static BondSubPieceParam GetParam(string group_iname) => (BondSubPieceParam) null;

    [Token(Token = "0x60088B4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondSubPieceParam()
    {
    }
  }
}
