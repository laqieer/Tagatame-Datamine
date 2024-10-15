// Decompiled with JetBrains decompiler
// Type: Gsc.App.NetworkHelper.BlockRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.App.NetworkHelper
{
  [Token(Token = "0x200354D")]
  public static class BlockRequest
  {
    [Token(Token = "0x600EC44")]
    public static BlockRequest<TRequest, TResponse> Create<TRequest, TResponse>(
      IRequest<TRequest, TResponse> request)
      where TRequest : IRequest<TRequest, TResponse>
      where TResponse : IResponse<TResponse>
    {
      return (BlockRequest<TRequest, TResponse>) null;
    }
  }
}
