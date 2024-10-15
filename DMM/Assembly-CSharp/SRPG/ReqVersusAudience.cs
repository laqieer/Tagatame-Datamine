// Decompiled with JetBrains decompiler
// Type: SRPG.ReqVersusAudience
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Networking;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003151")]
  public class ReqVersusAudience : WebAPI
  {
    [Token(Token = "0x600DDE7")]
    [Address(RVA = "0xA8D880", Offset = "0xA8C680", VA = "0x10A8D880")]
    public ReqVersusAudience(
      string appid,
      string version,
      string roomid,
      Network.ResponseCallback response,
      DownloadHandler handler)
    {
    }
  }
}
