// Decompiled with JetBrains decompiler
// Type: QuestLobbyNews
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200027C")]
public class QuestLobbyNews
{
  [Token(Token = "0x4000A70")]
  private const string TEXT_CATEGORY_NAME_BASE = "sys.QUEST_LOBBY_NEWS_CATEGORY_NAME_";
  [Token(Token = "0x4000A71")]
  private const string TEXT_SHOW_TYPE_BASE = "sys.QUEST_LOBBY_NEWS_TYPE_";
  [Token(Token = "0x4000A72")]
  [FieldOffset(Offset = "0x8")]
  private QuestLobbyNews.QuestLobbyCategory mCategory;
  [Token(Token = "0x4000A73")]
  [FieldOffset(Offset = "0x10")]
  private DateTime mBeginAt;
  [Token(Token = "0x4000A74")]
  [FieldOffset(Offset = "0x18")]
  private DateTime mEndAt;
  [Token(Token = "0x4000A75")]
  [FieldOffset(Offset = "0x20")]
  private int mShowType;

  [Token(Token = "0x6000D5B")]
  [Address(RVA = "0x11D6240", Offset = "0x11D5040", VA = "0x111D6240")]
  public bool Deserialize(JSON_QuestLobbyNewsParam json) => new bool();

  [Token(Token = "0x6000D5C")]
  [Address(RVA = "0x11D6500", Offset = "0x11D5300", VA = "0x111D6500")]
  public bool isShow() => new bool();

  [Token(Token = "0x6000D5D")]
  [Address(RVA = "0x11D6390", Offset = "0x11D5190", VA = "0x111D6390")]
  public string GetShowText() => (string) null;

  [Token(Token = "0x6000D5E")]
  [Address(RVA = "0x11D62C0", Offset = "0x11D50C0", VA = "0x111D62C0")]
  public static QuestLobbyNews FindQuestLobbyNews(QuestLobbyNews.QuestLobbyCategory target)
  {
    return (QuestLobbyNews) null;
  }

  [Token(Token = "0x6000D5F")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public QuestLobbyNews()
  {
  }

  [Token(Token = "0x200027D")]
  public enum QuestLobbyCategory
  {
    [Token(Token = "0x4000A77")] storyRoot,
    [Token(Token = "0x4000A78")] eventRoot,
    [Token(Token = "0x4000A79")] challengeRoot,
    [Token(Token = "0x4000A7A")] multi,
    [Token(Token = "0x4000A7B")] mainStory,
    [Token(Token = "0x4000A7C")] seiseki,
    [Token(Token = "0x4000A7D")] babel,
    [Token(Token = "0x4000A7E")] character,
    [Token(Token = "0x4000A7F")] eventQuest,
    [Token(Token = "0x4000A80")] dailyAndEnhance,
    [Token(Token = "0x4000A81")] key,
    [Token(Token = "0x4000A82")] tower,
    [Token(Token = "0x4000A83")] ordeal,
    [Token(Token = "0x4000A84")] arena,
    [Token(Token = "0x4000A85")] draft,
    [Token(Token = "0x4000A86")] archive,
    [Token(Token = "0x4000A87")] genesis,
    [Token(Token = "0x4000A88")] advance,
    [Token(Token = "0x4000A89")] combatpower,
    [Token(Token = "0x4000A8A")] DragonGod,
    [Token(Token = "0x4000A8B")] LeagueMatch,
  }
}
