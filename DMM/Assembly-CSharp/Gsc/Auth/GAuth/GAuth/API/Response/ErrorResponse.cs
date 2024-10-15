// Decompiled with JetBrains decompiler
// Type: Gsc.Auth.GAuth.GAuth.API.Response.ErrorResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM;
using Gsc.DOM.Json;
using Gsc.Network;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Auth.GAuth.GAuth.API.Response
{
  [Token(Token = "0x200366A")]
  public class ErrorResponse : Gsc.Network.Response<ErrorResponse>, IErrorResponse, IResponse
  {
    [Token(Token = "0x17002322")]
    public string ErrorCode
    {
      [Token(Token = "0x600F357"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0", Slot = "7")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F358"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17002323")]
    public Document data
    {
      [Token(Token = "0x600F359"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (Document) null;
      }
      [Token(Token = "0x600F35A"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17002324")]
    private IDocument Gsc\u002ENetwork\u002EIErrorResponse\u002Edata
    {
      [Token(Token = "0x600F35B"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0", Slot = "6")] get
      {
        return (IDocument) null;
      }
    }

    [Token(Token = "0x600F35C")]
    [Address(RVA = "0xB21750", Offset = "0xB20550", VA = "0x10B21750")]
    public ErrorResponse(WebInternalResponse response)
    {
    }
  }
}
