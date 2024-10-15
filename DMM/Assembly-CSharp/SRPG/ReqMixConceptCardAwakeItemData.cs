// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMixConceptCardAwakeItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002EA1")]
  public class ReqMixConceptCardAwakeItemData : WebAPI
  {
    [Token(Token = "0x600DAEB")]
    [Address(RVA = "0xA76C70", Offset = "0xA75A70", VA = "0x10A76C70")]
    public ReqMixConceptCardAwakeItemData(
      long base_id,
      Dictionary<string, int> materials,
      Network.ResponseCallback response,
      string trophyProgs = null,
      string bingoProgs = null)
    {
    }
  }
}
