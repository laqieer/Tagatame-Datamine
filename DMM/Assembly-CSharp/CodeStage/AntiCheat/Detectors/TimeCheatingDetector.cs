// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Detectors.TimeCheatingDetector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

#nullable disable
namespace CodeStage.AntiCheat.Detectors
{
  [Token(Token = "0x20036AD")]
  [AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Time Cheating Detector")]
  [DisallowMultipleComponent]
  [HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_time_cheating_detector.html")]
  public class TimeCheatingDetector : ACTkDetectorBase
  {
    [Token(Token = "0x40100B1")]
    internal const string ComponentName = "Time Cheating Detector";
    [Token(Token = "0x40100B2")]
    private const string LogPrefix = "[ACTk] Time Cheating Detector: ";
    [Token(Token = "0x40100B3")]
    private const int DefaultTimeoutSeconds = 10;
    [Token(Token = "0x40100B4")]
    [FieldOffset(Offset = "0x0")]
    private static readonly WaitForEndOfFrame cachedEndOfFrame;
    [Token(Token = "0x40100B5")]
    [FieldOffset(Offset = "0x4")]
    private static int instancesInScene;
    [Token(Token = "0x40100B6")]
    [FieldOffset(Offset = "0x8")]
    private static bool gettingOnlineTime;
    [Token(Token = "0x40100B8")]
    [FieldOffset(Offset = "0x20")]
    [Tooltip("Absolute URL which will return correct datetime in response headers (you may use popular web servers like google.com, microsoft.com etc.).")]
    [SerializeField]
    [Header("Request settings")]
    private string requestUrl;
    [Token(Token = "0x40100B9")]
    [FieldOffset(Offset = "0x24")]
    [Tooltip("Method to use for url request. Use Head method if possible and fall back to get if server does not reply or block head requests.")]
    public TimeCheatingDetector.RequestMethod requestMethod;
    [Token(Token = "0x40100BA")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("Online time request timeout in seconds.")]
    public int timeoutSeconds;
    [Token(Token = "0x40100BB")]
    [FieldOffset(Offset = "0x2C")]
    [Header("Settings in minutes")]
    [Tooltip("Time (in minutes) between detector checks.")]
    [Range(0.0f, 60f)]
    public float interval;
    [Token(Token = "0x40100BC")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("Maximum allowed difference between subsequent measurements, in minutes.")]
    [FormerlySerializedAs("threshold")]
    [Range(10f, 180f)]
    public int realCheatThreshold;
    [Token(Token = "0x40100BD")]
    [FieldOffset(Offset = "0x34")]
    [Range(1f, 180f)]
    [Tooltip("Maximum allowed difference between local and online time, in minutes.")]
    public int wrongTimeThreshold;
    [Token(Token = "0x40100C1")]
    [FieldOffset(Offset = "0x44")]
    private readonly string onlineOfflineDifferencePrefsKey;
    [Token(Token = "0x40100C2")]
    [FieldOffset(Offset = "0x48")]
    private Uri cachedUri;
    [Token(Token = "0x40100C3")]
    [FieldOffset(Offset = "0x4C")]
    private TimeCheatingDetector.TimeCheatingDetectorEventHandler cheatChecked;
    [Token(Token = "0x40100C4")]
    [FieldOffset(Offset = "0x50")]
    private float timeElapsed;
    [Token(Token = "0x40100C5")]
    [FieldOffset(Offset = "0x54")]
    private bool updateAfterPause;
    [Token(Token = "0x40100C6")]
    [FieldOffset(Offset = "0x58")]
    private double lastOnlineSecondsUtc;
    [Token(Token = "0x40100CA")]
    [FieldOffset(Offset = "0x68")]
    [Obsolete("Use wrongTimeThreshold instead.", true)]
    [NonSerialized]
    public int threshold;
    [Token(Token = "0x40100CB")]
    [FieldOffset(Offset = "0x6C")]
    [Obsolete("Use requestUrl instead", true)]
    [NonSerialized]
    public string timeServer;

    [Token(Token = "0x14000018")]
    public event TimeCheatingDetector.TimeCheatingDetectorEventHandler CheatChecked
    {
      [Token(Token = "0x600F711"), Address(RVA = "0xB721C0", Offset = "0xB70FC0", VA = "0x10B721C0")] add
      {
      }
      [Token(Token = "0x600F712"), Address(RVA = "0xB72580", Offset = "0xB71380", VA = "0x10B72580")] remove
      {
      }
    }

    [Token(Token = "0x17002376")]
    public string RequestUrl
    {
      [Token(Token = "0x600F713"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F714"), Address(RVA = "0xB72760", Offset = "0xB71560", VA = "0x10B72760")] set
      {
      }
    }

    [Token(Token = "0x17002377")]
    public TimeCheatingDetector.ErrorKind LastError
    {
      [Token(Token = "0x600F715"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new TimeCheatingDetector.ErrorKind();
      }
      [Token(Token = "0x600F716"), Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")] private set
      {
      }
    }

    [Token(Token = "0x17002378")]
    public TimeCheatingDetector.CheckResult LastResult
    {
      [Token(Token = "0x600F717"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new TimeCheatingDetector.CheckResult();
      }
      [Token(Token = "0x600F718"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] private set
      {
      }
    }

    [Token(Token = "0x17002379")]
    public bool IsCheckingForCheat
    {
      [Token(Token = "0x600F719"), Address(RVA = "0x288080", Offset = "0x286E80", VA = "0x10288080")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F71A"), Address(RVA = "0x2883C0", Offset = "0x2871C0", VA = "0x102883C0")] private set
      {
      }
    }

    [Token(Token = "0x1700237A")]
    public static TimeCheatingDetector Instance
    {
      [Token(Token = "0x600F71B"), Address(RVA = "0xB72540", Offset = "0xB71340", VA = "0x10B72540")] get
      {
        return (TimeCheatingDetector) null;
      }
      [Token(Token = "0x600F71C"), Address(RVA = "0xB72700", Offset = "0xB71500", VA = "0x10B72700")] private set
      {
      }
    }

    [Token(Token = "0x1700237B")]
    private static TimeCheatingDetector GetOrCreateInstance
    {
      [Token(Token = "0x600F71D"), Address(RVA = "0xB72340", Offset = "0xB71140", VA = "0x10B72340")] get
      {
        return (TimeCheatingDetector) null;
      }
    }

    [Token(Token = "0x600F71E")]
    [Address(RVA = "0xB70670", Offset = "0xB6F470", VA = "0x10B70670")]
    private void Awake()
    {
    }

    [Token(Token = "0x600F71F")]
    [Address(RVA = "0xB71420", Offset = "0xB70220", VA = "0x10B71420", Slot = "4")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600F720")]
    [Address(RVA = "0xB714E0", Offset = "0xB702E0", VA = "0x10B714E0")]
    private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
    {
    }

    [Token(Token = "0x600F721")]
    [Address(RVA = "0xB713E0", Offset = "0xB701E0", VA = "0x10B713E0")]
    private void OnApplicationPause(bool pauseStatus)
    {
    }

    [Token(Token = "0x600F722")]
    [Address(RVA = "0xB71F30", Offset = "0xB70D30", VA = "0x10B71F30")]
    private void Update()
    {
    }

    [Token(Token = "0x600F723")]
    [Address(RVA = "0xB70630", Offset = "0xB6F430", VA = "0x10B70630")]
    public static TimeCheatingDetector AddToSceneOrGetExisting() => (TimeCheatingDetector) null;

    [Token(Token = "0x600F724")]
    [Address(RVA = "0xB71810", Offset = "0xB70610", VA = "0x10B71810")]
    public static void StartDetection(
      TimeCheatingDetector.TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
    {
    }

    [Token(Token = "0x600F725")]
    [Address(RVA = "0xB719E0", Offset = "0xB707E0", VA = "0x10B719E0")]
    public static void StartDetection(
      float interval,
      TimeCheatingDetector.TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
    {
    }

    [Token(Token = "0x600F726")]
    [Address(RVA = "0xB71A90", Offset = "0xB70890", VA = "0x10B71A90")]
    public static void StopDetection()
    {
    }

    [Token(Token = "0x600F727")]
    [Address(RVA = "0xB70920", Offset = "0xB6F720", VA = "0x10B70920")]
    public static void Dispose()
    {
    }

    [Token(Token = "0x600F728")]
    [Address(RVA = "0xB70F60", Offset = "0xB6FD60", VA = "0x10B70F60")]
    public static IEnumerator GetOnlineTimeCoroutine(
      string url,
      TimeCheatingDetector.OnlineTimeCallback callback,
      TimeCheatingDetector.RequestMethod method = TimeCheatingDetector.RequestMethod.Head)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600F729")]
    [Address(RVA = "0xB70EE0", Offset = "0xB6FCE0", VA = "0x10B70EE0")]
    public static IEnumerator GetOnlineTimeCoroutine(
      Uri uri,
      TimeCheatingDetector.OnlineTimeCallback callback,
      TimeCheatingDetector.RequestMethod method = TimeCheatingDetector.RequestMethod.Head)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600F72A")]
    [Address(RVA = "0xB70FE0", Offset = "0xB6FDE0", VA = "0x10B70FE0")]
    public static Task<TimeCheatingDetector.OnlineTimeResult> GetOnlineTimeTask(
      string url,
      TimeCheatingDetector.RequestMethod method = TimeCheatingDetector.RequestMethod.Head)
    {
      return (Task<TimeCheatingDetector.OnlineTimeResult>) null;
    }

    [Token(Token = "0x600F72B")]
    [Address(RVA = "0xB710C0", Offset = "0xB6FEC0", VA = "0x10B710C0")]
    public static Task<TimeCheatingDetector.OnlineTimeResult> GetOnlineTimeTask(
      Uri uri,
      TimeCheatingDetector.RequestMethod method = TimeCheatingDetector.RequestMethod.Head)
    {
      return (Task<TimeCheatingDetector.OnlineTimeResult>) null;
    }

    [Token(Token = "0x600F72C")]
    [Address(RVA = "0xB711C0", Offset = "0xB6FFC0", VA = "0x10B711C0")]
    private static UnityWebRequest GetWebRequest(Uri uri, TimeCheatingDetector.RequestMethod method)
    {
      return (UnityWebRequest) null;
    }

    [Token(Token = "0x600F72D")]
    [Address(RVA = "0xB70A30", Offset = "0xB6F830", VA = "0x10B70A30")]
    private static void FillRequestResult(
      UnityWebRequest request,
      ref TimeCheatingDetector.OnlineTimeResult result)
    {
    }

    [Token(Token = "0x600F72E")]
    [Address(RVA = "0xB71FC0", Offset = "0xB70DC0", VA = "0x10B71FC0")]
    private static Uri UrlToUri(string url) => (Uri) null;

    [Token(Token = "0x600F72F")]
    [Address(RVA = "0xB71BA0", Offset = "0xB709A0", VA = "0x10B71BA0")]
    private static bool TryGetDate(string source, out DateTime date) => new bool();

    [Token(Token = "0x600F730")]
    [Address(RVA = "0xB70D90", Offset = "0xB6FB90", VA = "0x10B70D90")]
    public bool ForceCheck() => new bool();

    [Token(Token = "0x600F731")]
    [Address(RVA = "0xB70C50", Offset = "0xB6FA50", VA = "0x10B70C50")]
    public IEnumerator ForceCheckEnumerator() => (IEnumerator) null;

    [Token(Token = "0x600F732")]
    [Address(RVA = "0xB70CC0", Offset = "0xB6FAC0", VA = "0x10B70CC0")]
    public Task<TimeCheatingDetector.CheckResult> ForceCheckTask()
    {
      return (Task<TimeCheatingDetector.CheckResult>) null;
    }

    [Token(Token = "0x600F733")]
    [Address(RVA = "0xB71700", Offset = "0xB70500", VA = "0x10B71700")]
    private void StartDetectionInternal(
      float checkInterval,
      TimeCheatingDetector.TimeCheatingDetectorEventHandler cheatCheckedEventHandler = null)
    {
    }

    [Token(Token = "0x600F734")]
    [Address(RVA = "0xB71340", Offset = "0xB70140", VA = "0x10B71340", Slot = "6")]
    protected override bool Init(ACTkDetectorBase instance, string detectorName) => new bool();

    [Token(Token = "0x600F735")]
    [Address(RVA = "0xB716E0", Offset = "0xB704E0", VA = "0x10B716E0", Slot = "12")]
    protected override void StartDetectionAutomatically()
    {
    }

    [Token(Token = "0x600F736")]
    [Address(RVA = "0xB70820", Offset = "0xB6F620", VA = "0x10B70820", Slot = "8")]
    protected override bool DetectorHasCallbacks() => new bool();

    [Token(Token = "0x600F737")]
    [Address(RVA = "0xB71610", Offset = "0xB70410", VA = "0x10B71610", Slot = "10")]
    protected override void PauseDetector()
    {
    }

    [Token(Token = "0x600F738")]
    [Address(RVA = "0xB71A50", Offset = "0xB70850", VA = "0x10B71A50", Slot = "9")]
    protected override void StopDetectionInternal()
    {
    }

    [Token(Token = "0x600F739")]
    [Address(RVA = "0xB70850", Offset = "0xB6F650", VA = "0x10B70850", Slot = "7")]
    protected override void DisposeInternal()
    {
    }

    [Token(Token = "0x600F73A")]
    [Address(RVA = "0xB707B0", Offset = "0xB6F5B0", VA = "0x10B707B0")]
    private IEnumerator CheckForCheat() => (IEnumerator) null;

    [Token(Token = "0x600F73B")]
    [Address(RVA = "0xB71630", Offset = "0xB70430", VA = "0x10B71630")]
    private void ReportCheckResult()
    {
    }

    [Token(Token = "0x600F73C")]
    [Address(RVA = "0xB715E0", Offset = "0xB703E0", VA = "0x10B715E0")]
    private void OnOnlineTimeReceived(TimeCheatingDetector.OnlineTimeResult result)
    {
    }

    [Token(Token = "0x600F73D")]
    [Address(RVA = "0xB70E70", Offset = "0xB6FC70", VA = "0x10B70E70")]
    private double GetLocalSecondsUtc() => new double();

    [Token(Token = "0x14000019")]
    [Obsolete("Please use CheatChecked event instead", true)]
    public event Action<TimeCheatingDetector.ErrorKind> Error
    {
      [Token(Token = "0x600F73E"), Address(RVA = "0xB722C0", Offset = "0xB710C0", VA = "0x10B722C0")] add
      {
      }
      [Token(Token = "0x600F73F"), Address(RVA = "0xB72680", Offset = "0xB71480", VA = "0x10B72680")] remove
      {
      }
    }

    [Token(Token = "0x1400001A")]
    [Obsolete("Please use CheatChecked event instead", true)]
    public event Action CheckPassed
    {
      [Token(Token = "0x600F740"), Address(RVA = "0xB72240", Offset = "0xB71040", VA = "0x10B72240")] add
      {
      }
      [Token(Token = "0x600F741"), Address(RVA = "0xB72600", Offset = "0xB71400", VA = "0x10B72600")] remove
      {
      }
    }

    [Token(Token = "0x600F742")]
    [Address(RVA = "0xB711B0", Offset = "0xB6FFB0", VA = "0x10B711B0")]
    [Obsolete("Please use GetOnlineTimeCoroutine or GetOnlineTimeTask instead", true)]
    public static double GetOnlineTime(string server) => new double();

    [Token(Token = "0x600F743")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    [Obsolete("Please use Instance.Error event instead.", true)]
    public static void SetErrorCallback(
      Action<TimeCheatingDetector.ErrorKind> errorCallback)
    {
    }

    [Token(Token = "0x600F744")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    [Obsolete("Please use StartDetection(int, ...) instead.", true)]
    public static void StartDetection(Action detectionCallback, int interval)
    {
    }

    [Token(Token = "0x600F745")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    [Obsolete("Please use StartDetection(int, ...) instead.", true)]
    public static void StartDetection(
      Action detectionCallback,
      Action<TimeCheatingDetector.ErrorKind> errorCallback,
      int interval)
    {
    }

    [Token(Token = "0x600F746")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    [Obsolete("Please use other overloads of this method instead", true)]
    public static void StartDetection(
      float interval,
      Action detectionCallback,
      Action<TimeCheatingDetector.ErrorKind> errorCallback,
      Action checkPassedCallback)
    {
    }

    [Token(Token = "0x600F747")]
    [Address(RVA = "0xB720E0", Offset = "0xB70EE0", VA = "0x10B720E0")]
    public TimeCheatingDetector()
    {
    }

    [Token(Token = "0x600F748")]
    [Address(RVA = "0xB72070", Offset = "0xB70E70", VA = "0x10B72070")]
    static TimeCheatingDetector()
    {
    }

    [Token(Token = "0x20036AE")]
    public delegate void OnlineTimeCallback(TimeCheatingDetector.OnlineTimeResult result);

    [Token(Token = "0x20036AF")]
    public delegate void TimeCheatingDetectorEventHandler(
      TimeCheatingDetector.CheckResult checkResult,
      TimeCheatingDetector.ErrorKind errorKind);

    [Token(Token = "0x20036B0")]
    public struct OnlineTimeResult
    {
      [Token(Token = "0x40100CC")]
      [FieldOffset(Offset = "0x0")]
      public bool success;
      [Token(Token = "0x40100CD")]
      [FieldOffset(Offset = "0x4")]
      public string error;
      [Token(Token = "0x40100CE")]
      [FieldOffset(Offset = "0x8")]
      public long errorResponseCode;
      [Token(Token = "0x40100CF")]
      [FieldOffset(Offset = "0x10")]
      public double onlineSecondsUtc;

      [Token(Token = "0x600F751")]
      [Address(RVA = "0xB704E0", Offset = "0xB6F2E0", VA = "0x10B704E0")]
      internal void SetTime(double secondsUtc)
      {
      }

      [Token(Token = "0x600F752")]
      [Address(RVA = "0xB704A0", Offset = "0xB6F2A0", VA = "0x10B704A0")]
      internal void SetError(string errorText, long responseCode = -1)
      {
      }

      [Token(Token = "0x600F753")]
      [Address(RVA = "0xB70520", Offset = "0xB6F320", VA = "0x10B70520", Slot = "3")]
      public override string ToString() => (string) null;
    }

    [Token(Token = "0x20036B1")]
    public enum CheckResult
    {
      [Token(Token = "0x40100D1")] Unknown = 0,
      [Token(Token = "0x40100D2")] CheckPassed = 5,
      [Token(Token = "0x40100D3")] WrongTimeDetected = 10, // 0x0000000A
      [Token(Token = "0x40100D4")] CheatDetected = 15, // 0x0000000F
      [Token(Token = "0x40100D5")] Error = 100, // 0x00000064
    }

    [Token(Token = "0x20036B2")]
    public enum ErrorKind
    {
      [Token(Token = "0x40100D7")] NoError = 0,
      [Token(Token = "0x40100D8")] IncorrectUri = 3,
      [Token(Token = "0x40100D9")] OnlineTimeError = 5,
      [Token(Token = "0x40100DA")] NotStarted = 10, // 0x0000000A
      [Token(Token = "0x40100DB")] AlreadyCheckingForCheat = 15, // 0x0000000F
      [Token(Token = "0x40100DC")] Unknown = 100, // 0x00000064
    }

    [Token(Token = "0x20036B3")]
    public enum RequestMethod
    {
      [Token(Token = "0x40100DE")] Head,
      [Token(Token = "0x40100DF")] Get,
    }
  }
}
