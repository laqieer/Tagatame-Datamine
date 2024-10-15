// Decompiled with JetBrains decompiler
// Type: SRPG.ReqHotDealGenerate
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
  [Token(Token = "0x20032A6")]
  public class ReqHotDealGenerate : WebAPI
  {
    [Token(Token = "0x600DF48")]
    [Address(RVA = "0xA9A2E0", Offset = "0xA990E0", VA = "0x10A9A2E0")]
    public ReqHotDealGenerate(
      ReqHotDealGenerate.RequestParam.HotDealConds[] _hot_deal_conds,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032A7")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF32")]
      [FieldOffset(Offset = "0x8")]
      public ReqHotDealGenerate.RequestParam.HotDealConds[] hot_deal_conds;

      [Token(Token = "0x600DF49")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x20032A8")]
      [Serializable]
      public class HotDealConds
      {
        [Token(Token = "0x400EF33")]
        [FieldOffset(Offset = "0x8")]
        private string buy_coin_product_id;
        [Token(Token = "0x400EF34")]
        [FieldOffset(Offset = "0xC")]
        private string cond_str;
        [Token(Token = "0x400EF35")]
        [FieldOffset(Offset = "0x10")]
        private int cond_num;

        [Token(Token = "0x600DF4A")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public HotDealConds()
        {
        }
      }
    }

    [Token(Token = "0x20032A9")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF36")]
      [FieldOffset(Offset = "0x8")]
      public Json_HotDealInfo[] hot_deals;

      [Token(Token = "0x600DF4B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
