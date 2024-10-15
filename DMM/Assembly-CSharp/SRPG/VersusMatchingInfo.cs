// Decompiled with JetBrains decompiler
// Type: SRPG.VersusMatchingInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200274E")]
  [AddComponentMenu("UI/Multi/Versus/VersusMatchingInfo")]
  [FlowNode.Pin(1, "Matching", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "DraftMatching", FlowNode.PinTypes.Input, 2)]
  public class VersusMatchingInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x600B060")]
    [Address(RVA = "0x7502C0", Offset = "0x74F0C0", VA = "0x107502C0")]
    public void Start()
    {
    }

    [Token(Token = "0x600B061")]
    [Address(RVA = "0x7501E0", Offset = "0x74EFE0", VA = "0x107501E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B062")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusMatchingInfo()
    {
    }
  }
}
