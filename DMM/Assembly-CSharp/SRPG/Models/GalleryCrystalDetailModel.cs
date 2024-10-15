// Decompiled with JetBrains decompiler
// Type: SRPG.Models.GalleryCrystalDetailModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003328")]
  public class GalleryCrystalDetailModel
  {
    [Token(Token = "0x400F165")]
    [FieldOffset(Offset = "0x8")]
    private CrystalParam mCrystalParam;

    [Token(Token = "0x17001DE1")]
    public string CrystalName
    {
      [Token(Token = "0x600E1AB"), Address(RVA = "0xAB17D0", Offset = "0xAB05D0", VA = "0x10AB17D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001DE2")]
    public string CrystalFlavor
    {
      [Token(Token = "0x600E1AC"), Address(RVA = "0xAB1780", Offset = "0xAB0580", VA = "0x10AB1780")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001DE3")]
    public CrystalParam Crystal
    {
      [Token(Token = "0x600E1AD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (CrystalParam) null;
      }
    }

    [Token(Token = "0x600E1AE")]
    [Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")]
    public void Initialize(CrystalParam param)
    {
    }

    [Token(Token = "0x600E1AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GalleryCrystalDetailModel()
    {
    }
  }
}
