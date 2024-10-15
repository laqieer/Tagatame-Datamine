// Decompiled with JetBrains decompiler
// Type: SRPG.DirectionArrow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022F3")]
  [AddComponentMenu("UI/DirectionArrow")]
  public class DirectionArrow : MonoBehaviour
  {
    [Token(Token = "0x4009BC4")]
    [FieldOffset(Offset = "0xC")]
    public DirectionArrow.ArrowStates State;
    [Token(Token = "0x4009BC5")]
    [FieldOffset(Offset = "0x10")]
    public EUnitDirection Direction;
    [Token(Token = "0x4009BC6")]
    [FieldOffset(Offset = "0x14")]
    private Animator mAnimator;
    [Token(Token = "0x4009BC7")]
    [FieldOffset(Offset = "0x18")]
    [HelpBox("方向の選択状態にあわせてAnimatorのStateNameを変更します (0=Normal,1=Press,2=Hilit,3=Close)。矢印はアニメーションが停止したら破棄されるので、PressとClose状態以外はループアニメーションにしてください。")]
    public string StateName;

    [Token(Token = "0x600963F")]
    [Address(RVA = "0x58FBF0", Offset = "0x58E9F0", VA = "0x1058FBF0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009640")]
    [Address(RVA = "0x58FC40", Offset = "0x58EA40", VA = "0x1058FC40")]
    private void Update()
    {
    }

    [Token(Token = "0x6009641")]
    [Address(RVA = "0x58FDA0", Offset = "0x58EBA0", VA = "0x1058FDA0")]
    public DirectionArrow()
    {
    }

    [Token(Token = "0x20022F4")]
    public enum ArrowStates
    {
      [Token(Token = "0x4009BC9")] Normal,
      [Token(Token = "0x4009BCA")] Press,
      [Token(Token = "0x4009BCB")] Hilit,
      [Token(Token = "0x4009BCC")] Close,
    }
  }
}
