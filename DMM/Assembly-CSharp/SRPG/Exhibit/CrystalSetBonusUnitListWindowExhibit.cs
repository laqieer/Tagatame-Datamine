// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalSetBonusUnitListWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003421")]
  public class CrystalSetBonusUnitListWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalSetBonusUnitListWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F74F")]
    [FieldOffset(Offset = "0x34")]
    public CrystalIcon CrystalIcon;
    [Token(Token = "0x400F750")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalSetBonusUnitListWindowExhibit.EKey), typeof (CrystalSetBonusUnitListWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E90E")]
    [Address(RVA = "0xADB930", Offset = "0xADA730", VA = "0x10ADB930", Slot = "8")]
    public void Render(CrystalSetBonusUnitListWindowModel model)
    {
    }

    [Token(Token = "0x600E90F")]
    [Address(RVA = "0xADBAF0", Offset = "0xADA8F0", VA = "0x10ADBAF0")]
    private void SetCrystalIcon(CrystalIcon icon, CrystalData data, CrystalParam param)
    {
    }

    [Token(Token = "0x600E910")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalSetBonusUnitListWindowExhibit()
    {
    }

    [Token(Token = "0x2003422")]
    private enum EKey
    {
      [Token(Token = "0x400F752")] None,
      [Token(Token = "0x400F753")] Name,
      [Token(Token = "0x400F754")] CrystalIcon,
      [Token(Token = "0x400F755")] SelectObj,
    }
  }
}
