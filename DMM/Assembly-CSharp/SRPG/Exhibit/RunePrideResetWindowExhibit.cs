// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideResetWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034E5")]
  public class RunePrideResetWindowExhibit : 
    RunePrideBaseNeedItemWindowExhibit,
    IRenderModel<RunePrideResetWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB15")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideResetWindowExhibit.EKey), typeof (RunePrideResetWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA4C")]
    [Address(RVA = "0xAF5050", Offset = "0xAF3E50", VA = "0x10AF5050", Slot = "9")]
    public void Render(RunePrideResetWindowModel _model)
    {
    }

    [Token(Token = "0x600EA4D")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideResetWindowExhibit()
    {
    }

    [Token(Token = "0x20034E6")]
    private enum EKey
    {
      [Token(Token = "0x400FB17")] None,
      [Token(Token = "0x400FB18")] ReturnCoinGoldObj,
      [Token(Token = "0x400FB19")] ReturnCoin,
      [Token(Token = "0x400FB1A")] ReturnGold,
      [Token(Token = "0x400FB1B")] ReturnItem,
      [Token(Token = "0x400FB1C")] ResetCountObj,
      [Token(Token = "0x400FB1D")] NowResetCountText,
      [Token(Token = "0x400FB1E")] MaxResetCountText,
      [Token(Token = "0x400FB1F")] ResetText,
      [Token(Token = "0x400FB20")] NowResetCountSubText,
    }
  }
}
