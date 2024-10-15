// Decompiled with JetBrains decompiler
// Type: HttpClient
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000100")]
public class HttpClient : DLCDownloadClient
{
  [Token(Token = "0x40004CA")]
  private const int SleepTime = 50;
  [Token(Token = "0x40004CB")]
  [FieldOffset(Offset = "0x38")]
  private MemoryStream _requestData;
  [Token(Token = "0x40004CC")]
  [FieldOffset(Offset = "0x3C")]
  private byte[] _exchangedBytes;
  [Token(Token = "0x40004CD")]
  [FieldOffset(Offset = "0x40")]
  private Thread _thread;
  [Token(Token = "0x40004CE")]
  [FieldOffset(Offset = "0x44")]
  private TcpClient _tcpClient;
  [Token(Token = "0x40004CF")]
  [FieldOffset(Offset = "0x0")]
  protected static byte[] Eol;
  [Token(Token = "0x40004D0")]
  [FieldOffset(Offset = "0x48")]
  private int _timeOutCount;

  [Token(Token = "0x600069F")]
  [Address(RVA = "0xD59170", Offset = "0xD57F70", VA = "0x10D59170")]
  private static void PrintCertificate(X509Certificate certificate)
  {
  }

  [Token(Token = "0x60006A0")]
  [Address(RVA = "0xD59AE0", Offset = "0xD588E0", VA = "0x10D59AE0")]
  private static bool RemoteCertificateValidationCallback(
    object sender,
    X509Certificate certificate,
    X509Chain chain,
    SslPolicyErrors sslPolicyErrors)
  {
    return new bool();
  }

  [Token(Token = "0x60006A1")]
  [Address(RVA = "0xD59000", Offset = "0xD57E00", VA = "0x10D59000", Slot = "10")]
  public override void Download(string url, int size, MonoBehaviour coroutineExecuter = null)
  {
  }

  [Token(Token = "0x60006A2")]
  [Address(RVA = "0xD58D90", Offset = "0xD57B90", VA = "0x10D58D90")]
  private void CollectHeaders(Stream inputStream)
  {
  }

  [Token(Token = "0x60006A3")]
  [Address(RVA = "0xD596C0", Offset = "0xD584C0", VA = "0x10D596C0")]
  private static string[] ReadKeyValue(Stream stream) => (string[]) null;

  [Token(Token = "0x60006A4")]
  [Address(RVA = "0xD59DF0", Offset = "0xD58BF0", VA = "0x10D59DF0")]
  private void WriteMemoryStreamResponse(Stream stream)
  {
  }

  [Token(Token = "0x60006A5")]
  [Address(RVA = "0xD59370", Offset = "0xD58170", VA = "0x10D59370")]
  private void ReadCallback(IAsyncResult asyncResult)
  {
  }

  [Token(Token = "0x17000108")]
  public override int LoadingSize
  {
    [Token(Token = "0x60006A6"), Address(RVA = "0xD5A030", Offset = "0xD58E30", VA = "0x10D5A030", Slot = "4")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x17000109")]
  public override byte[] DataBytes
  {
    [Token(Token = "0x60006A7"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010", Slot = "6")] get
    {
      return (byte[]) null;
    }
  }

  [Token(Token = "0x1700010A")]
  public override int DownloadedSize
  {
    [Token(Token = "0x60006A8"), Address(RVA = "0xD5A010", Offset = "0xD58E10", VA = "0x10D5A010", Slot = "8")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x60006A9")]
  [Address(RVA = "0xD59B80", Offset = "0xD58980", VA = "0x10D59B80")]
  private void WriteHeaderTo(Stream socket, Uri uri)
  {
  }

  [Token(Token = "0x60006AA")]
  [Address(RVA = "0xD59840", Offset = "0xD58640", VA = "0x10D59840")]
  private static string ReadLine(Stream stream) => (string) null;

  [Token(Token = "0x60006AB")]
  [Address(RVA = "0xD58BE0", Offset = "0xD579E0", VA = "0x10D58BE0")]
  private static void CheckHttpHeader(Stream inputStream)
  {
  }

  [Token(Token = "0x60006AC")]
  [Address(RVA = "0xD58B50", Offset = "0xD57950", VA = "0x10D58B50", Slot = "11")]
  public override void Abort()
  {
  }

  [Token(Token = "0x60006AD")]
  [Address(RVA = "0xD58F90", Offset = "0xD57D90", VA = "0x10D58F90", Slot = "12")]
  public override void Dispose()
  {
  }

  [Token(Token = "0x60006AE")]
  [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
  public HttpClient()
  {
  }

  [Token(Token = "0x60006AF")]
  [Address(RVA = "0xD59F90", Offset = "0xD58D90", VA = "0x10D59F90")]
  static HttpClient()
  {
  }
}
