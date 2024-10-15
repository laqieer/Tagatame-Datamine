// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebInternalTask`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x200358C")]
  public class WebInternalTask<TRequest, TResponse> : WebInternalTask
    where TRequest : IRequest<TRequest, TResponse>
    where TResponse : IResponse<TResponse>
  {
    [Token(Token = "0x400FD2A")]
    [FieldOffset(Offset = "0x0")]
    private readonly TRequest _request;
    [Token(Token = "0x400FD2B")]
    [FieldOffset(Offset = "0x0")]
    private TResponse _response;
    [Token(Token = "0x400FD2C")]
    [FieldOffset(Offset = "0x0")]
    private IErrorResponse _error;

    [Token(Token = "0x170021E8")]
    public TResponse Response
    {
      [Token(Token = "0x600ED4A")] get => (TResponse) null;
    }

    [Token(Token = "0x170021E9")]
    public IErrorResponse ErrorResponse
    {
      [Token(Token = "0x600ED4B")] get => (IErrorResponse) null;
    }

    [Token(Token = "0x170021EA")]
    public byte[] error
    {
      [Token(Token = "0x600ED4C")] get => (byte[]) null;
      [Token(Token = "0x600ED4D")] private set
      {
      }
    }

    [Token(Token = "0x600ED4E")]
    public WebInternalTask(IRequest<TRequest, TResponse> request)
    {
    }

    [Token(Token = "0x600ED4F")]
    protected override WebTaskResult ProcessResponse(WebInternalResponse response)
    {
      return new WebTaskResult();
    }
  }
}
