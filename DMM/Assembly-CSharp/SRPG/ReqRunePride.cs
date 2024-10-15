// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRunePride
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
  [Token(Token = "0x20032C1")]
  public class ReqRunePride : WebAPI
  {
    [Token(Token = "0x600DF64")]
    [Address(RVA = "0xA9C280", Offset = "0xA9B080", VA = "0x10A9C280")]
    public ReqRunePride(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032C2")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF58")]
      [FieldOffset(Offset = "0x8")]
      public int pride_reset_cnt;

      [Token(Token = "0x600DF65")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
