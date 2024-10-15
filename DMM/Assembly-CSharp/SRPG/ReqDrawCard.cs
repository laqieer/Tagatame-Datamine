// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDrawCard
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
  [Token(Token = "0x200322F")]
  public class ReqDrawCard : WebAPI
  {
    [Token(Token = "0x600DECB")]
    [Address(RVA = "0xA96770", Offset = "0xA95570", VA = "0x10A96770")]
    public ReqDrawCard(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003230")]
    [MessagePackObject(true)]
    [Serializable]
    public class CardInfo
    {
      [Token(Token = "0x400EE31")]
      [FieldOffset(Offset = "0x8")]
      public int is_miss;
      [Token(Token = "0x400EE32")]
      [FieldOffset(Offset = "0xC")]
      public ReqDrawCard.CardInfo.Card draw_card_reward;

      [Token(Token = "0x600DECC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CardInfo()
      {
      }

      [Token(Token = "0x600DECD")]
      [Address(RVA = "0xA907B0", Offset = "0xA8F5B0", VA = "0x10A907B0")]
      public CardInfo(int type, string iname, int num, int miss)
      {
      }

      [Token(Token = "0x2003231")]
      [MessagePackObject(true)]
      [Serializable]
      public class Card
      {
        [Token(Token = "0x400EE33")]
        [FieldOffset(Offset = "0x8")]
        public int item_type;
        [Token(Token = "0x400EE34")]
        [FieldOffset(Offset = "0xC")]
        public string item_iname;
        [Token(Token = "0x400EE35")]
        [FieldOffset(Offset = "0x10")]
        public int item_num;

        [Token(Token = "0x600DECE")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Card()
        {
        }

        [Token(Token = "0x600DECF")]
        [Address(RVA = "0xA90840", Offset = "0xA8F640", VA = "0x10A90840")]
        public Card(int type, string iname, int num)
        {
        }
      }
    }

    [Token(Token = "0x2003232")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE36")]
      [FieldOffset(Offset = "0x8")]
      public ReqDrawCard.Response.Status drawcard_current_status;
      [Token(Token = "0x400EE37")]
      [FieldOffset(Offset = "0xC")]
      public ReqDrawCard.CardInfo.Card[] rewards;

      [Token(Token = "0x600DED0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }

      [Token(Token = "0x2003233")]
      [MessagePackObject(true)]
      [Serializable]
      public class Status
      {
        [Token(Token = "0x400EE38")]
        [FieldOffset(Offset = "0x8")]
        public int step;
        [Token(Token = "0x400EE39")]
        [FieldOffset(Offset = "0xC")]
        public int is_finish;
        [Token(Token = "0x400EE3A")]
        [FieldOffset(Offset = "0x10")]
        public ReqDrawCard.CardInfo[] draw_infos;

        [Token(Token = "0x600DED1")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public Status()
        {
        }
      }
    }
  }
}
