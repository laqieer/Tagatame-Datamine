// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebInternalTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Tasks;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine.Networking;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x200358A")]
  public abstract class WebInternalTask : IWebTaskBase, ITask, IEnumerator
  {
    [Token(Token = "0x400FD1C")]
    [FieldOffset(Offset = "0x8")]
    private int retryCount;
    [Token(Token = "0x400FD1D")]
    [FieldOffset(Offset = "0xC")]
    private bool completed;
    [Token(Token = "0x400FD1E")]
    [FieldOffset(Offset = "0x10")]
    private UnityWebRequest webRequest;
    [Token(Token = "0x400FD21")]
    [FieldOffset(Offset = "0x1C")]
    private readonly string method;
    [Token(Token = "0x400FD22")]
    [FieldOffset(Offset = "0x20")]
    private readonly string uri;
    [Token(Token = "0x400FD23")]
    [FieldOffset(Offset = "0x24")]
    private readonly byte[] payload;
    [Token(Token = "0x400FD24")]
    [FieldOffset(Offset = "0x28")]
    private readonly byte[] unencryptedPayload;
    [Token(Token = "0x400FD25")]
    [FieldOffset(Offset = "0x2C")]
    private readonly CustomHeaders customHeaders;
    [Token(Token = "0x400FD26")]
    [FieldOffset(Offset = "0x30")]
    private WebInternalTask.WaitTask waitTask;
    [Token(Token = "0x400FD27")]
    [FieldOffset(Offset = "0x34")]
    private object subroutine;

    [Token(Token = "0x170021E4")]
    public WebTaskResult Result
    {
      [Token(Token = "0x600ED36"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new WebTaskResult();
      }
      [Token(Token = "0x600ED37"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] protected set
      {
      }
    }

    [Token(Token = "0x170021E5")]
    public bool isBreak
    {
      [Token(Token = "0x600ED38"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600ED39"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] private set
      {
      }
    }

    [Token(Token = "0x170021E6")]
    public bool isDone
    {
      [Token(Token = "0x600ED3A"), Address(RVA = "0xB19660", Offset = "0xB18460", VA = "0x10B19660", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600ED3B")]
    public static WebInternalTask<TRequest, TResponse> Create<TRequest, TResponse>(
      IRequest<TRequest, TResponse> request)
      where TRequest : IRequest<TRequest, TResponse>, IRequest
      where TResponse : IResponse<TResponse>
    {
      return (WebInternalTask<TRequest, TResponse>) null;
    }

    [Token(Token = "0x600ED3C")]
    [Address(RVA = "0xB19600", Offset = "0xB18400", VA = "0x10B19600")]
    public WebInternalTask(
      string method,
      string uri,
      byte[] payload,
      byte[] unencryptedPayload,
      CustomHeaders customHeaders)
    {
    }

    [Token(Token = "0x600ED3D")]
    [Address(RVA = "0xB191F0", Offset = "0xB17FF0", VA = "0x10B191F0")]
    private void Update()
    {
    }

    [Token(Token = "0x600ED3E")]
    protected abstract WebTaskResult ProcessResponse(WebInternalResponse response);

    [Token(Token = "0x600ED3F")]
    [Address(RVA = "0x5EFFD0", Offset = "0x5EEDD0", VA = "0x105EFFD0", Slot = "5")]
    public void Break()
    {
    }

    [Token(Token = "0x600ED40")]
    [Address(RVA = "0xB191D0", Offset = "0xB17FD0", VA = "0x10B191D0", Slot = "12")]
    public void Reset()
    {
    }

    [Token(Token = "0x600ED41")]
    [Address(RVA = "0xB191D0", Offset = "0xB17FD0", VA = "0x10B191D0", Slot = "7")]
    public void OnStart()
    {
    }

    [Token(Token = "0x600ED42")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
    public void OnFinish()
    {
    }

    [Token(Token = "0x600ED43")]
    [Address(RVA = "0x7DFE90", Offset = "0x7DEC90", VA = "0x107DFE90", Slot = "8")]
    public IEnumerator Run() => (IEnumerator) null;

    [Token(Token = "0x170021E7")]
    public object Current
    {
      [Token(Token = "0x600ED44"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700", Slot = "11")] get
      {
        return (object) null;
      }
    }

    [Token(Token = "0x600ED45")]
    [Address(RVA = "0xB19120", Offset = "0xB17F20", VA = "0x10B19120", Slot = "10")]
    public bool MoveNext() => new bool();

    [Token(Token = "0x600ED46")]
    [Address(RVA = "0xB190F0", Offset = "0xB17EF0", VA = "0x10B190F0")]
    private void InternalDispose()
    {
    }

    [Token(Token = "0x600ED47")]
    [Address(RVA = "0xB18FE0", Offset = "0xB17DE0", VA = "0x10B18FE0")]
    private static UnityWebRequest CreateRequest(
      string method,
      string uri,
      byte[] payload,
      CustomHeaders customHeaders)
    {
      return (UnityWebRequest) null;
    }

    [Token(Token = "0x200358B")]
    private class WaitTask
    {
      [Token(Token = "0x400FD28")]
      [FieldOffset(Offset = "0x8")]
      private readonly float time;

      [Token(Token = "0x600ED48")]
      [Address(RVA = "0xB180E0", Offset = "0xB16EE0", VA = "0x10B180E0")]
      public WaitTask()
      {
      }

      [Token(Token = "0x600ED49")]
      [Address(RVA = "0xB180B0", Offset = "0xB16EB0", VA = "0x10B180B0")]
      public bool Wait() => new bool();
    }
  }
}
