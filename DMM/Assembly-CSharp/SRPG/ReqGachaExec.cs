// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGachaExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030DD")]
  public class ReqGachaExec : WebAPI
  {
    [Token(Token = "0x600DD62")]
    [Address(RVA = "0xA855B0", Offset = "0xA843B0", VA = "0x10A855B0")]
    public ReqGachaExec(string gachaid, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DD63")]
    [Address(RVA = "0xA853C0", Offset = "0xA841C0", VA = "0x10A853C0")]
    public ReqGachaExec(
      string iname,
      Network.ResponseCallback response,
      int free = 0,
      int num = 0,
      int is_decision = 0,
      int _cost_type = 0,
      int _execute_num = 0)
    {
    }
  }
}
