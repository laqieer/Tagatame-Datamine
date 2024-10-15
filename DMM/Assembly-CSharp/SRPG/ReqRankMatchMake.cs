// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchMake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200312F")]
  public class ReqRankMatchMake : WebAPI
  {
    [Token(Token = "0x600DDC4")]
    [Address(RVA = "0xA8AA20", Offset = "0xA89820", VA = "0x10A8AA20")]
    public ReqRankMatchMake(Network.ResponseCallback response = null)
    {
    }

    [Token(Token = "0x2003130")]
    public class Response
    {
      [Token(Token = "0x400ECCD")]
      [FieldOffset(Offset = "0x8")]
      public string token;
      [Token(Token = "0x400ECCE")]
      [FieldOffset(Offset = "0xC")]
      public string owner_name;
      [Token(Token = "0x400ECCF")]
      [FieldOffset(Offset = "0x10")]
      public string btl_ver;

      [Token(Token = "0x600DDC5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
