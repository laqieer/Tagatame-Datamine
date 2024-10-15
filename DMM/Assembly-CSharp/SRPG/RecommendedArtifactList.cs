// Decompiled with JetBrains decompiler
// Type: SRPG.RecommendedArtifactList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CA3")]
  public class RecommendedArtifactList
  {
    [Token(Token = "0x4007087")]
    [FieldOffset(Offset = "0x8")]
    private Dictionary<string, List<RecommendedArtifactParam>> mRecommendedArtifacts;

    [Token(Token = "0x60075FB")]
    [Address(RVA = "0x395E10", Offset = "0x394C10", VA = "0x10395E10")]
    public void Deserialize(JSON_RecommendedArtifactParam[] json)
    {
    }

    [Token(Token = "0x60075FC")]
    [Address(RVA = "0x3965D0", Offset = "0x3953D0", VA = "0x103965D0")]
    public List<RecommendedArtifactParam> GetRecommendedArtifacts(UnitData unitData)
    {
      return (List<RecommendedArtifactParam>) null;
    }

    [Token(Token = "0x60075FD")]
    [Address(RVA = "0x396100", Offset = "0x394F00", VA = "0x10396100")]
    public RecommendArtifactParams GetRecommendedArtifacts(
      UnitData unitData,
      MasterParam masterParam)
    {
      return (RecommendArtifactParams) null;
    }

    [Token(Token = "0x60075FE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RecommendedArtifactList()
    {
    }
  }
}
