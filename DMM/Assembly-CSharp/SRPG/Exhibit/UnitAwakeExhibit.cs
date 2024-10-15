// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitAwakeExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034FF")]
  public class UnitAwakeExhibit : BaseExhibit, IRenderModel<UnitAwakeModel>, IRenderModel
  {
    [Token(Token = "0x400FB91")]
    [FieldOffset(Offset = "0x34")]
    public int Index;
    [Token(Token = "0x400FB92")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitAwakeExhibit.EKey), typeof (UnitAwakeExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FB93")]
    [FieldOffset(Offset = "0x3C")]
    [CustomGroup("通常")]
    [CustomField("リスト", CustomFieldAttribute.Type.Array)]
    public List<GameObject> ObjectList;
    [Token(Token = "0x400FB94")]
    [FieldOffset(Offset = "0x40")]
    [CustomGroup("通常")]
    [CustomField("ImageArrayリスト", CustomFieldAttribute.Type.Array)]
    public List<ImageArray> ImageArrayList;
    [Token(Token = "0x400FB95")]
    [FieldOffset(Offset = "0x44")]
    [CustomGroup("共鳴")]
    [CustomField("リスト", CustomFieldAttribute.Type.Array)]
    public List<GameObject> ObjectList_Resonance;
    [Token(Token = "0x400FB96")]
    [FieldOffset(Offset = "0x48")]
    [CustomGroup("共鳴")]
    [CustomField("ImageArrayリスト", CustomFieldAttribute.Type.Array)]
    public List<ImageArray> ImageArrayList_Resonance;

    [Token(Token = "0x600EA76")]
    [Address(RVA = "0xAF91D0", Offset = "0xAF7FD0", VA = "0x10AF91D0", Slot = "8")]
    public void Render(UnitAwakeModel model)
    {
    }

    [Token(Token = "0x600EA77")]
    [Address(RVA = "0xAF94E0", Offset = "0xAF82E0", VA = "0x10AF94E0")]
    private void ResonanceAwake(UnitAwakeModel model)
    {
    }

    [Token(Token = "0x600EA78")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitAwakeExhibit()
    {
    }

    [Token(Token = "0x2003500")]
    private enum EKey
    {
      [Token(Token = "0x400FB98"), CustomEnumDesc("未設定")] None,
      [Token(Token = "0x400FB99"), CustomEnumDesc("限界突破(現在は使用しない)")] Awake,
      [Token(Token = "0x400FB9A"), CustomEnumDesc("共鳴による限界突破")] ResonanceAwake,
    }
  }
}
