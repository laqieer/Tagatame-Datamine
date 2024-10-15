// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitAbilityPanelExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034F9")]
  public class UnitAbilityPanelExhibit : 
    BaseExhibit,
    IRenderModel<UnitAbilityPanelModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB70")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitAbilityPanelExhibit.EKey), typeof (UnitAbilityPanelExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA6F")]
    [Address(RVA = "0xAF8E40", Offset = "0xAF7C40", VA = "0x10AF8E40", Slot = "8")]
    public void Render(UnitAbilityPanelModel model)
    {
    }

    [Token(Token = "0x600EA70")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitAbilityPanelExhibit()
    {
    }

    [Token(Token = "0x20034FA")]
    private enum EKey
    {
      [Token(Token = "0x400FB72")] None,
      [Token(Token = "0x400FB73")] BgImage,
      [Token(Token = "0x400FB74")] BgImageEmpty,
      [Token(Token = "0x400FB75")] AbilityIcon,
      [Token(Token = "0x400FB76")] AbilityLock,
      [Token(Token = "0x400FB77")] AbilityName,
      [Token(Token = "0x400FB78")] AbilityEmptyText,
      [Token(Token = "0x400FB79")] AbilityLv,
      [Token(Token = "0x400FB7A")] AbilityLvMax,
      [Token(Token = "0x400FB7B")] AbilityCaution,
      [Token(Token = "0x400FB7C")] HideAbilityName,
    }
  }
}
