// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitStatusPanelExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003509")]
  public class UnitStatusPanelExhibit : BaseExhibit, IRenderModel<UnitStatusPanelModel>, IRenderModel
  {
    [Token(Token = "0x400FBD4")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitStatusPanelExhibit.EKey), typeof (UnitStatusPanelExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA84")]
    [Address(RVA = "0xAFB610", Offset = "0xAFA410", VA = "0x10AFB610", Slot = "8")]
    public void Render(UnitStatusPanelModel model)
    {
    }

    [Token(Token = "0x600EA85")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitStatusPanelExhibit()
    {
    }

    [Token(Token = "0x200350A")]
    private enum EKey
    {
      [Token(Token = "0x400FBD6")] None,
      [Token(Token = "0x400FBD7")] ParamValueText,
    }
  }
}
