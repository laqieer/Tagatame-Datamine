// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusFriendScore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200314F")]
  public class ReqVersusFriendScore : WebAPI
  {
    [Token(Token = "0x600DDE5")]
    [Address(RVA = "0xA8EB90", Offset = "0xA8D990", VA = "0x10A8EB90")]
    public ReqVersusFriendScore(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003150")]
    public class Response
    {
      [Token(Token = "0x400ED0C")]
      [FieldOffset(Offset = "0x8")]
      public Json_VersusFriendScore[] friends;

      [Token(Token = "0x600DDE6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
