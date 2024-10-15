// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusRoomJoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200311C")]
  public class ReqVersusRoomJoin : WebAPI
  {
    [Token(Token = "0x600DDB1")]
    [Address(RVA = "0xA8F270", Offset = "0xA8E070", VA = "0x10A8F270")]
    public ReqVersusRoomJoin(int roomID, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200311D")]
    public class Quest
    {
      [Token(Token = "0x400EC8F")]
      [FieldOffset(Offset = "0x8")]
      public string iname;

      [Token(Token = "0x600DDB2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Quest()
      {
      }
    }

    [Token(Token = "0x200311E")]
    public class Response
    {
      [Token(Token = "0x400EC90")]
      [FieldOffset(Offset = "0x8")]
      public string app_id;
      [Token(Token = "0x400EC91")]
      [FieldOffset(Offset = "0xC")]
      public string token;
      [Token(Token = "0x400EC92")]
      [FieldOffset(Offset = "0x10")]
      public ReqVersusRoomJoin.Quest quest;
      [Token(Token = "0x400EC93")]
      [FieldOffset(Offset = "0x14")]
      public string btl_ver;

      [Token(Token = "0x600DDB3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
