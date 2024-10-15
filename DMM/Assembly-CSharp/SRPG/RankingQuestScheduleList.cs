// Decompiled with JetBrains decompiler
// Type: SRPG.RankingQuestScheduleList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C92")]
  public class RankingQuestScheduleList
  {
    [Token(Token = "0x400703D")]
    [FieldOffset(Offset = "0x8")]
    public RankingQuestScheduleParam m_RankingQuestScheduleParam;
    [Token(Token = "0x400703E")]
    [FieldOffset(Offset = "0xC")]
    public List<RankingQuestParam> m_RankingQuestParams;

    [Token(Token = "0x60075B6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RankingQuestScheduleList()
    {
    }
  }
}
