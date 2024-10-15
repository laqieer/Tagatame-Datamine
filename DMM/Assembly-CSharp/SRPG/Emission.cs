// Decompiled with JetBrains decompiler
// Type: SRPG.Emission
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002346")]
  [AddComponentMenu("UI/Emission")]
  public class Emission : MonoBehaviour
  {
    [Token(Token = "0x4009DEC")]
    [FieldOffset(Offset = "0xC")]
    public AnimationCurve AnimationCurve;
    [Token(Token = "0x4009DED")]
    [FieldOffset(Offset = "0x10")]
    public float Delay;
    [Token(Token = "0x4009DEE")]
    [FieldOffset(Offset = "0x14")]
    public float Duration;
    [Token(Token = "0x4009DEF")]
    [FieldOffset(Offset = "0x18")]
    public Image Image;
    [Token(Token = "0x4009DF0")]
    [FieldOffset(Offset = "0x1C")]
    private float m_Factor;
    [Token(Token = "0x4009DF1")]
    [FieldOffset(Offset = "0x20")]
    private float m_Time;

    [Token(Token = "0x6009801")]
    [Address(RVA = "0x5AA4A0", Offset = "0x5A92A0", VA = "0x105AA4A0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009802")]
    [Address(RVA = "0x5AA630", Offset = "0x5A9430", VA = "0x105AA630")]
    public Emission()
    {
    }
  }
}
