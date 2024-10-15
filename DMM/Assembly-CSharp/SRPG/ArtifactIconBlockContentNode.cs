// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactIconBlockContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FEC")]
  public class ArtifactIconBlockContentNode : ContentNode
  {
    [Token(Token = "0x40087A8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x40087A9")]
    [FieldOffset(Offset = "0x34")]
    private ArtifactIconBlockContentNodeModel mModel;

    [Token(Token = "0x170012DE")]
    public ArtifactIconBlockContentNodeModel Model
    {
      [Token(Token = "0x60083B8"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (ArtifactIconBlockContentNodeModel) null;
      }
    }

    [Token(Token = "0x60083B9")]
    [Address(RVA = "0x44B890", Offset = "0x44A690", VA = "0x1044B890")]
    public void Initialize(ArtifactData artifactData)
    {
    }

    [Token(Token = "0x60083BA")]
    [Address(RVA = "0x44B7D0", Offset = "0x44A5D0", VA = "0x1044B7D0")]
    public void Initialize(ItemData itemData)
    {
    }

    [Token(Token = "0x60083BB")]
    [Address(RVA = "0x44B9D0", Offset = "0x44A7D0", VA = "0x1044B9D0")]
    public void SetModel(ArtifactIconBlockContentNodeModel model)
    {
    }

    [Token(Token = "0x60083BC")]
    [Address(RVA = "0x44B950", Offset = "0x44A750", VA = "0x1044B950")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60083BD")]
    [Address(RVA = "0x44B640", Offset = "0x44A440", VA = "0x1044B640")]
    public static void CallBack(ContentNode node, ArtifactIconBlockContentNodeModel model)
    {
    }

    [Token(Token = "0x60083BE")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public ArtifactIconBlockContentNode()
    {
    }
  }
}
