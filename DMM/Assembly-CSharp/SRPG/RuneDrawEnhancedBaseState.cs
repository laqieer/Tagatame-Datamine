// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawEnhancedBaseState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002989")]
  [AddComponentMenu("UI/Rune/RuneDrawEnhancedBaseState")]
  public class RuneDrawEnhancedBaseState : MonoBehaviour
  {
    [Token(Token = "0x400C897")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private StatusList mBaseStatusBefore;
    [Token(Token = "0x400C898")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private StatusList mBaseStatusAfter;
    [Token(Token = "0x400C899")]
    [FieldOffset(Offset = "0x14")]
    private BindRuneData mRuneDataBefore;
    [Token(Token = "0x400C89A")]
    [FieldOffset(Offset = "0x18")]
    private BindRuneData mRuneDataAfter;

    [Token(Token = "0x600BC30")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BC31")]
    [Address(RVA = "0x83E8D0", Offset = "0x83D6D0", VA = "0x1083E8D0")]
    public void SetDrawParam(BindRuneData before, BindRuneData after)
    {
    }

    [Token(Token = "0x600BC32")]
    [Address(RVA = "0x83E6D0", Offset = "0x83D4D0", VA = "0x1083E6D0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC33")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneDrawEnhancedBaseState()
    {
    }
  }
}
