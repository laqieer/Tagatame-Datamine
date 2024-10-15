// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMultiTwRoomUpdate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003160")]
  public class ReqMultiTwRoomUpdate : WebAPI
  {
    [Token(Token = "0x600DDF6")]
    [Address(RVA = "0xA89100", Offset = "0xA87F00", VA = "0x10A89100")]
    public ReqMultiTwRoomUpdate(
      int roomID,
      string comment,
      string passCode,
      string iname,
      int floor,
      Network.ResponseCallback response)
    {
    }
  }
}
