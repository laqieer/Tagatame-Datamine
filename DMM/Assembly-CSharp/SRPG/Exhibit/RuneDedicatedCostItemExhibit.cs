// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDedicatedCostItemExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034A4")]
  public class RuneDedicatedCostItemExhibit : 
    BaseExhibit,
    IRenderModel<RuneDedicatedCostModel>,
    IRenderModel
  {
    [Token(Token = "0x400F9EB")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDedicatedCostItemExhibit.EKey), typeof (RuneDedicatedCostItemExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9E5")]
    [Address(RVA = "0xAEFED0", Offset = "0xAEECD0", VA = "0x10AEFED0", Slot = "8")]
    public void Render(RuneDedicatedCostModel model)
    {
    }

    [Token(Token = "0x600E9E6")]
    [Address(RVA = "0xAF00F0", Offset = "0xAEEEF0", VA = "0x10AF00F0")]
    private void SetItemIcon(ItemData itemData)
    {
    }

    [Token(Token = "0x600E9E7")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDedicatedCostItemExhibit()
    {
    }

    [Token(Token = "0x20034A5")]
    private enum EKey
    {
      [Token(Token = "0x400F9ED")] None,
      [Token(Token = "0x400F9EE")] COST_ITEM_ICON,
      [Token(Token = "0x400F9EF")] COST_ITEM_NEED_NUM_TEXT,
      [Token(Token = "0x400F9F0")] COST_ITEM_AMOUNT_TEXT,
      [Token(Token = "0x400F9F1")] COST_ITEM_NEED_TEXT_COLOR,
    }
  }
}
