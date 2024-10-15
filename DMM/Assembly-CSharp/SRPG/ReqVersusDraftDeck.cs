// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusDraftDeck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200304D")]
  public class ReqVersusDraftDeck : WebAPI
  {
    [Token(Token = "0x600DCB2")]
    [Address(RVA = "0xA7C300", Offset = "0xA7B100", VA = "0x10A7C300")]
    public ReqVersusDraftDeck(string token, long deck_id, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200304E")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBB3")]
      [FieldOffset(Offset = "0x8")]
      public string token;
      [Token(Token = "0x400EBB4")]
      [FieldOffset(Offset = "0x10")]
      public long deck_id;

      [Token(Token = "0x600DCB3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
