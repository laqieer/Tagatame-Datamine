// Decompiled with JetBrains decompiler
// Type: Gsc.Network.IWebTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Tasks;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003596")]
  public interface IWebTask : IWebTaskBase, ITask, IEnumerator
  {
    [Token(Token = "0x170021F5")]
    bool handled { [Token(Token = "0x600ED88")] get; }

    [Token(Token = "0x170021F6")]
    WebTaskResult Result { [Token(Token = "0x600ED89")] get; }

    [Token(Token = "0x170021F7")]
    byte[] error { [Token(Token = "0x600ED8A")] get; }

    [Token(Token = "0x600ED8B")]
    void Retry();

    [Token(Token = "0x600ED8C")]
    bool IsAcceptResult(WebTaskResult result);

    [Token(Token = "0x600ED8D")]
    bool HasAttributes(WebTaskAttribute attributes);

    [Token(Token = "0x600ED8E")]
    WebInternalTask GetInternalTask();

    [Token(Token = "0x600ED8F")]
    Type GetRequestType();
  }
}
