// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ExpansionPurchaseConfirmExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003491")]
  public class ExpansionPurchaseConfirmExhibit : 
    BaseExhibit,
    IRenderModel<ExpansionPurchaseConfirmModel>,
    IRenderModel
  {
    [Token(Token = "0x400F977")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ExpansionPurchaseConfirmExhibit.EKey), typeof (ExpansionPurchaseConfirmExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9BF")]
    [Address(RVA = "0xADC5C0", Offset = "0xADB3C0", VA = "0x10ADC5C0", Slot = "8")]
    public void Render(ExpansionPurchaseConfirmModel model)
    {
    }

    [Token(Token = "0x600E9C0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ExpansionPurchaseConfirmExhibit()
    {
    }

    [Token(Token = "0x2003492")]
    private enum EKey
    {
      [Token(Token = "0x400F979")] None,
      [Token(Token = "0x400F97A")] Title,
      [Token(Token = "0x400F97B")] MainText,
      [Token(Token = "0x400F97C")] YesText,
      [Token(Token = "0x400F97D")] NoText,
      [Token(Token = "0x400F97E")] YesButton,
      [Token(Token = "0x400F97F")] NoButton,
      [Token(Token = "0x400F980")] PeriodText,
      [Token(Token = "0x400F981")] PriceText,
    }
  }
}
