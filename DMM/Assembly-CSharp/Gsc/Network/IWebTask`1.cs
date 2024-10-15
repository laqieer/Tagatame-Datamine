// Decompiled with JetBrains decompiler
// Type: Gsc.Network.IWebTask`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Tasks;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003597")]
  public interface IWebTask<TResponse> : IWebTask, IWebTaskBase, ITask, IEnumerator where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x170021F8")]
    TResponse Response { [Token(Token = "0x600ED90")] get; }

    [Token(Token = "0x170021F9")]
    IErrorResponse ErrorResponse { [Token(Token = "0x600ED91")] get; }
  }
}
