// Decompiled with JetBrains decompiler
// Type: SRPG.ReqJobEquipV2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030CA")]
  public class ReqJobEquipV2 : WebAPI
  {
    [Token(Token = "0x600DD4F")]
    [Address(RVA = "0xA86D20", Offset = "0xA85B20", VA = "0x10A86D20")]
    public ReqJobEquipV2(
      long iid_unit,
      string iname_jobset,
      long slot,
      bool is_cmn,
      Network.ResponseCallback response)
    {
    }
  }
}
