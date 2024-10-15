// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ArtiStoneEffect_CostSelectExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033E9")]
  public class ArtiStoneEffect_CostSelectExhibit : 
    BaseExhibit,
    IRenderModel<ArtiStoneEffect_CostSelectModel>,
    IRenderModel
  {
    [Token(Token = "0x400F5FF")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ArtiStoneEffect_CostSelectExhibit.EKey), typeof (ArtiStoneEffect_CostSelectExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E8BE")]
    [Address(RVA = "0xAD5910", Offset = "0xAD4710", VA = "0x10AD5910", Slot = "8")]
    public void Render(ArtiStoneEffect_CostSelectModel model)
    {
    }

    [Token(Token = "0x600E8BF")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArtiStoneEffect_CostSelectExhibit()
    {
    }

    [Token(Token = "0x20033EA")]
    private enum EKey
    {
      [Token(Token = "0x400F601")] None,
      [Token(Token = "0x400F602")] CostButton,
      [Token(Token = "0x400F603")] OtherCostButton,
      [Token(Token = "0x400F604")] SelectNum,
      [Token(Token = "0x400F605")] SelectMaxNum,
      [Token(Token = "0x400F606")] GoldNum,
      [Token(Token = "0x400F607")] OtherCostNeedNum,
      [Token(Token = "0x400F608")] OtherCostHaveNum,
      [Token(Token = "0x400F609")] IsGoldCost,
      [Token(Token = "0x400F60A")] IsClearButton,
      [Token(Token = "0x400F60B")] OtherCostIcon,
    }
  }
}
