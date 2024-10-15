// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusDraftParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200305D")]
  public class ReqVersusDraftParty : WebAPI
  {
    [Token(Token = "0x600DCC4")]
    [Address(RVA = "0xA7C410", Offset = "0xA7B210", VA = "0x10A7C410")]
    public ReqVersusDraftParty(string token, int draft_id, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200305E")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBC7")]
      [FieldOffset(Offset = "0x8")]
      public string token;
      [Token(Token = "0x400EBC8")]
      [FieldOffset(Offset = "0xC")]
      public int draft_id;
      [Token(Token = "0x400EBC9")]
      [FieldOffset(Offset = "0x10")]
      public int[] party_indexes;

      [Token(Token = "0x600DCC5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
