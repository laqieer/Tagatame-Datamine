// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneSlotExExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034C7")]
  public class RuneSlotExExhibit : BaseExhibit, IRenderModel<RuneSlotExModel>, IRenderModel
  {
    [Token(Token = "0x400FA73")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneSlotExExhibit.EKey), typeof (RuneSlotExExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FA74")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("アイコン", CustomFieldAttribute.Type.Component, typeof (RuneIcon), null)]
    [CustomGroup("刻印アイコン")]
    public RuneIcon mRuneIcon;

    [Token(Token = "0x600EA1A")]
    [Address(RVA = "0xAF6490", Offset = "0xAF5290", VA = "0x10AF6490", Slot = "8")]
    public void Render(RuneSlotExModel model)
    {
    }

    [Token(Token = "0x600EA1B")]
    [Address(RVA = "0xAF63E0", Offset = "0xAF51E0", VA = "0x10AF63E0")]
    public void EquipEffect(bool isEffect)
    {
    }

    [Token(Token = "0x600EA1C")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneSlotExExhibit()
    {
    }

    [Token(Token = "0x20034C8")]
    private enum EKey
    {
      [Token(Token = "0x400FA76")] None,
      [Token(Token = "0x400FA77")] Select,
      [Token(Token = "0x400FA78")] SlotNumberImage,
      [Token(Token = "0x400FA79")] Equip,
      [Token(Token = "0x400FA7A")] NoEquip,
      [Token(Token = "0x400FA7B")] RuneIcon,
    }
  }
}
