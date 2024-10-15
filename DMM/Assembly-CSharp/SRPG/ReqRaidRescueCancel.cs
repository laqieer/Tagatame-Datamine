// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidRescueCancel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FD5")]
  public class ReqRaidRescueCancel : WebAPI
  {
    [Token(Token = "0x600DC29")]
    [Address(RVA = "0xA790F0", Offset = "0xA77EF0", VA = "0x10A790F0")]
    public ReqRaidRescueCancel(
      string uid,
      int area_id,
      int boss_id,
      int round,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FD6")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB00")]
      [FieldOffset(Offset = "0x8")]
      public string uid;
      [Token(Token = "0x400EB01")]
      [FieldOffset(Offset = "0xC")]
      public int area_id;
      [Token(Token = "0x400EB02")]
      [FieldOffset(Offset = "0x10")]
      public int boss_id;
      [Token(Token = "0x400EB03")]
      [FieldOffset(Offset = "0x14")]
      public int round;

      [Token(Token = "0x600DC2A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }
  }
}
