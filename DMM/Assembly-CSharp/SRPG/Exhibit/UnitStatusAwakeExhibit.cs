// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitStatusAwakeExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003507")]
  public class UnitStatusAwakeExhibit : BaseExhibit, IRenderModel<UnitStatusAwakeModel>, IRenderModel
  {
    [Token(Token = "0x400FBC5")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitStatusAwakeExhibit.EKey), typeof (UnitStatusAwakeExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400FBC6")]
    [FieldOffset(Offset = "0x38")]
    public UnitStatusAwakeContent StatusAwakeContent;
    [Token(Token = "0x400FBC7")]
    [FieldOffset(Offset = "0x3C")]
    public ExhibitList UnitExhibitList;
    [Token(Token = "0x400FBC8")]
    [FieldOffset(Offset = "0x40")]
    public Color ExplainTextColor;
    [Token(Token = "0x400FBC9")]
    [FieldOffset(Offset = "0x50")]
    public Color ExplainMaxTextColor;

    [Token(Token = "0x600EA81")]
    [Address(RVA = "0xAFB290", Offset = "0xAFA090", VA = "0x10AFB290", Slot = "8")]
    public void Render(UnitStatusAwakeModel model)
    {
    }

    [Token(Token = "0x600EA82")]
    [Address(RVA = "0xAFAE80", Offset = "0xAF9C80", VA = "0x10AFAE80")]
    private void CreateContent(UnitStatusAwakeModel model)
    {
    }

    [Token(Token = "0x600EA83")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitStatusAwakeExhibit()
    {
    }

    [Token(Token = "0x2003508")]
    private enum EKey
    {
      [Token(Token = "0x400FBCB")] None,
      [Token(Token = "0x400FBCC")] UnitData,
      [Token(Token = "0x400FBCD")] HpAndStatusAwake,
      [Token(Token = "0x400FBCE")] StatusAwakeLimit,
      [Token(Token = "0x400FBCF")] SelectJob,
      [Token(Token = "0x400FBD0")] Contents,
      [Token(Token = "0x400FBD1")] ResetBtn,
      [Token(Token = "0x400FBD2")] ExplainText,
      [Token(Token = "0x400FBD3")] MaxDisableObj,
    }
  }
}
