// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector
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
  [Token(Token = "0x20036AB")]
  [HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_obscured_cheating_detector.html")]
  [AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Obscured Cheating Detector")]
  [DisallowMultipleComponent]
  public class ObscuredCheatingDetector : ACTkDetectorBase
  {
    [Token(Token = "0x4010097")]
    internal const string ComponentName = "Obscured Cheating Detector";
    [Token(Token = "0x4010098")]
    internal const string FinalLogPrefix = "[ACTk] Obscured Cheating Detector: ";
    [Token(Token = "0x4010099")]
    [FieldOffset(Offset = "0x0")]
    private static int instancesInScene;
    [Token(Token = "0x401009A")]
    [FieldOffset(Offset = "0x20")]
    [Tooltip("Max allowed difference between encrypted and fake values in ObscuredDouble. Increase in case of false positives.")]
    public double doubleEpsilon;
    [Token(Token = "0x401009B")]
    [FieldOffset(Offset = "0x28")]
    [Tooltip("Max allowed difference between encrypted and fake values in ObscuredFloat. Increase in case of false positives.")]
    public float floatEpsilon;
    [Token(Token = "0x401009C")]
    [FieldOffset(Offset = "0x2C")]
    [Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector2. Increase in case of false positives.")]
    public float vector2Epsilon;
    [Token(Token = "0x401009D")]
    [FieldOffset(Offset = "0x30")]
    [Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector3. Increase in case of false positives.")]
    public float vector3Epsilon;
    [Token(Token = "0x401009E")]
    [FieldOffset(Offset = "0x34")]
    [Tooltip("Max allowed difference between encrypted and fake values in ObscuredQuaternion. Increase in case of false positives.")]
    public float quaternionEpsilon;

    [Token(Token = "0x600F6EB")]
    [Address(RVA = "0xB49A10", Offset = "0xB48810", VA = "0x10B49A10")]
    public static ObscuredCheatingDetector AddToSceneOrGetExisting()
    {
      return (ObscuredCheatingDetector) null;
    }

    [Token(Token = "0x600F6EC")]
    [Address(RVA = "0xB49F60", Offset = "0xB48D60", VA = "0x10B49F60")]
    public static void StartDetection()
    {
    }

    [Token(Token = "0x600F6ED")]
    [Address(RVA = "0xB4A050", Offset = "0xB48E50", VA = "0x10B4A050")]
    public static void StartDetection(Action callback)
    {
    }

    [Token(Token = "0x600F6EE")]
    [Address(RVA = "0xB4A080", Offset = "0xB48E80", VA = "0x10B4A080")]
    public static void StopDetection()
    {
    }

    [Token(Token = "0x600F6EF")]
    [Address(RVA = "0xB49C50", Offset = "0xB48A50", VA = "0x10B49C50")]
    public static void Dispose()
    {
    }

    [Token(Token = "0x17002371")]
    public static ObscuredCheatingDetector Instance
    {
      [Token(Token = "0x600F6F0"), Address(RVA = "0xB4A3A0", Offset = "0xB491A0", VA = "0x10B4A3A0")] get
      {
        return (ObscuredCheatingDetector) null;
      }
      [Token(Token = "0x600F6F1"), Address(RVA = "0xB4A3D0", Offset = "0xB491D0", VA = "0x10B4A3D0")] private set
      {
      }
    }

    [Token(Token = "0x17002372")]
    private static ObscuredCheatingDetector GetOrCreateInstance
    {
      [Token(Token = "0x600F6F2"), Address(RVA = "0xB4A200", Offset = "0xB49000", VA = "0x10B4A200")] get
      {
        return (ObscuredCheatingDetector) null;
      }
    }

    [Token(Token = "0x17002373")]
    internal static bool ExistsAndIsRunning
    {
      [Token(Token = "0x600F6F3"), Address(RVA = "0xB4A190", Offset = "0xB48F90", VA = "0x10B4A190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F6F4")]
    [Address(RVA = "0xB4A140", Offset = "0xB48F40", VA = "0x10B4A140")]
    private ObscuredCheatingDetector()
    {
    }

    [Token(Token = "0x600F6F5")]
    [Address(RVA = "0xB49A20", Offset = "0xB48820", VA = "0x10B49A20")]
    private void Awake()
    {
    }

    [Token(Token = "0x600F6F6")]
    [Address(RVA = "0xB49D10", Offset = "0xB48B10", VA = "0x10B49D10", Slot = "4")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600F6F7")]
    [Address(RVA = "0xB49D50", Offset = "0xB48B50", VA = "0x10B49D50")]
    private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
    {
    }

    [Token(Token = "0x600F6F8")]
    [Address(RVA = "0xB49E20", Offset = "0xB48C20", VA = "0x10B49E20")]
    private void StartDetectionInternal(Action callback)
    {
    }

    [Token(Token = "0x600F6F9")]
    [Address(RVA = "0xB49E00", Offset = "0xB48C00", VA = "0x10B49E00", Slot = "12")]
    protected override void StartDetectionAutomatically()
    {
    }

    [Token(Token = "0x600F6FA")]
    [Address(RVA = "0xB49B50", Offset = "0xB48950", VA = "0x10B49B50", Slot = "7")]
    protected override void DisposeInternal()
    {
    }
  }
}
