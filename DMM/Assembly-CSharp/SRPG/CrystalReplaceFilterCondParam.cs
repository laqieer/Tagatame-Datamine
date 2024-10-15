// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReplaceFilterCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A94")]
  public class CrystalReplaceFilterCondParam
  {
    [Token(Token = "0x17000C20")]
    public string CrystalFilterIname
    {
      [Token(Token = "0x6006D60"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D61"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C21")]
    public eCrystalFilterTypes FilterType
    {
      [Token(Token = "0x6006D62"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new eCrystalFilterTypes();
      }
      [Token(Token = "0x6006D63"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17000C22")]
    public string CondIname
    {
      [Token(Token = "0x6006D64"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D65"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C23")]
    public string Name
    {
      [Token(Token = "0x6006D66"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D67"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000C24")]
    public bool IsEnableSetBonus
    {
      [Token(Token = "0x6006D68"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6006D69"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] private set
      {
      }
    }

    [Token(Token = "0x17000C25")]
    public ERarity Rank
    {
      [Token(Token = "0x6006D6A"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new ERarity();
      }
      [Token(Token = "0x6006D6B"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x17000C26")]
    public ParamTypes ParamType
    {
      [Token(Token = "0x6006D6C"), Address(RVA = "0x35B820", Offset = "0x35A620", VA = "0x1035B820")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6006D6D"), Address(RVA = "0x35B860", Offset = "0x35A660", VA = "0x1035B860")] private set
      {
      }
    }

    [Token(Token = "0x17000C27")]
    public ParamTypes SetBonusParamType
    {
      [Token(Token = "0x6006D6E"), Address(RVA = "0x35B830", Offset = "0x35A630", VA = "0x1035B830")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6006D6F"), Address(RVA = "0x35B880", Offset = "0x35A680", VA = "0x1035B880")] private set
      {
      }
    }

    [Token(Token = "0x17000C28")]
    public eOverWritePartyType[] OverWritePartyTypes
    {
      [Token(Token = "0x6006D70"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (eOverWritePartyType[]) null;
      }
      [Token(Token = "0x6006D71"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] private set
      {
      }
    }

    [Token(Token = "0x6006D72")]
    [Address(RVA = "0x35B720", Offset = "0x35A520", VA = "0x1035B720")]
    public bool Deserialize(
      string parent_iname,
      bool is_enable_set_bonus,
      JSON_CrystalReplaceFilterCondParam json)
    {
      return new bool();
    }

    [Token(Token = "0x17000C29")]
    public string PrefsKey
    {
      [Token(Token = "0x6006D73"), Address(RVA = "0x357C20", Offset = "0x356A20", VA = "0x10357C20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006D74")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalReplaceFilterCondParam()
    {
    }
  }
}
