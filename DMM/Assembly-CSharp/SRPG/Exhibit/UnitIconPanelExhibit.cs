// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.UnitIconPanelExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034FB")]
  public class UnitIconPanelExhibit : BaseExhibit, IRenderModel<UnitIconPanelModel>, IRenderModel
  {
    [Token(Token = "0x400FB7D")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (UnitIconPanelExhibit.EKey), typeof (UnitIconPanelExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FB7E")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("StarGauge", CustomFieldAttribute.Type.Component, typeof (StarGauge), null)]
    [CustomGroup("レアリティ")]
    public StarGauge mStarGauge;
    [Token(Token = "0x400FB7F")]
    [FieldOffset(Offset = "0x3C")]
    public ExhibitList mExhibitList;

    [Token(Token = "0x600EA71")]
    [Address(RVA = "0xAFA490", Offset = "0xAF9290", VA = "0x10AFA490", Slot = "8")]
    public void Render(UnitIconPanelModel model)
    {
    }

    [Token(Token = "0x600EA72")]
    [Address(RVA = "0xAFA810", Offset = "0xAF9610", VA = "0x10AFA810")]
    public void SetStarGauge(int value, int max)
    {
    }

    [Token(Token = "0x600EA73")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public UnitIconPanelExhibit()
    {
    }

    [Token(Token = "0x20034FC")]
    private enum EKey
    {
      [Token(Token = "0x400FB81")] None,
      [Token(Token = "0x400FB82")] UnitIcon,
      [Token(Token = "0x400FB83")] Level,
      [Token(Token = "0x400FB84")] LevelLimit,
      [Token(Token = "0x400FB85")] ExpBar,
      [Token(Token = "0x400FB86")] StarGauge,
      [Token(Token = "0x400FB87")] HoodUnitIcon,
      [Token(Token = "0x400FB88")] Resonance,
    }
  }
}
