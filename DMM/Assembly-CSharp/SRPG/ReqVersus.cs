// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200314A")]
  public class ReqVersus : WebAPI
  {
    [Token(Token = "0x600DDE0")]
    [Address(RVA = "0xA8F6A0", Offset = "0xA8E4A0", VA = "0x10A8F6A0")]
    public ReqVersus(
      string iname,
      int plid,
      int seat,
      string uid,
      VersusStatusData param,
      int num,
      Network.ResponseCallback response,
      VERSUS_TYPE type,
      int draft_id = 0,
      int enemy_draft_id = 0)
    {
    }
  }
}
