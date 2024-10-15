// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideBoardOpenAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A03")]
  public class RunePrideBoardOpenAnimator : MonoBehaviour
  {
    [Token(Token = "0x400CC25")]
    [FieldOffset(Offset = "0xC")]
    private Action animationFinishCallback;

    [Token(Token = "0x600BF7C")]
    [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
    public void Initialize(Action animationFinishCallback)
    {
    }

    [Token(Token = "0x600BF7D")]
    [Address(RVA = "0x87EC60", Offset = "0x87DA60", VA = "0x1087EC60")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BF7E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RunePrideBoardOpenAnimator()
    {
    }
  }
}
