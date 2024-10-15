// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBonusObjective
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C4E")]
  public class QuestBonusObjective
  {
    [Token(Token = "0x4006ECF")]
    public const string TXT_ID_SUFFIX_PROGRESS = "_PROGRESS";
    [Token(Token = "0x4006ED0")]
    public const string TXT_ID_SUFFIX_PROGRESS_TARGET = "_PROGRESS_TARGET";
    [Token(Token = "0x4006ED1")]
    public const string TXT_ID_SUFFIX_PROGRESS_OK = "_PROGRESS_OK";
    [Token(Token = "0x4006ED2")]
    public const string TXT_ID_SUFFIX_PROGRESS_NG = "_PROGRESS_NG";
    [Token(Token = "0x4006ED3")]
    public const int FAILED_MISSION_VALUE = 1;
    [Token(Token = "0x4006ED4")]
    [FieldOffset(Offset = "0x8")]
    public string item;
    [Token(Token = "0x4006ED5")]
    [FieldOffset(Offset = "0xC")]
    public int itemNum;
    [Token(Token = "0x4006ED6")]
    [FieldOffset(Offset = "0x10")]
    public RewardType itemType;
    [Token(Token = "0x4006ED7")]
    [FieldOffset(Offset = "0x14")]
    public EMissionType Type;
    [Token(Token = "0x4006ED8")]
    [FieldOffset(Offset = "0x18")]
    public string TypeParam;
    [Token(Token = "0x4006ED9")]
    [FieldOffset(Offset = "0x1C")]
    public bool IsTakeoverProgress;
    [Token(Token = "0x4006EDA")]
    [FieldOffset(Offset = "0x0")]
    private static Dictionary<EMissionType, QuestMissionTypeAttribute> m_QuestMissionTypeDic;
    [Token(Token = "0x4006EDB")]
    [FieldOffset(Offset = "0x4")]
    private static Dictionary<EMissionType, TowerQuestMissionTypeAttribute> m_TowerQuestMissionTypeDic;

    [Token(Token = "0x600741F")]
    [Address(RVA = "0x380800", Offset = "0x37F600", VA = "0x10380800")]
    public bool IsMissionTypeExecSkill() => new bool();

    [Token(Token = "0x6007420")]
    [Address(RVA = "0x380820", Offset = "0x37F620", VA = "0x10380820")]
    public bool IsProgressMission() => new bool();

    [Token(Token = "0x6007421")]
    [Address(RVA = "0x3807B0", Offset = "0x37F5B0", VA = "0x103807B0")]
    public bool IsMissionTypeAllowLose() => new bool();

    [Token(Token = "0x6007422")]
    [Address(RVA = "0x3801A0", Offset = "0x37EFA0", VA = "0x103801A0")]
    public bool CheckHomeMissionValueAchievable(int missions_val) => new bool();

    [Token(Token = "0x6007423")]
    [Address(RVA = "0x3801D0", Offset = "0x37EFD0", VA = "0x103801D0")]
    public bool CheckMissionValueAchievable(int missions_val) => new bool();

    [Token(Token = "0x6007424")]
    [Address(RVA = "0x380980", Offset = "0x37F780", VA = "0x10380980")]
    public bool TryGetIntValue(ref int value) => new bool();

    [Token(Token = "0x6007425")]
    [Address(RVA = "0x3809A0", Offset = "0x37F7A0", VA = "0x103809A0")]
    public bool TryGetKeyValue(ref string key, ref int value) => new bool();

    [Token(Token = "0x6007426")]
    [Address(RVA = "0x3808D0", Offset = "0x37F6D0", VA = "0x103808D0")]
    public bool TryGetArray(ref string[] values) => new bool();

    [Token(Token = "0x6007427")]
    [Address(RVA = "0x380550", Offset = "0x37F350", VA = "0x10380550")]
    private QuestMissionTypeAttribute GetQuestMissionTypeAttribute(EMissionType missionType)
    {
      return (QuestMissionTypeAttribute) null;
    }

    [Token(Token = "0x6007428")]
    [Address(RVA = "0x380680", Offset = "0x37F480", VA = "0x10380680")]
    private TowerQuestMissionTypeAttribute GetTowerQuestMissionTypeAttribute(
      EMissionType missionType)
    {
      return (TowerQuestMissionTypeAttribute) null;
    }

    [Token(Token = "0x6007429")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestBonusObjective()
    {
    }

    [Token(Token = "0x600742A")]
    [Address(RVA = "0x380AA0", Offset = "0x37F8A0", VA = "0x10380AA0")]
    static QuestBonusObjective()
    {
    }
  }
}
