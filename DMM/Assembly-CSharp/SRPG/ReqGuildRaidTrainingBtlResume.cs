// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidTrainingBtlResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F51")]
  public class ReqGuildRaidTrainingBtlResume : WebAPI
  {
    [Token(Token = "0x600DBA2")]
    [Address(RVA = "0xA73B80", Offset = "0xA72980", VA = "0x10A73B80")]
    public ReqGuildRaidTrainingBtlResume(long btlid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002F52")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA0A")]
      [FieldOffset(Offset = "0x8")]
      public long btlid;

      [Token(Token = "0x600DBA3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
