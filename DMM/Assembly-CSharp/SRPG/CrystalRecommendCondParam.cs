// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalRecommendCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A90")]
  public class CrystalRecommendCondParam
  {
    [Token(Token = "0x17000C17")]
    public string CndsIname
    {
      [Token(Token = "0x6006D47"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D48"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C18")]
    public string Name
    {
      [Token(Token = "0x6006D49"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D4A"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C19")]
    public ParamTypes ParamType
    {
      [Token(Token = "0x6006D4B"), Address(RVA = "0x35B440", Offset = "0x35A240", VA = "0x1035B440")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6006D4C"), Address(RVA = "0x35B450", Offset = "0x35A250", VA = "0x1035B450")] private set
      {
      }
    }

    [Token(Token = "0x17000C1A")]
    public string TagName
    {
      [Token(Token = "0x6006D4D"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D4E"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x6006D4F")]
    [Address(RVA = "0x35B3E0", Offset = "0x35A1E0", VA = "0x1035B3E0")]
    public bool Deserialize(JSON_CrystalRecommendCondParam json) => new bool();

    [Token(Token = "0x6006D50")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalRecommendCondParam()
    {
    }
  }
}
