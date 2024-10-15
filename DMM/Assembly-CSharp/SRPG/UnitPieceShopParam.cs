// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPieceShopParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EA7")]
  public class UnitPieceShopParam
  {
    [Token(Token = "0x17001193")]
    public string Iname
    {
      [Token(Token = "0x6007DAD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007DAE"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001194")]
    public string CostIname
    {
      [Token(Token = "0x6007DAF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007DB0"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001195")]
    public string Banner
    {
      [Token(Token = "0x6007DB1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6007DB2"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001196")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6007DB3"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6007DB4"), Address(RVA = "0x372E10", Offset = "0x371C10", VA = "0x10372E10")] private set
      {
      }
    }

    [Token(Token = "0x17001197")]
    public DateTime EndAt
    {
      [Token(Token = "0x6007DB5"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6007DB6"), Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")] private set
      {
      }
    }

    [Token(Token = "0x6007DB7")]
    [Address(RVA = "0x3F5190", Offset = "0x3F3F90", VA = "0x103F5190")]
    public bool IsWithinPeriod() => new bool();

    [Token(Token = "0x6007DB8")]
    [Address(RVA = "0x3F4E40", Offset = "0x3F3C40", VA = "0x103F4E40")]
    public bool Deserialize(JSON_UnitPieceShopParam json) => new bool();

    [Token(Token = "0x6007DB9")]
    [Address(RVA = "0x3F4D30", Offset = "0x3F3B30", VA = "0x103F4D30")]
    public static void Deserialize(
      ref List<UnitPieceShopParam> param,
      JSON_UnitPieceShopParam[] json)
    {
    }

    [Token(Token = "0x6007DBA")]
    [Address(RVA = "0x3F4FD0", Offset = "0x3F3DD0", VA = "0x103F4FD0")]
    public static UnitPieceShopParam GetCurrentParam() => (UnitPieceShopParam) null;

    [Token(Token = "0x6007DBB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitPieceShopParam()
    {
    }
  }
}
