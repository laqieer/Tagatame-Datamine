// Decompiled with JetBrains decompiler
// Type: SRPG.TowerPartyHP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B46")]
  [AddComponentMenu("UI/TowerPartyHP")]
  public class TowerPartyHP : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x400D39C")]
    [FieldOffset(Offset = "0xC")]
    public Slider mSlider;

    [Token(Token = "0x600C61E")]
    [Address(RVA = "0x8EA7D0", Offset = "0x8E95D0", VA = "0x108EA7D0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C61F")]
    [Address(RVA = "0x8EA7D0", Offset = "0x8E95D0", VA = "0x108EA7D0", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600C620")]
    [Address(RVA = "0x8EA4A0", Offset = "0x8E92A0", VA = "0x108EA4A0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C621")]
    [Address(RVA = "0x8EA710", Offset = "0x8E9510", VA = "0x108EA710")]
    private void SetSliderValue(int value, int maxValue)
    {
    }

    [Token(Token = "0x600C622")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerPartyHP()
    {
    }
  }
}
