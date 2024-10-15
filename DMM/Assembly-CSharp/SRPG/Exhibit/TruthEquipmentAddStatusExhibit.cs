// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.TruthEquipmentAddStatusExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034F3")]
  public class TruthEquipmentAddStatusExhibit : 
    BaseExhibit,
    IRenderModel<TruthEquipmentAddStatusModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB5D")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (TruthEquipmentAddStatusExhibit.EKey), typeof (TruthEquipmentAddStatusExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FB5E")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("StatusList", CustomFieldAttribute.Type.Component, typeof (StatusList), null)]
    public StatusList m_StatusList;

    [Token(Token = "0x600EA67")]
    [Address(RVA = "0xAF8160", Offset = "0xAF6F60", VA = "0x10AF8160", Slot = "8")]
    public void Render(TruthEquipmentAddStatusModel model)
    {
    }

    [Token(Token = "0x600EA68")]
    [Address(RVA = "0xAF8330", Offset = "0xAF7130", VA = "0x10AF8330")]
    private void SetStatusList(TruthEquipmentAddStatusModel model)
    {
    }

    [Token(Token = "0x600EA69")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public TruthEquipmentAddStatusExhibit()
    {
    }

    [Token(Token = "0x20034F4")]
    private enum EKey
    {
      [Token(Token = "0x400FB60")] None,
      [Token(Token = "0x400FB61")] Status,
      [Token(Token = "0x400FB62")] Ability,
      [Token(Token = "0x400FB63")] OverwriteAbility,
    }
  }
}
