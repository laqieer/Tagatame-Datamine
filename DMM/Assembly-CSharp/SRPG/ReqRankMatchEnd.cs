// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRankMatchEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003145")]
  public class ReqRankMatchEnd : WebAPI
  {
    [Token(Token = "0x600DDDA")]
    [Address(RVA = "0xA8A340", Offset = "0xA89140", VA = "0x10A8A340")]
    public ReqRankMatchEnd(
      long btlid,
      BtlResultTypes result,
      string uid,
      string fuid,
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
      string bingoprog = null,
      string missionprog = null)
    {
    }
  }
}
