// Decompiled with JetBrains decompiler
// Type: SRPG.BondRecipeParam
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
  [Token(Token = "0x20019BD")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondRecipeParam
  {
    [Token(Token = "0x17000B25")]
    public string Iname
    {
      [Token(Token = "0x6006906"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006907"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000B26")]
    public List<BondRecipeMatsParam> Materials
    {
      [Token(Token = "0x6006908"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<BondRecipeMatsParam>) null;
      }
      [Token(Token = "0x6006909"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600690A")]
    [Address(RVA = "0x34DD80", Offset = "0x34CB80", VA = "0x1034DD80")]
    public bool Deserialize(Json_BondRecipeParam json) => new bool();

    [Token(Token = "0x600690B")]
    [Address(RVA = "0x34DED0", Offset = "0x34CCD0", VA = "0x1034DED0")]
    public static void Deserialize(ref List<BondRecipeParam> param, Json_BondRecipeParam[] json)
    {
    }

    [Token(Token = "0x600690C")]
    [Address(RVA = "0x34E100", Offset = "0x34CF00", VA = "0x1034E100")]
    public static BondRecipeParam GetParam(string receipe_iname) => (BondRecipeParam) null;

    [Token(Token = "0x600690D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondRecipeParam()
    {
    }
  }
}
