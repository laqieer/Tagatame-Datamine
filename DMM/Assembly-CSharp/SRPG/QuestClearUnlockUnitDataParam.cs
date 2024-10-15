// Decompiled with JetBrains decompiler
// Type: SRPG.QuestClearUnlockUnitDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C34")]
  [MessagePackObject(true)]
  public class QuestClearUnlockUnitDataParam
  {
    [Token(Token = "0x4006D75")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006D76")]
    [FieldOffset(Offset = "0xC")]
    public string uid;
    [Token(Token = "0x4006D77")]
    [FieldOffset(Offset = "0x10")]
    public bool add;
    [Token(Token = "0x4006D78")]
    [FieldOffset(Offset = "0x14")]
    public QuestClearUnlockUnitDataParam.EUnlockTypes type;
    [Token(Token = "0x4006D79")]
    [FieldOffset(Offset = "0x18")]
    public string new_id;
    [Token(Token = "0x4006D7A")]
    [FieldOffset(Offset = "0x1C")]
    public string old_id;
    [Token(Token = "0x4006D7B")]
    [FieldOffset(Offset = "0x20")]
    public string parent_id;
    [Token(Token = "0x4006D7C")]
    [FieldOffset(Offset = "0x24")]
    public int ulv;
    [Token(Token = "0x4006D7D")]
    [FieldOffset(Offset = "0x28")]
    public string aid;
    [Token(Token = "0x4006D7E")]
    [FieldOffset(Offset = "0x2C")]
    public int alv;
    [Token(Token = "0x4006D7F")]
    [FieldOffset(Offset = "0x30")]
    public string[] qids;
    [Token(Token = "0x4006D80")]
    [FieldOffset(Offset = "0x34")]
    public bool qcnd;

    [Token(Token = "0x60073FF")]
    [Address(RVA = "0x382590", Offset = "0x381390", VA = "0x10382590")]
    public string GetUnitLevelCond() => (string) null;

    [Token(Token = "0x6007400")]
    [Address(RVA = "0x381820", Offset = "0x380620", VA = "0x10381820")]
    public string GetAbilityLevelCond() => (string) null;

    [Token(Token = "0x6007401")]
    [Address(RVA = "0x3819C0", Offset = "0x3807C0", VA = "0x103819C0")]
    public string GetClearQuestCond() => (string) null;

    [Token(Token = "0x6007402")]
    [Address(RVA = "0x382800", Offset = "0x381600", VA = "0x10382800")]
    public bool IsSameNeedClearQuestCond(QuestClearUnlockUnitDataParam target) => new bool();

    [Token(Token = "0x6007403")]
    [Address(RVA = "0x381720", Offset = "0x380520", VA = "0x10381720")]
    public void Deserialize(JSON_QuestClearUnlockUnitDataParam json)
    {
    }

    [Token(Token = "0x6007404")]
    [Address(RVA = "0x382690", Offset = "0x381490", VA = "0x10382690")]
    public string GetUnlockTypeText() => (string) null;

    [Token(Token = "0x6007405")]
    [Address(RVA = "0x382410", Offset = "0x381210", VA = "0x10382410")]
    public string GetRewriteName() => (string) null;

    [Token(Token = "0x6007406")]
    [Address(RVA = "0x381B10", Offset = "0x380910", VA = "0x10381B10")]
    public string GetCondText(UnitParam unit) => (string) null;

    [Token(Token = "0x6007407")]
    [Address(RVA = "0x3827F0", Offset = "0x3815F0", VA = "0x103827F0")]
    public bool IsMasterAbility() => new bool();

    [Token(Token = "0x6007408")]
    [Address(RVA = "0x382B40", Offset = "0x381940", VA = "0x10382B40")]
    public QuestClearUnlockUnitDataParam()
    {
    }

    [Token(Token = "0x2001C35")]
    public enum EUnlockTypes
    {
      [Token(Token = "0x4006D82")] None = -1, // 0xFFFFFFFF
      [Token(Token = "0x4006D83")] Job = 0,
      [Token(Token = "0x4006D84")] Skill = 1,
      [Token(Token = "0x4006D85")] Ability = 2,
      [Token(Token = "0x4006D86")] LeaderSkill = 3,
      [Token(Token = "0x4006D87")] MasterAbility = 4,
      [Token(Token = "0x4006D88")] CollaboAbility = 5,
    }
  }
}
