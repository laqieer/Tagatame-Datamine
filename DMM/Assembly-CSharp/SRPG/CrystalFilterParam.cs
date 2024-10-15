// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalFilterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A88")]
  public class CrystalFilterParam
  {
    [Token(Token = "0x17000BFB")]
    public string Iname
    {
      [Token(Token = "0x6006CF7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006CF8"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000BFC")]
    public string TabName
    {
      [Token(Token = "0x6006CF9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006CFA"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000BFD")]
    public string Name
    {
      [Token(Token = "0x6006CFB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006CFC"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000BFE")]
    public eCrystalFilterTypes Categry
    {
      [Token(Token = "0x6006CFD"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new eCrystalFilterTypes();
      }
      [Token(Token = "0x6006CFE"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000BFF")]
    public List<CrystalFilterCondParam> Conds
    {
      [Token(Token = "0x6006CFF"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<CrystalFilterCondParam>) null;
      }
      [Token(Token = "0x6006D00"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x6006D01")]
    [Address(RVA = "0x357C50", Offset = "0x356A50", VA = "0x10357C50")]
    public bool Deserialize(JSON_CrystalFilterParam json) => new bool();

    [Token(Token = "0x6006D02")]
    [Address(RVA = "0x357E80", Offset = "0x356C80", VA = "0x10357E80")]
    public static void Deserialize(
      ref List<CrystalFilterParam> param,
      JSON_CrystalFilterParam[] json)
    {
    }

    [Token(Token = "0x6006D03")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalFilterParam()
    {
    }
  }
}
