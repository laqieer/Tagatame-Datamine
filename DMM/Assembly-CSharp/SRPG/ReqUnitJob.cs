// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030BD")]
  public class ReqUnitJob : WebAPI
  {
    [Token(Token = "0x600DD40")]
    [Address(RVA = "0xA8CA20", Offset = "0xA8B820", VA = "0x10A8CA20")]
    public ReqUnitJob(long iid_unit, long iid_job, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DD41")]
    [Address(RVA = "0xA8C9C0", Offset = "0xA8B7C0", VA = "0x10A8C9C0")]
    public ReqUnitJob(
      long iid_unit,
      long iid_job,
      string ptype,
      Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DD42")]
    [Address(RVA = "0xA8C860", Offset = "0xA8B660", VA = "0x10A8C860")]
    private void Setup(
      long iid_unit,
      long iid_job,
      string ptype,
      Network.ResponseCallback response)
    {
    }
  }
}
