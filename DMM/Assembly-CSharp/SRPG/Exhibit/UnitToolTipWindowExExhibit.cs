// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitToolTipWindowExExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200350B")]
  public class UnitToolTipWindowExExhibit : 
    BaseExhibit,
    IRenderModel<UnitToolTipWindowExModel>,
    IRenderModel
  {
    [Token(Token = "0x400FBD8")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitToolTipWindowExExhibit.EKey), typeof (UnitToolTipWindowExExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA86")]
    [Address(RVA = "0xAFC2D0", Offset = "0xAFB0D0", VA = "0x10AFC2D0", Slot = "8")]
    public void Render(UnitToolTipWindowExModel model)
    {
    }

    [Token(Token = "0x600EA87")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitToolTipWindowExExhibit()
    {
    }

    [Token(Token = "0x200350C")]
    private enum EKey
    {
      [Token(Token = "0x400FBDA")] None,
      [Token(Token = "0x400FBDB")] RunesButton,
      [Token(Token = "0x400FBDC")] AutoSkillButton,
    }
  }
}
