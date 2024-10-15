// Decompiled with JetBrains decompiler
// Type: SRPG.GachaResultBonusIconNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002440")]
  public class GachaResultBonusIconNode : ContentNode
  {
    [Token(Token = "0x400A445")]
    [FieldOffset(Offset = "0x30")]
    private Animator mAnimator;

    [Token(Token = "0x6009E1E")]
    [Address(RVA = "0x60AE20", Offset = "0x609C20", VA = "0x1060AE20")]
    public void Setup(
      GachaDropData _data,
      GachaResultThumbnailWindow _window,
      bool _is_delete_anim)
    {
    }

    [Token(Token = "0x6009E1F")]
    [Address(RVA = "0x60AF10", Offset = "0x609D10", VA = "0x1060AF10")]
    public void StartAnim()
    {
    }

    [Token(Token = "0x6009E20")]
    [Address(RVA = "0x60AD40", Offset = "0x609B40", VA = "0x1060AD40")]
    public void DeleteAnim()
    {
    }

    [Token(Token = "0x6009E21")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public GachaResultBonusIconNode()
    {
    }
  }
}
