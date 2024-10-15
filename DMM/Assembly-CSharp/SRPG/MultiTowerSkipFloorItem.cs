// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerSkipFloorItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002725")]
  [AddComponentMenu("UI/Multi/MultiTower/MultiTowerSkipFloorItem")]
  public class MultiTowerSkipFloorItem : MonoBehaviour
  {
    [Token(Token = "0x400B87A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextValue;
    [Token(Token = "0x400B87B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SRPG_Button SelectBtn;
    [Token(Token = "0x400B87C")]
    [FieldOffset(Offset = "0x14")]
    [HideInInspector]
    public int Floor;

    [Token(Token = "0x600AF83")]
    [Address(RVA = "0x739320", Offset = "0x738120", VA = "0x10739320")]
    public void SetItem(int floor, UnityAction action)
    {
    }

    [Token(Token = "0x600AF84")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiTowerSkipFloorItem()
    {
    }
  }
}
