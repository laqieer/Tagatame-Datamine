// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGenesisBossBtlResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031EE")]
  public class ReqGenesisBossBtlResume : WebAPI
  {
    [Token(Token = "0x600DE8A")]
    [Address(RVA = "0xA98750", Offset = "0xA97550", VA = "0x10A98750")]
    public ReqGenesisBossBtlResume(long btlid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x20031EF")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EDAD")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;

      [Token(Token = "0x600DE8B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
