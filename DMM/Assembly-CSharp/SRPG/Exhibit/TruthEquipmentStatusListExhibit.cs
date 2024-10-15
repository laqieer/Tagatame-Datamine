// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.TruthEquipmentStatusListExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034F5")]
  public class TruthEquipmentStatusListExhibit : 
    BaseExhibit,
    IRenderModel<TruthEquipmentStatusListModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB64")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (TruthEquipmentStatusListExhibit.EKey), typeof (TruthEquipmentStatusListExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400FB65")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("StatusList", CustomFieldAttribute.Type.Component, typeof (StatusList), null)]
    public StatusList m_StatusList;

    [Token(Token = "0x600EA6A")]
    [Address(RVA = "0xAF83B0", Offset = "0xAF71B0", VA = "0x10AF83B0", Slot = "8")]
    public void Render(TruthEquipmentStatusListModel model)
    {
    }

    [Token(Token = "0x600EA6B")]
    [Address(RVA = "0xAF85D0", Offset = "0xAF73D0", VA = "0x10AF85D0")]
    private void SetStatusList(TruthEquipmentStatusListModel model)
    {
    }

    [Token(Token = "0x600EA6C")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public TruthEquipmentStatusListExhibit()
    {
    }

    [Token(Token = "0x20034F6")]
    private enum EKey
    {
      [Token(Token = "0x400FB67")] None,
      [Token(Token = "0x400FB68")] Status,
      [Token(Token = "0x400FB69")] Ability,
      [Token(Token = "0x400FB6A")] Level,
      [Token(Token = "0x400FB6B")] OverwriteAbility,
    }
  }
}
