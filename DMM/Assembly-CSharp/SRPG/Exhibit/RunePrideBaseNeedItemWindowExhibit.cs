// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideBaseNeedItemWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034CD")]
  public class RunePrideBaseNeedItemWindowExhibit : 
    BaseExhibit,
    IRenderModel<RunePrideBaseNeedItemWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA86")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("ベースタイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideBaseNeedItemWindowExhibit.BaseEKey), typeof (RunePrideBaseNeedItemWindowExhibit))]
    [CustomGroup("基本")]
    public string m_BaseKeyName;

    [Token(Token = "0x600EA21")]
    [Address(RVA = "0xAF21D0", Offset = "0xAF0FD0", VA = "0x10AF21D0", Slot = "8")]
    public void Render(RunePrideBaseNeedItemWindowModel _model)
    {
    }

    [Token(Token = "0x600EA22")]
    [Address(RVA = "0xADC0E0", Offset = "0xADAEE0", VA = "0x10ADC0E0")]
    private new void SetTextColor(Color _color)
    {
    }

    [Token(Token = "0x600EA23")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideBaseNeedItemWindowExhibit()
    {
    }

    [Token(Token = "0x20034CE")]
    private enum BaseEKey
    {
      [Token(Token = "0x400FA88")] None,
      [Token(Token = "0x400FA89")] DispNotEnoughObj,
      [Token(Token = "0x400FA8A")] DispNeedItemList,
      [Token(Token = "0x400FA8B")] DispNeedGold,
      [Token(Token = "0x400FA8C")] TextNeedGold,
      [Token(Token = "0x400FA8D")] DispNeedCoin,
      [Token(Token = "0x400FA8E")] TextNeedCoin,
      [Token(Token = "0x400FA8F")] CostImageType,
      [Token(Token = "0x400FA90")] DispNowGold,
      [Token(Token = "0x400FA91")] TextNowGold,
      [Token(Token = "0x400FA92")] DispNowCoin,
      [Token(Token = "0x400FA93")] TextNowCoinFree,
      [Token(Token = "0x400FA94")] TextNowCoinPaid,
      [Token(Token = "0x400FA95")] TextNowCoin,
      [Token(Token = "0x400FA96")] CommonButton,
      [Token(Token = "0x400FA97")] FreeButton,
      [Token(Token = "0x400FA98")] ItemOnlyButton,
      [Token(Token = "0x400FA99")] CoinGoldButton,
      [Token(Token = "0x400FA9A")] DispLuminous,
    }
  }
}
