// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeaderSkillSlotExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003447")]
  public class LeaderSkillSlotExhibit : BaseExhibit, IRenderModel<LeaderSkillSlotModel>, IRenderModel
  {
    [Token(Token = "0x400F7D3")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeaderSkillSlotExhibit.EKey), typeof (LeaderSkillSlotExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E95A")]
    [Address(RVA = "0xADD930", Offset = "0xADC730", VA = "0x10ADD930", Slot = "8")]
    public void Render(LeaderSkillSlotModel model)
    {
    }

    [Token(Token = "0x600E95B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeaderSkillSlotExhibit()
    {
    }

    [Token(Token = "0x2003448")]
    private enum EKey
    {
      [Token(Token = "0x400F7D5")] None,
      [Token(Token = "0x400F7D6")] LeaderSkillText,
      [Token(Token = "0x400F7D7")] LeaderSkillExplanationText,
      [Token(Token = "0x400F7D8")] SelectWindow,
      [Token(Token = "0x400F7D9")] SkillChangeButton,
      [Token(Token = "0x400F7DA")] LeaderSkillBgImage,
      [Token(Token = "0x400F7DB")] HideLeaderSkillText,
      [Token(Token = "0x400F7DC")] HideLeaderSkillExplanationText,
    }
  }
}
