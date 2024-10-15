// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSetBonusParam
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
  [Token(Token = "0x2001A9F")]
  [MessagePackObject(true)]
  [Serializable]
  public class CrystalSetBonusParam
  {
    [Token(Token = "0x17000C3B")]
    public string Iname
    {
      [Token(Token = "0x6006DB1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DB2"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C3C")]
    public string Name
    {
      [Token(Token = "0x6006DB3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DB4"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C3D")]
    public string Expr
    {
      [Token(Token = "0x6006DB5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DB6"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C3E")]
    public string MainCrystalIanme
    {
      [Token(Token = "0x6006DB7"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DB8"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000C3F")]
    public List<string> SubCrystalInames
    {
      [Token(Token = "0x6006DB9"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6006DBA"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17000C40")]
    public string BuffIname
    {
      [Token(Token = "0x6006DBB"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DBC"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17000C41")]
    public string LimitUpName
    {
      [Token(Token = "0x6006DBD"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DBE"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x6006DBF")]
    [Address(RVA = "0x35C4B0", Offset = "0x35B2B0", VA = "0x1035C4B0")]
    public bool Deserialize(JSON_CrystalSetBonusParam json) => new bool();

    [Token(Token = "0x6006DC0")]
    [Address(RVA = "0x35C5A0", Offset = "0x35B3A0", VA = "0x1035C5A0")]
    public static void Deserialize(
      ref List<CrystalSetBonusParam> param,
      JSON_CrystalSetBonusParam[] json)
    {
    }

    [Token(Token = "0x6006DC1")]
    [Address(RVA = "0x35C300", Offset = "0x35B100", VA = "0x1035C300")]
    public void CalcStatus(
      ref BaseStatus fixed_status,
      ref BaseStatus scale_status,
      UnitData _unit_data = null)
    {
    }

    [Token(Token = "0x6006DC2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalSetBonusParam()
    {
    }
  }
}
