// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebQueue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Auth;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x200358D")]
  public class WebQueue : IEnumerator
  {
    [Token(Token = "0x400FD2F")]
    [FieldOffset(Offset = "0x4")]
    private static bool _sceneLoaded;
    [Token(Token = "0x400FD30")]
    [FieldOffset(Offset = "0xC")]
    private bool _lazyStarted;
    [Token(Token = "0x400FD31")]
    [FieldOffset(Offset = "0x10")]
    private object subroutine;
    [Token(Token = "0x400FD32")]
    [FieldOffset(Offset = "0x14")]
    private IRefreshTokenTask authTask;
    [Token(Token = "0x400FD33")]
    [FieldOffset(Offset = "0x18")]
    private System.Type execludRetryType;
    [Token(Token = "0x400FD34")]
    [FieldOffset(Offset = "0x1C")]
    private bool needAuthorization;
    [Token(Token = "0x400FD35")]
    [FieldOffset(Offset = "0x20")]
    private readonly List<IWebTask> executedTasks;
    [Token(Token = "0x400FD36")]
    [FieldOffset(Offset = "0x24")]
    private readonly WebQueue.SerialQueue serialQueue;
    [Token(Token = "0x400FD37")]
    [FieldOffset(Offset = "0x28")]
    private readonly WebQueue.ParallelQueue parallelQueue;
    [Token(Token = "0x400FD38")]
    [FieldOffset(Offset = "0x2C")]
    private bool pause;
    [Token(Token = "0x400FD39")]
    [FieldOffset(Offset = "0x2D")]
    private bool running;
    [Token(Token = "0x400FD3A")]
    [FieldOffset(Offset = "0x2E")]
    private bool activeStarted;

    [Token(Token = "0x170021EB")]
    public IWebQueueObserver Observer
    {
      [Token(Token = "0x600ED50"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (IWebQueueObserver) null;
      }
      [Token(Token = "0x600ED51"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x170021EC")]
    public static WebQueue defaultQueue
    {
      [Token(Token = "0x600ED52"), Address(RVA = "0xB1B2D0", Offset = "0xB1A0D0", VA = "0x10B1B2D0")] get
      {
        return (WebQueue) null;
      }
      [Token(Token = "0x600ED53"), Address(RVA = "0xB1B310", Offset = "0xB1A110", VA = "0x10B1B310")] private set
      {
      }
    }

    [Token(Token = "0x170021ED")]
    public bool isPause
    {
      [Token(Token = "0x600ED54"), Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170021EE")]
    public bool isRunning
    {
      [Token(Token = "0x600ED55"), Address(RVA = "0xB1B300", Offset = "0xB1A100", VA = "0x10B1B300")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600ED56")]
    [Address(RVA = "0xB1A2B0", Offset = "0xB190B0", VA = "0x10B1A2B0")]
    public static void Init(IWebQueueObserver observer)
    {
    }

    [Token(Token = "0x600ED57")]
    [Address(RVA = "0xB1B010", Offset = "0xB19E10", VA = "0x10B1B010")]
    public WebQueue()
    {
    }

    [Token(Token = "0x600ED58")]
    [Address(RVA = "0xB19CB0", Offset = "0xB18AB0", VA = "0x10B19CB0")]
    public void Add(IWebTask task)
    {
    }

    [Token(Token = "0x600ED59")]
    [Address(RVA = "0xB1A0B0", Offset = "0xB18EB0", VA = "0x10B1A0B0")]
    private bool HasNext() => new bool();

    [Token(Token = "0x600ED5A")]
    [Address(RVA = "0xB1A150", Offset = "0xB18F50", VA = "0x10B1A150")]
    private bool HasVisibleTasks() => new bool();

    [Token(Token = "0x600ED5B")]
    [Address(RVA = "0xB1AE00", Offset = "0xB19C00", VA = "0x10B1AE00")]
    public void Start()
    {
    }

    [Token(Token = "0x600ED5C")]
    [Address(RVA = "0xB1A380", Offset = "0xB19180", VA = "0x10B1A380")]
    private IEnumerator LazyStart() => (IEnumerator) null;

    [Token(Token = "0x600ED5D")]
    [Address(RVA = "0xB1ADD0", Offset = "0xB19BD0", VA = "0x10B1ADD0")]
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void SceneLoaded()
    {
    }

    [Token(Token = "0x600ED5E")]
    [Address(RVA = "0xB19FC0", Offset = "0xB18DC0", VA = "0x10B19FC0")]
    private static WebTaskResult GetTaskResults(List<IWebTask> tasks) => new WebTaskResult();

    [Token(Token = "0x600ED5F")]
    [Address(RVA = "0xB1A640", Offset = "0xB19440", VA = "0x10B1A640")]
    private void OnCompleted(List<IWebTask> executedTasks)
    {
    }

    [Token(Token = "0x600ED60")]
    [Address(RVA = "0xB1A540", Offset = "0xB19340", VA = "0x10B1A540")]
    private void Notify(List<IWebTask> tasks)
    {
    }

    [Token(Token = "0x600ED61")]
    [Address(RVA = "0xB1AC80", Offset = "0xB19A80", VA = "0x10B1AC80")]
    public void Pause(bool state = true)
    {
    }

    [Token(Token = "0x600ED62")]
    [Address(RVA = "0xB1ACA0", Offset = "0xB19AA0", VA = "0x10B1ACA0", Slot = "6")]
    public void Reset()
    {
    }

    [Token(Token = "0x170021EF")]
    public object Current
    {
      [Token(Token = "0x600ED63"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0", Slot = "5")] get
      {
        return (object) null;
      }
    }

    [Token(Token = "0x600ED64")]
    [Address(RVA = "0xB1A3F0", Offset = "0xB191F0", VA = "0x10B1A3F0", Slot = "4")]
    public bool MoveNext() => new bool();

    [Token(Token = "0x600ED65")]
    [Address(RVA = "0xB19DF0", Offset = "0xB18BF0", VA = "0x10B19DF0")]
    private object GetSubRoutine() => (object) null;

    [Token(Token = "0x200358E")]
    private class SerialQueue : IEnumerator
    {
      [Token(Token = "0x400FD3B")]
      [FieldOffset(Offset = "0x8")]
      private readonly LinkedList<IWebTask> queuedTasks;
      [Token(Token = "0x400FD3C")]
      [FieldOffset(Offset = "0xC")]
      private readonly List<IWebTask> executedTasks;
      [Token(Token = "0x400FD3D")]
      [FieldOffset(Offset = "0x10")]
      private readonly Action<List<IWebTask>> onCompleted;
      [Token(Token = "0x400FD3E")]
      [FieldOffset(Offset = "0x14")]
      private IWebTask currentTask;

      [Token(Token = "0x170021F0")]
      public bool isRunning
      {
        [Token(Token = "0x600ED67"), Address(RVA = "0xB112D0", Offset = "0xB100D0", VA = "0x10B112D0")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600ED68")]
      [Address(RVA = "0xB11200", Offset = "0xB10000", VA = "0x10B11200")]
      public SerialQueue(List<IWebTask> executedTasks, Action<List<IWebTask>> onCompleted)
      {
      }

      [Token(Token = "0x600ED69")]
      [Address(RVA = "0xB10E60", Offset = "0xB0FC60", VA = "0x10B10E60")]
      public bool HasNext() => new bool();

      [Token(Token = "0x600ED6A")]
      [Address(RVA = "0xB10DD0", Offset = "0xB0FBD0", VA = "0x10B10DD0")]
      public void Add(IWebTask task)
      {
      }

      [Token(Token = "0x600ED6B")]
      [Address(RVA = "0xB110B0", Offset = "0xB0FEB0", VA = "0x10B110B0")]
      public void Update()
      {
      }

      [Token(Token = "0x170021F1")]
      public object Current
      {
        [Token(Token = "0x600ED6C"), Address(RVA = "0xB11290", Offset = "0xB10090", VA = "0x10B11290", Slot = "5")] get
        {
          return (object) null;
        }
      }

      [Token(Token = "0x600ED6D")]
      [Address(RVA = "0xB10EC0", Offset = "0xB0FCC0", VA = "0x10B10EC0", Slot = "4")]
      public bool MoveNext() => new bool();

      [Token(Token = "0x600ED6E")]
      [Address(RVA = "0xB11050", Offset = "0xB0FE50", VA = "0x10B11050", Slot = "6")]
      public void Reset()
      {
      }
    }

    [Token(Token = "0x2003590")]
    private class ParallelQueue
    {
      [Token(Token = "0x400FD41")]
      [FieldOffset(Offset = "0x8")]
      private readonly List<IWebTask> queuedTasks;
      [Token(Token = "0x400FD42")]
      [FieldOffset(Offset = "0xC")]
      private readonly List<IWebTask> runningTasks;
      [Token(Token = "0x400FD43")]
      [FieldOffset(Offset = "0x10")]
      private readonly List<IWebTask> executedTasks;
      [Token(Token = "0x400FD44")]
      [FieldOffset(Offset = "0x14")]
      private readonly Action<List<IWebTask>> onCompleted;

      [Token(Token = "0x170021F2")]
      public bool isRunning
      {
        [Token(Token = "0x600ED72"), Address(RVA = "0xB0EA90", Offset = "0xB0D890", VA = "0x10B0EA90")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600ED73")]
      [Address(RVA = "0xB0E9D0", Offset = "0xB0D7D0", VA = "0x10B0E9D0")]
      public ParallelQueue(List<IWebTask> executedTasks, Action<List<IWebTask>> onCompleted)
      {
      }

      [Token(Token = "0x600ED74")]
      [Address(RVA = "0xB0E560", Offset = "0xB0D360", VA = "0x10B0E560")]
      public bool HasNext() => new bool();

      [Token(Token = "0x600ED75")]
      [Address(RVA = "0xB0E3A0", Offset = "0xB0D1A0", VA = "0x10B0E3A0")]
      public void Add(IWebTask task)
      {
      }

      [Token(Token = "0x600ED76")]
      [Address(RVA = "0xB0E630", Offset = "0xB0D430", VA = "0x10B0E630")]
      public void Update()
      {
      }

      [Token(Token = "0x600ED77")]
      [Address(RVA = "0xB0E3F0", Offset = "0xB0D1F0", VA = "0x10B0E3F0")]
      public void CancelAndRequeueAll()
      {
      }

      [Token(Token = "0x600ED78")]
      [Address(RVA = "0xB0E5B0", Offset = "0xB0D3B0", VA = "0x10B0E5B0")]
      public void Reset()
      {
      }
    }
  }
}
