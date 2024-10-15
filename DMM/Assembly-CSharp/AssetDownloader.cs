// Decompiled with JetBrains decompiler
// Type: AssetDownloader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;

#nullable disable
[Token(Token = "0x2000044")]
[AddComponentMenu("Common/AssetDownloader")]
public class AssetDownloader : MonoBehaviour
{
  [Token(Token = "0x4000150")]
  [FieldOffset(Offset = "0x0")]
  public static string DownloadURL;
  [Token(Token = "0x4000151")]
  [FieldOffset(Offset = "0x4")]
  public static string StreamingURL;
  [Token(Token = "0x4000152")]
  [FieldOffset(Offset = "0x8")]
  public static string ExDownloadURL;
  [Token(Token = "0x4000153")]
  public const string FileListName = "ASSETS";
  [Token(Token = "0x4000154")]
  [FieldOffset(Offset = "0xC")]
  public readonly string FileAssetListName;
  [Token(Token = "0x4000155")]
  [FieldOffset(Offset = "0x10")]
  public readonly string FileExistName;
  [Token(Token = "0x4000156")]
  [FieldOffset(Offset = "0x14")]
  public readonly string FileUnManagedExistName;
  [Token(Token = "0x4000157")]
  [FieldOffset(Offset = "0x18")]
  public readonly string FileUnManagedAssetListName;
  [Token(Token = "0x4000158")]
  [FieldOffset(Offset = "0x1C")]
  public readonly int SaveExistFileSize;
  [Token(Token = "0x4000159")]
  [FieldOffset(Offset = "0x20")]
  public readonly int SaveExistFileNum;
  [Token(Token = "0x400015A")]
  private const string MetaExt = ".meta";
  [Token(Token = "0x400015B")]
  [FieldOffset(Offset = "0xC")]
  private static AssetDownloader mInstance;
  [Token(Token = "0x400015C")]
  [FieldOffset(Offset = "0x10")]
  private static List<string> mRequestIDs;
  [Token(Token = "0x400015D")]
  [FieldOffset(Offset = "0x14")]
  private static List<string> mRequestUnmanagedAssets;
  [Token(Token = "0x400015E")]
  [FieldOffset(Offset = "0x18")]
  private static Dictionary<string, AssetList.Item> mRequestItems;
  [Token(Token = "0x400015F")]
  [FieldOffset(Offset = "0x1C")]
  private static Dictionary<string, UnManagedAssetList.Item> mRequestUnmanagedItems;
  [Token(Token = "0x4000160")]
  [FieldOffset(Offset = "0x24")]
  private Dictionary<string, int> itemCompressedSize;
  [Token(Token = "0x4000161")]
  [FieldOffset(Offset = "0x20")]
  private static Coroutine mCoroutine;
  [Token(Token = "0x4000162")]
  [FieldOffset(Offset = "0x24")]
  private static bool mHasError;
  [Token(Token = "0x4000163")]
  [FieldOffset(Offset = "0x25")]
  private static bool mRetryOnError;
  [Token(Token = "0x4000164")]
  [FieldOffset(Offset = "0x28")]
  private static float mDownloadProgress;
  [Token(Token = "0x4000165")]
  [FieldOffset(Offset = "0x30")]
  private static long totalDownloadSize;
  [Token(Token = "0x4000166")]
  [FieldOffset(Offset = "0x38")]
  private static long currentDownloadSize;
  [Token(Token = "0x4000167")]
  [FieldOffset(Offset = "0x40")]
  private static long downloadedSize;
  [Token(Token = "0x4000168")]
  [FieldOffset(Offset = "0x48")]
  private static float mUnManagedDownloadProgress;
  [Token(Token = "0x4000169")]
  [FieldOffset(Offset = "0x50")]
  private static long mUnManagedTotalDownloadSize;
  [Token(Token = "0x400016A")]
  [FieldOffset(Offset = "0x58")]
  private static long mUnManagedCurrentDownloadSize;
  [Token(Token = "0x400016B")]
  [FieldOffset(Offset = "0x60")]
  private static long mUnManagedDownloadedSize;
  [Token(Token = "0x400016C")]
  public const int maxRetryCount = 5;
  [Token(Token = "0x400016D")]
  public const int SIZE_MB = 1048576;
  [Token(Token = "0x400016E")]
  [FieldOffset(Offset = "0x28")]
  private float[] mSpeedHistory;
  [Token(Token = "0x400016F")]
  [FieldOffset(Offset = "0x2C")]
  private int mSpeedHistorySize;
  [Token(Token = "0x4000170")]
  [FieldOffset(Offset = "0x30")]
  private int mSpeedHistoryPos;
  [Token(Token = "0x4000171")]
  [FieldOffset(Offset = "0x68")]
  private static float mAverageDownloadSpeed;
  [Token(Token = "0x4000172")]
  [FieldOffset(Offset = "0x34")]
  private Thread mUnzipThread;
  [Token(Token = "0x4000173")]
  [FieldOffset(Offset = "0x38")]
  private Mutex mMutex;
  [Token(Token = "0x4000174")]
  [FieldOffset(Offset = "0x3C")]
  private AutoResetEvent mUnzipSignal;
  [Token(Token = "0x4000175")]
  [FieldOffset(Offset = "0x40")]
  private bool mMutexAcquired;
  [Token(Token = "0x4000176")]
  [FieldOffset(Offset = "0x41")]
  private bool mShuttingDown;
  [Token(Token = "0x4000177")]
  [FieldOffset(Offset = "0x44")]
  private List<AssetDownloader.UnzipJob> mUnzipJobs;
  [Token(Token = "0x4000178")]
  [FieldOffset(Offset = "0x48")]
  private AssetDownloader.UnzipThread2Arg mUnzipThreadArg;
  [Token(Token = "0x4000179")]
  [FieldOffset(Offset = "0x4C")]
  private Thread mCompareHashThread;
  [Token(Token = "0x400017A")]
  [FieldOffset(Offset = "0x50")]
  private Mutex mCompareHashMutex;
  [Token(Token = "0x400017B")]
  [FieldOffset(Offset = "0x54")]
  private float mCompareHashProgressShared;
  [Token(Token = "0x400017C")]
  [FieldOffset(Offset = "0x6C")]
  private static float mCompareHashProgress;
  [Token(Token = "0x400017D")]
  private const int FileSizeRequestLimit = 10;
  [Token(Token = "0x400017E")]
  private const int ConnectionSteamLimit = 10;
  [Token(Token = "0x400017F")]
  public const int LimitDownloadSize = 5242880;
  [Token(Token = "0x4000180")]
  [FieldOffset(Offset = "0x70")]
  public static long UnZipFileSize;
  [Token(Token = "0x4000181")]
  private const int UnZipRequestJobCapacity = 10;
  [Token(Token = "0x4000182")]
  [FieldOffset(Offset = "0x58")]
  private DownloadObserver mDownloadObserver;
  [Token(Token = "0x4000183")]
  [FieldOffset(Offset = "0x5C")]
  public int mExistFileDownloadSize;
  [Token(Token = "0x4000184")]
  [FieldOffset(Offset = "0x60")]
  public int mExistFileDownloadCount;
  [Token(Token = "0x4000185")]
  [FieldOffset(Offset = "0x78")]
  public static List<AssetDownloader.ExistAssetList> mExistFile;
  [Token(Token = "0x4000186")]
  [FieldOffset(Offset = "0x7C")]
  public static string mExitFilePath;
  [Token(Token = "0x4000187")]
  [FieldOffset(Offset = "0x80")]
  public static List<string> mUnmanagedExistFile;
  [Token(Token = "0x4000188")]
  [FieldOffset(Offset = "0x64")]
  private Coroutine m_LowMemoryCoroutine;
  [Token(Token = "0x4000189")]
  [FieldOffset(Offset = "0x84")]
  private static AssetDownloader.DownloadPhases mPhase;
  [Token(Token = "0x400018A")]
  [FieldOffset(Offset = "0x68")]
  private bool mIsUnzipNow;
  [Token(Token = "0x400018B")]
  [FieldOffset(Offset = "0x6C")]
  private string mLog;
  [Token(Token = "0x400018C")]
  [FieldOffset(Offset = "0x88")]
  public static bool BatchDownload;
  [Token(Token = "0x400018D")]
  [FieldOffset(Offset = "0x70")]
  private bool mWWWError;
  [Token(Token = "0x400018E")]
  [FieldOffset(Offset = "0x8C")]
  private static string mCachePath;
  [Token(Token = "0x400018F")]
  [FieldOffset(Offset = "0x90")]
  private static string mDemoCachePath;
  [Token(Token = "0x4000190")]
  [FieldOffset(Offset = "0x94")]
  private static List<AssetDownloader.FileSizeRequest> m_FileSizeRequest;
  [Token(Token = "0x4000191")]
  [FieldOffset(Offset = "0x98")]
  private static bool ApproveAssetDownload;
  [Token(Token = "0x4000192")]
  [FieldOffset(Offset = "0x9C")]
  private static List<AssetList.Item> CachedDownloadRequests;
  [Token(Token = "0x4000193")]
  [FieldOffset(Offset = "0xA0")]
  private static List<KeyValuePair<string, int>> CachedUnmanagedDownloadRequests;

  [Token(Token = "0x600019A")]
  [Address(RVA = "0x2D4BD0", Offset = "0x2D39D0", VA = "0x102D4BD0")]
  private void OnLowMemory()
  {
  }

  [Token(Token = "0x600019B")]
  [Address(RVA = "0x2D49F0", Offset = "0x2D37F0", VA = "0x102D49F0")]
  private IEnumerator LowMemoryCoroutine() => (IEnumerator) null;

  [Token(Token = "0x17000029")]
  public static float AverageDownloadSpeed
  {
    [Token(Token = "0x600019C"), Address(RVA = "0x2D7600", Offset = "0x2D6400", VA = "0x102D7600")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x600019D")]
  [Address(RVA = "0x2D5590", Offset = "0x2D4390", VA = "0x102D5590")]
  public static void Reset()
  {
  }

  [Token(Token = "0x1700002A")]
  public static bool HasError
  {
    [Token(Token = "0x600019E"), Address(RVA = "0x2D7A90", Offset = "0x2D6890", VA = "0x102D7A90")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700002B")]
  private static AssetDownloader Instance
  {
    [Token(Token = "0x600019F"), Address(RVA = "0x2D7B30", Offset = "0x2D6930", VA = "0x102D7B30")] get
    {
      return (AssetDownloader) null;
    }
  }

  [Token(Token = "0x60001A0")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public static void SetBaseDownloadURL(string url)
  {
  }

  [Token(Token = "0x60001A1")]
  [Address(RVA = "0x2D09D0", Offset = "0x2CF7D0", VA = "0x102D09D0")]
  private void Awake()
  {
  }

  [Token(Token = "0x60001A2")]
  [Address(RVA = "0x2D54C0", Offset = "0x2D42C0", VA = "0x102D54C0")]
  public static void ResetExistFilePath()
  {
  }

  [Token(Token = "0x60001A3")]
  [Address(RVA = "0x2D5C90", Offset = "0x2D4A90", VA = "0x102D5C90")]
  private void Shutdown()
  {
  }

  [Token(Token = "0x60001A4")]
  [Address(RVA = "0x2D4A70", Offset = "0x2D3870", VA = "0x102D4A70")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60001A5")]
  [Address(RVA = "0x2D4A60", Offset = "0x2D3860", VA = "0x102D4A60")]
  private void OnApplicationQuit()
  {
  }

  [Token(Token = "0x60001A6")]
  [Address(RVA = "0x2D5A90", Offset = "0x2D4890", VA = "0x102D5A90")]
  private void SetError(Network.EErrCode code, string textID)
  {
  }

  [Token(Token = "0x60001A7")]
  [Address(RVA = "0x2D6510", Offset = "0x2D5310", VA = "0x102D6510")]
  private void UnzipThread2()
  {
  }

  [Token(Token = "0x60001A8")]
  [Address(RVA = "0x2D3810", Offset = "0x2D2610", VA = "0x102D3810")]
  private static long GetFileSize(string path) => new long();

  [Token(Token = "0x60001A9")]
  [Address(RVA = "0x2D1A40", Offset = "0x2D0840", VA = "0x102D1A40")]
  private void CompareFileListHashThread(object args)
  {
  }

  [Token(Token = "0x60001AA")]
  [Address(RVA = "0x2D0810", Offset = "0x2CF610", VA = "0x102D0810")]
  public static void Add(string assetID)
  {
  }

  [Token(Token = "0x1700002C")]
  public static bool isDone
  {
    [Token(Token = "0x60001AB"), Address(RVA = "0x2D8390", Offset = "0x2D7190", VA = "0x102D8390")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700002D")]
  public static bool isManagedAssetsDone
  {
    [Token(Token = "0x60001AC"), Address(RVA = "0x2D8480", Offset = "0x2D7280", VA = "0x102D8480")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700002E")]
  public static bool isUnManagedAssetsDone
  {
    [Token(Token = "0x60001AD"), Address(RVA = "0x2D8500", Offset = "0x2D7300", VA = "0x102D8500")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700002F")]
  public static bool HasUnManagedAssetRequest
  {
    [Token(Token = "0x60001AE"), Address(RVA = "0x2D7AD0", Offset = "0x2D68D0", VA = "0x102D7AD0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000030")]
  private bool Internal_isDone
  {
    [Token(Token = "0x60001AF"), Address(RVA = "0x2D7D30", Offset = "0x2D6B30", VA = "0x102D7D30")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x60001B0")]
  [Address(RVA = "0x2D6310", Offset = "0x2D5110", VA = "0x102D6310")]
  public static AssetDownloader.DownloadState StartDownload(
    bool checkUpdates,
    bool canRetry = true,
    System.Threading.ThreadPriority threadPriority = System.Threading.ThreadPriority.Normal,
    bool dispProgressBar = false,
    bool autoUpdateProgressText = true)
  {
    return (AssetDownloader.DownloadState) null;
  }

  [Token(Token = "0x60001B1")]
  [Address(RVA = "0x2D0590", Offset = "0x2CF390", VA = "0x102D0590")]
  public static void AddUnManagedData(string name)
  {
  }

  [Token(Token = "0x60001B2")]
  [Address(RVA = "0x2D2890", Offset = "0x2D1690", VA = "0x102D2890")]
  public static void DeleteOldUnmanagedData(int max)
  {
  }

  [Token(Token = "0x60001B3")]
  [Address(RVA = "0x2D6220", Offset = "0x2D5020", VA = "0x102D6220")]
  public static void StartDownloadUnmanagedData()
  {
  }

  [Token(Token = "0x60001B4")]
  [Address(RVA = "0x2D57D0", Offset = "0x2D45D0", VA = "0x102D57D0")]
  public void RetryComfirmUnmanaged(bool retry)
  {
  }

  [Token(Token = "0x60001B5")]
  [Address(RVA = "0x2D2250", Offset = "0x2D1050", VA = "0x102D2250")]
  private IEnumerator ConfirmRetryUnmanaged() => (IEnumerator) null;

  [Token(Token = "0x60001B6")]
  [Address(RVA = "0x2D3340", Offset = "0x2D2140", VA = "0x102D3340")]
  public IEnumerator DonwoloadUnmanagedAsset(List<string> RequestAssets, string cacheDir)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60001B7")]
  [Address(RVA = "0x2D2170", Offset = "0x2D0F70", VA = "0x102D2170")]
  private string ComposeDownloadURI(string prefix, string[] fileID) => (string) null;

  [Token(Token = "0x60001B8")]
  [Address(RVA = "0x2D4DB0", Offset = "0x2D3BB0", VA = "0x102D4DB0")]
  private void RecordDownloadSpeed(float bytesPerSecond)
  {
  }

  [Token(Token = "0x17000031")]
  private AssetDownloader.UnzipJobState UnzipState
  {
    [Token(Token = "0x60001B9"), Address(RVA = "0x2D8220", Offset = "0x2D7020", VA = "0x102D8220")] get
    {
      return new AssetDownloader.UnzipJobState();
    }
  }

  [Token(Token = "0x60001BA")]
  [Address(RVA = "0x2D43A0", Offset = "0x2D31A0", VA = "0x102D43A0")]
  private byte[] LoadFileList() => (byte[]) null;

  [Token(Token = "0x60001BB")]
  [Address(RVA = "0x2D04F0", Offset = "0x2CF2F0", VA = "0x102D04F0")]
  private void AddRequiredAssets(string cacheDir, AssetList.Item[] assets)
  {
  }

  [Token(Token = "0x60001BC")]
  [Address(RVA = "0x2D4EE0", Offset = "0x2D3CE0", VA = "0x102D4EE0")]
  private void RemoveCompletedDownloadRequests(string cacheDir, AssetList assets)
  {
  }

  [Token(Token = "0x60001BD")]
  [Address(RVA = "0x2D64D0", Offset = "0x2D52D0", VA = "0x102D64D0")]
  private static UnityEngine.ThreadPriority TranslateThreadPriority(System.Threading.ThreadPriority priority)
  {
    return new UnityEngine.ThreadPriority();
  }

  [Token(Token = "0x60001BE")]
  [Address(RVA = "0x2D3E90", Offset = "0x2D2C90", VA = "0x102D3E90")]
  private bool IsUnZipWorkerThreadNotTight() => new bool();

  [Token(Token = "0x60001BF")]
  [Address(RVA = "0x2D2230", Offset = "0x2D1030", VA = "0x102D2230")]
  private string ComposeDownloadURI(string prefix, string fileID) => (string) null;

  [Token(Token = "0x60001C0")]
  [Address(RVA = "0x2D0B20", Offset = "0x2CF920", VA = "0x102D0B20")]
  private void BeginUnzip(
    byte[] bytes,
    int size,
    string dest,
    string requestID,
    AssetList assetList)
  {
  }

  [Token(Token = "0x60001C1")]
  [Address(RVA = "0x2D4C80", Offset = "0x2D3A80", VA = "0x102D4C80")]
  private IEnumerator ParallelDonwloading(
    AssetList assetList,
    System.Threading.ThreadPriority threadPriority,
    string prefix,
    string cacheDir,
    Dictionary<string, int> itemCompressedSize,
    List<string> requestID)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60001C2")]
  [Address(RVA = "0x2D4080", Offset = "0x2D2E80", VA = "0x102D4080")]
  private void LoadExistFile()
  {
  }

  [Token(Token = "0x60001C3")]
  [Address(RVA = "0x2D6C40", Offset = "0x2D5A40", VA = "0x102D6C40")]
  public static void VerifyExistList()
  {
  }

  [Token(Token = "0x60001C4")]
  [Address(RVA = "0x2D23D0", Offset = "0x2D11D0", VA = "0x102D23D0")]
  public void CreateExistFile()
  {
  }

  [Token(Token = "0x60001C5")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void LoadBaseAsset()
  {
  }

  [Token(Token = "0x60001C6")]
  [Address(RVA = "0x2D1230", Offset = "0x2D0030", VA = "0x102D1230")]
  private bool CheckDemoCacheDirectory() => new bool();

  [Token(Token = "0x60001C7")]
  [Address(RVA = "0x2D3060", Offset = "0x2D1E60", VA = "0x102D3060")]
  private void DestroyDemoCacheDirectory()
  {
  }

  [Token(Token = "0x60001C8")]
  [Address(RVA = "0x2D4770", Offset = "0x2D3570", VA = "0x102D4770")]
  private void LoadUnmanagedExistFile()
  {
  }

  [Token(Token = "0x60001C9")]
  [Address(RVA = "0x2D2630", Offset = "0x2D1430", VA = "0x102D2630")]
  private void CreateUnManagedExistFile()
  {
  }

  [Token(Token = "0x60001CA")]
  [Address(RVA = "0x2D31B0", Offset = "0x2D1FB0", VA = "0x102D31B0")]
  private void DestroyUnManagedExistFile()
  {
  }

  [Token(Token = "0x60001CB")]
  [Address(RVA = "0x2D33C0", Offset = "0x2D21C0", VA = "0x102D33C0")]
  private IEnumerator DownloadWWW(
    string prefix,
    string name,
    string writename,
    bool isError,
    Action<UnityWebRequest> onDownloadUpdate = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60001CC")]
  [Address(RVA = "0x2D3C90", Offset = "0x2D2A90", VA = "0x102D3C90")]
  private IEnumerator InternalDownloadAssets(
    AssetDownloader.DownloadState state,
    bool checkUpdates,
    bool isRetry,
    System.Threading.ThreadPriority threadPriority,
    bool dispProgressBar,
    bool autoUpdateProgressText)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60001CD")]
  [Address(RVA = "0x2D5870", Offset = "0x2D4670", VA = "0x102D5870")]
  private void SaveAssetListVersion()
  {
  }

  [Token(Token = "0x60001CE")]
  [Address(RVA = "0x2D3ED0", Offset = "0x2D2CD0", VA = "0x102D3ED0")]
  private bool LoadAssetListVersion(ref string hash) => new bool();

  [Token(Token = "0x60001CF")]
  [Address(RVA = "0x2D5980", Offset = "0x2D4780", VA = "0x102D5980")]
  private void SaveUnManagedAssetListVersion()
  {
  }

  [Token(Token = "0x60001D0")]
  [Address(RVA = "0x2D45C0", Offset = "0x2D33C0", VA = "0x102D45C0")]
  private bool LoadUnManagedAssetListVersion(ref string hash) => new bool();

  [Token(Token = "0x60001D1")]
  [Address(RVA = "0x2D0D40", Offset = "0x2CFB40", VA = "0x102D0D40")]
  private ulong CalcDLCSize() => new ulong();

  [Token(Token = "0x60001D2")]
  [Address(RVA = "0x2D3900", Offset = "0x2D2700", VA = "0x102D3900")]
  private string GetSizeText(ulong _size) => (string) null;

  [Token(Token = "0x60001D3")]
  [Address(RVA = "0x2D34C0", Offset = "0x2D22C0", VA = "0x102D34C0")]
  public void FileCheckThread(object arg)
  {
  }

  [Token(Token = "0x60001D4")]
  [Address(RVA = "0x2D22C0", Offset = "0x2D10C0", VA = "0x102D22C0")]
  private IEnumerator ConfirmRetry(AssetDownloader.RetryParam param) => (IEnumerator) null;

  [Token(Token = "0x17000032")]
  public static AssetDownloader.DownloadPhases Phase
  {
    [Token(Token = "0x60001D5"), Address(RVA = "0x2D7E50", Offset = "0x2D6C50", VA = "0x102D7E50")] get
    {
      return new AssetDownloader.DownloadPhases();
    }
  }

  [Token(Token = "0x17000033")]
  public static float Progress
  {
    [Token(Token = "0x60001D6"), Address(RVA = "0x2D7E90", Offset = "0x2D6C90", VA = "0x102D7E90")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x17000034")]
  public static long TotalDownloadSize
  {
    [Token(Token = "0x60001D7"), Address(RVA = "0x2D7F10", Offset = "0x2D6D10", VA = "0x102D7F10")] get
    {
      return new long();
    }
  }

  [Token(Token = "0x17000035")]
  public static long CurrentDownloadSize
  {
    [Token(Token = "0x60001D8"), Address(RVA = "0x2D77C0", Offset = "0x2D65C0", VA = "0x102D77C0")] get
    {
      return new long();
    }
  }

  [Token(Token = "0x17000036")]
  public static float UnManagedProgress
  {
    [Token(Token = "0x60001D9"), Address(RVA = "0x2D8030", Offset = "0x2D6E30", VA = "0x102D8030")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x17000037")]
  public static long UnManagedTotalDownloadSize
  {
    [Token(Token = "0x60001DA"), Address(RVA = "0x2D8070", Offset = "0x2D6E70", VA = "0x102D8070")] get
    {
      return new long();
    }
  }

  [Token(Token = "0x17000038")]
  public static long UnManagedCurrentDownloadSize
  {
    [Token(Token = "0x60001DB"), Address(RVA = "0x2D7FA0", Offset = "0x2D6DA0", VA = "0x102D7FA0")] get
    {
      return new long();
    }
  }

  [Token(Token = "0x60001DC")]
  [Address(RVA = "0x2D1370", Offset = "0x2D0170", VA = "0x102D1370")]
  public static void ClearCachePath()
  {
  }

  [Token(Token = "0x17000039")]
  public static string CachePath
  {
    [Token(Token = "0x60001DD"), Address(RVA = "0x2D76B0", Offset = "0x2D64B0", VA = "0x102D76B0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700003A")]
  public static string CachePathOld
  {
    [Token(Token = "0x60001DE"), Address(RVA = "0x2D7640", Offset = "0x2D6440", VA = "0x102D7640")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700003B")]
  public static string DemoCachePath
  {
    [Token(Token = "0x60001DF"), Address(RVA = "0x2D7850", Offset = "0x2D6650", VA = "0x102D7850")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700003C")]
  public static string OldDownloadPath
  {
    [Token(Token = "0x60001E0"), Address(RVA = "0x2D7DD0", Offset = "0x2D6BD0", VA = "0x102D7DD0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700003D")]
  public static string FileListPath
  {
    [Token(Token = "0x60001E1"), Address(RVA = "0x2D79D0", Offset = "0x2D67D0", VA = "0x102D79D0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700003E")]
  public static string FileListVerPath
  {
    [Token(Token = "0x60001E2"), Address(RVA = "0x2D7A30", Offset = "0x2D6830", VA = "0x102D7A30")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x1700003F")]
  public static string AssetListPath
  {
    [Token(Token = "0x60001E3"), Address(RVA = "0x2D74E0", Offset = "0x2D62E0", VA = "0x102D74E0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000040")]
  public static string AssetListHashPath
  {
    [Token(Token = "0x60001E4"), Address(RVA = "0x2D7480", Offset = "0x2D6280", VA = "0x102D7480")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000041")]
  public static int CurrentAssetListHashFormatVersion
  {
    [Token(Token = "0x60001E5"), Address(RVA = "0x2B8A30", Offset = "0x2B7830", VA = "0x102B8A30")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x60001E6")]
  [Address(RVA = "0x2D2330", Offset = "0x2D1130", VA = "0x102D2330")]
  private static AssetDownloader.AssetListHashVersionBase CreateCurrentAssetListHashVersionClass()
  {
    return (AssetDownloader.AssetListHashVersionBase) null;
  }

  [Token(Token = "0x17000042")]
  public static string AssetListTmpPath
  {
    [Token(Token = "0x60001E7"), Address(RVA = "0x2D75A0", Offset = "0x2D63A0", VA = "0x102D75A0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000043")]
  public static string AssetListTmpDir
  {
    [Token(Token = "0x60001E8"), Address(RVA = "0x2D7540", Offset = "0x2D6340", VA = "0x102D7540")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000044")]
  public static string ExistFilePath
  {
    [Token(Token = "0x60001E9"), Address(RVA = "0x2D7970", Offset = "0x2D6770", VA = "0x102D7970")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000045")]
  public static string UnmanagedListFilePath
  {
    [Token(Token = "0x60001EA"), Address(RVA = "0x2D8160", Offset = "0x2D6F60", VA = "0x102D8160")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000046")]
  public static string UnmanagedListHashPath
  {
    [Token(Token = "0x60001EB"), Address(RVA = "0x2D81C0", Offset = "0x2D6FC0", VA = "0x102D81C0")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x17000047")]
  public static int UnmanagedListHashFormatVersion
  {
    [Token(Token = "0x60001EC"), Address(RVA = "0x2B8A30", Offset = "0x2B7830", VA = "0x102B8A30")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x60001ED")]
  [Address(RVA = "0x2D2380", Offset = "0x2D1180", VA = "0x102D2380")]
  private static AssetDownloader.UnManagedAssetListHashVersionBase CreateCurrentUnManagedAssetListHashVersionClass()
  {
    return (AssetDownloader.UnManagedAssetListHashVersionBase) null;
  }

  [Token(Token = "0x17000048")]
  public static string UnmanagedExistFilePath
  {
    [Token(Token = "0x60001EE"), Address(RVA = "0x2D8100", Offset = "0x2D6F00", VA = "0x102D8100")] get
    {
      return (string) null;
    }
  }

  [Token(Token = "0x60001EF")]
  [Address(RVA = "0x2D19E0", Offset = "0x2D07E0", VA = "0x102D19E0")]
  private static bool CompareBytes(byte[] a, byte[] b) => new bool();

  [Token(Token = "0x60001F0")]
  [Address(RVA = "0x2D1400", Offset = "0x2D0200", VA = "0x102D1400")]
  public static void ClearCache()
  {
  }

  [Token(Token = "0x60001F1")]
  [Address(RVA = "0x2D2A50", Offset = "0x2D1850", VA = "0x102D2A50")]
  public static void DestroyAssetStart(AssetBundleFlags flags)
  {
  }

  [Token(Token = "0x60001F2")]
  [Address(RVA = "0x2D2D80", Offset = "0x2D1B80", VA = "0x102D2D80")]
  public IEnumerator DestroyAsset(AssetBundleFlags flags) => (IEnumerator) null;

  [Token(Token = "0x60001F3")]
  [Address(RVA = "0x2D2C30", Offset = "0x2D1A30", VA = "0x102D2C30")]
  public static void DestroyAsset(string path)
  {
  }

  [Token(Token = "0x60001F4")]
  [Address(RVA = "0x2D2B10", Offset = "0x2D1910", VA = "0x102D2B10")]
  public static void DestroyAsset(AssetList.Item item)
  {
  }

  [Token(Token = "0x60001F5")]
  [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0")]
  public static bool IsEnableShowSizeBeforeDownloading(bool usePlayerPrefs = true) => new bool();

  [Token(Token = "0x60001F6")]
  [Address(RVA = "0x2D03E0", Offset = "0x2CF1E0", VA = "0x102D03E0")]
  public static void AddFileSizeRequest(string url)
  {
  }

  [Token(Token = "0x60001F7")]
  [Address(RVA = "0x2D6460", Offset = "0x2D5260", VA = "0x102D6460")]
  private IEnumerator StartFileSizeRequest(Action<long> completeAllReqeust) => (IEnumerator) null;

  [Token(Token = "0x60001F8")]
  [Address(RVA = "0x2D61B0", Offset = "0x2D4FB0", VA = "0x102D61B0")]
  public static IEnumerator StartConfirmWindowYesNo(string msg) => (IEnumerator) null;

  [Token(Token = "0x60001F9")]
  [Address(RVA = "0x2D5E90", Offset = "0x2D4C90", VA = "0x102D5E90")]
  public static IEnumerator StartConfirmDownloadContentYesNo(
    UIUtility.DialogResultEvent okEventListener = null,
    UIUtility.DialogResultEvent cancelEventListener = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60001FA")]
  [Address(RVA = "0x2D5F80", Offset = "0x2D4D80", VA = "0x102D5F80")]
  public static void StartConfirmDownloadQuestContentYesNo(
    List<UnitData> entryUnits,
    List<ItemData> itemData,
    QuestParam questParam,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener)
  {
  }

  [Token(Token = "0x60001FB")]
  [Address(RVA = "0x2D3D20", Offset = "0x2D2B20", VA = "0x102D3D20")]
  private IEnumerator InternalStartConfirmDownloadQuestContentYesNo(
    List<UnitData> entryUnits,
    List<ItemData> itemData,
    QuestParam questParam,
    UIUtility.DialogResultEvent okEventListener,
    UIUtility.DialogResultEvent cancelEventListener)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60001FC")]
  [Address(RVA = "0x2D5F00", Offset = "0x2D4D00", VA = "0x102D5F00")]
  public static IEnumerator StartConfirmDownloadContent(
    UIUtility.DialogResultEvent okEventListener = null,
    AssetDownloader.OnDownloadPopupTimeout timeoutEventListener = null,
    float timeoutSec = 0.0f)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60001FD")]
  [Address(RVA = "0x2D6090", Offset = "0x2D4E90", VA = "0x102D6090")]
  public static void StartConfirmDownloadQuestContent(
    List<UnitData> entryUnits,
    List<ItemData> itemData,
    QuestParam questParam,
    UIUtility.DialogResultEvent okEventListener,
    AssetDownloader.OnDownloadPopupTimeout timeoutEventListener = null,
    float timeoutSec = 0.0f)
  {
  }

  [Token(Token = "0x60001FE")]
  [Address(RVA = "0x2D3DD0", Offset = "0x2D2BD0", VA = "0x102D3DD0")]
  private IEnumerator InternalStartConfirmDownloadQuestContent(
    List<UnitData> entryUnits,
    List<ItemData> itemData,
    QuestParam questParam,
    UIUtility.DialogResultEvent okEventListener,
    AssetDownloader.OnDownloadPopupTimeout timeoutEventListener = null,
    float timeoutSec = 0.0f)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x60001FF")]
  [Address(RVA = "0x2D4D30", Offset = "0x2D3B30", VA = "0x102D4D30")]
  public static IEnumerator PrepareQuest(
    List<UnitData> entryUnits,
    List<ItemData> itemData,
    QuestParam questParam)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000200")]
  [Address(RVA = "0x2D3610", Offset = "0x2D2410", VA = "0x102D3610")]
  public static void ForceCreateExistFile()
  {
  }

  [Token(Token = "0x6000201")]
  [Address(RVA = "0x2D3C00", Offset = "0x2D2A00", VA = "0x102D3C00")]
  public static bool HasRequests() => new bool();

  [Token(Token = "0x6000202")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void CheckIfDownloadRequestIsApproved()
  {
  }

  [Token(Token = "0x6000203")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void CheckIfDownloadUnManagedRequestIsApproved()
  {
  }

  [Token(Token = "0x6000204")]
  [Address(RVA = "0x2D0CF0", Offset = "0x2CFAF0", VA = "0x102D0CF0")]
  public static void Begin_ApproveAssetDownload()
  {
  }

  [Token(Token = "0x6000205")]
  [Address(RVA = "0x2D3470", Offset = "0x2D2270", VA = "0x102D3470")]
  public static void End_ApproveAssetDownload()
  {
  }

  [Token(Token = "0x6000206")]
  [Address(RVA = "0x2D1860", Offset = "0x2D0660", VA = "0x102D1860")]
  public static void ClearDownloadRequests(bool resetDownlaodApproved)
  {
  }

  [Token(Token = "0x6000207")]
  [Address(RVA = "0x2D50B0", Offset = "0x2D3EB0", VA = "0x102D50B0")]
  private static void ResetDownloadRequestApproved()
  {
  }

  [Token(Token = "0x6000208")]
  [Address(RVA = "0x2D3660", Offset = "0x2D2460", VA = "0x102D3660")]
  public static List<AssetList.Item> GetDownloadRequests() => (List<AssetList.Item>) null;

  [Token(Token = "0x6000209")]
  [Address(RVA = "0x2D39D0", Offset = "0x2D27D0", VA = "0x102D39D0")]
  public static List<KeyValuePair<string, int>> GetUnmanagedDownloadRequests()
  {
    return (List<KeyValuePair<string, int>>) null;
  }

  [Token(Token = "0x600020A")]
  [Address(RVA = "0x2D0F00", Offset = "0x2CFD00", VA = "0x102D0F00")]
  public static long CalcDownloadSize() => new long();

  [Token(Token = "0x600020B")]
  [Address(RVA = "0x2D4AE0", Offset = "0x2D38E0", VA = "0x102D4AE0")]
  private void OnDownloadUpdate(UnityWebRequest www)
  {
  }

  [Token(Token = "0x600020C")]
  [Address(RVA = "0x2D2E80", Offset = "0x2D1C80", VA = "0x102D2E80")]
  public static void DestroyAssets(List<AssetList.Item> destroyAssets)
  {
  }

  [Token(Token = "0x600020D")]
  [Address(RVA = "0x2D2DF0", Offset = "0x2D1BF0", VA = "0x102D2DF0")]
  public static void DestroyAssetsAll()
  {
  }

  [Token(Token = "0x600020E")]
  [Address(RVA = "0x2D7310", Offset = "0x2D6110", VA = "0x102D7310")]
  public AssetDownloader()
  {
  }

  [Token(Token = "0x600020F")]
  [Address(RVA = "0x2D6EC0", Offset = "0x2D5CC0", VA = "0x102D6EC0")]
  static AssetDownloader()
  {
  }

  [Token(Token = "0x2000045")]
  public enum DownloadPhases
  {
    [Token(Token = "0x4000195")] FileCheck,
    [Token(Token = "0x4000196")] Download,
  }

  [Token(Token = "0x2000046")]
  private enum UnzipJobState
  {
    [Token(Token = "0x4000198")] Error = -1, // 0xFFFFFFFF
    [Token(Token = "0x4000199")] Waiting = 0,
    [Token(Token = "0x400019A")] Extracting = 1,
    [Token(Token = "0x400019B")] Finished = 2,
  }

  [Token(Token = "0x2000047")]
  private class UnzipJob
  {
    [Token(Token = "0x400019C")]
    [FieldOffset(Offset = "0x8")]
    public byte[] Bytes;
    [Token(Token = "0x400019D")]
    [FieldOffset(Offset = "0xC")]
    public int Size;
    [Token(Token = "0x400019E")]
    [FieldOffset(Offset = "0x10")]
    public string Dest;
    [Token(Token = "0x400019F")]
    [FieldOffset(Offset = "0x14")]
    public AssetDownloader.UnzipJobState State;
    [Token(Token = "0x40001A0")]
    [FieldOffset(Offset = "0x18")]
    public List<AssetDownloader.UnzipJob.Node> nodes;

    [Token(Token = "0x6000210")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnzipJob()
    {
    }

    [Token(Token = "0x2000048")]
    public class Node
    {
      [Token(Token = "0x40001A1")]
      [FieldOffset(Offset = "0x8")]
      public string ID;
      [Token(Token = "0x40001A2")]
      [FieldOffset(Offset = "0xC")]
      public uint hash;
      [Token(Token = "0x40001A3")]
      [FieldOffset(Offset = "0x10")]
      public AssetList.Item Item;

      [Token(Token = "0x6000211")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Node()
      {
      }
    }
  }

  [Token(Token = "0x2000049")]
  public class ExistAssetList
  {
    [Token(Token = "0x40001A4")]
    [FieldOffset(Offset = "0x8")]
    public uint FileID;
    [Token(Token = "0x40001A5")]
    [FieldOffset(Offset = "0xC")]
    public int AssetID;

    [Token(Token = "0x6000212")]
    [Address(RVA = "0x28D570", Offset = "0x28C370", VA = "0x1028D570")]
    public ExistAssetList(uint file, int asset)
    {
    }
  }

  [Token(Token = "0x200004A")]
  private abstract class AssetListHashVersionBase
  {
    [Token(Token = "0x40001A6")]
    [FieldOffset(Offset = "0x8")]
    protected string m_Hash;

    [Token(Token = "0x17000049")]
    public string Hash
    {
      [Token(Token = "0x6000213"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6000214")]
    [Address(RVA = "0x2D85B0", Offset = "0x2D73B0", VA = "0x102D85B0", Slot = "4")]
    public virtual string Serialize() => (string) null;

    [Token(Token = "0x6000215")]
    [Address(RVA = "0x2D8580", Offset = "0x2D7380", VA = "0x102D8580", Slot = "5")]
    public virtual void Deserialize(string[] line)
    {
    }

    [Token(Token = "0x6000216")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    protected AssetListHashVersionBase()
    {
    }
  }

  [Token(Token = "0x200004B")]
  private class AssetListHashVersion_V1 : AssetDownloader.AssetListHashVersionBase
  {
    [Token(Token = "0x40001A7")]
    public const int Version = 1;

    [Token(Token = "0x6000217")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AssetListHashVersion_V1()
    {
    }
  }

  [Token(Token = "0x200004C")]
  private abstract class UnManagedAssetListHashVersionBase
  {
    [Token(Token = "0x40001A8")]
    [FieldOffset(Offset = "0x8")]
    protected string m_Hash;

    [Token(Token = "0x1700004A")]
    public string Hash
    {
      [Token(Token = "0x6000218"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6000219")]
    [Address(RVA = "0x2E3190", Offset = "0x2E1F90", VA = "0x102E3190", Slot = "4")]
    public virtual string Serialize() => (string) null;

    [Token(Token = "0x600021A")]
    [Address(RVA = "0x2D8580", Offset = "0x2D7380", VA = "0x102D8580", Slot = "5")]
    public virtual void Deserialize(string[] line)
    {
    }

    [Token(Token = "0x600021B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    protected UnManagedAssetListHashVersionBase()
    {
    }
  }

  [Token(Token = "0x200004D")]
  private class UnManagedAssetListHashVersion_V1 : AssetDownloader.UnManagedAssetListHashVersionBase
  {
    [Token(Token = "0x40001A9")]
    public const int Version = 1;

    [Token(Token = "0x600021C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnManagedAssetListHashVersion_V1()
    {
    }
  }

  [Token(Token = "0x200004E")]
  private class UnzipThread2Arg
  {
    [Token(Token = "0x40001AA")]
    [FieldOffset(Offset = "0x8")]
    public bool completed;
    [Token(Token = "0x40001AB")]
    [FieldOffset(Offset = "0x9")]
    public bool abort;
    [Token(Token = "0x40001AC")]
    [FieldOffset(Offset = "0xA")]
    public bool error;
    [Token(Token = "0x40001AD")]
    [FieldOffset(Offset = "0xC")]
    public AssetList assetlist;

    [Token(Token = "0x600021D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnzipThread2Arg()
    {
    }
  }

  [Token(Token = "0x200004F")]
  private class CompareFileListHashArg
  {
    [Token(Token = "0x40001AE")]
    [FieldOffset(Offset = "0x8")]
    public List<AssetDownloader.CompareFileListHashArg.Node> nodes;
    [Token(Token = "0x40001AF")]
    [FieldOffset(Offset = "0xC")]
    public string cacheDir;
    [Token(Token = "0x40001B0")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<uint, AssetList.Item> dic;

    [Token(Token = "0x600021E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CompareFileListHashArg()
    {
    }

    [Token(Token = "0x2000050")]
    public class Node
    {
      [Token(Token = "0x40001B1")]
      [FieldOffset(Offset = "0x8")]
      public string IDStr;
      [Token(Token = "0x40001B2")]
      [FieldOffset(Offset = "0xC")]
      public string metaPath;
      [Token(Token = "0x40001B3")]
      [FieldOffset(Offset = "0x10")]
      public uint Hash;
      [Token(Token = "0x40001B4")]
      [FieldOffset(Offset = "0x14")]
      public int Size;
      [Token(Token = "0x40001B5")]
      [FieldOffset(Offset = "0x18")]
      public AssetList.Item Item;

      [Token(Token = "0x600021F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Node()
      {
      }
    }
  }

  [Token(Token = "0x2000051")]
  public class DownloadState
  {
    [Token(Token = "0x40001B6")]
    [FieldOffset(Offset = "0x8")]
    public bool Finished;
    [Token(Token = "0x40001B7")]
    [FieldOffset(Offset = "0x9")]
    public bool HasError;

    [Token(Token = "0x6000220")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DownloadState()
    {
    }
  }

  [Token(Token = "0x2000052")]
  private class StorageException : Exception
  {
    [Token(Token = "0x6000221")]
    [Address(RVA = "0x2DC340", Offset = "0x2DB140", VA = "0x102DC340")]
    public StorageException()
    {
    }
  }

  [Token(Token = "0x2000053")]
  private class WWWException : Exception
  {
    [Token(Token = "0x40001B8")]
    [FieldOffset(Offset = "0x48")]
    private int mStatusCode;
    [Token(Token = "0x40001B9")]
    [FieldOffset(Offset = "0x4C")]
    private string mMessage;

    [Token(Token = "0x6000222")]
    [Address(RVA = "0x2E3280", Offset = "0x2E2080", VA = "0x102E3280")]
    public WWWException(UnityWebRequest www)
    {
    }

    [Token(Token = "0x1700004B")]
    public int StatusCode
    {
      [Token(Token = "0x6000223"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700004C")]
    public override string Message
    {
      [Token(Token = "0x6000224"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0", Slot = "5")] get
      {
        return (string) null;
      }
    }
  }

  [Token(Token = "0x2000054")]
  private class FileCheckArg
  {
    [Token(Token = "0x40001BA")]
    [FieldOffset(Offset = "0x8")]
    public AssetList assetList;

    [Token(Token = "0x6000225")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FileCheckArg()
    {
    }
  }

  [Token(Token = "0x2000055")]
  private class RetryParam
  {
    [Token(Token = "0x40001BB")]
    [FieldOffset(Offset = "0x8")]
    public AssetDownloader downloader;
    [Token(Token = "0x40001BC")]
    [FieldOffset(Offset = "0xC")]
    public AssetDownloader.DownloadState state;
    [Token(Token = "0x40001BD")]
    [FieldOffset(Offset = "0x10")]
    public bool checkUpdates;
    [Token(Token = "0x40001BE")]
    [FieldOffset(Offset = "0x11")]
    public bool isRetry;
    [Token(Token = "0x40001BF")]
    [FieldOffset(Offset = "0x14")]
    public System.Threading.ThreadPriority threadPriority;
    [Token(Token = "0x40001C0")]
    [FieldOffset(Offset = "0x18")]
    public string bodyText;
    [Token(Token = "0x40001C1")]
    [FieldOffset(Offset = "0x1C")]
    public bool dispProgressBar;
    [Token(Token = "0x40001C2")]
    [FieldOffset(Offset = "0x1D")]
    public bool autoUpdateProgressText;

    [Token(Token = "0x6000226")]
    [Address(RVA = "0x2DC2A0", Offset = "0x2DB0A0", VA = "0x102DC2A0")]
    public void RetryEvent(bool retry)
    {
    }

    [Token(Token = "0x6000227")]
    [Address(RVA = "0x2DC320", Offset = "0x2DB120", VA = "0x102DC320")]
    public RetryParam()
    {
    }
  }

  [Token(Token = "0x2000056")]
  public delegate void OnDownloadPopupTimeout();

  [Token(Token = "0x2000057")]
  private class FileSizeRequest : IDisposable
  {
    [Token(Token = "0x40001C3")]
    [FieldOffset(Offset = "0x8")]
    private UnityWebRequest m_Request;
    [Token(Token = "0x40001C4")]
    [FieldOffset(Offset = "0xC")]
    private AssetDownloader.FileSizeRequest.DownloadHandler m_DownloadHandler;
    [Token(Token = "0x40001C5")]
    [FieldOffset(Offset = "0x10")]
    private long m_ResponseCode;
    [Token(Token = "0x40001C6")]
    [FieldOffset(Offset = "0x18")]
    private AssetDownloader.FileSizeRequest.eState m_State;
    [Token(Token = "0x40001C7")]
    [FieldOffset(Offset = "0x1C")]
    private int m_SendCount;

    [Token(Token = "0x1700004D")]
    public bool isDone
    {
      [Token(Token = "0x600022C"), Address(RVA = "0x2DC180", Offset = "0x2DAF80", VA = "0x102DC180")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700004E")]
    public bool HasError
    {
      [Token(Token = "0x600022D"), Address(RVA = "0x2DC120", Offset = "0x2DAF20", VA = "0x102DC120")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700004F")]
    public string ErrorMessage
    {
      [Token(Token = "0x600022E"), Address(RVA = "0x2DC050", Offset = "0x2DAE50", VA = "0x102DC050")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000050")]
    public int ContentLength
    {
      [Token(Token = "0x600022F"), Address(RVA = "0x2DC030", Offset = "0x2DAE30", VA = "0x102DC030")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000051")]
    public bool IsSending
    {
      [Token(Token = "0x6000230"), Address(RVA = "0x26D070", Offset = "0x26BE70", VA = "0x1026D070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6000231")]
    [Address(RVA = "0x2DBFA0", Offset = "0x2DADA0", VA = "0x102DBFA0")]
    public FileSizeRequest(string url)
    {
    }

    [Token(Token = "0x6000232")]
    [Address(RVA = "0x2DBE00", Offset = "0x2DAC00", VA = "0x102DBE00", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x6000233")]
    [Address(RVA = "0x2DBF40", Offset = "0x2DAD40", VA = "0x102DBF40")]
    public void Send()
    {
    }

    [Token(Token = "0x6000234")]
    [Address(RVA = "0x2DBE70", Offset = "0x2DAC70", VA = "0x102DBE70")]
    public void Resend()
    {
    }

    [Token(Token = "0x2000058")]
    private class DownloadHandler : DownloadHandlerScript
    {
      [Token(Token = "0x40001C8")]
      [FieldOffset(Offset = "0xC")]
      private int m_ContentLength;

      [Token(Token = "0x17000052")]
      public int ContentLength
      {
        [Token(Token = "0x6000235"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6000236")]
      [Address(RVA = "0x2DBDF0", Offset = "0x2DABF0", VA = "0x102DBDF0")]
      private DownloadHandler()
      {
      }

      [Token(Token = "0x6000237")]
      [Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0", Slot = "11")]
      protected override void ReceiveContentLength(int contentLength)
      {
      }

      [Token(Token = "0x6000238")]
      [Address(RVA = "0x2DBD90", Offset = "0x2DAB90", VA = "0x102DBD90")]
      public static AssetDownloader.FileSizeRequest.DownloadHandler Create(int bufferSize = 0)
      {
        return (AssetDownloader.FileSizeRequest.DownloadHandler) null;
      }

      [Token(Token = "0x6000239")]
      [Address(RVA = "0x2DBDE0", Offset = "0x2DABE0", VA = "0x102DBDE0")]
      public void Reset()
      {
      }
    }

    [Token(Token = "0x2000059")]
    private enum eState
    {
      [Token(Token = "0x40001CA")] Ready,
      [Token(Token = "0x40001CB")] Sending,
      [Token(Token = "0x40001CC")] Disposed,
    }
  }

  [Token(Token = "0x200005A")]
  public class ApproveAssetDownloadScope : IDisposable
  {
    [Token(Token = "0x600023A")]
    [Address(RVA = "0x2CFD90", Offset = "0x2CEB90", VA = "0x102CFD90")]
    public ApproveAssetDownloadScope()
    {
    }

    [Token(Token = "0x600023B")]
    [Address(RVA = "0x2CFD10", Offset = "0x2CEB10", VA = "0x102CFD10", Slot = "4")]
    public void Dispose()
    {
    }
  }
}
