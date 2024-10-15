// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebInternalResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Networking;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003587")]
  public class WebInternalResponse
  {
    [Token(Token = "0x400FD13")]
    [FieldOffset(Offset = "0x0")]
    public static readonly byte[] RETRY_FOR_CHECK_MENTE_FLAG;
    [Token(Token = "0x400FD14")]
    [FieldOffset(Offset = "0x8")]
    private readonly WeakReference request;
    [Token(Token = "0x400FD15")]
    [FieldOffset(Offset = "0xC")]
    public readonly byte[] Payload;
    [Token(Token = "0x400FD16")]
    [FieldOffset(Offset = "0x10")]
    public readonly int StatusCode;
    [Token(Token = "0x400FD17")]
    [FieldOffset(Offset = "0x14")]
    public readonly ContentType ContentType;
    [Token(Token = "0x400FD18")]
    [FieldOffset(Offset = "0x18")]
    public readonly ContentEncoding ContentEncoding;

    [Token(Token = "0x600ED28")]
    [Address(RVA = "0xB18B50", Offset = "0xB17950", VA = "0x10B18B50")]
    public WebInternalResponse(UnityWebRequest request)
    {
    }

    [Token(Token = "0x600ED29")]
    [Address(RVA = "0xB18F90", Offset = "0xB17D90", VA = "0x10B18F90")]
    public WebInternalResponse(int statusCode)
    {
    }

    [Token(Token = "0x600ED2A")]
    [Address(RVA = "0xB18300", Offset = "0xB17100", VA = "0x10B18300")]
    public string GetResponseHeader(string name) => (string) null;

    [Token(Token = "0x600ED2B")]
    [Address(RVA = "0xB18770", Offset = "0xB17570", VA = "0x10B18770")]
    private static int GetStatusCode(UnityWebRequest webRequest) => new int();

    [Token(Token = "0x600ED2C")]
    [Address(RVA = "0xB183B0", Offset = "0xB171B0", VA = "0x10B183B0")]
    private static byte[] GetResponsePayload(UnityWebRequest webRequest) => (byte[]) null;

    [Token(Token = "0x600ED2D")]
    [Address(RVA = "0xB181A0", Offset = "0xB16FA0", VA = "0x10B181A0")]
    private static ContentType GetContentType(WebInternalResponse response) => new ContentType();

    [Token(Token = "0x600ED2E")]
    [Address(RVA = "0xB18100", Offset = "0xB16F00", VA = "0x10B18100")]
    private static ContentEncoding GetContentEncoding(WebInternalResponse response)
    {
      return new ContentEncoding();
    }

    [Token(Token = "0x600ED2F")]
    [Address(RVA = "0xB18AD0", Offset = "0xB178D0", VA = "0x10B18AD0")]
    static WebInternalResponse()
    {
    }
  }
}
