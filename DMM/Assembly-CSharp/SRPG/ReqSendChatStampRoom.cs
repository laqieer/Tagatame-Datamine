// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSendChatStampRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003198")]
  public class ReqSendChatStampRoom : WebAPI
  {
    [Token(Token = "0x600DE2A")]
    [Address(RVA = "0xA9C8B0", Offset = "0xA9B6B0", VA = "0x10A9C8B0")]
    public ReqSendChatStampRoom(
      string room_token,
      int stamp_id,
      string[] uids,
      Network.ResponseCallback response)
    {
    }
  }
}
