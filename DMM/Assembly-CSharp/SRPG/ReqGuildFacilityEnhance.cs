// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildFacilityEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002F06")]
  public class ReqGuildFacilityEnhance : WebAPI
  {
    [Token(Token = "0x600DB52")]
    [Address(RVA = "0xA71260", Offset = "0xA70060", VA = "0x10A71260")]
    public ReqGuildFacilityEnhance(
      string facility_iname,
      EnhanceMaterial[] materials,
      long gold,
      Network.ResponseCallback response)
    {
    }
  }
}
