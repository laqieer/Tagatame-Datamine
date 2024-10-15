// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDedicatedSelectedExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034A6")]
  public class RuneDedicatedSelectedExhibit : 
    BaseExhibit,
    IRenderModel<RuneDedicatedModel>,
    IRenderModel
  {
    [Token(Token = "0x400F9F2")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDedicatedSelectedExhibit.EKey), typeof (RuneDedicatedSelectedExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F9F3")]
    [FieldOffset(Offset = "0x38")]
    private Vector2 m_DefaultUnitImagePosition;

    [Token(Token = "0x600E9E8")]
    [Address(RVA = "0xAF0190", Offset = "0xAEEF90", VA = "0x10AF0190", Slot = "8")]
    public void Render(RuneDedicatedModel model)
    {
    }

    [Token(Token = "0x600E9E9")]
    [Address(RVA = "0xAF0620", Offset = "0xAEF420", VA = "0x10AF0620")]
    private void SetRuneIcon(RuneData runeData)
    {
    }

    [Token(Token = "0x600E9EA")]
    [Address(RVA = "0xAF0740", Offset = "0xAEF540", VA = "0x10AF0740")]
    private void SetUnitIcon(UnitData unitData)
    {
    }

    [Token(Token = "0x600E9EB")]
    [Address(RVA = "0xAF07E0", Offset = "0xAEF5E0", VA = "0x10AF07E0")]
    private void SetUnitImage((string path, Vector2 pos) imageData)
    {
    }

    [Token(Token = "0x600E9EC")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDedicatedSelectedExhibit()
    {
    }

    [Token(Token = "0x20034A7")]
    private enum EKey
    {
      [Token(Token = "0x400F9F5")] None,
      [Token(Token = "0x400F9F6")] SELECTED_RUNE_ICON,
      [Token(Token = "0x400F9F7")] SELECTED_UNIT_ICON,
      [Token(Token = "0x400F9F8")] SELECTED_UNIT_IMAGE,
      [Token(Token = "0x400F9F9")] SELECTED_UNIT_ICON_OBJECT,
      [Token(Token = "0x400F9FA")] SELECTED_RUNE_SLOT,
    }
  }
}
