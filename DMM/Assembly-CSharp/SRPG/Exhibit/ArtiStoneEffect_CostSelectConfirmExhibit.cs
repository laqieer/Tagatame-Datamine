// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.ArtiStoneEffect_CostSelectConfirmExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20033E7")]
  public class ArtiStoneEffect_CostSelectConfirmExhibit : 
    BaseExhibit,
    IRenderModel<ArtiStoneEffect_CostSelectConfirmModel>,
    IRenderModel
  {
    [Token(Token = "0x400F5F7")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (ArtiStoneEffect_CostSelectConfirmExhibit.EKey), typeof (ArtiStoneEffect_CostSelectConfirmExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F5F8")]
    [FieldOffset(Offset = "0x38")]
    public ContentExhibit m_ContentExhibit;
    [Token(Token = "0x400F5F9")]
    [FieldOffset(Offset = "0x3C")]
    public LayoutElement m_LayoutElement;

    [Token(Token = "0x600E8BA")]
    [Address(RVA = "0xAC4800", Offset = "0xAC3600", VA = "0x10AC4800", Slot = "8")]
    public void Render(ArtiStoneEffect_CostSelectConfirmModel model)
    {
    }

    [Token(Token = "0x600E8BB")]
    [Address(RVA = "0xAC4990", Offset = "0xAC3790", VA = "0x10AC4990")]
    private void SetupContentNode(List<ArtifactIconBlockContentNodeModel> Models)
    {
    }

    [Token(Token = "0x600E8BC")]
    [Address(RVA = "0xAC46D0", Offset = "0xAC34D0", VA = "0x10AC46D0")]
    private bool CheckLoopFlags(int count) => new bool();

    [Token(Token = "0x600E8BD")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public ArtiStoneEffect_CostSelectConfirmExhibit()
    {
    }

    [Token(Token = "0x20033E8")]
    private enum EKey
    {
      [Token(Token = "0x400F5FB")] None,
      [Token(Token = "0x400F5FC")] ContentNodeExhibit,
      [Token(Token = "0x400F5FD")] IsPersonal,
      [Token(Token = "0x400F5FE")] IsCommon,
    }
  }
}
