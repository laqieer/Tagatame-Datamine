// Decompiled with JetBrains decompiler
// Type: SRPG.ReqJobEquipAll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030C2")]
  public class ReqJobEquipAll : WebAPI
  {
    [Token(Token = "0x600DD47")]
    [Address(RVA = "0xA86AE0", Offset = "0xA858E0", VA = "0x10A86AE0")]
    public ReqJobEquipAll(
      long iid,
      string iname_jobset,
      bool[] iid_equips,
      Network.ResponseCallback response)
    {
    }
  }
}
