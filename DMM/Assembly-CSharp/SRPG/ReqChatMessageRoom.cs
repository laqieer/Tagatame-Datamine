// Decompiled with JetBrains decompiler
// Type: SRPG.ReqChatMessageRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003193")]
  public class ReqChatMessageRoom : WebAPI
  {
    [Token(Token = "0x600DE25")]
    [Address(RVA = "0xA95DE0", Offset = "0xA94BE0", VA = "0x10A95DE0")]
    public ReqChatMessageRoom(
      long start_id,
      string room_token,
      int limit,
      long exclude_id,
      bool isMultiPush,
      Network.ResponseCallback response)
    {
    }
  }
}
