// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusDraftBan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003059")]
  public class ReqVersusDraftBan : WebAPI
  {
    [Token(Token = "0x600DCBF")]
    [Address(RVA = "0xA7BE50", Offset = "0xA7AC50", VA = "0x10A7BE50")]
    public ReqVersusDraftBan(int draft_id, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200305A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBC2")]
      [FieldOffset(Offset = "0x8")]
      public int draft_id;
      [Token(Token = "0x400EBC3")]
      [FieldOffset(Offset = "0xC")]
      public ReqVersusDraftBan.RequestDraftUnit[] ban_units;

      [Token(Token = "0x600DCC0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200305B")]
    [Serializable]
    public class RequestDraftUnit
    {
      [Token(Token = "0x400EBC4")]
      [FieldOffset(Offset = "0x8")]
      public long id;
      [Token(Token = "0x400EBC5")]
      [FieldOffset(Offset = "0x10")]
      public int secret;

      [Token(Token = "0x600DCC1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestDraftUnit()
      {
      }
    }
  }
}
