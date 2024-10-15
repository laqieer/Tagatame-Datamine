// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidBtlResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FDB")]
  public class ReqRaidBtlResume : WebAPI
  {
    [Token(Token = "0x600DC2F")]
    [Address(RVA = "0xA789C0", Offset = "0xA777C0", VA = "0x10A789C0")]
    public ReqRaidBtlResume(long btlid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FDC")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB0B")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;

      [Token(Token = "0x600DC30")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
