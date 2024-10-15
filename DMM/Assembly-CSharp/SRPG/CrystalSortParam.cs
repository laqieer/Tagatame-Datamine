// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSortParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AA3")]
  public class CrystalSortParam
  {
    [Token(Token = "0x17000C42")]
    public string Iname
    {
      [Token(Token = "0x6006DC5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DC6"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C43")]
    public string TabName
    {
      [Token(Token = "0x6006DC7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DC8"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C44")]
    public string ItemName
    {
      [Token(Token = "0x6006DC9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DCA"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C45")]
    public string SubItemName
    {
      [Token(Token = "0x6006DCB"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DCC"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000C46")]
    public List<CrystalSortCondParam> Conditions
    {
      [Token(Token = "0x6006DCD"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<CrystalSortCondParam>) null;
      }
      [Token(Token = "0x6006DCE"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x6006DCF")]
    [Address(RVA = "0x35C8E0", Offset = "0x35B6E0", VA = "0x1035C8E0")]
    public bool Deserialize(JSON_CrystalSortParam json) => new bool();

    [Token(Token = "0x6006DD0")]
    [Address(RVA = "0x35C7E0", Offset = "0x35B5E0", VA = "0x1035C7E0")]
    public static void Deserialize(ref List<CrystalSortParam> param, JSON_CrystalSortParam[] json)
    {
    }

    [Token(Token = "0x6006DD1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalSortParam()
    {
    }
  }
}
