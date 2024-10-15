// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiTwRoomJoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200315D")]
  public class ReqMultiTwRoomJoin : WebAPI
  {
    [Token(Token = "0x600DDF3")]
    [Address(RVA = "0xA88D30", Offset = "0xA87B30", VA = "0x10A88D30")]
    public ReqMultiTwRoomJoin(
      int roomID,
      Network.ResponseCallback response,
      bool LockRoom = false,
      int floor = 0,
      bool isInv = false)
    {
    }

    [Token(Token = "0x200315E")]
    public class Quest
    {
      [Token(Token = "0x400ED15")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400ED16")]
      [FieldOffset(Offset = "0xC")]
      public int floor;

      [Token(Token = "0x600DDF4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Quest()
      {
      }
    }

    [Token(Token = "0x200315F")]
    public class Response
    {
      [Token(Token = "0x400ED17")]
      [FieldOffset(Offset = "0x8")]
      public string app_id;
      [Token(Token = "0x400ED18")]
      [FieldOffset(Offset = "0xC")]
      public string token;
      [Token(Token = "0x400ED19")]
      [FieldOffset(Offset = "0x10")]
      public ReqMultiTwRoomJoin.Quest quest;
      [Token(Token = "0x400ED1A")]
      [FieldOffset(Offset = "0x14")]
      public string btl_ver;

      [Token(Token = "0x600DDF5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}
