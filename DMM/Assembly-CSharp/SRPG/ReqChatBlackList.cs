// Decompiled with JetBrains decompiler
// Type: SRPG.ReqChatBlackList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200319C")]
  public class ReqChatBlackList : WebAPI
  {
    [Token(Token = "0x600DE2E")]
    [Address(RVA = "0xA95610", Offset = "0xA94410", VA = "0x10A95610")]
    public ReqChatBlackList(
      int start_id,
      int limit,
      int exclude_id,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DE2F")]
    [Address(RVA = "0xA95770", Offset = "0xA94570", VA = "0x10A95770")]
    public ReqChatBlackList(int offset, int limit, Network.ResponseCallback response)
    {
    }
  }
}
