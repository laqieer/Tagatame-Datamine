// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMPRoomUpdate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003104")]
  public class ReqMPRoomUpdate : WebAPI
  {
    [Token(Token = "0x600DD97")]
    [Address(RVA = "0xA87670", Offset = "0xA86470", VA = "0x10A87670")]
    public ReqMPRoomUpdate(
      int roomID,
      string comment,
      string passCode,
      int btl_speed,
      int enable_auto,
      Network.ResponseCallback response)
    {
    }
  }
}
