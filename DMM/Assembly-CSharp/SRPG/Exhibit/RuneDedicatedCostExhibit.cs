// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDedicatedCostExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034A2")]
  public class RuneDedicatedCostExhibit : BaseExhibit, IRenderModel<RuneDedicatedModel>, IRenderModel
  {
    [Token(Token = "0x400F9E1")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDedicatedCostExhibit.EKey), typeof (RuneDedicatedCostExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E9E3")]
    [Address(RVA = "0xAEFC50", Offset = "0xAEEA50", VA = "0x10AEFC50", Slot = "8")]
    public void Render(RuneDedicatedModel model)
    {
    }

    [Token(Token = "0x600E9E4")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDedicatedCostExhibit()
    {
    }

    [Token(Token = "0x20034A3")]
    private enum EKey
    {
      [Token(Token = "0x400F9E3")] None,
      [Token(Token = "0x400F9E4")] COST_ITEM_OBJ,
      [Token(Token = "0x400F9E5")] COST_USE_GOLD_TEXT,
      [Token(Token = "0x400F9E6")] COST_USE_GOLD_OBJ,
      [Token(Token = "0x400F9E7")] COST_USE_COIN_TEXT,
      [Token(Token = "0x400F9E8")] COST_USE_COIN_OBJ,
      [Token(Token = "0x400F9E9")] DEDICATED_BTN,
      [Token(Token = "0x400F9EA")] RESET_BTN,
    }
  }
}
