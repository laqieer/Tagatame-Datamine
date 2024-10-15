// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceEventManager
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
  [Token(Token = "0x2001F42")]
  [AddComponentMenu("UI/Advance/AdvanceEventManager")]
  public class AdvanceEventManager : MonoBehaviour
  {
    [Token(Token = "0x400839E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private AdvanceAssets mAdvanceAssets;
    [Token(Token = "0x400839F")]
    [FieldOffset(Offset = "0x10")]
    private LoadRequest mResourceRequest;
    [Token(Token = "0x40083A0")]
    [FieldOffset(Offset = "0x0")]
    private static AdvanceEventManager mInstance;
    [Token(Token = "0x40083A1")]
    [FieldOffset(Offset = "0x14")]
    private AdvanceEventParam mCurrentEventParam;
    [Token(Token = "0x40083A2")]
    [FieldOffset(Offset = "0x18")]
    private QuestDifficulties mStageDifficulty;
    [Token(Token = "0x40083A3")]
    [FieldOffset(Offset = "0x19")]
    private QuestDifficulties mBossDifficulty;
    [Token(Token = "0x40083A4")]
    [FieldOffset(Offset = "0x1A")]
    private bool mRestorePointIsStage;
    [Token(Token = "0x40083A5")]
    [FieldOffset(Offset = "0x1B")]
    private bool mJumpFromMission;
    [Token(Token = "0x40083A6")]
    [FieldOffset(Offset = "0x1C")]
    private int[] mSelectedStarRewardIndex;
    [Token(Token = "0x40083A7")]
    [FieldOffset(Offset = "0x20")]
    private List<GiftData> mStarMissionGiftDataList;

    [Token(Token = "0x17001255")]
    public static AdvanceEventManager Instance
    {
      [Token(Token = "0x6008011"), Address(RVA = "0x4084C0", Offset = "0x4072C0", VA = "0x104084C0")] get
      {
        return (AdvanceEventManager) null;
      }
    }

    [Token(Token = "0x6008012")]
    [Address(RVA = "0x408240", Offset = "0x407040", VA = "0x10408240")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6008013")]
    [Address(RVA = "0x4081C0", Offset = "0x406FC0", VA = "0x104081C0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x17001256")]
    public AdvanceEventParam CurrentEventParam
    {
      [Token(Token = "0x6008014"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (AdvanceEventParam) null;
      }
    }

    [Token(Token = "0x17001257")]
    public QuestDifficulties StageDifficulty
    {
      [Token(Token = "0x6008015"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new QuestDifficulties();
      }
    }

    [Token(Token = "0x17001258")]
    public QuestDifficulties BossDifficulty
    {
      [Token(Token = "0x6008016"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new QuestDifficulties();
      }
    }

    [Token(Token = "0x17001259")]
    public bool RestorePointIsStage
    {
      [Token(Token = "0x6008017"), Address(RVA = "0x408500", Offset = "0x407300", VA = "0x10408500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700125A")]
    public bool JumpFromMission
    {
      [Token(Token = "0x6008018"), Address(RVA = "0x4084F0", Offset = "0x4072F0", VA = "0x104084F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700125B")]
    public int[] SelectedStarRewardIndex
    {
      [Token(Token = "0x6008019"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x1700125C")]
    public AdvanceAssets AdvanceAssets
    {
      [Token(Token = "0x600801A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (AdvanceAssets) null;
      }
    }

    [Token(Token = "0x1700125D")]
    public List<GiftData> StarMissionGiftDataList
    {
      [Token(Token = "0x600801B"), Address(RVA = "0x408510", Offset = "0x407310", VA = "0x10408510")] get
      {
        return (List<GiftData>) null;
      }
    }

    [Token(Token = "0x600801C")]
    [Address(RVA = "0x408430", Offset = "0x407230", VA = "0x10408430")]
    private void Start()
    {
    }

    [Token(Token = "0x600801D")]
    [Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")]
    public void SetStageDifficulty(QuestDifficulties difficult)
    {
    }

    [Token(Token = "0x600801E")]
    [Address(RVA = "0x4082C0", Offset = "0x4070C0", VA = "0x104082C0")]
    public void SetBossDifficulty(QuestDifficulties difficult)
    {
    }

    [Token(Token = "0x600801F")]
    [Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")]
    public void SetStarRewardIndex(int[] index)
    {
    }

    [Token(Token = "0x6008020")]
    [Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")]
    public void SetCurrentEventParam(AdvanceEventParam chapter)
    {
    }

    [Token(Token = "0x6008021")]
    [Address(RVA = "0x4082E0", Offset = "0x4070E0", VA = "0x104082E0")]
    public void SetRestorePointIsStage(bool flag)
    {
    }

    [Token(Token = "0x6008022")]
    [Address(RVA = "0x4082D0", Offset = "0x4070D0", VA = "0x104082D0")]
    public void SetJumpFromMission(bool flag)
    {
    }

    [Token(Token = "0x6008023")]
    public bool LoadAssets<T>(string name, AdvanceEventManager.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x6008024")]
    private IEnumerator DownloadCoroutine<T>(AdvanceEventManager.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008025")]
    [Address(RVA = "0x4082F0", Offset = "0x4070F0", VA = "0x104082F0")]
    public void SetStarMissionReward(Json_Gift[] rewards)
    {
    }

    [Token(Token = "0x6008026")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceEventManager()
    {
    }

    [Token(Token = "0x2001F43")]
    public delegate void LoadAssetCallback<T>(T obj) where T : UnityEngine.Object;
  }
}
