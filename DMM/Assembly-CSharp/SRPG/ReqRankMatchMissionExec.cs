// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchMissionExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003137")]
  public class ReqRankMatchMissionExec : WebAPI
  {
    [Token(Token = "0x600DDCC")]
    [Address(RVA = "0xA8AAC0", Offset = "0xA898C0", VA = "0x10A8AAC0")]
    public ReqRankMatchMissionExec(string iname, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003138")]
    [Serializable]
    private class RequestParam
    {
      [Token(Token = "0x400ECDE")]
      [FieldOffset(Offset = "0x8")]
      public string iname;

      [Token(Token = "0x600DDCD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
