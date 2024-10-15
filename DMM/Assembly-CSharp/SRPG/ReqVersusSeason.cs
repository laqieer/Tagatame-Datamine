// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusSeason
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003146")]
  public class ReqVersusSeason : WebAPI
  {
    [Token(Token = "0x600DDDB")]
    [Address(RVA = "0xA8F4A0", Offset = "0xA8E2A0", VA = "0x10A8F4A0")]
    public ReqVersusSeason(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003147")]
    public class Response
    {
      [Token(Token = "0x400ECFD")]
      [FieldOffset(Offset = "0x8")]
      public int unreadmail;

      [Token(Token = "0x600DDDC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
