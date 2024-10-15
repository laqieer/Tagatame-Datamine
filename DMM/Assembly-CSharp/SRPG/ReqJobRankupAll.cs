// Decompiled with JetBrains decompiler
// Type: SRPG.ReqJobRankupAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030C3")]
  public class ReqJobRankupAll : WebAPI
  {
    [Token(Token = "0x600DD48")]
    [Address(RVA = "0xA86FB0", Offset = "0xA85DB0", VA = "0x10A86FB0")]
    public ReqJobRankupAll(
      long iid_unit,
      string iname_jobset,
      bool is_cmn,
      int current_rank,
      int target_rank,
      int isEquips,
      Network.ResponseCallback response)
    {
    }
  }
}
