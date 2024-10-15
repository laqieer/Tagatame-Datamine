// Decompiled with JetBrains decompiler
// Type: SRPG.ReqWorldRaidBtlReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003066")]
  public class ReqWorldRaidBtlReq : WebAPI
  {
    [Token(Token = "0x600DCCE")]
    [Address(RVA = "0xA7D690", Offset = "0xA7C490", VA = "0x10A7D690")]
    public ReqWorldRaidBtlReq(string bossIname, int _lap, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003067")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBD7")]
      [FieldOffset(Offset = "0x8")]
      public string boss_iname;
      [Token(Token = "0x400EBD8")]
      [FieldOffset(Offset = "0xC")]
      public int lap;

      [Token(Token = "0x600DCCF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
