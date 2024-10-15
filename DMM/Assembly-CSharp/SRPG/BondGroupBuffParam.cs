// Decompiled with JetBrains decompiler
// Type: SRPG.BondGroupBuffParam
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
  [Token(Token = "0x20019AB")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondGroupBuffParam
  {
    [Token(Token = "0x4005E40")]
    [FieldOffset(Offset = "0x10")]
    private List<string> mGetGroupUnitAll;

    [Token(Token = "0x17000AF9")]
    public string BondGroupIname
    {
      [Token(Token = "0x600688F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006890"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000AFA")]
    public List<BondGroupBuffDetaillParam> Buffs
    {
      [Token(Token = "0x6006891"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<BondGroupBuffDetaillParam>) null;
      }
      [Token(Token = "0x6006892"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6006893")]
    [Address(RVA = "0x34C050", Offset = "0x34AE50", VA = "0x1034C050")]
    public bool Deserialize(Json_BondGroupBuffParam json) => new bool();

    [Token(Token = "0x6006894")]
    [Address(RVA = "0x34C180", Offset = "0x34AF80", VA = "0x1034C180")]
    public static void Deserialize(
      ref List<BondGroupBuffParam> param,
      Json_BondGroupBuffParam[] json)
    {
    }

    [Token(Token = "0x17000AFB")]
    public List<string> GetGroupUnitInames
    {
      [Token(Token = "0x6006895"), Address(RVA = "0x34C3A0", Offset = "0x34B1A0", VA = "0x1034C3A0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x6006896")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondGroupBuffParam()
    {
    }
  }
}
