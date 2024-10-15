// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLogin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003086")]
  public class ReqLogin : WebAPI
  {
    [Token(Token = "0x600DD00")]
    [Address(RVA = "0xA76900", Offset = "0xA75700", VA = "0x10A76900")]
    public ReqLogin(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }
  }
}
