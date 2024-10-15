// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalFilterCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A89")]
  public class CrystalFilterCondParam
  {
    [Token(Token = "0x17000C00")]
    public string CrystalFilterIname
    {
      [Token(Token = "0x6006D04"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D05"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C01")]
    public eCrystalFilterTypes FilterType
    {
      [Token(Token = "0x6006D06"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new eCrystalFilterTypes();
      }
      [Token(Token = "0x6006D07"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17000C02")]
    public string CondIname
    {
      [Token(Token = "0x6006D08"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D09"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C03")]
    public string Name
    {
      [Token(Token = "0x6006D0A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D0B"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000C04")]
    public ERarity Rank
    {
      [Token(Token = "0x6006D0C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new ERarity();
      }
      [Token(Token = "0x6006D0D"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x17000C05")]
    public ParamTypes ParamType
    {
      [Token(Token = "0x6006D0E"), Address(RVA = "0x357C10", Offset = "0x356A10", VA = "0x10357C10")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6006D0F"), Address(RVA = "0x357C40", Offset = "0x356A40", VA = "0x10357C40")] private set
      {
      }
    }

    [Token(Token = "0x17000C06")]
    public eOverWritePartyType[] OverWritePartyTypes
    {
      [Token(Token = "0x6006D10"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (eOverWritePartyType[]) null;
      }
      [Token(Token = "0x6006D11"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x6006D12")]
    [Address(RVA = "0x357B20", Offset = "0x356920", VA = "0x10357B20")]
    public bool Deserialize(string parent_iname, JSON_CrystalFilterCondParam json) => new bool();

    [Token(Token = "0x17000C07")]
    public string PrefsKey
    {
      [Token(Token = "0x6006D13"), Address(RVA = "0x357C20", Offset = "0x356A20", VA = "0x10357C20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006D14")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalFilterCondParam()
    {
    }
  }
}
