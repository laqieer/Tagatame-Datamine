// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B84")]
  [FlowNode.Pin(2049, "ポイントクエストへ移動", FlowNode.PinTypes.Output, 2049)]
  [FlowNode.Pin(2028, "イベントショップへ移動", FlowNode.PinTypes.Output, 2028)]
  [FlowNode.Pin(2027, "限定ショップへ移動", FlowNode.PinTypes.Output, 2027)]
  [FlowNode.Pin(2026, "塔クエスト選択へ移動", FlowNode.PinTypes.Output, 2026)]
  [FlowNode.Pin(2052, "PvEへ移動", FlowNode.PinTypes.Output, 2052)]
  [FlowNode.Pin(3000, "通常一括受け取り", FlowNode.PinTypes.Output, 3000)]
  [FlowNode.Pin(2025, "ユニット選択へ移動", FlowNode.PinTypes.Output, 2025)]
  [FlowNode.Pin(2021, "武具の店へ移動", FlowNode.PinTypes.Output, 2021)]
  [AddComponentMenu("UI/TrophyWindow")]
  [FlowNode.Pin(2013, "アンナの店へ移動", FlowNode.PinTypes.Output, 2013)]
  [FlowNode.Pin(2008, "FgGID画面へ移動", FlowNode.PinTypes.Output, 2008)]
  [FlowNode.Pin(2007, "アリーナへ移動", FlowNode.PinTypes.Output, 2007)]
  [FlowNode.Pin(2006, "イベントクエスト選択へ移動", FlowNode.PinTypes.Output, 2006)]
  [FlowNode.Pin(2005, "マルチプレイへ移動", FlowNode.PinTypes.Output, 2005)]
  [FlowNode.Pin(2004, "装備強化画面へ移動", FlowNode.PinTypes.Output, 2004)]
  [FlowNode.Pin(2003, "ゴールド購入画面へ移動", FlowNode.PinTypes.Output, 2003)]
  [FlowNode.Pin(2045, "ポートショップへ移動", FlowNode.PinTypes.Output, 2045)]
  [FlowNode.Pin(2029, "レビューへ移動", FlowNode.PinTypes.Output, 2029)]
  [FlowNode.Pin(2030, "対戦へ移動", FlowNode.PinTypes.Output, 2030)]
  [FlowNode.Pin(2031, "マルチ塔へ移動", FlowNode.PinTypes.Output, 2031)]
  [FlowNode.Pin(2047, "派遣クエストへ移動", FlowNode.PinTypes.Output, 2047)]
  [FlowNode.Pin(2046, "新闘技場へ移動", FlowNode.PinTypes.Output, 2046)]
  [FlowNode.Pin(2044, "ポートレイドへ移動", FlowNode.PinTypes.Output, 2044)]
  [FlowNode.Pin(2043, "レイドへ移動", FlowNode.PinTypes.Output, 2043)]
  [FlowNode.Pin(2041, "新イベントへ移動", FlowNode.PinTypes.Output, 2041)]
  [FlowNode.Pin(2040, "創世編へ移動", FlowNode.PinTypes.Output, 2040)]
  [FlowNode.Pin(2039, "フレンド画面を開く", FlowNode.PinTypes.Output, 2039)]
  [FlowNode.Pin(2048, "外部リンクへ移動", FlowNode.PinTypes.Output, 2048)]
  [FlowNode.Pin(2038, "お知らせを開く", FlowNode.PinTypes.Output, 2038)]
  [FlowNode.Pin(2050, "ポイントクエストTOPへ移動", FlowNode.PinTypes.Output, 2050)]
  [FlowNode.Pin(2051, "ワールドレイドへ移動", FlowNode.PinTypes.Output, 2051)]
  [FlowNode.Pin(2036, "異層圏カルマへ移動", FlowNode.PinTypes.Output, 2036)]
  [FlowNode.Pin(2035, "真理念装へ移動", FlowNode.PinTypes.Output, 2035)]
  [FlowNode.Pin(2034, "初心者の館へ移動", FlowNode.PinTypes.Output, 2034)]
  [FlowNode.Pin(2033, "初心者クエストへ移動", FlowNode.PinTypes.Output, 2033)]
  [FlowNode.Pin(2032, "キャラクエストへ移動", FlowNode.PinTypes.Output, 2032)]
  [FlowNode.Pin(2037, "ホーム画面へ移動", FlowNode.PinTypes.Output, 2037)]
  [FlowNode.Pin(2042, "アルケミィポートへ移動", FlowNode.PinTypes.Output, 2042)]
  [FlowNode.Pin(2020, "魂の交換所へ移動", FlowNode.PinTypes.Output, 2020)]
  [FlowNode.Pin(2001, "ガチャへ移動", FlowNode.PinTypes.Output, 2001)]
  [FlowNode.Pin(3, "更新(ポート)", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(5, "更新(復刻)", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(1002, "ポートデイリー", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1001, "レコード", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "デイリー", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(4, "初期化(復刻)", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(2, "初期化(ポート)", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "報酬を一括受け取り", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(2002, "クエスト選択へ移動", FlowNode.PinTypes.Output, 2002)]
  [FlowNode.Pin(2000, "報酬を受け取り", FlowNode.PinTypes.Output, 2000)]
  [FlowNode.Pin(11, "報酬を一括受け取り(ポート)", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(21, "一括受取EXP含むか設定更新", FlowNode.PinTypes.Input, 21)]
  public class TrophyWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D54C")]
    public const int PIN_INIT = 0;
    [Token(Token = "0x400D54D")]
    public const int PIN_REFRESH = 1;
    [Token(Token = "0x400D54E")]
    public const int PIN_INIT_GUILD_DAILY = 2;
    [Token(Token = "0x400D54F")]
    public const int PIN_REFRESH_GUILD = 3;
    [Token(Token = "0x400D550")]
    public const int PIN_INIT_QUEST_ARCHIVE = 4;
    [Token(Token = "0x400D551")]
    public const int PIN_REFRESH_QUEST_ARCHIVE = 5;
    [Token(Token = "0x400D552")]
    public const int PIN_GETALL = 10;
    [Token(Token = "0x400D553")]
    public const int PIN_GETALL_GUILD = 11;
    [Token(Token = "0x400D554")]
    public const int PIN_COLLECTIVE_RECEIPT = 21;
    [Token(Token = "0x400D555")]
    public const int PIN_DAILY = 1000;
    [Token(Token = "0x400D556")]
    public const int PIN_RECORD = 1001;
    [Token(Token = "0x400D557")]
    public const int PIN_GUILD_DAILY = 1002;
    [Token(Token = "0x400D558")]
    public const int PIN_REWARD_CHECK = 2000;
    [Token(Token = "0x400D559")]
    public const int PIN_GOTO_GACHA = 2001;
    [Token(Token = "0x400D55A")]
    public const int PIN_GOTO_QUEST = 2002;
    [Token(Token = "0x400D55B")]
    public const int PIN_GOTO_BUYGOLD = 2003;
    [Token(Token = "0x400D55C")]
    public const int PIN_GOTO_SOUBI = 2004;
    [Token(Token = "0x400D55D")]
    public const int PIN_GOTO_MULTI = 2005;
    [Token(Token = "0x400D55E")]
    public const int PIN_GOTO_EVENT = 2006;
    [Token(Token = "0x400D55F")]
    public const int PIN_GOTO_ARENA = 2007;
    [Token(Token = "0x400D560")]
    public const int PIN_GOTO_FGGID = 2008;
    [Token(Token = "0x400D561")]
    public const int PIN_GOTO_SHOP_NORMAL = 2013;
    [Token(Token = "0x400D562")]
    public const int PIN_GOTO_SHOP_KAKERA = 2020;
    [Token(Token = "0x400D563")]
    public const int PIN_GOTO_SHOP_ARTIFACT = 2021;
    [Token(Token = "0x400D564")]
    public const int PIN_GOTO_UNIT = 2025;
    [Token(Token = "0x400D565")]
    public const int PIN_GOTO_TOWER = 2026;
    [Token(Token = "0x400D566")]
    public const int PIN_GOTO_SHOP_LIMITE = 2027;
    [Token(Token = "0x400D567")]
    public const int PIN_GOTO_SHOP_EVENT = 2028;
    [Token(Token = "0x400D568")]
    public const int PIN_GOTO_REVIEW = 2029;
    [Token(Token = "0x400D569")]
    public const int PIN_GOTO_VERSUS = 2030;
    [Token(Token = "0x400D56A")]
    public const int PIN_GOTO_MULTITOWER = 2031;
    [Token(Token = "0x400D56B")]
    public const int PIN_GOTO_CHARAQUEST = 2032;
    [Token(Token = "0x400D56C")]
    public const int PIN_GOTO_EVENT_BEGINEER = 2033;
    [Token(Token = "0x400D56D")]
    public const int PIN_GOTO_BEGINNER_TOP = 2034;
    [Token(Token = "0x400D56E")]
    public const int PIN_GOTO_CONCEPT_CARD = 2035;
    [Token(Token = "0x400D56F")]
    public const int PIN_GOTO_QUEST_ORDEAL = 2036;
    [Token(Token = "0x400D570")]
    public const int PIN_GOTO_HOME = 2037;
    [Token(Token = "0x400D571")]
    public const int PIN_VIEW_NEWS = 2038;
    [Token(Token = "0x400D572")]
    public const int PIN_GOTO_FRIEND = 2039;
    [Token(Token = "0x400D573")]
    public const int PIN_GOTO_GENESIS = 2040;
    [Token(Token = "0x400D574")]
    public const int PIN_GOTO_ADVANCE = 2041;
    [Token(Token = "0x400D575")]
    public const int PIN_GOTO_GUILD = 2042;
    [Token(Token = "0x400D576")]
    public const int PIN_GOTO_RAIDBOSS = 2043;
    [Token(Token = "0x400D577")]
    public const int PIN_GOTO_GUILDRAIDBOSS = 2044;
    [Token(Token = "0x400D578")]
    public const int PIN_GOTO_SHOP_PORT = 2045;
    [Token(Token = "0x400D579")]
    public const int PIN_GOTO_DUEL = 2046;
    [Token(Token = "0x400D57A")]
    public const int PIN_GOTO_ADVENTURE = 2047;
    [Token(Token = "0x400D57B")]
    public const int PIN_GOTO_EXTERNAL_LINK = 2048;
    [Token(Token = "0x400D57C")]
    public const int PIN_GOTO_POINTQUEST = 2049;
    [Token(Token = "0x400D57D")]
    public const int PIN_GOTO_POINTQUEST_TOP = 2050;
    [Token(Token = "0x400D57E")]
    public const int PIN_GOTO_WORLDRAID = 2051;
    [Token(Token = "0x400D57F")]
    public const int PIN_GOTO_LEAGUEMATCH = 2052;
    [Token(Token = "0x400D580")]
    public const int PIN_OUTPUT_GETALL = 3000;
    [Token(Token = "0x400D581")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject daily_badge_obj;
    [Token(Token = "0x400D582")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject record_badge_obj;
    [Token(Token = "0x400D583")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private List<GameObject> badgeObjList;
    [Token(Token = "0x400D584")]
    [FieldOffset(Offset = "0x18")]
    public Toggle[] TrophyTab;
    [Token(Token = "0x400D585")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject DailyTrophyObj;
    [Token(Token = "0x400D586")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] RecordMissionObjs;
    [Token(Token = "0x400D587")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button BtnDailyCollectiveReceipt;
    [Token(Token = "0x400D588")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button BtnTrophyCollectiveReceipt;
    [Token(Token = "0x400D589")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Toggle ToggleTrophyCollectiveReceiptExp;
    [Token(Token = "0x400D58A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool IsGetAllStarPlus;
    [Token(Token = "0x400D58B")]
    [FieldOffset(Offset = "0x34")]
    private TrophyWindow.DailyIndex SelectedDaily;
    [Token(Token = "0x400D58C")]
    [FieldOffset(Offset = "0x38")]
    private TrophyCategoryData mCategoryData;
    [Token(Token = "0x400D58D")]
    [FieldOffset(Offset = "0x3C")]
    private Dictionary<TrophyCategorys, List<TrophyCategoryData>> trophy_record_data;
    [Token(Token = "0x400D58E")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, TrophyCategoryData> trophy_category_data;
    [Token(Token = "0x400D58F")]
    [FieldOffset(Offset = "0x44")]
    private List<TrophyState> trophy_daily_data;
    [Token(Token = "0x400D590")]
    [FieldOffset(Offset = "0x48")]
    private List<TrophyState> tmp_trophy_daily_data;
    [Token(Token = "0x400D591")]
    [FieldOffset(Offset = "0x4C")]
    private List<TrophyState> trophy_ended_data;
    [Token(Token = "0x400D592")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [Header("ポートデイリーミッション用UI")]
    [Space(5f)]
    private GameObject GuildDailyObj;
    [Token(Token = "0x400D593")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Button GuildDailyCollectiveReceiptBtn;
    [Token(Token = "0x400D594")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TrophyList GuildDailyTrophyList;
    [Token(Token = "0x400D595")]
    [FieldOffset(Offset = "0x5C")]
    private List<TrophyState> trophy_guilddaily_data;
    [Token(Token = "0x400D596")]
    [FieldOffset(Offset = "0x60")]
    private List<TrophyState> trophy_guildended_data;
    [Token(Token = "0x400D597")]
    [FieldOffset(Offset = "0x64")]
    private Dictionary<TrophyCategorys, List<TrophyCategoryData>> trophy_guildrecord_data;

    [Token(Token = "0x600C7B0")]
    [Address(RVA = "0x906450", Offset = "0x905250", VA = "0x10906450", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C7B1")]
    [Address(RVA = "0x906910", Offset = "0x905710", VA = "0x10906910")]
    private void GetAllTrophies()
    {
    }

    [Token(Token = "0x600C7B2")]
    [Address(RVA = "0x906C00", Offset = "0x905A00", VA = "0x10906C00")]
    private List<TrophyState> GetCollectiveReceiveData(TrophyCategorys category)
    {
      return (List<TrophyState>) null;
    }

    [Token(Token = "0x600C7B3")]
    [Address(RVA = "0x907650", Offset = "0x906450", VA = "0x10907650")]
    private Dictionary<TrophyCategorys, List<TrophyCategoryData>> GetTrophyDataWithTabs(
      Dictionary<int, TrophyCategoryData> tempCategoryData)
    {
      return (Dictionary<TrophyCategorys, List<TrophyCategoryData>>) null;
    }

    [Token(Token = "0x600C7B4")]
    [Address(RVA = "0x9073D0", Offset = "0x9061D0", VA = "0x109073D0")]
    private Dictionary<int, TrophyCategoryData> GetTempCategoryData(
      TrophyCategoryParam[] tcp,
      TrophyParam[] trp,
      TrophyBase tb)
    {
      return (Dictionary<int, TrophyCategoryData>) null;
    }

    [Token(Token = "0x600C7B5")]
    [Address(RVA = "0x908A30", Offset = "0x907830", VA = "0x10908A30")]
    private bool IsIgnoreCollectiveReceive(TrophyParam trophyParam) => new bool();

    [Token(Token = "0x600C7B6")]
    [Address(RVA = "0x9068F0", Offset = "0x9056F0", VA = "0x109068F0")]
    private void GetAllTrophiesGuild()
    {
    }

    [Token(Token = "0x600C7B7")]
    [Address(RVA = "0x9069B0", Offset = "0x9057B0", VA = "0x109069B0")]
    private void GetAllTrophies(List<TrophyState> trophydatas, bool is_bulk = false)
    {
    }

    [Token(Token = "0x600C7B8")]
    [Address(RVA = "0x90A1F0", Offset = "0x908FF0", VA = "0x1090A1F0")]
    private void SetStarMissionReward(int _starNum, ref RewardData _reward)
    {
    }

    [Token(Token = "0x600C7B9")]
    [Address(RVA = "0x909E10", Offset = "0x908C10", VA = "0x10909E10")]
    private void SetRequestTrophies(
      List<TrophyState> trophy_datas,
      ref List<string> sel_trophy_list,
      ref RewardData reward,
      ref int starNum)
    {
    }

    [Token(Token = "0x600C7BA")]
    [Address(RVA = "0x90A640", Offset = "0x909440", VA = "0x1090A640")]
    public void UpdateTrophyCollectiveReceiptExpSetting()
    {
    }

    [Token(Token = "0x600C7BB")]
    [Address(RVA = "0x5DD920", Offset = "0x5DC720", VA = "0x105DD920")]
    public void ActivateOutputLinks(int pin_id)
    {
    }

    [Token(Token = "0x600C7BC")]
    [Address(RVA = "0x9067E0", Offset = "0x9055E0", VA = "0x109067E0")]
    private void DataClear()
    {
    }

    [Token(Token = "0x600C7BD")]
    [Address(RVA = "0x907B20", Offset = "0x906920", VA = "0x10907B20")]
    private void Initialize(int pinID = 0)
    {
    }

    [Token(Token = "0x600C7BE")]
    [Address(RVA = "0x906FC0", Offset = "0x905DC0", VA = "0x10906FC0")]
    private void GetMissionInfoByQuestArchive()
    {
    }

    [Token(Token = "0x600C7BF")]
    [Address(RVA = "0x9066E0", Offset = "0x9054E0", VA = "0x109066E0")]
    private bool DailyCheck(List<TrophyState> dailydatas) => new bool();

    [Token(Token = "0x600C7C0")]
    [Address(RVA = "0x90A600", Offset = "0x909400", VA = "0x1090A600")]
    private TrophyWindow.TabIndex TrophyCategorysToTabIndex(TrophyCategorys category)
    {
      return new TrophyWindow.TabIndex();
    }

    [Token(Token = "0x600C7C1")]
    [Address(RVA = "0x90A540", Offset = "0x909340", VA = "0x1090A540")]
    private void SetToggleIsOn(int index)
    {
    }

    [Token(Token = "0x600C7C2")]
    [Address(RVA = "0x908B20", Offset = "0x907920", VA = "0x10908B20")]
    private void RefreshBadge()
    {
    }

    [Token(Token = "0x17001A7C")]
    public Dictionary<TrophyCategorys, List<TrophyCategoryData>> TrophyRecordData
    {
      [Token(Token = "0x600C7C3"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (Dictionary<TrophyCategorys, List<TrophyCategoryData>>) null;
      }
    }

    [Token(Token = "0x17001A7D")]
    public List<TrophyState> TrophyDailyData
    {
      [Token(Token = "0x600C7C4"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x17001A7E")]
    public List<TrophyState> TrophyEndedData
    {
      [Token(Token = "0x600C7C5"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x600C7C6")]
    [Address(RVA = "0x909D10", Offset = "0x908B10", VA = "0x10909D10")]
    private void RefreshTrophyDatas()
    {
    }

    [Token(Token = "0x600C7C7")]
    [Address(RVA = "0x909080", Offset = "0x907E80", VA = "0x10909080")]
    private void RefreshGuildTrophyDatas()
    {
    }

    [Token(Token = "0x600C7C8")]
    [Address(RVA = "0x909160", Offset = "0x907F60", VA = "0x10909160")]
    private void RefreshQuestArchive()
    {
    }

    [Token(Token = "0x600C7C9")]
    [Address(RVA = "0x9093F0", Offset = "0x9081F0", VA = "0x109093F0")]
    private void RefreshTrophyDatas(
      TrophyCategoryParam[] tcp,
      TrophyParam[] trp,
      TrophyBase tb,
      ref List<TrophyState> tdd,
      ref List<TrophyState> ted,
      ref Dictionary<TrophyCategorys, List<TrophyCategoryData>> trd)
    {
    }

    [Token(Token = "0x600C7CA")]
    [Address(RVA = "0x9084E0", Offset = "0x9072E0", VA = "0x109084E0")]
    private bool IsDisplayTrophyCategory(TrophyCategoryParam _tcp) => new bool();

    [Token(Token = "0x600C7CB")]
    [Address(RVA = "0x908540", Offset = "0x907340", VA = "0x10908540")]
    private bool IsDisplayTrophy(TrophyState st) => new bool();

    [Token(Token = "0x600C7CC")]
    [Address(RVA = "0x908000", Offset = "0x906E00", VA = "0x10908000")]
    private bool IsCollectiveReceiveTrophy(TrophyState st) => new bool();

    [Token(Token = "0x600C7CD")]
    [Address(RVA = "0x9082F0", Offset = "0x9070F0", VA = "0x109082F0")]
    private bool IsCompletedRequiredTrophy(
      TrophyState trophyState,
      List<TrophyState> endedTrophies,
      List<TrophyState> collectiveReceiveTrophies)
    {
      return new bool();
    }

    [Token(Token = "0x600C7CE")]
    [Address(RVA = "0x908450", Offset = "0x907250", VA = "0x10908450")]
    private bool IsContainTrophyIname(string iname, List<TrophyState> trophyStates) => new bool();

    [Token(Token = "0x600C7CF")]
    [Address(RVA = "0x9062E0", Offset = "0x9050E0", VA = "0x109062E0")]
    public void ActivateTrophyCollectiveReceiptButton(List<TrophyCategoryData> trophyCategories)
    {
    }

    [Token(Token = "0x600C7D0")]
    [Address(RVA = "0x908910", Offset = "0x907710", VA = "0x10908910")]
    private bool IsEnableTrophyCollectiveButton(List<TrophyCategoryData> trophyCategories)
    {
      return new bool();
    }

    [Token(Token = "0x600C7D1")]
    [Address(RVA = "0x908AC0", Offset = "0x9078C0", VA = "0x10908AC0")]
    private void ReflectDailyCollectiveReceipt(Button button, List<TrophyState> dailydatas)
    {
    }

    [Token(Token = "0x600C7D2")]
    [Address(RVA = "0x907A20", Offset = "0x906820", VA = "0x10907A20")]
    public int GetTrophyStarMissionDailyStarCount() => new int();

    [Token(Token = "0x17001A7F")]
    public List<TrophyState> TrophyGuildDailyData
    {
      [Token(Token = "0x600C7D3"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x17001A80")]
    public List<TrophyState> TrophyGuildEndedData
    {
      [Token(Token = "0x600C7D4"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x17001A81")]
    public Dictionary<TrophyCategorys, List<TrophyCategoryData>> TrophyGuildRecordData
    {
      [Token(Token = "0x600C7D5"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return (Dictionary<TrophyCategorys, List<TrophyCategoryData>>) null;
      }
    }

    [Token(Token = "0x600C7D6")]
    [Address(RVA = "0x90A8A0", Offset = "0x9096A0", VA = "0x1090A8A0")]
    public TrophyWindow()
    {
    }

    [Token(Token = "0x2002B85")]
    private enum TabIndex
    {
      [Token(Token = "0x400D599")] Story,
      [Token(Token = "0x400D59A")] Event,
      [Token(Token = "0x400D59B")] Multi,
      [Token(Token = "0x400D59C")] Training,
      [Token(Token = "0x400D59D")] Campaign,
      [Token(Token = "0x400D59E")] Other,
      [Token(Token = "0x400D59F")] MAX,
    }

    [Token(Token = "0x2002B86")]
    private enum DailyIndex
    {
      [Token(Token = "0x400D5A1")] Normal,
      [Token(Token = "0x400D5A2")] Guild,
    }
  }
}
