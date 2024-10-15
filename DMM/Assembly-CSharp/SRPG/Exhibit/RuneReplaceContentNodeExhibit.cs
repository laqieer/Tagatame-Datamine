// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneReplaceContentNodeExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034BD")]
  public class RuneReplaceContentNodeExhibit : 
    BaseExhibit,
    IRenderModel<RuneReplaceContentNodeModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA50")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneReplaceContentNodeExhibit.EKey), typeof (RuneReplaceContentNodeExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400FA51")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("ユニットアイコン", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("ユニット表示")]
    public GameObject mUnitObj;
    [Token(Token = "0x400FA52")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("表示オブジェクト", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("刻印のセット効果")]
    public GameObject mRuneSetEffectObj;
    [Token(Token = "0x400FA53")]
    [FieldOffset(Offset = "0x40")]
    public ExhibitList UnitIconExhibitList;

    [Token(Token = "0x600EA0B")]
    [Address(RVA = "0xAF5610", Offset = "0xAF4410", VA = "0x10AF5610", Slot = "8")]
    public void Render(RuneReplaceContentNodeModel model)
    {
    }

    [Token(Token = "0x600EA0C")]
    [Address(RVA = "0xAF5990", Offset = "0xAF4790", VA = "0x10AF5990")]
    public void UnitIconUpdate(UnitModel model)
    {
    }

    [Token(Token = "0x600EA0D")]
    [Address(RVA = "0xAF58D0", Offset = "0xAF46D0", VA = "0x10AF58D0")]
    public void RuneSetEffectUpdate(UnitData unitData)
    {
    }

    [Token(Token = "0x600EA0E")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneReplaceContentNodeExhibit()
    {
    }

    [Token(Token = "0x20034BE")]
    public enum EKey
    {
      [Token(Token = "0x400FA55")] None,
      [Token(Token = "0x400FA56")] Unit,
      [Token(Token = "0x400FA57")] UnitName,
      [Token(Token = "0x400FA58")] RuneSetEffect,
    }
  }
}
