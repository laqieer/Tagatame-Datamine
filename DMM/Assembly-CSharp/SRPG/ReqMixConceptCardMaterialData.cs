// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMixConceptCardMaterialData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002EA2")]
  public class ReqMixConceptCardMaterialData : WebAPI
  {
    [Token(Token = "0x600DAEC")]
    [Address(RVA = "0xA77090", Offset = "0xA75E90", VA = "0x10A77090")]
    public ReqMixConceptCardMaterialData(
      long base_id,
      List<SelecteConceptCardMaterial> materials,
      Network.ResponseCallback response,
      string trophyProgs = null,
      string bingoProgs = null)
    {
    }
  }
}
