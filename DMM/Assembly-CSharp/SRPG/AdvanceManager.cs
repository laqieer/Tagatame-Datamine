// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceManager
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
  [Token(Token = "0x2001F51")]
  [AddComponentMenu("UI/Advance/AdvanceManager")]
  public class AdvanceManager : MonoBehaviour
  {
    [Token(Token = "0x40083F3")]
    [FieldOffset(Offset = "0x0")]
    private static AdvanceManager mInstance;
    [Token(Token = "0x40083F4")]
    [FieldOffset(Offset = "0x4")]
    private static AdvanceEventParam mCurrentEventParam;
    [Token(Token = "0x40083F5")]
    [FieldOffset(Offset = "0x8")]
    private static ChapterParam mCurrentChapterParam;
    [Token(Token = "0x40083F6")]
    [FieldOffset(Offset = "0xC")]
    private static List<ChapterParam> mBossChapterParamList;
    [Token(Token = "0x40083F7")]
    [FieldOffset(Offset = "0x10")]
    private static List<AdvanceManager.StarMissionInfo> mStarMissionInfoList;

    [Token(Token = "0x17001266")]
    public static AdvanceManager Instance
    {
      [Token(Token = "0x600806A"), Address(RVA = "0x40C6A0", Offset = "0x40B4A0", VA = "0x1040C6A0")] get
      {
        return (AdvanceManager) null;
      }
    }

    [Token(Token = "0x600806B")]
    [Address(RVA = "0x40C030", Offset = "0x40AE30", VA = "0x1040C030")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600806C")]
    [Address(RVA = "0x40BF80", Offset = "0x40AD80", VA = "0x1040BF80")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x17001267")]
    public static AdvanceEventParam CurrentEventParam
    {
      [Token(Token = "0x600806D"), Address(RVA = "0x40C660", Offset = "0x40B460", VA = "0x1040C660")] get
      {
        return (AdvanceEventParam) null;
      }
      [Token(Token = "0x600806E"), Address(RVA = "0x40C820", Offset = "0x40B620", VA = "0x1040C820")] set
      {
      }
    }

    [Token(Token = "0x17001268")]
    public static ChapterParam CurrentChapterParam
    {
      [Token(Token = "0x600806F"), Address(RVA = "0x40C620", Offset = "0x40B420", VA = "0x1040C620")] get
      {
        return (ChapterParam) null;
      }
      [Token(Token = "0x6008070"), Address(RVA = "0x40C7C0", Offset = "0x40B5C0", VA = "0x1040C7C0")] set
      {
      }
    }

    [Token(Token = "0x17001269")]
    public static List<ChapterParam> BossChapterParamList
    {
      [Token(Token = "0x6008071"), Address(RVA = "0x40C5E0", Offset = "0x40B3E0", VA = "0x1040C5E0")] get
      {
        return (List<ChapterParam>) null;
      }
      [Token(Token = "0x6008072"), Address(RVA = "0x40C760", Offset = "0x40B560", VA = "0x1040C760")] set
      {
      }
    }

    [Token(Token = "0x1700126A")]
    public static bool IsBossChapterParamList
    {
      [Token(Token = "0x6008073"), Address(RVA = "0x40C6E0", Offset = "0x40B4E0", VA = "0x1040C6E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008074")]
    public bool LoadAssets<T>(string name, AdvanceManager.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x6008075")]
    private IEnumerator DownloadCoroutine<T>(
      string name,
      AdvanceManager.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008076")]
    [Address(RVA = "0x40BE00", Offset = "0x40AC00", VA = "0x1040BE00")]
    public static bool IsGetStarMissionReward(
      string area_id,
      QuestDifficulties difficulty,
      int[] star_idx)
    {
      return new bool();
    }

    [Token(Token = "0x6008077")]
    [Address(RVA = "0x40C0E0", Offset = "0x40AEE0", VA = "0x1040C0E0")]
    public static void SetStarMissionInfo(ReqBtlCom.AdvanceStar[] advance_stars)
    {
    }

    [Token(Token = "0x6008078")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceManager()
    {
    }

    [Token(Token = "0x6008079")]
    [Address(RVA = "0x40C4B0", Offset = "0x40B2B0", VA = "0x1040C4B0")]
    static AdvanceManager()
    {
    }

    [Token(Token = "0x2001F52")]
    public delegate void LoadAssetCallback<T>(T obj) where T : UnityEngine.Object;

    [Token(Token = "0x2001F53")]
    public class StarMissionInfo
    {
      [Token(Token = "0x40083F8")]
      [FieldOffset(Offset = "0x8")]
      public string mAreaId;
      [Token(Token = "0x40083F9")]
      [FieldOffset(Offset = "0xC")]
      public AdvanceManager.StarMissionInfo.Mode[] mMode;

      [Token(Token = "0x600807E")]
      [Address(RVA = "0x411B50", Offset = "0x410950", VA = "0x10411B50")]
      public StarMissionInfo(string area_id, int mode_len)
      {
      }

      [Token(Token = "0x2001F54")]
      public class Mode
      {
        [Token(Token = "0x40083FA")]
        [FieldOffset(Offset = "0x8")]
        public bool[] mIsReward;

        [Token(Token = "0x600807F")]
        [Address(RVA = "0x4113A0", Offset = "0x4101A0", VA = "0x104113A0")]
        public Mode(int reward_len)
        {
        }
      }
    }
  }
}
