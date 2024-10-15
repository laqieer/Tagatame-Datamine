// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSendChatMessageRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003197")]
  public class ReqSendChatMessageRoom : WebAPI
  {
    [Token(Token = "0x600DE29")]
    [Address(RVA = "0xA9C4B0", Offset = "0xA9B2B0", VA = "0x10A9C4B0")]
    public ReqSendChatMessageRoom(
      string room_token,
      string message,
      string[] uids,
      Network.ResponseCallback response)
    {
    }
  }
}
