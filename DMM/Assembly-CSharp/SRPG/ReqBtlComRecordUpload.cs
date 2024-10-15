// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlComRecordUpload
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030B6")]
  public class ReqBtlComRecordUpload : WebAPI
  {
    [Token(Token = "0x600DD36")]
    [Address(RVA = "0xA82700", Offset = "0xA81500", VA = "0x10A82700")]
    public ReqBtlComRecordUpload(
      string fuid,
      long btlid,
      int[] achieved,
      int time,
      BtlResultTypes result,
      int[] beats,
      int[] itemSteals,
      int[] goldSteals,
      int[] missions,
      Dictionary<OString, OInt> usedItems,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DD37")]
    [Address(RVA = "0xA82550", Offset = "0xA81350", VA = "0x10A82550")]
    private static string CreateRequestString(string body) => (string) null;

    [Token(Token = "0x600DD38")]
    [Address(RVA = "0xA827C0", Offset = "0xA815C0", VA = "0x10A827C0")]
    private static string makeBody(
      string fuid,
      long btlid,
      int[] achieved,
      int time,
      BtlResultTypes result,
      int[] beats,
      int[] itemSteals,
      int[] goldSteals,
      int[] missions,
      Dictionary<OString, OInt> usedItems)
    {
      return (string) null;
    }
  }
}
