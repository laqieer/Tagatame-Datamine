// Decompiled with JetBrains decompiler
// Type: SRPG.ReqHotDealConfirm
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
  [Token(Token = "0x20032AA")]
  public class ReqHotDealConfirm : WebAPI
  {
    [Token(Token = "0x600DF4C")]
    [Address(RVA = "0xA9A240", Offset = "0xA99040", VA = "0x10A9A240")]
    public ReqHotDealConfirm(
      ReqHotDealConfirm.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032AB")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF37")]
      [FieldOffset(Offset = "0x8")]
      public ReqHotDealConfirm.RequestParam.HotDealConds[] hot_deals;

      [Token(Token = "0x600DF4D")]
      [Address(RVA = "0xA9FAE0", Offset = "0xA9E8E0", VA = "0x10A9FAE0")]
      public RequestParam(HotDealInfo _info)
      {
      }

      [Token(Token = "0x20032AC")]
      [Serializable]
      public class HotDealConds
      {
        [Token(Token = "0x400EF38")]
        [FieldOffset(Offset = "0x8")]
        public string buy_coin_product_id;
        [Token(Token = "0x400EF39")]
        [FieldOffset(Offset = "0xC")]
        public int is_confirm;

        [Token(Token = "0x600DF4E")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public HotDealConds()
        {
        }
      }
    }

    [Token(Token = "0x20032AD")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF3A")]
      [FieldOffset(Offset = "0x8")]
      public Json_HotDealInfo[] hot_deals;

      [Token(Token = "0x600DF4F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
