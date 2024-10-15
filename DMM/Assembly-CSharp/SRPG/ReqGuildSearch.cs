// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildSearch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F05")]
  public class ReqGuildSearch : WebAPI
  {
    [Token(Token = "0x600DB51")]
    [Address(RVA = "0xA74600", Offset = "0xA73400", VA = "0x10A74600")]
    public ReqGuildSearch(
      long search_gid,
      string search_name,
      int is_auto,
      int lower_lv,
      int guild_lv_from,
      int guild_lv_to,
      int policy,
      int member_num_from,
      int member_num_to,
      int shop_lv_from,
      int shop_lv_to,
      Network.ResponseCallback response)
    {
    }
  }
}
