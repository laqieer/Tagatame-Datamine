// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidResetBp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FE7")]
  public class ReqRaidResetBp : WebAPI
  {
    [Token(Token = "0x600DC3D")]
    [Address(RVA = "0xA79400", Offset = "0xA78200", VA = "0x10A79400")]
    public ReqRaidResetBp(ReqRaidResetBp.RequestParam rp, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FE8")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB1E")]
      [FieldOffset(Offset = "0x8")]
      public int add_num;
      [Token(Token = "0x400EB1F")]
      [FieldOffset(Offset = "0xC")]
      public int current_num;

      [Token(Token = "0x600DC3E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002FE9")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB20")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EB21")]
      [FieldOffset(Offset = "0xC")]
      public Json_RaidBP bp;

      [Token(Token = "0x600DC3F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
