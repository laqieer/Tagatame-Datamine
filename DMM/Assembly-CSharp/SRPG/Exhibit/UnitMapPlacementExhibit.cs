// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitMapPlacementExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003505")]
  public class UnitMapPlacementExhibit : 
    BaseExhibit,
    IRenderModel<UnitMapPlacementModel>,
    IRenderModel
  {
    [Token(Token = "0x400FBBE")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitMapPlacementExhibit.EKey), typeof (UnitMapPlacementExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA7F")]
    [Address(RVA = "0xAFAD30", Offset = "0xAF9B30", VA = "0x10AFAD30", Slot = "8")]
    public void Render(UnitMapPlacementModel model)
    {
    }

    [Token(Token = "0x600EA80")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitMapPlacementExhibit()
    {
    }

    [Token(Token = "0x2003506")]
    private enum EKey
    {
      [Token(Token = "0x400FBC0")] None,
      [Token(Token = "0x400FBC1")] QuestName,
      [Token(Token = "0x400FBC2")] QuestExper,
      [Token(Token = "0x400FBC3")] ReadyBtn,
      [Token(Token = "0x400FBC4")] BattleBtn,
    }
  }
}
