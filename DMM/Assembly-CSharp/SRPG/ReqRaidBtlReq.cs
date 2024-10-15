// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidBtlReq
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FD9")]
  public class ReqRaidBtlReq : WebAPI
  {
    [Token(Token = "0x600DC2D")]
    [Address(RVA = "0xA788A0", Offset = "0xA776A0", VA = "0x10A788A0")]
    public ReqRaidBtlReq(
      int area_id,
      int boss_id,
      int round,
      string uid,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FDA")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB07")]
      [FieldOffset(Offset = "0x8")]
      public int area_id;
      [Token(Token = "0x400EB08")]
      [FieldOffset(Offset = "0xC")]
      public int boss_id;
      [Token(Token = "0x400EB09")]
      [FieldOffset(Offset = "0x10")]
      public int round;
      [Token(Token = "0x400EB0A")]
      [FieldOffset(Offset = "0x14")]
      public string uid;

      [Token(Token = "0x600DC2E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
