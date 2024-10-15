// Decompiled with JetBrains decompiler
// Type: SRPG.BondPieceMatsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019BA")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondPieceMatsParam
  {
    [Token(Token = "0x17000B22")]
    public string UnitIname
    {
      [Token(Token = "0x60068FB"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068FC"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000B23")]
    public int Num
    {
      [Token(Token = "0x60068FD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60068FE"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17000B24")]
    public string SubMaterialsIname
    {
      [Token(Token = "0x60068FF"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006900"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x6006901")]
    [Address(RVA = "0x34D7C0", Offset = "0x34C5C0", VA = "0x1034D7C0")]
    public bool Deserialize(Json_BondPieceMatsParam json) => new bool();

    [Token(Token = "0x6006902")]
    [Address(RVA = "0x34D810", Offset = "0x34C610", VA = "0x1034D810")]
    public BondLvUpMaterials GetBondLvUpMaterials() => (BondLvUpMaterials) null;

    [Token(Token = "0x6006903")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondPieceMatsParam()
    {
    }
  }
}
