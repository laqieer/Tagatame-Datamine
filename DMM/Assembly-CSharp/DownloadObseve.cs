// Decompiled with JetBrains decompiler
// Type: DownloadObseve
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000BE")]
public class DownloadObseve
{
  [Token(Token = "0x4000386")]
  [FieldOffset(Offset = "0x1C")]
  private IEnumerator _downloadEnumerator;
  [Token(Token = "0x400038A")]
  [FieldOffset(Offset = "0x2C")]
  private DLCDownloadClient p_downloadClient;
  [Token(Token = "0x400038B")]
  [FieldOffset(Offset = "0x30")]
  private bool instantiated;
  [Token(Token = "0x400038C")]
  [FieldOffset(Offset = "0x34")]
  private MonoBehaviour _coroutineExecuter;
  [Token(Token = "0x400038F")]
  [FieldOffset(Offset = "0x40")]
  public int CompressedSize;

  [Token(Token = "0x14000001")]
  public event DownloadObseve.FailureHandler Failure
  {
    [Token(Token = "0x6000497"), Address(RVA = "0xB8C150", Offset = "0xB8AF50", VA = "0x10B8C150")] add
    {
    }
    [Token(Token = "0x6000498"), Address(RVA = "0xB8C5A0", Offset = "0xB8B3A0", VA = "0x10B8C5A0")] remove
    {
    }
  }

  [Token(Token = "0x14000002")]
  public event DownloadObseve.LoadingHandler Loading
  {
    [Token(Token = "0x6000499"), Address(RVA = "0xB8C1D0", Offset = "0xB8AFD0", VA = "0x10B8C1D0")] add
    {
    }
    [Token(Token = "0x600049A"), Address(RVA = "0xB8C620", Offset = "0xB8B420", VA = "0x10B8C620")] remove
    {
    }
  }

  [Token(Token = "0x14000003")]
  public event DownloadObseve.SuccessHandler Success
  {
    [Token(Token = "0x600049B"), Address(RVA = "0xB8C2D0", Offset = "0xB8B0D0", VA = "0x10B8C2D0")] add
    {
    }
    [Token(Token = "0x600049C"), Address(RVA = "0xB8C720", Offset = "0xB8B520", VA = "0x10B8C720")] remove
    {
    }
  }

  [Token(Token = "0x14000004")]
  public event DownloadObseve.RetryHandler Retry
  {
    [Token(Token = "0x600049D"), Address(RVA = "0xB8C250", Offset = "0xB8B050", VA = "0x10B8C250")] add
    {
    }
    [Token(Token = "0x600049E"), Address(RVA = "0xB8C6A0", Offset = "0xB8B4A0", VA = "0x10B8C6A0")] remove
    {
    }
  }

  [Token(Token = "0x14000005")]
  public event DownloadObseve.CanWriteHandler CanWrite
  {
    [Token(Token = "0x600049F"), Address(RVA = "0xB8C0D0", Offset = "0xB8AED0", VA = "0x10B8C0D0")] add
    {
    }
    [Token(Token = "0x60004A0"), Address(RVA = "0xB8C520", Offset = "0xB8B320", VA = "0x10B8C520")] remove
    {
    }
  }

  [Token(Token = "0x170000C9")]
  private int _size
  {
    [Token(Token = "0x60004A1"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
    {
      return new int();
    }
    [Token(Token = "0x60004A2"), Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")] set
    {
    }
  }

  [Token(Token = "0x170000CA")]
  private string _url
  {
    [Token(Token = "0x60004A3"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
    {
      return (string) null;
    }
    [Token(Token = "0x60004A4"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] set
    {
    }
  }

  [Token(Token = "0x170000CB")]
  private string _identificationKey
  {
    [Token(Token = "0x60004A5"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
    {
      return (string) null;
    }
    [Token(Token = "0x60004A6"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
    {
    }
  }

  [Token(Token = "0x170000CC")]
  private DLCDownloadClient _downloadClient
  {
    [Token(Token = "0x60004A7"), Address(RVA = "0xB8C420", Offset = "0xB8B220", VA = "0x10B8C420")] get
    {
      return (DLCDownloadClient) null;
    }
  }

  [Token(Token = "0x170000CD")]
  public int RetryCount
  {
    [Token(Token = "0x60004A8"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
    {
      return new int();
    }
    [Token(Token = "0x60004A9"), Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")] private set
    {
    }
  }

  [Token(Token = "0x170000CE")]
  public int MaxRetryNumber
  {
    [Token(Token = "0x60004AA"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
    {
      return new int();
    }
    [Token(Token = "0x60004AB"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] private set
    {
    }
  }

  [Token(Token = "0x170000CF")]
  public int ContentsSize
  {
    [Token(Token = "0x60004AC"), Address(RVA = "0xB8C400", Offset = "0xB8B200", VA = "0x10B8C400")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000D0")]
  public bool CanWriteStream
  {
    [Token(Token = "0x60004AD"), Address(RVA = "0xB8C3E0", Offset = "0xB8B1E0", VA = "0x10B8C3E0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170000D1")]
  public DownloadObseve.StateEnum State
  {
    [Token(Token = "0x60004AE"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
    {
      return new DownloadObseve.StateEnum();
    }
    [Token(Token = "0x60004AF"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] private set
    {
    }
  }

  [Token(Token = "0x60004B0")]
  [Address(RVA = "0xB8BD40", Offset = "0xB8AB40", VA = "0x10B8BD40")]
  public DownloadObseve()
  {
  }

  [Token(Token = "0x60004B1")]
  [Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")]
  public void SetRetryNumber(int retryNumber)
  {
  }

  [Token(Token = "0x60004B2")]
  [Address(RVA = "0xB8BCA0", Offset = "0xB8AAA0", VA = "0x10B8BCA0")]
  public void StartDownload(
    string identificationKey,
    MonoBehaviour behabior,
    string url,
    int size)
  {
  }

  [Token(Token = "0x60004B3")]
  [Address(RVA = "0xB8BB40", Offset = "0xB8A940", VA = "0x10B8BB40")]
  private IEnumerator Download() => (IEnumerator) null;

  [Token(Token = "0x60004B4")]
  [Address(RVA = "0xB8C350", Offset = "0xB8B150", VA = "0x10B8C350")]
  public DownloadObseve.DownloadInfo getDownloadInfo() => new DownloadObseve.DownloadInfo();

  [Token(Token = "0x60004B5")]
  [Address(RVA = "0xB8BBA0", Offset = "0xB8A9A0", VA = "0x10B8BBA0")]
  private void RetryDownload()
  {
  }

  [Token(Token = "0x60004B6")]
  [Address(RVA = "0xB8BA90", Offset = "0xB8A890", VA = "0x10B8BA90")]
  private bool CanRetryDownload() => new bool();

  [Token(Token = "0x60004B7")]
  [Address(RVA = "0xB8BA30", Offset = "0xB8A830", VA = "0x10B8BA30")]
  public IEnumerator Abort() => (IEnumerator) null;

  [Token(Token = "0x60004B8")]
  [Address(RVA = "0xB8BAB0", Offset = "0xB8A8B0", VA = "0x10B8BAB0")]
  public void Dispose()
  {
  }

  [Token(Token = "0x20000BF")]
  public enum StateEnum
  {
    [Token(Token = "0x4000392")] IsRunning,
    [Token(Token = "0x4000393")] IsCompleted,
    [Token(Token = "0x4000394")] IsFailureFinished,
    [Token(Token = "0x4000395")] IsDestroying,
    [Token(Token = "0x4000396")] IsDestroyed,
    [Token(Token = "0x4000397")] IsNone,
  }

  [Token(Token = "0x20000C0")]
  public delegate void FailureHandler(string errorText);

  [Token(Token = "0x20000C1")]
  public delegate void LoadingHandler(string identificationKey, int loadingSize);

  [Token(Token = "0x20000C2")]
  public delegate void SuccessHandler(
    DownloadObseve observe,
    string identificationKey,
    byte[] bytes,
    int size,
    double downloadTime);

  [Token(Token = "0x20000C3")]
  public delegate bool CanWriteHandler(int contentsSize);

  [Token(Token = "0x20000C4")]
  public delegate void RetryHandler();

  [Token(Token = "0x20000C5")]
  public struct DownloadInfo
  {
    [Token(Token = "0x4000398")]
    [FieldOffset(Offset = "0x0")]
    public string identificationKey;
    [Token(Token = "0x4000399")]
    [FieldOffset(Offset = "0x8")]
    public long position;
    [Token(Token = "0x400039A")]
    [FieldOffset(Offset = "0x10")]
    public int ContentLength;
  }
}
