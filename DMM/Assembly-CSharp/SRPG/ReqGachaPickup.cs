// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGachaPickup
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
  [Token(Token = "0x200320C")]
  public class ReqGachaPickup : WebAPI
  {
    [Token(Token = "0x600DEA8")]
    [Address(RVA = "0xA97300", Offset = "0xA96100", VA = "0x10A97300")]
    public ReqGachaPickup(
      ReqGachaPickup.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200320D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDFA")]
      [FieldOffset(Offset = "0x8")]
      public string gachaid;

      [Token(Token = "0x600DEA9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200320E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDFB")]
      [FieldOffset(Offset = "0x8")]
      public Json_GachaPickups[] pickups;
      [Token(Token = "0x400EDFC")]
      [FieldOffset(Offset = "0xC")]
      public int pickup_select_num;

      [Token(Token = "0x600DEAA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
