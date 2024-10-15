// Decompiled with JetBrains decompiler
// Type: DownloaderClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

#nullable disable
[Token(Token = "0x20000B3")]
public class DownloaderClient : DLCDownloadClient
{
  [Token(Token = "0x400035A")]
  private const float sleepTime = 0.05f;
  [Token(Token = "0x400035B")]
  private const int timeoutTime = 10;
  [Token(Token = "0x400035C")]
  private const int bufferSize = 1048576;
  [Token(Token = "0x400035D")]
  [FieldOffset(Offset = "0x38")]
  private MonoBehaviour _coroutineExecuter;
  [Token(Token = "0x400035E")]
  [FieldOffset(Offset = "0x3C")]
  private IEnumerator _downloadEnumerator;
  [Token(Token = "0x400035F")]
  [FieldOffset(Offset = "0x40")]
  private IEnumerator _writeStreamEnumerator;
  [Token(Token = "0x4000360")]
  [FieldOffset(Offset = "0x44")]
  private UnityWebRequest _request;
  [Token(Token = "0x4000361")]
  [FieldOffset(Offset = "0x48")]
  private float _timeOutCount;

  [Token(Token = "0x170000B8")]
  public override int DownloadedSize
  {
    [Token(Token = "0x6000446"), Address(RVA = "0xB8CCD0", Offset = "0xB8BAD0", VA = "0x10B8CCD0", Slot = "8")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x6000447")]
  [Address(RVA = "0xB8CAA0", Offset = "0xB8B8A0", VA = "0x10B8CAA0", Slot = "10")]
  public override void Download(string url, int size, MonoBehaviour coroutineExecuter)
  {
  }

  [Token(Token = "0x6000448")]
  [Address(RVA = "0xB8CC60", Offset = "0xB8BA60", VA = "0x10B8CC60")]
  private IEnumerator _Download(string url) => (IEnumerator) null;

  [Token(Token = "0x6000449")]
  [Address(RVA = "0xB8C930", Offset = "0xB8B730", VA = "0x10B8C930", Slot = "11")]
  public override void Abort()
  {
  }

  [Token(Token = "0x600044A")]
  [Address(RVA = "0xB8CA00", Offset = "0xB8B800", VA = "0x10B8CA00", Slot = "12")]
  public override void Dispose()
  {
  }

  [Token(Token = "0x600044B")]
  [Address(RVA = "0xB8CBF0", Offset = "0xB8B9F0", VA = "0x10B8CBF0")]
  private IEnumerator WriteMemoryStreamResponse() => (IEnumerator) null;

  [Token(Token = "0x600044C")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public DownloaderClient()
  {
  }

  [Token(Token = "0x20000B4")]
  private class DLCDownloadHandler : DownloadHandlerScript
  {
    [Token(Token = "0x4000362")]
    [FieldOffset(Offset = "0xC")]
    private DownloaderClient loader;
    [Token(Token = "0x4000363")]
    [FieldOffset(Offset = "0x10")]
    private List<byte> buf;

    [Token(Token = "0x600044D")]
    [Address(RVA = "0xB84A90", Offset = "0xB83890", VA = "0x10B84A90")]
    public DLCDownloadHandler(DownloaderClient _loader, byte[] buffer)
    {
    }

    [Token(Token = "0x600044E")]
    [Address(RVA = "0xB849A0", Offset = "0xB837A0", VA = "0x10B849A0", Slot = "9")]
    protected override bool ReceiveData(byte[] data, int dataLength) => new bool();

    [Token(Token = "0x600044F")]
    [Address(RVA = "0xB84610", Offset = "0xB83410", VA = "0x10B84610")]
    private void BufCopy(byte[] bytes, int length)
    {
    }

    [Token(Token = "0x6000450")]
    [Address(RVA = "0xB84850", Offset = "0xB83650", VA = "0x10B84850", Slot = "12")]
    protected override void CompleteContent()
    {
    }
  }
}
