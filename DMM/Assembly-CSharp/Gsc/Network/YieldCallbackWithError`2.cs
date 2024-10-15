// Decompiled with JetBrains decompiler
// Type: Gsc.Network.YieldCallbackWithError`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003570")]
  public delegate IEnumerator YieldCallbackWithError<TRequest, TResponse>(
    TRequest request,
    TResponse response,
    IErrorResponse error);
}
