// Decompiled with JetBrains decompiler
// Type: SRPG.ReqChatChannelList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20031A0")]
  public class ReqChatChannelList : WebAPI
  {
    [Token(Token = "0x600DE33")]
    [Address(RVA = "0xA95A90", Offset = "0xA94890", VA = "0x10A95A90")]
    public ReqChatChannelList(
      int start_id,
      int limit,
      int exclude_id,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DE34")]
    [Address(RVA = "0xA95920", Offset = "0xA94720", VA = "0x10A95920")]
    public ReqChatChannelList(int[] channel_ids, Network.ResponseCallback response)
    {
    }
  }
}
