// Decompiled with JetBrains decompiler
// Type: CodeStage.AntiCheat.Detectors.ACTkDetectorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace CodeStage.AntiCheat.Detectors
{
  [Token(Token = "0x20036A9")]
  [AddComponentMenu("")]
  public abstract class ACTkDetectorBase : MonoBehaviour
  {
    [Token(Token = "0x4010089")]
    protected const string ContainerName = "Anti-Cheat Toolkit Detectors";
    [Token(Token = "0x401008A")]
    protected const string MenuPath = "Code Stage/Anti-Cheat Toolkit/";
    [Token(Token = "0x401008B")]
    protected const string GameObjectMenuPath = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";
    [Token(Token = "0x401008C")]
    [FieldOffset(Offset = "0x0")]
    protected static GameObject detectorsContainer;
    [Token(Token = "0x401008D")]
    [FieldOffset(Offset = "0xC")]
    [Tooltip("Automatically start detector. Detection Event will be called on detection.")]
    public bool autoStart;
    [Token(Token = "0x401008E")]
    [FieldOffset(Offset = "0xD")]
    [Tooltip("Detector will survive new level (scene) load if checked.")]
    public bool keepAlive;
    [Token(Token = "0x401008F")]
    [FieldOffset(Offset = "0xE")]
    [Tooltip("Automatically dispose Detector after firing callback.")]
    public bool autoDispose;
    [Token(Token = "0x4010091")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    protected UnityEvent detectionEvent;
    [Token(Token = "0x4010092")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected bool detectionEventHasListener;
    [Token(Token = "0x4010093")]
    [FieldOffset(Offset = "0x19")]
    protected bool started;
    [Token(Token = "0x4010094")]
    [FieldOffset(Offset = "0x1A")]
    protected bool isRunning;

    [Token(Token = "0x14000017")]
    public event Action CheatDetected
    {
      [Token(Token = "0x600F6D3"), Address(RVA = "0xB46E30", Offset = "0xB45C30", VA = "0x10B46E30")] add
      {
      }
      [Token(Token = "0x600F6D4"), Address(RVA = "0xB46EB0", Offset = "0xB45CB0", VA = "0x10B46EB0")] remove
      {
      }
    }

    [Token(Token = "0x1700236F")]
    public bool IsRunning
    {
      [Token(Token = "0x600F6D5"), Address(RVA = "0x408500", Offset = "0x407300", VA = "0x10408500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F6D6")]
    [Address(RVA = "0xB46D00", Offset = "0xB45B00", VA = "0x10B46D00")]
    private void Start()
    {
    }

    [Token(Token = "0x600F6D7")]
    [Address(RVA = "0xB46C80", Offset = "0xB45A80", VA = "0x10B46C80")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600F6D8")]
    [Address(RVA = "0x77B5F0", Offset = "0x77A3F0", VA = "0x1077B5F0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600F6D9")]
    [Address(RVA = "0xB46AF0", Offset = "0xB458F0", VA = "0x10B46AF0")]
    private void OnApplicationQuit()
    {
    }

    [Token(Token = "0x600F6DA")]
    [Address(RVA = "0xB46B80", Offset = "0xB45980", VA = "0x10B46B80", Slot = "4")]
    protected virtual void OnDestroy()
    {
    }

    [Token(Token = "0x600F6DB")]
    [Address(RVA = "0xB46B10", Offset = "0xB45910", VA = "0x10B46B10", Slot = "5")]
    internal virtual void OnCheatingDetected()
    {
    }

    [Token(Token = "0x600F6DC")]
    [Address(RVA = "0xB46930", Offset = "0xB45730", VA = "0x10B46930", Slot = "6")]
    protected virtual bool Init(ACTkDetectorBase instance, string detectorName) => new bool();

    [Token(Token = "0x600F6DD")]
    [Address(RVA = "0xB468E0", Offset = "0xB456E0", VA = "0x10B468E0", Slot = "7")]
    protected virtual void DisposeInternal()
    {
    }

    [Token(Token = "0x600F6DE")]
    [Address(RVA = "0xB468C0", Offset = "0xB456C0", VA = "0x10B468C0", Slot = "8")]
    protected virtual bool DetectorHasCallbacks() => new bool();

    [Token(Token = "0x600F6DF")]
    [Address(RVA = "0xB46DE0", Offset = "0xB45BE0", VA = "0x10B46DE0", Slot = "9")]
    protected virtual void StopDetectionInternal()
    {
    }

    [Token(Token = "0x600F6E0")]
    [Address(RVA = "0xB46CA0", Offset = "0xB45AA0", VA = "0x10B46CA0", Slot = "10")]
    protected virtual void PauseDetector()
    {
    }

    [Token(Token = "0x600F6E1")]
    [Address(RVA = "0xB46CC0", Offset = "0xB45AC0", VA = "0x10B46CC0", Slot = "11")]
    protected virtual bool ResumeDetector() => new bool();

    [Token(Token = "0x600F6E2")]
    protected abstract void StartDetectionAutomatically();

    [Token(Token = "0x600F6E3")]
    [Address(RVA = "0xB46E10", Offset = "0xB45C10", VA = "0x10B46E10")]
    protected ACTkDetectorBase()
    {
    }
  }
}
