// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestChapterManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002802")]
  public class PointQuestChapterManager : MonoBehaviour
  {
    [Token(Token = "0x400BE6B")]
    [FieldOffset(Offset = "0xC")]
    private LoadRequest mResourceRequest;
    [Token(Token = "0x400BE6C")]
    [FieldOffset(Offset = "0x0")]
    private static PointQuestChapterManager mInstance;
    [Token(Token = "0x400BE6D")]
    [FieldOffset(Offset = "0x10")]
    private ChapterParam mCurrentChapterParam;
    [Token(Token = "0x400BE6E")]
    [FieldOffset(Offset = "0x14")]
    private QuestDifficulties mStageDifficulty;
    [Token(Token = "0x400BE6F")]
    [FieldOffset(Offset = "0x15")]
    private bool mRestorePointIsStage;
    [Token(Token = "0x400BE70")]
    [FieldOffset(Offset = "0x16")]
    private bool mJumpFromMission;

    [Token(Token = "0x170018BC")]
    public static PointQuestChapterManager Instance
    {
      [Token(Token = "0x600B496"), Address(RVA = "0x7B1CF0", Offset = "0x7B0AF0", VA = "0x107B1CF0")] get
      {
        return (PointQuestChapterManager) null;
      }
    }

    [Token(Token = "0x600B497")]
    [Address(RVA = "0x7B1C10", Offset = "0x7B0A10", VA = "0x107B1C10")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600B498")]
    [Address(RVA = "0x7B1B90", Offset = "0x7B0990", VA = "0x107B1B90")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x170018BD")]
    public ChapterParam CurrentChapterParam
    {
      [Token(Token = "0x600B499"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ChapterParam) null;
      }
    }

    [Token(Token = "0x170018BE")]
    public QuestDifficulties StageDifficulty
    {
      [Token(Token = "0x600B49A"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new QuestDifficulties();
      }
    }

    [Token(Token = "0x170018BF")]
    public bool RestorePointIsStage
    {
      [Token(Token = "0x600B49B"), Address(RVA = "0x39C2B0", Offset = "0x39B0B0", VA = "0x1039C2B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170018C0")]
    public bool JumpFromMission
    {
      [Token(Token = "0x600B49C"), Address(RVA = "0x7B1D20", Offset = "0x7B0B20", VA = "0x107B1D20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B49D")]
    [Address(RVA = "0x7B1CB0", Offset = "0x7B0AB0", VA = "0x107B1CB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B49E")]
    [Address(RVA = "0x357B00", Offset = "0x356900", VA = "0x10357B00")]
    public void SetStageDifficulty(QuestDifficulties difficult)
    {
    }

    [Token(Token = "0x600B49F")]
    [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
    public void SetCurrentChapterParam(ChapterParam chapter)
    {
    }

    [Token(Token = "0x600B4A0")]
    [Address(RVA = "0x7B1CA0", Offset = "0x7B0AA0", VA = "0x107B1CA0")]
    public void SetRestorePointIsStage(bool flag)
    {
    }

    [Token(Token = "0x600B4A1")]
    [Address(RVA = "0x7B1C90", Offset = "0x7B0A90", VA = "0x107B1C90")]
    public void SetJumpFromMission(bool flag)
    {
    }

    [Token(Token = "0x600B4A2")]
    public bool LoadAssets<T>(
      string name,
      PointQuestChapterManager.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x600B4A3")]
    private IEnumerator DownloadCoroutine<T>(
      PointQuestChapterManager.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600B4A4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestChapterManager()
    {
    }

    [Token(Token = "0x2002803")]
    public delegate void LoadAssetCallback<T>(T obj) where T : UnityEngine.Object;
  }
}
