// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawDisassemblyEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002984")]
  [AddComponentMenu("UI/Rune/RuneDrawDisassemblyEffect")]
  public class RuneDrawDisassemblyEffect : MonoBehaviour
  {
    [Token(Token = "0x400C879")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray[] mTitleImage;
    [Token(Token = "0x400C87A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x400C87B")]
    [FieldOffset(Offset = "0x14")]
    private readonly string AnimatorTrigger;
    [Token(Token = "0x400C87C")]
    [FieldOffset(Offset = "0x18")]
    private ReqRuneDisassembly.Response.Result mResult;

    [Token(Token = "0x600BC1F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC20")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x600BC21")]
    [Address(RVA = "0x83D470", Offset = "0x83C270", VA = "0x1083D470")]
    public void SetDrawParam(ReqRuneDisassembly.Response.Result result)
    {
    }

    [Token(Token = "0x600BC22")]
    [Address(RVA = "0x83D370", Offset = "0x83C170", VA = "0x1083D370")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC23")]
    [Address(RVA = "0x83D490", Offset = "0x83C290", VA = "0x1083D490")]
    public RuneDrawDisassemblyEffect()
    {
    }
  }
}
