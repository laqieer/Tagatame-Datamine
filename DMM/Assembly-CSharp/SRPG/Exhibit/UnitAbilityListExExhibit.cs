// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitAbilityListExExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034F7")]
  public class UnitAbilityListExExhibit : 
    BaseExhibit,
    IRenderModel<UnitAbilityListExModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB6C")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitAbilityListExExhibit.EKey), typeof (UnitAbilityListExExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA6D")]
    [Address(RVA = "0xAF8D30", Offset = "0xAF7B30", VA = "0x10AF8D30", Slot = "8")]
    public void Render(UnitAbilityListExModel model)
    {
    }

    [Token(Token = "0x600EA6E")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitAbilityListExExhibit()
    {
    }

    [Token(Token = "0x20034F8")]
    private enum EKey
    {
      [Token(Token = "0x400FB6E")] None,
      [Token(Token = "0x400FB6F")] ChangeText,
    }
  }
}
