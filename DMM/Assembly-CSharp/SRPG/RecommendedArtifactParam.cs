// Decompiled with JetBrains decompiler
// Type: SRPG.RecommendedArtifactParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CA2")]
  public class RecommendedArtifactParam
  {
    [Token(Token = "0x4007084")]
    [FieldOffset(Offset = "0x8")]
    private string m_UnitIname;
    [Token(Token = "0x4007085")]
    [FieldOffset(Offset = "0xC")]
    private string m_JobIname;
    [Token(Token = "0x4007086")]
    [FieldOffset(Offset = "0x10")]
    private List<string> m_ArtifactInames;

    [Token(Token = "0x17000F47")]
    public string UnitIname
    {
      [Token(Token = "0x60075F5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F48")]
    public string JobIname
    {
      [Token(Token = "0x60075F6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000F49")]
    public string[] ArtifactInames
    {
      [Token(Token = "0x60075F7"), Address(RVA = "0x3968D0", Offset = "0x3956D0", VA = "0x103968D0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x60075F8")]
    [Address(RVA = "0x3967B0", Offset = "0x3955B0", VA = "0x103967B0")]
    public void Deserialize(JSON_RecommendedArtifactParam param)
    {
    }

    [Token(Token = "0x60075F9")]
    [Address(RVA = "0x396720", Offset = "0x395520", VA = "0x10396720")]
    public bool CheckRecommendedForUnit(UnitData unitData) => new bool();

    [Token(Token = "0x60075FA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RecommendedArtifactParam()
    {
    }
  }
}
