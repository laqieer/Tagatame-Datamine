// Decompiled with JetBrains decompiler
// Type: SRPG.ReqChatMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003192")]
  public class ReqChatMessage : WebAPI
  {
    [Token(Token = "0x600DE24")]
    [Address(RVA = "0xA95FD0", Offset = "0xA94DD0", VA = "0x10A95FD0")]
    public ReqChatMessage(
      long start_id,
      int channel,
      int limit,
      long exclude_id,
      bool isMultiPush,
      Network.ResponseCallback response)
    {
    }
  }
}
