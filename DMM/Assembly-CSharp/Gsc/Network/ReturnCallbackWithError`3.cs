﻿// Decompiled with JetBrains decompiler
// Type: Gsc.Network.ReturnCallbackWithError`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003574")]
  public delegate TResult ReturnCallbackWithError<TRequest, TResponse, TResult>(
    TRequest request,
    TResponse response,
    IErrorResponse error);
}