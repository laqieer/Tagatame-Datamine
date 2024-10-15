// Decompiled with JetBrains decompiler
// Type: SRPG.ReqWorldRaidBtlResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003068")]
  public class ReqWorldRaidBtlResume : WebAPI
  {
    [Token(Token = "0x600DCD0")]
    [Address(RVA = "0xA7D7A0", Offset = "0xA7C5A0", VA = "0x10A7D7A0")]
    public ReqWorldRaidBtlResume(long btlid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003069")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EBD9")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;

      [Token(Token = "0x600DCD1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
