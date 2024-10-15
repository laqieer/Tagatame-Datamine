// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchBattleEditEnemyExhibit
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
  [Token(Token = "0x200344B")]
  public class LeagueMatchBattleEditEnemyExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchBattleEditEnemyModel>,
    IRenderModel
  {
    [Token(Token = "0x400F7E6")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchBattleEditEnemyExhibit.EKey), typeof (LeagueMatchBattleEditEnemyExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F7E7")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("リスト", CustomFieldAttribute.Type.Array)]
    public List<GameObject> objectList;
    [Token(Token = "0x400F7E8")]
    [FieldOffset(Offset = "0x3C")]
    public SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400F7E9")]
    [FieldOffset(Offset = "0x40")]
    public List<ExhibitList> _unitIconExhibitLists;
    [Token(Token = "0x400F7EA")]
    [FieldOffset(Offset = "0x44")]
    public List<SerializeValueBehaviour> _unitIconSerializeValueList;
    [Token(Token = "0x400F7EB")]
    [FieldOffset(Offset = "0x48")]
    public List<ExhibitList> _hideExhibitLists;

    [Token(Token = "0x600E95E")]
    [Address(RVA = "0xADDDB0", Offset = "0xADCBB0", VA = "0x10ADDDB0", Slot = "8")]
    public void Render(LeagueMatchBattleEditEnemyModel model)
    {
    }

    [Token(Token = "0x600E95F")]
    [Address(RVA = "0xADE160", Offset = "0xADCF60", VA = "0x10ADE160")]
    private void SetUnitIcon(LeagueMatchBattleEditEnemyModel model)
    {
    }

    [Token(Token = "0x600E960")]
    [Address(RVA = "0xADE370", Offset = "0xADD170", VA = "0x10ADE370")]
    public LeagueMatchBattleEditEnemyExhibit()
    {
    }

    [Token(Token = "0x200344C")]
    private enum EKey
    {
      [Token(Token = "0x400F7ED")] None,
      [Token(Token = "0x400F7EE")] UserName,
      [Token(Token = "0x400F7EF")] UserLevel,
      [Token(Token = "0x400F7F0")] TotalPowerMessage,
      [Token(Token = "0x400F7F1")] RankIcon,
      [Token(Token = "0x400F7F2")] RankName,
      [Token(Token = "0x400F7F3")] Point,
      [Token(Token = "0x400F7F4")] BattleButton,
      [Token(Token = "0x400F7F5")] WinLose,
      [Token(Token = "0x400F7F6")] RankingOut,
      [Token(Token = "0x400F7F7")] UnitIcons,
      [Token(Token = "0x400F7F8")] SetData,
    }
  }
}
