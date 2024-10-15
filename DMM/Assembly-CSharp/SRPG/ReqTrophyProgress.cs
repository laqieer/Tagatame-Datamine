// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTrophyProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030EE")]
  public class ReqTrophyProgress : WebAPI
  {
    [Token(Token = "0x600DD75")]
    [Address(RVA = "0xA8BD40", Offset = "0xA8AB40", VA = "0x10A8BD40")]
    public ReqTrophyProgress(
      bool is_daily,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }
  }
}
