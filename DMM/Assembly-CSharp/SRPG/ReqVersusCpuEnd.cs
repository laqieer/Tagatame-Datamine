// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusCpuEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003157")]
  public class ReqVersusCpuEnd : WebAPI
  {
    [Token(Token = "0x600DDED")]
    [Address(RVA = "0xA8DA00", Offset = "0xA8C800", VA = "0x10A8DA00")]
    public ReqVersusCpuEnd(
      long btlid,
      BtlResultTypes result,
      uint turn,
      int[] myhp,
      int[] enhp,
      int atk,
      int dmg,
      int heal,
      int beat,
      int[] place,
      Network.ResponseCallback response,
      string trophyprog = null,
      string bingoprog = null)
    {
    }
  }
}
