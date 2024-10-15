// Decompiled with JetBrains decompiler
// Type: SRPG.RecommendArtifactParams
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CA7")]
  public class RecommendArtifactParams
  {
    [Token(Token = "0x400708B")]
    [FieldOffset(Offset = "0x8")]
    private List<ArtifactParam> mUnitJobArtifacts;
    [Token(Token = "0x400708C")]
    [FieldOffset(Offset = "0xC")]
    private List<ArtifactParam> mUnitArtifacts;
    [Token(Token = "0x400708D")]
    [FieldOffset(Offset = "0x10")]
    private List<ArtifactParam> mAbilityArtifacts;

    [Token(Token = "0x17000F4B")]
    public List<ArtifactParam> UnitJobArtifacts
    {
      [Token(Token = "0x6007605"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<ArtifactParam>) null;
      }
    }

    [Token(Token = "0x17000F4C")]
    public List<ArtifactParam> UnitArtifacts
    {
      [Token(Token = "0x6007606"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<ArtifactParam>) null;
      }
    }

    [Token(Token = "0x17000F4D")]
    public List<ArtifactParam> AbilityArtifacts
    {
      [Token(Token = "0x6007607"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<ArtifactParam>) null;
      }
    }

    [Token(Token = "0x6007608")]
    [Address(RVA = "0x395240", Offset = "0x394040", VA = "0x10395240")]
    public List<ArtifactParam> GetAll() => (List<ArtifactParam>) null;

    [Token(Token = "0x6007609")]
    [Address(RVA = "0x395970", Offset = "0x394770", VA = "0x10395970")]
    public List<ArtifactData> GetRecommendArtifacts(
      List<ArtifactData> player_artifacts,
      ArtifactTypes type,
      int num)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x600760A")]
    [Address(RVA = "0x3956F0", Offset = "0x3944F0", VA = "0x103956F0")]
    public List<ArtifactData> GetMasterAbilityArtifacts(
      List<ArtifactData> player_artifacts,
      ArtifactTypes type,
      int num)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x600760B")]
    [Address(RVA = "0x395D40", Offset = "0x394B40", VA = "0x10395D40")]
    public RecommendArtifactParams()
    {
    }
  }
}
