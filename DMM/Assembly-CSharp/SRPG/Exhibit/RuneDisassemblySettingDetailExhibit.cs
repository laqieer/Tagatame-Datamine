// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RuneDisassemblySettingDetailExhibit
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
  [Token(Token = "0x20034AC")]
  public class RuneDisassemblySettingDetailExhibit : 
    BaseExhibit,
    IRenderModel<RuneDisassemblySettingDetailModel>,
    IRenderModel
  {
    [Token(Token = "0x400FA0E")]
    [FieldOffset(Offset = "0x34")]
    private List<RuneDisassemblySettingStatusModel> _models;
    [Token(Token = "0x400FA0F")]
    [FieldOffset(Offset = "0x38")]
    private List<ExhibitList> _exhibitList;
    [Token(Token = "0x400FA10")]
    [FieldOffset(Offset = "0x3C")]
    private RuneDisassemblySettingDetailModel _model;
    [Token(Token = "0x400FA11")]
    [FieldOffset(Offset = "0x40")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RuneDisassemblySettingDetailExhibit.EKey), typeof (RuneDisassemblySettingDetailExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400FA12")]
    [FieldOffset(Offset = "0x44")]
    [CustomField("ステータスのテンプレート", CustomFieldAttribute.Type.GameObject)]
    public GameObject templateStatusDetail;

    [Token(Token = "0x1700216F")]
    public RuneDisassemblySettingDetailModel ModelData
    {
      [Token(Token = "0x600E9F2"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (RuneDisassemblySettingDetailModel) null;
      }
    }

    [Token(Token = "0x600E9F3")]
    [Address(RVA = "0xAF12D0", Offset = "0xAF00D0", VA = "0x10AF12D0", Slot = "8")]
    public void Render(RuneDisassemblySettingDetailModel model)
    {
    }

    [Token(Token = "0x600E9F4")]
    [Address(RVA = "0xAF0DD0", Offset = "0xAEFBD0", VA = "0x10AF0DD0")]
    private void CreateStatusDetail(RuneDisassemblySettingDetailModel model)
    {
    }

    [Token(Token = "0x600E9F5")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RuneDisassemblySettingDetailExhibit()
    {
    }

    [Token(Token = "0x20034AD")]
    private enum EKey
    {
      [Token(Token = "0x400FA14")] None,
      [Token(Token = "0x400FA15")] Title,
      [Token(Token = "0x400FA16")] StatusDetail,
      [Token(Token = "0x400FA17")] IsSelect,
      [Token(Token = "0x400FA18")] IsSelectTab,
      [Token(Token = "0x400FA19")] RuneTypeIcon,
    }
  }
}
