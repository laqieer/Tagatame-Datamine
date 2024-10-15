// Decompiled with JetBrains decompiler
// Type: SRPG.TowerUnitIsDead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B6B")]
  [AddComponentMenu("UI/TowerUnitIsDead")]
  public class TowerUnitIsDead : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x400D4A2")]
    [FieldOffset(Offset = "0xC")]
    public GameObject dead;
    [Token(Token = "0x400D4A3")]
    [FieldOffset(Offset = "0x10")]
    public GameObject target;
    [Token(Token = "0x400D4A4")]
    [FieldOffset(Offset = "0x14")]
    public CanvasGroup canvas_group;

    [Token(Token = "0x600C6F5")]
    [Address(RVA = "0x8F9770", Offset = "0x8F8570", VA = "0x108F9770")]
    private void Start()
    {
    }

    [Token(Token = "0x600C6F6")]
    [Address(RVA = "0x8F9770", Offset = "0x8F8570", VA = "0x108F9770", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x600C6F7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TowerUnitIsDead()
    {
    }
  }
}
