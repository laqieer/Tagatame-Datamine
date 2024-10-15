// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactConvert
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E5D")]
  public class ReqArtifactConvert : WebAPI
  {
    [Token(Token = "0x600DAA3")]
    [Address(RVA = "0xA6BF10", Offset = "0xA6AD10", VA = "0x10A6BF10")]
    public ReqArtifactConvert(long[] artifact_iids, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002E5E")]
    public class Response : Json_PlayerDataAll
    {
      [Token(Token = "0x400E87F")]
      [FieldOffset(Offset = "0xB0")]
      public long[] iids;

      [Token(Token = "0x600DAA4")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public Response()
      {
      }
    }
  }
}
