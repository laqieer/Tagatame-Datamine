// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.WorldRaidBattlePointExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x200350D")]
  public class WorldRaidBattlePointExhibit : 
    BaseExhibit,
    IRenderModel<WorldRaidBattlePointModel>,
    IRenderModel
  {
    [Token(Token = "0x400FBDD")]
    [FieldOffset(Offset = "0x34")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (WorldRaidBattlePointExhibit.EKey), typeof (WorldRaidBattlePointExhibit))]
    public string m_KeyName;
    [Token(Token = "0x400FBDE")]
    [FieldOffset(Offset = "0x38")]
    public GameObject[] mBpList;

    [Token(Token = "0x600EA88")]
    [Address(RVA = "0xAFE310", Offset = "0xAFD110", VA = "0x10AFE310", Slot = "8")]
    public void Render(WorldRaidBattlePointModel _model)
    {
    }

    [Token(Token = "0x600EA89")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public WorldRaidBattlePointExhibit()
    {
    }

    [Token(Token = "0x200350E")]
    private enum EKey
    {
      [Token(Token = "0x400FBE0")] None,
      [Token(Token = "0x400FBE1")] DispObj,
      [Token(Token = "0x400FBE2")] DispBp,
      [Token(Token = "0x400FBE3")] RemainObj,
      [Token(Token = "0x400FBE4")] RemainText,
      [Token(Token = "0x400FBE5")] HealButton,
      [Token(Token = "0x400FBE6")] DispNotTimeHeal,
      [Token(Token = "0x400FBE7")] HealButtonObj,
    }
  }
}
