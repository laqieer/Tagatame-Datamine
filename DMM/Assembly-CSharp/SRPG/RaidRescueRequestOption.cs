// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRescueRequestOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028ED")]
  [FlowNode.Pin(101, "Finish", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Set", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Raid/RaidRescueRequestOption")]
  public class RaidRescueRequestOption : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C4C6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Toggle mGuild;
    [Token(Token = "0x400C4C7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Toggle mFriend;
    [Token(Token = "0x400C4C8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Toggle mAll;

    [Token(Token = "0x600B93A")]
    [Address(RVA = "0x806390", Offset = "0x805190", VA = "0x10806390")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B93B")]
    [Address(RVA = "0x8062F0", Offset = "0x8050F0", VA = "0x108062F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B93C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidRescueRequestOption()
    {
    }
  }
}
