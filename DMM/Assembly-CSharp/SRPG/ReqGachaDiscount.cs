// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGachaDiscount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003209")]
  public class ReqGachaDiscount : WebAPI
  {
    [Token(Token = "0x600DEA5")]
    [Address(RVA = "0xA970D0", Offset = "0xA95ED0", VA = "0x10A970D0")]
    public ReqGachaDiscount(
      string gacha_id,
      string gacha_group_id,
      string discount_item_iname,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200320A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDF5")]
      [FieldOffset(Offset = "0x8")]
      public string gachaid;
      [Token(Token = "0x400EDF6")]
      [FieldOffset(Offset = "0xC")]
      public string groupid;
      [Token(Token = "0x400EDF7")]
      [FieldOffset(Offset = "0x10")]
      public string discount_iname;

      [Token(Token = "0x600DEA6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200320B")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDF8")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] items;
      [Token(Token = "0x400EDF9")]
      [FieldOffset(Offset = "0xC")]
      public Json_GachaParam[] gachas;

      [Token(Token = "0x600DEA7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
