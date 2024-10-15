// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchBattleOptionExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003469")]
  public class LeagueMatchBattleOptionExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchBattleOptionModel>,
    IRenderModel
  {
    [Token(Token = "0x400F8B3")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchBattleOptionExhibit.EKey), typeof (LeagueMatchBattleOptionExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600E98A")]
    [Address(RVA = "0xADE9D0", Offset = "0xADD7D0", VA = "0x10ADE9D0", Slot = "8")]
    public void Render(LeagueMatchBattleOptionModel model)
    {
    }

    [Token(Token = "0x600E98B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchBattleOptionExhibit()
    {
    }

    [Token(Token = "0x200346A")]
    private enum EKey
    {
      [Token(Token = "0x400F8B5")] None,
      [Token(Token = "0x400F8B6")] SKILL_DIRECTION_CUT_TOGGLE,
      [Token(Token = "0x400F8B7")] ATTACK_NOTICE_TOGGLE,
      [Token(Token = "0x400F8B8")] ATTACK_NOTICE_OBJ,
    }
  }
}
