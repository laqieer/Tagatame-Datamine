// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiTwRoomMake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003159")]
  public class ReqMultiTwRoomMake : WebAPI
  {
    [Token(Token = "0x600DDEF")]
    [Address(RVA = "0xA88F10", Offset = "0xA87D10", VA = "0x10A88F10")]
    public ReqMultiTwRoomMake(
      string iname,
      string comment,
      string passCode,
      int floor,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x200315A")]
    public class Response
    {
      [Token(Token = "0x400ED10")]
      [FieldOffset(Offset = "0x8")]
      public int roomid;
      [Token(Token = "0x400ED11")]
      [FieldOffset(Offset = "0xC")]
      public string app_id;
      [Token(Token = "0x400ED12")]
      [FieldOffset(Offset = "0x10")]
      public string token;
      [Token(Token = "0x400ED13")]
      [FieldOffset(Offset = "0x14")]
      public string btl_ver;

      [Token(Token = "0x600DDF0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
