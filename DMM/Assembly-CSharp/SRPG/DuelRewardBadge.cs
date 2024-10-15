// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRewardBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002337")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/Duel/DuelRewardBadge")]
  public class DuelRewardBadge : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009D95")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x4009D96")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Badge;

    [Token(Token = "0x600979C")]
    [Address(RVA = "0x5A0D60", Offset = "0x59FB60", VA = "0x105A0D60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600979D")]
    [Address(RVA = "0x5A0E00", Offset = "0x59FC00", VA = "0x105A0E00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600979E")]
    [Address(RVA = "0x5A0EA0", Offset = "0x59FCA0", VA = "0x105A0EA0")]
    private void Update()
    {
    }

    [Token(Token = "0x600979F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelRewardBadge()
    {
    }
  }
}
