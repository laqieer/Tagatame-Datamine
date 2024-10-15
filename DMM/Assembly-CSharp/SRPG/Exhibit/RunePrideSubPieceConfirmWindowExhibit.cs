// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideSubPieceConfirmWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034E9")]
  public class RunePrideSubPieceConfirmWindowExhibit : 
    BaseExhibit,
    IRenderModel<RunePrideSubPieceConfirmWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB25")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideSubPieceConfirmWindowExhibit.EKey), typeof (RunePrideSubPieceConfirmWindowExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600EA50")]
    [Address(RVA = "0xAF5470", Offset = "0xAF4270", VA = "0x10AF5470", Slot = "8")]
    public void Render(RunePrideSubPieceConfirmWindowModel _model)
    {
    }

    [Token(Token = "0x600EA51")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideSubPieceConfirmWindowExhibit()
    {
    }

    [Token(Token = "0x20034EA")]
    private enum EKey
    {
      [Token(Token = "0x400FB27")] None,
      [Token(Token = "0x400FB28")] REPLACE_NUM,
      [Token(Token = "0x400FB29")] REPLACE_ITEM_NAME,
      [Token(Token = "0x400FB2A")] REPLACE_ITEM_AMOUNT,
    }
  }
}
