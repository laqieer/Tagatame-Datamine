// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSetBonusFilterCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A9D")]
  public class CrystalSetBonusFilterCondParam
  {
    [Token(Token = "0x17000C34")]
    public string CrystalFilterIname
    {
      [Token(Token = "0x6006DA1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DA2"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C35")]
    public string CondIname
    {
      [Token(Token = "0x6006DA3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DA4"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C36")]
    public string Name
    {
      [Token(Token = "0x6006DA5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DA6"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C37")]
    public ERarity Rank
    {
      [Token(Token = "0x6006DA7"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new ERarity();
      }
      [Token(Token = "0x6006DA8"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000C38")]
    public ParamTypes ParamType
    {
      [Token(Token = "0x6006DA9"), Address(RVA = "0x35C000", Offset = "0x35AE00", VA = "0x1035C000")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6006DAA"), Address(RVA = "0x35C030", Offset = "0x35AE30", VA = "0x1035C030")] private set
      {
      }
    }

    [Token(Token = "0x17000C39")]
    public eCrystalFilterTypes FilterType
    {
      [Token(Token = "0x6006DAB"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new eCrystalFilterTypes();
      }
      [Token(Token = "0x6006DAC"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x6006DAD")]
    [Address(RVA = "0x35BF90", Offset = "0x35AD90", VA = "0x1035BF90")]
    public bool Deserialize(
      JSON_CrystalSetBonusFilterParam parent,
      JSON_CrystalFilterCondParam json)
    {
      return new bool();
    }

    [Token(Token = "0x17000C3A")]
    public string PrefsKey
    {
      [Token(Token = "0x6006DAE"), Address(RVA = "0x35C010", Offset = "0x35AE10", VA = "0x1035C010")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006DAF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalSetBonusFilterCondParam()
    {
    }
  }
}
