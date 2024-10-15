// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeaderSkillSelectWindowExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003445")]
  public class LeaderSkillSelectWindowExhibit : 
    BaseExhibit,
    IRenderModel<LeaderSkillSelectWindowModel>,
    IRenderModel
  {
    [Token(Token = "0x400F7C9")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeaderSkillSelectWindowExhibit.EKey), typeof (LeaderSkillSelectWindowExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E958")]
    [Address(RVA = "0xADD6E0", Offset = "0xADC4E0", VA = "0x10ADD6E0", Slot = "8")]
    public void Render(LeaderSkillSelectWindowModel model)
    {
    }

    [Token(Token = "0x600E959")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeaderSkillSelectWindowExhibit()
    {
    }

    [Token(Token = "0x2003446")]
    private enum EKey
    {
      [Token(Token = "0x400F7CB")] None,
      [Token(Token = "0x400F7CC")] UnitSkillName,
      [Token(Token = "0x400F7CD")] UnitSkillExp,
      [Token(Token = "0x400F7CE")] UnitSkillUnSelectMask,
      [Token(Token = "0x400F7CF")] ConceptCardSkillName,
      [Token(Token = "0x400F7D0")] ConceptCardSkillExp,
      [Token(Token = "0x400F7D1")] ConceptCardSkillUnSelectMask,
      [Token(Token = "0x400F7D2")] IsButtonEnable,
    }
  }
}
