// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.GalleryCrystalDetailExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200340D")]
  public class GalleryCrystalDetailExhibit : 
    BaseExhibit,
    IRenderModel<GalleryCrystalDetailModel>,
    IRenderModel
  {
    [Token(Token = "0x400F6E2")]
    [FieldOffset(Offset = "0x34")]
    public CrystalIcon CrystalIcon;
    [Token(Token = "0x400F6E3")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (GalleryCrystalDetailExhibit.EKey), typeof (GalleryCrystalDetailExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8F4")]
    [Address(RVA = "0xADCDB0", Offset = "0xADBBB0", VA = "0x10ADCDB0", Slot = "8")]
    public void Render(GalleryCrystalDetailModel model)
    {
    }

    [Token(Token = "0x600E8F5")]
    [Address(RVA = "0xADCFB0", Offset = "0xADBDB0", VA = "0x10ADCFB0")]
    private void SetCrystalIcon(CrystalParam param)
    {
    }

    [Token(Token = "0x600E8F6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GalleryCrystalDetailExhibit()
    {
    }

    [Token(Token = "0x200340E")]
    private enum EKey
    {
      [Token(Token = "0x400F6E5")] None,
      [Token(Token = "0x400F6E6")] Name,
      [Token(Token = "0x400F6E7")] Explain,
      [Token(Token = "0x400F6E8")] CrystalIcon,
    }
  }
}
