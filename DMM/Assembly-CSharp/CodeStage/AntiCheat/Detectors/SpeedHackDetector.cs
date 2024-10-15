// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Detectors.SpeedHackDetector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace CodeStage.AntiCheat.Detectors
{
  [Token(Token = "0x20036AC")]
  [HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_speed_hack_detector.html")]
  [DisallowMultipleComponent]
  [AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Speed Hack Detector")]
  public class SpeedHackDetector : ACTkDetectorBase
  {
    [Token(Token = "0x40100A0")]
    internal const string ComponentName = "Speed Hack Detector";
    [Token(Token = "0x40100A1")]
    internal const string LogPrefix = "[ACTk] Speed Hack Detector: ";
    [Token(Token = "0x40100A2")]
    private const long TicksPerSecond = 10000000;
    [Token(Token = "0x40100A3")]
    private const int Threshold = 5000000;
    [Token(Token = "0x40100A4")]
    private const float ThresholdFloat = 0.5f;
    [Token(Token = "0x40100A5")]
    [FieldOffset(Offset = "0x0")]
    private static int instancesInScene;
    [Token(Token = "0x40100A6")]
    [FieldOffset(Offset = "0x1C")]
    [Tooltip("Time (in seconds) between detector checks.")]
    public float interval;
    [Token(Token = "0x40100A7")]
    [FieldOffset(Offset = "0x20")]
    [Tooltip("Maximum false positives count allowed before registering speed hack.")]
    public byte maxFalsePositives;
    [Token(Token = "0x40100A8")]
    [FieldOffset(Offset = "0x24")]
    [Tooltip("Amount of sequential successful checks before clearing internal false positives counter.\nSet 0 to disable Cool Down feature.")]
    public int coolDown;
    [Token(Token = "0x40100A9")]
    [FieldOffset(Offset = "0x28")]
    private byte currentFalsePositives;
    [Token(Token = "0x40100AA")]
    [FieldOffset(Offset = "0x2C")]
    private int currentCooldownShots;
    [Token(Token = "0x40100AB")]
    [FieldOffset(Offset = "0x30")]
    private long ticksOnStart;
    [Token(Token = "0x40100AC")]
    [FieldOffset(Offset = "0x38")]
    private long vulnerableTicksOnStart;
    [Token(Token = "0x40100AD")]
    [FieldOffset(Offset = "0x40")]
    private long previousTicks;
    [Token(Token = "0x40100AE")]
    [FieldOffset(Offset = "0x48")]
    private long previousIntervalTicks;
    [Token(Token = "0x40100AF")]
    [FieldOffset(Offset = "0x50")]
    private float vulnerableTimeOnStart;

    [Token(Token = "0x600F6FB")]
    [Address(RVA = "0xB63FD0", Offset = "0xB62DD0", VA = "0x10B63FD0")]
    public static SpeedHackDetector AddToSceneOrGetExisting() => (SpeedHackDetector) null;

    [Token(Token = "0x600F6FC")]
    [Address(RVA = "0xB64680", Offset = "0xB63480", VA = "0x10B64680")]
    public static void StartDetection()
    {
    }

    [Token(Token = "0x600F6FD")]
    [Address(RVA = "0xB64880", Offset = "0xB63680", VA = "0x10B64880")]
    public static void StartDetection(Action callback)
    {
    }

    [Token(Token = "0x600F6FE")]
    [Address(RVA = "0xB64820", Offset = "0xB63620", VA = "0x10B64820")]
    public static void StartDetection(Action callback, float interval)
    {
    }

    [Token(Token = "0x600F6FF")]
    [Address(RVA = "0xB64940", Offset = "0xB63740", VA = "0x10B64940")]
    public static void StartDetection(Action callback, float interval, byte maxFalsePositives)
    {
    }

    [Token(Token = "0x600F700")]
    [Address(RVA = "0xB64900", Offset = "0xB63700", VA = "0x10B64900")]
    public static void StartDetection(
      Action callback,
      float interval,
      byte maxFalsePositives,
      int coolDown)
    {
    }

    [Token(Token = "0x600F701")]
    [Address(RVA = "0xB64990", Offset = "0xB63790", VA = "0x10B64990")]
    public static void StopDetection()
    {
    }

    [Token(Token = "0x600F702")]
    [Address(RVA = "0xB64210", Offset = "0xB63010", VA = "0x10B64210")]
    public static void Dispose()
    {
    }

    [Token(Token = "0x17002374")]
    public static SpeedHackDetector Instance
    {
      [Token(Token = "0x600F703"), Address(RVA = "0xB64E50", Offset = "0xB63C50", VA = "0x10B64E50")] get
      {
        return (SpeedHackDetector) null;
      }
      [Token(Token = "0x600F704"), Address(RVA = "0xB64E80", Offset = "0xB63C80", VA = "0x10B64E80")] private set
      {
      }
    }

    [Token(Token = "0x17002375")]
    private static SpeedHackDetector GetOrCreateInstance
    {
      [Token(Token = "0x600F705"), Address(RVA = "0xB64CB0", Offset = "0xB63AB0", VA = "0x10B64CB0")] get
      {
        return (SpeedHackDetector) null;
      }
    }

    [Token(Token = "0x600F706")]
    [Address(RVA = "0xB64C70", Offset = "0xB63A70", VA = "0x10B64C70")]
    private SpeedHackDetector()
    {
    }

    [Token(Token = "0x600F707")]
    [Address(RVA = "0xB63FE0", Offset = "0xB62DE0", VA = "0x10B63FE0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600F708")]
    [Address(RVA = "0xB64350", Offset = "0xB63150", VA = "0x10B64350", Slot = "4")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600F709")]
    [Address(RVA = "0xB64390", Offset = "0xB63190", VA = "0x10B64390")]
    private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
    {
    }

    [Token(Token = "0x600F70A")]
    [Address(RVA = "0xB64330", Offset = "0xB63130", VA = "0x10B64330")]
    private void OnApplicationPause(bool pause)
    {
    }

    [Token(Token = "0x600F70B")]
    [Address(RVA = "0xB64A50", Offset = "0xB63850", VA = "0x10B64A50")]
    private void Update()
    {
    }

    [Token(Token = "0x600F70C")]
    [Address(RVA = "0xB64510", Offset = "0xB63310", VA = "0x10B64510")]
    private void StartDetectionInternal(
      Action callback,
      float checkInterval,
      byte falsePositives,
      int shotsTillCooldown)
    {
    }

    [Token(Token = "0x600F70D")]
    [Address(RVA = "0xB644E0", Offset = "0xB632E0", VA = "0x10B644E0", Slot = "12")]
    protected override void StartDetectionAutomatically()
    {
    }

    [Token(Token = "0x600F70E")]
    [Address(RVA = "0xB64110", Offset = "0xB62F10", VA = "0x10B64110", Slot = "7")]
    protected override void DisposeInternal()
    {
    }

    [Token(Token = "0x600F70F")]
    [Address(RVA = "0xB64440", Offset = "0xB63240", VA = "0x10B64440")]
    private void ResetStartTicks()
    {
    }

    [Token(Token = "0x600F710")]
    [Address(RVA = "0xB642D0", Offset = "0xB630D0", VA = "0x10B642D0")]
    private long GetReliableTicks() => new long();
  }
}
