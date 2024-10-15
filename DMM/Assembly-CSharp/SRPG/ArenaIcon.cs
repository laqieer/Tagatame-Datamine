// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FD8")]
  [AddComponentMenu("UI/ArenaIcon")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  public class ArenaIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008706")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x4008707")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Badge;

    [Token(Token = "0x6008326")]
    [Address(RVA = "0x438D70", Offset = "0x437B70", VA = "0x10438D70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008327")]
    [Address(RVA = "0x438E10", Offset = "0x437C10", VA = "0x10438E10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008328")]
    [Address(RVA = "0x438EB0", Offset = "0x437CB0", VA = "0x10438EB0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008329")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ArenaIcon()
    {
    }
  }
}
