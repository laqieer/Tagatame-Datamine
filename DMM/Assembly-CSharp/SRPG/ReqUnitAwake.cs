// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitAwake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030BA")]
  public class ReqUnitAwake : WebAPI
  {
    [Token(Token = "0x600DD3D")]
    [Address(RVA = "0xA8C1B0", Offset = "0xA8AFB0", VA = "0x10A8C1B0")]
    public ReqUnitAwake(
      long unitUniqueId,
      int target_plus,
      int pieceCountUnit,
      int pieceCountElement,
      int pieceCountCommon,
      Network.ResponseCallback response,
      string trophyprog = null,
      string bingoprog = null)
    {
    }
  }
}
