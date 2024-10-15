// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMPRoomJoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003101")]
  public class ReqMPRoomJoin : WebAPI
  {
    [Token(Token = "0x600DD94")]
    [Address(RVA = "0xA873A0", Offset = "0xA861A0", VA = "0x10A873A0")]
    public ReqMPRoomJoin(int roomID, Network.ResponseCallback response, bool LockRoom = false)
    {
    }

    [Token(Token = "0x2003102")]
    public class Quest
    {
      [Token(Token = "0x400EC69")]
      [FieldOffset(Offset = "0x8")]
      public string iname;

      [Token(Token = "0x600DD95")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Quest()
      {
      }
    }

    [Token(Token = "0x2003103")]
    public class Response
    {
      [Token(Token = "0x400EC6A")]
      [FieldOffset(Offset = "0x8")]
      public string app_id;
      [Token(Token = "0x400EC6B")]
      [FieldOffset(Offset = "0xC")]
      public string token;
      [Token(Token = "0x400EC6C")]
      [FieldOffset(Offset = "0x10")]
      public ReqMPRoomJoin.Quest quest;
      [Token(Token = "0x400EC6D")]
      [FieldOffset(Offset = "0x14")]
      public string btl_ver;

      [Token(Token = "0x600DD96")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
