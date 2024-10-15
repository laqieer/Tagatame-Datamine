// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisChapterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B07")]
  public class GenesisChapterParam
  {
    [Token(Token = "0x400670A")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400670B")]
    [FieldOffset(Offset = "0xC")]
    private int mPriority;
    [Token(Token = "0x400670C")]
    [FieldOffset(Offset = "0x10")]
    private string mAreaId;
    [Token(Token = "0x400670D")]
    [FieldOffset(Offset = "0x14")]
    private string mName;
    [Token(Token = "0x400670E")]
    [FieldOffset(Offset = "0x18")]
    private string mBoxIname;
    [Token(Token = "0x400670F")]
    [FieldOffset(Offset = "0x1C")]
    private int mChapterUiIndex;
    [Token(Token = "0x4006710")]
    [FieldOffset(Offset = "0x20")]
    private string mChapterBanner;
    [Token(Token = "0x4006711")]
    [FieldOffset(Offset = "0x24")]
    private string mChapterDetailUrl;
    [Token(Token = "0x4006712")]
    [FieldOffset(Offset = "0x28")]
    private string mBossHintUrl;
    [Token(Token = "0x4006713")]
    [FieldOffset(Offset = "0x2C")]
    private GenesisChapterModeInfoParam[] mModeInfo;

    [Token(Token = "0x17000CF2")]
    public string Iname
    {
      [Token(Token = "0x6006F8C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CF3")]
    public int Priority
    {
      [Token(Token = "0x6006F8D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CF4")]
    public string AreaId
    {
      [Token(Token = "0x6006F8E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CF5")]
    public string Name
    {
      [Token(Token = "0x6006F8F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CF6")]
    public string BoxIname
    {
      [Token(Token = "0x6006F90"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CF7")]
    public int ChapterUiIndex
    {
      [Token(Token = "0x6006F91"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000CF8")]
    public string ChapterBanner
    {
      [Token(Token = "0x6006F92"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CF9")]
    public string ChapterDetailUrl
    {
      [Token(Token = "0x6006F93"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CFA")]
    public string BossHintUrl
    {
      [Token(Token = "0x6006F94"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CFB")]
    public List<GenesisChapterModeInfoParam> ModeInfoList
    {
      [Token(Token = "0x6006F95"), Address(RVA = "0x36BBA0", Offset = "0x36A9A0", VA = "0x1036BBA0")] get
      {
        return (List<GenesisChapterModeInfoParam>) null;
      }
    }

    [Token(Token = "0x6006F96")]
    [Address(RVA = "0x36B930", Offset = "0x36A730", VA = "0x1036B930")]
    private List<QuestParam> GetQuestTypeList(
      QuestTypes quest_type,
      string chapter_id,
      QuestDifficulties difficulty = QuestDifficulties.MAX,
      bool is_no_check_unlock = false)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x6006F97")]
    [Address(RVA = "0x36B5B0", Offset = "0x36A3B0", VA = "0x1036B5B0")]
    public void Deserialize(JSON_GenesisChapterParam json)
    {
    }

    [Token(Token = "0x6006F98")]
    [Address(RVA = "0x36B910", Offset = "0x36A710", VA = "0x1036B910")]
    public List<QuestParam> GetQuestList(QuestDifficulties difficulty = QuestDifficulties.MAX, bool is_no_check_unlock = false)
    {
      return (List<QuestParam>) null;
    }

    [Token(Token = "0x6006F99")]
    [Address(RVA = "0x36B780", Offset = "0x36A580", VA = "0x1036B780")]
    public QuestParam GetBossQuest(QuestDifficulties difficulty, bool is_no_check_unlock = false)
    {
      return (QuestParam) null;
    }

    [Token(Token = "0x6006F9A")]
    [Address(RVA = "0x36B860", Offset = "0x36A660", VA = "0x1036B860")]
    public GenesisChapterModeInfoParam GetModeInfo(QuestDifficulties difficulty)
    {
      return (GenesisChapterModeInfoParam) null;
    }

    [Token(Token = "0x6006F9B")]
    [Address(RVA = "0x36B7F0", Offset = "0x36A5F0", VA = "0x1036B7F0")]
    public int GetMaxStarNum(List<QuestParam> quest_list) => new int();

    [Token(Token = "0x6006F9C")]
    [Address(RVA = "0x36B890", Offset = "0x36A690", VA = "0x1036B890")]
    public int GetNowStarNum(List<QuestParam> quest_list) => new int();

    [Token(Token = "0x6006F9D")]
    [Address(RVA = "0x31A2C0", Offset = "0x3190C0", VA = "0x1031A2C0")]
    public int GetMaxStarNum(QuestParam quest_param) => new int();

    [Token(Token = "0x6006F9E")]
    [Address(RVA = "0x31A380", Offset = "0x319180", VA = "0x1031A380")]
    public int GetNowStarNum(QuestParam quest_param) => new int();

    [Token(Token = "0x6006F9F")]
    [Address(RVA = "0x36BAC0", Offset = "0x36A8C0", VA = "0x1036BAC0")]
    public bool IsBossLiberation(QuestDifficulties difficulty) => new bool();

    [Token(Token = "0x6006FA0")]
    [Address(RVA = "0x36BA90", Offset = "0x36A890", VA = "0x1036BA90")]
    public bool IsBossCondQuests(QuestDifficulties difficulty) => new bool();

    [Token(Token = "0x6006FA1")]
    [Address(RVA = "0x36B3B0", Offset = "0x36A1B0", VA = "0x1036B3B0")]
    public static void Deserialize(
      ref List<GenesisChapterParam> list,
      JSON_GenesisChapterParam[] json)
    {
    }

    [Token(Token = "0x6006FA2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GenesisChapterParam()
    {
    }
  }
}
