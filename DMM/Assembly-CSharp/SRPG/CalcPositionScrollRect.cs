// Decompiled with JetBrains decompiler
// Type: SRPG.CalcPositionScrollRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200211B")]
  [AddComponentMenu("UI/CalcPositionScrollRect")]
  public class CalcPositionScrollRect : MonoBehaviour
  {
    [Token(Token = "0x4008F94")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ItemContainer;
    [Token(Token = "0x4008F95")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ScrollRect ScrollRectObj;
    [Token(Token = "0x4008F96")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float ScrollRate;

    [Token(Token = "0x6008AB4")]
    [Address(RVA = "0x4E4CE0", Offset = "0x4E3AE0", VA = "0x104E4CE0")]
    public float CalcScrollRectPos(int nodeIndex) => new float();

    [Token(Token = "0x6008AB5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CalcPositionScrollRect()
    {
    }
  }
}
