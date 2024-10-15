// Decompiled with JetBrains decompiler
// Type: SRPG.ReqFgGAuth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003182")]
  public class ReqFgGAuth : WebAPI
  {
    [Token(Token = "0x600DE16")]
    [Address(RVA = "0xA96A30", Offset = "0xA95830", VA = "0x10A96A30")]
    public ReqFgGAuth(Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x2003183")]
    public enum eAuthStatus
    {
      [Token(Token = "0x400ED46")] None,
      [Token(Token = "0x400ED47")] Disable,
      [Token(Token = "0x400ED48")] NotSynchronized,
      [Token(Token = "0x400ED49")] Synchronized,
    }
  }
}
