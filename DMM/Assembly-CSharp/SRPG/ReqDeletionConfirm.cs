// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDeletionConfirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E3C")]
  public class ReqDeletionConfirm : WebAPI
  {
    [Token(Token = "0x600DA80")]
    [Address(RVA = "0xA6F1C0", Offset = "0xA6DFC0", VA = "0x10A6F1C0")]
    public ReqDeletionConfirm(
      DeletionConfirmParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }
  }
}
