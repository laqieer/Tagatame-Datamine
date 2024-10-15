// Decompiled with JetBrains decompiler
// Type: SRPG.ReqProductChargePrepare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030FB")]
  public class ReqProductChargePrepare : WebAPI
  {
    [Token(Token = "0x600DD8E")]
    [Address(RVA = "0xA89F90", Offset = "0xA88D90", VA = "0x10A89F90")]
    public ReqProductChargePrepare(
      string ID,
      string productID,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }
  }
}
