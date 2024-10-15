// Decompiled with JetBrains decompiler
// Type: SRPG.TowerQuestMissionTypeAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C4D")]
  public class TowerQuestMissionTypeAttribute : Attribute
  {
    [Token(Token = "0x4006ECE")]
    [FieldOffset(Offset = "0x8")]
    private QuestMissionProgressJudgeType m_ProgressJudgeType;

    [Token(Token = "0x17000E99")]
    public QuestMissionProgressJudgeType ProgressJudgeType
    {
      [Token(Token = "0x600741D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new QuestMissionProgressJudgeType();
      }
    }

    [Token(Token = "0x600741E")]
    [Address(RVA = "0x2B6E90", Offset = "0x2B5C90", VA = "0x102B6E90")]
    public TowerQuestMissionTypeAttribute(QuestMissionProgressJudgeType progressJudgeType)
    {
    }
  }
}
