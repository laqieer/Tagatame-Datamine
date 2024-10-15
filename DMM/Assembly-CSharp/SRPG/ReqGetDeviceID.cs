// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGetDeviceID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003082")]
  public class ReqGetDeviceID : WebAPI
  {
    [Token(Token = "0x600DCFC")]
    [Address(RVA = "0xA70340", Offset = "0xA6F140", VA = "0x10A70340")]
    public ReqGetDeviceID(string secretkey, string udid, Network.ResponseCallback response)
    {
    }
  }
}
