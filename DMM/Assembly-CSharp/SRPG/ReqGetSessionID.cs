// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGetSessionID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003084")]
  public class ReqGetSessionID : WebAPI
  {
    [Token(Token = "0x600DCFE")]
    [Address(RVA = "0xA70640", Offset = "0xA6F440", VA = "0x10A70640")]
    public ReqGetSessionID(
      string udid,
      string udid_,
      string romver,
      Network.ResponseCallback response)
    {
    }
  }
}
