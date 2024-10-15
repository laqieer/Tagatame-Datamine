// Decompiled with JetBrains decompiler
// Type: SRPG.ProgressWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002855")]
  [AddComponentMenu("UI/ProgressWindow")]
  public class ProgressWindow : MonoBehaviour
  {
    [Token(Token = "0x400C084")]
    [FieldOffset(Offset = "0x0")]
    private static ProgressWindow mInstance;
    [Token(Token = "0x400C085")]
    [FieldOffset(Offset = "0xC")]
    public Animator WindowAnimator;
    [Token(Token = "0x400C086")]
    [FieldOffset(Offset = "0x10")]
    public Slider ProgressBar;
    [Token(Token = "0x400C087")]
    [FieldOffset(Offset = "0x14")]
    public ProgressWindow.ProgressRatio Ratios;
    [Token(Token = "0x400C088")]
    [FieldOffset(Offset = "0x1C")]
    public string CloseTrigger;
    [Token(Token = "0x400C089")]
    [FieldOffset(Offset = "0x20")]
    public float DestroyDelay;
    [Token(Token = "0x400C08A")]
    [FieldOffset(Offset = "0x24")]
    public Text Title;
    [Token(Token = "0x400C08B")]
    [FieldOffset(Offset = "0x28")]
    public Text Lore;
    [Token(Token = "0x400C08C")]
    [FieldOffset(Offset = "0x2C")]
    public Text Percentage;
    [Token(Token = "0x400C08D")]
    [FieldOffset(Offset = "0x30")]
    public string PercentageFormat;
    [Token(Token = "0x400C08E")]
    [FieldOffset(Offset = "0x34")]
    public Text Complete;
    [Token(Token = "0x400C08F")]
    [FieldOffset(Offset = "0x38")]
    public string CompleteFormat;
    [Token(Token = "0x400C090")]
    [FieldOffset(Offset = "0x3C")]
    public ImageArray Phase;
    [Token(Token = "0x400C091")]
    [FieldOffset(Offset = "0x40")]
    public GameObject[] PhaseObjects;
    [Token(Token = "0x400C092")]
    [FieldOffset(Offset = "0x44")]
    public GameObject notice0;
    [Token(Token = "0x400C093")]
    [FieldOffset(Offset = "0x48")]
    public GameObject notice1;
    [Token(Token = "0x400C094")]
    [FieldOffset(Offset = "0x4C")]
    public string ImageTable;
    [Token(Token = "0x400C095")]
    [FieldOffset(Offset = "0x50")]
    public RawImage[] Images;
    [Token(Token = "0x400C096")]
    [FieldOffset(Offset = "0x54")]
    public float DisplayImageThreshold;
    [Token(Token = "0x400C097")]
    [FieldOffset(Offset = "0x58")]
    public GameObject ImageGroup;
    [Token(Token = "0x400C098")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject ProgressBarRoot;
    [Token(Token = "0x400C099")]
    [FieldOffset(Offset = "0x60")]
    public float MinVisibleTime;
    [Token(Token = "0x400C09A")]
    [FieldOffset(Offset = "0x64")]
    private float mLoadTime;
    [Token(Token = "0x400C09B")]
    [FieldOffset(Offset = "0x68")]
    private float mLoadProgress;
    [Token(Token = "0x400C09C")]
    [FieldOffset(Offset = "0x70")]
    private long mKeepTotalDownloadSize;
    [Token(Token = "0x400C09D")]
    [FieldOffset(Offset = "0x78")]
    private long mKeepCurrentDownloadSize;
    [Token(Token = "0x400C09E")]
    [FieldOffset(Offset = "0x80")]
    private int mCurrentImageIndex;
    [Token(Token = "0x400C09F")]
    [FieldOffset(Offset = "0x84")]
    private List<KeyValuePair<string, string>> mImagePairs;
    [Token(Token = "0x400C0A0")]
    [FieldOffset(Offset = "0x88")]
    private bool mAutoUpdateProgressText;

    [Token(Token = "0x600B611")]
    [Address(RVA = "0x7C90D0", Offset = "0x7C7ED0", VA = "0x107C90D0")]
    public static void SetActiveWindow(bool is_active)
    {
    }

    [Token(Token = "0x600B612")]
    [Address(RVA = "0x7C9000", Offset = "0x7C7E00", VA = "0x107C9000")]
    public static void SetActiveCompleteCount(bool is_active)
    {
    }

    [Token(Token = "0x600B613")]
    [Address(RVA = "0x7C9190", Offset = "0x7C7F90", VA = "0x107C9190")]
    public static void SetAutoUpdateProgressText(bool value)
    {
    }

    [Token(Token = "0x600B614")]
    [Address(RVA = "0x7C88E0", Offset = "0x7C76E0", VA = "0x107C88E0")]
    public static void OpenGenericDownloadWindow(bool autoUpdateProgressText = true)
    {
    }

    [Token(Token = "0x600B615")]
    [Address(RVA = "0x7C8FB0", Offset = "0x7C7DB0", VA = "0x107C8FB0")]
    public static IEnumerator OpenVersusLoadScreenAsync() => (IEnumerator) null;

    [Token(Token = "0x600B616")]
    [Address(RVA = "0x7C8F60", Offset = "0x7C7D60", VA = "0x107C8F60")]
    public static IEnumerator OpenVersusDraftLoadScreenAsync() => (IEnumerator) null;

    [Token(Token = "0x600B617")]
    [Address(RVA = "0x7C8F10", Offset = "0x7C7D10", VA = "0x107C8F10")]
    public static IEnumerator OpenRankMatchLoadScreenAsync() => (IEnumerator) null;

    [Token(Token = "0x600B618")]
    [Address(RVA = "0x7C8C30", Offset = "0x7C7A30", VA = "0x107C8C30")]
    public static void OpenQuestLoadScreen(string title, string lore)
    {
    }

    [Token(Token = "0x600B619")]
    [Address(RVA = "0x7C8620", Offset = "0x7C7420", VA = "0x107C8620")]
    public static IEnumerator LoadAsyncPrefab() => (IEnumerator) null;

    [Token(Token = "0x600B61A")]
    [Address(RVA = "0x7C89F0", Offset = "0x7C77F0", VA = "0x107C89F0")]
    public static void OpenQuestLoadScreen(QuestParam quest)
    {
    }

    [Token(Token = "0x600B61B")]
    [Address(RVA = "0x7C9910", Offset = "0x7C8710", VA = "0x107C9910")]
    public static void SetTexts(string title, string lore)
    {
    }

    [Token(Token = "0x600B61C")]
    [Address(RVA = "0x7C96E0", Offset = "0x7C84E0", VA = "0x107C96E0")]
    public static void SetQuestText(QuestParam quest, string title = null, string lore = null)
    {
    }

    [Token(Token = "0x600B61D")]
    [Address(RVA = "0x7C9290", Offset = "0x7C8090", VA = "0x107C9290")]
    public static void SetLoadProgress(float t)
    {
    }

    [Token(Token = "0x600B61E")]
    [Address(RVA = "0x7C9310", Offset = "0x7C8110", VA = "0x107C9310")]
    public static void SetLoadProgress(float progress, long current, long target)
    {
    }

    [Token(Token = "0x600B61F")]
    [Address(RVA = "0x7C9210", Offset = "0x7C8010", VA = "0x107C9210")]
    public static void SetDestroyDelay(float delay)
    {
    }

    [Token(Token = "0x600B620")]
    [Address(RVA = "0x7C8400", Offset = "0x7C7200", VA = "0x107C8400")]
    public static void Close()
    {
    }

    [Token(Token = "0x600B621")]
    [Address(RVA = "0x7C85C0", Offset = "0x7C73C0", VA = "0x107C85C0")]
    public static bool IsInstance() => new bool();

    [Token(Token = "0x600B622")]
    [Address(RVA = "0x7C9A50", Offset = "0x7C8850", VA = "0x107C9A50")]
    private void Start()
    {
    }

    [Token(Token = "0x600B623")]
    [Address(RVA = "0x7C8860", Offset = "0x7C7660", VA = "0x107C8860")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600B624")]
    [Address(RVA = "0x7C87E0", Offset = "0x7C75E0", VA = "0x107C87E0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x170018F2")]
    public static bool ShouldKeepVisible
    {
      [Token(Token = "0x600B625"), Address(RVA = "0x7CA480", Offset = "0x7C9280", VA = "0x107CA480")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B626")]
    [Address(RVA = "0x7C9DD0", Offset = "0x7C8BD0", VA = "0x107C9DD0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B627")]
    [Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x107C83A0")]
    private IEnumerator AnimationThread() => (IEnumerator) null;

    [Token(Token = "0x600B628")]
    [Address(RVA = "0x7C8670", Offset = "0x7C7470", VA = "0x107C8670")]
    private void LoadImageTable()
    {
    }

    [Token(Token = "0x600B629")]
    [Address(RVA = "0x7CA330", Offset = "0x7C9130", VA = "0x107CA330")]
    public ProgressWindow()
    {
    }

    [Token(Token = "0x2002856")]
    [Serializable]
    public struct ProgressRatio
    {
      [Token(Token = "0x400C0A1")]
      [FieldOffset(Offset = "0x0")]
      [Range(0.0f, 1f)]
      public float Download;
      [Token(Token = "0x400C0A2")]
      [FieldOffset(Offset = "0x4")]
      [Range(0.0f, 1f)]
      public float Deserilize;

      [Token(Token = "0x600B62A")]
      [Address(RVA = "0x7CCB20", Offset = "0x7CB920", VA = "0x107CCB20")]
      public ProgressRatio(float a, float b)
      {
      }
    }
  }
}
