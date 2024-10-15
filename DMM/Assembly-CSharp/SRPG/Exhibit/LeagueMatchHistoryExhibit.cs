// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchHistoryExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003457")]
  public class LeagueMatchHistoryExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchHistoryModel>,
    IRenderModel
  {
    [Token(Token = "0x400F83D")]
    [FieldOffset(Offset = "0x34")]
    public ExhibitList UnitIcon;
    [Token(Token = "0x400F83E")]
    [FieldOffset(Offset = "0x38")]
    public ButtonEvent DetailBtn;
    [Token(Token = "0x400F83F")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchHistoryExhibit.EKey), typeof (LeagueMatchHistoryExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;

    [Token(Token = "0x600E970")]
    [Address(RVA = "0xADF9A0", Offset = "0xADE7A0", VA = "0x10ADF9A0", Slot = "8")]
    public void Render(LeagueMatchHistoryModel model)
    {
    }

    [Token(Token = "0x600E971")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchHistoryExhibit()
    {
    }

    [Token(Token = "0x2003458")]
    private enum EKey
    {
      [Token(Token = "0x400F841")] None,
      [Token(Token = "0x400F842")] AttackType,
      [Token(Token = "0x400F843")] BattleResult,
      [Token(Token = "0x400F844")] PlayerName,
      [Token(Token = "0x400F845")] PlayerLv,
      [Token(Token = "0x400F846")] TotalCombatPower,
      [Token(Token = "0x400F847")] UnitIcon,
      [Token(Token = "0x400F848")] Rank,
      [Token(Token = "0x400F849")] Score,
    }
  }
}
