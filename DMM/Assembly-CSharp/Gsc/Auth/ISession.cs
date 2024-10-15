// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.ISession
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x2003657")]
  public interface ISession
  {
    [Token(Token = "0x17002305")]
    string SecretKey { [Token(Token = "0x600F2F5")] get; }

    [Token(Token = "0x17002306")]
    string DeviceID { [Token(Token = "0x600F2F6")] get; }

    [Token(Token = "0x17002307")]
    string AccessToken { [Token(Token = "0x600F2F7")] get; }

    [Token(Token = "0x17002308")]
    string UserAgent { [Token(Token = "0x600F2F8")] get; }

    [Token(Token = "0x600F2F9")]
    void DeleteAuthKeys();

    [Token(Token = "0x600F2FA")]
    bool CanRefreshToken(Type requestType);

    [Token(Token = "0x600F2FB")]
    IRefreshTokenTask GetRefreshTokenTask();

    [Token(Token = "0x600F2FC")]
    IWebTask RegisterEmailAddressAndPassword(
      string email,
      string password,
      bool disableValicationEmail,
      Action<RegisterEmailAddressAndPasswordResult> callback);

    [Token(Token = "0x600F2FD")]
    IWebTask AddDeviceWithEmailAddressAndPassword(
      string email,
      string password,
      Action<AddDeviceWithEmailAddressAndPasswordResult> callback);
  }
}
