// Decompiled with JetBrains decompiler
// Type: SRPG.ReqResonanceExec
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002FFC")]
  public class ReqResonanceExec : WebAPI
  {
    [Token(Token = "0x600DC52")]
    [Address(RVA = "0xA79A30", Offset = "0xA78830", VA = "0x10A79A30")]
    public ReqResonanceExec(
      ResonanceRequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }
  }
}
