// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.CoinConfirmExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033F1")]
  public class CoinConfirmExhibit : BaseExhibit, IRenderModel<CoinConfirmModel>, IRenderModel
  {
    [Token(Token = "0x400F645")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (CoinConfirmExhibit.EKey), typeof (CoinConfirmExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E8C7")]
    [Address(RVA = "0xAD7FA0", Offset = "0xAD6DA0", VA = "0x10AD7FA0", Slot = "8")]
    public void Render(CoinConfirmModel model)
    {
    }

    [Token(Token = "0x600E8C8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CoinConfirmExhibit()
    {
    }

    [Token(Token = "0x20033F2")]
    private enum EKey
    {
      [Token(Token = "0x400F647")] None,
      [Token(Token = "0x400F648")] Title,
      [Token(Token = "0x400F649")] MainText,
      [Token(Token = "0x400F64A")] SubText,
      [Token(Token = "0x400F64B")] PaidCoin,
      [Token(Token = "0x400F64C")] FreeCoin,
      [Token(Token = "0x400F64D")] YesText,
      [Token(Token = "0x400F64E")] NoText,
      [Token(Token = "0x400F64F")] YesButton,
      [Token(Token = "0x400F650")] NoButton,
      [Token(Token = "0x400F651")] IsDisplayCoin,
      [Token(Token = "0x400F652")] PeriodText,
      [Token(Token = "0x400F653")] IsCautionDisplay,
    }
  }
}
