// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidBtlResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F22")]
  public class ReqGuildRaidBtlResume : WebAPI
  {
    [Token(Token = "0x600DB71")]
    [Address(RVA = "0xA72560", Offset = "0xA71360", VA = "0x10A72560")]
    public ReqGuildRaidBtlResume(int gid, long btlid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002F23")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9B9")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9BA")]
      [FieldOffset(Offset = "0x10")]
      public long btlid;

      [Token(Token = "0x600DB72")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
