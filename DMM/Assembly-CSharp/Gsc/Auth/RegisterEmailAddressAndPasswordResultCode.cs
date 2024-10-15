// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.RegisterEmailAddressAndPasswordResultCode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth
{
  [Token(Token = "0x2003659")]
  public enum RegisterEmailAddressAndPasswordResultCode
  {
    [Token(Token = "0x400FF52")] Success,
    [Token(Token = "0x400FF53")] InvalidEmailAddress,
    [Token(Token = "0x400FF54")] InvalidPassword,
    [Token(Token = "0x400FF55")] DuplicatedEmailAddress,
    [Token(Token = "0x400FF56")] UnknownError,
  }
}
