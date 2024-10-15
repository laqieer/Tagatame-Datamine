// Decompiled with JetBrains decompiler
// Type: SRPG.ReqPlayNew
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2003088")]
  public class ReqPlayNew : WebAPI
  {
    [Token(Token = "0x600DD02")]
    [Address(RVA = "0xA89D20", Offset = "0xA88B20", VA = "0x10A89D20")]
    public ReqPlayNew(
      int debugItemHave,
      int debugQuestClear,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }
  }
}
