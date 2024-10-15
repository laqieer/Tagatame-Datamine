// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGachaOptionSet
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
  [Token(Token = "0x2003212")]
  public class ReqGachaOptionSet : WebAPI
  {
    [Token(Token = "0x600DEAE")]
    [Address(RVA = "0xA97260", Offset = "0xA96060", VA = "0x10A97260")]
    public ReqGachaOptionSet(
      ReqGachaOptionSet.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003213")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE01")]
      [FieldOffset(Offset = "0x8")]
      public Json_GachaOption options;

      [Token(Token = "0x600DEAF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003214")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE02")]
      [FieldOffset(Offset = "0x8")]
      public Json_GachaOption options;

      [Token(Token = "0x600DEB0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
