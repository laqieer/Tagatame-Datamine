// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePridePieceSelectItemListViewExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034DB")]
  public class RunePridePieceSelectItemListViewExhibit : 
    BaseItemExhibit,
    IRenderModel<RunePridePieceSelectItemListViewModel>,
    IRenderModel
  {
    [Token(Token = "0x400FAEB")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePridePieceSelectItemListViewExhibit.EKey), typeof (RunePridePieceSelectItemListViewExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA42")]
    [Address(RVA = "0xAF4580", Offset = "0xAF3380", VA = "0x10AF4580", Slot = "9")]
    public void Render(RunePridePieceSelectItemListViewModel model)
    {
    }

    [Token(Token = "0x600EA43")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePridePieceSelectItemListViewExhibit()
    {
    }

    [Token(Token = "0x20034DC")]
    private enum EKey
    {
      [Token(Token = "0x400FAED")] None,
      [Token(Token = "0x400FAEE")] Icon,
      [Token(Token = "0x400FAEF")] Frame,
      [Token(Token = "0x400FAF0")] CheckBox,
      [Token(Token = "0x400FAF1")] Slider,
      [Token(Token = "0x400FAF2")] MinusBtn,
      [Token(Token = "0x400FAF3")] PlusBtn,
      [Token(Token = "0x400FAF4")] ItemAmount,
      [Token(Token = "0x400FAF5")] UseItemNum,
      [Token(Token = "0x400FAF6")] Mask,
    }
  }
}
