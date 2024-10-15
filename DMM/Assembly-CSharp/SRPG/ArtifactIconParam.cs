// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002002")]
  public class ArtifactIconParam : ContentSource.Param
  {
    [Token(Token = "0x400888E")]
    [FieldOffset(Offset = "0x10")]
    public ArtifactData Data;
    [Token(Token = "0x400888F")]
    [FieldOffset(Offset = "0x14")]
    public ArtifactParam Param;
    [Token(Token = "0x4008890")]
    [FieldOffset(Offset = "0x18")]
    public bool Select;
    [Token(Token = "0x4008891")]
    [FieldOffset(Offset = "0x19")]
    public bool Enable;
    [Token(Token = "0x4008892")]
    [FieldOffset(Offset = "0x1A")]
    public bool SpecialDisplay;
    [Token(Token = "0x4008893")]
    [FieldOffset(Offset = "0x1B")]
    public bool IsRecommend;
    [Token(Token = "0x4008894")]
    [FieldOffset(Offset = "0x1C")]
    public bool IsEmpty;
    [Token(Token = "0x4008895")]
    [FieldOffset(Offset = "0x20")]
    private ArtifactIconNode mNode;

    [Token(Token = "0x170012EA")]
    public ArtifactIconNode GetNode
    {
      [Token(Token = "0x6008438"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (ArtifactIconNode) null;
      }
    }

    [Token(Token = "0x6008439")]
    [Address(RVA = "0x44D000", Offset = "0x44BE00", VA = "0x1044D000", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600843A")]
    [Address(RVA = "0x44CFD0", Offset = "0x44BDD0", VA = "0x1044CFD0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600843B")]
    [Address(RVA = "0x44D0C0", Offset = "0x44BEC0", VA = "0x1044D0C0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600843C")]
    [Address(RVA = "0x44D980", Offset = "0x44C780", VA = "0x1044D980")]
    public ArtifactIconParam()
    {
    }
  }
}
