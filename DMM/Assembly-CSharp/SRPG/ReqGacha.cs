// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030DB")]
  public class ReqGacha : WebAPI
  {
    [Token(Token = "0x600DD60")]
    [Address(RVA = "0xA85700", Offset = "0xA84500", VA = "0x10A85700")]
    public ReqGacha(ReqGacha.RequestParam rp, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20030DC")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC48")]
      [FieldOffset(Offset = "0x8")]
      public int is_option;

      [Token(Token = "0x600DD61")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
