// Decompiled with JetBrains decompiler
// Type: Gsc.Network.IWebTask`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Tasks;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003598")]
  public interface IWebTask<TRequest, TResponse> : 
    IWebTask<TResponse>,
    IWebTask,
    IWebTaskBase,
    ITask,
    IEnumerator
    where TRequest : IRequest<TRequest, TResponse>
    where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x170021FA")]
    TRequest Request { [Token(Token = "0x600ED92")] get; }
  }
}
