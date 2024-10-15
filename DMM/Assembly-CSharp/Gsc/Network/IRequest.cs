// Decompiled with JetBrains decompiler
// Type: Gsc.Network.IRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x200355B")]
  public interface IRequest
  {
    [Token(Token = "0x170021D5")]
    CustomHeaders CustomHeaders { [Token(Token = "0x600EC73")] get; }

    [Token(Token = "0x170021D6")]
    bool IsUseEncryption { [Token(Token = "0x600EC74")] get; }

    [Token(Token = "0x170021D7")]
    byte[] UnencryptedPayload { [Token(Token = "0x600EC75")] get; [Token(Token = "0x600EC76")] set; }

    [Token(Token = "0x170021D8")]
    bool isDone { [Token(Token = "0x600EC77")] get; }

    [Token(Token = "0x600EC78")]
    WebTaskResult GetResult();

    [Token(Token = "0x600EC79")]
    string GetRequestID();

    [Token(Token = "0x600EC7A")]
    string GetHost();

    [Token(Token = "0x600EC7B")]
    string GetUrl();

    [Token(Token = "0x600EC7C")]
    string GetPath();

    [Token(Token = "0x600EC7D")]
    string GetMethod();

    [Token(Token = "0x600EC7E")]
    IWebTask Cast();

    [Token(Token = "0x600EC7F")]
    IWebTask Send();

    [Token(Token = "0x600EC80")]
    void Retry();

    [Token(Token = "0x600EC81")]
    byte[] GetPayload();

    [Token(Token = "0x600EC82")]
    Type GetErrorResponseType();

    [Token(Token = "0x600EC83")]
    WebTaskResult InquireResult(WebTaskResult result, WebInternalResponse response);
  }
}
