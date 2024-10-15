// Decompiled with JetBrains decompiler
// Type: DownloadObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000B7")]
public class DownloadObserver
{
  [Token(Token = "0x400036B")]
  [FieldOffset(Offset = "0x8")]
  private readonly MonoBehaviour _coroutineExecuter;
  [Token(Token = "0x400036C")]
  [FieldOffset(Offset = "0xC")]
  private int _retryNumber;
  [Token(Token = "0x400036D")]
  [FieldOffset(Offset = "0x10")]
  private Dictionary<string, int> _itemCompressedSize;
  [Token(Token = "0x400036E")]
  [FieldOffset(Offset = "0x14")]
  private LinkedList<string> _requestUrlList;
  [Token(Token = "0x400036F")]
  [FieldOffset(Offset = "0x18")]
  private string _prefix;
  [Token(Token = "0x4000370")]
  [FieldOffset(Offset = "0x1C")]
  private readonly List<DownloadObseve> _downloadObserveList;

  [Token(Token = "0x170000BD")]
  private DownloadObserver.DownloadedAction _downloadedAction
  {
    [Token(Token = "0x600045D"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
    {
      return (DownloadObserver.DownloadedAction) null;
    }
    [Token(Token = "0x600045E"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
    {
    }
  }

  [Token(Token = "0x170000BE")]
  private DownloadObserver.DownloadingAction _downloadingAction
  {
    [Token(Token = "0x600045F"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
    {
      return (DownloadObserver.DownloadingAction) null;
    }
    [Token(Token = "0x6000460"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
    {
    }
  }

  [Token(Token = "0x170000BF")]
  private DownloadObserver.ComposeDownloadUriAction _uriAction
  {
    [Token(Token = "0x6000461"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
    {
      return (DownloadObserver.ComposeDownloadUriAction) null;
    }
    [Token(Token = "0x6000462"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
    {
    }
  }

  [Token(Token = "0x170000C0")]
  private DownloadObserver.DownloadCondition _downloadCondition
  {
    [Token(Token = "0x6000463"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
    {
      return (DownloadObserver.DownloadCondition) null;
    }
    [Token(Token = "0x6000464"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
    {
    }
  }

  [Token(Token = "0x170000C1")]
  public bool IsWait
  {
    [Token(Token = "0x6000465"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000466"), Address(RVA = "0x3A1250", Offset = "0x3A0050", VA = "0x103A1250")] set
    {
    }
  }

  [Token(Token = "0x170000C2")]
  public bool IsAborting
  {
    [Token(Token = "0x6000467"), Address(RVA = "0x7F55A0", Offset = "0x7F43A0", VA = "0x107F55A0")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000468"), Address(RVA = "0x9728A0", Offset = "0x9716A0", VA = "0x109728A0")] private set
    {
    }
  }

  [Token(Token = "0x170000C3")]
  public bool IsFailured
  {
    [Token(Token = "0x6000469"), Address(RVA = "0x972890", Offset = "0x971690", VA = "0x10972890")] get
    {
      return new bool();
    }
    [Token(Token = "0x600046A"), Address(RVA = "0x9728B0", Offset = "0x9716B0", VA = "0x109728B0")] private set
    {
    }
  }

  [Token(Token = "0x170000C4")]
  public bool IsCompleted
  {
    [Token(Token = "0x600046B"), Address(RVA = "0xAAD900", Offset = "0xAAC700", VA = "0x10AAD900")] get
    {
      return new bool();
    }
    [Token(Token = "0x600046C"), Address(RVA = "0xAAFB40", Offset = "0xAAE940", VA = "0x10AAFB40")] private set
    {
    }
  }

  [Token(Token = "0x600046D")]
  [Address(RVA = "0xB8B920", Offset = "0xB8A720", VA = "0x10B8B920")]
  public DownloadObserver(
    MonoBehaviour behavior,
    int parallelNumber,
    int retryNumber,
    DownloadObserver.DownloadCondition downloadCondition)
  {
  }

  [Token(Token = "0x600046E")]
  [Address(RVA = "0xB8B620", Offset = "0xB8A420", VA = "0x10B8B620")]
  public void StartDownloads(
    string prefix,
    List<string> param,
    Dictionary<string, int> itemCompressedSize,
    DownloadObserver.DownloadedAction downloadedAction,
    DownloadObserver.DownloadingAction downloadingAction,
    DownloadObserver.ComposeDownloadUriAction uriAction)
  {
  }

  [Token(Token = "0x600046F")]
  [Address(RVA = "0xB8B5B0", Offset = "0xB8A3B0", VA = "0x10B8B5B0")]
  private IEnumerator RunDownloadTask() => (IEnumerator) null;

  [Token(Token = "0x6000470")]
  [Address(RVA = "0xB8ABF0", Offset = "0xB899F0", VA = "0x10B8ABF0")]
  private void AddDownloadObserve()
  {
  }

  [Token(Token = "0x6000471")]
  [Address(RVA = "0xB8B0E0", Offset = "0xB89EE0", VA = "0x10B8B0E0")]
  private bool CanWriteMemoryStreamEvent(int contentsSize) => new bool();

  [Token(Token = "0x6000472")]
  [Address(RVA = "0xB8B260", Offset = "0xB8A060", VA = "0x10B8B260")]
  private void DownloadingEvent(string identificationKey, int loadingSize)
  {
  }

  [Token(Token = "0x6000473")]
  [Address(RVA = "0xB8B290", Offset = "0xB8A090", VA = "0x10B8B290")]
  public List<DownloadObseve.DownloadInfo> GetDownloadInfo()
  {
    return (List<DownloadObseve.DownloadInfo>) null;
  }

  [Token(Token = "0x6000474")]
  [Address(RVA = "0xB8AB00", Offset = "0xB89900", VA = "0x10B8AB00")]
  public void Abort()
  {
  }

  [Token(Token = "0x6000475")]
  [Address(RVA = "0xB8AB00", Offset = "0xB89900", VA = "0x10B8AB00")]
  private void FailureEvent(string errorText)
  {
  }

  [Token(Token = "0x6000476")]
  [Address(RVA = "0xB8B070", Offset = "0xB89E70", VA = "0x10B8B070")]
  private IEnumerator AllStopObserve() => (IEnumerator) null;

  [Token(Token = "0x6000477")]
  [Address(RVA = "0xB8B860", Offset = "0xB8A660", VA = "0x10B8B860")]
  private void SuccessEvent(
    DownloadObseve observe,
    string identificationKey,
    byte[] bytes,
    int size,
    double downloadTime)
  {
  }

  [Token(Token = "0x6000478")]
  [Address(RVA = "0xB8B590", Offset = "0xB8A390", VA = "0x10B8B590")]
  public bool IsDone() => new bool();

  [Token(Token = "0x6000479")]
  [Address(RVA = "0xB8B530", Offset = "0xB8A330", VA = "0x10B8B530")]
  private bool IsAllDownloaded() => new bool();

  [Token(Token = "0x600047A")]
  [Address(RVA = "0xB8B180", Offset = "0xB89F80", VA = "0x10B8B180")]
  public void Dispose()
  {
  }

  [Token(Token = "0x20000B8")]
  public delegate void DownloadingAction(string identificationKey, int loadingSize);

  [Token(Token = "0x20000B9")]
  public delegate void DownloadedAction(
    string identificationKey,
    byte[] bytes,
    int size,
    double downloadTime);

  [Token(Token = "0x20000BA")]
  public delegate string ComposeDownloadUriAction(string prefix, string url);

  [Token(Token = "0x20000BB")]
  public delegate bool DownloadCondition();
}
