// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.SkillExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034ED")]
  public class SkillExhibit : BaseExhibit, IRenderModel<SkillModel>, IRenderModel
  {
    [Token(Token = "0x400FB3A")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (SkillExhibit.EKey), typeof (SkillExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA59")]
    [Address(RVA = "0xAF7E90", Offset = "0xAF6C90", VA = "0x10AF7E90", Slot = "8")]
    public void Render(SkillModel model)
    {
    }

    [Token(Token = "0x600EA5A")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public SkillExhibit()
    {
    }

    [Token(Token = "0x20034EE")]
    private enum EKey
    {
      [Token(Token = "0x400FB3C")] NAME,
      [Token(Token = "0x400FB3D")] EXPR,
      [Token(Token = "0x400FB3E")] USE_COUNT,
      [Token(Token = "0x400FB3F")] IMGINDEX_ELEMENT,
      [Token(Token = "0x400FB40")] IMGINDEX_ATKTYPE,
      [Token(Token = "0x400FB41")] IMGINDEX_ATKDETAILTYPE,
      [Token(Token = "0x400FB42")] ISDRAW_CASTSKILL,
      [Token(Token = "0x400FB43")] DRAW_CASTSPEED,
      [Token(Token = "0x400FB44")] DRAW_GEMS,
      [Token(Token = "0x400FB45")] DRAW_RANGEMIN,
      [Token(Token = "0x400FB46")] DRAW_RANGEMAX,
      [Token(Token = "0x400FB47")] DRAW_SCOPE,
      [Token(Token = "0x400FB48")] DRAW_HIGHT,
    }
  }
}
