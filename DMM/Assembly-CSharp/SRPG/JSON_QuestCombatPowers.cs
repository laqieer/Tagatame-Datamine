// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestCombatPowers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A5A")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_QuestCombatPowers
  {
    [Token(Token = "0x4006135")]
    [FieldOffset(Offset = "0x8")]
    public JSON_QuestCombatPower[] quests;
    [Token(Token = "0x4006136")]
    [FieldOffset(Offset = "0xC")]
    public JSON_AreaCombatPower[] areas;

    [Token(Token = "0x6006C5E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestCombatPowers()
    {
    }
  }
}
