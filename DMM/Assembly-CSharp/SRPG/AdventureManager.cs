// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureManager
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
  [Token(Token = "0x2001F9C")]
  [AddComponentMenu("UI/Adventure/AdventureManager")]
  public class AdventureManager : BaseManager<AdventureManager>
  {
    [Token(Token = "0x4008594")]
    [FieldOffset(Offset = "0x0")]
    private static List<AdventureData> mAdvDataList;
    [Token(Token = "0x4008595")]
    [FieldOffset(Offset = "0x4")]
    private static List<AdventureDataBase> mAdvDataBaseList;
    [Token(Token = "0x4008596")]
    [FieldOffset(Offset = "0xC")]
    private AdventureData mCurrentAdvData;
    [Token(Token = "0x4008597")]
    [FieldOffset(Offset = "0x10")]
    private List<UnitData> mCurrentPartyList;
    [Token(Token = "0x4008598")]
    [FieldOffset(Offset = "0x14")]
    private List<AdventureSaveTimeItem.UseItemData> mUseItemDatas;
    [Token(Token = "0x4008599")]
    [FieldOffset(Offset = "0x18")]
    private int mAdvCount;
    [Token(Token = "0x400859A")]
    [FieldOffset(Offset = "0x1C")]
    private int mAdvMaxCount;
    [Token(Token = "0x400859B")]
    [FieldOffset(Offset = "0x20")]
    private int mAdvExtendCount;
    [Token(Token = "0x400859C")]
    [FieldOffset(Offset = "0x24")]
    private int mAdvEndCount;
    [Token(Token = "0x400859D")]
    [FieldOffset(Offset = "0x28")]
    private List<AdventureDrop> mAdvDropList;
    [Token(Token = "0x400859E")]
    [FieldOffset(Offset = "0x2C")]
    private List<AdventureBook> mAdvBookList;
    [Token(Token = "0x400859F")]
    [FieldOffset(Offset = "0x30")]
    private AdventureBook mAdvUpdateBook;
    [Token(Token = "0x40085A0")]
    [FieldOffset(Offset = "0x34")]
    private List<AdventureHistory> mAdvHistoryList;
    [Token(Token = "0x40085A1")]
    [FieldOffset(Offset = "0x38")]
    private AdventureManager.AdventureTrophyProgress mAdvEndTrophyProgress;
    [Token(Token = "0x40085A2")]
    [FieldOffset(Offset = "0x3C")]
    private bool mIsLocalPush;
    [Token(Token = "0x40085A3")]
    [FieldOffset(Offset = "0x40")]
    private AdventureLocalNotification mAdvNotification;

    [Token(Token = "0x60081E1")]
    [Address(RVA = "0x425630", Offset = "0x424430", VA = "0x10425630")]
    public static AdventureData FindAdventureData(string area_iname) => (AdventureData) null;

    [Token(Token = "0x170012A8")]
    public static List<AdventureDataBase> AdvDataBaseList
    {
      [Token(Token = "0x60081E2"), Address(RVA = "0x428150", Offset = "0x426F50", VA = "0x10428150")] get
      {
        return (List<AdventureDataBase>) null;
      }
    }

    [Token(Token = "0x60081E3")]
    [Address(RVA = "0x426A60", Offset = "0x425860", VA = "0x10426A60")]
    public static JSON_AdventureDataBase[] SerializeAdvDataBaseList()
    {
      return (JSON_AdventureDataBase[]) null;
    }

    [Token(Token = "0x170012A9")]
    public AdventureData CurrentAdvData
    {
      [Token(Token = "0x60081E4"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (AdventureData) null;
      }
    }

    [Token(Token = "0x170012AA")]
    public List<UnitData> CurrentPartyList
    {
      [Token(Token = "0x60081E5"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x60081E6")]
    [Address(RVA = "0x427E90", Offset = "0x426C90", VA = "0x10427E90")]
    public bool SetCurrentAdvData(AdventureData adv_data) => new bool();

    [Token(Token = "0x170012AB")]
    public List<AdventureSaveTimeItem.UseItemData> UseItemDatas
    {
      [Token(Token = "0x60081E7"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<AdventureSaveTimeItem.UseItemData>) null;
      }
      [Token(Token = "0x60081E8"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x170012AC")]
    public int AdvCount
    {
      [Token(Token = "0x60081E9"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170012AD")]
    public int AdvMaxCount
    {
      [Token(Token = "0x60081EA"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170012AE")]
    public int AdvExtendCount
    {
      [Token(Token = "0x60081EB"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60081EC")]
    [Address(RVA = "0x4243A0", Offset = "0x4231A0", VA = "0x104243A0")]
    public int CalcAdvExtendMaxCount() => new int();

    [Token(Token = "0x60081ED")]
    [Address(RVA = "0x425E40", Offset = "0x424C40", VA = "0x10425E40")]
    public int GetTargetAdvExtendClearCount() => new int();

    [Token(Token = "0x170012AF")]
    public int AdvEndCount
    {
      [Token(Token = "0x60081EE"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170012B0")]
    public List<AdventureDrop> AdvDropList
    {
      [Token(Token = "0x60081EF"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<AdventureDrop>) null;
      }
    }

    [Token(Token = "0x170012B1")]
    public List<AdventureBook> AdvBookList
    {
      [Token(Token = "0x60081F0"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<AdventureBook>) null;
      }
    }

    [Token(Token = "0x60081F1")]
    [Address(RVA = "0x425820", Offset = "0x424620", VA = "0x10425820")]
    public List<AdventureBook.Item> GetAdvBookItemList(string area_iname)
    {
      return (List<AdventureBook.Item>) null;
    }

    [Token(Token = "0x170012B2")]
    public AdventureBook AdvUpdateBook
    {
      [Token(Token = "0x60081F2"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (AdventureBook) null;
      }
    }

    [Token(Token = "0x170012B3")]
    public List<AdventureHistory> AdvHistoryList
    {
      [Token(Token = "0x60081F3"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (List<AdventureHistory>) null;
      }
    }

    [Token(Token = "0x170012B4")]
    public bool IsLocalPush
    {
      [Token(Token = "0x60081F4"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
      [Token(Token = "0x60081F5"), Address(RVA = "0x428390", Offset = "0x427190", VA = "0x10428390")] set
      {
      }
    }

    [Token(Token = "0x170012B5")]
    public AdventureLocalNotification AdvNotification
    {
      [Token(Token = "0x60081F6"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (AdventureLocalNotification) null;
      }
    }

    [Token(Token = "0x60081F7")]
    [Address(RVA = "0x424260", Offset = "0x423060", VA = "0x10424260")]
    private void Awake()
    {
    }

    [Token(Token = "0x60081F8")]
    [Address(RVA = "0x426030", Offset = "0x424E30", VA = "0x10426030")]
    public bool IsMeetConditionArea(AdventureData adv_data) => new bool();

    [Token(Token = "0x60081F9")]
    [Address(RVA = "0x424D30", Offset = "0x423B30", VA = "0x10424D30")]
    public List<AdventureData> CreateAreaDataList(bool is_active = false)
    {
      return (List<AdventureData>) null;
    }

    [Token(Token = "0x60081FA")]
    [Address(RVA = "0x424F20", Offset = "0x423D20", VA = "0x10424F20")]
    public List<AdventureBook> CreateBookDataList(bool is_active = false)
    {
      return (List<AdventureBook>) null;
    }

    [Token(Token = "0x60081FB")]
    [Address(RVA = "0x424570", Offset = "0x423370", VA = "0x10424570")]
    public bool[] CalcSpcUnitGroupApplyInfo(PartyData _party_data, AdventureData adv_data = null)
    {
      return (bool[]) null;
    }

    [Token(Token = "0x60081FC")]
    [Address(RVA = "0x424AF0", Offset = "0x4238F0", VA = "0x10424AF0")]
    public static List<BuffEffectParam> CreateAdvApplyBuffList(List<AdventureDataBase> adb_list = null)
    {
      return (List<BuffEffectParam>) null;
    }

    [Token(Token = "0x60081FD")]
    [Address(RVA = "0x423F40", Offset = "0x422D40", VA = "0x10423F40")]
    private static bool AddAdvDataParam() => new bool();

    [Token(Token = "0x60081FE")]
    [Address(RVA = "0x4270D0", Offset = "0x425ED0", VA = "0x104270D0")]
    public static void SetAdvData(JSON_AdventureData[] adv_datas)
    {
    }

    [Token(Token = "0x60081FF")]
    [Address(RVA = "0x4267B0", Offset = "0x4255B0", VA = "0x104267B0")]
    public static void RefreshAdvData(JSON_AdventureData[] adv_datas)
    {
    }

    [Token(Token = "0x6008200")]
    [Address(RVA = "0x426570", Offset = "0x425370", VA = "0x10426570")]
    private void RefreshAdvCountInstance()
    {
    }

    [Token(Token = "0x6008201")]
    [Address(RVA = "0x4266D0", Offset = "0x4254D0", VA = "0x104266D0")]
    public static bool RefreshAdvCount() => new bool();

    [Token(Token = "0x6008202")]
    [Address(RVA = "0x426C90", Offset = "0x425A90", VA = "0x10426C90")]
    private bool SetAdvAddCountInstance(int adv_add_count) => new bool();

    [Token(Token = "0x6008203")]
    [Address(RVA = "0x426D20", Offset = "0x425B20", VA = "0x10426D20")]
    public static bool SetAdvAddCount(int adv_add_count) => new bool();

    [Token(Token = "0x6008204")]
    [Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")]
    private void SetAdvEndCountInstance(int adv_end_count)
    {
    }

    [Token(Token = "0x6008205")]
    [Address(RVA = "0x4275E0", Offset = "0x4263E0", VA = "0x104275E0")]
    public static bool SetAdvEndCount(int adv_end_count) => new bool();

    [Token(Token = "0x6008206")]
    [Address(RVA = "0x4272F0", Offset = "0x4260F0", VA = "0x104272F0")]
    private bool SetAdvDropInstance(JSON_AdventureDrop[] adv_drops) => new bool();

    [Token(Token = "0x6008207")]
    [Address(RVA = "0x427400", Offset = "0x426200", VA = "0x10427400")]
    public static bool SetAdvDrop(JSON_AdventureDrop[] adv_drops) => new bool();

    [Token(Token = "0x6008208")]
    [Address(RVA = "0x426E00", Offset = "0x425C00", VA = "0x10426E00")]
    private bool SetAdvBookInstance(JSON_AdventureBook[] adv_books) => new bool();

    [Token(Token = "0x6008209")]
    [Address(RVA = "0x426F00", Offset = "0x425D00", VA = "0x10426F00")]
    public static bool SetAdvBook(JSON_AdventureBook[] adv_books) => new bool();

    [Token(Token = "0x600820A")]
    [Address(RVA = "0x427BD0", Offset = "0x4269D0", VA = "0x10427BD0")]
    private bool SetAdvUpdateBookInstance(JSON_AdventureBook[] adv_books) => new bool();

    [Token(Token = "0x600820B")]
    [Address(RVA = "0x427CD0", Offset = "0x426AD0", VA = "0x10427CD0")]
    public static bool SetAdvUpdateBook(JSON_AdventureBook[] adv_books) => new bool();

    [Token(Token = "0x600820C")]
    [Address(RVA = "0x427900", Offset = "0x426700", VA = "0x10427900")]
    private bool SetAdvHistoryInstance(JSON_AdventureHistory[] adv_histories) => new bool();

    [Token(Token = "0x600820D")]
    [Address(RVA = "0x427A00", Offset = "0x426800", VA = "0x10427A00")]
    public static bool SetAdvHistory(JSON_AdventureHistory[] adv_histories) => new bool();

    [Token(Token = "0x600820E")]
    [Address(RVA = "0x426450", Offset = "0x425250", VA = "0x10426450")]
    public bool ReflectAdvEndTrophyProgress() => new bool();

    [Token(Token = "0x600820F")]
    [Address(RVA = "0x4276C0", Offset = "0x4264C0", VA = "0x104276C0")]
    private bool SetAdvEndTrophyProgressInstance(
      JSON_TrophyProgress[] trophyprogs,
      JSON_TrophyProgress[] bingoprogs,
      JSON_TrophyProgress[] guild_trophies)
    {
      return new bool();
    }

    [Token(Token = "0x6008210")]
    [Address(RVA = "0x427780", Offset = "0x426580", VA = "0x10427780")]
    public static bool SetAdvEndTrophyProgress(
      JSON_TrophyProgress[] trophyprogs,
      JSON_TrophyProgress[] bingoprogs,
      JSON_TrophyProgress[] guild_trophies)
    {
      return new bool();
    }

    [Token(Token = "0x6008211")]
    [Address(RVA = "0x425C80", Offset = "0x424A80", VA = "0x10425C80")]
    public List<UnitData> GetDispatchedUnitList() => (List<UnitData>) null;

    [Token(Token = "0x6008212")]
    [Address(RVA = "0x426010", Offset = "0x424E10", VA = "0x10426010")]
    public bool IsAdventureReady() => new bool();

    [Token(Token = "0x6008213")]
    [Address(RVA = "0x425920", Offset = "0x424720", VA = "0x10425920")]
    public List<string> GetAdventureBookProgress() => (List<string>) null;

    [Token(Token = "0x6008214")]
    [Address(RVA = "0x4262E0", Offset = "0x4250E0", VA = "0x104262E0")]
    public bool IsMenuIconBadgeActive() => new bool();

    [Token(Token = "0x6008215")]
    [Address(RVA = "0x4251B0", Offset = "0x423FB0", VA = "0x104251B0")]
    public void DisplayRemainTime(Text _text, AdventureData _data)
    {
    }

    [Token(Token = "0x6008216")]
    [Address(RVA = "0x425760", Offset = "0x424560", VA = "0x10425760")]
    public Sprite GetAdvAreaIcon(int _index) => (Sprite) null;

    [Token(Token = "0x6008217")]
    [Address(RVA = "0x428000", Offset = "0x426E00", VA = "0x10428000")]
    public AdventureManager()
    {
    }

    [Token(Token = "0x6008218")]
    [Address(RVA = "0x427F50", Offset = "0x426D50", VA = "0x10427F50")]
    static AdventureManager()
    {
    }

    [Token(Token = "0x2001F9D")]
    private class AdventureTrophyProgress
    {
      [Token(Token = "0x40085A4")]
      [FieldOffset(Offset = "0x8")]
      private JSON_TrophyProgress[] mTrophyProgs;
      [Token(Token = "0x40085A5")]
      [FieldOffset(Offset = "0xC")]
      private JSON_TrophyProgress[] mBingoProgs;
      [Token(Token = "0x40085A6")]
      [FieldOffset(Offset = "0x10")]
      private JSON_TrophyProgress[] mGuildProgs;

      [Token(Token = "0x170012B6")]
      public JSON_TrophyProgress[] TrophyProgs
      {
        [Token(Token = "0x600821A"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (JSON_TrophyProgress[]) null;
        }
      }

      [Token(Token = "0x170012B7")]
      public JSON_TrophyProgress[] BingoProgs
      {
        [Token(Token = "0x600821B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (JSON_TrophyProgress[]) null;
        }
      }

      [Token(Token = "0x170012B8")]
      public JSON_TrophyProgress[] GuildProgs
      {
        [Token(Token = "0x600821C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (JSON_TrophyProgress[]) null;
        }
      }

      [Token(Token = "0x600821D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public AdventureTrophyProgress()
      {
      }

      [Token(Token = "0x600821E")]
      [Address(RVA = "0x42CC30", Offset = "0x42BA30", VA = "0x1042CC30")]
      public AdventureTrophyProgress(
        JSON_TrophyProgress[] trophyprogs,
        JSON_TrophyProgress[] bingoprogs,
        JSON_TrophyProgress[] guild_trophies)
      {
      }
    }
  }
}
