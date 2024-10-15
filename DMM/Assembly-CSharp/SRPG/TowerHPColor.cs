// Decompiled with JetBrains decompiler
// Type: SRPG.TowerHPColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B3F")]
  [AddComponentMenu("UI/TowerHPColor")]
  public class TowerHPColor : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x400D34B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x400D34C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Sprite ColorBlue;
    [Token(Token = "0x400D34D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Sprite ColorGreen;
    [Token(Token = "0x400D34E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Sprite ColorRed;
    [Token(Token = "0x400D34F")]
    private const float BorderGreen = 1f;
    [Token(Token = "0x400D350")]
    private const float BorderRed = 0.2f;

    [Token(Token = "0x600C5EB")]
    [Address(RVA = "0x8E7410", Offset = "0x8E6210", VA = "0x108E7410", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600C5EC")]
    [Address(RVA = "0x8E73A0", Offset = "0x8E61A0", VA = "0x108E73A0")]
    public void ChangeValue(int hp, int max_hp)
    {
    }

    [Token(Token = "0x600C5ED")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerHPColor()
    {
    }
  }
}
