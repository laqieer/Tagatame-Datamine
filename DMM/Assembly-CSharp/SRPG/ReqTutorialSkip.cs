// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTutorialSkip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003038")]
  public class ReqTutorialSkip : WebAPI
  {
    [Token(Token = "0x600DC9E")]
    [Address(RVA = "0xA7BBE0", Offset = "0xA7A9E0", VA = "0x10A7BBE0")]
    public ReqTutorialSkip(
      TutorialSkipParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod method = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }
  }
}
