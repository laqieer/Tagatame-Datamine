// Decompiled with JetBrains decompiler
// Type: SRPG.VersusUnknownEnemy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002763")]
  [FlowNode.Pin(1, "Unknown", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Reset", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(100, "Finish", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("UI/Multi/Versus/VersusUnknownEnemy")]
  public class VersusUnknownEnemy : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BA3A")]
    [FieldOffset(Offset = "0xC")]
    public RawImage_Transparent EnemyImage;
    [Token(Token = "0x400BA3B")]
    [FieldOffset(Offset = "0x10")]
    public GameObject UnknownObj;

    [Token(Token = "0x600B0C1")]
    [Address(RVA = "0x7565D0", Offset = "0x7553D0", VA = "0x107565D0")]
    private void RefreshUnknow()
    {
    }

    [Token(Token = "0x600B0C2")]
    [Address(RVA = "0x756510", Offset = "0x755310", VA = "0x10756510")]
    private void RefreshReset()
    {
    }

    [Token(Token = "0x600B0C3")]
    [Address(RVA = "0x756370", Offset = "0x755170", VA = "0x10756370", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B0C4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusUnknownEnemy()
    {
    }
  }
}
