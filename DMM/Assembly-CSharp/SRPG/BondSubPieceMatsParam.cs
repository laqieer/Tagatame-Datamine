// Decompiled with JetBrains decompiler
// Type: SRPG.BondSubPieceMatsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020CF")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondSubPieceMatsParam
  {
    [Token(Token = "0x1700134E")]
    public string SubPiece
    {
      [Token(Token = "0x60088B7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60088B8"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700134F")]
    public int Rate
    {
      [Token(Token = "0x60088B9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60088BA"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x60088BB")]
    [Address(RVA = "0x34DD40", Offset = "0x34CB40", VA = "0x1034DD40")]
    public bool Deserialize(Json_BondSubPieceMatsParam json) => new bool();

    [Token(Token = "0x60088BC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondSubPieceMatsParam()
    {
    }
  }
}
