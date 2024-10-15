// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLoginPack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030A1")]
  public class ReqLoginPack : WebAPI
  {
    [Token(Token = "0x600DD21")]
    [Address(RVA = "0xA87280", Offset = "0xA86080", VA = "0x10A87280")]
    public ReqLoginPack(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod,
      bool relogin = false)
    {
    }
  }
}
