// Decompiled with JetBrains decompiler
// Type: Gsc.Network.VoidCallbackWithError`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x200356C")]
  public delegate void VoidCallbackWithError<TRequest, TResponse>(
    TRequest request,
    TResponse response,
    IErrorResponse error);
}
