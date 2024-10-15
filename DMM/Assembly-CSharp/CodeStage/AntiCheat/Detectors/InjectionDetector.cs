// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Detectors.InjectionDetector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace CodeStage.AntiCheat.Detectors
{
  [Token(Token = "0x20036AA")]
  [HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_injection_detector.html")]
  [AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Injection Detector")]
  [DisallowMultipleComponent]
  public class InjectionDetector : ACTkDetectorBase
  {
    [Token(Token = "0x4010095")]
    internal const string ComponentName = "Injection Detector";
    [Token(Token = "0x4010096")]
    internal const string FinalLogPrefix = "[ACTk] Injection Detector: ";

    [Token(Token = "0x17002370")]
    public static InjectionDetector Instance
    {
      [Token(Token = "0x600F6E4"), Address(RVA = "0xB472E0", Offset = "0xB460E0", VA = "0x10B472E0")] get
      {
        return (InjectionDetector) null;
      }
    }

    [Token(Token = "0x600F6E5")]
    [Address(RVA = "0xB47240", Offset = "0xB46040", VA = "0x10B47240")]
    public static void StartDetection()
    {
    }

    [Token(Token = "0x600F6E6")]
    [Address(RVA = "0xB471F0", Offset = "0xB45FF0", VA = "0x10B471F0")]
    public static void StartDetection(Action<string> callback)
    {
    }

    [Token(Token = "0x600F6E7")]
    [Address(RVA = "0xB47290", Offset = "0xB46090", VA = "0x10B47290")]
    public static void StopDetection()
    {
    }

    [Token(Token = "0x600F6E8")]
    [Address(RVA = "0xB47150", Offset = "0xB45F50", VA = "0x10B47150")]
    public static void Dispose()
    {
    }

    [Token(Token = "0x600F6E9")]
    [Address(RVA = "0xB471A0", Offset = "0xB45FA0", VA = "0x10B471A0", Slot = "12")]
    protected override void StartDetectionAutomatically()
    {
    }

    [Token(Token = "0x600F6EA")]
    [Address(RVA = "0xB46E10", Offset = "0xB45C10", VA = "0x10B46E10")]
    public InjectionDetector()
    {
    }
  }
}
