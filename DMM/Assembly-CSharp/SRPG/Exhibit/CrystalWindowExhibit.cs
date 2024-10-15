// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CrystalWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003413")]
  public class CrystalWindowExhibit : BaseExhibit, IRenderModel<CrystalWindowModel>, IRenderModel
  {
    [Token(Token = "0x400F708")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CrystalWindowExhibit.EKey), typeof (CrystalWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E8FC")]
    [Address(RVA = "0xADC120", Offset = "0xADAF20", VA = "0x10ADC120", Slot = "8")]
    public void Render(CrystalWindowModel model)
    {
    }

    [Token(Token = "0x600E8FD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalWindowExhibit()
    {
    }

    [Token(Token = "0x2003414")]
    private enum EKey
    {
      [Token(Token = "0x400F70A")] None,
      [Token(Token = "0x400F70B")] SaleTab,
      [Token(Token = "0x400F70C")] BulkGradeUp,
      [Token(Token = "0x400F70D")] HaveCount,
      [Token(Token = "0x400F70E")] HaveMaxCount,
      [Token(Token = "0x400F70F")] SaleSelectCount,
      [Token(Token = "0x400F710")] SaleSelectMax,
      [Token(Token = "0x400F711")] SaleGold,
      [Token(Token = "0x400F712")] SaleCoin,
      [Token(Token = "0x400F713")] SaleExeBtn,
      [Token(Token = "0x400F714")] SaleSelectClear,
      [Token(Token = "0x400F715")] SaleSelectAll,
      [Token(Token = "0x400F716")] UnequipAll,
    }
  }
}
