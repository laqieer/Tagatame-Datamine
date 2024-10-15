// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBtlMultiTwEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200316E")]
  public class ReqBtlMultiTwEnd : WebAPI
  {
    [Token(Token = "0x600DE04")]
    [Address(RVA = "0xA94CB0", Offset = "0xA93AB0", VA = "0x10A94CB0")]
    public ReqBtlMultiTwEnd(
      long btlid,
      int time,
      BtlResultTypes result,
      int[] myhp,
      string[] myUnit,
      string[] fuid,
      Network.ResponseCallback response,
      string trophyprog = null,
      string bingoprog = null)
    {
    }
  }
}
