// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002829")]
  public class PointQuestManager : MonoBehaviour
  {
    [Token(Token = "0x400BF6A")]
    [FieldOffset(Offset = "0xC")]
    private string mSectionName;
    [Token(Token = "0x400BF6B")]
    [FieldOffset(Offset = "0x10")]
    private List<PointQuestRewardStatus> mRewardStatusList;
    [Token(Token = "0x400BF6C")]
    [FieldOffset(Offset = "0x14")]
    private List<PointQuestBestPoint> mBestPointList;
    [Token(Token = "0x400BF6D")]
    [FieldOffset(Offset = "0x18")]
    private JSON_ShopListArray.Shops mShopInfo;
    [Token(Token = "0x400BF6E")]
    [FieldOffset(Offset = "0x1C")]
    private PointQuestPlayerInfoData mPointQuestPlayerInfo;
    [Token(Token = "0x400BF6F")]
    [FieldOffset(Offset = "0x20")]
    private List<PointQuestProgressInfoData> mProgressInfoList;
    [Token(Token = "0x400BF70")]
    [FieldOffset(Offset = "0x24")]
    private bool mIsDragonGod;
    [Token(Token = "0x400BF71")]
    [FieldOffset(Offset = "0x25")]
    private bool mIsScoreChallenge;
    [Token(Token = "0x400BF72")]
    [FieldOffset(Offset = "0x0")]
    private static ChapterParam mCurrentChapterParam;
    [Token(Token = "0x400BF73")]
    [FieldOffset(Offset = "0x28")]
    private string mCacheWolrdId;
    [Token(Token = "0x400BF74")]
    [FieldOffset(Offset = "0x2C")]
    private List<ChapterParam> mCacheCapterList;
    [Token(Token = "0x400BF75")]
    [FieldOffset(Offset = "0x30")]
    private string mCacheChapterId;
    [Token(Token = "0x400BF76")]
    [FieldOffset(Offset = "0x34")]
    private List<QuestParam> mCacheQuestList;
    [Token(Token = "0x400BF77")]
    [FieldOffset(Offset = "0x38")]
    private string mShopGname;
    [Token(Token = "0x400BF78")]
    [FieldOffset(Offset = "0x3C")]
    private bool mIsReward;
    [Token(Token = "0x400BF79")]
    [FieldOffset(Offset = "0x3D")]
    private bool mIsGuildReward;
    [Token(Token = "0x400BF7A")]
    [FieldOffset(Offset = "0x4")]
    private static PointQuestManager mInstance;

    [Token(Token = "0x170018CD")]
    public string SectionName
    {
      [Token(Token = "0x600B528"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170018CE")]
    public string GetCurrentChapterName
    {
      [Token(Token = "0x600B529"), Address(RVA = "0x7BBE00", Offset = "0x7BAC00", VA = "0x107BBE00")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170018CF")]
    public List<PointQuestRewardStatus> RewardStatusList
    {
      [Token(Token = "0x600B52A"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<PointQuestRewardStatus>) null;
      }
    }

    [Token(Token = "0x170018D0")]
    public List<PointQuestBestPoint> BestPointList
    {
      [Token(Token = "0x600B52B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<PointQuestBestPoint>) null;
      }
    }

    [Token(Token = "0x170018D1")]
    public JSON_ShopListArray.Shops ShopInfo
    {
      [Token(Token = "0x600B52C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (JSON_ShopListArray.Shops) null;
      }
    }

    [Token(Token = "0x170018D2")]
    public PointQuestPlayerInfoData PointQuestPlayerInfo
    {
      [Token(Token = "0x600B52D"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (PointQuestPlayerInfoData) null;
      }
    }

    [Token(Token = "0x170018D3")]
    public List<PointQuestProgressInfoData> PointQuestProgressInfoList
    {
      [Token(Token = "0x600B52E"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<PointQuestProgressInfoData>) null;
      }
    }

    [Token(Token = "0x170018D4")]
    public bool IsDragonGod
    {
      [Token(Token = "0x600B52F"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170018D5")]
    public bool IsScoreChallenge
    {
      [Token(Token = "0x600B530"), Address(RVA = "0x628F10", Offset = "0x627D10", VA = "0x10628F10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170018D6")]
    public static ChapterParam CurrentChapterParam
    {
      [Token(Token = "0x600B531"), Address(RVA = "0x7BBDD0", Offset = "0x7BABD0", VA = "0x107BBDD0")] get
      {
        return (ChapterParam) null;
      }
      [Token(Token = "0x600B532"), Address(RVA = "0x7BBE80", Offset = "0x7BAC80", VA = "0x107BBE80")] set
      {
      }
    }

    [Token(Token = "0x170018D7")]
    public string GetShopGname
    {
      [Token(Token = "0x600B533"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170018D8")]
    public bool IsReward
    {
      [Token(Token = "0x600B534"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170018D9")]
    public bool IsGuildReward
    {
      [Token(Token = "0x600B535"), Address(RVA = "0x56B2D0", Offset = "0x56A0D0", VA = "0x1056B2D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170018DA")]
    public static PointQuestManager Instance
    {
      [Token(Token = "0x600B536"), Address(RVA = "0x7BBE50", Offset = "0x7BAC50", VA = "0x107BBE50")] get
      {
        return (PointQuestManager) null;
      }
    }

    [Token(Token = "0x600B537")]
    [Address(RVA = "0x7BBB80", Offset = "0x7BA980", VA = "0x107BBB80")]
    private void Start()
    {
    }

    [Token(Token = "0x600B538")]
    [Address(RVA = "0x7BB500", Offset = "0x7BA300", VA = "0x107BB500")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600B539")]
    [Address(RVA = "0x7BB470", Offset = "0x7BA270", VA = "0x107BB470")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600B53A")]
    [Address(RVA = "0x7BB1D0", Offset = "0x7B9FD0", VA = "0x107BB1D0")]
    public List<ChapterParam> GetChapterList() => (List<ChapterParam>) null;

    [Token(Token = "0x600B53B")]
    [Address(RVA = "0x7BB2C0", Offset = "0x7BA0C0", VA = "0x107BB2C0")]
    public List<QuestParam> GetQuestList(string chapter_iname) => (List<QuestParam>) null;

    [Token(Token = "0x600B53C")]
    [Address(RVA = "0x7BB8F0", Offset = "0x7BA6F0", VA = "0x107BB8F0")]
    public void SetRewardStatus(JSON_PointQuestRewardStatusData[] json_rewards)
    {
    }

    [Token(Token = "0x600B53D")]
    [Address(RVA = "0x7BB590", Offset = "0x7BA390", VA = "0x107BB590")]
    public void SetBestPoint(JSON_PointQuestBestPointData[] json_bestPoints)
    {
    }

    [Token(Token = "0x600B53E")]
    [Address(RVA = "0x7BBA10", Offset = "0x7BA810", VA = "0x107BBA10")]
    public void SetShop(JSON_ShopListArray.Shops json_shop)
    {
    }

    [Token(Token = "0x600B53F")]
    [Address(RVA = "0x7BB6B0", Offset = "0x7BA4B0", VA = "0x107BB6B0")]
    public void SetPlayerInfo(JSON_PointQuestPlayerInfoData json)
    {
    }

    [Token(Token = "0x600B540")]
    [Address(RVA = "0x7BB8D0", Offset = "0x7BA6D0", VA = "0x107BB8D0")]
    public void SetRewardInfo(int isReward, int isGuildReward)
    {
    }

    [Token(Token = "0x600B541")]
    public bool LoadAssets<T>(string name, PointQuestManager.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x600B542")]
    private IEnumerator DownloadCoroutine<T>(
      string name,
      PointQuestManager.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600B543")]
    [Address(RVA = "0x7BB7D0", Offset = "0x7BA5D0", VA = "0x107BB7D0")]
    public void SetQuestProgressInfo(JSON_QuestProgress[] json)
    {
    }

    [Token(Token = "0x600B544")]
    [Address(RVA = "0x7BBC30", Offset = "0x7BAA30", VA = "0x107BBC30")]
    public PointQuestManager()
    {
    }

    [Token(Token = "0x200282A")]
    public delegate void LoadAssetCallback<T>(T obj) where T : UnityEngine.Object;
  }
}
