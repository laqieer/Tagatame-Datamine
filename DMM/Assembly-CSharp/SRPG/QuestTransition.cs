// Decompiled with JetBrains decompiler
// Type: SRPG.QuestTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010C7")]
  public class QuestTransition
  {
    [Token(Token = "0x600470D")]
    [Address(RVA = "0x11E76D0", Offset = "0x11E64D0", VA = "0x111E76D0")]
    public static void TransitioAndTakeAction(
      string quest_id,
      Action callQuest,
      Action callEvent,
      Action callMulti,
      Action callBeginner,
      Action callCharaQuest,
      Action callTower,
      Action callGenesis,
      Action callAdvance,
      Action callDragonGod,
      Action callPointEvent)
    {
    }

    [Token(Token = "0x600470E")]
    [Address(RVA = "0x11E73D0", Offset = "0x11E61D0", VA = "0x111E73D0")]
    private static void NotOpneQuest()
    {
    }

    [Token(Token = "0x600470F")]
    [Address(RVA = "0x11E72E0", Offset = "0x11E60E0", VA = "0x111E72E0")]
    private static void GotoNotOpneEventQuestArchive(Action callArchiveNotAvaailable)
    {
    }

    [Token(Token = "0x6004710")]
    [Address(RVA = "0x11E7530", Offset = "0x11E6330", VA = "0x111E7530")]
    public static void SetupGotoArchive(string quest_iname)
    {
    }

    [Token(Token = "0x6004711")]
    [Address(RVA = "0x11E75B0", Offset = "0x11E63B0", VA = "0x111E75B0")]
    public static void SetupGotoArchive(QuestParam quest_param, string chapter_iname)
    {
    }

    [Token(Token = "0x6004712")]
    [Address(RVA = "0x11E7430", Offset = "0x11E6230", VA = "0x111E7430")]
    public static void SetupGotoArchiveTop()
    {
    }

    [Token(Token = "0x6004713")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public QuestTransition()
    {
    }
  }
}
