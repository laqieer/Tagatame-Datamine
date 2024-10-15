// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAbilityRankUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20030C8")]
  public class ReqAbilityRankUp : WebAPI
  {
    [Token(Token = "0x600DD4D")]
    [Address(RVA = "0xA80330", Offset = "0xA7F130", VA = "0x10A80330")]
    public ReqAbilityRankUp(
      Dictionary<long, int> abilities,
      Network.ResponseCallback response,
      string trophyprog = null,
      string bingoprog = null)
    {
    }
  }
}
