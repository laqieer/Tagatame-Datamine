// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalReplaceContentExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003407")]
  public class CrystalReplaceContentExhibit : 
    BaseExhibit,
    IRenderModel<CrystalReplaceContentModel>,
    IRenderModel
  {
    [Token(Token = "0x400F6CA")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalReplaceContentExhibit.EKey), typeof (CrystalReplaceContentExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F6CB")]
    [FieldOffset(Offset = "0x38")]
    public ExhibitList UnitIconExhibitList;
    [Token(Token = "0x400F6CC")]
    [FieldOffset(Offset = "0x3C")]
    public CrystalEquipSlot[] CrystalSlotExhibitList;
    [Token(Token = "0x400F6CD")]
    [FieldOffset(Offset = "0x40")]
    public CrystalReplaceSetBonus SetBonus;

    [Token(Token = "0x600E8EC")]
    [Address(RVA = "0xADB360", Offset = "0xADA160", VA = "0x10ADB360", Slot = "8")]
    public void Render(CrystalReplaceContentModel model)
    {
    }

    [Token(Token = "0x600E8ED")]
    [Address(RVA = "0xADB530", Offset = "0xADA330", VA = "0x10ADB530")]
    private void SetSlotData(CrystalReplaceContentModel model)
    {
    }

    [Token(Token = "0x600E8EE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalReplaceContentExhibit()
    {
    }

    [Token(Token = "0x2003408")]
    private enum EKey
    {
      [Token(Token = "0x400F6CF")] None,
      [Token(Token = "0x400F6D0")] UnitName,
      [Token(Token = "0x400F6D1")] Unit,
      [Token(Token = "0x400F6D2")] CrystalList,
      [Token(Token = "0x400F6D3")] SetBonus,
    }
  }
}
