// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiTwStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003161")]
  public class ReqMultiTwStatus : WebAPI
  {
    [Token(Token = "0x600DDF7")]
    [Address(RVA = "0xA89490", Offset = "0xA88290", VA = "0x10A89490")]
    public ReqMultiTwStatus(string tower_id, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003162")]
    [Serializable]
    public class FloorParam
    {
      [Token(Token = "0x400ED1B")]
      [FieldOffset(Offset = "0x8")]
      public int floor;
      [Token(Token = "0x400ED1C")]
      [FieldOffset(Offset = "0xC")]
      public int clear_count;

      [Token(Token = "0x600DDF8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public FloorParam()
      {
      }
    }

    [Token(Token = "0x2003163")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ED1D")]
      [FieldOffset(Offset = "0x8")]
      public ReqMultiTwStatus.FloorParam[] floors;
      [Token(Token = "0x400ED1E")]
      [FieldOffset(Offset = "0xC")]
      public string appid;
      [Token(Token = "0x400ED1F")]
      [FieldOffset(Offset = "0x10")]
      public int max_clear_floor;
      [Token(Token = "0x400ED20")]
      [FieldOffset(Offset = "0x14")]
      public string btl_ver;

      [Token(Token = "0x600DDF9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
