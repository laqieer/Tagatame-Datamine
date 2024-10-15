// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalDetailWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003411")]
  public class CrystalDetailWindowExhibit : 
    BaseExhibit,
    IRenderModel<CrystalDetailWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F6F1")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalDetailWindowExhibit.EKey), typeof (CrystalDetailWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8FA")]
    [Address(RVA = "0xAD9720", Offset = "0xAD8520", VA = "0x10AD9720", Slot = "8")]
    public void Render(CrystalDetailWindowModel _model)
    {
    }

    [Token(Token = "0x600E8FB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalDetailWindowExhibit()
    {
    }

    [Token(Token = "0x2003412")]
    private enum EKey
    {
      [Token(Token = "0x400F6F3")] None,
      [Token(Token = "0x400F6F4")] CrystalName,
      [Token(Token = "0x400F6F5")] IconImage,
      [Token(Token = "0x400F6F6")] RankObj,
      [Token(Token = "0x400F6F7")] RankImage,
      [Token(Token = "0x400F6F8")] PlusObj,
      [Token(Token = "0x400F6F9")] PlusText,
      [Token(Token = "0x400F6FA")] MaskImageObj,
      [Token(Token = "0x400F6FB")] FavoriteToggleObj,
      [Token(Token = "0x400F6FC")] FavoriteToggleInteractable,
      [Token(Token = "0x400F6FD")] DisassemblyBtnObj,
      [Token(Token = "0x400F6FE")] DisassemblyBtnInteractable,
      [Token(Token = "0x400F6FF")] GradeUpBtnObj,
      [Token(Token = "0x400F700")] GradeUpBtnInteractable,
      [Token(Token = "0x400F701")] GradeUpBtnEffectObj,
      [Token(Token = "0x400F702")] SetBonusBtnObj,
      [Token(Token = "0x400F703")] SetBonusBtnInteractable,
      [Token(Token = "0x400F704")] AllUnequipBtnObj,
      [Token(Token = "0x400F705")] AllUnequipBtnInteractable,
      [Token(Token = "0x400F706")] DummyParamDisp,
      [Token(Token = "0x400F707")] UsedWarningBtn,
    }
  }
}
