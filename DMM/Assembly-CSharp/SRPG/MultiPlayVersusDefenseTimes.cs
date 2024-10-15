// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayVersusDefenseTimes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002791")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/MultiPlayVersusDefenseTimes")]
  public class MultiPlayVersusDefenseTimes : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BADD")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x400BADE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text DefenseCountText;
    [Token(Token = "0x400BADF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform IconHolder;
    [Token(Token = "0x400BAE0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ItemIcon;
    [Token(Token = "0x400BAE1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject CoinIcon;
    [Token(Token = "0x400BAE2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject GoldIcon;
    [Token(Token = "0x400BAE3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ArenaCoinIcon;

    [Token(Token = "0x600B184")]
    [Address(RVA = "0x759830", Offset = "0x758630", VA = "0x10759830", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B185")]
    [Address(RVA = "0x759850", Offset = "0x758650", VA = "0x10759850")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B186")]
    [Address(RVA = "0x759980", Offset = "0x758780", VA = "0x10759980")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B187")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiPlayVersusDefenseTimes()
    {
    }
  }
}
