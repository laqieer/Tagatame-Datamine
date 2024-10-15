// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerQuestConditionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A5C")]
  public class CombatPowerQuestConditionResult
  {
    [Token(Token = "0x400613E")]
    [FieldOffset(Offset = "0x8")]
    public CombatPowerQuestParam mCombatPowerQuestParam;
    [Token(Token = "0x400613F")]
    [FieldOffset(Offset = "0xC")]
    public QuestParam mQuestParam;
    [Token(Token = "0x4006140")]
    [FieldOffset(Offset = "0x10")]
    public ChapterParam mChapterParam;
    [Token(Token = "0x4006141")]
    [FieldOffset(Offset = "0x14")]
    public bool mIsUnlocked;
    [Token(Token = "0x4006142")]
    [FieldOffset(Offset = "0x15")]
    public bool mIsAlreadyUnlocked;
    [Token(Token = "0x4006143")]
    [FieldOffset(Offset = "0x18")]
    public int mTargetValue;
    [Token(Token = "0x4006144")]
    [FieldOffset(Offset = "0x1C")]
    public int mCurrentValue;

    [Token(Token = "0x6006C60")]
    [Address(RVA = "0x353140", Offset = "0x351F40", VA = "0x10353140")]
    public static CombatPowerQuestConditionResult JudgeByArea(
      CombatPowerQuestParam combatPowerQuestParam,
      bool check_parent = true)
    {
      return (CombatPowerQuestConditionResult) null;
    }

    [Token(Token = "0x6006C61")]
    [Address(RVA = "0x353260", Offset = "0x352060", VA = "0x10353260")]
    public static CombatPowerQuestConditionResult JudgeByQuest(
      CombatPowerQuestParam combatPowerQuestParam)
    {
      return (CombatPowerQuestConditionResult) null;
    }

    [Token(Token = "0x6006C62")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CombatPowerQuestConditionResult()
    {
    }
  }
}
