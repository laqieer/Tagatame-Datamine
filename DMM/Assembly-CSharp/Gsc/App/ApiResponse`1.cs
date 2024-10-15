// Decompiled with JetBrains decompiler
// Type: Gsc.App.ApiResponse`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.App
{
  [Token(Token = "0x2003542")]
  public abstract class ApiResponse<TResponse> : Response<TResponse> where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x600EBE4")]
    protected ApiResponse()
    {
    }
  }
}
