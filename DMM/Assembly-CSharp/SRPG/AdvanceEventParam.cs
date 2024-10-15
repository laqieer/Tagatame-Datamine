// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceEventParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001959")]
  public class AdvanceEventParam
  {
    [Token(Token = "0x4005C42")]
    private const long TIME_MIN = 0;
    [Token(Token = "0x4005C43")]
    private const long TIME_MAX = 2147483647;
    [Token(Token = "0x4005C44")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4005C45")]
    [FieldOffset(Offset = "0xC")]
    private eTransType mTransType;
    [Token(Token = "0x4005C46")]
    [FieldOffset(Offset = "0x10")]
    private int mPriority;
    [Token(Token = "0x4005C47")]
    [FieldOffset(Offset = "0x14")]
    private string mAreaId;
    [Token(Token = "0x4005C48")]
    [FieldOffset(Offset = "0x18")]
    private string mName;
    [Token(Token = "0x4005C49")]
    [FieldOffset(Offset = "0x1C")]
    private string mBoxIname;
    [Token(Token = "0x4005C4A")]
    [FieldOffset(Offset = "0x20")]
    private int mEventUiIndex;
    [Token(Token = "0x4005C4B")]
    [FieldOffset(Offset = "0x24")]
    private string mEventBanner;
    [Token(Token = "0x4005C4C")]
    [FieldOffset(Offset = "0x28")]
    private string mEventDetailUrl;
    [Token(Token = "0x4005C4D")]
    [FieldOffset(Offset = "0x2C")]
    private string mBossHintUrl;
    [Token(Token = "0x4005C4E")]
    [FieldOffset(Offset = "0x30")]
    private AdvanceEventModeInfoParam[] mModeInfo;
    [Token(Token = "0x4005C4F")]
    [FieldOffset(Offset = "0x34")]
    private ChapterParam mChapterParam;

    [Token(Token = "0x17000A7A")]
    public string Iname
    {
      [Token(Token = "0x6006750"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A7B")]
    public eTransType TransType
    {
      [Token(Token = "0x6006751"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new eTransType();
      }
    }

    [Token(Token = "0x17000A7C")]
    public int Priority
    {
      [Token(Token = "0x6006752"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A7D")]
    public string AreaId
    {
      [Token(Token = "0x6006753"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A7E")]
    public string Name
    {
      [Token(Token = "0x6006754"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A7F")]
    public string BoxIname
    {
      [Token(Token = "0x6006755"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A80")]
    public int EventUiIndex
    {
      [Token(Token = "0x6006756"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000A81")]
    public string EventBanner
    {
      [Token(Token = "0x6006757"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A82")]
    public string EventDetailUrl
    {
      [Token(Token = "0x6006758"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A83")]
    public string BossHintUrl
    {
      [Token(Token = "0x6006759"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A84")]
    public ChapterParam ChapterParam
    {
      [Token(Token = "0x600675A"), Address(RVA = "0x31A8F0", Offset = "0x3196F0", VA = "0x1031A8F0")] get
      {
        return (ChapterParam) null;
      }
    }

    [Token(Token = "0x600675B")]
    [Address(RVA = "0x319DF0", Offset = "0x318BF0", VA = "0x10319DF0")]
    public void Deserialize(JSON_AdvanceEventParam json)
    {
    }

    [Token(Token = "0x600675C")]
    [Address(RVA = "0x31A460", Offset = "0x319260", VA = "0x1031A460")]
    public List<QuestParam> GetQuestList(QuestDifficulties difficulty = QuestDifficulties.MAX, bool is_no_check_unlock = false)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x600675D")]
    [Address(RVA = "0x31A170", Offset = "0x318F70", VA = "0x1031A170")]
    public QuestParam GetBossQuest(QuestDifficulties difficulty, bool is_no_check_unlock = false)
    {
      return (QuestParam) null;
    }

    [Token(Token = "0x600675E")]
    [Address(RVA = "0x31A350", Offset = "0x319150", VA = "0x1031A350")]
    public AdvanceEventModeInfoParam GetModeInfo(QuestDifficulties difficulty)
    {
      return (AdvanceEventModeInfoParam) null;
    }

    [Token(Token = "0x600675F")]
    [Address(RVA = "0x31A2E0", Offset = "0x3190E0", VA = "0x1031A2E0")]
    public int GetMaxStarNum(List<QuestParam> quest_list) => new int();

    [Token(Token = "0x6006760")]
    [Address(RVA = "0x31A3E0", Offset = "0x3191E0", VA = "0x1031A3E0")]
    public int GetNowStarNum(List<QuestParam> quest_list) => new int();

    [Token(Token = "0x6006761")]
    [Address(RVA = "0x31A2C0", Offset = "0x3190C0", VA = "0x1031A2C0")]
    public int GetMaxStarNum(QuestParam quest_param) => new int();

    [Token(Token = "0x6006762")]
    [Address(RVA = "0x31A380", Offset = "0x319180", VA = "0x1031A380")]
    public int GetNowStarNum(QuestParam quest_param) => new int();

    [Token(Token = "0x6006763")]
    [Address(RVA = "0x31A700", Offset = "0x319500", VA = "0x1031A700")]
    public bool IsBossLiberation(QuestDifficulties difficulty) => new bool();

    [Token(Token = "0x6006764")]
    [Address(RVA = "0x31A6D0", Offset = "0x3194D0", VA = "0x1031A6D0")]
    public bool IsBossCondQuests(QuestDifficulties difficulty) => new bool();

    [Token(Token = "0x6006765")]
    [Address(RVA = "0x319BF0", Offset = "0x3189F0", VA = "0x10319BF0")]
    public static void Deserialize(ref List<AdvanceEventParam> list, JSON_AdvanceEventParam[] json)
    {
    }

    [Token(Token = "0x6006766")]
    [Address(RVA = "0x31A480", Offset = "0x319280", VA = "0x1031A480")]
    public static List<QuestParam> GetQuestTypeList(
      QuestTypes quest_type,
      string chapter_id,
      QuestDifficulties difficulty = QuestDifficulties.MAX,
      bool is_no_check_unlock = false)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x6006767")]
    [Address(RVA = "0x31A7E0", Offset = "0x3195E0", VA = "0x1031A7E0")]
    public static bool IsWithinPeriod(string chapter_id = null) => new bool();

    [Token(Token = "0x6006768")]
    [Address(RVA = "0x319FE0", Offset = "0x318DE0", VA = "0x10319FE0")]
    private static bool ExistsAvailableEventFromAll() => new bool();

    [Token(Token = "0x6006769")]
    [Address(RVA = "0x31A5F0", Offset = "0x3193F0", VA = "0x1031A5F0")]
    public static DateTime GetStartDateTime(string chapter_id) => new DateTime();

    [Token(Token = "0x600676A")]
    [Address(RVA = "0x31A1E0", Offset = "0x318FE0", VA = "0x1031A1E0")]
    public static DateTime GetEndDateTime(string chapter_id) => new DateTime();

    [Token(Token = "0x600676B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdvanceEventParam()
    {
    }
  }
}
