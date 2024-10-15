// Decompiled with JetBrains decompiler
// Type: SRPG.ReqHotDealStart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20032A2")]
  public class ReqHotDealStart : WebAPI
  {
    [Token(Token = "0x600DF44")]
    [Address(RVA = "0xA9A3C0", Offset = "0xA991C0", VA = "0x10A9A3C0")]
    public ReqHotDealStart(
      ReqHotDealStart.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032A3")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF2E")]
      [FieldOffset(Offset = "0x8")]
      public ReqHotDealStart.RequestParam.HotDealConds[] hot_deals;

      [Token(Token = "0x600DF45")]
      [Address(RVA = "0xA9F940", Offset = "0xA9E740", VA = "0x10A9F940")]
      public RequestParam(List<HotDealInfo> _infos)
      {
      }

      [Token(Token = "0x20032A4")]
      [Serializable]
      public class HotDealConds
      {
        [Token(Token = "0x400EF2F")]
        [FieldOffset(Offset = "0x8")]
        public string buy_coin_product_id;
        [Token(Token = "0x400EF30")]
        [FieldOffset(Offset = "0xC")]
        public int is_confirm;

        [Token(Token = "0x600DF46")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public HotDealConds()
        {
        }
      }
    }

    [Token(Token = "0x20032A5")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF31")]
      [FieldOffset(Offset = "0x8")]
      public Json_HotDealInfo[] hot_deals;

      [Token(Token = "0x600DF47")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
