// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSortCondParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AA4")]
  public class CrystalSortCondParam
  {
    [Token(Token = "0x17000C47")]
    public string CndsIname
    {
      [Token(Token = "0x6006DD2"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DD3"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C48")]
    public string Name
    {
      [Token(Token = "0x6006DD4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DD5"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C49")]
    public eCrystalSortType SortType
    {
      [Token(Token = "0x6006DD6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new eCrystalSortType();
      }
      [Token(Token = "0x6006DD7"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C4A")]
    public ParamTypes ParamType
    {
      [Token(Token = "0x6006DD8"), Address(RVA = "0x32A980", Offset = "0x329780", VA = "0x1032A980")] get
      {
        return new ParamTypes();
      }
      [Token(Token = "0x6006DD9"), Address(RVA = "0x32A990", Offset = "0x329790", VA = "0x1032A990")] private set
      {
      }
    }

    [Token(Token = "0x17000C4B")]
    public string TagName
    {
      [Token(Token = "0x6006DDA"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006DDB"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x6006DDC")]
    [Address(RVA = "0x35C780", Offset = "0x35B580", VA = "0x1035C780")]
    public bool Deserialize(JSON_CrystalSortCondParam json) => new bool();

    [Token(Token = "0x6006DDD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalSortCondParam()
    {
    }
  }
}
