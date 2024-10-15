// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchBattleEditPlayerExhibit
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
  [Token(Token = "0x200344D")]
  public class LeagueMatchBattleEditPlayerExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchBattleEditPlayerModel>,
    IRenderModel
  {
    [Token(Token = "0x400F7F9")]
    [FieldOffset(Offset = "0x34")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchBattleEditPlayerExhibit.EKey), typeof (LeagueMatchBattleEditPlayerExhibit))]
    [CustomGroup("基本")]
    public string m_KeyName;
    [Token(Token = "0x400F7FA")]
    [FieldOffset(Offset = "0x38")]
    [CustomField("リスト", CustomFieldAttribute.Type.Array)]
    public List<GameObject> objectList;
    [Token(Token = "0x400F7FB")]
    [FieldOffset(Offset = "0x3C")]
    [CustomField("アイコンのオブジェクト", CustomFieldAttribute.Type.GameObject)]
    [CustomGroup("ユニット")]
    public GameObject UnitTemplate;
    [Token(Token = "0x400F7FC")]
    [FieldOffset(Offset = "0x40")]
    public ExhibitList IconExhibitList;
    [Token(Token = "0x400F7FD")]
    [FieldOffset(Offset = "0x44")]
    public SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400F7FE")]
    [FieldOffset(Offset = "0x48")]
    private List<ExhibitList> _exhibitLists;

    [Token(Token = "0x600E961")]
    [Address(RVA = "0xADE750", Offset = "0xADD550", VA = "0x10ADE750", Slot = "8")]
    public void Render(LeagueMatchBattleEditPlayerModel model)
    {
    }

    [Token(Token = "0x600E962")]
    [Address(RVA = "0xADE450", Offset = "0xADD250", VA = "0x10ADE450")]
    private void CreateUnitIcon(LeagueMatchBattleEditPlayerModel model)
    {
    }

    [Token(Token = "0x600E963")]
    [Address(RVA = "0xADE960", Offset = "0xADD760", VA = "0x10ADE960")]
    public LeagueMatchBattleEditPlayerExhibit()
    {
    }

    [Token(Token = "0x200344E")]
    private enum EKey
    {
      [Token(Token = "0x400F800")] None,
      [Token(Token = "0x400F801")] TotalPowerMessage,
      [Token(Token = "0x400F802")] UnitIcons,
      [Token(Token = "0x400F803")] SetData,
      [Token(Token = "0x400F804")] CheckBox,
      [Token(Token = "0x400F805")] TeamName,
    }
  }
}
