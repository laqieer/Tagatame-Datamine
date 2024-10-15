// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactSell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E5B")]
  public class ReqArtifactSell : WebAPI
  {
    [Token(Token = "0x600DAA1")]
    [Address(RVA = "0xA6C5A0", Offset = "0xA6B3A0", VA = "0x10A6C5A0")]
    public ReqArtifactSell(long[] artifact_iids, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002E5C")]
    public class Response : Json_PlayerDataAll
    {
      [Token(Token = "0x400E87E")]
      [FieldOffset(Offset = "0xB0")]
      public long[] sells;

      [Token(Token = "0x600DAA2")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Response()
      {
      }
    }
  }
}
