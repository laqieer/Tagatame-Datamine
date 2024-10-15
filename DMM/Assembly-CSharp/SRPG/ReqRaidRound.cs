// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FE5")]
  public class ReqRaidRound : WebAPI
  {
    [Token(Token = "0x600DC3B")]
    [Address(RVA = "0xA797C0", Offset = "0xA785C0", VA = "0x10A797C0")]
    public ReqRaidRound(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FE6")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB1D")]
      [FieldOffset(Offset = "0x8")]
      public int round;

      [Token(Token = "0x600DC3C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
