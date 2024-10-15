// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBoxDrawStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003206")]
  public class ReqBoxDrawStatus : WebAPI
  {
    [Token(Token = "0x600DEA2")]
    [Address(RVA = "0xA94200", Offset = "0xA93000", VA = "0x10A94200")]
    public ReqBoxDrawStatus(string box_iname, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003207")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDE9")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;

      [Token(Token = "0x600DEA3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003208")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EDEA")]
      [FieldOffset(Offset = "0x8")]
      public string box_iname;
      [Token(Token = "0x400EDEB")]
      [FieldOffset(Offset = "0xC")]
      public int step;
      [Token(Token = "0x400EDEC")]
      [FieldOffset(Offset = "0x10")]
      public int total_step;
      [Token(Token = "0x400EDED")]
      [FieldOffset(Offset = "0x14")]
      public int total_num;
      [Token(Token = "0x400EDEE")]
      [FieldOffset(Offset = "0x18")]
      public int remain_num;
      [Token(Token = "0x400EDEF")]
      [FieldOffset(Offset = "0x1C")]
      public int is_reset_enable;
      [Token(Token = "0x400EDF0")]
      [FieldOffset(Offset = "0x20")]
      public int total_num_feature;
      [Token(Token = "0x400EDF1")]
      [FieldOffset(Offset = "0x24")]
      public int total_num_normal;
      [Token(Token = "0x400EDF2")]
      [FieldOffset(Offset = "0x28")]
      public int remain_num_feature;
      [Token(Token = "0x400EDF3")]
      [FieldOffset(Offset = "0x2C")]
      public int remain_num_normal;
      [Token(Token = "0x400EDF4")]
      [FieldOffset(Offset = "0x30")]
      public JSON_BoxGachaItems[] box_items;

      [Token(Token = "0x600DEA4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
