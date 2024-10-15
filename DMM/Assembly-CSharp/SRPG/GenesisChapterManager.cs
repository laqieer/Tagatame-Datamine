// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisChapterManager
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
  [Token(Token = "0x20024E0")]
  [AddComponentMenu("UI/Genesis/GenesisChapterManager")]
  public class GenesisChapterManager : MonoBehaviour
  {
    [Token(Token = "0x400A86A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GenesisAssets mGenesisAssets;
    [Token(Token = "0x400A86B")]
    [FieldOffset(Offset = "0x10")]
    private LoadRequest mResourceRequest;
    [Token(Token = "0x400A86C")]
    [FieldOffset(Offset = "0x0")]
    private static GenesisChapterManager mInstance;
    [Token(Token = "0x400A86D")]
    [FieldOffset(Offset = "0x14")]
    private GenesisChapterParam mCurrentChapterParam;
    [Token(Token = "0x400A86E")]
    [FieldOffset(Offset = "0x18")]
    private QuestDifficulties mStageDifficulty;
    [Token(Token = "0x400A86F")]
    [FieldOffset(Offset = "0x19")]
    private QuestDifficulties mBossDifficulty;
    [Token(Token = "0x400A870")]
    [FieldOffset(Offset = "0x1A")]
    private bool mRestorePointIsStage;
    [Token(Token = "0x400A871")]
    [FieldOffset(Offset = "0x1B")]
    private bool mJumpFromMission;
    [Token(Token = "0x400A872")]
    [FieldOffset(Offset = "0x1C")]
    private int[] mSelectedStarRewardIndex;
    [Token(Token = "0x400A873")]
    [FieldOffset(Offset = "0x20")]
    private List<GiftData> mStarMissionGiftDataList;

    [Token(Token = "0x1700169C")]
    public static GenesisChapterManager Instance
    {
      [Token(Token = "0x600A1D1"), Address(RVA = "0x63AA80", Offset = "0x639880", VA = "0x1063AA80")] get
      {
        return (GenesisChapterManager) null;
      }
    }

    [Token(Token = "0x600A1D2")]
    [Address(RVA = "0x63A830", Offset = "0x639630", VA = "0x1063A830")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600A1D3")]
    [Address(RVA = "0x63A7B0", Offset = "0x6395B0", VA = "0x1063A7B0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x1700169D")]
    public GenesisChapterParam CurrentChapterParam
    {
      [Token(Token = "0x600A1D4"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (GenesisChapterParam) null;
      }
    }

    [Token(Token = "0x1700169E")]
    public QuestDifficulties StageDifficulty
    {
      [Token(Token = "0x600A1D5"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new QuestDifficulties();
      }
    }

    [Token(Token = "0x1700169F")]
    public QuestDifficulties BossDifficulty
    {
      [Token(Token = "0x600A1D6"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new QuestDifficulties();
      }
    }

    [Token(Token = "0x170016A0")]
    public bool RestorePointIsStage
    {
      [Token(Token = "0x600A1D7"), Address(RVA = "0x408500", Offset = "0x407300", VA = "0x10408500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016A1")]
    public bool JumpFromMission
    {
      [Token(Token = "0x600A1D8"), Address(RVA = "0x4084F0", Offset = "0x4072F0", VA = "0x104084F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170016A2")]
    public int[] SelectedStarRewardIndex
    {
      [Token(Token = "0x600A1D9"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x170016A3")]
    public GenesisAssets GenesisAssets
    {
      [Token(Token = "0x600A1DA"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GenesisAssets) null;
      }
    }

    [Token(Token = "0x170016A4")]
    public List<GiftData> StarMissionGiftDataList
    {
      [Token(Token = "0x600A1DB"), Address(RVA = "0x63AAB0", Offset = "0x6398B0", VA = "0x1063AAB0")] get
      {
        return (List<GiftData>) null;
      }
    }

    [Token(Token = "0x600A1DC")]
    [Address(RVA = "0x63A9F0", Offset = "0x6397F0", VA = "0x1063A9F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A1DD")]
    [Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")]
    public void SetStageDifficulty(QuestDifficulties difficult)
    {
    }

    [Token(Token = "0x600A1DE")]
    [Address(RVA = "0x4082C0", Offset = "0x4070C0", VA = "0x104082C0")]
    public void SetBossDifficulty(QuestDifficulties difficult)
    {
    }

    [Token(Token = "0x600A1DF")]
    [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
    public void SetStarRewardIndex(int[] index)
    {
    }

    [Token(Token = "0x600A1E0")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void SetCurrentChapterParam(GenesisChapterParam chapter)
    {
    }

    [Token(Token = "0x600A1E1")]
    [Address(RVA = "0x4082E0", Offset = "0x4070E0", VA = "0x104082E0")]
    public void SetRestorePointIsStage(bool flag)
    {
    }

    [Token(Token = "0x600A1E2")]
    [Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x104082D0")]
    public void SetJumpFromMission(bool flag)
    {
    }

    [Token(Token = "0x600A1E3")]
    public bool LoadAssets<T>(
      string name,
      GenesisChapterManager.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x600A1E4")]
    private IEnumerator DownloadCoroutine<T>(
      GenesisChapterManager.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600A1E5")]
    [Address(RVA = "0x63A8B0", Offset = "0x6396B0", VA = "0x1063A8B0")]
    public void SetStarMissionReward(Json_Gift[] rewards)
    {
    }

    [Token(Token = "0x600A1E6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisChapterManager()
    {
    }

    [Token(Token = "0x20024E1")]
    public delegate void LoadAssetCallback<T>(T obj) where T : UnityEngine.Object;
  }
}
