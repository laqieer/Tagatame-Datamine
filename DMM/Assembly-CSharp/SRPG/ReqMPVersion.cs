// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMPVersion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003105")]
  public class ReqMPVersion : WebAPI
  {
    [Token(Token = "0x600DD98")]
    [Address(RVA = "0xA879C0", Offset = "0xA867C0", VA = "0x10A879C0")]
    public ReqMPVersion(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003106")]
    public class Response
    {
      [Token(Token = "0x400EC6E")]
      [FieldOffset(Offset = "0x8")]
      public string device_id;

      [Token(Token = "0x600DD99")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
