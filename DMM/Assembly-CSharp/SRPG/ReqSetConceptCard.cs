// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSetConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E97")]
  public class ReqSetConceptCard : WebAPI
  {
    [Token(Token = "0x600DADE")]
    [Address(RVA = "0xA7B2C0", Offset = "0xA7A0C0", VA = "0x10A7B2C0")]
    private ReqSetConceptCard(long[] card_iids, long unit_iid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DADF")]
    [Address(RVA = "0xA7B110", Offset = "0xA79F10", VA = "0x10A7B110")]
    public static ReqSetConceptCard CreateSet(
      long[] card_iids,
      long unit_iid,
      Network.ResponseCallback response)
    {
      return (ReqSetConceptCard) null;
    }
  }
}
