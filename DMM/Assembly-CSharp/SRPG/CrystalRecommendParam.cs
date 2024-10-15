// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalRecommendParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A8F")]
  public class CrystalRecommendParam
  {
    [Token(Token = "0x17000C12")]
    public string Iname
    {
      [Token(Token = "0x6006D3A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D3B"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C13")]
    public string TabName
    {
      [Token(Token = "0x6006D3C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D3D"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C14")]
    public string ItemName
    {
      [Token(Token = "0x6006D3E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D3F"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C15")]
    public string SubItemName
    {
      [Token(Token = "0x6006D40"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D41"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000C16")]
    public List<CrystalRecommendCondParam> Conditions
    {
      [Token(Token = "0x6006D42"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<CrystalRecommendCondParam>) null;
      }
      [Token(Token = "0x6006D43"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x6006D44")]
    [Address(RVA = "0x35B460", Offset = "0x35A260", VA = "0x1035B460")]
    public bool Deserialize(JSON_CrystalRecommendParam json) => new bool();

    [Token(Token = "0x6006D45")]
    [Address(RVA = "0x35B620", Offset = "0x35A420", VA = "0x1035B620")]
    public static void Deserialize(
      ref List<CrystalRecommendParam> param,
      JSON_CrystalRecommendParam[] json)
    {
    }

    [Token(Token = "0x6006D46")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalRecommendParam()
    {
    }
  }
}
