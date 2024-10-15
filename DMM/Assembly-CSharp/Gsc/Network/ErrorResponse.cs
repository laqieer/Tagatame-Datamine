// Decompiled with JetBrains decompiler
// Type: Gsc.Network.ErrorResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.DOM;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003557")]
  public class ErrorResponse : Response<ErrorResponse>, IErrorResponse, IResponse
  {
    [Token(Token = "0x170021D3")]
    public IDocument data
    {
      [Token(Token = "0x600EC6D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0", Slot = "6")] get
      {
        return (IDocument) null;
      }
      [Token(Token = "0x600EC6E"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x170021D4")]
    public string ErrorCode
    {
      [Token(Token = "0x600EC6F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0", Slot = "7")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EC70"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600EC71")]
    [Address(RVA = "0xB09520", Offset = "0xB08320", VA = "0x10B09520")]
    public ErrorResponse(WebInternalResponse response)
    {
    }
  }
}
