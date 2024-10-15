// Decompiled with JetBrains decompiler
// Type: SRPG.QuestResultData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028C0")]
  public class QuestResultData
  {
    [Token(Token = "0x400C34F")]
    [FieldOffset(Offset = "0x8")]
    public int StartExp;
    [Token(Token = "0x400C350")]
    [FieldOffset(Offset = "0xC")]
    public int StartGold;
    [Token(Token = "0x400C351")]
    [FieldOffset(Offset = "0x10")]
    public int StartBonusFlags;
    [Token(Token = "0x400C352")]
    [FieldOffset(Offset = "0x14")]
    public Dictionary<long, UnitData.CharacterQuestParam> CharacterQuest;
    [Token(Token = "0x400C353")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<long, string> SkillUnlocks;
    [Token(Token = "0x400C354")]
    [FieldOffset(Offset = "0x1C")]
    public BattleCore.Record Record;
    [Token(Token = "0x400C355")]
    [FieldOffset(Offset = "0x20")]
    public UnitGetParam GetUnits;
    [Token(Token = "0x400C356")]
    [FieldOffset(Offset = "0x24")]
    public bool IsFirstWin;
    [Token(Token = "0x400C357")]
    [FieldOffset(Offset = "0x28")]
    public int ArenaActionCount;
    [Token(Token = "0x400C358")]
    [FieldOffset(Offset = "0x2C")]
    public int ArenaEnemyActionCount;
    [Token(Token = "0x400C359")]
    [FieldOffset(Offset = "0x30")]
    public Dictionary<long, string> CollaboSkillUnlocks;

    [Token(Token = "0x600B841")]
    [Address(RVA = "0x7F27A0", Offset = "0x7F15A0", VA = "0x107F27A0")]
    public QuestResultData(QuestResultData.QuestResultStatus status)
    {
    }

    [Token(Token = "0x20028C1")]
    public class QuestResultStatus
    {
      [Token(Token = "0x400C35A")]
      [FieldOffset(Offset = "0x8")]
      public PlayerData player;
      [Token(Token = "0x400C35B")]
      [FieldOffset(Offset = "0xC")]
      public int bonusFlags;
      [Token(Token = "0x400C35C")]
      [FieldOffset(Offset = "0x10")]
      public BattleCore.Record record;
      [Token(Token = "0x400C35D")]
      [FieldOffset(Offset = "0x14")]
      public List<Unit> units;
      [Token(Token = "0x400C35E")]
      [FieldOffset(Offset = "0x18")]
      public bool isFirstWin;
      [Token(Token = "0x400C35F")]
      [FieldOffset(Offset = "0x1C")]
      public int arenaActionCount;
      [Token(Token = "0x400C360")]
      [FieldOffset(Offset = "0x20")]
      public int arenaEnemyActionCount;

      [Token(Token = "0x600B842")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public QuestResultStatus()
      {
      }
    }
  }
}
