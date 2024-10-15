// Decompiled with JetBrains decompiler
// Type: SRPG.ReqExpansionPurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003293")]
  public class ReqExpansionPurchase : WebAPI
  {
    [Token(Token = "0x600DF34")]
    [Address(RVA = "0xA969A0", Offset = "0xA957A0", VA = "0x10A969A0")]
    public ReqExpansionPurchase(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003294")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF1C")]
      [FieldOffset(Offset = "0x8")]
      public Json_ExpansionPurchase[] expansions;

      [Token(Token = "0x600DF35")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
