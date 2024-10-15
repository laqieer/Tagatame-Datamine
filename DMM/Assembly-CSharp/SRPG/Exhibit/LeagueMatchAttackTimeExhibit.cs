// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.LeagueMatchAttackTimeExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003449")]
  public class LeagueMatchAttackTimeExhibit : 
    BaseExhibit,
    IRenderModel<LeagueMatchAttackTimeModel>,
    IRenderModel
  {
    [Token(Token = "0x400F7DD")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (LeagueMatchAttackTimeExhibit.EKey), typeof (LeagueMatchAttackTimeExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400F7DE")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("Active用")]
    [CustomField("次回", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_Next;
    [Token(Token = "0x400F7DF")]
    [FieldOffset(Offset = "0x3C")]
    [CustomGroup("Active用")]
    [CustomField("次々回", CustomFieldAttribute.Type.GameObject)]
    public GameObject m_AfterNext;

    [Token(Token = "0x600E95C")]
    [Address(RVA = "0xADDB80", Offset = "0xADC980", VA = "0x10ADDB80", Slot = "8")]
    public void Render(LeagueMatchAttackTimeModel model)
    {
    }

    [Token(Token = "0x600E95D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchAttackTimeExhibit()
    {
    }

    [Token(Token = "0x200344A")]
    private enum EKey
    {
      [Token(Token = "0x400F7E1")] None,
      [Token(Token = "0x400F7E2")] NextTime,
      [Token(Token = "0x400F7E3")] NextAfterTime,
      [Token(Token = "0x400F7E4")] NextActive,
      [Token(Token = "0x400F7E5")] AfterNextActive,
    }
  }
}
