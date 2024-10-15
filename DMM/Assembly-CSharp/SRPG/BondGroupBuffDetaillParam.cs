// Decompiled with JetBrains decompiler
// Type: SRPG.BondGroupBuffDetaillParam
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
  [Token(Token = "0x20019AC")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondGroupBuffDetaillParam
  {
    [Token(Token = "0x4005E4D")]
    [FieldOffset(Offset = "0x38")]
    private BuffEffectParam mBuffEffectParam;
    [Token(Token = "0x4005E4E")]
    [FieldOffset(Offset = "0x3C")]
    private BondPieceParam mBondPieceParam;
    [Token(Token = "0x4005E4F")]
    [FieldOffset(Offset = "0x40")]
    private BondRecipeParam mBondRecipeParam;
    [Token(Token = "0x4005E50")]
    [FieldOffset(Offset = "0x44")]
    private List<string> mGetUnitInameAll;

    [Token(Token = "0x17000AFC")]
    public int Level
    {
      [Token(Token = "0x6006897"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6006898"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000AFD")]
    public string Name
    {
      [Token(Token = "0x6006899"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600689A"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000AFE")]
    public string Expr
    {
      [Token(Token = "0x600689B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600689C"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000AFF")]
    public EAbilityTypeDetail TypeDetail
    {
      [Token(Token = "0x600689D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new EAbilityTypeDetail();
      }
      [Token(Token = "0x600689E"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000B00")]
    public string BuffIname
    {
      [Token(Token = "0x600689F"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068A0"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17000B01")]
    public string PieceIname
    {
      [Token(Token = "0x60068A1"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068A2"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17000B02")]
    public string RecipeIname
    {
      [Token(Token = "0x60068A3"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068A4"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x17000B03")]
    public int NeedGoldNum
    {
      [Token(Token = "0x60068A5"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
      [Token(Token = "0x60068A6"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
      {
      }
    }

    [Token(Token = "0x17000B04")]
    public string NeedItemIname
    {
      [Token(Token = "0x60068A7"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068A8"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x17000B05")]
    public int NeedItemNum
    {
      [Token(Token = "0x60068A9"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
      [Token(Token = "0x60068AA"), Address(RVA = "0x2A09E0", Offset = "0x29F7E0", VA = "0x102A09E0")] private set
      {
      }
    }

    [Token(Token = "0x17000B06")]
    public string UnitGroupIname
    {
      [Token(Token = "0x60068AB"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60068AC"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] private set
      {
      }
    }

    [Token(Token = "0x17000B07")]
    public List<string> UnitInames
    {
      [Token(Token = "0x60068AD"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60068AE"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] private set
      {
      }
    }

    [Token(Token = "0x60068AF")]
    [Address(RVA = "0x34B880", Offset = "0x34A680", VA = "0x1034B880")]
    public bool Deserialize(Json_BondGroupBuffParamDetail json) => new bool();

    [Token(Token = "0x17000B08")]
    public BuffEffectParam GetBuffEffectParam
    {
      [Token(Token = "0x60068B0"), Address(RVA = "0x34BDD0", Offset = "0x34ABD0", VA = "0x1034BDD0")] get
      {
        return (BuffEffectParam) null;
      }
    }

    [Token(Token = "0x17000B09")]
    public BondPieceParam GetBondPieceParam
    {
      [Token(Token = "0x60068B1"), Address(RVA = "0x34B9E0", Offset = "0x34A7E0", VA = "0x1034B9E0")] get
      {
        return (BondPieceParam) null;
      }
    }

    [Token(Token = "0x17000B0A")]
    public BondRecipeParam GetBondRecipeParam
    {
      [Token(Token = "0x60068B2"), Address(RVA = "0x34BBC0", Offset = "0x34A9C0", VA = "0x1034BBC0")] get
      {
        return (BondRecipeParam) null;
      }
    }

    [Token(Token = "0x17000B0B")]
    public List<string> GetBuffUnitInames
    {
      [Token(Token = "0x60068B3"), Address(RVA = "0x34BEB0", Offset = "0x34ACB0", VA = "0x1034BEB0")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x60068B4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BondGroupBuffDetaillParam()
    {
    }
  }
}
