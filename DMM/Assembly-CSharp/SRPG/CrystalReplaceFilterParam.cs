// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReplaceFilterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A93")]
  public class CrystalReplaceFilterParam
  {
    [Token(Token = "0x17000C1B")]
    public string Iname
    {
      [Token(Token = "0x6006D53"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D54"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C1C")]
    public string TabName
    {
      [Token(Token = "0x6006D55"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D56"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C1D")]
    public string Name
    {
      [Token(Token = "0x6006D57"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D58"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C1E")]
    public eCrystalFilterTypes Categry
    {
      [Token(Token = "0x6006D59"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new eCrystalFilterTypes();
      }
      [Token(Token = "0x6006D5A"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000C1F")]
    public List<CrystalReplaceFilterCondParam> Conds
    {
      [Token(Token = "0x6006D5B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<CrystalReplaceFilterCondParam>) null;
      }
      [Token(Token = "0x6006D5C"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x6006D5D")]
    [Address(RVA = "0x35B890", Offset = "0x35A690", VA = "0x1035B890")]
    public bool Deserialize(JSON_CrystalReplaceFilterParam json) => new bool();

    [Token(Token = "0x6006D5E")]
    [Address(RVA = "0x35BAE0", Offset = "0x35A8E0", VA = "0x1035BAE0")]
    public static void Deserialize(
      ref List<CrystalReplaceFilterParam> param,
      JSON_CrystalReplaceFilterParam[] json)
    {
    }

    [Token(Token = "0x6006D5F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalReplaceFilterParam()
    {
    }
  }
}
