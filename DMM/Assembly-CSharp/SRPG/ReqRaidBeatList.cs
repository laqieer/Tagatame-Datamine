// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRaidBeatList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FD7")]
  public class ReqRaidBeatList : WebAPI
  {
    [Token(Token = "0x600DC2B")]
    [Address(RVA = "0xA77FD0", Offset = "0xA76DD0", VA = "0x10A77FD0")]
    public ReqRaidBeatList(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2002FD8")]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB04")]
      [FieldOffset(Offset = "0x8")]
      public int round;
      [Token(Token = "0x400EB05")]
      [FieldOffset(Offset = "0xC")]
      public int[] beat_stamp_index;
      [Token(Token = "0x400EB06")]
      [FieldOffset(Offset = "0x10")]
      public int is_get_complete;

      [Token(Token = "0x600DC2C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
