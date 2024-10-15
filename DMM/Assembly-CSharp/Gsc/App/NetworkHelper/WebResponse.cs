// Decompiled with JetBrains decompiler
// Type: Gsc.App.NetworkHelper.WebResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace Gsc.App.NetworkHelper
{
  [Token(Token = "0x200354C")]
  public class WebResponse : ApiResponse<WebResponse>
  {
    [Token(Token = "0x400FCCB")]
    [FieldOffset(Offset = "0x8")]
    public readonly byte[] payload;
    [Token(Token = "0x400FCCC")]
    [FieldOffset(Offset = "0xC")]
    public readonly SRPG.Network.EErrCode ErrorCode;
    [Token(Token = "0x400FCCD")]
    [FieldOffset(Offset = "0x10")]
    public readonly string ErrorMessage;
    [Token(Token = "0x400FCCE")]
    [FieldOffset(Offset = "0x18")]
    public readonly long ServerTime;
    [Token(Token = "0x400FCCF")]
    [FieldOffset(Offset = "0x20")]
    public readonly WWWResult Result;

    [Token(Token = "0x600EC42")]
    [Address(RVA = "0xB1B830", Offset = "0xB1A630", VA = "0x10B1B830")]
    public WebResponse(WebInternalResponse response)
    {
    }

    [Token(Token = "0x600EC43")]
    [Address(RVA = "0xB1B410", Offset = "0xB1A210", VA = "0x10B1B410")]
    public WebResponse(byte[] payload, Gsc.Network.ContentType contentType, ContentEncoding contentEncoding)
    {
    }
  }
}
