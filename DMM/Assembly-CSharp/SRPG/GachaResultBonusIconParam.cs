// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultBonusIconParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200243F")]
  public class GachaResultBonusIconParam : ContentSource.Param
  {
    [Token(Token = "0x400A441")]
    [FieldOffset(Offset = "0x10")]
    private GachaResultBonusIconNode mNode;
    [Token(Token = "0x400A442")]
    [FieldOffset(Offset = "0x14")]
    public GachaDropData DropData;
    [Token(Token = "0x400A443")]
    [FieldOffset(Offset = "0x18")]
    public GachaResultThumbnailWindow Window;
    [Token(Token = "0x400A444")]
    [FieldOffset(Offset = "0x1C")]
    private bool mIsDeleteAnim;

    [Token(Token = "0x6009E17")]
    [Address(RVA = "0x60AFA0", Offset = "0x609DA0", VA = "0x1060AFA0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x6009E18")]
    [Address(RVA = "0x4A5130", Offset = "0x4A3F30", VA = "0x104A5130", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x6009E19")]
    [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
    public ContentNode GetNode() => (ContentNode) null;

    [Token(Token = "0x6009E1A")]
    [Address(RVA = "0x60B190", Offset = "0x609F90", VA = "0x1060B190")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009E1B")]
    [Address(RVA = "0x60B420", Offset = "0x60A220", VA = "0x1060B420")]
    public void StartAnim()
    {
    }

    [Token(Token = "0x6009E1C")]
    [Address(RVA = "0x60B2E0", Offset = "0x60A0E0", VA = "0x1060B2E0")]
    public void SetDeleteAnimFlag()
    {
    }

    [Token(Token = "0x6009E1D")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public GachaResultBonusIconParam()
    {
    }
  }
}
