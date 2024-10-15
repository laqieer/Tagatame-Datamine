// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.AddDeviceWithEmailAddressAndPasswordResultCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x200365A")]
  public enum AddDeviceWithEmailAddressAndPasswordResultCode
  {
    [Token(Token = "0x400FF58")] Success,
    [Token(Token = "0x400FF59")] MissingDeviceId,
    [Token(Token = "0x400FF5A")] MissingEmailOrPassword,
    [Token(Token = "0x400FF5B")] Locked,
    [Token(Token = "0x400FF5C")] UnknownError,
  }
}
