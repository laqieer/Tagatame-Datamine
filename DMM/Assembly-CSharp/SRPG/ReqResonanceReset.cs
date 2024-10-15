// Decompiled with JetBrains decompiler
// Type: SRPG.ReqResonanceReset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FFD")]
  public class ReqResonanceReset : WebAPI
  {
    [Token(Token = "0x600DC53")]
    [Address(RVA = "0xA79B00", Offset = "0xA78900", VA = "0x10A79B00")]
    public ReqResonanceReset(
      ResonanceRequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }
  }
}
