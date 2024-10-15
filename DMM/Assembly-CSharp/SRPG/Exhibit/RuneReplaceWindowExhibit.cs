// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneReplaceWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034C5")]
  public class RuneReplaceWindowExhibit : 
    BaseExhibit,
    IRenderModel<RuneReplaceWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA6A")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneReplaceWindowExhibit.EKey), typeof (RuneReplaceWindowExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FA6B")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("選択者表示")]
    [CustomField("オブジェクト", CustomFieldAttribute.Type.GameObject)]
    public GameObject mTargetChara;
    [Token(Token = "0x400FA6C")]
    [FieldOffset(Offset = "0x3C")]
    [CustomGroup("フィルターボタン")]
    [CustomField("画像群", CustomFieldAttribute.Type.ImageArray)]
    public ImageArray m_FilterButton;
    [Token(Token = "0x400FA6D")]
    [FieldOffset(Offset = "0x40")]
    [CustomField("テキスト外枠", CustomFieldAttribute.Type.Component, typeof (Outline), null)]
    [CustomGroup("フィルターボタン")]
    public Outline m_FilterButtonTextOutLine;
    [Token(Token = "0x400FA6E")]
    [FieldOffset(Offset = "0x44")]
    public List<Color> m_FilterButtonTextOutLineColor;

    [Token(Token = "0x600EA15")]
    [Address(RVA = "0xAF5E70", Offset = "0xAF4C70", VA = "0x10AF5E70", Slot = "8")]
    public void Render(RuneReplaceWindowModel model)
    {
    }

    [Token(Token = "0x600EA16")]
    [Address(RVA = "0xAF62B0", Offset = "0xAF50B0", VA = "0x10AF62B0")]
    public void TargetCharacter(RuneReplaceContentParam param)
    {
    }

    [Token(Token = "0x600EA17")]
    [Address(RVA = "0xAF61F0", Offset = "0xAF4FF0", VA = "0x10AF61F0")]
    public void SetFilterButton(int imageIndex)
    {
    }

    [Token(Token = "0x600EA18")]
    [Address(RVA = "0xAF6140", Offset = "0xAF4F40", VA = "0x10AF6140")]
    public void SetFilterButtonOutLine(int imageIndex)
    {
    }

    [Token(Token = "0x600EA19")]
    [Address(RVA = "0xAF6370", Offset = "0xAF5170", VA = "0x10AF6370")]
    public RuneReplaceWindowExhibit()
    {
    }

    [Token(Token = "0x20034C6")]
    public enum EKey
    {
      [Token(Token = "0x400FA70")] None,
      [Token(Token = "0x400FA71")] SELECT_CHARACTER,
      [Token(Token = "0x400FA72")] FILTER_BUTTON,
    }
  }
}
