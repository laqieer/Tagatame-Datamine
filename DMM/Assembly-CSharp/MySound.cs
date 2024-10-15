// Decompiled with JetBrains decompiler
// Type: MySound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200025A")]
[AddComponentMenu("/MySound")]
public class MySound : MonoSingleton<MySound>
{
  [Token(Token = "0x4000A02")]
  [FieldOffset(Offset = "0xC")]
  private GameObject mCriAtomGO;
  [Token(Token = "0x4000A03")]
  [FieldOffset(Offset = "0x10")]
  private CriAtom mCriAtom;
  [Token(Token = "0x4000A04")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string SECueSheetName;
  [Token(Token = "0x4000A05")]
  [FieldOffset(Offset = "0x14")]
  private MySound.EClearCacheState mClearCacheState;
  [Token(Token = "0x4000A06")]
  [FieldOffset(Offset = "0x18")]
  private MySound.CueSheetHandle mHandleSE;
  [Token(Token = "0x4000A07")]
  [FieldOffset(Offset = "0x1C")]
  private MySound.BGMManager mBGM;
  [Token(Token = "0x4000A08")]
  [FieldOffset(Offset = "0x20")]
  private MySound.Source mSourceToPlayHandle;
  [Token(Token = "0x4000A09")]
  private const char EVENT_TAG_CB_SEPARATOR = ',';
  [Token(Token = "0x4000A0A")]
  private const int EVENT_TAG_CB_INDEX = 4;
  [Token(Token = "0x4000A0B")]
  [FieldOffset(Offset = "0x4")]
  private static List<MySound.EventTagCb> mEventTagCbList;

  [Token(Token = "0x6000C98")]
  [Address(RVA = "0x10865C0", Offset = "0x10853C0", VA = "0x110865C0")]
  private static string CueName(string cueID, string oldPrefix) => (string) null;

  [Token(Token = "0x6000C99")]
  [Address(RVA = "0x1087840", Offset = "0x1086640", VA = "0x11087840")]
  private static string SECueName(string cueID) => (string) null;

  [Token(Token = "0x6000C9A")]
  [Address(RVA = "0x10862D0", Offset = "0x10850D0", VA = "0x110862D0")]
  private static string BGMCueSheetName(string cueID) => (string) null;

  [Token(Token = "0x6000C9B")]
  [Address(RVA = "0x1086230", Offset = "0x1085030", VA = "0x11086230")]
  private static string BGMCueName(string cueID) => (string) null;

  [Token(Token = "0x6000C9C")]
  [Address(RVA = "0x1086A30", Offset = "0x1085830", VA = "0x11086A30")]
  private static string JingleCueSheetName(string cueID) => (string) null;

  [Token(Token = "0x6000C9D")]
  [Address(RVA = "0x1086990", Offset = "0x1085790", VA = "0x11086990")]
  private static string JingleCueName(string cueID) => (string) null;

  [Token(Token = "0x6000C9E")]
  [Address(RVA = "0x1088040", Offset = "0x1086E40", VA = "0x11088040")]
  private static string VoiceCueSheetName(string charName) => (string) null;

  [Token(Token = "0x6000C9F")]
  [Address(RVA = "0x1087EC0", Offset = "0x1086CC0", VA = "0x11087EC0")]
  public static string[] VoiceCueSheetFileName(string charName) => (string[]) null;

  [Token(Token = "0x6000CA0")]
  [Address(RVA = "0x1086620", Offset = "0x1085420", VA = "0x11086620")]
  public static string[] CueSheetFileName(string sheetName) => (string[]) null;

  [Token(Token = "0x6000CA1")]
  [Address(RVA = "0x10878E0", Offset = "0x10866E0", VA = "0x110878E0")]
  private void Setup()
  {
  }

  [Token(Token = "0x6000CA2")]
  [Address(RVA = "0x1086AD0", Offset = "0x10858D0", VA = "0x11086AD0")]
  public bool LoadSE() => new bool();

  [Token(Token = "0x6000CA3")]
  [Address(RVA = "0x10874C0", Offset = "0x10862C0", VA = "0x110874C0")]
  public void PrepareToClearCache()
  {
  }

  [Token(Token = "0x6000CA4")]
  [Address(RVA = "0x5F0520", Offset = "0x5EF320", VA = "0x105F0520")]
  public bool IsReadyToClearCache() => new bool();

  [Token(Token = "0x6000CA5")]
  [Address(RVA = "0x1087750", Offset = "0x1086550", VA = "0x11087750")]
  public static void RestoreFromClearCache()
  {
  }

  [Token(Token = "0x6000CA6")]
  [Address(RVA = "0x1086730", Offset = "0x1085530", VA = "0x11086730", Slot = "4")]
  protected override void Initialize()
  {
  }

  [Token(Token = "0x6000CA7")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
  protected override void Release()
  {
  }

  [Token(Token = "0x6000CA8")]
  [Address(RVA = "0x1087CB0", Offset = "0x1086AB0", VA = "0x11087CB0")]
  public void UpdateCueSheet()
  {
  }

  [Token(Token = "0x6000CA9")]
  [Address(RVA = "0x1087CF0", Offset = "0x1086AF0", VA = "0x11087CF0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000CAA")]
  [Address(RVA = "0x10873B0", Offset = "0x10861B0", VA = "0x110873B0")]
  public void PlaySEOneShot(string cueID, float delaySec = 0.0f)
  {
  }

  [Token(Token = "0x6000CAB")]
  [Address(RVA = "0x10872A0", Offset = "0x10860A0", VA = "0x110872A0")]
  public void PlaySEOneShotAndroidLowLatency(string cueID, float delaySec = 0.0f)
  {
  }

  [Token(Token = "0x6000CAC")]
  [Address(RVA = "0x1087C60", Offset = "0x1086A60", VA = "0x11087C60")]
  public void StopSEOneShot(float fade)
  {
  }

  [Token(Token = "0x6000CAD")]
  [Address(RVA = "0x1087110", Offset = "0x1085F10", VA = "0x11087110")]
  public MySound.PlayHandle PlaySELoop(string cueID, float delaySec = 0.0f)
  {
    return (MySound.PlayHandle) null;
  }

  [Token(Token = "0x6000CAE")]
  [Address(RVA = "0x10867D0", Offset = "0x10855D0", VA = "0x110867D0")]
  public bool IsLoopSE(string cueID) => new bool();

  [Token(Token = "0x6000CAF")]
  [Address(RVA = "0x10868B0", Offset = "0x10856B0", VA = "0x110868B0")]
  public bool IsPlaying(string cueID) => new bool();

  [Token(Token = "0x6000CB0")]
  [Address(RVA = "0x1086500", Offset = "0x1085300", VA = "0x11086500")]
  public MySound.PlayHandle CreatePlayHandleSE() => (MySound.PlayHandle) null;

  [Token(Token = "0x6000CB1")]
  [Address(RVA = "0x1086CE0", Offset = "0x1085AE0", VA = "0x11086CE0")]
  public void PlayJingle(string cueID, float delaySec = 0.0f, string sheetName = null)
  {
  }

  [Token(Token = "0x6000CB2")]
  [Address(RVA = "0x1087050", Offset = "0x1085E50", VA = "0x11087050")]
  public void PlayOneShot(string sheetName, string cueName, MySound.EType type = MySound.EType.SE, float delaySec = 0.0f)
  {
  }

  [Token(Token = "0x6000CB3")]
  [Address(RVA = "0x1086F70", Offset = "0x1085D70", VA = "0x11086F70")]
  public MySound.PlayHandle PlayLoop(
    string sheetName,
    string cueName,
    MySound.EType type = MySound.EType.SE,
    float delaySec = 0.0f)
  {
    return (MySound.PlayHandle) null;
  }

  [Token(Token = "0x1700017C")]
  public long PlayingBGMTime
  {
    [Token(Token = "0x6000CB4"), Address(RVA = "0x10881A0", Offset = "0x1086FA0", VA = "0x110881A0")] get
    {
      return new long();
    }
  }

  [Token(Token = "0x6000CB5")]
  [Address(RVA = "0x1086C50", Offset = "0x1085A50", VA = "0x11086C50")]
  public void PlayBGM(string cueID, string sheetName = null, bool IsUnManaged = false)
  {
  }

  [Token(Token = "0x6000CB6")]
  [Address(RVA = "0x1086C00", Offset = "0x1085A00", VA = "0x11086C00")]
  public void PlayBGM(string cueID, float delaySec, string sheetName = null)
  {
  }

  [Token(Token = "0x6000CB7")]
  [Address(RVA = "0x1086BB0", Offset = "0x10859B0", VA = "0x11086BB0")]
  public void PlayBGMJukebox(
    string _cue_id,
    string _sheet_name,
    float _wait_sec,
    bool _is_unmanaged)
  {
  }

  [Token(Token = "0x6000CB8")]
  [Address(RVA = "0x1087C00", Offset = "0x1086A00", VA = "0x11087C00")]
  public void StopBGM()
  {
  }

  [Token(Token = "0x6000CB9")]
  [Address(RVA = "0x1087C30", Offset = "0x1086A30", VA = "0x11087C30")]
  public void StopBGM(float sec)
  {
  }

  [Token(Token = "0x6000CBA")]
  [Address(RVA = "0x1087BA0", Offset = "0x10869A0", VA = "0x11087BA0")]
  public bool StopBGMFadeOut(float sec = 1f) => new bool();

  [Token(Token = "0x6000CBB")]
  [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
  public bool CheckCueSheetNames() => new bool();

  [Token(Token = "0x6000CBC")]
  [Address(RVA = "0x1086060", Offset = "0x1084E60", VA = "0x11086060")]
  public static void AddEventTagCallback(CriAtomExSequencer.EventCbFunc func, string tag_name = null)
  {
  }

  [Token(Token = "0x6000CBD")]
  [Address(RVA = "0x10875D0", Offset = "0x10863D0", VA = "0x110875D0")]
  public static void RemoveEventTagCallback(CriAtomExSequencer.EventCbFunc func)
  {
  }

  [Token(Token = "0x6000CBE")]
  [Address(RVA = "0x1086370", Offset = "0x1085170", VA = "0x11086370")]
  private static void Callback(
    ref CriAtomExSequencer.CriAtomExSequenceEventInfo info)
  {
  }

  [Token(Token = "0x6000CBF")]
  [Address(RVA = "0x1088130", Offset = "0x1086F30", VA = "0x11088130")]
  public MySound()
  {
  }

  [Token(Token = "0x6000CC0")]
  [Address(RVA = "0x1088080", Offset = "0x1086E80", VA = "0x11088080")]
  static MySound()
  {
  }

  [Token(Token = "0x200025B")]
  private enum EClearCacheState
  {
    [Token(Token = "0x4000A0D")] NOP,
    [Token(Token = "0x4000A0E")] STOPPING,
    [Token(Token = "0x4000A0F")] FINISH,
    [Token(Token = "0x4000A10")] END,
  }

  [Token(Token = "0x200025C")]
  public enum EType
  {
    [Token(Token = "0x4000A12")] DIRECT = -1, // 0xFFFFFFFF
    [Token(Token = "0x4000A13")] BGM = 0,
    [Token(Token = "0x4000A14")] JINGLE = 1,
    [Token(Token = "0x4000A15")] SE = 2,
    [Token(Token = "0x4000A16")] VOICE = 3,
    [Token(Token = "0x4000A17")] JUKE_BGM = 4,
  }

  [Token(Token = "0x200025D")]
  private class CueIDConverter
  {
    [Token(Token = "0x4000A18")]
    [FieldOffset(Offset = "0x0")]
    private static readonly Dictionary<string, string> sBGM;
    [Token(Token = "0x4000A19")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Dictionary<string, string> sJingle;
    [Token(Token = "0x4000A1A")]
    [FieldOffset(Offset = "0x8")]
    private static readonly Dictionary<string, string> sSE;
    [Token(Token = "0x4000A1B")]
    [FieldOffset(Offset = "0xC")]
    private static readonly Dictionary<string, string> sVoice;

    [Token(Token = "0x6000CC1")]
    [Address(RVA = "0x10768B0", Offset = "0x10756B0", VA = "0x110768B0")]
    public static string Convert(MySound.EType type, string cueID) => (string) null;

    [Token(Token = "0x6000CC2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CueIDConverter()
    {
    }

    [Token(Token = "0x6000CC3")]
    [Address(RVA = "0x1076C10", Offset = "0x1075A10", VA = "0x11076C10")]
    static CueIDConverter()
    {
    }
  }

  [Token(Token = "0x200025E")]
  private class CueSheet
  {
    [Token(Token = "0x4000A1C")]
    [FieldOffset(Offset = "0x0")]
    private static List<MySound.CueSheet> sCueSheets;
    [Token(Token = "0x4000A1D")]
    [FieldOffset(Offset = "0x4")]
    private static List<MySound.CueSheet> sDelCueSheets;
    [Token(Token = "0x4000A1E")]
    [FieldOffset(Offset = "0x8")]
    private CriAtomCueSheet mSheet;
    [Token(Token = "0x4000A1F")]
    [FieldOffset(Offset = "0xC")]
    private int refCount;
    [Token(Token = "0x4000A20")]
    [FieldOffset(Offset = "0x10")]
    private List<MySound.Source> mSrcList;
    [Token(Token = "0x4000A21")]
    [FieldOffset(Offset = "0x14")]
    private List<MySound.Source> mDelSrcList;
    [Token(Token = "0x4000A22")]
    [FieldOffset(Offset = "0x18")]
    private MySound.CueSheet.EState mState;

    [Token(Token = "0x1700017D")]
    private string name
    {
      [Token(Token = "0x6000CC4"), Address(RVA = "0x90C400", Offset = "0x90B200", VA = "0x1090C400")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6000CC5")]
    [Address(RVA = "0x1079700", Offset = "0x1078500", VA = "0x11079700")]
    private CueSheet()
    {
    }

    [Token(Token = "0x6000CC6")]
    [Address(RVA = "0x10785B0", Offset = "0x10773B0", VA = "0x110785B0")]
    public static bool Load(
      string sheetName,
      bool useAcb = true,
      bool useAwb = true,
      bool loadAsync = false,
      bool isUnManaged = false)
    {
      return new bool();
    }

    [Token(Token = "0x6000CC7")]
    [Address(RVA = "0x1078520", Offset = "0x1077320", VA = "0x11078520")]
    private IEnumerator LoadCueSheetCore(
      string sheetName,
      bool useAcb,
      bool useAwb,
      bool isUnManaged)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6000CC8")]
    [Address(RVA = "0x1078120", Offset = "0x1076F20", VA = "0x11078120")]
    private static bool IsSheetValid(string sheetName) => new bool();

    [Token(Token = "0x6000CC9")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private static void CheckSheet(string sheetName)
    {
    }

    [Token(Token = "0x6000CCA")]
    [Address(RVA = "0x1078EA0", Offset = "0x1077CA0", VA = "0x11078EA0")]
    public static void Unload(string sheetName)
    {
    }

    [Token(Token = "0x6000CCB")]
    [Address(RVA = "0x1078020", Offset = "0x1076E20", VA = "0x11078020")]
    public static bool IsReady(string sheetName) => new bool();

    [Token(Token = "0x6000CCC")]
    [Address(RVA = "0x1077730", Offset = "0x1076530", VA = "0x11077730")]
    public static MySound.Source CreateSource(
      string sheetName,
      string srcName,
      bool useAndroidLowLatencyMode,
      MySound.EType type)
    {
      return (MySound.Source) null;
    }

    [Token(Token = "0x6000CCD")]
    [Address(RVA = "0x1077C40", Offset = "0x1076A40", VA = "0x11077C40")]
    public static bool IsLoop(string sheetName, string cueName) => new bool();

    [Token(Token = "0x6000CCE")]
    [Address(RVA = "0x1079360", Offset = "0x1078160", VA = "0x11079360")]
    private void Update()
    {
    }

    [Token(Token = "0x1700017E")]
    private bool IsReadyToRemove
    {
      [Token(Token = "0x6000CCF"), Address(RVA = "0x10797A0", Offset = "0x10785A0", VA = "0x110797A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6000CD0")]
    [Address(RVA = "0x1078FB0", Offset = "0x1077DB0", VA = "0x11078FB0")]
    public static void UpdateAll()
    {
    }

    [Token(Token = "0x6000CD1")]
    [Address(RVA = "0x1078B10", Offset = "0x1077910", VA = "0x11078B10")]
    private void PrepareToClearCache(float sec)
    {
    }

    [Token(Token = "0x6000CD2")]
    [Address(RVA = "0x10789B0", Offset = "0x10777B0", VA = "0x110789B0")]
    public static void PrepareToClearCacheAll(float sec)
    {
    }

    [Token(Token = "0x6000CD3")]
    [Address(RVA = "0x10783C0", Offset = "0x10771C0", VA = "0x110783C0")]
    private bool IsStoppedForClearCache() => new bool();

    [Token(Token = "0x6000CD4")]
    [Address(RVA = "0x1078240", Offset = "0x1077040", VA = "0x11078240")]
    public static bool IsStoppedAllForClearCache() => new bool();

    [Token(Token = "0x6000CD5")]
    [Address(RVA = "0x1077BE0", Offset = "0x10769E0", VA = "0x11077BE0")]
    public static int GetLoadedNum() => new int();

    [Token(Token = "0x6000CD6")]
    [Address(RVA = "0x1077DB0", Offset = "0x1076BB0", VA = "0x11077DB0")]
    private bool IsPlaying() => new bool();

    [Token(Token = "0x6000CD7")]
    [Address(RVA = "0x1077F10", Offset = "0x1076D10", VA = "0x11077F10")]
    public static bool IsPlaying(string sheetName) => new bool();

    [Token(Token = "0x6000CD8")]
    [Address(RVA = "0x1078D60", Offset = "0x1077B60", VA = "0x11078D60")]
    private void Stop(float sec, bool fadeOutTemporary)
    {
    }

    [Token(Token = "0x6000CD9")]
    [Address(RVA = "0x1078C50", Offset = "0x1077A50", VA = "0x11078C50")]
    public static void StopAll(string sheetName, float sec, bool fadeOutTemporary = false)
    {
    }

    [Token(Token = "0x6000CDA")]
    [Address(RVA = "0x1077AD0", Offset = "0x10768D0", VA = "0x11077AD0")]
    public static CriAtomExAcb FindAcb(string sheetName) => (CriAtomExAcb) null;

    [Token(Token = "0x6000CDB")]
    [Address(RVA = "0x1079640", Offset = "0x1078440", VA = "0x11079640")]
    static CueSheet()
    {
    }

    [Token(Token = "0x200025F")]
    private enum EState
    {
      [Token(Token = "0x4000A24")] NOP,
      [Token(Token = "0x4000A25")] LOADING,
      [Token(Token = "0x4000A26")] READY,
    }
  }

  [Token(Token = "0x200026A")]
  public class CueSheetHandle
  {
    [Token(Token = "0x4000A37")]
    [FieldOffset(Offset = "0x8")]
    private string mSheetName;
    [Token(Token = "0x4000A38")]
    [FieldOffset(Offset = "0xC")]
    private MySound.EType mType;
    [Token(Token = "0x4000A39")]
    [FieldOffset(Offset = "0x10")]
    private MySound.Source mDefaultOneShot;
    [Token(Token = "0x4000A3A")]
    [FieldOffset(Offset = "0x14")]
    private MySound.Source mDefaultOneShotAndroidLowLatency;

    [Token(Token = "0x17000181")]
    public bool IsReady
    {
      [Token(Token = "0x6000CF4"), Address(RVA = "0x10776E0", Offset = "0x10764E0", VA = "0x110776E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6000CF5")]
    [Address(RVA = "0x10771A0", Offset = "0x1075FA0", VA = "0x110771A0")]
    public static MySound.CueSheetHandle Create(
      string sheetName,
      MySound.EType type,
      bool useAcb = true,
      bool useAwb = true,
      bool loadAsync = false,
      bool isUnManaged = false)
    {
      return (MySound.CueSheetHandle) null;
    }

    [Token(Token = "0x6000CF6")]
    [Address(RVA = "0x1077300", Offset = "0x1076100", VA = "0x11077300")]
    public bool GetCueInfo(string cue_id, ref CriAtomEx.CueInfo info) => new bool();

    [Token(Token = "0x6000CF7")]
    [Address(RVA = "0x1076ED0", Offset = "0x1075CD0", VA = "0x11076ED0")]
    public void CreateDefaultOneShotSource()
    {
    }

    [Token(Token = "0x6000CF8")]
    [Address(RVA = "0x1077110", Offset = "0x1075F10", VA = "0x11077110")]
    private MySound.Source CreateSource(
      string srcName,
      bool androidLatency,
      MySound.EType type,
      MySound.CueSheetHandle.ELoopFlag loop)
    {
      return (MySound.Source) null;
    }

    [Token(Token = "0x6000CF9")]
    [Address(RVA = "0x1077520", Offset = "0x1076320", VA = "0x11077520")]
    public void PlayDefaultOneShot(
      string cueName,
      bool androidLowLatency,
      float delaySec = 0.0f,
      bool is_stopplay = false)
    {
    }

    [Token(Token = "0x6000CFA")]
    [Address(RVA = "0x1077600", Offset = "0x1076400", VA = "0x11077600")]
    public void StopDefaultAll(float sec)
    {
    }

    [Token(Token = "0x6000CFB")]
    [Address(RVA = "0x1077570", Offset = "0x1076370", VA = "0x11077570")]
    public MySound.PlayHandle Play(
      string cueName,
      MySound.CueSheetHandle.ELoopFlag loop,
      bool useHandle,
      float delaySec = 0.0f)
    {
      return (MySound.PlayHandle) null;
    }

    [Token(Token = "0x6000CFC")]
    [Address(RVA = "0x1077010", Offset = "0x1075E10", VA = "0x11077010")]
    private MySound.PlayHandle CreatePlayHandleCore(MySound.Source src)
    {
      return (MySound.PlayHandle) null;
    }

    [Token(Token = "0x6000CFD")]
    [Address(RVA = "0x10770B0", Offset = "0x1075EB0", VA = "0x110770B0")]
    public MySound.PlayHandle CreatePlayHandle(MySound.CueSheetHandle.ELoopFlag loop)
    {
      return (MySound.PlayHandle) null;
    }

    [Token(Token = "0x6000CFE")]
    [Address(RVA = "0x1077380", Offset = "0x1076180", VA = "0x11077380")]
    public bool IsLoop(string cueName) => new bool();

    [Token(Token = "0x6000CFF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private CueSheetHandle()
    {
    }

    [Token(Token = "0x6000D00")]
    [Address(RVA = "0x1077260", Offset = "0x1076060", VA = "0x11077260", Slot = "1")]
    ~CueSheetHandle()
    {
    }

    [Token(Token = "0x6000D01")]
    [Address(RVA = "0x1076D50", Offset = "0x1075B50", VA = "0x11076D50")]
    public void Cleanup()
    {
    }

    [Token(Token = "0x17000182")]
    public bool IsDefaultOneShotPlaying
    {
      [Token(Token = "0x6000D02"), Address(RVA = "0x10776A0", Offset = "0x10764A0", VA = "0x110776A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000183")]
    public bool IsCueSheetPlaying
    {
      [Token(Token = "0x6000D03"), Address(RVA = "0x1077650", Offset = "0x1076450", VA = "0x11077650")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x200026B")]
    public enum ELoopFlag
    {
      [Token(Token = "0x4000A3C")] DEFAULT,
      [Token(Token = "0x4000A3D")] NOT_LOOP,
      [Token(Token = "0x4000A3E")] LOOP,
    }
  }

  [Token(Token = "0x200026C")]
  private class BGMManager
  {
    [Token(Token = "0x4000A3F")]
    [FieldOffset(Offset = "0x8")]
    private MySound.PlayHandle mCurrent;
    [Token(Token = "0x4000A42")]
    [FieldOffset(Offset = "0x14")]
    private float mTimer;
    [Token(Token = "0x4000A43")]
    [FieldOffset(Offset = "0x18")]
    private float mWaitSec;
    [Token(Token = "0x4000A44")]
    [FieldOffset(Offset = "0x1C")]
    private MySound.CueSheetHandle mNextHandle;
    [Token(Token = "0x4000A45")]
    [FieldOffset(Offset = "0x20")]
    private MySound.CueSheetHandle mCurrentHandle;

    [Token(Token = "0x17000184")]
    public string CurrentCueID
    {
      [Token(Token = "0x6000D04"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6000D05"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000185")]
    public string NextCueID
    {
      [Token(Token = "0x6000D06"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6000D07"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x6000D08")]
    [Address(RVA = "0x1075B60", Offset = "0x1074960", VA = "0x11075B60")]
    public void Cleanup()
    {
    }

    [Token(Token = "0x17000186")]
    public long CurrentTime
    {
      [Token(Token = "0x6000D09"), Address(RVA = "0x1076230", Offset = "0x1075030", VA = "0x11076230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6000D0A")]
    [Address(RVA = "0x1075BF0", Offset = "0x10749F0", VA = "0x11075BF0")]
    public void Play(
      string cueID,
      float waitSec,
      string sheetName = null,
      bool IsUnManaged = false,
      bool IsJuke = false)
    {
    }

    [Token(Token = "0x6000D0B")]
    [Address(RVA = "0x1075E70", Offset = "0x1074C70", VA = "0x11075E70")]
    public bool Stop(float fadeSec) => new bool();

    [Token(Token = "0x6000D0C")]
    [Address(RVA = "0x1075ED0", Offset = "0x1074CD0", VA = "0x11075ED0")]
    public void Update()
    {
    }

    [Token(Token = "0x6000D0D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BGMManager()
    {
    }
  }

  [Token(Token = "0x200026D")]
  public class Voice
  {
    [Token(Token = "0x4000A47")]
    [FieldOffset(Offset = "0xC")]
    private string mCueNamePrefix;
    [Token(Token = "0x4000A48")]
    [FieldOffset(Offset = "0x10")]
    private MySound.CueSheetHandle mHandle;

    [Token(Token = "0x17000187")]
    public string CharName
    {
      [Token(Token = "0x6000D0E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6000D0F"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000188")]
    public string SheetName
    {
      [Token(Token = "0x6000D10"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6000D11"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x6000D12")]
    [Address(RVA = "0x108BBF0", Offset = "0x108A9F0", VA = "0x1108BBF0")]
    public Voice(string sheetName, string charName, string cueNamePrefix, bool isUnManaged = false)
    {
    }

    [Token(Token = "0x6000D13")]
    [Address(RVA = "0x108BAE0", Offset = "0x108A8E0", VA = "0x1108BAE0")]
    public Voice(string charName, string cue_name_prefix = null)
    {
    }

    [Token(Token = "0x6000D14")]
    [Address(RVA = "0x108B8A0", Offset = "0x108A6A0", VA = "0x1108B8A0")]
    private void Setup(string sheetName, string cueNamePrefix, bool isUnManaged = false)
    {
    }

    [Token(Token = "0x6000D15")]
    [Address(RVA = "0x108B760", Offset = "0x108A560", VA = "0x1108B760")]
    public void Play(string cueID, float delaySec = 0.0f, bool is_stopplay = false)
    {
    }

    [Token(Token = "0x6000D16")]
    [Address(RVA = "0x108B830", Offset = "0x108A630", VA = "0x1108B830")]
    public static string ReplaceCharNameOfCueName(string cueName, string charName) => (string) null;

    [Token(Token = "0x6000D17")]
    [Address(RVA = "0x108B690", Offset = "0x108A490", VA = "0x1108B690")]
    public void PlayDirect(string cueID, float delaySec = 0.0f)
    {
    }

    [Token(Token = "0x6000D18")]
    [Address(RVA = "0x108B900", Offset = "0x108A700", VA = "0x1108B900")]
    public void StopAll(float sec = 1f)
    {
    }

    [Token(Token = "0x6000D19")]
    [Address(RVA = "0x108B950", Offset = "0x108A750", VA = "0x1108B950")]
    public static void StopAll(string charName, float sec, bool fadeOutTemporary = false)
    {
    }

    [Token(Token = "0x17000189")]
    public bool IsPlaying
    {
      [Token(Token = "0x6000D1A"), Address(RVA = "0x108BCD0", Offset = "0x108AAD0", VA = "0x1108BCD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6000D1B")]
    [Address(RVA = "0x108B5F0", Offset = "0x108A3F0", VA = "0x1108B5F0")]
    public static bool IsCueSheetPlaying(string charName) => new bool();

    [Token(Token = "0x6000D1C")]
    [Address(RVA = "0x108B480", Offset = "0x108A280", VA = "0x1108B480")]
    public void Cleanup()
    {
    }

    [Token(Token = "0x6000D1D")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
    public bool CheckCueIDs() => new bool();

    [Token(Token = "0x6000D1E")]
    [Address(RVA = "0x108B4A0", Offset = "0x108A2A0", VA = "0x1108B4A0")]
    public CriAtomExAcb FindAcb(string sheetName) => (CriAtomExAcb) null;
  }

  [Token(Token = "0x200026E")]
  private class VolumeManager
  {
    [Token(Token = "0x4000A4A")]
    [FieldOffset(Offset = "0x8")]
    private MySound.EType mType;
    [Token(Token = "0x4000A4B")]
    [FieldOffset(Offset = "0x0")]
    private static List<MySound.VolumeManager> sInstanceList;
    [Token(Token = "0x4000A4C")]
    [FieldOffset(Offset = "0xC")]
    private bool mDiscarded;
    [Token(Token = "0x4000A4D")]
    [FieldOffset(Offset = "0x10")]
    private float mVolumeTgt;
    [Token(Token = "0x4000A4E")]
    [FieldOffset(Offset = "0x14")]
    private float mVolumeStart;
    [Token(Token = "0x4000A4F")]
    [FieldOffset(Offset = "0x18")]
    private float mInterpSec;
    [Token(Token = "0x4000A50")]
    [FieldOffset(Offset = "0x1C")]
    private float mPastSec;
    [Token(Token = "0x4000A51")]
    [FieldOffset(Offset = "0x20")]
    private bool mDiscardAtEnd;

    [Token(Token = "0x6000D1F")]
    [Address(RVA = "0x108C2C0", Offset = "0x108B0C0", VA = "0x1108C2C0")]
    public VolumeManager(MySound.EType type)
    {
    }

    [Token(Token = "0x6000D20")]
    [Address(RVA = "0x2E2F20", Offset = "0x2E1D20", VA = "0x102E2F20")]
    public void Discard()
    {
    }

    [Token(Token = "0x1700018A")]
    public float Volume
    {
      [Token(Token = "0x6000D21"), Address(RVA = "0x108C350", Offset = "0x108B150", VA = "0x1108C350")] get
      {
        return new float();
      }
      [Token(Token = "0x6000D22"), Address(RVA = "0x108C3A0", Offset = "0x108B1A0", VA = "0x1108C3A0")] set
      {
      }
    }

    [Token(Token = "0x6000D23")]
    [Address(RVA = "0x108BEE0", Offset = "0x108ACE0", VA = "0x1108BEE0")]
    public void SetVolume(float volume, float sec, bool discardAtEnd = false)
    {
    }

    [Token(Token = "0x6000D24")]
    [Address(RVA = "0x108C1E0", Offset = "0x108AFE0", VA = "0x1108C1E0")]
    public void Update()
    {
    }

    [Token(Token = "0x6000D25")]
    [Address(RVA = "0x108BF50", Offset = "0x108AD50", VA = "0x1108BF50")]
    public static void UpdateAll()
    {
    }

    [Token(Token = "0x6000D26")]
    [Address(RVA = "0x108BD20", Offset = "0x108AB20", VA = "0x1108BD20")]
    public static float GetVolume(MySound.EType type) => new float();

    [Token(Token = "0x6000D27")]
    [Address(RVA = "0x108C240", Offset = "0x108B040", VA = "0x1108C240")]
    static VolumeManager()
    {
    }
  }

  [Token(Token = "0x2000270")]
  public class VolumeHandle
  {
    [Token(Token = "0x4000A54")]
    [FieldOffset(Offset = "0x8")]
    private MySound.VolumeManager mMng;

    [Token(Token = "0x1700018B")]
    public float DiscardAtEndSec
    {
      [Token(Token = "0x6000D2B"), Address(RVA = "0x2CD6E0", Offset = "0x2CC4E0", VA = "0x102CD6E0")] get
      {
        return new float();
      }
      [Token(Token = "0x6000D2C"), Address(RVA = "0xB24FB0", Offset = "0xB23DB0", VA = "0x10B24FB0")] set
      {
      }
    }

    [Token(Token = "0x6000D2D")]
    [Address(RVA = "0x11DCA60", Offset = "0x11DB860", VA = "0x111DCA60")]
    public VolumeHandle(MySound.EType type)
    {
    }

    [Token(Token = "0x6000D2E")]
    [Address(RVA = "0x11DC950", Offset = "0x11DB750", VA = "0x111DC950", Slot = "1")]
    ~VolumeHandle()
    {
    }

    [Token(Token = "0x6000D2F")]
    [Address(RVA = "0x11DC900", Offset = "0x11DB700", VA = "0x111DC900")]
    public void Discard()
    {
    }

    [Token(Token = "0x6000D30")]
    [Address(RVA = "0x11DCA20", Offset = "0x11DB820", VA = "0x111DCA20")]
    public void SetVolume(float volume, float sec)
    {
    }
  }

  [Token(Token = "0x2000271")]
  private class Source
  {
    [Token(Token = "0x4000A56")]
    [FieldOffset(Offset = "0x8")]
    private CriAtomSource mCore;
    [Token(Token = "0x4000A57")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4000A58")]
    [FieldOffset(Offset = "0x10")]
    private MySound.EType mType;
    [Token(Token = "0x4000A59")]
    [FieldOffset(Offset = "0x14")]
    private bool mFadeOutStop;
    [Token(Token = "0x4000A5A")]
    [FieldOffset(Offset = "0x15")]
    private bool mFadeOutStopIsTemporary;
    [Token(Token = "0x4000A5B")]
    [FieldOffset(Offset = "0x18")]
    private float mFadeOutSec;
    [Token(Token = "0x4000A5C")]
    [FieldOffset(Offset = "0x1C")]
    private float mTimer;
    [Token(Token = "0x4000A5D")]
    [FieldOffset(Offset = "0x20")]
    private string mDelayCueName;
    [Token(Token = "0x4000A5E")]
    [FieldOffset(Offset = "0x24")]
    private float mDelaySec;

    [Token(Token = "0x1700018C")]
    public string name
    {
      [Token(Token = "0x6000D31"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700018D")]
    public float Pitch
    {
      [Token(Token = "0x6000D32"), Address(RVA = "0x11D9F60", Offset = "0x11D8D60", VA = "0x111D9F60")] get
      {
        return new float();
      }
      [Token(Token = "0x6000D33"), Address(RVA = "0x11D9FD0", Offset = "0x11D8DD0", VA = "0x111D9FD0")] set
      {
      }
    }

    [Token(Token = "0x1700018E")]
    public long CurrentTime
    {
      [Token(Token = "0x6000D34"), Address(RVA = "0x11D9CF0", Offset = "0x11D8AF0", VA = "0x111D9CF0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6000D35")]
    [Address(RVA = "0x11D9540", Offset = "0x11D8340", VA = "0x111D9540")]
    private float GetTypeVolume() => new float();

    [Token(Token = "0x6000D36")]
    [Address(RVA = "0x11D98D0", Offset = "0x11D86D0", VA = "0x111D98D0")]
    public bool Setup(
      string sheetName,
      string srcName,
      bool androidLowLatency,
      MySound.EType type)
    {
      return new bool();
    }

    [Token(Token = "0x6000D37")]
    [Address(RVA = "0x11D9430", Offset = "0x11D8230", VA = "0x111D9430")]
    public void Cleanup()
    {
    }

    [Token(Token = "0x1700018F")]
    public bool KeepInstance
    {
      [Token(Token = "0x6000D38"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
      [Token(Token = "0x6000D39"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] set
      {
      }
    }

    [Token(Token = "0x17000190")]
    public bool IsReadyToRemove
    {
      [Token(Token = "0x6000D3A"), Address(RVA = "0x11D9E10", Offset = "0x11D8C10", VA = "0x111D9E10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000191")]
    public bool IsPlaying
    {
      [Token(Token = "0x6000D3B"), Address(RVA = "0x11D9D70", Offset = "0x11D8B70", VA = "0x111D9D70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6000D3C")]
    [Address(RVA = "0x11D9B20", Offset = "0x11D8920", VA = "0x111D9B20")]
    public void Update()
    {
    }

    [Token(Token = "0x6000D3D")]
    [Address(RVA = "0x11D9670", Offset = "0x11D8470", VA = "0x111D9670")]
    public void Play(string cueName, bool is_stopplay = false)
    {
    }

    [Token(Token = "0x6000D3E")]
    [Address(RVA = "0x11D94E0", Offset = "0x11D82E0", VA = "0x111D94E0")]
    public void DelayPlay(string cueName, float sec)
    {
    }

    [Token(Token = "0x6000D3F")]
    [Address(RVA = "0x11D9860", Offset = "0x11D8660", VA = "0x111D9860")]
    public void SetLoop(bool flag)
    {
    }

    [Token(Token = "0x6000D40")]
    [Address(RVA = "0x11D9510", Offset = "0x11D8310", VA = "0x111D9510")]
    public void FadeOutStop(float sec, bool temporaryFadeOut = false)
    {
    }

    [Token(Token = "0x6000D41")]
    [Address(RVA = "0x11D9CA0", Offset = "0x11D8AA0", VA = "0x111D9CA0")]
    public Source()
    {
    }
  }

  [Token(Token = "0x2000272")]
  public class PlayHandle
  {
    [Token(Token = "0x4000A60")]
    [FieldOffset(Offset = "0x8")]
    private MySound.Source mSrc;
    [Token(Token = "0x4000A61")]
    [FieldOffset(Offset = "0x0")]
    public static readonly float HALF_PITCH;

    [Token(Token = "0x17000192")]
    public float Pitch
    {
      [Token(Token = "0x6000D42"), Address(RVA = "0x11D6070", Offset = "0x11D4E70", VA = "0x111D6070")] get
      {
        return new float();
      }
      [Token(Token = "0x6000D43"), Address(RVA = "0x11D6120", Offset = "0x11D4F20", VA = "0x111D6120")] set
      {
      }
    }

    [Token(Token = "0x17000193")]
    public long CurrentTime
    {
      [Token(Token = "0x6000D44"), Address(RVA = "0x11D5FD0", Offset = "0x11D4DD0", VA = "0x111D5FD0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6000D45")]
    [Address(RVA = "0x11D5DD0", Offset = "0x11D4BD0", VA = "0x111D5DD0")]
    public static MySound.PlayHandle Create() => (MySound.PlayHandle) null;

    [Token(Token = "0x6000D46")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    private PlayHandle(MySound.Source src)
    {
    }

    [Token(Token = "0x6000D47")]
    [Address(RVA = "0x11D5E70", Offset = "0x11D4C70", VA = "0x111D5E70", Slot = "1")]
    ~PlayHandle()
    {
    }

    [Token(Token = "0x17000194")]
    public bool KeepInstance
    {
      [Token(Token = "0x6000D48"), Address(RVA = "0x11D6050", Offset = "0x11D4E50", VA = "0x111D6050")] get
      {
        return new bool();
      }
      [Token(Token = "0x6000D49"), Address(RVA = "0x11D6100", Offset = "0x11D4F00", VA = "0x111D6100")] set
      {
      }
    }

    [Token(Token = "0x6000D4A")]
    [Address(RVA = "0x11D5F40", Offset = "0x11D4D40", VA = "0x111D5F40")]
    public void Play(string cueName)
    {
    }

    [Token(Token = "0x6000D4B")]
    [Address(RVA = "0x11D5F60", Offset = "0x11D4D60", VA = "0x111D5F60")]
    public void Stop(float sec)
    {
    }

    [Token(Token = "0x6000D4C")]
    [Address(RVA = "0x11D5FA0", Offset = "0x11D4DA0", VA = "0x111D5FA0")]
    static PlayHandle()
    {
    }
  }

  [Token(Token = "0x2000273")]
  private class EventTagCb
  {
    [Token(Token = "0x4000A62")]
    [FieldOffset(Offset = "0x8")]
    public CriAtomExSequencer.EventCbFunc mFunc;
    [Token(Token = "0x4000A63")]
    [FieldOffset(Offset = "0xC")]
    public string mTagName;

    [Token(Token = "0x6000D4D")]
    [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
    public EventTagCb(CriAtomExSequencer.EventCbFunc func, string tag_name)
    {
    }
  }
}
