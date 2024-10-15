// Decompiled with JetBrains decompiler
// Type: SRPG.HpBarSlider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002643")]
  [AddComponentMenu("UI/HpBarSlider")]
  public class HpBarSlider : MonoBehaviour
  {
    [Token(Token = "0x400B2BD")]
    [FieldOffset(Offset = "0xC")]
    public Slider slider;
    [Token(Token = "0x400B2BE")]
    [FieldOffset(Offset = "0x10")]
    public TowerHPColor color;

    [Token(Token = "0x600AACE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HpBarSlider()
    {
    }
  }
}
